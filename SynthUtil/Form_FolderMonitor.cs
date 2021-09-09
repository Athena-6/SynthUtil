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
    public partial class Form_FolderMonitor : Form
    {
        //PathIn
        public string PathIn;
        public int totalFiles;
        private int countFilesExisting;
        private int countFilesNew;

        EtcCalculator timer;
        FileSystemWatcher watcher;

        public Form_FolderMonitor()
        {
            InitializeComponent();
        }

        public void SetPaths(string srPath, string srFiles)
        {
            PathIn = srPath;
            totalFiles = Convert.ToInt32(srFiles);
        }

        private void Form_FolderMonitor_Shown(object sender, EventArgs e)
        {
            textBox_t4.Text = PathIn;

            //Count Initial Files
            countFilesExisting = Directory.EnumerateFiles(PathIn, "*.*", SearchOption.AllDirectories).Count();

            //Initialize timer for time estimate
            timer = new EtcCalculator(totalFiles - countFilesExisting);

            //Initialize UI
            label_timelabel.Text = "";
            label_timedata.Text = "";
            label_durationdata.Text = "";
            label_progLeft.Text = "";
            label_progRight.Text = "";
            label_timelabel.Visible = true;
            label_timedata.Visible = true;
            label_durationdata.Visible = true;
            label_progLeft.Visible = true;
            label_progRight.Visible = true;

            MonitorDirectory(PathIn);
        }

        private void MonitorDirectory(string path)
        {
            watcher = new FileSystemWatcher();
            watcher.Path = path;
            watcher.IncludeSubdirectories = true;
            watcher.NotifyFilter = NotifyFilters.Attributes |
                                    NotifyFilters.CreationTime |
                                    NotifyFilters.FileName |
                                    NotifyFilters.LastAccess |
                                    NotifyFilters.LastWrite |
                                    NotifyFilters.Size |
                                    NotifyFilters.Security;
            watcher.Filter = "*.*";
            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.EnableRaisingEvents = true;
        }

        private void OnChanged(object source, FileSystemEventArgs e)
        {
            countFilesNew++;

            int currentFiles = countFilesExisting + countFilesNew;
            int percentage = ProgramTools.IntToPerc(currentFiles, totalFiles);

            //Console.WriteLine("File created: {0}", e.Name);

            //Report EST time (converted)
            string estTime = ProgramTools.TimeConvertHM(timer.GetEtc(countFilesNew));
            string estDuration = ProgramTools.TimeConvertDuration(timer.GetEtc(countFilesNew));

            //Terminate if finished
            if (percentage >= 100)
            {
                watcher.Dispose();
                MessageBox.Show("Process Complete - File number met or exceeded preset target");
                //Push
                this.Invoke(new Action(
                delegate ()
                {
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }));
                return;
            }

            //Push
            this.Invoke(new Action(
            delegate ()
            {
                label_progLeft.Text = "Files: " + currentFiles + @"/" + totalFiles;
                label_progRight.Text = "Percentage: " + percentage + "%";
                progressBar1.Value = percentage;
                //Update Time Labels
                label_timelabel.Text = "Estimated time to completion:";
                label_timedata.Text = estTime;
                label_durationdata.Text = estDuration;
                this.Update();
            }));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            watcher.Dispose();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }


    }
}
