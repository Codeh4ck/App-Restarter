namespace AppRestarter.Forms
{
    partial class FrmSettings
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkAutoStartMonitoring = new System.Windows.Forms.CheckBox();
            this.chkAutoResizeColumns = new System.Windows.Forms.CheckBox();
            this.chkAlwaysShowLog = new System.Windows.Forms.CheckBox();
            this.chkStartWithWindows = new System.Windows.Forms.CheckBox();
            this.chkMinimizeToTray = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtLogsDirectory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkSaveLogsOnDifferentFiles = new System.Windows.Forms.CheckBox();
            this.chkSaveLogsToDisk = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chkAutoCheckForUpdates = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkAutoCheckForUpdates);
            this.groupBox1.Controls.Add(this.chkAutoStartMonitoring);
            this.groupBox1.Controls.Add(this.chkAutoResizeColumns);
            this.groupBox1.Controls.Add(this.chkAlwaysShowLog);
            this.groupBox1.Controls.Add(this.chkStartWithWindows);
            this.groupBox1.Controls.Add(this.chkMinimizeToTray);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 194);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Application";
            // 
            // chkAutoStartMonitoring
            // 
            this.chkAutoStartMonitoring.AutoSize = true;
            this.chkAutoStartMonitoring.Location = new System.Drawing.Point(29, 79);
            this.chkAutoStartMonitoring.Name = "chkAutoStartMonitoring";
            this.chkAutoStartMonitoring.Size = new System.Drawing.Size(246, 19);
            this.chkAutoStartMonitoring.TabIndex = 4;
            this.chkAutoStartMonitoring.Text = "Automatically start monitoring on startup";
            this.chkAutoStartMonitoring.UseVisualStyleBackColor = true;
            // 
            // chkAutoResizeColumns
            // 
            this.chkAutoResizeColumns.AutoSize = true;
            this.chkAutoResizeColumns.Location = new System.Drawing.Point(29, 154);
            this.chkAutoResizeColumns.Name = "chkAutoResizeColumns";
            this.chkAutoResizeColumns.Size = new System.Drawing.Size(181, 19);
            this.chkAutoResizeColumns.TabIndex = 3;
            this.chkAutoResizeColumns.Text = "Automatically resize columns";
            this.chkAutoResizeColumns.UseVisualStyleBackColor = true;
            // 
            // chkAlwaysShowLog
            // 
            this.chkAlwaysShowLog.AutoSize = true;
            this.chkAlwaysShowLog.Location = new System.Drawing.Point(29, 129);
            this.chkAlwaysShowLog.Name = "chkAlwaysShowLog";
            this.chkAlwaysShowLog.Size = new System.Drawing.Size(160, 19);
            this.chkAlwaysShowLog.TabIndex = 2;
            this.chkAlwaysShowLog.Text = "Always show restarter log";
            this.chkAlwaysShowLog.UseVisualStyleBackColor = true;
            // 
            // chkStartWithWindows
            // 
            this.chkStartWithWindows.AutoSize = true;
            this.chkStartWithWindows.Location = new System.Drawing.Point(29, 54);
            this.chkStartWithWindows.Name = "chkStartWithWindows";
            this.chkStartWithWindows.Size = new System.Drawing.Size(202, 19);
            this.chkStartWithWindows.TabIndex = 1;
            this.chkStartWithWindows.Text = "Start App Restarter with Windows";
            this.chkStartWithWindows.UseVisualStyleBackColor = true;
            // 
            // chkMinimizeToTray
            // 
            this.chkMinimizeToTray.AutoSize = true;
            this.chkMinimizeToTray.Location = new System.Drawing.Point(29, 29);
            this.chkMinimizeToTray.Name = "chkMinimizeToTray";
            this.chkMinimizeToTray.Size = new System.Drawing.Size(112, 19);
            this.chkMinimizeToTray.TabIndex = 0;
            this.chkMinimizeToTray.Text = "Minimize to tray";
            this.chkMinimizeToTray.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBrowse);
            this.groupBox2.Controls.Add(this.txtLogsDirectory);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.chkSaveLogsOnDifferentFiles);
            this.groupBox2.Controls.Add(this.chkSaveLogsToDisk);
            this.groupBox2.Location = new System.Drawing.Point(13, 213);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 163);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Logs";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(290, 119);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(30, 23);
            this.btnBrowse.TabIndex = 7;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtLogsDirectory
            // 
            this.txtLogsDirectory.BackColor = System.Drawing.SystemColors.Window;
            this.txtLogsDirectory.Location = new System.Drawing.Point(29, 119);
            this.txtLogsDirectory.Name = "txtLogsDirectory";
            this.txtLogsDirectory.ReadOnly = true;
            this.txtLogsDirectory.Size = new System.Drawing.Size(255, 23);
            this.txtLogsDirectory.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Logs directory:";
            // 
            // chkSaveLogsOnDifferentFiles
            // 
            this.chkSaveLogsOnDifferentFiles.AutoSize = true;
            this.chkSaveLogsOnDifferentFiles.Location = new System.Drawing.Point(29, 63);
            this.chkSaveLogsOnDifferentFiles.Name = "chkSaveLogsOnDifferentFiles";
            this.chkSaveLogsOnDifferentFiles.Size = new System.Drawing.Size(186, 19);
            this.chkSaveLogsOnDifferentFiles.TabIndex = 4;
            this.chkSaveLogsOnDifferentFiles.Text = "Save app logs on seperate files";
            this.chkSaveLogsOnDifferentFiles.UseVisualStyleBackColor = true;
            // 
            // chkSaveLogsToDisk
            // 
            this.chkSaveLogsToDisk.AutoSize = true;
            this.chkSaveLogsToDisk.Location = new System.Drawing.Point(29, 38);
            this.chkSaveLogsToDisk.Name = "chkSaveLogsToDisk";
            this.chkSaveLogsToDisk.Size = new System.Drawing.Size(113, 19);
            this.chkSaveLogsToDisk.TabIndex = 3;
            this.chkSaveLogsToDisk.Text = "Save logs to disk";
            this.chkSaveLogsToDisk.UseVisualStyleBackColor = true;
            this.chkSaveLogsToDisk.CheckedChanged += new System.EventHandler(this.chkSaveLogsToDisk_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(278, 382);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(197, 382);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // chkAutoCheckForUpdates
            // 
            this.chkAutoCheckForUpdates.AutoSize = true;
            this.chkAutoCheckForUpdates.Location = new System.Drawing.Point(29, 104);
            this.chkAutoCheckForUpdates.Name = "chkAutoCheckForUpdates";
            this.chkAutoCheckForUpdates.Size = new System.Drawing.Size(197, 19);
            this.chkAutoCheckForUpdates.TabIndex = 5;
            this.chkAutoCheckForUpdates.Text = "Automatically check for updates";
            this.chkAutoCheckForUpdates.UseVisualStyleBackColor = true;
            // 
            // FrmSettings
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(365, 417);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmSettings";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "App Restarter - Settings";
            this.Load += new System.EventHandler(this.FrmSettings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkAlwaysShowLog;
        private System.Windows.Forms.CheckBox chkStartWithWindows;
        private System.Windows.Forms.CheckBox chkMinimizeToTray;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkSaveLogsOnDifferentFiles;
        private System.Windows.Forms.CheckBox chkSaveLogsToDisk;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtLogsDirectory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chkAutoResizeColumns;
        private System.Windows.Forms.CheckBox chkAutoStartMonitoring;
        private System.Windows.Forms.CheckBox chkAutoCheckForUpdates;
    }
}