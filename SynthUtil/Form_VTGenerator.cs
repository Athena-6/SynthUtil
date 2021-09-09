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
    public partial class Form_VTGenerator : Form
    {
        //DataTable to load csv into
        private DataTable vtData = new DataTable();

        public Form_VTGenerator()
        {
            InitializeComponent();
        }

        private void Form_VTGenerator_Shown(object sender, EventArgs e)
        {
            Application.DoEvents();

            //Load CSV into local DataTable
            LoadToDatatable();
            //Remove entires according to user settings
            RemoveEntriesFromDT();
            //Populate remaining entires into textboxes
            MainPopulateTextFields();
        }

        private void LoadToDatatable()
        {
            try
            {
                vtData.Clear();
                vtData = ProgramTools.ReadVoiceTypesCSV().Copy();
            }
            catch (Exception ex1)
            {
                MessageBox.Show("Error reading data : " + ex1, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RemoveEntriesFromDT()
        {
            //Exclude DLC
            if (Properties.Settings.Default.vm_e_DLC)
            {
                vtData.AcceptChanges();
                foreach (DataRow row in vtData.Rows)
                {
                    // If row matches conditions, delete
                    string rowData = row["dlc"].ToString();
                    if (rowData == "yes")
                        row.Delete();
                }
                vtData.AcceptChanges();
            }

            //Exclude Unique
            if (Properties.Settings.Default.vm_e_Unique)
            {
                vtData.AcceptChanges();
                foreach (DataRow row in vtData.Rows)
                {
                    // If row matches conditions, delete
                    string rowData = row["unique"].ToString();
                    if (rowData == "yes")
                        row.Delete();
                }
                vtData.AcceptChanges();
            }

            //Exclude NonUnique
            if (Properties.Settings.Default.vm_e_NonUnique)
            {
                vtData.AcceptChanges();
                foreach (DataRow row in vtData.Rows)
                {
                    // If row matches conditions, delete
                    string rowData = row["unique"].ToString();
                    if (rowData == "no")
                        row.Delete();
                }
                vtData.AcceptChanges();
            }

            //Exclude Creatures
            if (Properties.Settings.Default.vm_e_Creature)
            {
                vtData.AcceptChanges();
                foreach (DataRow row in vtData.Rows)
                {
                    // If row matches conditions, delete
                    string rowData = row["creature"].ToString();
                    if (rowData == "yes")
                        row.Delete();
                }
                vtData.AcceptChanges();
            }

            //Exclude Non-HIFI
            if (Properties.Settings.Default.vm_e_NonHifi)
            {
                vtData.AcceptChanges();
                foreach (DataRow row in vtData.Rows)
                {
                    // If row matches conditions, delete
                    string rowData = row["has hifi vc"].ToString();
                    if (rowData == "no")
                        row.Delete();
                }
                vtData.AcceptChanges();
            }
        }

        private void MainPopulateTextFields()
        {
            //Populate box 1
            string box1 = "";
            var listVT = vtData.AsEnumerable().Select(r => r["vm name"].ToString());
            var listSK = vtData.AsEnumerable().Select(r => r["skyrim vt"].ToString());
   
            for (int i = 0; i < listVT.Count(); i++)
            {
                box1 += listVT.ToArray()[i].ToString();
                box1 += "=";
                box1 += listSK.ToArray()[i].ToString();
                box1 += ", ";
            }
            //Remove extra comma
            int box1L = box1.Length;
            box1 = box1.Remove(box1L - 2);

            //Populate box 2
            string box2 = "";
            for (int i = 0; i < vtData.Rows.Count; i++)
            {
                DataRow tRow = vtData.Rows[i];
                // If row matches conditions, delete
                string rowData = tRow["male/female"].ToString();
                if (rowData == "male")
                {
                    box2 += tRow["skyrim vt"];
                    box2 += ", ";
                }
            }
            //Remove extra comma
            int box2L = box2.Length;
            box2 = box2.Remove(box2L - 2);

            //Populate box 3
            string box3 = "";
            for (int i = 0; i < vtData.Rows.Count; i++)
            {
                DataRow tRow = vtData.Rows[i];
                // If row matches conditions, delete
                string rowData = tRow["male/female"].ToString();
                if (rowData == "female")
                {
                    box3 += tRow["skyrim vt"];
                    box3 += ", ";
                }
            }
            //Remove extra comma
            int box3L = box3.Length;
            box3 = box3.Remove(box3L - 2);

            //Set and print boxes
            textBox1.Text = box1;
            textBox2.Text = box2;
            textBox3.Text = box3;

            //Update UI
            this.Update();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }


    }
}
