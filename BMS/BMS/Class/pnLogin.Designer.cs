namespace BMS.Class
{
    partial class pnLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pnLogin));
            this.pnSettings = new MetroFramework.Controls.MetroPanel();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.tcSettings = new MetroFramework.Controls.MetroTabControl();
            this.tpConnection = new MetroFramework.Controls.MetroTabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdSQLServerAuthentication = new MetroFramework.Controls.MetroRadioButton();
            this.rdWindowsAuthentication = new MetroFramework.Controls.MetroRadioButton();
            this.txtDbPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtDbUserName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.cbServerName = new MetroFramework.Controls.MetroComboBox();
            this.txtDbName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btSave = new MetroFramework.Controls.MetroButton();
            this.btConnect = new MetroFramework.Controls.MetroButton();
            this.tabTheme = new MetroFramework.Controls.MetroTabPage();
            this.rdLight = new MetroFramework.Controls.MetroRadioButton();
            this.rdDark = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.flpSettings = new System.Windows.Forms.FlowLayoutPanel();
            this.linkBack = new MetroFramework.Controls.MetroLink();
            this.pnCenter = new MetroFramework.Controls.MetroPanel();
            this.btExit = new MetroFramework.Controls.MetroButton();
            this.btLogin = new MetroFramework.Controls.MetroButton();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtUserName = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroToolTipLogin = new MetroFramework.Components.MetroToolTip();
            this.pnSettings.SuspendLayout();
            this.tcSettings.SuspendLayout();
            this.tpConnection.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabTheme.SuspendLayout();
            this.pnCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnSettings
            // 
            this.pnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnSettings.Controls.Add(this.metroPanel3);
            this.pnSettings.Controls.Add(this.tcSettings);
            this.pnSettings.Controls.Add(this.linkBack);
            this.pnSettings.Font = new System.Drawing.Font("UTM Avo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnSettings.HorizontalScrollbarBarColor = true;
            this.pnSettings.HorizontalScrollbarHighlightOnWheel = false;
            this.pnSettings.HorizontalScrollbarSize = 10;
            this.pnSettings.Location = new System.Drawing.Point(745, 0);
            this.pnSettings.Name = "pnSettings";
            this.pnSettings.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.pnSettings.Size = new System.Drawing.Size(304, 519);
            this.pnSettings.Style = MetroFramework.MetroColorStyle.Blue;
            this.pnSettings.TabIndex = 1;
            this.pnSettings.VerticalScrollbarBarColor = true;
            this.pnSettings.VerticalScrollbarHighlightOnWheel = false;
            this.pnSettings.VerticalScrollbarSize = 10;
            this.pnSettings.Visible = false;
            // 
            // metroPanel3
            // 
            this.metroPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.metroPanel3.BackColor = System.Drawing.Color.Black;
            this.metroPanel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(-2, 1);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(4, 519);
            this.metroPanel3.TabIndex = 0;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // tcSettings
            // 
            this.tcSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tcSettings.Controls.Add(this.tpConnection);
            this.tcSettings.Controls.Add(this.tabTheme);
            this.tcSettings.Location = new System.Drawing.Point(11, 59);
            this.tcSettings.Name = "tcSettings";
            this.tcSettings.SelectedIndex = 0;
            this.tcSettings.Size = new System.Drawing.Size(279, 456);
            this.tcSettings.TabIndex = 2;
            this.tcSettings.TabStop = false;
            this.tcSettings.UseSelectable = true;
            // 
            // tpConnection
            // 
            this.tpConnection.Controls.Add(this.groupBox1);
            this.tpConnection.Controls.Add(this.cbServerName);
            this.tpConnection.Controls.Add(this.txtDbName);
            this.tpConnection.Controls.Add(this.metroLabel4);
            this.tpConnection.Controls.Add(this.metroLabel3);
            this.tpConnection.Controls.Add(this.btSave);
            this.tpConnection.Controls.Add(this.btConnect);
            this.tpConnection.Font = new System.Drawing.Font("UTM Avo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpConnection.HorizontalScrollbarBarColor = true;
            this.tpConnection.HorizontalScrollbarHighlightOnWheel = false;
            this.tpConnection.HorizontalScrollbarSize = 10;
            this.tpConnection.Location = new System.Drawing.Point(4, 38);
            this.tpConnection.Name = "tpConnection";
            this.tpConnection.Size = new System.Drawing.Size(271, 414);
            this.tpConnection.TabIndex = 0;
            this.tpConnection.Text = "&connection";
            this.tpConnection.VerticalScrollbarBarColor = true;
            this.tpConnection.VerticalScrollbarHighlightOnWheel = false;
            this.tpConnection.VerticalScrollbarSize = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdSQLServerAuthentication);
            this.groupBox1.Controls.Add(this.rdWindowsAuthentication);
            this.groupBox1.Controls.Add(this.txtDbPassword);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.txtDbUserName);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Font = new System.Drawing.Font("UTM Avo", 8.5F);
            this.groupBox1.Location = new System.Drawing.Point(3, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 178);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Authentication mode";
            // 
            // rdSQLServerAuthentication
            // 
            this.rdSQLServerAuthentication.BackColor = System.Drawing.SystemColors.Control;
            this.rdSQLServerAuthentication.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rdSQLServerAuthentication.Location = new System.Drawing.Point(21, 48);
            this.rdSQLServerAuthentication.Name = "rdSQLServerAuthentication";
            this.rdSQLServerAuthentication.Size = new System.Drawing.Size(204, 24);
            this.rdSQLServerAuthentication.TabIndex = 2;
            this.rdSQLServerAuthentication.TabStop = true;
            this.rdSQLServerAuthentication.Text = "SQL Server Authentication";
            this.metroToolTipLogin.SetToolTip(this.rdSQLServerAuthentication, "SQL Server Authentication");
            this.rdSQLServerAuthentication.UseCustomBackColor = true;
            this.rdSQLServerAuthentication.UseSelectable = true;
            this.rdSQLServerAuthentication.UseStyleColors = true;
            this.rdSQLServerAuthentication.CheckedChanged += new System.EventHandler(this.rdSQLServerAuthentication_CheckedChanged);
            // 
            // rdWindowsAuthentication
            // 
            this.rdWindowsAuthentication.BackColor = System.Drawing.SystemColors.Control;
            this.rdWindowsAuthentication.Checked = true;
            this.rdWindowsAuthentication.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rdWindowsAuthentication.Location = new System.Drawing.Point(21, 25);
            this.rdWindowsAuthentication.Name = "rdWindowsAuthentication";
            this.rdWindowsAuthentication.Size = new System.Drawing.Size(204, 24);
            this.rdWindowsAuthentication.TabIndex = 1;
            this.rdWindowsAuthentication.TabStop = true;
            this.rdWindowsAuthentication.Text = "Windows Authentication";
            this.metroToolTipLogin.SetToolTip(this.rdWindowsAuthentication, "Windows Authentication");
            this.rdWindowsAuthentication.UseCustomBackColor = true;
            this.rdWindowsAuthentication.UseSelectable = true;
            this.rdWindowsAuthentication.UseStyleColors = true;
            this.rdWindowsAuthentication.CheckedChanged += new System.EventHandler(this.rdWindowsAuthentication_CheckedChanged);
            // 
            // txtDbPassword
            // 
            // 
            // 
            // 
            this.txtDbPassword.CustomButton.Image = null;
            this.txtDbPassword.CustomButton.Location = new System.Drawing.Point(176, 1);
            this.txtDbPassword.CustomButton.Name = "";
            this.txtDbPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDbPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDbPassword.CustomButton.TabIndex = 1;
            this.txtDbPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDbPassword.CustomButton.UseSelectable = true;
            this.txtDbPassword.CustomButton.Visible = false;
            this.txtDbPassword.Enabled = false;
            this.txtDbPassword.Lines = new string[0];
            this.txtDbPassword.Location = new System.Drawing.Point(39, 142);
            this.txtDbPassword.MaxLength = 50;
            this.txtDbPassword.Name = "txtDbPassword";
            this.txtDbPassword.PasswordChar = '●';
            this.txtDbPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDbPassword.SelectedText = "";
            this.txtDbPassword.SelectionLength = 0;
            this.txtDbPassword.SelectionStart = 0;
            this.txtDbPassword.ShortcutsEnabled = true;
            this.txtDbPassword.Size = new System.Drawing.Size(198, 23);
            this.txtDbPassword.TabIndex = 4;
            this.metroToolTipLogin.SetToolTip(this.txtDbPassword, "SQL user password");
            this.txtDbPassword.UseSelectable = true;
            this.txtDbPassword.UseSystemPasswordChar = true;
            this.txtDbPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDbPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel5.Location = new System.Drawing.Point(36, 80);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(64, 15);
            this.metroLabel5.TabIndex = 0;
            this.metroLabel5.Text = "&User Name";
            this.metroLabel5.UseCustomBackColor = true;
            // 
            // txtDbUserName
            // 
            // 
            // 
            // 
            this.txtDbUserName.CustomButton.Image = null;
            this.txtDbUserName.CustomButton.Location = new System.Drawing.Point(176, 1);
            this.txtDbUserName.CustomButton.Name = "";
            this.txtDbUserName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDbUserName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDbUserName.CustomButton.TabIndex = 1;
            this.txtDbUserName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDbUserName.CustomButton.UseSelectable = true;
            this.txtDbUserName.CustomButton.Visible = false;
            this.txtDbUserName.Enabled = false;
            this.txtDbUserName.Lines = new string[0];
            this.txtDbUserName.Location = new System.Drawing.Point(39, 98);
            this.txtDbUserName.MaxLength = 50;
            this.txtDbUserName.Name = "txtDbUserName";
            this.txtDbUserName.PasswordChar = '\0';
            this.txtDbUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDbUserName.SelectedText = "";
            this.txtDbUserName.SelectionLength = 0;
            this.txtDbUserName.SelectionStart = 0;
            this.txtDbUserName.ShortcutsEnabled = true;
            this.txtDbUserName.Size = new System.Drawing.Size(198, 23);
            this.txtDbUserName.TabIndex = 3;
            this.metroToolTipLogin.SetToolTip(this.txtDbUserName, "SQL username");
            this.txtDbUserName.UseSelectable = true;
            this.txtDbUserName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDbUserName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel6.Location = new System.Drawing.Point(36, 124);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(55, 15);
            this.metroLabel6.TabIndex = 0;
            this.metroLabel6.Text = "&Password";
            this.metroLabel6.UseCustomBackColor = true;
            // 
            // cbServerName
            // 
            this.cbServerName.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cbServerName.FormattingEnabled = true;
            this.cbServerName.ItemHeight = 19;
            this.cbServerName.Location = new System.Drawing.Point(6, 38);
            this.cbServerName.Name = "cbServerName";
            this.cbServerName.Size = new System.Drawing.Size(262, 25);
            this.cbServerName.TabIndex = 0;
            this.cbServerName.TabStop = false;
            this.metroToolTipLogin.SetToolTip(this.cbServerName, "Choose the Server name.");
            this.cbServerName.UseSelectable = true;
            // 
            // txtDbName
            // 
            // 
            // 
            // 
            this.txtDbName.CustomButton.Image = null;
            this.txtDbName.CustomButton.Location = new System.Drawing.Point(240, 1);
            this.txtDbName.CustomButton.Name = "";
            this.txtDbName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDbName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDbName.CustomButton.TabIndex = 1;
            this.txtDbName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDbName.CustomButton.UseSelectable = true;
            this.txtDbName.CustomButton.Visible = false;
            this.txtDbName.Lines = new string[] {
        "BookstoreDB"};
            this.txtDbName.Location = new System.Drawing.Point(6, 86);
            this.txtDbName.MaxLength = 50;
            this.txtDbName.Name = "txtDbName";
            this.txtDbName.PasswordChar = '\0';
            this.txtDbName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDbName.SelectedText = "";
            this.txtDbName.SelectionLength = 0;
            this.txtDbName.SelectionStart = 0;
            this.txtDbName.ShortcutsEnabled = true;
            this.txtDbName.Size = new System.Drawing.Size(262, 23);
            this.txtDbName.TabIndex = 0;
            this.txtDbName.Text = "BookstoreDB";
            this.metroToolTipLogin.SetToolTip(this.txtDbName, "Database name");
            this.txtDbName.UseSelectable = true;
            this.txtDbName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDbName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(3, 68);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(100, 15);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "&Database Name";
            // 
            // metroLabel3
            // 
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(3, 19);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(91, 15);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "&Server Name";
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(168, 309);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(100, 23);
            this.btSave.TabIndex = 4;
            this.btSave.Text = "&Save";
            this.metroToolTipLogin.SetToolTip(this.btSave, "Save the connection string.");
            this.btSave.UseSelectable = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(62, 309);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(100, 23);
            this.btConnect.TabIndex = 3;
            this.btConnect.Text = "&Test Connection";
            this.metroToolTipLogin.SetToolTip(this.btConnect, "Test the connection.");
            this.btConnect.UseSelectable = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // tabTheme
            // 
            this.tabTheme.Controls.Add(this.rdLight);
            this.tabTheme.Controls.Add(this.rdDark);
            this.tabTheme.Controls.Add(this.metroLabel2);
            this.tabTheme.Controls.Add(this.metroLabel1);
            this.tabTheme.Controls.Add(this.flpSettings);
            this.tabTheme.Font = new System.Drawing.Font("UTM Avo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabTheme.HorizontalScrollbarBarColor = true;
            this.tabTheme.HorizontalScrollbarHighlightOnWheel = false;
            this.tabTheme.HorizontalScrollbarSize = 10;
            this.tabTheme.Location = new System.Drawing.Point(4, 38);
            this.tabTheme.Name = "tabTheme";
            this.tabTheme.Size = new System.Drawing.Size(271, 414);
            this.tabTheme.TabIndex = 1;
            this.tabTheme.Text = "&theme";
            this.tabTheme.VerticalScrollbarBarColor = true;
            this.tabTheme.VerticalScrollbarHighlightOnWheel = false;
            this.tabTheme.VerticalScrollbarSize = 10;
            // 
            // rdLight
            // 
            this.rdLight.AutoSize = true;
            this.rdLight.Checked = true;
            this.rdLight.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rdLight.Location = new System.Drawing.Point(90, 39);
            this.rdLight.Name = "rdLight";
            this.rdLight.Size = new System.Drawing.Size(56, 19);
            this.rdLight.TabIndex = 0;
            this.rdLight.TabStop = true;
            this.rdLight.Text = "&Light";
            this.rdLight.UseSelectable = true;
            this.rdLight.CheckedChanged += new System.EventHandler(this.rdLight_CheckedChanged);
            // 
            // rdDark
            // 
            this.rdDark.AutoSize = true;
            this.rdDark.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rdDark.Location = new System.Drawing.Point(3, 39);
            this.rdDark.Name = "rdDark";
            this.rdDark.Size = new System.Drawing.Size(54, 19);
            this.rdDark.TabIndex = 1;
            this.rdDark.Text = "&Dark";
            this.rdDark.UseSelectable = true;
            this.rdDark.CheckedChanged += new System.EventHandler(this.rdDark_CheckedChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(-4, 68);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(38, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Style";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(-4, 13);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(50, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Theme";
            // 
            // flpSettings
            // 
            this.flpSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpSettings.BackColor = System.Drawing.Color.Transparent;
            this.flpSettings.Location = new System.Drawing.Point(0, 90);
            this.flpSettings.Name = "flpSettings";
            this.flpSettings.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.flpSettings.Size = new System.Drawing.Size(271, 350);
            this.flpSettings.TabIndex = 2;
            // 
            // linkBack
            // 
            this.linkBack.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.linkBack.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.linkBack.ForeColor = System.Drawing.Color.Aqua;
            this.linkBack.Image = ((System.Drawing.Image)(resources.GetObject("linkBack.Image")));
            this.linkBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkBack.ImageSize = 36;
            this.linkBack.Location = new System.Drawing.Point(7, 3);
            this.linkBack.Name = "linkBack";
            this.linkBack.Size = new System.Drawing.Size(152, 51);
            this.linkBack.Style = MetroFramework.MetroColorStyle.Blue;
            this.linkBack.TabIndex = 0;
            this.linkBack.TabStop = false;
            this.linkBack.Text = "&Settings";
            this.linkBack.UseSelectable = true;
            this.linkBack.Click += new System.EventHandler(this.linkBack_Click);
            // 
            // pnCenter
            // 
            this.pnCenter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnCenter.BackColor = System.Drawing.SystemColors.Control;
            this.pnCenter.Controls.Add(this.btExit);
            this.pnCenter.Controls.Add(this.btLogin);
            this.pnCenter.Controls.Add(this.txtPassword);
            this.pnCenter.Controls.Add(this.txtUserName);
            this.pnCenter.Controls.Add(this.pictureBox1);
            this.pnCenter.HorizontalScrollbarBarColor = true;
            this.pnCenter.HorizontalScrollbarHighlightOnWheel = false;
            this.pnCenter.HorizontalScrollbarSize = 10;
            this.pnCenter.Location = new System.Drawing.Point(0, 115);
            this.pnCenter.Name = "pnCenter";
            this.pnCenter.Size = new System.Drawing.Size(1049, 285);
            this.pnCenter.TabIndex = 0;
            this.pnCenter.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.pnCenter.VerticalScrollbarBarColor = true;
            this.pnCenter.VerticalScrollbarHighlightOnWheel = false;
            this.pnCenter.VerticalScrollbarSize = 10;
            // 
            // btExit
            // 
            this.btExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btExit.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btExit.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btExit.Location = new System.Drawing.Point(623, 239);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(116, 37);
            this.btExit.TabIndex = 3;
            this.btExit.Text = "&Exit";
            this.metroToolTipLogin.SetToolTip(this.btExit, "Close the program.");
            this.btExit.UseSelectable = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btLogin
            // 
            this.btLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btLogin.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btLogin.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btLogin.Location = new System.Drawing.Point(501, 239);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(116, 37);
            this.btLogin.TabIndex = 2;
            this.btLogin.Text = "&Login";
            this.metroToolTipLogin.SetToolTip(this.btLogin, "Login to use the program.");
            this.btLogin.UseSelectable = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            this.btLogin.DragEnter += new System.Windows.Forms.DragEventHandler(this.btLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(393, 1);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.DisplayIcon = true;
            this.txtPassword.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtPassword.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtPassword.Icon = ((System.Drawing.Image)(resources.GetObject("txtPassword.Icon")));
            this.txtPassword.Lines = new string[] {
        "1"};
            this.txtPassword.Location = new System.Drawing.Point(310, 196);
            this.txtPassword.MaxLength = 50;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.PromptText = "Enter your password";
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(429, 37);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "1";
            this.metroToolTipLogin.SetToolTip(this.txtPassword, "Password");
            this.txtPassword.UseSelectable = true;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.WaterMark = "Enter your password";
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            // 
            // 
            // 
            this.txtUserName.CustomButton.Image = null;
            this.txtUserName.CustomButton.Location = new System.Drawing.Point(393, 1);
            this.txtUserName.CustomButton.Name = "";
            this.txtUserName.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtUserName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUserName.CustomButton.TabIndex = 1;
            this.txtUserName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUserName.CustomButton.UseSelectable = true;
            this.txtUserName.CustomButton.Visible = false;
            this.txtUserName.DisplayIcon = true;
            this.txtUserName.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtUserName.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtUserName.Icon = ((System.Drawing.Image)(resources.GetObject("txtUserName.Icon")));
            this.txtUserName.Lines = new string[] {
        "ADMINISTRATOR"};
            this.txtUserName.Location = new System.Drawing.Point(310, 151);
            this.txtUserName.MaxLength = 50;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = '\0';
            this.txtUserName.PromptText = "Enter your user name";
            this.txtUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUserName.SelectedText = "";
            this.txtUserName.SelectionLength = 0;
            this.txtUserName.SelectionStart = 0;
            this.txtUserName.ShortcutsEnabled = true;
            this.txtUserName.Size = new System.Drawing.Size(429, 37);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.Text = "ADMINISTRATOR";
            this.metroToolTipLogin.SetToolTip(this.txtUserName, "Username");
            this.txtUserName.UseSelectable = true;
            this.txtUserName.WaterMark = "Enter your user name";
            this.txtUserName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUserName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(310, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(429, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // metroToolTipLogin
            // 
            this.metroToolTipLogin.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTipLogin.StyleManager = null;
            this.metroToolTipLogin.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // pnLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnSettings);
            this.Controls.Add(this.pnCenter);
            this.Name = "pnLogin";
            this.Size = new System.Drawing.Size(1049, 519);
            this.pnSettings.ResumeLayout(false);
            this.tcSettings.ResumeLayout(false);
            this.tpConnection.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabTheme.ResumeLayout(false);
            this.tabTheme.PerformLayout();
            this.pnCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnCenter;
        private MetroFramework.Controls.MetroPanel pnSettings;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroTabControl tcSettings;
        private MetroFramework.Controls.MetroTabPage tpConnection;
        private MetroFramework.Controls.MetroTabPage tabTheme;
        private MetroFramework.Controls.MetroRadioButton rdLight;
        private MetroFramework.Controls.MetroRadioButton rdDark;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.FlowLayoutPanel flpSettings;
        private MetroFramework.Controls.MetroLink linkBack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroTextBox txtUserName;
        private MetroFramework.Controls.MetroButton btLogin;
        private MetroFramework.Controls.MetroButton btExit;
        private MetroFramework.Controls.MetroComboBox cbServerName;
        private MetroFramework.Controls.MetroTextBox txtDbPassword;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtDbUserName;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtDbName;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton btSave;
        private MetroFramework.Controls.MetroButton btConnect;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroRadioButton rdSQLServerAuthentication;
        private MetroFramework.Controls.MetroRadioButton rdWindowsAuthentication;
        private MetroFramework.Components.MetroToolTip metroToolTipLogin;
    }
}
