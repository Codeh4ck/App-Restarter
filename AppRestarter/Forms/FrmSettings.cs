using System;
using System.IO;
using System.Windows.Forms;
using AppRestarter.Models;
using AppRestarter.Core.Containers;

namespace AppRestarter.Forms
{
    public partial class FrmSettings : Form
    {
        private readonly ISettingsContainer _settingsContainer;

        public FrmSettings()
        {
            _settingsContainer = SettingsContainer.GetInstance();
            InitializeComponent();
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            Settings settings = _settingsContainer.GetSettings();

            chkMinimizeToTray.Checked = settings.MinimizeToTray;
            chkStartWithWindows.Checked = settings.StartWithWindows;
            chkAutoStartMonitoring.Checked = settings.AutoStartWatching;
            chkAutoCheckForUpdates.Checked = settings.AutoCheckForUpdates;
            chkAlwaysShowLog.Checked = settings.AlwaysShowLog;
            chkAutoResizeColumns.Checked = settings.AutoResizeColumns;
            chkSaveLogsToDisk.Checked = settings.SaveLogsToDisk;
            chkSaveLogsOnDifferentFiles.Checked = settings.SaveAppLogsSeparately;

            txtLogsDirectory.Text = settings.LogsFolder;
            chkSaveLogsOnDifferentFiles.Enabled = chkSaveLogsToDisk.Checked;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using FolderBrowserDialog folderBrowseDialog = new()
            {
                Description = "Select a directory to save application logs at...",
                ShowNewFolderButton = true,
            };

            if (folderBrowseDialog.ShowDialog(this) != DialogResult.OK) return;

            txtLogsDirectory.Text = folderBrowseDialog.SelectedPath;
        }

        private void chkSaveLogsToDisk_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkSaveLogsToDisk.Checked)
            {
                txtLogsDirectory.Text = string.Empty;
                chkSaveLogsOnDifferentFiles.Checked = false;
            }

            chkSaveLogsOnDifferentFiles.Enabled = chkSaveLogsToDisk.Checked;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (chkSaveLogsToDisk.Checked)
            {
                if (string.IsNullOrEmpty(txtLogsDirectory.Text))
                {
                    MessageBox.Show("Please specify a valid directory to save application logs at.",
                        "Empty or invalid directory!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                    return;
                }

                if (!Directory.Exists(txtLogsDirectory.Text))
                {
                    DialogResult shouldCreateDirectory =
                        MessageBox.Show(
                            "The directory you selected to save logs at does not exist\n\nWould you like to create it?",
                            "Invalid logs directory!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                    if (shouldCreateDirectory == DialogResult.Yes)
                        Directory.CreateDirectory(txtLogsDirectory.Text);
                    else
                        chkSaveLogsToDisk.Checked = false;
                }
            }

            Settings settings = new()
            {
                MinimizeToTray = chkMinimizeToTray.Checked,
                StartWithWindows = chkStartWithWindows.Checked,
                AutoStartWatching = chkAutoStartMonitoring.Checked,
                AutoCheckForUpdates = chkAutoCheckForUpdates.Checked,
                AlwaysShowLog = chkAlwaysShowLog.Checked,
                AutoResizeColumns = chkAutoResizeColumns.Checked,
                SaveLogsToDisk = chkSaveLogsToDisk.Checked,
                SaveAppLogsSeparately = chkSaveLogsOnDifferentFiles.Checked,
                LogsFolder = txtLogsDirectory.Text
            };

            _settingsContainer.ModifySettings(settings);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
