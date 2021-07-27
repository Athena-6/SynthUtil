
namespace SynthUtil
{
    partial class Form_Processing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Processing));
            this.button_ok = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label_timeduration = new System.Windows.Forms.Label();
            this.label_pg1 = new System.Windows.Forms.Label();
            this.label_proc1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_proc1b = new System.Windows.Forms.Label();
            this.label_timelabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_ok
            // 
            this.button_ok.Enabled = false;
            this.button_ok.Location = new System.Drawing.Point(345, 355);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(110, 37);
            this.button_ok.TabIndex = 0;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(23, 194);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(754, 33);
            this.progressBar1.Step = 1;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 1;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // label_timeduration
            // 
            this.label_timeduration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_timeduration.Location = new System.Drawing.Point(277, 297);
            this.label_timeduration.Name = "label_timeduration";
            this.label_timeduration.Size = new System.Drawing.Size(242, 31);
            this.label_timeduration.TabIndex = 4;
            this.label_timeduration.Text = "5 hrs, 34 mins";
            this.label_timeduration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_timeduration.Visible = false;
            // 
            // label_pg1
            // 
            this.label_pg1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pg1.Location = new System.Drawing.Point(366, 230);
            this.label_pg1.Name = "label_pg1";
            this.label_pg1.Size = new System.Drawing.Size(74, 25);
            this.label_pg1.TabIndex = 5;
            this.label_pg1.Text = "75%";
            this.label_pg1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_pg1.Visible = false;
            // 
            // label_proc1
            // 
            this.label_proc1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_proc1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_proc1.Location = new System.Drawing.Point(18, 230);
            this.label_proc1.Name = "label_proc1";
            this.label_proc1.Size = new System.Drawing.Size(312, 25);
            this.label_proc1.TabIndex = 6;
            this.label_proc1.Text = "Processing Line 1146/24562";
            this.label_proc1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_proc1.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(23, 22);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(754, 145);
            this.textBox1.TabIndex = 7;
            // 
            // label_proc1b
            // 
            this.label_proc1b.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_proc1b.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_proc1b.Location = new System.Drawing.Point(474, 230);
            this.label_proc1b.Name = "label_proc1b";
            this.label_proc1b.Size = new System.Drawing.Size(303, 25);
            this.label_proc1b.TabIndex = 8;
            this.label_proc1b.Text = "Modified Lines: 12405";
            this.label_proc1b.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_proc1b.Visible = false;
            // 
            // label_timelabel
            // 
            this.label_timelabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_timelabel.Location = new System.Drawing.Point(236, 272);
            this.label_timelabel.Name = "label_timelabel";
            this.label_timelabel.Size = new System.Drawing.Size(325, 25);
            this.label_timelabel.TabIndex = 9;
            this.label_timelabel.Text = "Estimated time to completion:";
            this.label_timelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_timelabel.Visible = false;
            // 
            // Form_Processing
            // 
            this.AcceptButton = this.button_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 404);
            this.Controls.Add(this.label_timelabel);
            this.Controls.Add(this.label_proc1b);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_proc1);
            this.Controls.Add(this.label_pg1);
            this.Controls.Add(this.label_timeduration);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button_ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Processing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CSV Processing";
            this.Load += new System.EventHandler(this.Form_Processing_Load);
            this.Shown += new System.EventHandler(this.Form_Processing_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label_timeduration;
        private System.Windows.Forms.Label label_pg1;
        private System.Windows.Forms.Label label_proc1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_proc1b;
        private System.Windows.Forms.Label label_timelabel;
    }
}