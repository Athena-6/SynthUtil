using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SynthUtil
{
    public partial class Form_AudioProcess : Form
    {
        //Paths
        public string SourcePath;
        public string OutputPath;

        //Global Lists
        private List<string> getFiles = new List<string>();
        private List<string> getDirectory = new List<string>();
        private List<string> getFilesNoExt = new List<string>();

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

            //Run Worker1
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            string[] files = Directory.GetFiles(SourcePath, "*.wav", SearchOption.AllDirectories);

            int filesIndex = 0;

            foreach (string arrItem in files)
            {
                getFiles.Add(arrItem);
                getDirectory.Add(Path.GetDirectoryName(arrItem));
                getFilesNoExt.Add(Path.GetFileNameWithoutExtension(arrItem));
                filesIndex++;
                int percentage = ProgramTools.IntToPerc(filesIndex, files.Length);
                backgroundWorker1.ReportProgress(percentage);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            label_pg1.Text = e.ProgressPercentage + "%";
            this.Update();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (getFiles.Count >= 1)
            {
                //stage2confirm = true;
                //StateUpdate();
                //button3.Enabled = true;
                //textboxConfirm.ForeColor = Color.DarkGreen;
                //textboxConfirm.Text = "Confirmed | .wav files found: " + getFiles.Count.ToString();
                MessageBox.Show("OK", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //stage2confirm = false;
                //StateUpdate();
                MessageBox.Show("No .wav files found in directory", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
    }
}
