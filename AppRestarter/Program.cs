using System;
using System.Windows.Forms;
using AppRestarter.Forms;

namespace AppRestarter
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.ThreadException += (sender, args) => FrmException.ShowExceptionForm(args.Exception);
            AppDomain.CurrentDomain.UnhandledException += (sender, args) => FrmException.ShowExceptionForm((Exception)args.ExceptionObject);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        }
    }
}
