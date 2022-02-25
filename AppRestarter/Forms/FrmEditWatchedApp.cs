using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AppRestarter.Core.Containers;
using AppRestarter.Models;

namespace AppRestarter.Forms
{
    public partial class FrmEditWatchedApp : Form
    {
        private readonly WatchedApp _watchedApp;
        private readonly IAppContainer _appContainer;

        public FrmEditWatchedApp(WatchedApp watchedApp)
        {
            _watchedApp = watchedApp ?? throw new ArgumentNullException(nameof(watchedApp));
            _appContainer = AppContainer.GetInstance();

            InitializeComponent();
        }

        public static WatchedApp EditWatchedApp(Form parent, WatchedApp current)
        {
            using FrmEditWatchedApp editWatchedApp = new(current);
            if (editWatchedApp.ShowDialog(parent) != DialogResult.OK) return null;

            return editWatchedApp._watchedApp;
        }

        private void FrmEditWatchedApp_Load(object sender, EventArgs e)
        {
            Text = $"{Text}{_watchedApp.ExecutableName}";

            chkShowWindow.Checked = _watchedApp.ShowWindow;
            chkRunThroughCmd.Checked = _watchedApp.RunThroughCmd;
            chkLogAppEvents.Checked = _watchedApp.LogApplicationEvents;

            foreach (CmdArgument cmd in _watchedApp.Arguments)
            {
                ListViewItem item = new(new[]
                {
                    cmd.Argument,
                    cmd.Value
                })
                {
                    Tag = cmd
                };

                listArguments.Items.Add(item);
            }

            cbPollType.SelectedIndex = _watchedApp.PollIntervalType;
            cbRestartType.SelectedIndex = _watchedApp.RestartAfterType;

            numThreshold.Value = _watchedApp.CrashThreshold;
            numPollInterval.Value = GetTimespanValue(_watchedApp.PollInterval, _watchedApp.PollIntervalType);
            numRestartAfter.Value = GetTimespanValue(_watchedApp.RestartAfter, _watchedApp.RestartAfterType);
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

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            TimeSpan pollInterval = GetPollInterval();
            if (pollInterval == default) return;

            _watchedApp.CrashThreshold = Convert.ToInt32(numThreshold.Value);
            _watchedApp.Arguments = GetArguments();
            _watchedApp.PollInterval = GetPollInterval();
            _watchedApp.RestartAfter = GetRestartAfter();

            _watchedApp.PollIntervalType = cbPollType.SelectedIndex;
            _watchedApp.RestartAfterType = cbRestartType.SelectedIndex;

            _watchedApp.ShowWindow = chkShowWindow.Checked;
            _watchedApp.RunThroughCmd = chkRunThroughCmd.Checked;
            _watchedApp.LogApplicationEvents = chkLogAppEvents.Checked;

            _appContainer.UpdateApplication(_watchedApp);

            DialogResult = DialogResult.OK;
            Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
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

        private int GetTimespanValue(TimeSpan timeSpan, int timeSpanType)
        {
            return timeSpanType switch
            {
                0 => timeSpan.Milliseconds,
                1 => timeSpan.Seconds,
                2 => timeSpan.Minutes,
                3 => timeSpan.Hours,
                _ => throw new ArgumentOutOfRangeException(nameof(timeSpanType))
            };
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
    }
}
