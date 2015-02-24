using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace QuietFile.Gui
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new QuietFileGui(args));
        }
    }
}
