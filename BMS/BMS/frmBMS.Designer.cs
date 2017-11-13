namespace BMS
{
    partial class frmBMS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBMS));
            this.msmBMS = new MetroFramework.Components.MetroStyleManager(this.components);
            this.timerDigitalClock = new System.Windows.Forms.Timer(this.components);
            this.lbUserName = new MetroFramework.Controls.MetroLabel();
            this.contxtMenuAccountSettings = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.accountSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroTile7 = new MetroFramework.Controls.MetroTile();
            this.mtEmployee = new MetroFramework.Controls.MetroTile();
            this.mtCustomer = new MetroFramework.Controls.MetroTile();
            this.mtPromotion = new MetroFramework.Controls.MetroTile();
            this.mtBillsPayment = new MetroFramework.Controls.MetroTile();
            this.mtBook = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.lbAMPM = new System.Windows.Forms.Label();
            this.lbDayMonthYear = new System.Windows.Forms.Label();
            this.lbDay = new System.Windows.Forms.Label();
            this.lbHour = new System.Windows.Forms.Label();
            this.lbSec = new System.Windows.Forms.Label();
            this.circularDigitalClock = new CircularProgressBar.CircularProgressBar();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.mtBackup = new MetroFramework.Controls.MetroTile();
            this.mtRestore = new MetroFramework.Controls.MetroTile();
            this.mtSales = new MetroFramework.Controls.MetroTile();
            this.linkSetting = new MetroFramework.Controls.MetroLink();
            this.linkClose = new MetroFramework.Controls.MetroLink();
            this.picEmp = new System.Windows.Forms.PictureBox();
            this.lbEmployeeName = new MetroFramework.Controls.MetroLabel();
            this.metroToolTipLogOut = new MetroFramework.Components.MetroToolTip();
            this.linkAccSettings = new MetroFramework.Controls.MetroLink();
            this.lbPassword = new MetroFramework.Controls.MetroLabel();
            this.maximizedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuZoom = new MetroFramework.Controls.MetroContextMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.msmBMS)).BeginInit();
            this.contxtMenuAccountSettings.SuspendLayout();
            this.metroTile1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEmp)).BeginInit();
            this.ContextMenuZoom.SuspendLayout();
            this.SuspendLayout();
            // 
            // msmBMS
            // 
            this.msmBMS.Owner = this;
            // 
            // timerDigitalClock
            // 
            this.timerDigitalClock.Enabled = true;
            this.timerDigitalClock.Tick += new System.EventHandler(this.timerDigitalClock_Tick);
            // 
            // lbUserName
            // 
            this.lbUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbUserName.ContextMenuStrip = this.contxtMenuAccountSettings;
            this.lbUserName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbUserName.Location = new System.Drawing.Point(936, 27);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(179, 25);
            this.lbUserName.TabIndex = 6;
            this.lbUserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // contxtMenuAccountSettings
            // 
            this.contxtMenuAccountSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.contxtMenuAccountSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.contxtMenuAccountSettings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountSettingsToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.contxtMenuAccountSettings.Name = "contxtMenuAccountSettings";
            this.contxtMenuAccountSettings.Size = new System.Drawing.Size(164, 48);
            // 
            // accountSettingsToolStripMenuItem
            // 
            this.accountSettingsToolStripMenuItem.BackColor = System.Drawing.Color.Chartreuse;
            this.accountSettingsToolStripMenuItem.Name = "accountSettingsToolStripMenuItem";
            this.accountSettingsToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.accountSettingsToolStripMenuItem.Text = "Account settings";
            this.accountSettingsToolStripMenuItem.Click += new System.EventHandler(this.accountSettingsToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.BackColor = System.Drawing.Color.MediumOrchid;
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // metroTile7
            // 
            this.metroTile7.ActiveControl = null;
            this.metroTile7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTile7.Location = new System.Drawing.Point(28, 215);
            this.metroTile7.Name = "metroTile7";
            this.metroTile7.Size = new System.Drawing.Size(87, 182);
            this.metroTile7.Style = MetroFramework.MetroColorStyle.Pink;
            this.metroTile7.TabIndex = 20;
            this.metroTile7.Text = "Report";
            this.metroTile7.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile7.TileImage")));
            this.metroTile7.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile7.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile7.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile7.UseSelectable = true;
            this.metroTile7.UseTileImage = true;
            this.metroTile7.Visible = false;
            // 
            // mtEmployee
            // 
            this.mtEmployee.ActiveControl = null;
            this.mtEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mtEmployee.Location = new System.Drawing.Point(121, 212);
            this.mtEmployee.Name = "mtEmployee";
            this.mtEmployee.Size = new System.Drawing.Size(138, 340);
            this.mtEmployee.Style = MetroFramework.MetroColorStyle.Green;
            this.mtEmployee.TabIndex = 21;
            this.mtEmployee.Text = "Employee";
            this.mtEmployee.TileImage = ((System.Drawing.Image)(resources.GetObject("mtEmployee.TileImage")));
            this.mtEmployee.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtEmployee.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtEmployee.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtEmployee.UseSelectable = true;
            this.mtEmployee.UseTileImage = true;
            this.mtEmployee.Click += new System.EventHandler(this.mtEmployee_Click);
            // 
            // mtCustomer
            // 
            this.mtCustomer.ActiveControl = null;
            this.mtCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mtCustomer.Location = new System.Drawing.Point(460, 403);
            this.mtCustomer.Name = "mtCustomer";
            this.mtCustomer.Size = new System.Drawing.Size(145, 149);
            this.mtCustomer.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtCustomer.TabIndex = 19;
            this.mtCustomer.Text = "Customer";
            this.mtCustomer.TileImage = ((System.Drawing.Image)(resources.GetObject("mtCustomer.TileImage")));
            this.mtCustomer.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtCustomer.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtCustomer.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtCustomer.UseSelectable = true;
            this.mtCustomer.UseTileImage = true;
            this.mtCustomer.Click += new System.EventHandler(this.mtCustomer_Click);
            // 
            // mtPromotion
            // 
            this.mtPromotion.ActiveControl = null;
            this.mtPromotion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mtPromotion.Location = new System.Drawing.Point(611, 403);
            this.mtPromotion.Name = "mtPromotion";
            this.mtPromotion.Size = new System.Drawing.Size(181, 149);
            this.mtPromotion.Style = MetroFramework.MetroColorStyle.Lime;
            this.mtPromotion.TabIndex = 15;
            this.mtPromotion.Text = "Promotion";
            this.mtPromotion.TileImage = ((System.Drawing.Image)(resources.GetObject("mtPromotion.TileImage")));
            this.mtPromotion.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtPromotion.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtPromotion.UseSelectable = true;
            this.mtPromotion.UseTileImage = true;
            this.mtPromotion.Click += new System.EventHandler(this.mtPromotion_Click);
            // 
            // mtBillsPayment
            // 
            this.mtBillsPayment.ActiveControl = null;
            this.mtBillsPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mtBillsPayment.Location = new System.Drawing.Point(265, 403);
            this.mtBillsPayment.Name = "mtBillsPayment";
            this.mtBillsPayment.Size = new System.Drawing.Size(189, 149);
            this.mtBillsPayment.Style = MetroFramework.MetroColorStyle.Red;
            this.mtBillsPayment.TabIndex = 17;
            this.mtBillsPayment.Text = "Bills payment";
            this.mtBillsPayment.TileImage = ((System.Drawing.Image)(resources.GetObject("mtBillsPayment.TileImage")));
            this.mtBillsPayment.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtBillsPayment.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtBillsPayment.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtBillsPayment.UseSelectable = true;
            this.mtBillsPayment.UseTileImage = true;
            this.mtBillsPayment.Click += new System.EventHandler(this.mtBillsPayment_Click);
            // 
            // mtBook
            // 
            this.mtBook.ActiveControl = null;
            this.mtBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mtBook.Location = new System.Drawing.Point(265, 212);
            this.mtBook.Name = "mtBook";
            this.mtBook.Size = new System.Drawing.Size(189, 185);
            this.mtBook.Style = MetroFramework.MetroColorStyle.Yellow;
            this.mtBook.TabIndex = 18;
            this.mtBook.Text = "Book";
            this.mtBook.TileImage = ((System.Drawing.Image)(resources.GetObject("mtBook.TileImage")));
            this.mtBook.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtBook.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtBook.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtBook.UseSelectable = true;
            this.mtBook.UseTileImage = true;
            this.mtBook.Click += new System.EventHandler(this.mtBook_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTile1.Controls.Add(this.lbAMPM);
            this.metroTile1.Controls.Add(this.lbDayMonthYear);
            this.metroTile1.Controls.Add(this.lbDay);
            this.metroTile1.Controls.Add(this.lbHour);
            this.metroTile1.Controls.Add(this.lbSec);
            this.metroTile1.Controls.Add(this.circularDigitalClock);
            this.metroTile1.Location = new System.Drawing.Point(798, 212);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(340, 340);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroTile1.TabIndex = 14;
            this.metroTile1.UseSelectable = true;
            // 
            // lbAMPM
            // 
            this.lbAMPM.AutoSize = true;
            this.lbAMPM.Location = new System.Drawing.Point(230, 145);
            this.lbAMPM.Name = "lbAMPM";
            this.lbAMPM.Size = new System.Drawing.Size(25, 15);
            this.lbAMPM.TabIndex = 6;
            this.lbAMPM.Text = "AM";
            this.lbAMPM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDayMonthYear
            // 
            this.lbDayMonthYear.AutoSize = true;
            this.lbDayMonthYear.BackColor = System.Drawing.Color.Black;
            this.lbDayMonthYear.Font = new System.Drawing.Font("UTM Avo", 10F);
            this.lbDayMonthYear.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbDayMonthYear.Location = new System.Drawing.Point(131, 218);
            this.lbDayMonthYear.Name = "lbDayMonthYear";
            this.lbDayMonthYear.Size = new System.Drawing.Size(85, 19);
            this.lbDayMonthYear.TabIndex = 5;
            this.lbDayMonthYear.Text = "01/01/2017";
            this.lbDayMonthYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDay
            // 
            this.lbDay.BackColor = System.Drawing.Color.Black;
            this.lbDay.Font = new System.Drawing.Font("UTM Avo", 10F);
            this.lbDay.ForeColor = System.Drawing.Color.Red;
            this.lbDay.Location = new System.Drawing.Point(120, 194);
            this.lbDay.Name = "lbDay";
            this.lbDay.Size = new System.Drawing.Size(103, 19);
            this.lbDay.TabIndex = 4;
            this.lbDay.Text = "Sunday";
            this.lbDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbHour
            // 
            this.lbHour.AutoEllipsis = true;
            this.lbHour.AutoSize = true;
            this.lbHour.BackColor = System.Drawing.Color.Black;
            this.lbHour.Font = new System.Drawing.Font("UTM Avo", 30F, System.Drawing.FontStyle.Bold);
            this.lbHour.ForeColor = System.Drawing.Color.White;
            this.lbHour.Location = new System.Drawing.Point(103, 126);
            this.lbHour.Name = "lbHour";
            this.lbHour.Size = new System.Drawing.Size(138, 59);
            this.lbHour.TabIndex = 3;
            this.lbHour.Text = "00:00";
            this.lbHour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSec
            // 
            this.lbSec.AutoSize = true;
            this.lbSec.BackColor = System.Drawing.Color.Black;
            this.lbSec.Font = new System.Drawing.Font("UTM Avo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSec.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbSec.Location = new System.Drawing.Point(159, 102);
            this.lbSec.Name = "lbSec";
            this.lbSec.Size = new System.Drawing.Size(25, 19);
            this.lbSec.TabIndex = 2;
            this.lbSec.Text = "00";
            this.lbSec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // circularDigitalClock
            // 
            this.circularDigitalClock.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularDigitalClock.AnimationSpeed = 500;
            this.circularDigitalClock.BackColor = System.Drawing.Color.Transparent;
            this.circularDigitalClock.Font = new System.Drawing.Font("UTM Avo", 30F, System.Drawing.FontStyle.Bold);
            this.circularDigitalClock.ForeColor = System.Drawing.Color.White;
            this.circularDigitalClock.InnerColor = System.Drawing.Color.Black;
            this.circularDigitalClock.InnerMargin = 2;
            this.circularDigitalClock.InnerWidth = -1;
            this.circularDigitalClock.Location = new System.Drawing.Point(50, 49);
            this.circularDigitalClock.MarqueeAnimationSpeed = 2000;
            this.circularDigitalClock.Maximum = 60;
            this.circularDigitalClock.Name = "circularDigitalClock";
            this.circularDigitalClock.OuterColor = System.Drawing.Color.Gray;
            this.circularDigitalClock.OuterMargin = -25;
            this.circularDigitalClock.OuterWidth = 26;
            this.circularDigitalClock.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.circularDigitalClock.ProgressWidth = 20;
            this.circularDigitalClock.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularDigitalClock.Size = new System.Drawing.Size(241, 241);
            this.circularDigitalClock.StartAngle = 270;
            this.circularDigitalClock.SubscriptColor = System.Drawing.Color.Silver;
            this.circularDigitalClock.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularDigitalClock.SubscriptText = "PM";
            this.circularDigitalClock.SuperscriptColor = System.Drawing.Color.Silver;
            this.circularDigitalClock.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularDigitalClock.SuperscriptText = "";
            this.circularDigitalClock.TabIndex = 1;
            this.circularDigitalClock.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularDigitalClock.Value = 60;
            // 
            // metroTile4
            // 
            this.metroTile4.ActiveControl = null;
            this.metroTile4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTile4.Location = new System.Drawing.Point(28, 488);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(87, 64);
            this.metroTile4.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroTile4.TabIndex = 17;
            this.metroTile4.Text = "metroTile2";
            this.metroTile4.UseSelectable = true;
            this.metroTile4.Visible = false;
            // 
            // mtBackup
            // 
            this.mtBackup.ActiveControl = null;
            this.mtBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mtBackup.Location = new System.Drawing.Point(28, 403);
            this.mtBackup.Name = "mtBackup";
            this.mtBackup.Size = new System.Drawing.Size(41, 79);
            this.mtBackup.Style = MetroFramework.MetroColorStyle.Orange;
            this.mtBackup.TabIndex = 18;
            this.mtBackup.Text = "Backup DB";
            this.mtBackup.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtBackup.TileImage = ((System.Drawing.Image)(resources.GetObject("mtBackup.TileImage")));
            this.mtBackup.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtBackup.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.mtBackup.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtBackup.UseSelectable = true;
            this.mtBackup.UseTileImage = true;
            this.mtBackup.Visible = false;
            this.mtBackup.Click += new System.EventHandler(this.mtBackup_Click);
            // 
            // mtRestore
            // 
            this.mtRestore.ActiveControl = null;
            this.mtRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mtRestore.Location = new System.Drawing.Point(75, 403);
            this.mtRestore.Name = "mtRestore";
            this.mtRestore.Size = new System.Drawing.Size(40, 79);
            this.mtRestore.Style = MetroFramework.MetroColorStyle.Silver;
            this.mtRestore.TabIndex = 18;
            this.mtRestore.Text = "Restore DB";
            this.mtRestore.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtRestore.TileImage = ((System.Drawing.Image)(resources.GetObject("mtRestore.TileImage")));
            this.mtRestore.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtRestore.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.mtRestore.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtRestore.UseSelectable = true;
            this.mtRestore.UseTileImage = true;
            this.mtRestore.Visible = false;
            this.mtRestore.Click += new System.EventHandler(this.mtRestore_Click);
            // 
            // mtSales
            // 
            this.mtSales.ActiveControl = null;
            this.mtSales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mtSales.Location = new System.Drawing.Point(460, 212);
            this.mtSales.Name = "mtSales";
            this.mtSales.Size = new System.Drawing.Size(332, 185);
            this.mtSales.Style = MetroFramework.MetroColorStyle.Magenta;
            this.mtSales.TabIndex = 16;
            this.mtSales.Text = "Sales";
            this.mtSales.TileImage = ((System.Drawing.Image)(resources.GetObject("mtSales.TileImage")));
            this.mtSales.TileImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.mtSales.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtSales.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtSales.UseSelectable = true;
            this.mtSales.UseTileImage = true;
            this.mtSales.Click += new System.EventHandler(this.mtSales_Click);
            // 
            // linkSetting
            // 
            this.linkSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkSetting.BackColor = System.Drawing.Color.Transparent;
            this.linkSetting.Image = ((System.Drawing.Image)(resources.GetObject("linkSetting.Image")));
            this.linkSetting.ImageSize = 63;
            this.linkSetting.Location = new System.Drawing.Point(1225, 6);
            this.linkSetting.Name = "linkSetting";
            this.linkSetting.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("linkSetting.NoFocusImage")));
            this.linkSetting.Size = new System.Drawing.Size(45, 45);
            this.linkSetting.TabIndex = 0;
            this.metroToolTipLogOut.SetToolTip(this.linkSetting, "Settings");
            this.linkSetting.UseCustomBackColor = true;
            this.linkSetting.UseSelectable = true;
            this.linkSetting.Click += new System.EventHandler(this.linkSetting_Click);
            // 
            // linkClose
            // 
            this.linkClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkClose.BackColor = System.Drawing.Color.Transparent;
            this.linkClose.Image = ((System.Drawing.Image)(resources.GetObject("linkClose.Image")));
            this.linkClose.ImageSize = 39;
            this.linkClose.Location = new System.Drawing.Point(1177, 6);
            this.linkClose.Name = "linkClose";
            this.linkClose.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("linkClose.NoFocusImage")));
            this.linkClose.Size = new System.Drawing.Size(45, 45);
            this.linkClose.TabIndex = 0;
            this.linkClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroToolTipLogOut.SetToolTip(this.linkClose, "Shut down");
            this.linkClose.UseCustomBackColor = true;
            this.linkClose.UseSelectable = true;
            this.linkClose.Visible = false;
            this.linkClose.Click += new System.EventHandler(this.linkClose_Click);
            // 
            // picEmp
            // 
            this.picEmp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picEmp.ContextMenuStrip = this.contxtMenuAccountSettings;
            this.picEmp.Location = new System.Drawing.Point(1121, 7);
            this.picEmp.Name = "picEmp";
            this.picEmp.Size = new System.Drawing.Size(50, 45);
            this.picEmp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEmp.TabIndex = 22;
            this.picEmp.TabStop = false;
            // 
            // lbEmployeeName
            // 
            this.lbEmployeeName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbEmployeeName.ContextMenuStrip = this.contxtMenuAccountSettings;
            this.lbEmployeeName.Location = new System.Drawing.Point(936, 7);
            this.lbEmployeeName.Name = "lbEmployeeName";
            this.lbEmployeeName.Size = new System.Drawing.Size(179, 25);
            this.lbEmployeeName.TabIndex = 6;
            this.lbEmployeeName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroToolTipLogOut
            // 
            this.metroToolTipLogOut.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTipLogOut.StyleManager = null;
            this.metroToolTipLogOut.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // linkAccSettings
            // 
            this.linkAccSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkAccSettings.BackColor = System.Drawing.Color.Transparent;
            this.linkAccSettings.Image = ((System.Drawing.Image)(resources.GetObject("linkAccSettings.Image")));
            this.linkAccSettings.ImageSize = 40;
            this.linkAccSettings.Location = new System.Drawing.Point(1225, 7);
            this.linkAccSettings.Name = "linkAccSettings";
            this.linkAccSettings.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("linkAccSettings.NoFocusImage")));
            this.linkAccSettings.Size = new System.Drawing.Size(45, 45);
            this.linkAccSettings.TabIndex = 0;
            this.metroToolTipLogOut.SetToolTip(this.linkAccSettings, "Account settings.");
            this.linkAccSettings.UseCustomBackColor = true;
            this.linkAccSettings.UseSelectable = true;
            this.linkAccSettings.Visible = false;
            this.linkAccSettings.Click += new System.EventHandler(this.linkAccSettings_Click);
            // 
            // lbPassword
            // 
            this.lbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPassword.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbPassword.Location = new System.Drawing.Point(936, 69);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(179, 25);
            this.lbPassword.TabIndex = 6;
            this.lbPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbPassword.Visible = false;
            // 
            // maximizedToolStripMenuItem
            // 
            this.maximizedToolStripMenuItem.BackColor = System.Drawing.Color.Coral;
            this.maximizedToolStripMenuItem.Name = "maximizedToolStripMenuItem";
            this.maximizedToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.maximizedToolStripMenuItem.Text = "Ma&ximized";
            this.maximizedToolStripMenuItem.Click += new System.EventHandler(this.maximumToolStripMenuItem_Click);
            // 
            // minimizedToolStripMenuItem
            // 
            this.minimizedToolStripMenuItem.BackColor = System.Drawing.Color.GreenYellow;
            this.minimizedToolStripMenuItem.Name = "minimizedToolStripMenuItem";
            this.minimizedToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.minimizedToolStripMenuItem.Text = "M&inimized";
            this.minimizedToolStripMenuItem.Click += new System.EventHandler(this.minimizedToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.BackColor = System.Drawing.Color.DarkGray;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.closeToolStripMenuItem.Text = "Cl&ose the program";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // ContextMenuZoom
            // 
            this.ContextMenuZoom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maximizedToolStripMenuItem,
            this.minimizedToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.ContextMenuZoom.Name = "ContextMenuZoom";
            this.ContextMenuZoom.Size = new System.Drawing.Size(173, 70);
            // 
            // frmBMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1300, 768);
            this.ContextMenuStrip = this.ContextMenuZoom;
            this.ControlBox = false;
            this.Controls.Add(this.picEmp);
            this.Controls.Add(this.metroTile7);
            this.Controls.Add(this.mtEmployee);
            this.Controls.Add(this.mtCustomer);
            this.Controls.Add(this.mtPromotion);
            this.Controls.Add(this.mtSales);
            this.Controls.Add(this.metroTile4);
            this.Controls.Add(this.mtBillsPayment);
            this.Controls.Add(this.mtRestore);
            this.Controls.Add(this.mtBackup);
            this.Controls.Add(this.mtBook);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.lbEmployeeName);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.linkAccSettings);
            this.Controls.Add(this.linkSetting);
            this.Controls.Add(this.linkClose);
            this.Font = new System.Drawing.Font("UTM Avo", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBMS";
            this.Padding = new System.Windows.Forms.Padding(20, 69, 20, 23);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "BMS";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BMS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.msmBMS)).EndInit();
            this.contxtMenuAccountSettings.ResumeLayout(false);
            this.metroTile1.ResumeLayout(false);
            this.metroTile1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEmp)).EndInit();
            this.ContextMenuZoom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLink linkClose;
        private MetroFramework.Controls.MetroLink linkSetting;
        private MetroFramework.Components.MetroStyleManager msmBMS;
        private System.Windows.Forms.Timer timerDigitalClock;
        private MetroFramework.Controls.MetroLabel lbUserName;
        private MetroFramework.Controls.MetroTile metroTile7;
        private MetroFramework.Controls.MetroTile mtEmployee;
        private MetroFramework.Controls.MetroTile mtCustomer;
        private MetroFramework.Controls.MetroTile mtPromotion;
        private MetroFramework.Controls.MetroTile mtSales;
        private MetroFramework.Controls.MetroTile mtBillsPayment;
        private MetroFramework.Controls.MetroTile mtBook;
        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.Label lbAMPM;
        private System.Windows.Forms.Label lbDayMonthYear;
        private System.Windows.Forms.Label lbDay;
        private System.Windows.Forms.Label lbHour;
        private System.Windows.Forms.Label lbSec;
        private CircularProgressBar.CircularProgressBar circularDigitalClock;
        private MetroFramework.Controls.MetroTile metroTile4;
        private MetroFramework.Controls.MetroTile mtBackup;
        private MetroFramework.Controls.MetroTile mtRestore;
        private System.Windows.Forms.PictureBox picEmp;
        private MetroFramework.Controls.MetroLabel lbEmployeeName;
        private MetroFramework.Components.MetroToolTip metroToolTipLogOut;
        private MetroFramework.Controls.MetroLink linkAccSettings;
        private MetroFramework.Controls.MetroLabel lbPassword;
        private MetroFramework.Controls.MetroContextMenu contxtMenuAccountSettings;
        private System.Windows.Forms.ToolStripMenuItem accountSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private MetroFramework.Controls.MetroContextMenu ContextMenuZoom;
        private System.Windows.Forms.ToolStripMenuItem maximizedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimizedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}

