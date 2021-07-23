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
    public static class WriteCSV
    {
        public static void ToCSV(this DataTable dtDataTable, string strFilePath)
        {
            // Write sample data to CSV file
            using (CsvFileWriter writer = new CsvFileWriter(strFilePath))
            {
                //Header Writer START

                //New CsvRow for writing
                CsvRow row = new CsvRow();
                //New String list for column names
                List<string> colNames = new List<string>();
                //Creates array of strings from data row
                foreach (DataColumn column in dtDataTable.Columns)
                {
                    colNames.Add(column.ColumnName);
                }
                //Adds strings within string list to CsvRow
                foreach (string str in colNames)
                {
                    row.Add(str);
                }
                //Write Operation
                writer.WriteRow(row);

                //Header Writer END

                //Loops for each datarow in datatable
                foreach (DataRow dr in dtDataTable.Rows)
                {
                    //New CsvRow for writing
                    CsvRow row2 = new CsvRow();
                    //Creates array of strings from data row
                    //var stringArray = dr.ItemArray.Cast<string>().ToArray();

                    for(int i = 0; i < dr.ItemArray.Length; i++)
                    {
                        if (!DBNull.Value.Equals(dr[i]))
                        {
                            //If not empty
                            row2.Add(dr[i].ToString());
                        }
                        else
                        {
                            //If null
                            row2.Add("");
                        }
                            
                    }

                    //Adds strings within array to CsvRow
                    //foreach(string str in stringArray)
                    //{
                    //    row2.Add(str);
                    //    row2.AddRange(dr.ItemArray)
                    //}

                    //Write Operation
                    writer.WriteRow(row2);
                }
            }
        }

        public static void ToCSVOLD(this DataTable dtDataTable, string strFilePath)
        {
            StreamWriter sw = new StreamWriter(strFilePath, false);
            //headers    
            for (int i = 0; i < dtDataTable.Columns.Count; i++)
            {
                sw.Write(dtDataTable.Columns[i]);
                if (i < dtDataTable.Columns.Count - 1)
                {
                    sw.Write(",");
                }
            }
            sw.Write(sw.NewLine);
            foreach (DataRow dr in dtDataTable.Rows)
            {
                for (int i = 0; i < dtDataTable.Columns.Count; i++)
                {
                    if (!Convert.IsDBNull(dr[i]))
                    {
                        string value = dr[i].ToString();
                        if (value.Contains(','))
                        {
                            value = String.Format("\"{0}\"", value);
                            sw.Write(value);
                        }
                        else
                        {
                            sw.Write(dr[i].ToString());
                        }
                    }
                    if (i < dtDataTable.Columns.Count - 1)
                    {
                        sw.Write(",");
                    }
                }
                sw.Write(sw.NewLine);
            }
            sw.Close();
        }
    }
}
