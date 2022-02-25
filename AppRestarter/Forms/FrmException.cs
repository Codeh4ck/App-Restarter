using System;
using System.Windows.Forms;

namespace AppRestarter.Forms
{
    public partial class FrmException : Form
    {
        public FrmException()
        {
            InitializeComponent();
        }

        public static void ShowExceptionForm(Exception ex)
        {
            using FrmException frmException = new FrmException();
            frmException.SetExceptionMessage(ex);

            frmException.Show();
        }

        public void SetExceptionMessage(Exception ex)
        {
            while (true)
            {
                txtExceptionLog.AppendText(ex.Message + "\r\n\r\n");
                txtExceptionLog.AppendText("Stacktrace: \r\n");
                txtExceptionLog.AppendText(ex.StackTrace);
                txtExceptionLog.AppendText("\r\n\r\n");

                if (ex.InnerException != null)
                {
                    ex = ex.InnerException;
                    continue;
                }

                break;
            }
        }

        private void btnShutdown_Click(object sender, EventArgs e) => Application.Exit();
        private void btnRestart_Click(object sender, EventArgs e) => Application.Restart();
        private void btnIgnore_Click(object sender, EventArgs e) => Close();
    }
}
