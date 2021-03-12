
using WindowsFormsApp2;
using System;
using System.Windows.Forms;

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
