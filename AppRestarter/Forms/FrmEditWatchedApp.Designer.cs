namespace AppRestarter.Forms
{
    partial class FrmEditWatchedApp
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnArgAdd = new System.Windows.Forms.Button();
            this.btnArgModify = new System.Windows.Forms.Button();
            this.btnArgRemove = new System.Windows.Forms.Button();
            this.listArguments = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkLogAppEvents = new System.Windows.Forms.CheckBox();
            this.cbRestartType = new System.Windows.Forms.ComboBox();
            this.numRestartAfter = new AppRestarter.Forms.Controls.NumericUpDownEx();
            this.label7 = new System.Windows.Forms.Label();
            this.cbPollType = new System.Windows.Forms.ComboBox();
            this.numPollInterval = new AppRestarter.Forms.Controls.NumericUpDownEx();
            this.label6 = new System.Windows.Forms.Label();
            this.chkRunThroughCmd = new System.Windows.Forms.CheckBox();
            this.chkShowWindow = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRestartAfter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPollInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnArgAdd);
            this.groupBox3.Controls.Add(this.btnArgModify);
            this.groupBox3.Controls.Add(this.btnArgRemove);
            this.groupBox3.Controls.Add(this.listArguments);
            this.groupBox3.Location = new System.Drawing.Point(344, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(360, 239);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Command line arguments";
            // 
            // btnArgAdd
            // 
            this.btnArgAdd.Location = new System.Drawing.Point(45, 209);
            this.btnArgAdd.Name = "btnArgAdd";
            this.btnArgAdd.Size = new System.Drawing.Size(99, 23);
            this.btnArgAdd.TabIndex = 8;
            this.btnArgAdd.Text = "Add new";
            this.btnArgAdd.UseVisualStyleBackColor = true;
            this.btnArgAdd.Click += new System.EventHandler(this.btnArgAdd_Click);
            // 
            // btnArgModify
            // 
            this.btnArgModify.Location = new System.Drawing.Point(150, 209);
            this.btnArgModify.Name = "btnArgModify";
            this.btnArgModify.Size = new System.Drawing.Size(99, 23);
            this.btnArgModify.TabIndex = 7;
            this.btnArgModify.Text = "Modify";
            this.btnArgModify.UseVisualStyleBackColor = true;
            this.btnArgModify.Click += new System.EventHandler(this.btnArgModify_Click);
            // 
            // btnArgRemove
            // 
            this.btnArgRemove.Location = new System.Drawing.Point(255, 209);
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
            this.listArguments.Size = new System.Drawing.Size(348, 181);
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
            this.groupBox2.Location = new System.Drawing.Point(12, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 239);
            this.groupBox2.TabIndex = 6;
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
            // numRestartAfter
            // 
            this.numRestartAfter.Location = new System.Drawing.Point(28, 193);
            this.numRestartAfter.Name = "numRestartAfter";
            this.numRestartAfter.Size = new System.Drawing.Size(123, 23);
            this.numRestartAfter.TabIndex = 12;
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
            // numPollInterval
            // 
            this.numPollInterval.Location = new System.Drawing.Point(28, 140);
            this.numPollInterval.Name = "numPollInterval";
            this.numPollInterval.Size = new System.Drawing.Size(123, 23);
            this.numPollInterval.TabIndex = 9;
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
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(468, 270);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(115, 35);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(589, 270);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(115, 35);
            this.btnSaveChanges.TabIndex = 8;
            this.btnSaveChanges.Text = "Save changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // FrmEditWatchedApp
            // 
            this.AcceptButton = this.btnSaveChanges;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(715, 312);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmEditWatchedApp";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "App Restarter - Editing application: ";
            this.Load += new System.EventHandler(this.FrmEditWatchedApp_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRestartAfter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPollInterval)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnArgAdd;
        private System.Windows.Forms.Button btnArgModify;
        private System.Windows.Forms.Button btnArgRemove;
        private System.Windows.Forms.ListView listArguments;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkLogAppEvents;
        private System.Windows.Forms.ComboBox cbRestartType;
        private Controls.NumericUpDownEx numRestartAfter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbPollType;
        private Controls.NumericUpDownEx numPollInterval;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkRunThroughCmd;
        private System.Windows.Forms.CheckBox chkShowWindow;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveChanges;
    }
}