using AppRestarter.Forms.Controls;

namespace AppRestarter.Forms
{
    partial class FrmAddWatchedApp
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
            this.labelExecutableName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelDirectory = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkLogAppEvents = new System.Windows.Forms.CheckBox();
            this.cbRestartType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbPollType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkRunThroughCmd = new System.Windows.Forms.CheckBox();
            this.chkShowWindow = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnArgAdd = new System.Windows.Forms.Button();
            this.btnArgModify = new System.Windows.Forms.Button();
            this.btnArgRemove = new System.Windows.Forms.Button();
            this.listArguments = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddApp = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.labelReadme = new System.Windows.Forms.LinkLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelWhatIsThis = new System.Windows.Forms.LinkLabel();
            this.chkPassCmdArgsOnly = new System.Windows.Forms.CheckBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtAppPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numRestartAfter = new AppRestarter.Forms.Controls.NumericUpDownEx();
            this.numPollInterval = new AppRestarter.Forms.Controls.NumericUpDownEx();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRestartAfter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPollInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelExecutableName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.labelDirectory);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(15, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 145);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Application details";
            // 
            // labelExecutableName
            // 
            this.labelExecutableName.AutoSize = true;
            this.labelExecutableName.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelExecutableName.Location = new System.Drawing.Point(36, 104);
            this.labelExecutableName.Name = "labelExecutableName";
            this.labelExecutableName.Size = new System.Drawing.Size(12, 15);
            this.labelExecutableName.TabIndex = 7;
            this.labelExecutableName.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Executable name:";
            // 
            // labelDirectory
            // 
            this.labelDirectory.AutoSize = true;
            this.labelDirectory.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelDirectory.Location = new System.Drawing.Point(36, 54);
            this.labelDirectory.Name = "labelDirectory";
            this.labelDirectory.Size = new System.Drawing.Size(12, 15);
            this.labelDirectory.TabIndex = 5;
            this.labelDirectory.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Base directory:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkLogAppEvents);
            this.groupBox2.Controls.Add(this.cbRestartType);
            this.groupBox2.Controls.Add(this.numRestartAfter);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cbPollType);
            this.groupBox2.Controls.Add(this.numPollInterval);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.chkRunThroughCmd);
            this.groupBox2.Controls.Add(this.chkShowWindow);
            this.groupBox2.Location = new System.Drawing.Point(15, 291);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 239);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings";
            // 
            // chkLogAppEvents
            // 
            this.chkLogAppEvents.AutoSize = true;
            this.chkLogAppEvents.Location = new System.Drawing.Point(28, 77);
            this.chkLogAppEvents.Name = "chkLogAppEvents";
            this.chkLogAppEvents.Size = new System.Drawing.Size(145, 19);
            this.chkLogAppEvents.TabIndex = 14;
            this.chkLogAppEvents.Text = "Log application events";
            this.chkLogAppEvents.UseVisualStyleBackColor = true;
            // 
            // cbRestartType
            // 
            this.cbRestartType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRestartType.FormattingEnabled = true;
            this.cbRestartType.Items.AddRange(new object[] {
            "Milliseconds",
            "Seconds",
            "Minutes",
            "Hours"});
            this.cbRestartType.Location = new System.Drawing.Point(157, 193);
            this.cbRestartType.Name = "cbRestartType";
            this.cbRestartType.Size = new System.Drawing.Size(121, 23);
            this.cbRestartType.TabIndex = 13;
            this.cbRestartType.SelectedIndexChanged += new System.EventHandler(this.cbRestartType_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Restart after:";
            // 
            // cbPollType
            // 
            this.cbPollType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPollType.FormattingEnabled = true;
            this.cbPollType.Items.AddRange(new object[] {
            "Milliseconds",
            "Seconds",
            "Minutes",
            "Hours"});
            this.cbPollType.Location = new System.Drawing.Point(157, 140);
            this.cbPollType.Name = "cbPollType";
            this.cbPollType.Size = new System.Drawing.Size(121, 23);
            this.cbPollType.TabIndex = 10;
            this.cbPollType.SelectedIndexChanged += new System.EventHandler(this.cbPollType_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Poll interval:";
            // 
            // chkRunThroughCmd
            // 
            this.chkRunThroughCmd.AutoSize = true;
            this.chkRunThroughCmd.Location = new System.Drawing.Point(28, 52);
            this.chkRunThroughCmd.Name = "chkRunThroughCmd";
            this.chkRunThroughCmd.Size = new System.Drawing.Size(141, 19);
            this.chkRunThroughCmd.TabIndex = 1;
            this.chkRunThroughCmd.Text = "Run through cmd.exe";
            this.chkRunThroughCmd.UseVisualStyleBackColor = true;
            // 
            // chkShowWindow
            // 
            this.chkShowWindow.AutoSize = true;
            this.chkShowWindow.Location = new System.Drawing.Point(28, 27);
            this.chkShowWindow.Name = "chkShowWindow";
            this.chkShowWindow.Size = new System.Drawing.Size(100, 19);
            this.chkShowWindow.TabIndex = 0;
            this.chkShowWindow.Text = "Show window";
            this.chkShowWindow.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnArgAdd);
            this.groupBox3.Controls.Add(this.btnArgModify);
            this.groupBox3.Controls.Add(this.btnArgRemove);
            this.groupBox3.Controls.Add(this.listArguments);
            this.groupBox3.Location = new System.Drawing.Point(347, 139);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(360, 391);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Command line arguments";
            // 
            // btnArgAdd
            // 
            this.btnArgAdd.Location = new System.Drawing.Point(45, 362);
            this.btnArgAdd.Name = "btnArgAdd";
            this.btnArgAdd.Size = new System.Drawing.Size(99, 23);
            this.btnArgAdd.TabIndex = 8;
            this.btnArgAdd.Text = "Add new";
            this.btnArgAdd.UseVisualStyleBackColor = true;
            this.btnArgAdd.Click += new System.EventHandler(this.btnArgAdd_Click);
            // 
            // btnArgModify
            // 
            this.btnArgModify.Location = new System.Drawing.Point(150, 362);
            this.btnArgModify.Name = "btnArgModify";
            this.btnArgModify.Size = new System.Drawing.Size(99, 23);
            this.btnArgModify.TabIndex = 7;
            this.btnArgModify.Text = "Modify";
            this.btnArgModify.UseVisualStyleBackColor = true;
            this.btnArgModify.Click += new System.EventHandler(this.btnArgModify_Click);
            // 
            // btnArgRemove
            // 
            this.btnArgRemove.Location = new System.Drawing.Point(255, 362);
            this.btnArgRemove.Name = "btnArgRemove";
            this.btnArgRemove.Size = new System.Drawing.Size(99, 23);
            this.btnArgRemove.TabIndex = 6;
            this.btnArgRemove.Text = "Remove";
            this.btnArgRemove.UseVisualStyleBackColor = true;
            this.btnArgRemove.Click += new System.EventHandler(this.btnArgRemove_Click);
            // 
            // listArguments
            // 
            this.listArguments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listArguments.FullRowSelect = true;
            this.listArguments.HideSelection = false;
            this.listArguments.Location = new System.Drawing.Point(6, 22);
            this.listArguments.Name = "listArguments";
            this.listArguments.Size = new System.Drawing.Size(348, 334);
            this.listArguments.TabIndex = 0;
            this.listArguments.UseCompatibleStateImageBehavior = false;
            this.listArguments.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Argument";
            this.columnHeader1.Width = 104;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Value";
            this.columnHeader2.Width = 183;
            // 
            // btnAddApp
            // 
            this.btnAddApp.Location = new System.Drawing.Point(592, 541);
            this.btnAddApp.Name = "btnAddApp";
            this.btnAddApp.Size = new System.Drawing.Size(115, 35);
            this.btnAddApp.TabIndex = 6;
            this.btnAddApp.Text = "Add application";
            this.btnAddApp.UseVisualStyleBackColor = true;
            this.btnAddApp.Click += new System.EventHandler(this.btnAddApp_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(471, 541);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(115, 35);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 551);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "For help with settings visit";
            // 
            // labelReadme
            // 
            this.labelReadme.AutoSize = true;
            this.labelReadme.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.labelReadme.Location = new System.Drawing.Point(161, 551);
            this.labelReadme.Name = "labelReadme";
            this.labelReadme.Size = new System.Drawing.Size(73, 15);
            this.labelReadme.TabIndex = 9;
            this.labelReadme.TabStop = true;
            this.labelReadme.Text = "the README";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labelWhatIsThis);
            this.groupBox4.Controls.Add(this.chkPassCmdArgsOnly);
            this.groupBox4.Controls.Add(this.btnBrowse);
            this.groupBox4.Controls.Add(this.txtAppPath);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(15, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(692, 121);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Application selection";
            // 
            // labelWhatIsThis
            // 
            this.labelWhatIsThis.AutoSize = true;
            this.labelWhatIsThis.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.labelWhatIsThis.Location = new System.Drawing.Point(250, 82);
            this.labelWhatIsThis.Name = "labelWhatIsThis";
            this.labelWhatIsThis.Size = new System.Drawing.Size(73, 15);
            this.labelWhatIsThis.TabIndex = 12;
            this.labelWhatIsThis.TabStop = true;
            this.labelWhatIsThis.Text = "What is this?";
            this.labelWhatIsThis.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelWhatIsThis_LinkClicked);
            // 
            // chkPassCmdArgsOnly
            // 
            this.chkPassCmdArgsOnly.AutoSize = true;
            this.chkPassCmdArgsOnly.Location = new System.Drawing.Point(28, 81);
            this.chkPassCmdArgsOnly.Name = "chkPassCmdArgsOnly";
            this.chkPassCmdArgsOnly.Size = new System.Drawing.Size(215, 19);
            this.chkPassCmdArgsOnly.TabIndex = 14;
            this.chkPassCmdArgsOnly.Text = "Pass command line arguments only";
            this.chkPassCmdArgsOnly.UseVisualStyleBackColor = true;
            this.chkPassCmdArgsOnly.CheckedChanged += new System.EventHandler(this.chkPassCmdArgsOnly_CheckedChanged);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(628, 47);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(42, 23);
            this.btnBrowse.TabIndex = 13;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtAppPath
            // 
            this.txtAppPath.BackColor = System.Drawing.SystemColors.Window;
            this.txtAppPath.Location = new System.Drawing.Point(28, 48);
            this.txtAppPath.Name = "txtAppPath";
            this.txtAppPath.ReadOnly = true;
            this.txtAppPath.Size = new System.Drawing.Size(594, 23);
            this.txtAppPath.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Application path:";
            // 
            // numRestartAfter
            // 
            this.numRestartAfter.Location = new System.Drawing.Point(28, 193);
            this.numRestartAfter.Name = "numRestartAfter";
            this.numRestartAfter.Size = new System.Drawing.Size(123, 23);
            this.numRestartAfter.TabIndex = 12;
            // 
            // numPollInterval
            // 
            this.numPollInterval.Location = new System.Drawing.Point(28, 140);
            this.numPollInterval.Name = "numPollInterval";
            this.numPollInterval.Size = new System.Drawing.Size(123, 23);
            this.numPollInterval.TabIndex = 9;
            // 
            // FrmAddWatchedApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 591);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.labelReadme);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddApp);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmAddWatchedApp";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "App Restarter - Add application";
            this.Load += new System.EventHandler(this.FrmAddWatchedApp_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRestartAfter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPollInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelExecutableName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelDirectory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkShowWindow;
        private System.Windows.Forms.ComboBox cbRestartType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbPollType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkRunThroughCmd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnArgAdd;
        private System.Windows.Forms.Button btnArgModify;
        private System.Windows.Forms.Button btnArgRemove;
        private System.Windows.Forms.ListView listArguments;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnAddApp;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel labelReadme;
        private System.Windows.Forms.CheckBox chkLogAppEvents;
        private NumericUpDownEx numRestartAfter;
        private NumericUpDownEx numPollInterval;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.LinkLabel labelWhatIsThis;
        private System.Windows.Forms.CheckBox chkPassCmdArgsOnly;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtAppPath;
        private System.Windows.Forms.Label label1;
    }
}