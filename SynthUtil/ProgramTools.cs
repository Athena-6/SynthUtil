using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SynthUtil
{
    public static class ProgramTools
    {

        //Write Stock Empty 'WordReplace.csv' with headers
        public static void WriteStockCSV()
        {

        }


        //Percentage from 2 ints
        public static int IntToPerc(int input1, int input2)
        {
            float d1 = (float)input1;
            float d2 = (float)input2;
            float dR = d1 / d2 * (float)100;
            int result = Convert.ToInt32(Math.Floor(dR));
            return result;
        }

        //Int division
        public static int IntDiv_rDown(int input1, int input2)
        {
            float d1 = (float)input1;
            float d2 = (float)input2;
            float dR = d1 / d2;
            int result = Convert.ToInt32(Math.Floor(dR));
            return result;
        }

        //Write Temp CSV to Disk
        public static void WriteTempCSV(DataTable InputData)
        {
            //Set input dataSource to local DataTable
            //Set application directory
            String appPath = Directory.GetCurrentDirectory();
            String csvPath = appPath + @"\SynthUtil_Temp.csv";
            //System.IO.File.SetAttributes(csvPath, FileAttributes.Hidden);

            try
            {
                InputData.ToCSV(csvPath);
            }
            catch (Exception ex1)
            {
                MessageBox.Show("Error writing temp file to disk : " + ex1, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Load Temp CSV from Disk
        public static DataTable ReadTempCSV()
        {
            //Set target DataTable
            DataTable output = new DataTable();
            //Set application directory
            String appPath = Directory.GetCurrentDirectory();
            String csvPath = appPath + @"\SynthUtil_Temp.csv";

            //Creates object for ReadCSV Class
            ReadCSV csv = new ReadCSV(csvPath);

            try
            {
                //Populates with result
                output = csv.DT_ReadCSV;

                //Deletes temp file
                if (File.Exists(csvPath))
                {
                    File.Delete(csvPath);
                }
            }
            catch (Exception ex1)
            {
                MessageBox.Show("Error reading temp file from disk : " + ex1, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return output;
        }

        //Load VoiceTypes CSV from Disk
        public static DataTable ReadVoiceTypesCSV()
        {
            //Set target DataTable
            DataTable output = new DataTable();
            //Set application directory
            String appPath = Directory.GetCurrentDirectory();
            String csvPath = appPath + @"\VoiceTypes.csv";

            //Creates object for ReadCSV Class
            ReadCSV csv = new ReadCSV(csvPath);

            try
            {
                //Populates with result
                output = csv.DT_ReadCSV;
            }
            catch (Exception ex1)
            {
                MessageBox.Show("Error reading VoiceTypes.csv file : " + ex1, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return output;
        }

        //Timer delay
        public static void Delayed(int delay, Action action)
        {
            Timer timer = new Timer();
            timer.Interval = delay;
            timer.Tick += (s, e) => {
                action();
                timer.Stop();
            };
            timer.Start();
        }

        //Converts DateTime to hours:minutes AM/PM
        public static string TimeConvertHM(System.DateTime dtInput)
        {
            //Calculate duration for determining which type of date to display
            TimeSpan duration = dtInput - DateTime.Now;

            string asString = null;

            if (duration.TotalHours > 24.0)
            {
                asString = dtInput.ToString("MM/dd hh:mm tt");
            }
            else if (duration.TotalHours < 24.0)
            {
                asString = dtInput.ToString("hh:mm tt");
            }

            return asString;
        }

        //Converts DateTime to hours:minutes:seconds
        public static string TimeConvertDuration(System.DateTime dtInput)
        {
            TimeSpan duration = dtInput - DateTime.Now;

            string result;

            if (duration.TotalHours >= 24.0)
            {
                result = (duration.TotalDays.ToString() + " days");
            }
            else if ( (duration.TotalHours >= 1.0) && (duration.TotalHours < 24.0) )
            {
                result = string.Format("{0:D2} hours, {1:D2} mins", duration.Hours, duration.Minutes);
            }
            else if ((duration.TotalMinutes >= 1.0) && (duration.TotalHours < 1.0) )
            {
                result = string.Format("{0:D2} mins", duration.Minutes);
            }
            else if (duration.TotalMinutes < 1.0)
            {
                result = string.Format("{0:D2} seconds", duration.Seconds);
            }
            else
            {
                throw new Exception("Error in Processing Time Estimation.");
            }

            return result;
        }
    }
}
