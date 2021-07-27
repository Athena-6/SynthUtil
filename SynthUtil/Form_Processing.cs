using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static SynthUtil.ProgramTools;

namespace SynthUtil
{
    public partial class Form_Processing : Form
    {
        //Source to do processing from
        public DataTable dataSource = new DataTable();
        //Word replacement data form from WordReplace.csv
        private DataTable wrData = new DataTable();

        //Record of operations completed
        private bool Opr1;
        private bool Opr2;

        public Form_Processing()
        {
            InitializeComponent();
        }

        private void Form_Processing_Load(object sender, EventArgs e)
        {
            //Do Stuff
        }

        private void Form_Processing_Shown(object sender, EventArgs e)
        {
            Application.DoEvents();

            UpdateDataFromTemp();

            CSVProcessingMasterControl();
        }

        private void UpdateDataFromTemp()
        {
            try
            {
                dataSource.Clear();
                dataSource = ProgramTools.ReadTempCSV().Copy();
            }
            catch (Exception ex1)
            {
                MessageBox.Show("Error reading data for processing: " + ex1, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private int ReadWordReplacements()
        {
            //set application directory
            String appPath = Directory.GetCurrentDirectory();
            String csvPath = appPath + @"\WordReplace.csv";

            //Creates object for ReadCSV Class
            ReadCSV csv = new ReadCSV(csvPath);

            try
            {
                //Clears local datatable, populates with result
                wrData.Clear();
                wrData = csv.DT_ReadCSV;
                //Return 1 for successful read
                return 1;
            }
            catch (Exception ex1)
            {
                MessageBox.Show("Error reading WordReplace.csv : " + ex1, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Returning 0 for failed read
                return 0;
            }
        }

        private void CSVProcessingMasterControl()
        {
            if (Properties.Settings.Default.t2ck_CustomWordReplace && !Opr1)
            {
                //Set Flag
                Opr1 = true;

                //Attempt to read WordReplace.csv to local DataTable
                if(ReadWordReplacements() == 1)
                {
                    label_pg1.Text = "";
                    label_timeduration.Text = "";
                    label_proc1.Text = "";
                    label_proc1b.Text = "";
                    label_pg1.Visible = true;
                    label_timeduration.Visible = true;
                    label_proc1.Visible = true;
                    label_proc1b.Visible = true;
                    //Time Labels
                    label_timelabel.Text = "";
                    label_timeduration.Text = "";
                    label_timelabel.Visible = true;
                    label_timeduration.Visible = true;

                    //Delayed Start
                    ProgramTools.Delayed(250, () => backgroundWorker1.RunWorkerAsync());
                    return;
                }
            }

            if (Properties.Settings.Default.t2ck_SortVoiceID && !Opr2)
            {
                //Update Datatable
                UpdateDataFromTemp();
                //Set Flag
                Opr2 = true;

                progressBar1.Value = 0;
                label_proc1.Text = "Sorting data by voice_id...";
                label_proc1.Visible = true;
                label_pg1.Visible = false;
                label_timeduration.Visible = false;
                label_proc1b.Visible = false;

                this.Cursor = Cursors.WaitCursor;
                this.Update();

                dataSource.DefaultView.Sort = "voice_id";
                dataSource = dataSource.DefaultView.ToTable();
                ProgramTools.WriteTempCSV(dataSource);

                this.Cursor = Cursors.Default;
                this.Update();
            }

            label_proc1.Text = "Complete.";
            button_ok.Enabled = true;
            MessageBox.Show("Operations Complete!");
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //Count of Word Replacement words completed
            int countWR = 0;
            //Count of Lines processed per replacement word
            int countLinesProcessed = 0;
            //Count of Lines actually changed
            int countLinesChanged = 0;

            //Initialize timer for time estimate
            var timer = new EtcCalculator(dataSource.Rows.Count - 1);

            //Repeats for every row in dataSource           
            foreach (DataRow drRow in dataSource.Rows)
            {
                //Resets vars
                countWR = 0;
                string initial = drRow["text"].ToString();

                //Repeats for every row in WordReplace.csv
                foreach (DataRow wrRow in wrData.Rows)
                {
                    countWR++;
                    string input = drRow["text"].ToString();
                    string pattern;
                    //Uses regex if not blank
                    if (wrRow["source_regex_override"] != null && !string.IsNullOrEmpty(wrRow["source_regex_override"].ToString()))
                    {
                        pattern = wrRow["source_regex_override"].ToString();
                    }
                    //Use regex-fied source if regex override is blank
                    else
                    {
                        string wr_source = wrRow["source"].ToString();
                        pattern = @"\b" + wr_source + @"\b";
                        //Console.WriteLine("pattern: " + pattern);
                    }
                    string replace = wrRow["change_to"].ToString();
                    string result = Regex.Replace(input, pattern, replace, RegexOptions.IgnoreCase);

                    drRow["text"] = result;
                    //Console.WriteLine("result: " + result);
                }

                countLinesProcessed++;

                //If line changed, increment countLinesChanged
                string changed = drRow["text"].ToString();
                if (!(string.Equals(initial, changed)))
                {
                    countLinesChanged++;
                }

                //Report EST time (converted)
                string estDuration = ProgramTools.TimeConvertDuration(timer.GetEtc(countLinesProcessed + 1));

                //Creates report to userstate
                string[] reportStrArr;
                //Array order: Current Word, Current Line, Changed Lines, Cum Lines, 
                reportStrArr = new string[6] { countWR.ToString(), countLinesProcessed.ToString(), countLinesChanged.ToString(), initial, changed, estDuration };

                backgroundWorker1.ReportProgress(0, reportStrArr);
            }

        }

        private void backgroundWorker1_DoWorkOLD(object sender, DoWorkEventArgs e)
        {
            //Count of Word Replacement words completed
            int countWR = 0;
            //Count of Lines processed per replacement word
            int countLinesProcessed = 0;
            //Count of Lines actually changed
            int countLinesChanged = 0;
            //Count of cumulative lines
            int countLinesCumulative = 0;


            //Repeats for every row in WordReplace.csv
            foreach (DataRow wrRow in wrData.Rows)
            {
                //Reset countLinesProcessed and countLinesChanged
                countLinesProcessed = 0;
                countLinesChanged = 0;
                countWR++;
                //Repeats for every row in dataSource
                foreach (DataRow drRow in dataSource.Rows)
                {
                    // drRow["Comments"] = drRow["Comments"].ToString().Replace('*', '\n');

                    string input = drRow["text"].ToString();
                    string pattern;
                    //Uses regex if not blank
                    if ( wrRow["source_regex_override"] != null && !string.IsNullOrEmpty(wrRow["source_regex_override"].ToString()) )
                    {
                        pattern = wrRow["source_regex_override"].ToString();
                    }
                    //Use regex-fied source if regex override is blank
                    else
                    {
                        string wr_source = wrRow["source"].ToString();
                        pattern = @"\b" + wr_source + @"\b";
                        //Console.WriteLine("pattern: " + pattern);
                    }
                    string replace = wrRow["change_to"].ToString();
                    string result = Regex.Replace(input, pattern, replace, RegexOptions.IgnoreCase);

                    drRow["text"] = result;

                    //Console.WriteLine("result: " + result);

                    //If line changed, increment countLinesChanged
                    if ( !(string.Equals(input, result)) )
                    {
                        countLinesChanged++;
                    }

                    countLinesCumulative++;
                    countLinesProcessed++;

                    //Creates report to userstate
                    int[] reportStrArr;
                    //Array order: Current Word, Current Line, Changed Lines, Cum Lines, 
                    reportStrArr = new int[4] {countWR, countLinesProcessed, countLinesChanged, countLinesCumulative};

                    backgroundWorker1.ReportProgress(0, reportStrArr);
                }
                //Wait for stuff to update
                Thread.Sleep(1000);
            }

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //Statics
            int totalModWords = wrData.Rows.Count;
            int totalLines = dataSource.Rows.Count;

            //Parse UserState
            string[] us_arr = (string[])e.UserState;
            int countWR = Convert.ToInt32(us_arr[0]);
            int countLinesProcessed = Convert.ToInt32(us_arr[1]);
            int countLinesChanged = Convert.ToInt32(us_arr[2]);;
            string InitialLine = us_arr[3];
            string ChangedLine = us_arr[4];
            string estDuration = us_arr[5];

            //Print Lines by Condition if line changed
            //If line changed, increment countLinesChanged
            if (!(string.Equals(InitialLine, ChangedLine)))
            {
                //If Line different
                string printres = string.Format("[Line {0}] [Changed] \"{1}\" -> \"{2}\"", countLinesProcessed, InitialLine, ChangedLine);
                textBox1.AppendText(printres);
                textBox1.AppendText(Environment.NewLine);
            }

            //Calculate percentages for bar 1
            int percent1 = ProgramTools.IntToPerc(countLinesProcessed, totalLines);
            progressBar1.Value = percent1;

            //Time labels
            label_timelabel.Text = "Estimated time to completion:";
            label_timeduration.Text = estDuration;

            //Labels
            label_proc1.Text = "Processing Line " + countLinesProcessed + @"/" + totalLines;
            label_proc1b.Text = "Modified Lines: " + countLinesChanged;
            label_pg1.Text = percent1.ToString() + @"%";
            //label_timeduration.Text = countWR + @"/" + totalModWords;
            this.Update();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar1.Value = 100;
            label_pg1.Text = 100 + @"%";
            label_timeduration.Text = (wrData.Rows.Count) + @"/" + (wrData.Rows.Count);
            this.Update();

            ProgramTools.WriteTempCSV(dataSource);

            CSVProcessingMasterControl();
            //Delayed Start
            //ProgramTools.Delayed(250, () => MessageBox.Show("Complete!"));
        }

    }
}
