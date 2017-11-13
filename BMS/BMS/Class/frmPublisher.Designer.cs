namespace BMS.Class
{
    partial class frmPublisher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPublisher));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPublisherSearch = new MetroFramework.Controls.MetroTextBox();
            this.pnPublisher = new MetroFramework.Controls.MetroPanel();
            this.txtPublisherDescription = new MetroFramework.Controls.MetroTextBox();
            this.txtPublisherAddress = new MetroFramework.Controls.MetroTextBox();
            this.txtPublisherName = new MetroFramework.Controls.MetroTextBox();
            this.txtPublisherNo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dgvPublisher = new MetroFramework.Controls.MetroGrid();
            this.PublisherID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisher_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btCancel = new MetroFramework.Controls.MetroButton();
            this.btRefresh = new MetroFramework.Controls.MetroButton();
            this.btClose = new MetroFramework.Controls.MetroButton();
            this.btSave = new MetroFramework.Controls.MetroButton();
            this.btDelete = new MetroFramework.Controls.MetroButton();
            this.btUpdate = new MetroFramework.Controls.MetroButton();
            this.btInsert = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnPublisher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPublisher)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.Red;
            this.metroPanel1.Controls.Add(this.metroPanel2);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 55);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(661, 600);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroPanel2
            // 
            this.metroPanel2.BackColor = System.Drawing.Color.White;
            this.metroPanel2.Controls.Add(this.groupBox1);
            this.metroPanel2.Controls.Add(this.pnPublisher);
            this.metroPanel2.Controls.Add(this.dgvPublisher);
            this.metroPanel2.Controls.Add(this.btCancel);
            this.metroPanel2.Controls.Add(this.btRefresh);
            this.metroPanel2.Controls.Add(this.btClose);
            this.metroPanel2.Controls.Add(this.btSave);
            this.metroPanel2.Controls.Add(this.btDelete);
            this.metroPanel2.Controls.Add(this.btUpdate);
            this.metroPanel2.Controls.Add(this.btInsert);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(14, 13);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(632, 574);
            this.metroPanel2.TabIndex = 2;
            this.metroPanel2.UseCustomBackColor = true;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.txtPublisherSearch);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("UTM Avo", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(319, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 70);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // txtPublisherSearch
            // 
            // 
            // 
            // 
            this.txtPublisherSearch.CustomButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtPublisherSearch.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.txtPublisherSearch.CustomButton.Location = new System.Drawing.Point(219, 1);
            this.txtPublisherSearch.CustomButton.Name = "";
            this.txtPublisherSearch.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtPublisherSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPublisherSearch.CustomButton.TabIndex = 1;
            this.txtPublisherSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPublisherSearch.CustomButton.UseSelectable = true;
            this.txtPublisherSearch.DisplayIcon = true;
            this.txtPublisherSearch.Icon = ((System.Drawing.Image)(resources.GetObject("txtPublisherSearch.Icon")));
            this.txtPublisherSearch.Lines = new string[0];
            this.txtPublisherSearch.Location = new System.Drawing.Point(32, 26);
            this.txtPublisherSearch.MaxLength = 32767;
            this.txtPublisherSearch.Name = "txtPublisherSearch";
            this.txtPublisherSearch.PasswordChar = '\0';
            this.txtPublisherSearch.PromptText = "Enter your keywords!";
            this.txtPublisherSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPublisherSearch.SelectedText = "";
            this.txtPublisherSearch.SelectionLength = 0;
            this.txtPublisherSearch.SelectionStart = 0;
            this.txtPublisherSearch.ShortcutsEnabled = true;
            this.txtPublisherSearch.ShowButton = true;
            this.txtPublisherSearch.ShowClearButton = true;
            this.txtPublisherSearch.Size = new System.Drawing.Size(245, 27);
            this.txtPublisherSearch.TabIndex = 0;
            this.txtPublisherSearch.UseSelectable = true;
            this.txtPublisherSearch.WaterMark = "Enter your keywords!";
            this.txtPublisherSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPublisherSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPublisherSearch.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.txtPublisherSearch_ButtonClick);
            // 
            // pnPublisher
            // 
            this.pnPublisher.BackColor = System.Drawing.Color.White;
            this.pnPublisher.Controls.Add(this.txtPublisherDescription);
            this.pnPublisher.Controls.Add(this.txtPublisherAddress);
            this.pnPublisher.Controls.Add(this.txtPublisherName);
            this.pnPublisher.Controls.Add(this.txtPublisherNo);
            this.pnPublisher.Controls.Add(this.metroLabel4);
            this.pnPublisher.Controls.Add(this.metroLabel3);
            this.pnPublisher.Controls.Add(this.metroLabel2);
            this.pnPublisher.Controls.Add(this.metroLabel1);
            this.pnPublisher.HorizontalScrollbarBarColor = true;
            this.pnPublisher.HorizontalScrollbarHighlightOnWheel = false;
            this.pnPublisher.HorizontalScrollbarSize = 10;
            this.pnPublisher.Location = new System.Drawing.Point(16, 89);
            this.pnPublisher.Name = "pnPublisher";
            this.pnPublisher.Size = new System.Drawing.Size(598, 201);
            this.pnPublisher.TabIndex = 60;
            this.pnPublisher.UseCustomBackColor = true;
            this.pnPublisher.VerticalScrollbarBarColor = true;
            this.pnPublisher.VerticalScrollbarHighlightOnWheel = false;
            this.pnPublisher.VerticalScrollbarSize = 10;
            // 
            // txtPublisherDescription
            // 
            // 
            // 
            // 
            this.txtPublisherDescription.CustomButton.Image = null;
            this.txtPublisherDescription.CustomButton.Location = new System.Drawing.Point(341, 2);
            this.txtPublisherDescription.CustomButton.Name = "";
            this.txtPublisherDescription.CustomButton.Size = new System.Drawing.Size(75, 75);
            this.txtPublisherDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPublisherDescription.CustomButton.TabIndex = 1;
            this.txtPublisherDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPublisherDescription.CustomButton.UseSelectable = true;
            this.txtPublisherDescription.CustomButton.Visible = false;
            this.txtPublisherDescription.Lines = new string[0];
            this.txtPublisherDescription.Location = new System.Drawing.Point(160, 104);
            this.txtPublisherDescription.MaxLength = 32767;
            this.txtPublisherDescription.Multiline = true;
            this.txtPublisherDescription.Name = "txtPublisherDescription";
            this.txtPublisherDescription.PasswordChar = '\0';
            this.txtPublisherDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPublisherDescription.SelectedText = "";
            this.txtPublisherDescription.SelectionLength = 0;
            this.txtPublisherDescription.SelectionStart = 0;
            this.txtPublisherDescription.ShortcutsEnabled = true;
            this.txtPublisherDescription.ShowClearButton = true;
            this.txtPublisherDescription.Size = new System.Drawing.Size(419, 80);
            this.txtPublisherDescription.TabIndex = 73;
            this.txtPublisherDescription.UseSelectable = true;
            this.txtPublisherDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPublisherDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPublisherAddress
            // 
            // 
            // 
            // 
            this.txtPublisherAddress.CustomButton.Image = null;
            this.txtPublisherAddress.CustomButton.Location = new System.Drawing.Point(397, 1);
            this.txtPublisherAddress.CustomButton.Name = "";
            this.txtPublisherAddress.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPublisherAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPublisherAddress.CustomButton.TabIndex = 1;
            this.txtPublisherAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPublisherAddress.CustomButton.UseSelectable = true;
            this.txtPublisherAddress.Lines = new string[0];
            this.txtPublisherAddress.Location = new System.Drawing.Point(160, 75);
            this.txtPublisherAddress.MaxLength = 32767;
            this.txtPublisherAddress.Name = "txtPublisherAddress";
            this.txtPublisherAddress.PasswordChar = '\0';
            this.txtPublisherAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPublisherAddress.SelectedText = "";
            this.txtPublisherAddress.SelectionLength = 0;
            this.txtPublisherAddress.SelectionStart = 0;
            this.txtPublisherAddress.ShortcutsEnabled = true;
            this.txtPublisherAddress.ShowButton = true;
            this.txtPublisherAddress.ShowClearButton = true;
            this.txtPublisherAddress.Size = new System.Drawing.Size(419, 23);
            this.txtPublisherAddress.TabIndex = 74;
            this.txtPublisherAddress.UseSelectable = true;
            this.txtPublisherAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPublisherAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPublisherName
            // 
            // 
            // 
            // 
            this.txtPublisherName.CustomButton.Image = null;
            this.txtPublisherName.CustomButton.Location = new System.Drawing.Point(397, 1);
            this.txtPublisherName.CustomButton.Name = "";
            this.txtPublisherName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPublisherName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPublisherName.CustomButton.TabIndex = 1;
            this.txtPublisherName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPublisherName.CustomButton.UseSelectable = true;
            this.txtPublisherName.Lines = new string[0];
            this.txtPublisherName.Location = new System.Drawing.Point(160, 46);
            this.txtPublisherName.MaxLength = 32767;
            this.txtPublisherName.Name = "txtPublisherName";
            this.txtPublisherName.PasswordChar = '\0';
            this.txtPublisherName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPublisherName.SelectedText = "";
            this.txtPublisherName.SelectionLength = 0;
            this.txtPublisherName.SelectionStart = 0;
            this.txtPublisherName.ShortcutsEnabled = true;
            this.txtPublisherName.ShowButton = true;
            this.txtPublisherName.ShowClearButton = true;
            this.txtPublisherName.Size = new System.Drawing.Size(419, 23);
            this.txtPublisherName.TabIndex = 75;
            this.txtPublisherName.UseSelectable = true;
            this.txtPublisherName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPublisherName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPublisherNo
            // 
            // 
            // 
            // 
            this.txtPublisherNo.CustomButton.Image = null;
            this.txtPublisherNo.CustomButton.Location = new System.Drawing.Point(397, 1);
            this.txtPublisherNo.CustomButton.Name = "";
            this.txtPublisherNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPublisherNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPublisherNo.CustomButton.TabIndex = 1;
            this.txtPublisherNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPublisherNo.CustomButton.UseSelectable = true;
            this.txtPublisherNo.Lines = new string[0];
            this.txtPublisherNo.Location = new System.Drawing.Point(160, 17);
            this.txtPublisherNo.MaxLength = 32767;
            this.txtPublisherNo.Name = "txtPublisherNo";
            this.txtPublisherNo.PasswordChar = '\0';
            this.txtPublisherNo.ReadOnly = true;
            this.txtPublisherNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPublisherNo.SelectedText = "";
            this.txtPublisherNo.SelectionLength = 0;
            this.txtPublisherNo.SelectionStart = 0;
            this.txtPublisherNo.ShortcutsEnabled = true;
            this.txtPublisherNo.ShowButton = true;
            this.txtPublisherNo.ShowClearButton = true;
            this.txtPublisherNo.Size = new System.Drawing.Size(419, 23);
            this.txtPublisherNo.TabIndex = 76;
            this.txtPublisherNo.UseSelectable = true;
            this.txtPublisherNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPublisherNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(19, 75);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(56, 19);
            this.metroLabel4.TabIndex = 70;
            this.metroLabel4.Text = "Address";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(19, 104);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(74, 19);
            this.metroLabel3.TabIndex = 69;
            this.metroLabel3.Text = "Description";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(19, 46);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(102, 19);
            this.metroLabel2.TabIndex = 71;
            this.metroLabel2.Text = "Publisher Name";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(19, 17);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(87, 19);
            this.metroLabel1.TabIndex = 72;
            this.metroLabel1.Text = "Publisher No.";
            // 
            // dgvPublisher
            // 
            this.dgvPublisher.AllowUserToAddRows = false;
            this.dgvPublisher.AllowUserToDeleteRows = false;
            this.dgvPublisher.AllowUserToResizeRows = false;
            this.dgvPublisher.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvPublisher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPublisher.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPublisher.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPublisher.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPublisher.ColumnHeadersHeight = 25;
            this.dgvPublisher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PublisherID,
            this.publisher_Name,
            this.Address,
            this.Description});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPublisher.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPublisher.EnableHeadersVisualStyles = false;
            this.dgvPublisher.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvPublisher.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPublisher.Location = new System.Drawing.Point(17, 365);
            this.dgvPublisher.Name = "dgvPublisher";
            this.dgvPublisher.ReadOnly = true;
            this.dgvPublisher.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("UTM Avo", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPublisher.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPublisher.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPublisher.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPublisher.Size = new System.Drawing.Size(598, 193);
            this.dgvPublisher.TabIndex = 59;
            // 
            // PublisherID
            // 
            this.PublisherID.DataPropertyName = "publisher_ID";
            this.PublisherID.HeaderText = "Publisher ID";
            this.PublisherID.Name = "PublisherID";
            this.PublisherID.ReadOnly = true;
            this.PublisherID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // publisher_Name
            // 
            this.publisher_Name.DataPropertyName = "publisher_Name";
            this.publisher_Name.HeaderText = "Publisher Name";
            this.publisher_Name.Name = "publisher_Name";
            this.publisher_Name.ReadOnly = true;
            this.publisher_Name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.publisher_Name.Width = 150;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "publisher_Address";
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Address.Width = 150;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "publisher_Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Description.Width = 200;
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.Gainsboro;
            this.btCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btCancel.BackgroundImage")));
            this.btCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btCancel.Highlight = true;
            this.btCancel.Location = new System.Drawing.Point(278, 302);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(73, 44);
            this.btCancel.TabIndex = 52;
            this.btCancel.UseSelectable = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btRefresh
            // 
            this.btRefresh.BackColor = System.Drawing.Color.Gainsboro;
            this.btRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btRefresh.BackgroundImage")));
            this.btRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btRefresh.Highlight = true;
            this.btRefresh.Location = new System.Drawing.Point(357, 302);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(73, 44);
            this.btRefresh.TabIndex = 53;
            this.btRefresh.UseSelectable = true;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.Color.Gainsboro;
            this.btClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btClose.BackgroundImage")));
            this.btClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btClose.Highlight = true;
            this.btClose.Location = new System.Drawing.Point(515, 302);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(73, 44);
            this.btClose.TabIndex = 54;
            this.btClose.UseSelectable = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.Color.Gainsboro;
            this.btSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btSave.BackgroundImage")));
            this.btSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btSave.Highlight = true;
            this.btSave.Location = new System.Drawing.Point(436, 302);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(73, 44);
            this.btSave.TabIndex = 55;
            this.btSave.UseSelectable = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.Gainsboro;
            this.btDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btDelete.BackgroundImage")));
            this.btDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btDelete.Highlight = true;
            this.btDelete.Location = new System.Drawing.Point(199, 302);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(73, 44);
            this.btDelete.TabIndex = 56;
            this.btDelete.UseSelectable = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.BackColor = System.Drawing.Color.Gainsboro;
            this.btUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btUpdate.BackgroundImage")));
            this.btUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btUpdate.Highlight = true;
            this.btUpdate.Location = new System.Drawing.Point(120, 302);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(73, 44);
            this.btUpdate.TabIndex = 57;
            this.btUpdate.UseSelectable = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btInsert
            // 
            this.btInsert.BackColor = System.Drawing.Color.Gainsboro;
            this.btInsert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btInsert.BackgroundImage")));
            this.btInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btInsert.Highlight = true;
            this.btInsert.Location = new System.Drawing.Point(41, 302);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(73, 44);
            this.btInsert.TabIndex = 58;
            this.btInsert.UseSelectable = true;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // frmPublisher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 654);
            this.Controls.Add(this.metroPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPublisher";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "Publisher";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmPublisher_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.pnPublisher.ResumeLayout(false);
            this.pnPublisher.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPublisher)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroGrid dgvPublisher;
        private MetroFramework.Controls.MetroButton btCancel;
        private MetroFramework.Controls.MetroButton btRefresh;
        private MetroFramework.Controls.MetroButton btClose;
        private MetroFramework.Controls.MetroButton btSave;
        private MetroFramework.Controls.MetroButton btDelete;
        private MetroFramework.Controls.MetroButton btUpdate;
        private MetroFramework.Controls.MetroButton btInsert;
        private MetroFramework.Controls.MetroPanel pnPublisher;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox txtPublisherSearch;
        private MetroFramework.Controls.MetroTextBox txtPublisherDescription;
        private MetroFramework.Controls.MetroTextBox txtPublisherAddress;
        private MetroFramework.Controls.MetroTextBox txtPublisherName;
        private MetroFramework.Controls.MetroTextBox txtPublisherNo;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublisherID;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisher_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}