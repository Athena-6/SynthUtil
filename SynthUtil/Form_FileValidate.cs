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
    public partial class Form_FileValidate : Form
    {
        public int countWav = 0;
        public int countLip = 0;
        public int countLipExists = 0;
        private String fdPath;

        private List<string> wav_getFiles = new List<string>();
        private List<string> wav_getDirectory = new List<string>();
        private List<string> wav_getFilesNoExt = new List<string>();

        private List<string> lip_getFiles = new List<string>();
        private List<string> lip_getDirectory = new List<string>();
        private List<string> lip_getFilesNoExt = new List<string>();

        public Form_FileValidate()
        {
            InitializeComponent();
        }

        public void Form2_Shown(object sender, EventArgs e)
        {
            Application.DoEvents();
            doFileValidate();
        }

        public void setFolderPath(String folderPath)
        {
            //set internal variable for path
            fdPath = folderPath;
        }

        private void ClearLists()
        {
            wav_getFiles.Clear();
            wav_getDirectory.Clear();
            wav_getFilesNoExt.Clear();
            lip_getFiles.Clear();
            lip_getDirectory.Clear();
            lip_getFilesNoExt.Clear();
        }

        public void doFileValidate()
        {
            //reset values
            countWav = 0;
            countLip = 0;
            progressBar1.Value = 0;
            progressBar2.Value = 0;
            label_wav.Text = ".wav files: 0";
            label_lip.Text = ".lip files: 0";
            label_wav.Visible = true;
            label_lip.Visible = true;
            label_v.Visible = false;

            //reset lists
            ClearLists();

            //start work
            backgroundWorker1.RunWorkerAsync();
        }

        public void doFileValidate2()
        {
            //start work
            backgroundWorker2.RunWorkerAsync();
        }

        public void doFileValidate3()
        {
            //Label visible
            label_v.Visible = true;
            //start work
            backgroundWorker3.RunWorkerAsync();
        }

        private void label1Update()
        {
            label_wav.Text = countWav.ToString();
        }

        private void label2Update()
        {
            label_lip.Text = countLip.ToString();
        }

        private void finishedCallF1() {

            if (countLipExists == wav_getFilesNoExt.Count)
            {
                textBox1.Text = "Validation Successful. " + wav_getFilesNoExt.Count + " .wav files with accompanying .lip files found.";
            }
            else if (countLipExists < wav_getFiles.Count)
            {
                textBox1.Text = "Validation Failed. Check output. " + wav_getFilesNoExt.Count + " .wav files with " + countLipExists + " accompanying .lip files found.";
            }

            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(500);

            string[] files =
                Directory.GetFiles(fdPath, "*.wav", SearchOption.AllDirectories);

            int filesIndex = 0;

            foreach (string arrItem in files)
            {
                wav_getFiles.Add(arrItem);
                wav_getDirectory.Add(Path.GetDirectoryName(arrItem));
                wav_getFilesNoExt.Add(Path.GetFileNameWithoutExtension(arrItem));
                filesIndex++;
                int percentage = ProgramTools.IntToPerc(filesIndex, files.Length);
                backgroundWorker1.ReportProgress(percentage, filesIndex);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            countWav = (int) e.UserState;
            label_wav.Text = ".wav files: " + countWav.ToString();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            doFileValidate2();
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(500);

            string[] files =
                Directory.GetFiles(fdPath, "*.lip", SearchOption.AllDirectories);

            int filesIndex = 0;

            foreach (string arrItem in files)
            {
                lip_getFiles.Add(arrItem);
                lip_getDirectory.Add(Path.GetDirectoryName(arrItem));
                lip_getFilesNoExt.Add(Path.GetFileNameWithoutExtension(arrItem));
                filesIndex++;
                int percentage = ProgramTools.IntToPerc(filesIndex, files.Length);
                backgroundWorker2.ReportProgress(percentage, filesIndex);
            }
        }

        private void backgroundWorker2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar2.Value = e.ProgressPercentage;
            countLip = (int) e.UserState;
            label_lip.Text = ".lip files: " + countLip.ToString();
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            doFileValidate3();
        }

        private void backgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(500);

            int filesIndex = 0;
            int lipExists = 0;

            foreach (string arrItem in wav_getFilesNoExt)
            {
                if(lip_getFilesNoExt.Contains(arrItem))
                {
                    lipExists++;
                }
                filesIndex++;
                int percentage = ProgramTools.IntToPerc(filesIndex, wav_getFilesNoExt.Count);
                backgroundWorker3.ReportProgress(percentage);
            }

            countLipExists = lipExists;
        }

        private void backgroundWorker3_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar3.Value = e.ProgressPercentage;
        }

        private void backgroundWorker3_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            finishedCallF1();
        }
    }
}
