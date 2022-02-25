using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Net;
using System.Reflection;
using System.Windows.Forms;
using AppRestarter.Models;

namespace AppRestarter.Forms
{
    public partial class FrmUpdateAvailable : Form
    {
        private readonly string _downloadUrl;
        public FrmUpdateAvailable(string downloadUrl)
        {
            if (string.IsNullOrEmpty(downloadUrl)) throw new ArgumentNullException(nameof(downloadUrl));
            _downloadUrl = downloadUrl;

            InitializeComponent();
        }

        public static void ShowAvailableUpdate(Form parent, Update update)
        {
            using FrmUpdateAvailable frmUpdateAvailable = new FrmUpdateAvailable(update.DownloadUrl);

            frmUpdateAvailable.labelCurrentVersion.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            frmUpdateAvailable.labelNewVersion.Text = update.Version.ToString();
            frmUpdateAvailable.txtChangeLog.Text = update.ChangeLog;

            frmUpdateAvailable.ShowDialog(parent);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            pbDownload.Visible = true;

            using WebClient webClient = new WebClient();
            webClient.DownloadProgressChanged += WebClientOnDownloadProgressChanged;
            webClient.DownloadFileCompleted += WebClientOnDownloadFileCompleted;

            webClient.DownloadFileAsync(new Uri(_downloadUrl), "AppRestarter.zip");
        }

        private void WebClientOnDownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            Invoke(delegate ()
            {
                MessageBox.Show(
                    "The new update has finished downloading. AppRestarter will now restart to update all relevant files.",
                    "Update download complete!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                pbDownload.Visible = false;
                btnUpdate.Enabled = true;
            });

            if (!File.Exists("AppRestarter.Updater.exe"))
            {
                MessageBox.Show(
                    "Application installation is corrupt. AppRestarter.Updater.exe is missing! Please download AppRestarter again manually.",
                    "Corrupt installation!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Close();
                return;
            }

            ProcessStartInfo startInfo = new ProcessStartInfo("AppRestarter.Updater.exe")
            {
                WindowStyle = ProcessWindowStyle.Normal,
                WorkingDirectory = Application.StartupPath,
            };

            Process process = Process.Start(startInfo);
            
            if (process == null)
            {
                MessageBox.Show(
                    "Could not update AppRestarter. AppRestarter.Updater.exe could not be ran! Please download AppRestarter again manually.",
                    "Unable to update AppRestart!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Close();
                return;
            }

            process.WaitForExit();
        }

        private void WebClientOnDownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            double receivedBytes = double.Parse(e.BytesReceived.ToString());
            double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
            double percentage = receivedBytes / totalBytes * 100;

            pbDownload.Value = int.Parse(Math.Truncate(percentage).ToString(CultureInfo.InvariantCulture));
        }

        private void FrmUpdateAvailable_Load(object sender, EventArgs e) => btnUpdate.Focus();
        private void btnCancel_Click(object sender, EventArgs e) => Close();
    }
}
