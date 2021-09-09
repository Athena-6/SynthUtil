
namespace SynthUtil
{
    partial class form_main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_main));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.checkBox_overwrite = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label_process = new System.Windows.Forms.Label();
            this.label_index = new System.Windows.Forms.Label();
            this.progressBar_index = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textboxConfirm = new System.Windows.Forms.TextBox();
            this.textboxPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBox_t2_setting1 = new System.Windows.Forms.CheckBox();
            this.checkBox_t2_proc1 = new System.Windows.Forms.CheckBox();
            this.checkBox_t2_proc2 = new System.Windows.Forms.CheckBox();
            this.textBox_lineCount = new System.Windows.Forms.TextBox();
            this.button2_settings = new System.Windows.Forms.Button();
            this.textBox_csvPath = new System.Windows.Forms.TextBox();
            this.button2_WordR = new System.Windows.Forms.Button();
            this.button2_ProcessData = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button2_save = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.button2_load = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_t3_3 = new System.Windows.Forms.TextBox();
            this.label_t3_3 = new System.Windows.Forms.Label();
            this.button_t3_start = new System.Windows.Forms.Button();
            this.label_t3_2 = new System.Windows.Forms.Label();
            this.button_t3_2 = new System.Windows.Forms.Button();
            this.button_t3_1 = new System.Windows.Forms.Button();
            this.textBox_t3_2 = new System.Windows.Forms.TextBox();
            this.textBox_t3_1 = new System.Windows.Forms.TextBox();
            this.label_t3_1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button_t4_start = new System.Windows.Forms.Button();
            this.button_t4_browse = new System.Windows.Forms.Button();
            this.textBox_t4 = new System.Windows.Forms.TextBox();
            this.label_t4_textboxlabel = new System.Windows.Forms.Label();
            this.label_t4_1 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.checkBox_t5_4 = new System.Windows.Forms.CheckBox();
            this.checkBox_t5_3 = new System.Windows.Forms.CheckBox();
            this.checkBox_t5_2 = new System.Windows.Forms.CheckBox();
            this.checkBox_t5_1 = new System.Windows.Forms.CheckBox();
            this.button_t5_1 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.tabPageA = new System.Windows.Forms.TabPage();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label14 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.checkBox_t5_5 = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPageA.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.WorkerReportsProgress = true;
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorker2.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker2_ProgressChanged);
            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted);
            // 
            // backgroundWorker3
            // 
            this.backgroundWorker3.WorkerReportsProgress = true;
            this.backgroundWorker3.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker3_DoWork);
            this.backgroundWorker3.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker3_ProgressChanged);
            this.backgroundWorker3.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker3_RunWorkerCompleted);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPageA);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(952, 557);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.checkBox_overwrite);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.label_process);
            this.tabPage1.Controls.Add(this.label_index);
            this.tabPage1.Controls.Add(this.progressBar_index);
            this.tabPage1.Controls.Add(this.progressBar2);
            this.tabPage1.Controls.Add(this.progressBar1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.textboxConfirm);
            this.tabPage1.Controls.Add(this.textboxPath);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.ImageKey = "(none)";
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(944, 523);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Static Lip Gen";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // checkBox_overwrite
            // 
            this.checkBox_overwrite.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.checkBox_overwrite.AutoSize = true;
            this.checkBox_overwrite.Location = new System.Drawing.Point(581, 452);
            this.checkBox_overwrite.Name = "checkBox_overwrite";
            this.checkBox_overwrite.Size = new System.Drawing.Size(218, 25);
            this.checkBox_overwrite.TabIndex = 24;
            this.checkBox_overwrite.Text = "Overwrite existing .lip files";
            this.checkBox_overwrite.UseVisualStyleBackColor = true;
            this.checkBox_overwrite.CheckedChanged += new System.EventHandler(this.checkBox_overwrite_CheckedChanged);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button3.Enabled = false;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(400, 439);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 49);
            this.button3.TabIndex = 23;
            this.button3.Text = "Start Process";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label_process
            // 
            this.label_process.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label_process.AutoSize = true;
            this.label_process.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_process.Location = new System.Drawing.Point(323, 386);
            this.label_process.Name = "label_process";
            this.label_process.Size = new System.Drawing.Size(312, 28);
            this.label_process.TabIndex = 22;
            this.label_process.Text = "Calculating Audio Durations... 50%";
            this.label_process.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_process.Visible = false;
            // 
            // label_index
            // 
            this.label_index.AutoSize = true;
            this.label_index.Enabled = false;
            this.label_index.Location = new System.Drawing.Point(30, 129);
            this.label_index.Name = "label_index";
            this.label_index.Size = new System.Drawing.Size(110, 21);
            this.label_index.TabIndex = 21;
            this.label_index.Text = "Indexing files...";
            this.label_index.Visible = false;
            // 
            // progressBar_index
            // 
            this.progressBar_index.Enabled = false;
            this.progressBar_index.Location = new System.Drawing.Point(146, 128);
            this.progressBar_index.Name = "progressBar_index";
            this.progressBar_index.Size = new System.Drawing.Size(576, 23);
            this.progressBar_index.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar_index.TabIndex = 20;
            this.progressBar_index.Visible = false;
            // 
            // progressBar2
            // 
            this.progressBar2.Enabled = false;
            this.progressBar2.Location = new System.Drawing.Point(31, 283);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(882, 35);
            this.progressBar2.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar2.TabIndex = 19;
            // 
            // progressBar1
            // 
            this.progressBar1.Enabled = false;
            this.progressBar1.Location = new System.Drawing.Point(31, 217);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(882, 35);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(746, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 41);
            this.button2.TabIndex = 17;
            this.button2.Text = "Confirm Selection";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 32);
            this.label2.TabIndex = 16;
            this.label2.Text = "Static .lip file generator";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(746, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 41);
            this.button1.TabIndex = 15;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textboxConfirm
            // 
            this.textboxConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxConfirm.Location = new System.Drawing.Point(31, 157);
            this.textboxConfirm.Name = "textboxConfirm";
            this.textboxConfirm.ReadOnly = true;
            this.textboxConfirm.Size = new System.Drawing.Size(691, 32);
            this.textboxConfirm.TabIndex = 13;
            // 
            // textboxPath
            // 
            this.textboxPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxPath.Location = new System.Drawing.Point(31, 89);
            this.textboxPath.Name = "textboxPath";
            this.textboxPath.ReadOnly = true;
            this.textboxPath.Size = new System.Drawing.Size(691, 32);
            this.textboxPath.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Path to esp folder";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.checkBox_t2_setting1);
            this.tabPage2.Controls.Add(this.checkBox_t2_proc1);
            this.tabPage2.Controls.Add(this.checkBox_t2_proc2);
            this.tabPage2.Controls.Add(this.textBox_lineCount);
            this.tabPage2.Controls.Add(this.button2_settings);
            this.tabPage2.Controls.Add(this.textBox_csvPath);
            this.tabPage2.Controls.Add(this.button2_WordR);
            this.tabPage2.Controls.Add(this.button2_ProcessData);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.button2_save);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.button2_load);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(944, 523);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "CSV Editor";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkBox_t2_setting1
            // 
            this.checkBox_t2_setting1.AutoSize = true;
            this.checkBox_t2_setting1.Location = new System.Drawing.Point(664, 397);
            this.checkBox_t2_setting1.Name = "checkBox_t2_setting1";
            this.checkBox_t2_setting1.Size = new System.Drawing.Size(168, 25);
            this.checkBox_t2_setting1.TabIndex = 49;
            this.checkBox_t2_setting1.Text = "Performance Mode";
            this.checkBox_t2_setting1.UseVisualStyleBackColor = true;
            this.checkBox_t2_setting1.CheckedChanged += new System.EventHandler(this.checkBox_t2_setting1_CheckedChanged);
            // 
            // checkBox_t2_proc1
            // 
            this.checkBox_t2_proc1.AutoSize = true;
            this.checkBox_t2_proc1.Location = new System.Drawing.Point(664, 102);
            this.checkBox_t2_proc1.Name = "checkBox_t2_proc1";
            this.checkBox_t2_proc1.Size = new System.Drawing.Size(190, 25);
            this.checkBox_t2_proc1.TabIndex = 48;
            this.checkBox_t2_proc1.Text = "Custom Word Replace";
            this.checkBox_t2_proc1.UseVisualStyleBackColor = true;
            this.checkBox_t2_proc1.CheckedChanged += new System.EventHandler(this.checkBox_t2_proc1_CheckedChanged);
            // 
            // checkBox_t2_proc2
            // 
            this.checkBox_t2_proc2.AutoSize = true;
            this.checkBox_t2_proc2.Location = new System.Drawing.Point(664, 260);
            this.checkBox_t2_proc2.Name = "checkBox_t2_proc2";
            this.checkBox_t2_proc2.Size = new System.Drawing.Size(248, 25);
            this.checkBox_t2_proc2.TabIndex = 47;
            this.checkBox_t2_proc2.Text = "Sort / Group Lines by voice_id ";
            this.checkBox_t2_proc2.UseVisualStyleBackColor = true;
            this.checkBox_t2_proc2.CheckedChanged += new System.EventHandler(this.checkBox_t2_proc2_CheckedChanged);
            // 
            // textBox_lineCount
            // 
            this.textBox_lineCount.Location = new System.Drawing.Point(473, 445);
            this.textBox_lineCount.Name = "textBox_lineCount";
            this.textBox_lineCount.Size = new System.Drawing.Size(160, 29);
            this.textBox_lineCount.TabIndex = 46;
            // 
            // button2_settings
            // 
            this.button2_settings.Location = new System.Drawing.Point(810, 13);
            this.button2_settings.Name = "button2_settings";
            this.button2_settings.Size = new System.Drawing.Size(102, 40);
            this.button2_settings.TabIndex = 43;
            this.button2_settings.Text = "Settings";
            this.button2_settings.UseVisualStyleBackColor = true;
            this.button2_settings.Click += new System.EventHandler(this.button2_settings_Click);
            // 
            // textBox_csvPath
            // 
            this.textBox_csvPath.Location = new System.Drawing.Point(29, 445);
            this.textBox_csvPath.Name = "textBox_csvPath";
            this.textBox_csvPath.Size = new System.Drawing.Size(438, 29);
            this.textBox_csvPath.TabIndex = 42;
            // 
            // button2_WordR
            // 
            this.button2_WordR.Location = new System.Drawing.Point(664, 133);
            this.button2_WordR.Name = "button2_WordR";
            this.button2_WordR.Size = new System.Drawing.Size(248, 46);
            this.button2_WordR.TabIndex = 41;
            this.button2_WordR.Text = "Replacements Setting";
            this.button2_WordR.UseVisualStyleBackColor = true;
            this.button2_WordR.Click += new System.EventHandler(this.button2_WordR_Click);
            // 
            // button2_ProcessData
            // 
            this.button2_ProcessData.Enabled = false;
            this.button2_ProcessData.Location = new System.Drawing.Point(664, 428);
            this.button2_ProcessData.Name = "button2_ProcessData";
            this.button2_ProcessData.Size = new System.Drawing.Size(248, 46);
            this.button2_ProcessData.TabIndex = 38;
            this.button2_ProcessData.Text = "Apply Processing";
            this.button2_ProcessData.UseVisualStyleBackColor = true;
            this.button2_ProcessData.Click += new System.EventHandler(this.button2_ProcessData_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(659, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 28);
            this.label3.TabIndex = 37;
            this.label3.Text = "Processing Step 2:";
            // 
            // button2_save
            // 
            this.button2_save.Enabled = false;
            this.button2_save.Location = new System.Drawing.Point(433, 14);
            this.button2_save.Name = "button2_save";
            this.button2_save.Size = new System.Drawing.Size(92, 41);
            this.button2_save.TabIndex = 34;
            this.button2_save.Text = "Export";
            this.button2_save.UseVisualStyleBackColor = true;
            this.button2_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(659, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 28);
            this.label6.TabIndex = 33;
            this.label6.Text = "Processing Step 1:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(604, 354);
            this.dataGridView1.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 32);
            this.label4.TabIndex = 30;
            this.label4.Text = "CSV Editor";
            // 
            // button2_load
            // 
            this.button2_load.Location = new System.Drawing.Point(541, 14);
            this.button2_load.Name = "button2_load";
            this.button2_load.Size = new System.Drawing.Size(92, 41);
            this.button2_load.TabIndex = 25;
            this.button2_load.Text = "Import";
            this.button2_load.UseVisualStyleBackColor = true;
            this.button2_load.Click += new System.EventHandler(this.button_load_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.textBox2);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.radioButton2);
            this.tabPage3.Controls.Add(this.radioButton1);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.textBox_t3_3);
            this.tabPage3.Controls.Add(this.label_t3_3);
            this.tabPage3.Controls.Add(this.button_t3_start);
            this.tabPage3.Controls.Add(this.label_t3_2);
            this.tabPage3.Controls.Add(this.button_t3_2);
            this.tabPage3.Controls.Add(this.button_t3_1);
            this.tabPage3.Controls.Add(this.textBox_t3_2);
            this.tabPage3.Controls.Add(this.textBox_t3_1);
            this.tabPage3.Controls.Add(this.label_t3_1);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Location = new System.Drawing.Point(4, 30);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(944, 523);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "CK .wav Preprocessing";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(563, 285);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 21);
            this.label10.TabIndex = 41;
            this.label10.Text = "Highpass, Lowpass";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(564, 248);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(159, 34);
            this.textBox2.TabIndex = 40;
            this.textBox2.Text = "1500, 1 [Locked]";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(563, 224);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 21);
            this.label11.TabIndex = 39;
            this.label11.Text = "BiQuad Filter:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(303, 285);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 21);
            this.label8.TabIndex = 38;
            this.label8.Text = "(kHz)";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(304, 248);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(159, 34);
            this.textBox1.TabIndex = 37;
            this.textBox1.Text = "16 [Locked]";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(303, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 21);
            this.label9.TabIndex = 36;
            this.label9.Text = "Final Sampling Rate";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Enabled = false;
            this.radioButton2.Location = new System.Drawing.Point(401, 391);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(168, 25);
            this.radioButton2.TabIndex = 35;
            this.radioButton2.Text = "General Processing";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(401, 360);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(158, 25);
            this.radioButton1.TabIndex = 34;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Preprocess for CK";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 21);
            this.label7.TabIndex = 33;
            this.label7.Text = "1 (Linear) - 60";
            // 
            // textBox_t3_3
            // 
            this.textBox_t3_3.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_t3_3.Location = new System.Drawing.Point(32, 248);
            this.textBox_t3_3.Name = "textBox_t3_3";
            this.textBox_t3_3.ReadOnly = true;
            this.textBox_t3_3.Size = new System.Drawing.Size(159, 34);
            this.textBox_t3_3.TabIndex = 32;
            this.textBox_t3_3.Text = "60 [Locked]";
            // 
            // label_t3_3
            // 
            this.label_t3_3.AutoSize = true;
            this.label_t3_3.Location = new System.Drawing.Point(31, 224);
            this.label_t3_3.Name = "label_t3_3";
            this.label_t3_3.Size = new System.Drawing.Size(163, 21);
            this.label_t3_3.TabIndex = 31;
            this.label_t3_3.Text = "Step Size / Resolution:";
            // 
            // button_t3_start
            // 
            this.button_t3_start.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_t3_start.Enabled = false;
            this.button_t3_start.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_t3_start.Location = new System.Drawing.Point(401, 439);
            this.button_t3_start.Name = "button_t3_start";
            this.button_t3_start.Size = new System.Drawing.Size(144, 49);
            this.button_t3_start.TabIndex = 30;
            this.button_t3_start.Text = "Start Process";
            this.button_t3_start.UseVisualStyleBackColor = true;
            this.button_t3_start.Click += new System.EventHandler(this.button_t3_start_Click);
            // 
            // label_t3_2
            // 
            this.label_t3_2.AutoSize = true;
            this.label_t3_2.Location = new System.Drawing.Point(31, 129);
            this.label_t3_2.Name = "label_t3_2";
            this.label_t3_2.Size = new System.Drawing.Size(142, 21);
            this.label_t3_2.TabIndex = 29;
            this.label_t3_2.Text = "Output Destination";
            // 
            // button_t3_2
            // 
            this.button_t3_2.Enabled = false;
            this.button_t3_2.Location = new System.Drawing.Point(747, 154);
            this.button_t3_2.Name = "button_t3_2";
            this.button_t3_2.Size = new System.Drawing.Size(167, 41);
            this.button_t3_2.TabIndex = 28;
            this.button_t3_2.Text = "Browse";
            this.button_t3_2.UseVisualStyleBackColor = true;
            this.button_t3_2.Click += new System.EventHandler(this.button_t3_2_Click);
            // 
            // button_t3_1
            // 
            this.button_t3_1.Location = new System.Drawing.Point(747, 86);
            this.button_t3_1.Name = "button_t3_1";
            this.button_t3_1.Size = new System.Drawing.Size(167, 41);
            this.button_t3_1.TabIndex = 27;
            this.button_t3_1.Text = "Browse";
            this.button_t3_1.UseVisualStyleBackColor = true;
            this.button_t3_1.Click += new System.EventHandler(this.button_t3_1_Click);
            // 
            // textBox_t3_2
            // 
            this.textBox_t3_2.Font = new System.Drawing.Font("Roboto", 11F);
            this.textBox_t3_2.Location = new System.Drawing.Point(32, 157);
            this.textBox_t3_2.Name = "textBox_t3_2";
            this.textBox_t3_2.ReadOnly = true;
            this.textBox_t3_2.Size = new System.Drawing.Size(691, 37);
            this.textBox_t3_2.TabIndex = 25;
            // 
            // textBox_t3_1
            // 
            this.textBox_t3_1.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_t3_1.Location = new System.Drawing.Point(32, 89);
            this.textBox_t3_1.Name = "textBox_t3_1";
            this.textBox_t3_1.ReadOnly = true;
            this.textBox_t3_1.Size = new System.Drawing.Size(691, 37);
            this.textBox_t3_1.TabIndex = 26;
            // 
            // label_t3_1
            // 
            this.label_t3_1.AutoSize = true;
            this.label_t3_1.Location = new System.Drawing.Point(31, 56);
            this.label_t3_1.Name = "label_t3_1";
            this.label_t3_1.Size = new System.Drawing.Size(335, 21);
            this.label_t3_1.TabIndex = 24;
            this.label_t3_1.Text = "Source Folder (Sub-folder paths will be copied)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 32);
            this.label5.TabIndex = 17;
            this.label5.Text = "Audio Preprocessing";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.textBox3);
            this.tabPage4.Controls.Add(this.button_t4_start);
            this.tabPage4.Controls.Add(this.button_t4_browse);
            this.tabPage4.Controls.Add(this.textBox_t4);
            this.tabPage4.Controls.Add(this.label_t4_textboxlabel);
            this.tabPage4.Controls.Add(this.label_t4_1);
            this.tabPage4.Location = new System.Drawing.Point(4, 30);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(944, 523);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "File Monitor";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(27, 175);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(189, 21);
            this.label15.TabIndex = 37;
            this.label15.Text = "Total Files for Completion:";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Roboto", 11F);
            this.textBox3.Location = new System.Drawing.Point(31, 199);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(185, 37);
            this.textBox3.TabIndex = 36;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button_t4_start
            // 
            this.button_t4_start.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_t4_start.Enabled = false;
            this.button_t4_start.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_t4_start.Location = new System.Drawing.Point(401, 439);
            this.button_t4_start.Name = "button_t4_start";
            this.button_t4_start.Size = new System.Drawing.Size(144, 49);
            this.button_t4_start.TabIndex = 35;
            this.button_t4_start.Text = "Start Process";
            this.button_t4_start.UseVisualStyleBackColor = true;
            this.button_t4_start.Click += new System.EventHandler(this.button_t4_start_Click);
            // 
            // button_t4_browse
            // 
            this.button_t4_browse.Location = new System.Drawing.Point(747, 86);
            this.button_t4_browse.Name = "button_t4_browse";
            this.button_t4_browse.Size = new System.Drawing.Size(167, 41);
            this.button_t4_browse.TabIndex = 34;
            this.button_t4_browse.Text = "Browse";
            this.button_t4_browse.UseVisualStyleBackColor = true;
            this.button_t4_browse.Click += new System.EventHandler(this.button_t4_browse_Click);
            // 
            // textBox_t4
            // 
            this.textBox_t4.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_t4.Location = new System.Drawing.Point(32, 89);
            this.textBox_t4.Name = "textBox_t4";
            this.textBox_t4.ReadOnly = true;
            this.textBox_t4.Size = new System.Drawing.Size(691, 37);
            this.textBox_t4.TabIndex = 33;
            // 
            // label_t4_textboxlabel
            // 
            this.label_t4_textboxlabel.AutoSize = true;
            this.label_t4_textboxlabel.Location = new System.Drawing.Point(28, 65);
            this.label_t4_textboxlabel.Name = "label_t4_textboxlabel";
            this.label_t4_textboxlabel.Size = new System.Drawing.Size(191, 21);
            this.label_t4_textboxlabel.TabIndex = 32;
            this.label_t4_textboxlabel.Text = "Choose Folder / Directory:";
            // 
            // label_t4_1
            // 
            this.label_t4_1.AutoSize = true;
            this.label_t4_1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_t4_1.Location = new System.Drawing.Point(25, 14);
            this.label_t4_1.Name = "label_t4_1";
            this.label_t4_1.Size = new System.Drawing.Size(233, 32);
            this.label_t4_1.TabIndex = 31;
            this.label_t4_1.Text = "File Change Monitor";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.checkBox_t5_5);
            this.tabPage5.Controls.Add(this.checkBox_t5_4);
            this.tabPage5.Controls.Add(this.checkBox_t5_3);
            this.tabPage5.Controls.Add(this.checkBox_t5_2);
            this.tabPage5.Controls.Add(this.checkBox_t5_1);
            this.tabPage5.Controls.Add(this.button_t5_1);
            this.tabPage5.Controls.Add(this.label16);
            this.tabPage5.Location = new System.Drawing.Point(4, 30);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(944, 523);
            this.tabPage5.TabIndex = 5;
            this.tabPage5.Text = "Voice Models";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // checkBox_t5_4
            // 
            this.checkBox_t5_4.AutoSize = true;
            this.checkBox_t5_4.Location = new System.Drawing.Point(31, 239);
            this.checkBox_t5_4.Name = "checkBox_t5_4";
            this.checkBox_t5_4.Size = new System.Drawing.Size(152, 25);
            this.checkBox_t5_4.TabIndex = 41;
            this.checkBox_t5_4.Text = "Exclude Creature";
            this.checkBox_t5_4.UseVisualStyleBackColor = true;
            this.checkBox_t5_4.CheckedChanged += new System.EventHandler(this.checkBox_t5_4_CheckedChanged);
            // 
            // checkBox_t5_3
            // 
            this.checkBox_t5_3.AutoSize = true;
            this.checkBox_t5_3.Location = new System.Drawing.Point(31, 191);
            this.checkBox_t5_3.Name = "checkBox_t5_3";
            this.checkBox_t5_3.Size = new System.Drawing.Size(178, 25);
            this.checkBox_t5_3.TabIndex = 40;
            this.checkBox_t5_3.Text = "Exclude Non-Unique";
            this.checkBox_t5_3.UseVisualStyleBackColor = true;
            this.checkBox_t5_3.CheckedChanged += new System.EventHandler(this.checkBox_t5_3_CheckedChanged);
            // 
            // checkBox_t5_2
            // 
            this.checkBox_t5_2.AutoSize = true;
            this.checkBox_t5_2.Location = new System.Drawing.Point(31, 143);
            this.checkBox_t5_2.Name = "checkBox_t5_2";
            this.checkBox_t5_2.Size = new System.Drawing.Size(142, 25);
            this.checkBox_t5_2.TabIndex = 39;
            this.checkBox_t5_2.Text = "Exclude Unqiue";
            this.checkBox_t5_2.UseVisualStyleBackColor = true;
            this.checkBox_t5_2.CheckedChanged += new System.EventHandler(this.checkBox_t5_2_CheckedChanged);
            // 
            // checkBox_t5_1
            // 
            this.checkBox_t5_1.AutoSize = true;
            this.checkBox_t5_1.Location = new System.Drawing.Point(31, 95);
            this.checkBox_t5_1.Name = "checkBox_t5_1";
            this.checkBox_t5_1.Size = new System.Drawing.Size(120, 25);
            this.checkBox_t5_1.TabIndex = 38;
            this.checkBox_t5_1.Text = "Exclude DLC";
            this.checkBox_t5_1.UseVisualStyleBackColor = true;
            this.checkBox_t5_1.CheckedChanged += new System.EventHandler(this.checkBox_t5_1_CheckedChanged);
            // 
            // button_t5_1
            // 
            this.button_t5_1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_t5_1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_t5_1.Location = new System.Drawing.Point(401, 439);
            this.button_t5_1.Name = "button_t5_1";
            this.button_t5_1.Size = new System.Drawing.Size(144, 49);
            this.button_t5_1.TabIndex = 37;
            this.button_t5_1.Text = "Generate";
            this.button_t5_1.UseVisualStyleBackColor = true;
            this.button_t5_1.Click += new System.EventHandler(this.button_t5_1_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(25, 14);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(391, 32);
            this.label16.TabIndex = 36;
            this.label16.Text = "Generate list of voice models/types";
            // 
            // tabPageA
            // 
            this.tabPageA.Controls.Add(this.linkLabel2);
            this.tabPageA.Controls.Add(this.label14);
            this.tabPageA.Controls.Add(this.linkLabel1);
            this.tabPageA.Controls.Add(this.label13);
            this.tabPageA.Controls.Add(this.label12);
            this.tabPageA.Location = new System.Drawing.Point(4, 30);
            this.tabPageA.Name = "tabPageA";
            this.tabPageA.Size = new System.Drawing.Size(944, 523);
            this.tabPageA.TabIndex = 3;
            this.tabPageA.Text = "About";
            this.tabPageA.UseVisualStyleBackColor = true;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Roboto", 9F);
            this.linkLabel2.Location = new System.Drawing.Point(31, 435);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(269, 24);
            this.linkLabel2.TabIndex = 29;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "GNU General Public License v3.0";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(31, 459);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(140, 24);
            this.label14.TabIndex = 27;
            this.label14.Text = "© 2021 Athena6";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(31, 80);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(316, 24);
            this.linkLabel1.TabIndex = 26;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://github.com/Athena-6/SynthUtil";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(31, 56);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(236, 24);
            this.label13.TabIndex = 25;
            this.label13.Text = "Information and bug reports:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(25, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 32);
            this.label12.TabIndex = 18;
            this.label12.Text = "About";
            // 
            // checkBox_t5_5
            // 
            this.checkBox_t5_5.AutoSize = true;
            this.checkBox_t5_5.Location = new System.Drawing.Point(31, 287);
            this.checkBox_t5_5.Name = "checkBox_t5_5";
            this.checkBox_t5_5.Size = new System.Drawing.Size(152, 25);
            this.checkBox_t5_5.TabIndex = 42;
            this.checkBox_t5_5.Text = "Exclude Non-Hifi";
            this.checkBox_t5_5.UseVisualStyleBackColor = true;
            this.checkBox_t5_5.CheckedChanged += new System.EventHandler(this.checkBox_t5_5_CheckedChanged);
            // 
            // form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 557);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SynthUtil";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPageA.ResumeLayout(false);
            this.tabPageA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label_process;
        private System.Windows.Forms.Label label_index;
        private System.Windows.Forms.ProgressBar progressBar_index;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textboxConfirm;
        private System.Windows.Forms.TextBox textboxPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_overwrite;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2_load;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2_save;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2_ProcessData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2_WordR;
        private System.Windows.Forms.TextBox textBox_csvPath;
        private System.Windows.Forms.Button button2_settings;
        private System.Windows.Forms.TextBox textBox_lineCount;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_t3_start;
        private System.Windows.Forms.Label label_t3_2;
        private System.Windows.Forms.Button button_t3_2;
        private System.Windows.Forms.Button button_t3_1;
        private System.Windows.Forms.TextBox textBox_t3_2;
        private System.Windows.Forms.TextBox textBox_t3_1;
        private System.Windows.Forms.Label label_t3_1;
        private System.Windows.Forms.CheckBox checkBox_t2_proc1;
        private System.Windows.Forms.CheckBox checkBox_t2_proc2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_t3_3;
        private System.Windows.Forms.Label label_t3_3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TabPage tabPageA;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button_t4_start;
        private System.Windows.Forms.Button button_t4_browse;
        private System.Windows.Forms.TextBox textBox_t4;
        private System.Windows.Forms.Label label_t4_textboxlabel;
        private System.Windows.Forms.Label label_t4_1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.CheckBox checkBox_t2_setting1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.CheckBox checkBox_t5_4;
        private System.Windows.Forms.CheckBox checkBox_t5_3;
        private System.Windows.Forms.CheckBox checkBox_t5_2;
        private System.Windows.Forms.CheckBox checkBox_t5_1;
        private System.Windows.Forms.Button button_t5_1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox checkBox_t5_5;
    }
}

