
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AudioProcess));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label_proc1b = new System.Windows.Forms.Label();
            this.label_proc1 = new System.Windows.Forms.Label();
            this.label_pg1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(770, 157);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 182);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Audio Processing View";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(15, 238);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(770, 37);
            this.progressBar1.TabIndex = 2;
            // 
            // label_proc1b
            // 
            this.label_proc1b.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_proc1b.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_proc1b.Location = new System.Drawing.Point(482, 210);
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
            this.label_proc1.Location = new System.Drawing.Point(12, 210);
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
            this.label_pg1.Location = new System.Drawing.Point(362, 210);
            this.label_pg1.Name = "label_pg1";
            this.label_pg1.Size = new System.Drawing.Size(74, 25);
            this.label_pg1.TabIndex = 9;
            this.label_pg1.Text = "75%";
            this.label_pg1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_pg1.Visible = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Form_AudioProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label_proc1b;
        private System.Windows.Forms.Label label_proc1;
        private System.Windows.Forms.Label label_pg1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}