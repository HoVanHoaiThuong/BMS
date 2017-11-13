namespace BMS.Class
{
    partial class frmPromotion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPromotion));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.linkBack = new MetroFramework.Controls.MetroLink();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.pnPromotionInfo = new MetroFramework.Controls.MetroPanel();
            this.txtStatus = new MetroFramework.Controls.MetroTextBox();
            this.numericDiscount = new System.Windows.Forms.NumericUpDown();
            this.dtEndPromo = new MetroFramework.Controls.MetroDateTime();
            this.dtStartPromo = new MetroFramework.Controls.MetroDateTime();
            this.txtPromoID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cbBookTitle = new MetroFramework.Controls.MetroComboBox();
            this.btRefresh = new MetroFramework.Controls.MetroButton();
            this.btCancel = new MetroFramework.Controls.MetroButton();
            this.btSave = new MetroFramework.Controls.MetroButton();
            this.btDelete = new MetroFramework.Controls.MetroButton();
            this.btUpdate = new MetroFramework.Controls.MetroButton();
            this.btInsert = new MetroFramework.Controls.MetroButton();
            this.dgvPromotion = new MetroFramework.Controls.MetroGrid();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.pnPromotionInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromotion)).BeginInit();
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
            this.metroPanel1.Location = new System.Drawing.Point(-1, 3);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1369, 600);
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
            this.linkBack.Location = new System.Drawing.Point(0, 10);
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
            this.metroPanel2.Controls.Add(this.pnPromotionInfo);
            this.metroPanel2.Controls.Add(this.btRefresh);
            this.metroPanel2.Controls.Add(this.btCancel);
            this.metroPanel2.Controls.Add(this.btSave);
            this.metroPanel2.Controls.Add(this.btDelete);
            this.metroPanel2.Controls.Add(this.btUpdate);
            this.metroPanel2.Controls.Add(this.btInsert);
            this.metroPanel2.Controls.Add(this.dgvPromotion);
            this.metroPanel2.Controls.Add(this.txtSearch);
            this.metroPanel2.Controls.Add(this.metroLabel1);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(349, 10);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(654, 581);
            this.metroPanel2.TabIndex = 5;
            this.metroPanel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // pnPromotionInfo
            // 
            this.pnPromotionInfo.Controls.Add(this.txtStatus);
            this.pnPromotionInfo.Controls.Add(this.numericDiscount);
            this.pnPromotionInfo.Controls.Add(this.dtEndPromo);
            this.pnPromotionInfo.Controls.Add(this.dtStartPromo);
            this.pnPromotionInfo.Controls.Add(this.txtPromoID);
            this.pnPromotionInfo.Controls.Add(this.metroLabel7);
            this.pnPromotionInfo.Controls.Add(this.metroLabel6);
            this.pnPromotionInfo.Controls.Add(this.metroLabel5);
            this.pnPromotionInfo.Controls.Add(this.metroLabel4);
            this.pnPromotionInfo.Controls.Add(this.metroLabel3);
            this.pnPromotionInfo.Controls.Add(this.metroLabel2);
            this.pnPromotionInfo.Controls.Add(this.cbBookTitle);
            this.pnPromotionInfo.HorizontalScrollbarBarColor = true;
            this.pnPromotionInfo.HorizontalScrollbarHighlightOnWheel = false;
            this.pnPromotionInfo.HorizontalScrollbarSize = 10;
            this.pnPromotionInfo.Location = new System.Drawing.Point(3, 53);
            this.pnPromotionInfo.Name = "pnPromotionInfo";
            this.pnPromotionInfo.Size = new System.Drawing.Size(648, 205);
            this.pnPromotionInfo.TabIndex = 17;
            this.pnPromotionInfo.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.pnPromotionInfo.VerticalScrollbarBarColor = true;
            this.pnPromotionInfo.VerticalScrollbarHighlightOnWheel = false;
            this.pnPromotionInfo.VerticalScrollbarSize = 10;
            // 
            // txtStatus
            // 
            // 
            // 
            // 
            this.txtStatus.CustomButton.Image = null;
            this.txtStatus.CustomButton.Location = new System.Drawing.Point(236, 2);
            this.txtStatus.CustomButton.Name = "";
            this.txtStatus.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtStatus.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStatus.CustomButton.TabIndex = 1;
            this.txtStatus.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStatus.CustomButton.UseSelectable = true;
            this.txtStatus.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtStatus.Lines = new string[0];
            this.txtStatus.Location = new System.Drawing.Point(243, 172);
            this.txtStatus.MaxLength = 32767;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.PasswordChar = '\0';
            this.txtStatus.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStatus.SelectedText = "";
            this.txtStatus.SelectionLength = 0;
            this.txtStatus.SelectionStart = 0;
            this.txtStatus.ShortcutsEnabled = true;
            this.txtStatus.ShowButton = true;
            this.txtStatus.ShowClearButton = true;
            this.txtStatus.Size = new System.Drawing.Size(260, 26);
            this.txtStatus.TabIndex = 21;
            this.txtStatus.UseSelectable = true;
            this.txtStatus.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStatus.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // numericDiscount
            // 
            this.numericDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericDiscount.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericDiscount.Location = new System.Drawing.Point(243, 140);
            this.numericDiscount.Name = "numericDiscount";
            this.numericDiscount.Size = new System.Drawing.Size(74, 26);
            this.numericDiscount.TabIndex = 20;
            this.numericDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtEndPromo
            // 
            this.dtEndPromo.CalendarFont = new System.Drawing.Font("UTM Avo", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtEndPromo.CustomFormat = "dd/MM/yyyy";
            this.dtEndPromo.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtEndPromo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEndPromo.Location = new System.Drawing.Point(243, 106);
            this.dtEndPromo.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtEndPromo.Name = "dtEndPromo";
            this.dtEndPromo.Size = new System.Drawing.Size(309, 29);
            this.dtEndPromo.TabIndex = 18;
            // 
            // dtStartPromo
            // 
            this.dtStartPromo.CalendarFont = new System.Drawing.Font("UTM Avo", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtStartPromo.CalendarTitleBackColor = System.Drawing.Color.Red;
            this.dtStartPromo.CustomFormat = "dd/MM/yyyy";
            this.dtStartPromo.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtStartPromo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStartPromo.Location = new System.Drawing.Point(243, 72);
            this.dtStartPromo.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtStartPromo.Name = "dtStartPromo";
            this.dtStartPromo.Size = new System.Drawing.Size(309, 29);
            this.dtStartPromo.TabIndex = 19;
            // 
            // txtPromoID
            // 
            // 
            // 
            // 
            this.txtPromoID.CustomButton.Image = null;
            this.txtPromoID.CustomButton.Location = new System.Drawing.Point(113, 2);
            this.txtPromoID.CustomButton.Name = "";
            this.txtPromoID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPromoID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPromoID.CustomButton.TabIndex = 1;
            this.txtPromoID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPromoID.CustomButton.UseSelectable = true;
            this.txtPromoID.Enabled = false;
            this.txtPromoID.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPromoID.Lines = new string[0];
            this.txtPromoID.Location = new System.Drawing.Point(243, 7);
            this.txtPromoID.MaxLength = 32767;
            this.txtPromoID.Name = "txtPromoID";
            this.txtPromoID.PasswordChar = '\0';
            this.txtPromoID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPromoID.SelectedText = "";
            this.txtPromoID.SelectionLength = 0;
            this.txtPromoID.SelectionStart = 0;
            this.txtPromoID.ShortcutsEnabled = true;
            this.txtPromoID.ShowButton = true;
            this.txtPromoID.ShowClearButton = true;
            this.txtPromoID.Size = new System.Drawing.Size(137, 26);
            this.txtPromoID.TabIndex = 17;
            this.txtPromoID.UseSelectable = true;
            this.txtPromoID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPromoID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.ForeColor = System.Drawing.Color.White;
            this.metroLabel7.Location = new System.Drawing.Point(96, 144);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(78, 19);
            this.metroLabel7.TabIndex = 11;
            this.metroLabel7.Text = "% &Discount";
            this.metroLabel7.UseCustomBackColor = true;
            this.metroLabel7.UseCustomForeColor = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.ForeColor = System.Drawing.Color.White;
            this.metroLabel6.Location = new System.Drawing.Point(96, 178);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(47, 19);
            this.metroLabel6.TabIndex = 12;
            this.metroLabel6.Text = "&Status";
            this.metroLabel6.UseCustomBackColor = true;
            this.metroLabel6.UseCustomForeColor = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.ForeColor = System.Drawing.Color.White;
            this.metroLabel5.Location = new System.Drawing.Point(96, 110);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(65, 19);
            this.metroLabel5.TabIndex = 13;
            this.metroLabel5.Text = "&End Date";
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.ForeColor = System.Drawing.Color.White;
            this.metroLabel4.Location = new System.Drawing.Point(96, 75);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(71, 19);
            this.metroLabel4.TabIndex = 14;
            this.metroLabel4.Text = "&Start Date";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.ForeColor = System.Drawing.Color.White;
            this.metroLabel3.Location = new System.Drawing.Point(96, 39);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(69, 19);
            this.metroLabel3.TabIndex = 15;
            this.metroLabel3.Text = "Book &Title";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.ForeColor = System.Drawing.Color.White;
            this.metroLabel2.Location = new System.Drawing.Point(96, 6);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(99, 19);
            this.metroLabel2.TabIndex = 16;
            this.metroLabel2.Text = "Promotion N&o.";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // cbBookTitle
            // 
            this.cbBookTitle.FormattingEnabled = true;
            this.cbBookTitle.ItemHeight = 23;
            this.cbBookTitle.Location = new System.Drawing.Point(243, 38);
            this.cbBookTitle.Name = "cbBookTitle";
            this.cbBookTitle.Size = new System.Drawing.Size(309, 29);
            this.cbBookTitle.TabIndex = 10;
            this.cbBookTitle.UseSelectable = true;
            // 
            // btRefresh
            // 
            this.btRefresh.BackColor = System.Drawing.Color.Gainsboro;
            this.btRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btRefresh.BackgroundImage")));
            this.btRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btRefresh.Highlight = true;
            this.btRefresh.Location = new System.Drawing.Point(420, 275);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(73, 44);
            this.btRefresh.TabIndex = 11;
            this.btRefresh.UseSelectable = true;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.Gainsboro;
            this.btCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btCancel.BackgroundImage")));
            this.btCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btCancel.Highlight = true;
            this.btCancel.Location = new System.Drawing.Point(334, 275);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(73, 44);
            this.btCancel.TabIndex = 12;
            this.btCancel.UseSelectable = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.Color.Gainsboro;
            this.btSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btSave.BackgroundImage")));
            this.btSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btSave.Highlight = true;
            this.btSave.Location = new System.Drawing.Point(506, 275);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(73, 44);
            this.btSave.TabIndex = 13;
            this.btSave.UseSelectable = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.Gainsboro;
            this.btDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btDelete.BackgroundImage")));
            this.btDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btDelete.Highlight = true;
            this.btDelete.Location = new System.Drawing.Point(248, 275);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(73, 44);
            this.btDelete.TabIndex = 14;
            this.btDelete.UseSelectable = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.BackColor = System.Drawing.Color.Gainsboro;
            this.btUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btUpdate.BackgroundImage")));
            this.btUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btUpdate.Highlight = true;
            this.btUpdate.Location = new System.Drawing.Point(162, 275);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(73, 44);
            this.btUpdate.TabIndex = 15;
            this.btUpdate.UseSelectable = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btInsert
            // 
            this.btInsert.BackColor = System.Drawing.Color.Gainsboro;
            this.btInsert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btInsert.BackgroundImage")));
            this.btInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btInsert.Highlight = true;
            this.btInsert.Location = new System.Drawing.Point(76, 275);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(73, 44);
            this.btInsert.TabIndex = 16;
            this.btInsert.UseSelectable = true;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // dgvPromotion
            // 
            this.dgvPromotion.AllowUserToResizeRows = false;
            this.dgvPromotion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPromotion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPromotion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPromotion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPromotion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPromotion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPromotion.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPromotion.EnableHeadersVisualStyles = false;
            this.dgvPromotion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvPromotion.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPromotion.Location = new System.Drawing.Point(3, 339);
            this.dgvPromotion.Name = "dgvPromotion";
            this.dgvPromotion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPromotion.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPromotion.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPromotion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPromotion.Size = new System.Drawing.Size(648, 232);
            this.dgvPromotion.TabIndex = 8;
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(236, 2);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.DisplayIcon = true;
            this.txtSearch.Icon = ((System.Drawing.Image)(resources.GetObject("txtSearch.Icon")));
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(378, 7);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PromptText = "Enter (a) keyword(s).";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.ShowButton = true;
            this.txtSearch.ShowClearButton = true;
            this.txtSearch.Size = new System.Drawing.Size(260, 26);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "Enter (a) keyword(s).";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearch.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.txtSearch_ButtonClick);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.metroLabel1.BackColor = System.Drawing.Color.Red;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.White;
            this.metroLabel1.Location = new System.Drawing.Point(0, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(654, 39);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "PROMOTION";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // frmPromotion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroPanel1);
            this.Name = "frmPromotion";
            this.Size = new System.Drawing.Size(1366, 620);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.pnPromotionInfo.ResumeLayout(false);
            this.pnPromotionInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromotion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLink linkBack;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroGrid dgvPromotion;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroButton btRefresh;
        private MetroFramework.Controls.MetroButton btCancel;
        private MetroFramework.Controls.MetroButton btSave;
        private MetroFramework.Controls.MetroButton btDelete;
        private MetroFramework.Controls.MetroButton btUpdate;
        private MetroFramework.Controls.MetroButton btInsert;
        private MetroFramework.Controls.MetroPanel pnPromotionInfo;
        private MetroFramework.Controls.MetroTextBox txtStatus;
        private System.Windows.Forms.NumericUpDown numericDiscount;
        private MetroFramework.Controls.MetroDateTime dtEndPromo;
        private MetroFramework.Controls.MetroDateTime dtStartPromo;
        private MetroFramework.Controls.MetroTextBox txtPromoID;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cbBookTitle;
    }
}
