using NAudio.Dsp;
using NAudio.Wave;
using Spectrogram;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SynthUtil
{
    public partial class Form_AudioProcess : Form
    {
        //Direct Paths
        public string SourcePath;
        public string OutputPath;

        //Global Lists
        private List<string> getFiles = new List<string>();
        private List<string> getDirectory = new List<string>();
        private List<string> getFilesNoExt = new List<string>();

        //Advanced Lists
        private List<string> calcFileMinusSourceFolder = new List<string>();
        private List<string> calcOutputFile = new List<string>();

        public Form_AudioProcess()
        {
            InitializeComponent();
        }

        private void Form_AudioProcess_Load(object sender, EventArgs e)
        {

        }

        public void SetPaths(string srPath, string outPath)
        {
            SourcePath = srPath;
            OutputPath = outPath;
        }

        private void Form_AudioProcess_Shown(object sender, EventArgs e)
        {
            Application.DoEvents();

            //Initialize
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            //Run Worker1 after delay
            ProgramTools.Delayed(350, () => backgroundWorker1_Indexing.RunWorkerAsync());
        }

        private void backgroundWorker1_Indexing_DoWork(object sender, DoWorkEventArgs e)
        {
            string[] files = Directory.GetFiles(SourcePath, "*.wav", SearchOption.AllDirectories);

            int filesIndex = 0;

            foreach (string arrItem in files)
            {
                getFiles.Add(arrItem);
                getDirectory.Add(Path.GetDirectoryName(arrItem));
                getFilesNoExt.Add(Path.GetFileNameWithoutExtension(arrItem));

                //Calculate Substring for calcFileMinusSourceFolder list
                string subtractedFilePath = arrItem.Replace(SourcePath, "");
                calcFileMinusSourceFolder.Add(subtractedFilePath);

                //Calculate full ouput file and path
                string outFullPath = OutputPath + subtractedFilePath;
                calcOutputFile.Add(outFullPath);

                filesIndex++;
                int percentage = ProgramTools.IntToPerc(filesIndex, files.Length);
                backgroundWorker1_Indexing.ReportProgress(percentage);
            }
        }

        private void backgroundWorker1_Indexing_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            label_pg1.Text = e.ProgressPercentage + "%";
            label_proc1.Text = "Indexing (Fast Mode)...";
            label_proc1.Visible = true;
            this.Update();
        }

        private void backgroundWorker1_Indexing_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar1.Value = progressBar1.Maximum;
            label_pg1.Text = 100 + @"%";
            this.Update();

            if (getFiles.Count >= 1)
            {
                label_proc1.Text = "Indexing Complete";
                textboxPath.ForeColor = Color.DarkGreen;
                textboxPath.Text = "Indexing complete, .wav files found: " + getFiles.Count.ToString();
                this.Update(); 
            }
            else
            {
                MessageBox.Show("No .wav files found in directory", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Closes Dialog
                this.DialogResult = System.Windows.Forms.DialogResult.Abort;
                this.Close();
                return;
            }

            IndexCompleted_DoProcessing();
        }

        private void IndexCompleted_DoProcessing()
        {
            //Enable Abort Button
            button_abort.Enabled = true;
            //Run Worker2 after delay
            ProgramTools.Delayed(350, () => backgroundWorker2_Processing.RunWorkerAsync());
        }

        private void backgroundWorker2_Processing_DoWork(object sender, DoWorkEventArgs e)
        {
            //Initialize timer for time estimate
            var timer = new EtcCalculator(getFiles.Count - 1);

            for (int i = 0; i < (getFiles.Count); i++)
            {
                string outFullPath = calcOutputFile[i];
                string outFolderPath = Path.GetDirectoryName(outFullPath);

                //Resampling
                int outRate = 16000;
                var inFile = getFiles[i];
                using (var reader = new WaveFileReader(inFile))
                {
                    var outFormat = new WaveFormat(outRate, reader.WaveFormat.Channels);
                    using (var resampler = new MediaFoundationResampler(reader, outFormat))
                    {
                        resampler.ResamplerQuality = 60;
                        Directory.CreateDirectory(outFolderPath);
                        WaveFileWriter.CreateWaveFile(outFullPath, resampler);
                    }
                }


                //Report File Index
                string fileIndex = i.ToString();
                //Report EST time (converted)
                string estTime = ProgramTools.TimeConvertHM(timer.GetEtc(i+1));
                string estDuration = ProgramTools.TimeConvertDuration(timer.GetEtc(i+1));

                //Creates report to userstate
                //Array order: Current Word, Current Line, Changed Lines, Cum Lines, 
                string[] reportStrArr = new string[3] { fileIndex, estTime, estDuration };
                //Reports Progress
                backgroundWorker2_Processing.ReportProgress(0, reportStrArr);
            }
        }

        private void backgroundWorker2_Processing_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //Parse UserState
            string[] us_arr = (string[])e.UserState;
            int fileIndex = Int32.Parse(us_arr[0]);
            string estTime = us_arr[1];
            string estDuration = us_arr[2];

            //Calculates percentage and updates elements
            int percentage = ProgramTools.IntToPerc(fileIndex, getFiles.Count);
            int currentPercentage = progressBar1.Value;

            //Updates bar
            progressBar1.Value = percentage;
            label_pg1.Text = percentage + "%";
            label_pg1.Visible = true;
            label_proc1.Text = "Processing Audio Files... " + fileIndex + @"/" + getFiles.Count;
            label_proc1.Visible = true;

            //Textboxs
            textboxPath.Text = getFiles[fileIndex];
            //Track to end of textbox
            textboxPath.SelectionStart = textboxPath.Text.Length;
            textboxPath.SelectionLength = 0;

            //Time Estimate
            label_timedata.Text = estTime;
            label_durationdata.Text = estDuration;
            label_timelabel.Visible = true;
            label_durationdata.Visible = true;
            label_timedata.Visible = true;

            //Calc MELS for every percent of progress OR if this is the first run
            if ( (currentPercentage < percentage) || (fileIndex == 0) )
            {
                CalcMELBox1(getFiles[fileIndex]);
                CalcMELBox2(calcOutputFile[fileIndex]);
            }

            this.Update();
        }

        private void backgroundWorker2_Processing_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar1.Value = progressBar1.Maximum;
            label_pg1.Text = 100 + @"%";

            //Time Estimate
            label_timelabel.Visible = false;
            label_timedata.Visible = false;

            //Update UI
            this.Update();

            MessageBox.Show("Processing Complete.", "SynthUtil - Audio Processor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            button_ok.Enabled = true;

        }

        private void CalcMELBox1(string FullPath)
        {
            //Input MEL
            (double[] audio, int sampleRate) = ReadWAV(FullPath);
            var sg = new SpectrogramGenerator(sampleRate, fftSize: 4096, stepSize: 500, maxFreq: 3000);
            sg.Add(audio);
            pictureBox1.Image = sg.GetBitmap();
        }

        private void CalcMELBox2(string FullPath)
        {
            //Output MEL
            (double[] audio, int sampleRate) = ReadWAV(FullPath);
            var sg = new SpectrogramGenerator(sampleRate, fftSize: 4096, stepSize: 500, maxFreq: 3000);
            sg.Add(audio);
            pictureBox2.Image = sg.GetBitmap();
        }

        (double[] audio, int sampleRate) ReadWAV(string filePath, double multiplier = 16_000)
        {
            using var afr = new NAudio.Wave.AudioFileReader(filePath);
            int sampleRate = afr.WaveFormat.SampleRate;
            int sampleCount = (int)(afr.Length / afr.WaveFormat.BitsPerSample / 8);
            int channelCount = afr.WaveFormat.Channels;
            var audio = new List<double>(sampleCount);
            var buffer = new float[sampleRate * channelCount];
            int samplesRead = 0;
            while ((samplesRead = afr.Read(buffer, 0, buffer.Length)) > 0)
                audio.AddRange(buffer.Take(samplesRead).Select(x => x * multiplier));
            return (audio.ToArray(), sampleRate);
        }

        private void button_abort_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Operation Aborted", "SynthUtil - Audio Processor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //Closes Dialog
            this.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.Close();
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}
