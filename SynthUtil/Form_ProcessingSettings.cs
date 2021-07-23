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
    public partial class Form_ProcessingSettings : Form
    {
        //DataTable
        private DataTable wrData = new DataTable();

        public Form_ProcessingSettings()
        {
            InitializeComponent();

            PrereqCheck.CheckCreate_WR_CSV();

            ImportCSV();
        }

        private void ImportCSV()
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
                //Sets datagrid view to result
                dataGridView1.DataSource = csv.DT_ReadCSV;
            }
            catch (Exception ex1)
            {
                MessageBox.Show("Error reading WordReplace.csv : " + ex1, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportCSV()
        {
            //set application directory
            String appPath = Directory.GetCurrentDirectory();
            String csvPath = appPath + @"\WordReplace.csv";

            try
            {
                //Clears local datatable, populates with result
                wrData.ToCSV(csvPath);
            }
            catch (Exception ex1)
            {
                MessageBox.Show("Error saving to WordReplace.csv : " + ex1, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            try
            {
                ExportCSV();
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
