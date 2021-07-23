using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;
using System.Windows.Forms;

namespace SynthUtil
{
    public class ReadCSV
    {
        public DataTable DT_ReadCSV { get; set; }

        public ReadCSV(string fileName, bool firstRowContainsFieldNames = true)
        {
            DT_ReadCSV = GenerateDataTableOLD(fileName, firstRowContainsFieldNames);
            //readCSV = GenerateDataTable(fileName);
        }

        public static DataTable GenerateDataTable(string strFilePath)
        {
            DataTable dt = new DataTable();

            // Flag for first run
            bool dtInit = true;

            // Read sample data from CSV file
            using (CsvFileReader reader = new CsvFileReader(strFilePath))
            {
                CsvRow row = new CsvRow();
                while (reader.ReadRow(row))
                {
                    int index = 1;
                    //Declares array list for storing row strings
                    List<string> cRow = new List<string>();

                    foreach (string s in row)
                    {            
                        if (dtInit)
                        {
                            //For first run (setting headers)
                            dt.Columns.Add(s);
                        } 
                        else
                        {
                            //Further runs
                            Console.Write(index + @"[");
                            Console.Write(s);
                            Console.Write("] ");
                            cRow.Add(s);
                            index++;
                        }
                    }

                    if (!dtInit)
                    {
                        dt.Rows.Add(cRow.ToArray());
                    }


                    //unset flag
                    dtInit = false;
                    Console.WriteLine();
                }
            }

            return dt;
        }

        public static DataTable GenerateDataTableNEW(string strFilePath)
        {
            DataTable dt = new DataTable();
            using (StreamReader sr = new StreamReader(strFilePath))
            {
                string[] headers = sr.ReadLine().Split(',');
                foreach (string header in headers)
                {
                    dt.Columns.Add(header);
                }
                while (!sr.EndOfStream)
                {
                    string[] rows = sr.ReadLine().Split(',');
                    DataRow dr = dt.NewRow();
                    for (int i = 0; i < headers.Length; i++)
                    {
                        dr[i] = rows[i];
                    }
                    dt.Rows.Add(dr);
                }

            }


            return dt;
        }

        private static DataTable GenerateDataTableOLD(string fileName, bool firstRowContainsFieldNames = true)
        {
            DataTable result = new DataTable();

            if (fileName == "")
            {
                return result;
            }

            string delimiters = ",";
            string extension = Path.GetExtension(fileName);

            if (extension.ToLower() == "txt")
                delimiters = "\t";
            else if (extension.ToLower() == "csv")
                delimiters = ",";

            using (TextFieldParser tfp = new TextFieldParser(fileName))
            {
                tfp.SetDelimiters(delimiters);
                tfp.HasFieldsEnclosedInQuotes = true;

                // Get The Column Names
                if (!tfp.EndOfData)
                {
                    string[] fields = tfp.ReadFields();

                    for (int i = 0; i < fields.Count(); i++)
                    {
                        if (firstRowContainsFieldNames)
                            result.Columns.Add(fields[i]);
                        else
                            result.Columns.Add("Col" + i);
                    }

                    // If first line is data then add it
                    if (!firstRowContainsFieldNames)
                        result.Rows.Add(fields);
                }

                // Get Remaining Rows from the CSV
                while (!tfp.EndOfData)
                    result.Rows.Add(tfp.ReadFields());
            }

            return result;
        }
    }
}
