using System;
using System.Diagnostics;
using System.Windows.Forms;
using TanjayPOS.DB;

namespace TanjayPOS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /** var info = new ProcessStartInfo()
            {
                FileName = "Path\to\FontReg.exe",
                Arguments = "/copy",
                UseShellExecute = false,
                WindowStyle = ProcessWindowStyle.Hidden

            };

            Process.Start(info); **/

            new DB_SetConnection().CreateConnection();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            Application.Run(new MainForm());
            //Application.Run(new Credits());
            //Application.Run(new Stocks());
            //Application.Run(new POS());
        }
    }
}
