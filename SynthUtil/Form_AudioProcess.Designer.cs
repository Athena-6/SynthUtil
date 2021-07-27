
namespace SynthUtil
{
    partial class Form_AudioProcess
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AudioProcess));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label_proc1b = new System.Windows.Forms.Label();
            this.label_proc1 = new System.Windows.Forms.Label();
            this.label_pg1 = new System.Windows.Forms.Label();
            this.backgroundWorker1_Indexing = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textboxPath = new System.Windows.Forms.TextBox();
            this.backgroundWorker2_Processing = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_credits1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_ok = new System.Windows.Forms.Button();
            this.button_abort = new System.Windows.Forms.Button();
            this.label_timelabel = new System.Windows.Forms.Label();
            this.label_timedata = new System.Windows.Forms.Label();
            this.label_durationdata = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(374, 385);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 410);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Audio";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 385);
            this.panel1.TabIndex = 1;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(15, 472);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(764, 37);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 2;
            // 
            // label_proc1b
            // 
            this.label_proc1b.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_proc1b.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_proc1b.Location = new System.Drawing.Point(476, 512);
            this.label_proc1b.Name = "label_proc1b";
            this.label_proc1b.Size = new System.Drawing.Size(303, 25);
            this.label_proc1b.TabIndex = 11;
            this.label_proc1b.Text = "Modified Lines: 12405";
            this.label_proc1b.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_proc1b.Visible = false;
            // 
            // label_proc1
            // 
            this.label_proc1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_proc1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_proc1.Location = new System.Drawing.Point(10, 512);
            this.label_proc1.Name = "label_proc1";
            this.label_proc1.Size = new System.Drawing.Size(312, 25);
            this.label_proc1.TabIndex = 10;
            this.label_proc1.Text = "Processing Line 1146/24562";
            this.label_proc1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_proc1.Visible = false;
            // 
            // label_pg1
            // 
            this.label_pg1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pg1.Location = new System.Drawing.Point(357, 512);
            this.label_pg1.Name = "label_pg1";
            this.label_pg1.Size = new System.Drawing.Size(74, 25);
            this.label_pg1.TabIndex = 9;
            this.label_pg1.Text = "75%";
            this.label_pg1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_pg1.Visible = false;
            // 
            // backgroundWorker1_Indexing
            // 
            this.backgroundWorker1_Indexing.WorkerReportsProgress = true;
            this.backgroundWorker1_Indexing.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_Indexing_DoWork);
            this.backgroundWorker1_Indexing.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_Indexing_ProgressChanged);
            this.backgroundWorker1_Indexing.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_Indexing_RunWorkerCompleted);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Location = new System.Drawing.Point(402, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(380, 410);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output Audio";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(374, 385);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(374, 385);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // textboxPath
            // 
            this.textboxPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxPath.Location = new System.Drawing.Point(15, 434);
            this.textboxPath.Name = "textboxPath";
            this.textboxPath.ReadOnly = true;
            this.textboxPath.Size = new System.Drawing.Size(764, 32);
            this.textboxPath.TabIndex = 15;
            // 
            // backgroundWorker2_Processing
            // 
            this.backgroundWorker2_Processing.WorkerReportsProgress = true;
            this.backgroundWorker2_Processing.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_Processing_DoWork);
            this.backgroundWorker2_Processing.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker2_Processing_ProgressChanged);
            this.backgroundWorker2_Processing.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_Processing_RunWorkerCompleted);
            // 
            // label_credits1
            // 
            this.label_credits1.AutoSize = true;
            this.label_credits1.Location = new System.Drawing.Point(12, 629);
            this.label_credits1.Name = "label_credits1";
            this.label_credits1.Size = new System.Drawing.Size(263, 20);
            this.label_credits1.TabIndex = 16;
            this.label_credits1.Text = "Created using open-source libraries:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 669);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "FftSharp - Fast Fourier Transform (FFT) tools for .NET";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 649);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(417, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "FSKview - Frequency-shift keyed (FSK) signals in real time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 689);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(292, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "NAudio - Open source .NET audio library";
            // 
            // button_ok
            // 
            this.button_ok.Enabled = false;
            this.button_ok.Location = new System.Drawing.Point(683, 669);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(96, 40);
            this.button_ok.TabIndex = 20;
            this.button_ok.Text = "Continue";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // button_abort
            // 
            this.button_abort.Enabled = false;
            this.button_abort.Location = new System.Drawing.Point(569, 669);
            this.button_abort.Name = "button_abort";
            this.button_abort.Size = new System.Drawing.Size(96, 40);
            this.button_abort.TabIndex = 21;
            this.button_abort.Text = "Abort";
            this.button_abort.UseVisualStyleBackColor = true;
            this.button_abort.Click += new System.EventHandler(this.button_abort_Click);
            // 
            // label_timelabel
            // 
            this.label_timelabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_timelabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_timelabel.Location = new System.Drawing.Point(269, 548);
            this.label_timelabel.Name = "label_timelabel";
            this.label_timelabel.Size = new System.Drawing.Size(262, 30);
            this.label_timelabel.TabIndex = 22;
            this.label_timelabel.Text = "Estimated time to completion:";
            this.label_timelabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_timelabel.Visible = false;
            // 
            // label_timedata
            // 
            this.label_timedata.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_timedata.Location = new System.Drawing.Point(269, 600);
            this.label_timedata.Name = "label_timedata";
            this.label_timedata.Size = new System.Drawing.Size(262, 23);
            this.label_timedata.TabIndex = 23;
            this.label_timedata.Text = "1:23 PM";
            this.label_timedata.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_timedata.Visible = false;
            // 
            // label_durationdata
            // 
            this.label_durationdata.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_durationdata.Location = new System.Drawing.Point(269, 576);
            this.label_durationdata.Name = "label_durationdata";
            this.label_durationdata.Size = new System.Drawing.Size(262, 23);
            this.label_durationdata.TabIndex = 24;
            this.label_durationdata.Text = "5 hrs, 34 mins";
            this.label_durationdata.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_durationdata.Visible = false;
            // 
            // Form_AudioProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 729);
            this.Controls.Add(this.label_durationdata);
            this.Controls.Add(this.label_timedata);
            this.Controls.Add(this.label_timelabel);
            this.Controls.Add(this.button_abort);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_credits1);
            this.Controls.Add(this.textboxPath);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label_proc1b);
            this.Controls.Add(this.label_proc1);
            this.Controls.Add(this.label_pg1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_AudioProcess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SynthUtil - Audio Processor";
            this.Load += new System.EventHandler(this.Form_AudioProcess_Load);
            this.Shown += new System.EventHandler(this.Form_AudioProcess_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label_proc1b;
        private System.Windows.Forms.Label label_proc1;
        private System.Windows.Forms.Label label_pg1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1_Indexing;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textboxPath;
        private System.ComponentModel.BackgroundWorker backgroundWorker2_Processing;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_credits1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Button button_abort;
        private System.Windows.Forms.Label label_timelabel;
        private System.Windows.Forms.Label label_timedata;
        private System.Windows.Forms.Label label_durationdata;
    }
}