using System.Windows.Forms;
using AppRestarter.Core.Containers;
using AppRestarter.Core.Services;
using AppRestarter.Forms;
using AppRestarter.Models;

namespace AppRestarter.Utilities.Extensions
{
    public static class FrmMainExtensions
    {
        public static void AddWatchedApp(this FrmMain frmMain, WatchedApp app)
        {
            if (app == null) return;

            ListViewItem item = new(new[]
            {
                app.BaseDirectory,
                app.ExecutableName,
                app.Arguments.Count.ToString(),
                app.ShowWindow.ToString(),
                app.RunThroughCmd.ToString(),
                app.LogApplicationEvents.ToString(),
                app.PollInterval.ToHumanReadableString(),
                app.RestartAfter.ToHumanReadableString(),
                "0"
            })
            {
                Tag = app
            };

            frmMain.listWatchedApps.Items.Add(item);
            frmMain.listWatchedApps.AutoResizeColumns();
        }

        public static void UpdateAppRestartCount(this FrmMain frmMain, WatchedApp app)
        {
            // We're invoking this as it is almost always called from a different thread

            frmMain.Invoke(delegate()
            {
                foreach (ListViewItem item in frmMain.listWatchedApps.Items)
                {
                    if (item.Tag is not WatchedApp tag) continue;
                    if (tag.Id != app.Id) continue;

                    ListViewItem.ListViewSubItem subItem = item.SubItems[item.SubItems.Count - 1];

                    bool parsable = int.TryParse(subItem.Text, out int currentTimes);
                    if (!parsable) return;

                    currentTimes++;

                    subItem.Text = currentTimes.ToString();

                    return;
                }
            });
        }

        public static void EditWatchedApp(this FrmMain frmMain)
        {
            if (frmMain.listWatchedApps.SelectedItems.Count != 1) return;
            if (!frmMain.CanProceedToAppEditor()) return;

            ListViewItem item = frmMain.listWatchedApps.SelectedItems[0];

            if (item.Tag is not WatchedApp app) return;

            WatchedApp updated = FrmEditWatchedApp.EditWatchedApp(frmMain, app);
            if (updated == null) return;

            item.Tag = updated;

            item.SubItems[2].Text = updated.Arguments.Count.ToString();
            item.SubItems[3].Text = updated.ShowWindow.ToString();
            item.SubItems[4].Text = updated.RunThroughCmd.ToString();
            item.SubItems[5].Text = updated.LogApplicationEvents.ToString();
            item.SubItems[6].Text = updated.PollInterval.ToHumanReadableString();
            item.SubItems[7].Text = updated.RestartAfter.ToHumanReadableString();

            frmMain.listWatchedApps.AutoResizeColumns();
        }

        public static void AutoResizeColumns(this ListView listView)
        {
            bool autoResizeColumns = SettingsContainer.GetInstance().GetSettings().AutoResizeColumns;

            if (autoResizeColumns)
            {
                listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        public static bool CanProceedToAppEditor(this FrmMain frmMain)
        {
            IWatcherService watcherService = WatcherService.GetInstance();
            if (!watcherService.IsWatching()) return true;

            MessageBox.Show("Please stop the application monitor before adding or modifying an application.",
                "Application monitor running!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return false;
        }

        public static bool StartWatching(this FrmMain frmMain)
        {
            IWatcherService watcherService = WatcherService.GetInstance();

            if (frmMain.listWatchedApps.Items.Count == 0 && !watcherService.IsWatching())
            {
                MessageBox.Show(
                    "Application monitor may only be started when there is at least one application to monitor.",
                    "Application monitor empty!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return false;
            }

            if (watcherService.IsWatching())
            {
                watcherService.StopWatching();
                frmMain.btnStartStop.Text = "Start monitoring";
                frmMain.btnStartStop.Image = Properties.Resources.Start;
            }
            else
            {
                watcherService.StartWatching();
                frmMain.btnStartStop.Text = "Stop monitoring";
                frmMain.btnStartStop.Image = Properties.Resources.Stop;
            }

            return true;
        }
    }
}
