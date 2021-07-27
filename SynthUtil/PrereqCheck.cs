using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SynthUtil
{
    public static class PrereqCheck
    {
        // Tests if all required dll exists, 
        // Will show error message and return number of missing
        public static int StartupTest()
        {
            // String list of missing files
            List<string> missingList = new List<string>();
            // int count
            int missingFiles = 0;

            //set application directory
            String appPath = Directory.GetCurrentDirectory();

            //list of required files
            String[] reqFiles = { "TagLibSharp.dll", "Microsoft.WindowsAPICodePack.dll", "Microsoft.WindowsAPICodePack.Shell.dll" };

            //check .dll exists
            foreach (String str in reqFiles)
            {
                if (!System.IO.File.Exists(appPath + @"\" + str))
                {
                    missingFiles++;
                    missingList.Add(str);
                }
            }

            //Comma seperated string of missing list
            string s = String.Join(", ", missingList);

            if (missingFiles > 0)
            {
                MessageBox.Show("Required files not present in app directory: " + s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return missingFiles;
        }

        //Check and if word replace csv exists, if not creates one with heading only
        public static void CheckCreate_WR_CSV()
        {
            //set application directory
            String appPath = Directory.GetCurrentDirectory();
            String csvPath = appPath + @"\WordReplace.csv";
            if (!System.IO.File.Exists(csvPath))
            {
                //File Missing, creates csv

                //Creates Datatable with coloumns
                DataTable newDT = new DataTable();
                newDT.Clear();
                newDT.Columns.Add("source");
                newDT.Columns.Add("source_regex_override");
                newDT.Columns.Add("change_to");

                //Add example data
                string[] strEData = new string[3] { "ok", "", "okay" };
                newDT.Rows.Add(strEData);

                //Datatable to csv
                try
                {
                    //Save operations
                    newDT.ToCSV(csvPath);
                    //MessageBox.Show("WR CSV Created");
                }
                catch (Exception ex1)
                {
                    MessageBox.Show("Error creating WordReplace.csv : " + ex1, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
