using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanjayPOS.Reusable_Code
{
    class ErrorLogger
    {
        public ErrorLogger(String error)
        {
            string path = @"c:\\Users" + Environment.UserName + "\\Documents\\POS ERROR LOG.txt";
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("This");
                    sw.WriteLine("is Extra");
                    sw.WriteLine("Text");
                }
            }
        }
    }
}