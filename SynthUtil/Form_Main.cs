using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using Microsoft.WindowsAPICodePack.Dialogs;
using TagLib.Mpeg;
using SynthUtil.Properties;

namespace SynthUtil
{
    public partial class form_main : Form
    {
        //Tab 1 Stages
        private bool stage1confirm;
        private bool stage2confirm;
        private bool stage3confirm;

        //Tab 1 Button States
        private bool uiStore1;
        private bool uiStore2;
        private bool uiStore3;
        private bool uiStore4;

        //Global Paths
        private string suFolderPath;
        private string suCSVPath;
        private string tbcTextUnconfirmed = "Unconfirmed";

        //Global Lists
        private List<string> getFiles = new List<string>();
        private List<string> getDirectory = new List<string>();
        private List<string> getFilesNoExt = new List<string>();
        private List<int> wavLength = new List<int>();

        //Temp settings (resets on restart)
        public bool setting_Overwrite = false;

        //Tab 2 DataTable
        private DataTable csvData = new DataTable();

        public form_main()
        {
            //set application directory
            String appPath = Directory.GetCurrentDirectory();

            //check .dll exists
            if (!System.IO.File.Exists(appPath + @"\TagLibSharp.dll"))
            {
                MessageBox.Show("Required files not present in app directory: 'TagLibSharp.dll'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            if (!System.IO.File.Exists(appPath + @"\Microsoft.WindowsAPICodePack.dll"))
            {
                MessageBox.Show("Required files not present in app directory: 'Microsoft.WindowsAPICodePack.dll'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            if (!System.IO.File.Exists(appPath + @"\Microsoft.WindowsAPICodePack.Shell.dll"))
            {
                MessageBox.Show("Required files not present in app directory: 'Microsoft.WindowsAPICodePack.Shell.dll'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            InitializeComponent();

            InitializeTasks();
        }

        private void InitializeTasks()
        {
            //For Tab 1
            button2.Enabled = false;
            button3.Enabled = false;
            textboxConfirm.Enabled = false;
            textboxConfirm.Text = tbcTextUnconfirmed;

            //For Tab 2
            //Settings Group 1
            checkedListBoxT2G1.SetItemChecked(0, Properties.Settings.Default.t2ck_DelBetweenSymb);
            checkedListBoxT2G1.SetItemChecked(1, Properties.Settings.Default.t2ck_DelSingleSymb);
            //Settings Group 2
            checkedListBoxT2G2.SetItemChecked(0, Properties.Settings.Default.t2ck_Symb1);
            checkedListBoxT2G2.SetItemChecked(1, Properties.Settings.Default.t2ck_Symb2);
            checkedListBoxT2G2.SetItemChecked(2, Properties.Settings.Default.t2ck_Symb3);
            checkedListBoxT2G2.SetItemChecked(3, Properties.Settings.Default.t2ck_Symb4);
            checkedListBoxT2G2.SetItemChecked(4, Properties.Settings.Default.t2ck_Symb5);
            checkedListBoxT2G2.SetItemChecked(5, Properties.Settings.Default.t2ck_Symb6);
            //Settings Group 3
            checkedListBoxT2G3.SetItemChecked(0, Properties.Settings.Default.t2ck_CustomWordReplace);
            //Settings Group 4
            checkedListBoxT2G4.SetItemChecked(0, Properties.Settings.Default.t2ck_DelEmptyText);
            checkedListBoxT2G4.SetItemChecked(1, Properties.Settings.Default.t2ck_DelEmptyVT);
        }

        private void StateUpdate()
        {
            if(stage1confirm == true)
            {
                button2.Enabled = true;
                textboxConfirm.Enabled = true;
            }
            else
            {
                suFolderPath = null;
                textboxConfirm.Enabled = false;
                textboxConfirm.Text = tbcTextUnconfirmed;
                button2.Enabled = false;
                textboxConfirm.Enabled = false;
            }

            if (stage2confirm == true)
            {

            }
            else
            {
                button3.Enabled = false;
                textboxConfirm.Text = tbcTextUnconfirmed;
            }

            if (stage3confirm == true)
            {

            }
            else
            {

            }

        }

        private void ClearLists()
        {
            getFiles.Clear();
            getDirectory.Clear();
            getFilesNoExt.Clear();
            wavLength.Clear();
        }

        private void lockUI()
        {
            uiStore1 = button1.Enabled;
            uiStore2 = button2.Enabled;
            uiStore3 = button3.Enabled;
            uiStore4 = checkBox_overwrite.Enabled;

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            checkBox_overwrite.Enabled = false;
        }

        private void unlockUI()
        {
            button1.Enabled = uiStore1;
            button2.Enabled = uiStore2;
            button3.Enabled = uiStore3;
            checkBox_overwrite.Enabled = uiStore4;
        }

        public static double GetSoundLength(string FilePath)
        {
            // AudioFile ObjAF = new AudioFile(FilePath);
            // return ObjAF.Properties.Duration.TotalSeconds;
            TagLib.File wavfile = TagLib.File.Create(FilePath);
            return wavfile.Properties.Duration.TotalSeconds;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            // dialog.InitialDirectory = "C:\\Users";
            dialog.RestoreDirectory = true;
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                suFolderPath = dialog.FileName;
                textboxPath.Text = suFolderPath;
                stage1confirm = true;
                stage2confirm = false;
                stage3confirm = false;
                StateUpdate();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool eventContinue = true;
            button2.Enabled = false;
            string folderName = Path.GetFileName(suFolderPath);
            if (folderName.Contains(".esp") == false || folderName.Contains(".esl") == false || folderName.Contains(".esm") == false)
            {
                String msgBoxText1 = @"The folder you have selected is not the mod.esp folder. " +
                "The app can still attempt to index .wav files and continue processing, but note that " +
                "unexpected behavior may occur. It is highly suggested that you point the directory to " +
                "the 'sound/voice/mod.esp' folder. Do you wish to continue?";
                DialogResult dialogResult = MessageBox.Show(msgBoxText1, "Caution", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dialogResult == DialogResult.No)
                {
                    button2.Enabled = true;
                    eventContinue = false;
                }
            }

            if (eventContinue == true)
            {
                label_index.Visible = true;
                label_index.Enabled = true;
                progressBar_index.Value = 0;
                progressBar_index.Visible = true;
                progressBar_index.Enabled = true;

                ClearLists();

                //Lock UI
                lockUI();
                //Run Worker1
                backgroundWorker1.RunWorkerAsync();
            }
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            string[] files =
                Directory.GetFiles(suFolderPath, "*.wav", SearchOption.AllDirectories);

            int filesIndex = 0;

            foreach (string arrItem in files)
            {
                getFiles.Add(arrItem);
                getDirectory.Add(Path.GetDirectoryName(arrItem));
                getFilesNoExt.Add(Path.GetFileNameWithoutExtension(arrItem));
                filesIndex++;
                int percentage = filesIndex * 100 / files.Length;
                backgroundWorker1.ReportProgress(percentage);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar_index.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //unlock UI
            unlockUI();

            label_index.Visible = false;
            label_index.Enabled = false;
            progressBar_index.Visible = false;
            progressBar_index.Enabled = false;
            button2.Enabled = true;

            if (getFiles.Count >= 1)
            {
                stage2confirm = true;
                StateUpdate();
                button3.Enabled = true;
                textboxConfirm.ForeColor = Color.DarkGreen;
                textboxConfirm.Text = "Confirmed | .wav files found: " + getFiles.Count.ToString();
            }
            else
            {
                stage2confirm = false;
                StateUpdate();
                MessageBox.Show("No .wav files found in directory", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string msgBoxText1 = null;

            if (setting_Overwrite)
            {
                msgBoxText1 = "This step will generate accompanying .lip files to match all .wav files. " +
                "Existing .lip files are set to be overwritten without confirmation.";
            }
            else
            {
                msgBoxText1 = "This step is set to generate accompanying .lip files to match all .wav files. " +
                "Existing .lip files will not be overwritten and will be skipped.";
            }

            DialogResult dialogResult = MessageBox.Show(msgBoxText1, "Continue?", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.OK)
            {
                button3.Enabled = false;

                progressBar1.Value = 0;
                progressBar2.Value = 0;
                progressBar1.Enabled = true;
                progressBar2.Enabled = true;
                label_process.Visible = true;
                label_process.Text = "Calculating Audio Durations... 0%";

                //Lock UI
                lockUI();

                //Start worker2
                backgroundWorker2.RunWorkerAsync();
            }
            else if (dialogResult == DialogResult.Cancel)
            {
                //do something else
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            int filesIndex = 0;

            foreach (string arrItem in getFiles)
            {
                filesIndex++;
                double process = GetSoundLength(arrItem);
                int wavL = (int)Math.Ceiling(process);

                if (wavL <= 30 && wavL > 0)
                {
                    wavLength.Add(wavL);
                }
                else if (wavL > 30)
                {
                    wavLength.Add(30);
                }
                else if (wavL <= 0)
                {
                    wavLength.Add(5);
                }

                int percentage = filesIndex * 100 / getFiles.Count;
                backgroundWorker2.ReportProgress(percentage);
            }
        }

        private void backgroundWorker2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            label_process.Text = "Calculating Audio Durations... " + e.ProgressPercentage + "%";
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            label_process.Text = "Generating Files... 0%";
            backgroundWorker3.RunWorkerAsync();
        }

        private void backgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
        {
            int filesIndex = 0;

            foreach (string arrItem in getFiles)
            {
                string fileName = getFilesNoExt[filesIndex] + ".lip";
                string resName = "SynthUtil.Resources." + wavLength[filesIndex] + ".lip";
                string newFileName = getDirectory[filesIndex] + @"\" + fileName;

                if (System.IO.File.Exists(newFileName) == false || setting_Overwrite == true)
                {
                    using (FileStream fileStream = System.IO.File.Create(newFileName))
                    {
                        Assembly.GetExecutingAssembly().GetManifestResourceStream(resName).CopyTo(fileStream);
                    }
                }

                filesIndex++;

                int percentage = filesIndex * 100 / getFiles.Count;
                backgroundWorker3.ReportProgress(percentage);
            }
        }

        private void backgroundWorker3_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar2.Value = e.ProgressPercentage;
            label_process.Text = "Generating Files... " + e.ProgressPercentage + "%";
        }

        private void backgroundWorker3_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ShowDialogForm2();
        }

        public void ShowDialogForm2()
        {
            Form_FileValidate f2Dialog = new Form_FileValidate();
            f2Dialog.setFolderPath(suFolderPath);
            
            // Show testDialog as a modal dialog and determine if DialogResult = OK.
            if (f2Dialog.ShowDialog(this) == DialogResult.OK)
            {
                // Read the contents of testDialog's TextBox.
                // this.txtResult.Text = testDialog.TextBox1.Text;
                validationComplete();
            }
            else
            {
                validationComplete();
            }
            f2Dialog.Dispose();
        }

        public void validationComplete()
        {
            //Unlock UI
            unlockUI();

            button3.Enabled = true;

            progressBar1.Value = 0;
            progressBar2.Value = 0;
            label_process.Visible = false;
            label_process.Text = "Calculating Audio Durations... 0%";
        }

        private void checkBox_overwrite_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_overwrite.Checked == true)
            {
                setting_Overwrite = true;
            } 
            else
            {
                setting_Overwrite = false;
            }
        }


        // Tab 2

        // fileName should consist of the CSV file name with full path
        private void LoadCSV(string fileName)
        {
            try
            {
                //Creates object for ReadCSV Class
                ReadCSV csv = new ReadCSV(fileName);
                try
                {
                    //Sets datagrid view to result
                    dataGridView1.DataSource = csv.readCSV;
                    //Clears local datatable, populates with result
                    csvData.Clear();
                    csvData = csv.readCSV;
                    //Sets textbox to datatable rows
                    textBox_lineCount.Text = "Lines: " + csvData.Rows.Count.ToString();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void SaveCSV(string fileName)
        {
            try
            {
                csvData.ToCSV(fileName);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void button_load_Click(object sender, EventArgs e)
        {
            //For LOAD file operation
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.RestoreDirectory = true;
            dialog.IsFolderPicker = false;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                try
                {
                    //Set Path
                    suCSVPath = dialog.FileName;
                    //Set textbox to Path
                    textBox_csvPath.Text = suCSVPath;
                    //Track to end of textbox
                    textBox_csvPath.SelectionStart = textBox_csvPath.Text.Length;
                    textBox_csvPath.SelectionLength = 0;

                    //Lock UI, Wait cursor on
                    Cursor.Current = Cursors.WaitCursor;
                    this.Enabled = false;

                    //Load operations
                    LoadCSV(suCSVPath);
                }
                catch (Exception ex1)
                {
                    MessageBox.Show("Error loading csv: " + ex1, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //Clear path textbox
                    textBox_csvPath.Text = "";
                    return;
                }
                finally
                {
                    //Unlock UI, Wait cursor off
                    Cursor.Current = Cursors.Default;
                    this.Enabled = true;
                }

                button2_save.Enabled = true;
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            //For SAVE file operation
            SaveFileDialog sfdialog = new SaveFileDialog();
            //Sets dialog properties
            sfdialog.InitialDirectory = suCSVPath;
            sfdialog.Filter = "CSV file (*.csv)|*.csv| All Files (*.*)|*.*";
            sfdialog.FileName = Path.GetFileName(suCSVPath);
            if (sfdialog.ShowDialog() == DialogResult.OK)
            {
                String tempCSVPath = sfdialog.FileName;
                textBox_csvPath.Text = tempCSVPath;

                //Track to end of textbox
                textBox_csvPath.SelectionStart = textBox_csvPath.Text.Length;
                textBox_csvPath.SelectionLength = 0;

                try
                {
                    //Lock UI, Wait cursor on
                    Cursor.Current = Cursors.WaitCursor;
                    this.Enabled = false;
                    //Save operations
                    SaveCSV(tempCSVPath);
                }
                catch (Exception ex1)
                {
                    MessageBox.Show("Error saving csv: " + ex1, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    //Unlock UI, Wait cursor off
                    Cursor.Current = Cursors.Default;
                    this.Enabled = true;
                }
            }
        }

        private void button2_settings_Click(object sender, EventArgs e)
        {
            Form_Tab2Settings fDialog = new Form_Tab2Settings();

            // Show testDialog as a modal dialog and determine if DialogResult = OK.
            if (fDialog.ShowDialog(this) == DialogResult.OK)
            {
                //Do nothing
            }
            else
            {
                //Do nothing
            }
            fDialog.Dispose();
        }
    }
}
 