namespace BMS.Class
{
    partial class frmRestoreDB
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRestoreDB));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.linkBack = new MetroFramework.Controls.MetroLink();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.ProgrSpinnerBK = new MetroFramework.Controls.MetroProgressSpinner();
            this.ProgrBarProcess = new MetroFramework.Controls.MetroProgressBar();
            this.btRestore = new MetroFramework.Controls.MetroButton();
            this.txtLocation = new MetroFramework.Controls.MetroTextBox();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtUserName = new MetroFramework.Controls.MetroTextBox();
            this.txtDbName = new MetroFramework.Controls.MetroTextBox();
            this.lbProcessPercent = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.lbStatus = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cbServerName = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.timerRestore = new System.Windows.Forms.Timer(this.components);
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel1.BackColor = System.Drawing.Color.LightGray;
            this.metroPanel1.Controls.Add(this.linkBack);
            this.metroPanel1.Controls.Add(this.metroPanel2);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(-1, 75);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1369, 450);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // linkBack
            // 
            this.linkBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkBack.BackColor = System.Drawing.Color.Red;
            this.linkBack.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.linkBack.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.linkBack.ForeColor = System.Drawing.Color.White;
            this.linkBack.Image = ((System.Drawing.Image)(resources.GetObject("linkBack.Image")));
            this.linkBack.ImageSize = 30;
            this.linkBack.Location = new System.Drawing.Point(0, 14);
            this.linkBack.Name = "linkBack";
            this.linkBack.Size = new System.Drawing.Size(80, 39);
            this.linkBack.Style = MetroFramework.MetroColorStyle.Blue;
            this.linkBack.TabIndex = 6;
            this.linkBack.UseCustomBackColor = true;
            this.linkBack.UseCustomForeColor = true;
            this.linkBack.UseSelectable = true;
            this.linkBack.Click += new System.EventHandler(this.linkBack_Click);
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.ProgrSpinnerBK);
            this.metroPanel2.Controls.Add(this.ProgrBarProcess);
            this.metroPanel2.Controls.Add(this.btRestore);
            this.metroPanel2.Controls.Add(this.txtLocation);
            this.metroPanel2.Controls.Add(this.txtPassword);
            this.metroPanel2.Controls.Add(this.txtUserName);
            this.metroPanel2.Controls.Add(this.txtDbName);
            this.metroPanel2.Controls.Add(this.lbProcessPercent);
            this.metroPanel2.Controls.Add(this.metroLabel7);
            this.metroPanel2.Controls.Add(this.lbStatus);
            this.metroPanel2.Controls.Add(this.metroLabel6);
            this.metroPanel2.Controls.Add(this.metroLabel5);
            this.metroPanel2.Controls.Add(this.metroLabel4);
            this.metroPanel2.Controls.Add(this.metroLabel3);
            this.metroPanel2.Controls.Add(this.metroLabel2);
            this.metroPanel2.Controls.Add(this.cbServerName);
            this.metroPanel2.Controls.Add(this.metroLabel1);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(349, 14);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(654, 423);
            this.metroPanel2.TabIndex = 5;
            this.metroPanel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // ProgrSpinnerBK
            // 
            this.ProgrSpinnerBK.BackColor = System.Drawing.Color.Red;
            this.ProgrSpinnerBK.Location = new System.Drawing.Point(602, 2);
            this.ProgrSpinnerBK.Maximum = 100;
            this.ProgrSpinnerBK.Name = "ProgrSpinnerBK";
            this.ProgrSpinnerBK.Size = new System.Drawing.Size(35, 36);
            this.ProgrSpinnerBK.Speed = 2F;
            this.ProgrSpinnerBK.TabIndex = 8;
            this.ProgrSpinnerBK.UseCustomBackColor = true;
            this.ProgrSpinnerBK.UseSelectable = true;
            this.ProgrSpinnerBK.UseWaitCursor = true;
            // 
            // ProgrBarProcess
            // 
            this.ProgrBarProcess.Location = new System.Drawing.Point(53, 348);
            this.ProgrBarProcess.Name = "ProgrBarProcess";
            this.ProgrBarProcess.Size = new System.Drawing.Size(549, 13);
            this.ProgrBarProcess.Step = 1;
            this.ProgrBarProcess.TabIndex = 7;
            this.ProgrBarProcess.UseWaitCursor = true;
            // 
            // btRestore
            // 
            this.btRestore.Enabled = false;
            this.btRestore.Location = new System.Drawing.Point(426, 242);
            this.btRestore.Name = "btRestore";
            this.btRestore.Size = new System.Drawing.Size(140, 36);
            this.btRestore.TabIndex = 6;
            this.btRestore.Text = "&Restore";
            this.btRestore.UseSelectable = true;
            this.btRestore.Click += new System.EventHandler(this.btRestore_Click);
            // 
            // txtLocation
            // 
            // 
            // 
            // 
            this.txtLocation.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.txtLocation.CustomButton.Location = new System.Drawing.Point(307, 1);
            this.txtLocation.CustomButton.Name = "";
            this.txtLocation.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLocation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLocation.CustomButton.TabIndex = 1;
            this.txtLocation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLocation.CustomButton.UseSelectable = true;
            this.txtLocation.Lines = new string[0];
            this.txtLocation.Location = new System.Drawing.Point(237, 212);
            this.txtLocation.MaxLength = 32767;
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.PasswordChar = '\0';
            this.txtLocation.PromptText = "Choose the storage location for restore file!";
            this.txtLocation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLocation.SelectedText = "";
            this.txtLocation.SelectionLength = 0;
            this.txtLocation.SelectionStart = 0;
            this.txtLocation.ShortcutsEnabled = true;
            this.txtLocation.ShowButton = true;
            this.txtLocation.ShowClearButton = true;
            this.txtLocation.Size = new System.Drawing.Size(329, 23);
            this.txtLocation.TabIndex = 5;
            this.txtLocation.UseSelectable = true;
            this.txtLocation.WaterMark = "Choose the storage location for restore file!";
            this.txtLocation.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLocation.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtLocation.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.txtLocation_ButtonClick);
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(307, 1);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(237, 183);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.PromptText = "Enter your SQL password!";
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.ShowButton = true;
            this.txtPassword.ShowClearButton = true;
            this.txtPassword.Size = new System.Drawing.Size(329, 23);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.WaterMark = "Enter your SQL password!";
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtUserName
            // 
            // 
            // 
            // 
            this.txtUserName.CustomButton.Image = null;
            this.txtUserName.CustomButton.Location = new System.Drawing.Point(307, 1);
            this.txtUserName.CustomButton.Name = "";
            this.txtUserName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUserName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUserName.CustomButton.TabIndex = 1;
            this.txtUserName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUserName.CustomButton.UseSelectable = true;
            this.txtUserName.Lines = new string[0];
            this.txtUserName.Location = new System.Drawing.Point(237, 154);
            this.txtUserName.MaxLength = 32767;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = '\0';
            this.txtUserName.PromptText = "Enter your SQL username!";
            this.txtUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUserName.SelectedText = "";
            this.txtUserName.SelectionLength = 0;
            this.txtUserName.SelectionStart = 0;
            this.txtUserName.ShortcutsEnabled = true;
            this.txtUserName.ShowButton = true;
            this.txtUserName.ShowClearButton = true;
            this.txtUserName.Size = new System.Drawing.Size(329, 23);
            this.txtUserName.TabIndex = 5;
            this.txtUserName.UseSelectable = true;
            this.txtUserName.WaterMark = "Enter your SQL username!";
            this.txtUserName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUserName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDbName
            // 
            // 
            // 
            // 
            this.txtDbName.CustomButton.Image = null;
            this.txtDbName.CustomButton.Location = new System.Drawing.Point(307, 1);
            this.txtDbName.CustomButton.Name = "";
            this.txtDbName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDbName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDbName.CustomButton.TabIndex = 1;
            this.txtDbName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDbName.CustomButton.UseSelectable = true;
            this.txtDbName.Lines = new string[] {
        "BookstoreDB"};
            this.txtDbName.Location = new System.Drawing.Point(237, 125);
            this.txtDbName.MaxLength = 32767;
            this.txtDbName.Name = "txtDbName";
            this.txtDbName.PasswordChar = '\0';
            this.txtDbName.PromptText = "Enter your database name!";
            this.txtDbName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDbName.SelectedText = "";
            this.txtDbName.SelectionLength = 0;
            this.txtDbName.SelectionStart = 0;
            this.txtDbName.ShortcutsEnabled = true;
            this.txtDbName.ShowButton = true;
            this.txtDbName.ShowClearButton = true;
            this.txtDbName.Size = new System.Drawing.Size(329, 23);
            this.txtDbName.TabIndex = 5;
            this.txtDbName.Text = "BookstoreDB";
            this.txtDbName.UseSelectable = true;
            this.txtDbName.WaterMark = "Enter your database name!";
            this.txtDbName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDbName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbProcessPercent
            // 
            this.lbProcessPercent.AutoSize = true;
            this.lbProcessPercent.BackColor = System.Drawing.Color.Transparent;
            this.lbProcessPercent.ForeColor = System.Drawing.Color.White;
            this.lbProcessPercent.Location = new System.Drawing.Point(314, 316);
            this.lbProcessPercent.Name = "lbProcessPercent";
            this.lbProcessPercent.Size = new System.Drawing.Size(27, 19);
            this.lbProcessPercent.TabIndex = 4;
            this.lbProcessPercent.Text = "0%";
            this.lbProcessPercent.UseCustomBackColor = true;
            this.lbProcessPercent.UseCustomForeColor = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel7.ForeColor = System.Drawing.Color.White;
            this.metroLabel7.Location = new System.Drawing.Point(47, 366);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(50, 19);
            this.metroLabel7.TabIndex = 4;
            this.metroLabel7.Text = "&Status: ";
            this.metroLabel7.UseCustomBackColor = true;
            this.metroLabel7.UseCustomForeColor = true;
            // 
            // lbStatus
            // 
            this.lbStatus.BackColor = System.Drawing.Color.Transparent;
            this.lbStatus.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lbStatus.ForeColor = System.Drawing.Color.White;
            this.lbStatus.Location = new System.Drawing.Point(103, 364);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(499, 19);
            this.lbStatus.TabIndex = 4;
            this.lbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbStatus.UseCustomBackColor = true;
            this.lbStatus.UseCustomForeColor = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.ForeColor = System.Drawing.Color.White;
            this.metroLabel6.Location = new System.Drawing.Point(88, 212);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(112, 19);
            this.metroLabel6.TabIndex = 4;
            this.metroLabel6.Text = "Storage &Location";
            this.metroLabel6.UseCustomBackColor = true;
            this.metroLabel6.UseCustomForeColor = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.ForeColor = System.Drawing.Color.White;
            this.metroLabel5.Location = new System.Drawing.Point(88, 183);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(67, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "&Password";
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.ForeColor = System.Drawing.Color.White;
            this.metroLabel4.Location = new System.Drawing.Point(88, 154);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(71, 19);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "&Username";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.ForeColor = System.Drawing.Color.White;
            this.metroLabel3.Location = new System.Drawing.Point(88, 125);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(106, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "&Database Name";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.ForeColor = System.Drawing.Color.White;
            this.metroLabel2.Location = new System.Drawing.Point(88, 97);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(87, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "&Server Name";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // cbServerName
            // 
            this.cbServerName.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cbServerName.FormattingEnabled = true;
            this.cbServerName.ItemHeight = 19;
            this.cbServerName.Location = new System.Drawing.Point(237, 95);
            this.cbServerName.Name = "cbServerName";
            this.cbServerName.Size = new System.Drawing.Size(329, 25);
            this.cbServerName.TabIndex = 3;
            this.cbServerName.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.BackColor = System.Drawing.Color.Red;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.White;
            this.metroLabel1.Location = new System.Drawing.Point(0, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(654, 39);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "RESTORE DATABASE";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // timerRestore
            // 
            this.timerRestore.Tick += new System.EventHandler(this.timerRestore_Tick);
            // 
            // frmRestoreDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroPanel1);
            this.Name = "frmRestoreDB";
            this.Size = new System.Drawing.Size(1366, 600);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLink linkBack;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroProgressSpinner ProgrSpinnerBK;
        private MetroFramework.Controls.MetroProgressBar ProgrBarProcess;
        private MetroFramework.Controls.MetroButton btRestore;
        private MetroFramework.Controls.MetroTextBox txtLocation;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroTextBox txtUserName;
        private MetroFramework.Controls.MetroTextBox txtDbName;
        private MetroFramework.Controls.MetroLabel lbProcessPercent;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel lbStatus;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cbServerName;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Timer timerRestore;
    }
}
