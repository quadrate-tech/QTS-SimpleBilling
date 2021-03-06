

using System;
using System.Windows.Forms;
using WindowsFormsApp2;

namespace QTS_SimpleBilling
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Main());
            //Application.Run(new EmployeeForm());
            Application.Run(new Form1());
        }
    }
}
