using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using AppRestarter.Core.Containers;
using AppRestarter.Models;

namespace AppRestarter.Forms
{
    public partial class FrmAddWatchedApp : Form
    {
        private readonly IAppContainer _appContainer;
        public WatchedApp WatchedApp { get; private set; }

        public FrmAddWatchedApp(IAppContainer appContainer)
        {
            _appContainer = appContainer ?? throw new ArgumentNullException(nameof(appContainer));
            
            WatchedApp = null;

            InitializeComponent();
        }
        private void FrmAddWatchedApp_Load(object sender, EventArgs e)
        {
            cbPollType.SelectedIndex = 0;
            cbRestartType.SelectedIndex = 0;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (chkPassCmdArgsOnly.Checked)
            {
                using FolderBrowserDialog folderBrowseDialog = new()
                {
                    Description = "Select a base directory for your command line application..",
                    ShowNewFolderButton = false
                };

                if (folderBrowseDialog.ShowDialog(this) != DialogResult.OK) return;

                txtAppPath.Text = folderBrowseDialog.SelectedPath;

                labelDirectory.Text = folderBrowseDialog.SelectedPath;
                labelExecutableName.Text = "cmd.exe";
            }
            else
            {
                using OpenFileDialog openFileDialog = new()
                {
                    Filter = "Executable Files (.exe)|*.exe",
                    Title = "Select an application to add to monitoring...",
                    CheckPathExists = true,
                    CheckFileExists = true,
                };

                if (openFileDialog.ShowDialog(this) != DialogResult.OK) return;

                txtAppPath.Text = openFileDialog.FileName;

                labelDirectory.Text = Path.GetDirectoryName(openFileDialog.FileName);
                labelExecutableName.Text = openFileDialog.SafeFileName;
            }
        }

        private void btnAddApp_Click(object sender, EventArgs e)
        {
            if (chkPassCmdArgsOnly.Checked)
            {
                if (!Directory.Exists(txtAppPath.Text))
                {
                    MessageBox.Show("Please select a valid directory for your command line application.", "Invalid directory!",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    return;
                }
            }
            else
            {
                if (!File.Exists(txtAppPath.Text))
                {
                    MessageBox.Show("Please select a valid application executable file.", "Invalid executable file!",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    return;
                }
            }

            TimeSpan pollInterval = GetPollInterval();
            if (pollInterval == default) return;

            WatchedApp app = new()
            {
                Id = Guid.NewGuid(),
                BaseDirectory = chkPassCmdArgsOnly.Checked ? txtAppPath.Text : Path.GetDirectoryName(txtAppPath.Text),
                ExecutableName = chkPassCmdArgsOnly.Checked ? "Command Line" : Path.GetFileName(txtAppPath.Text),
                PassCmdArgsOnly = chkPassCmdArgsOnly.Checked,
                LogApplicationEvents = chkLogAppEvents.Checked,
                ShowWindow = chkShowWindow.Checked,
                RunThroughCmd = chkRunThroughCmd.Checked,
                PollInterval = pollInterval,
                PollIntervalType = cbPollType.SelectedIndex,
                RestartAfter = GetRestartAfter(),
                RestartAfterType = cbRestartType.SelectedIndex,
                Arguments = GetArguments()
            };

            _appContainer.AddApplication(app);

            WatchedApp = app;

            DialogResult = DialogResult.OK;
            Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void labelWhatIsThis_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(
                "Clicking the \"Pass command line arguments only option\" will switch the application selection dialog to a folder selection dialog. " +
                "The selected folder will be the base directory of your command line. This is equivalent to running \"cd\" (change directory) commands before " +
                "running your application through command line. Then you can specify cmd arguments in the list below to run directly to the command line." +
                "\n\nFor example:\n\nApplication path:\n\tC:/Users/Username/Desktop/WebProject\n\nCommand line arguments:" +
                "\n\tArgument: yarn - Value: <Empty>\n\tArgument: start - Value: index.ts\n\t\n\n" +
                "This is equivalent to running \"yarn start \"index.ts\" in directory C:/Users/Username/Desktop/WebProject",
                "What is this?",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void chkPassCmdArgsOnly_CheckedChanged(object sender, EventArgs e)
        {
            chkRunThroughCmd.Enabled = !chkPassCmdArgsOnly.Checked;
        }
        
        // TODO: Replace all methods below this comment with extension methods
        private List<CmdArgument> GetArguments()
        {
            List<CmdArgument> arguments = new();

            foreach (ListViewItem item in listArguments.Items)
            {
                if (item.Tag is not CmdArgument tag) continue;
                arguments.Add(tag);
            }

            return arguments;
        }

        private TimeSpan GetPollInterval()
        {
            if (numPollInterval.Value == 0)
            {
                MessageBox.Show("Please enter a poll interval of over 0.", "Invalid poll interval!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return default;
            }

            double intervalDouble = Convert.ToDouble(numPollInterval.Value);

            return cbPollType.SelectedIndex switch
            {
                0 => TimeSpan.FromMilliseconds(intervalDouble),
                1 => TimeSpan.FromSeconds(intervalDouble),
                2 => TimeSpan.FromMinutes(intervalDouble),
                3 => TimeSpan.FromHours(intervalDouble),
                _ => TimeSpan.FromSeconds(intervalDouble)
            };
        }

        private TimeSpan GetRestartAfter()
        {
            double restartAfterAll = Convert.ToDouble(numRestartAfter.Value);

            return cbRestartType.SelectedIndex switch
            {
                0 => TimeSpan.FromMilliseconds(restartAfterAll),
                1 => TimeSpan.FromSeconds(restartAfterAll),
                2 => TimeSpan.FromMinutes(restartAfterAll),
                3 => TimeSpan.FromHours(restartAfterAll),
                _ => TimeSpan.FromSeconds(restartAfterAll)
            };
        }

        private void cbPollType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPollType.SelectedIndex == 0)
            {
                numPollInterval.Increment = 100;
                numPollInterval.Maximum = 999;
            }

            if (cbPollType.SelectedIndex == 1 || cbPollType.SelectedIndex == 2)
            {
                numPollInterval.Increment = 5;
                numPollInterval.Maximum = 59;
            }

            if (cbPollType.SelectedIndex == 3)
            {
                numPollInterval.Increment = 1;
                numPollInterval.Maximum = 23;
            }
        }

        private void cbRestartType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRestartType.SelectedIndex == 0)
            {
                numRestartAfter.Increment = 100;
                numRestartAfter.Maximum = 999;
            }

            if (cbRestartType.SelectedIndex == 1 || cbRestartType.SelectedIndex == 2)
            {
                numRestartAfter.Increment = 5;
                numRestartAfter.Maximum = 59;
            }

            if (cbRestartType.SelectedIndex == 3)
            {
                numRestartAfter.Increment = 1;
                numRestartAfter.Maximum = 23;
            }
        }
        private void btnArgAdd_Click(object sender, EventArgs e)
        {
            CmdArgument argument = FrmAddArgument.GetArgument(this);
            if (argument == null) return;

            if (TryGetArgumentItem(argument.Argument, out ListViewItem existing))
            {
                DialogResult shouldReplaceArgument = MessageBox.Show("Argument already exists, would you like to replace it?", "Argument exists!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (shouldReplaceArgument == DialogResult.Yes)
                {
                    existing.SubItems[1].Text = argument.Value;
                    existing.Tag = argument;
                }

                return;
            }

            ListViewItem item = new(new[]
            {
                argument.Argument,
                argument.Value
            })
            {
                Tag = argument
            };

            listArguments.Items.Add(item);
        }

        private void btnArgModify_Click(object sender, EventArgs e)
        {
            if (listArguments.SelectedItems.Count != 1) return;

            ListViewItem item = listArguments.SelectedItems[0];

            if (item.Tag is not CmdArgument affectedArgument) return;

            CmdArgument modifiedArgument = FrmModifyArgument.ModifyArgument(affectedArgument, this);

            if (modifiedArgument == null) return;

            if (TryGetEqualArgument(modifiedArgument, out ListViewItem existing))
            {
                DialogResult shouldReplaceArgument = MessageBox.Show("Argument already exists, would you like to replace it?", "Argument exists!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (shouldReplaceArgument == DialogResult.Yes)
                {
                    existing.SubItems[1].Text = modifiedArgument.Value;
                    existing.Tag = modifiedArgument;

                    listArguments.Items.Remove(item);
                }

                return;
            }

            item.SubItems[0].Text = modifiedArgument.Argument;
            item.SubItems[1].Text = modifiedArgument.Value;
            item.Tag = modifiedArgument;
        }

        private void btnArgRemove_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listArguments.SelectedItems)
                listArguments.Items.Remove(item);
        }

        private bool TryGetArgumentItem(string argument, out ListViewItem existing)
        {
            foreach (ListViewItem item in listArguments.Items)
            {
                if (item.Tag is not CmdArgument tag) continue;
                if (!string.Equals(tag.Argument, argument, StringComparison.InvariantCultureIgnoreCase)) continue;

                existing = item;
                return true;
            }

            existing = null;
            return false;
        }

        private bool TryGetEqualArgument(CmdArgument argument, out ListViewItem existing)
        {
            foreach (ListViewItem item in listArguments.Items)
            {
                if (item.Tag is not CmdArgument tag) continue;

                if (string.Equals(tag.Argument, argument.Argument, StringComparison.InvariantCultureIgnoreCase) && tag.Id != argument.Id)
                {
                    existing = item;
                    return true;
                }
            }

            existing = null;
            return false;
        }

        private void labelReadme_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) 
            => Process.Start("https://github.com/Codeh4ck/App-Restarter/blob/main/README.md");
    
    }
}
