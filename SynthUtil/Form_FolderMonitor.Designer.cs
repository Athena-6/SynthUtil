
namespace SynthUtil
{
    partial class Form_FolderMonitor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_FolderMonitor));
            this.textBox_t4 = new System.Windows.Forms.TextBox();
            this.label_s2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label_s1 = new System.Windows.Forms.Label();
            this.label_durationdata = new System.Windows.Forms.Label();
            this.label_timedata = new System.Windows.Forms.Label();
            this.label_timelabel = new System.Windows.Forms.Label();
            this.label_progRight = new System.Windows.Forms.Label();
            this.label_progLeft = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_t4
            // 
            this.textBox_t4.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_t4.Location = new System.Drawing.Point(29, 198);
            this.textBox_t4.Name = "textBox_t4";
            this.textBox_t4.ReadOnly = true;
            this.textBox_t4.Size = new System.Drawing.Size(553, 37);
            this.textBox_t4.TabIndex = 34;
            // 
            // label_s2
            // 
            this.label_s2.AutoSize = true;
            this.label_s2.Location = new System.Drawing.Point(25, 175);
            this.label_s2.Name = "label_s2";
            this.label_s2.Size = new System.Drawing.Size(46, 20);
            this.label_s2.TabIndex = 35;
            this.label_s2.Text = "Path:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(258, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 36);
            this.button1.TabIndex = 36;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(29, 50);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(553, 21);
            this.progressBar1.TabIndex = 37;
            // 
            // label_s1
            // 
            this.label_s1.AutoSize = true;
            this.label_s1.Location = new System.Drawing.Point(25, 27);
            this.label_s1.Name = "label_s1";
            this.label_s1.Size = new System.Drawing.Size(76, 20);
            this.label_s1.TabIndex = 38;
            this.label_s1.Text = "Progress:";
            // 
            // label_durationdata
            // 
            this.label_durationdata.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_durationdata.Location = new System.Drawing.Point(177, 130);
            this.label_durationdata.Name = "label_durationdata";
            this.label_durationdata.Size = new System.Drawing.Size(262, 23);
            this.label_durationdata.TabIndex = 41;
            this.label_durationdata.Text = "5 hrs, 34 mins";
            this.label_durationdata.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_durationdata.Visible = false;
            // 
            // label_timedata
            // 
            this.label_timedata.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_timedata.Location = new System.Drawing.Point(177, 153);
            this.label_timedata.Name = "label_timedata";
            this.label_timedata.Size = new System.Drawing.Size(262, 23);
            this.label_timedata.TabIndex = 40;
            this.label_timedata.Text = "1:23 PM";
            this.label_timedata.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_timedata.Visible = false;
            // 
            // label_timelabel
            // 
            this.label_timelabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_timelabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_timelabel.Location = new System.Drawing.Point(177, 103);
            this.label_timelabel.Name = "label_timelabel";
            this.label_timelabel.Size = new System.Drawing.Size(262, 30);
            this.label_timelabel.TabIndex = 39;
            this.label_timelabel.Text = "Estimated time to completion:";
            this.label_timelabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_timelabel.Visible = false;
            // 
            // label_progRight
            // 
            this.label_progRight.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_progRight.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_progRight.Location = new System.Drawing.Point(316, 74);
            this.label_progRight.Name = "label_progRight";
            this.label_progRight.Size = new System.Drawing.Size(266, 25);
            this.label_progRight.TabIndex = 43;
            this.label_progRight.Text = "Percentage: 55%";
            this.label_progRight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_progRight.Visible = false;
            // 
            // label_progLeft
            // 
            this.label_progLeft.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_progLeft.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_progLeft.Location = new System.Drawing.Point(24, 74);
            this.label_progLeft.Name = "label_progLeft";
            this.label_progLeft.Size = new System.Drawing.Size(269, 25);
            this.label_progLeft.TabIndex = 42;
            this.label_progLeft.Text = "Files: 1146/24562";
            this.label_progLeft.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_progLeft.Visible = false;
            // 
            // Form_FolderMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 304);
            this.Controls.Add(this.label_progRight);
            this.Controls.Add(this.label_progLeft);
            this.Controls.Add(this.label_durationdata);
            this.Controls.Add(this.label_timedata);
            this.Controls.Add(this.label_timelabel);
            this.Controls.Add(this.label_s1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_s2);
            this.Controls.Add(this.textBox_t4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_FolderMonitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SynthUtil - Folder Monitor";
            this.Shown += new System.EventHandler(this.Form_FolderMonitor_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_t4;
        private System.Windows.Forms.Label label_s2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label_s1;
        private System.Windows.Forms.Label label_durationdata;
        private System.Windows.Forms.Label label_timedata;
        private System.Windows.Forms.Label label_timelabel;
        private System.Windows.Forms.Label label_progRight;
        private System.Windows.Forms.Label label_progLeft;
    }
}