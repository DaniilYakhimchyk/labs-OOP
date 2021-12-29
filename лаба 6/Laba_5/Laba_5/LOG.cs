using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Laba_5
{
    class LOG
    {
        public static void WriteLog(Exception ex, bool infile = true, string filePath = @"C:\Users\Admin\Desktop\даниил\лаба 6\Laba_5\Laba_5\log.txt")
        {
            if (infile)
            {
                DateTime time = DateTime.Now;
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    sw.WriteLine($"Time: {time}");
                    sw.Write($"ERROR: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
