namespace AppRestarter.Forms
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.listWatchedApps = new System.Windows.Forms.ListView();
            this.columnBaseDirectory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAppName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCmdArguments = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnShowWindow = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnRunOnCmd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLogEvents = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPollInterval = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnRestartAfter = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnRestartCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showAppRestarterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gitHubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.statusStripLabelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.cmsMain.SuspendLayout();
            this.cmsTray.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // listWatchedApps
            // 
            this.listWatchedApps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listWatchedApps.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnBaseDirectory,
            this.columnAppName,
            this.columnCmdArguments,
            this.columnShowWindow,
            this.columnRunOnCmd,
            this.columnLogEvents,
            this.columnPollInterval,
            this.columnRestartAfter,
            this.columnRestartCount});
            this.listWatchedApps.ContextMenuStrip = this.cmsMain;
            this.listWatchedApps.FullRowSelect = true;
            this.listWatchedApps.HideSelection = false;
            this.listWatchedApps.Location = new System.Drawing.Point(0, 24);
            this.listWatchedApps.Name = "listWatchedApps";
            this.listWatchedApps.Size = new System.Drawing.Size(1396, 673);
            this.listWatchedApps.TabIndex = 0;
            this.listWatchedApps.UseCompatibleStateImageBehavior = false;
            this.listWatchedApps.View = System.Windows.Forms.View.Details;
            // 
            // columnBaseDirectory
            // 
            this.columnBaseDirectory.Text = "Base Directory";
            this.columnBaseDirectory.Width = 128;
            // 
            // columnAppName
            // 
            this.columnAppName.Text = "Application Name";
            this.columnAppName.Width = 190;
            // 
            // columnCmdArguments
            // 
            this.columnCmdArguments.Text = "Cmd Arguments";
            this.columnCmdArguments.Width = 163;
            // 
            // columnShowWindow
            // 
            this.columnShowWindow.Text = "Show Window";
            this.columnShowWindow.Width = 155;
            // 
            // columnRunOnCmd
            // 
            this.columnRunOnCmd.Text = "Run on Cmd";
            this.columnRunOnCmd.Width = 131;
            // 
            // columnLogEvents
            // 
            this.columnLogEvents.Text = "Log Events";
            this.columnLogEvents.Width = 147;
            // 
            // columnPollInterval
            // 
            this.columnPollInterval.Text = "Poll Interval";
            this.columnPollInterval.Width = 163;
            // 
            // columnRestartAfter
            // 
            this.columnRestartAfter.Text = "Restart After";
            this.columnRestartAfter.Width = 125;
            // 
            // columnRestartCount
            // 
            this.columnRestartCount.Text = "Restart Count";
            this.columnRestartCount.Width = 115;
            // 
            // cmsMain
            // 
            this.cmsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addApplicationToolStripMenuItem,
            this.editSelectedToolStripMenuItem,
            this.removeSelectedToolStripMenuItem});
            this.cmsMain.Name = "cmsMain";
            this.cmsMain.Size = new System.Drawing.Size(164, 70);
            // 
            // addApplicationToolStripMenuItem
            // 
            this.addApplicationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addApplicationToolStripMenuItem.Image")));
            this.addApplicationToolStripMenuItem.Name = "addApplicationToolStripMenuItem";
            this.addApplicationToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.addApplicationToolStripMenuItem.Text = "Add application";
            this.addApplicationToolStripMenuItem.Click += new System.EventHandler(this.addApplicationToolStripMenuItem_Click);
            // 
            // editSelectedToolStripMenuItem
            // 
            this.editSelectedToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editSelectedToolStripMenuItem.Image")));
            this.editSelectedToolStripMenuItem.Name = "editSelectedToolStripMenuItem";
            this.editSelectedToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.editSelectedToolStripMenuItem.Text = "Edit";
            this.editSelectedToolStripMenuItem.Click += new System.EventHandler(this.editSelectedToolStripMenuItem_Click);
            // 
            // removeSelectedToolStripMenuItem
            // 
            this.removeSelectedToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("removeSelectedToolStripMenuItem.Image")));
            this.removeSelectedToolStripMenuItem.Name = "removeSelectedToolStripMenuItem";
            this.removeSelectedToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.removeSelectedToolStripMenuItem.Text = "Remove selected";
            this.removeSelectedToolStripMenuItem.Click += new System.EventHandler(this.removeSelectedToolStripMenuItem_Click);
            // 
            // trayIcon
            // 
            this.trayIcon.ContextMenuStrip = this.cmsTray;
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "App Restarter";
            this.trayIcon.Click += new System.EventHandler(this.trayIcon_Click);
            // 
            // cmsTray
            // 
            this.cmsTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAppRestarterToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.cmsTray.Name = "cmsTray";
            this.cmsTray.Size = new System.Drawing.Size(178, 48);
            // 
            // showAppRestarterToolStripMenuItem
            // 
            this.showAppRestarterToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showAppRestarterToolStripMenuItem.Image")));
            this.showAppRestarterToolStripMenuItem.Name = "showAppRestarterToolStripMenuItem";
            this.showAppRestarterToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.showAppRestarterToolStripMenuItem.Text = "Show App Restarter";
            this.showAppRestarterToolStripMenuItem.Click += new System.EventHandler(this.showAppRestarterToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem1.Image")));
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(177, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1396, 24);
            this.menuStripMain.TabIndex = 1;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showLogToolStripMenuItem,
            this.settingsToolStripMenuItem1});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // showLogToolStripMenuItem
            // 
            this.showLogToolStripMenuItem.Name = "showLogToolStripMenuItem";
            this.showLogToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.showLogToolStripMenuItem.Text = "Show log";
            this.showLogToolStripMenuItem.Click += new System.EventHandler(this.showLogToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem1
            // 
            this.settingsToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("settingsToolStripMenuItem1.Image")));
            this.settingsToolStripMenuItem1.Name = "settingsToolStripMenuItem1";
            this.settingsToolStripMenuItem1.Size = new System.Drawing.Size(123, 22);
            this.settingsToolStripMenuItem1.Text = "Settings";
            this.settingsToolStripMenuItem1.Click += new System.EventHandler(this.settingsToolStripMenuItem1_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gitHubToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // gitHubToolStripMenuItem
            // 
            this.gitHubToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("gitHubToolStripMenuItem.Image")));
            this.gitHubToolStripMenuItem.Name = "gitHubToolStripMenuItem";
            this.gitHubToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.gitHubToolStripMenuItem.Text = "GitHub";
            this.gitHubToolStripMenuItem.Click += new System.EventHandler(this.gitHubToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStripMain
            // 
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStripLabelStatus});
            this.statusStripMain.Location = new System.Drawing.Point(0, 737);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(1396, 22);
            this.statusStripMain.TabIndex = 2;
            this.statusStripMain.Text = "statusStrip1";
            // 
            // statusStripLabelStatus
            // 
            this.statusStripLabelStatus.Name = "statusStripLabelStatus";
            this.statusStripLabelStatus.Size = new System.Drawing.Size(26, 17);
            this.statusStripLabelStatus.Text = "Idle";
            // 
            // btnStartStop
            // 
            this.btnStartStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStartStop.Image")));
            this.btnStartStop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStartStop.Location = new System.Drawing.Point(1264, 701);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(124, 31);
            this.btnStartStop.TabIndex = 3;
            this.btnStartStop.Text = "Start monitoring";
            this.btnStartStop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 759);
            this.Controls.Add(this.btnStartStop);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.listWatchedApps);
            this.Controls.Add(this.menuStripMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmMain";
            this.Text = "App Restarter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Shown += new System.EventHandler(this.FrmMain_Shown);
            this.Resize += new System.EventHandler(this.FrmMain_Resize);
            this.cmsMain.ResumeLayout(false);
            this.cmsTray.ResumeLayout(false);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColumnHeader columnAppName;
        private System.Windows.Forms.ColumnHeader columnBaseDirectory;
        private System.Windows.Forms.ColumnHeader columnCmdArguments;
        private System.Windows.Forms.ColumnHeader columnShowWindow;
        private System.Windows.Forms.ColumnHeader columnPollInterval;
        private System.Windows.Forms.ColumnHeader columnRestartAfter;
        private System.Windows.Forms.ColumnHeader columnRestartCount;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel statusStripLabelStatus;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gitHubToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsMain;
        private System.Windows.Forms.ContextMenuStrip cmsTray;
        private System.Windows.Forms.ToolStripMenuItem addApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editSelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeSelectedToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnLogEvents;
        private System.Windows.Forms.ColumnHeader columnRunOnCmd;
        public System.Windows.Forms.ListView listWatchedApps;
        private System.Windows.Forms.ToolStripMenuItem showAppRestarterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        public System.Windows.Forms.Button btnStartStop;
    }
}

