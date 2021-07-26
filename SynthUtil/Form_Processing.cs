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

        public Form_Processing()
        {
            InitializeComponent();
        }

        private void Form_Processing_Load(object sender, EventArgs e)
        {
            //Initialize textbox for output of console
            //TextBoxWriter writer = new TextBoxWriter(textBox1);
            //Console.SetOut(writer);
        }

        private void Form_Processing_Shown(object sender, EventArgs e)
        {
            Application.DoEvents();

            try
            {
                //Read temp
                dataSource.Clear();
                dataSource = ProgramTools.ReadTempCSV().Copy();
            }
            catch (Exception ex1)
            {
                MessageBox.Show("Error reading data for processing: " + ex1, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CSVProcessingMasterControl(dataSource);
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

        private void CSVProcessingMasterControl(DataTable inputDT)
        {
            if (Properties.Settings.Default.t2ck_CustomWordReplace)
            {
                //Attempt to read WordReplace.csv to local DataTable
                if(ReadWordReplacements() == 1)
                {
                    label_pg1.Text = "";
                    label_pg2.Text = "";
                    label_proc1.Text = "";
                    label_proc1b.Text = "";
                    label_proc2.Text = "";
                    label_pg1.Visible = true;
                    label_pg2.Visible = true;
                    label_proc1.Visible = true;
                    label_proc1b.Visible = true;
                    label_proc2.Visible = true;

                    //Delayed Start
                    ProgramTools.Delayed(250, () => backgroundWorker1.RunWorkerAsync());
                }
            }

            if (Properties.Settings.Default.t2ck_SortVoiceID)
            {
                //Sorts table

                label_pg1.Text = "";
                label_pg2.Text = "";
                label_proc1.Text = "";
                label_proc1b.Text = "";
                label_proc2.Text = "";
                label_pg1.Visible = false;
                label_pg2.Visible = false;
                label_proc1.Visible = false;
                label_proc1b.Visible = false;
                label_proc2.Visible = false;

                this.Cursor = Cursors.WaitCursor;
                this.Update();

                dataSource.DefaultView.Sort = "voice_id";
                dataSource = dataSource.DefaultView.ToTable();
                ProgramTools.WriteTempCSV(dataSource);

                this.Cursor = Cursors.Default;
                this.Update();

                button_ok.Enabled = true;
                MessageBox.Show("Operations Complete!");
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //Count of Word Replacement words completed
            int countWR = 0;
            //Count of Lines processed per replacement word
            int countLinesProcessed = 0;
            //Count of Lines actually changed
            int countLinesChanged = 0;
            //Count of cumulative lines
            int countLinesCumulative = 0;


            //Reset countLinesProcessed and countLinesChanged
            countLinesProcessed = 0;
            countLinesChanged = 0;

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

                countLinesCumulative++;
                countLinesProcessed++;

                //If line changed, increment countLinesChanged
                string changed = drRow["text"].ToString();
                if (!(string.Equals(initial, changed)))
                {
                    countLinesChanged++;
                }

                //Creates report to userstate
                int[] reportStrArr;
                //Array order: Current Word, Current Line, Changed Lines, Cum Lines, 
                reportStrArr = new int[4] { countWR, countLinesProcessed, countLinesChanged, countLinesCumulative };

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
            int totalLinesXWords = dataSource.Rows.Count * wrData.Rows.Count;

            //Parse UserState
            int[] us_arr = (int[])e.UserState;
            int countWR = us_arr[0];
            int countLinesProcessed = us_arr[1];
            int countLinesChanged = us_arr[2];
            int countLinesCumulative = us_arr[3];

            //Calculate percentages
            int percent1 = ProgramTools.IntToPerc(countLinesProcessed, totalLines);
            int percent2 = ProgramTools.IntToPerc(countWR, totalModWords);

            progressBar1.Value = percent1;
            progressBar2.Value = percent2;
            label_proc1.Text = "Processing Line " + countLinesProcessed + @"/" + totalLines;
            label_proc1b.Text = "Modified Lines: " + countLinesChanged;
            label_pg1.Text = percent1.ToString() + @"%";
            label_proc2.Text = "Processing Word Replacements...";
            label_pg2.Text = countWR + @"/" + totalModWords;
            this.Update();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar1.Value = 100;
            progressBar2.Value = 100;
            label_pg1.Text = 100 + @"%";
            label_pg2.Text = (wrData.Rows.Count) + @"/" + (wrData.Rows.Count);
            this.Update();

            ProgramTools.WriteTempCSV(dataSource);

            button_ok.Enabled = true;
            MessageBox.Show("Operations Complete!");
            //Delayed Start
            //ProgramTools.Delayed(250, () => MessageBox.Show("Complete!"));
        }
    }

    class TextBoxWriter : TextWriter
    {
        // The control where we will write text.
        private Control MyControl;
        public TextBoxWriter(Control control)
        {
            MyControl = control;
        }

        public override void Write(char value)
        {
            MyControl.Text += value;
        }

        public override void Write(string value)
        {
            MyControl.Text += value;
        }

        public override Encoding Encoding
        {
            get { return Encoding.Unicode; }
        }
    }
}
