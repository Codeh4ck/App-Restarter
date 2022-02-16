using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

namespace AppRestarter.Forms
{
    public partial class FrmAbout : Form
    {
        public FrmAbout() => InitializeComponent();
        private void FrmAbout_Load(object sender, EventArgs e) => labelVersion.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
        private void linkGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("https://github.com/Codeh4ck/App-Restarter");
    }
}
