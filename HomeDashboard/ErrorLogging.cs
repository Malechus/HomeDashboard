using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HomeDashboard
{
    internal class ErrorLogging
    {
        public static bool ErrorCheck()
        {
            string filePath = Environment.CurrentDirectory + @"\Logs\";
            string fileName = "ErrorLog" + DateTime.Today.ToShortDateString().Replace('/', '-') + ".txt";
            try
            {
                if(File.Exists(filePath + fileName))
                {
                    return true;
                }
                else
                {
                    try
                    {
                        File.Create(filePath + fileName);
                        return true;
                    }
                    catch
                    {
                        return false;
                    }
                }
            }
            catch
            {
                return false;
            }
        }
        public static void ErrorHandler(Exception ex, DateTime dateTime)
        {
            string filePath = Environment.CurrentDirectory + @"\Logs\";
            string fileName = "ErrorLog" + DateTime.Today.ToShortDateString().Replace('/', '-') + ".txt";

            using (StreamWriter sw = new StreamWriter(filePath + fileName))
            {
                sw.WriteLine("An error occured at " + dateTime.ToString());
                sw.WriteLine(ex.ToString());
                sw.WriteLine();
            }
        }
    }
}
