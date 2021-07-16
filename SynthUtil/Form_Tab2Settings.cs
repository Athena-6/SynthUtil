using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SynthUtil
{
    public partial class Form_Tab2Settings : Form
    {
        public Form_Tab2Settings()
        {
            InitializeComponent();
            textBox1.Text = Properties.Settings.Default.proc_voiceid;
            textBox2.Text = Properties.Settings.Default.proc_text;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.proc_voiceid = textBox1.Text;
                Properties.Settings.Default.proc_text = textBox2.Text;
            } 
            catch (Exception ex1)
            {
                MessageBox.Show("Error saving settings: " + ex1, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
    }
}
