using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using AppRestarter.Core.Containers;
using AppRestarter.Core.Observers;
using AppRestarter.Core.Services;
using AppRestarter.Models;
using AppRestarter.Utilities;
using AppRestarter.Utilities.Extensions;

namespace AppRestarter.Forms
{
    public partial class FrmMain : Form
    {
        private readonly IAppContainer _appContainer;
        private readonly ISettingsContainer _settingsContainer;
        private readonly IWatcherService _watcherService;

        public FrmMain()
        {
            _appContainer = AppContainer.GetInstance();
            _settingsContainer = SettingsContainer.GetInstance();
            _watcherService = WatcherService.GetInstance();

            IWatcherStatusObserver watcherStatusObserver = WatcherStatusObserver.GetInstance();
            watcherStatusObserver.OnWatcherStatusChanged += WatcherStatusObserver_OnWatcherStatusChanged;

            IRestartObserver restartObserver = RestartObserver.GetInstance();
            restartObserver.OnWatchedAppRestarted += RestartObserver_OnWatchedAppRestarted;

            ISettingsChangeObserver settingsChangeObserver = SettingsChangeObserver.GetInstance();
            settingsChangeObserver.OnSettingsChanged += SettingsChangeObserver_OnSettingsChanged;

            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            Settings settings = _settingsContainer.GetSettings();
            Location = settings.WindowPosition;

            if (settings.MinimizeToTray)
                trayIcon.Visible = true;

            List<WatchedApp> watchedApps = _appContainer.GetWatchedApps();
            
            foreach(WatchedApp app in watchedApps)
                this.AddWatchedApp(app);

            if (settings.AutoResizeColumns)
            {
                listWatchedApps.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                listWatchedApps.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }

            if (settings.AlwaysShowLog)
                FrmLog.GetInstance().Show();
        }

        private void FrmMain_Resize(object sender, EventArgs e)
        {
            Settings settings = _settingsContainer.GetSettings();

            if (settings.MinimizeToTray && WindowState == FormWindowState.Minimized)
                Hide();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings settings = _settingsContainer.GetSettings();
            settings.WindowPosition = Location;

            _settingsContainer.ModifySettings(settings);
            _settingsContainer.SaveSettings();

            _appContainer.SaveApplications();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using FrmAbout frmAbout = new();
            frmAbout.ShowDialog(this);
        }

        private void trayIcon_Click(object sender, EventArgs e)
        {
            Visible = true;
            WindowState = FormWindowState.Normal;
        }

        private void showLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FrmLog.GetInstance().Visible)
                FrmLog.GetInstance().Show();
        }

        private void settingsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using FrmSettings settings = new();
            settings.ShowDialog(this);
        }

        private void addApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using FrmAddWatchedApp frmAddWatchedApp = new(new AppContainer());
            frmAddWatchedApp.ShowDialog(this);

            WatchedApp app = frmAddWatchedApp.WatchedApp;
            if (app == null) return;

            _appContainer.AddApplication(app);
            this.AddWatchedApp(app);
        }

        private void removeSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listWatchedApps.SelectedItems.Count == 0) return;

            DialogResult shouldRemoveApps = MessageBox.Show("Are you sure you would like to remove the selected monitored applications?",
                "Confirm removal!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (shouldRemoveApps == DialogResult.No) return;

            foreach (ListViewItem item in listWatchedApps.SelectedItems)
            {
                if (item.Tag is WatchedApp tag) _appContainer.TryRemoveApplication(tag);
                listWatchedApps.Items.Remove(item);
            }
        }

        private void showAppRestarterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visible = true;
            WindowState = FormWindowState.Normal;
        }

        private void SettingsChangeObserver_OnSettingsChanged(Settings settings)
        {
            trayIcon.Visible = settings.MinimizeToTray;

            if (settings.StartWithWindows) Startup.AddToStartup();
            else Startup.RemoveFromStartup();
        }

        private void WatcherStatusObserver_OnWatcherStatusChanged(WatcherStatus status) => statusStripLabelStatus.Text = $"Watcher status: {status:F}";
        private void RestartObserver_OnWatchedAppRestarted(WatchedApp app) => this.UpdateAppRestartCount(app);
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e) => Environment.Exit(0);
        private void exitToolStripMenuItem_Click(object sender, EventArgs e) => Environment.Exit(0);
        private void startWatchingSelectedToolStripMenuItem_Click(object sender, EventArgs e) => _watcherService.StartWatching();
        private void stopWatchingSelectedToolStripMenuItem_Click(object sender, EventArgs e) => _watcherService.StopWatching();
        private void editSelectedToolStripMenuItem_Click(object sender, EventArgs e) => this.EditWatchedApp();
        private void gitHubToolStripMenuItem_Click(object sender, EventArgs e) => Process.Start("https://github.com/Codeh4ck/App-Restarter");

    }
}
