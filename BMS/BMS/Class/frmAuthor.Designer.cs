namespace BMS.Class
{
    partial class frmAuthor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAuthor));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAuthorSearch = new MetroFramework.Controls.MetroTextBox();
            this.pnAuthor = new MetroFramework.Controls.MetroPanel();
            this.txtAuthorDescription = new MetroFramework.Controls.MetroTextBox();
            this.txtAuthorName = new MetroFramework.Controls.MetroTextBox();
            this.txtAuthorNo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dgvAuthor = new MetroFramework.Controls.MetroGrid();
            this.author_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.pnAuthor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthor)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.Aqua;
            this.metroPanel1.Controls.Add(this.metroPanel2);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 56);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(661, 585);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroPanel2
            // 
            this.metroPanel2.BackColor = System.Drawing.Color.White;
            this.metroPanel2.Controls.Add(this.groupBox1);
            this.metroPanel2.Controls.Add(this.pnAuthor);
            this.metroPanel2.Controls.Add(this.dgvAuthor);
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
            this.metroPanel2.Location = new System.Drawing.Point(14, 14);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(632, 560);
            this.metroPanel2.TabIndex = 2;
            this.metroPanel2.UseCustomBackColor = true;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.txtAuthorSearch);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("UTM Avo", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(315, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 70);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // txtAuthorSearch
            // 
            // 
            // 
            // 
            this.txtAuthorSearch.CustomButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtAuthorSearch.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.txtAuthorSearch.CustomButton.Location = new System.Drawing.Point(219, 1);
            this.txtAuthorSearch.CustomButton.Name = "";
            this.txtAuthorSearch.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtAuthorSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAuthorSearch.CustomButton.TabIndex = 1;
            this.txtAuthorSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAuthorSearch.CustomButton.UseSelectable = true;
            this.txtAuthorSearch.DisplayIcon = true;
            this.txtAuthorSearch.Icon = ((System.Drawing.Image)(resources.GetObject("txtAuthorSearch.Icon")));
            this.txtAuthorSearch.Lines = new string[0];
            this.txtAuthorSearch.Location = new System.Drawing.Point(32, 26);
            this.txtAuthorSearch.MaxLength = 32767;
            this.txtAuthorSearch.Name = "txtAuthorSearch";
            this.txtAuthorSearch.PasswordChar = '\0';
            this.txtAuthorSearch.PromptText = "Enter your keywords!";
            this.txtAuthorSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAuthorSearch.SelectedText = "";
            this.txtAuthorSearch.SelectionLength = 0;
            this.txtAuthorSearch.SelectionStart = 0;
            this.txtAuthorSearch.ShortcutsEnabled = true;
            this.txtAuthorSearch.ShowButton = true;
            this.txtAuthorSearch.ShowClearButton = true;
            this.txtAuthorSearch.Size = new System.Drawing.Size(245, 27);
            this.txtAuthorSearch.TabIndex = 0;
            this.txtAuthorSearch.UseSelectable = true;
            this.txtAuthorSearch.WaterMark = "Enter your keywords!";
            this.txtAuthorSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAuthorSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtAuthorSearch.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.txtAuthorSearch_ButtonClick);
            // 
            // pnAuthor
            // 
            this.pnAuthor.BackColor = System.Drawing.Color.White;
            this.pnAuthor.Controls.Add(this.txtAuthorDescription);
            this.pnAuthor.Controls.Add(this.txtAuthorName);
            this.pnAuthor.Controls.Add(this.txtAuthorNo);
            this.pnAuthor.Controls.Add(this.metroLabel3);
            this.pnAuthor.Controls.Add(this.metroLabel2);
            this.pnAuthor.Controls.Add(this.metroLabel1);
            this.pnAuthor.HorizontalScrollbarBarColor = true;
            this.pnAuthor.HorizontalScrollbarHighlightOnWheel = false;
            this.pnAuthor.HorizontalScrollbarSize = 10;
            this.pnAuthor.Location = new System.Drawing.Point(11, 91);
            this.pnAuthor.Name = "pnAuthor";
            this.pnAuthor.Size = new System.Drawing.Size(603, 171);
            this.pnAuthor.TabIndex = 60;
            this.pnAuthor.UseCustomBackColor = true;
            this.pnAuthor.VerticalScrollbarBarColor = true;
            this.pnAuthor.VerticalScrollbarHighlightOnWheel = false;
            this.pnAuthor.VerticalScrollbarSize = 10;
            // 
            // txtAuthorDescription
            // 
            // 
            // 
            // 
            this.txtAuthorDescription.CustomButton.Image = null;
            this.txtAuthorDescription.CustomButton.Location = new System.Drawing.Point(341, 2);
            this.txtAuthorDescription.CustomButton.Name = "";
            this.txtAuthorDescription.CustomButton.Size = new System.Drawing.Size(75, 75);
            this.txtAuthorDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAuthorDescription.CustomButton.TabIndex = 1;
            this.txtAuthorDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAuthorDescription.CustomButton.UseSelectable = true;
            this.txtAuthorDescription.CustomButton.Visible = false;
            this.txtAuthorDescription.Lines = new string[0];
            this.txtAuthorDescription.Location = new System.Drawing.Point(160, 74);
            this.txtAuthorDescription.MaxLength = 32767;
            this.txtAuthorDescription.Multiline = true;
            this.txtAuthorDescription.Name = "txtAuthorDescription";
            this.txtAuthorDescription.PasswordChar = '\0';
            this.txtAuthorDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAuthorDescription.SelectedText = "";
            this.txtAuthorDescription.SelectionLength = 0;
            this.txtAuthorDescription.SelectionStart = 0;
            this.txtAuthorDescription.ShortcutsEnabled = true;
            this.txtAuthorDescription.ShowClearButton = true;
            this.txtAuthorDescription.Size = new System.Drawing.Size(419, 80);
            this.txtAuthorDescription.TabIndex = 70;
            this.txtAuthorDescription.UseSelectable = true;
            this.txtAuthorDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAuthorDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAuthorName
            // 
            // 
            // 
            // 
            this.txtAuthorName.CustomButton.Image = null;
            this.txtAuthorName.CustomButton.Location = new System.Drawing.Point(397, 1);
            this.txtAuthorName.CustomButton.Name = "";
            this.txtAuthorName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAuthorName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAuthorName.CustomButton.TabIndex = 1;
            this.txtAuthorName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAuthorName.CustomButton.UseSelectable = true;
            this.txtAuthorName.Lines = new string[0];
            this.txtAuthorName.Location = new System.Drawing.Point(160, 45);
            this.txtAuthorName.MaxLength = 32767;
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.PasswordChar = '\0';
            this.txtAuthorName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAuthorName.SelectedText = "";
            this.txtAuthorName.SelectionLength = 0;
            this.txtAuthorName.SelectionStart = 0;
            this.txtAuthorName.ShortcutsEnabled = true;
            this.txtAuthorName.ShowButton = true;
            this.txtAuthorName.ShowClearButton = true;
            this.txtAuthorName.Size = new System.Drawing.Size(419, 23);
            this.txtAuthorName.TabIndex = 71;
            this.txtAuthorName.UseSelectable = true;
            this.txtAuthorName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAuthorName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAuthorNo
            // 
            // 
            // 
            // 
            this.txtAuthorNo.CustomButton.Image = null;
            this.txtAuthorNo.CustomButton.Location = new System.Drawing.Point(397, 1);
            this.txtAuthorNo.CustomButton.Name = "";
            this.txtAuthorNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAuthorNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAuthorNo.CustomButton.TabIndex = 1;
            this.txtAuthorNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAuthorNo.CustomButton.UseSelectable = true;
            this.txtAuthorNo.Lines = new string[0];
            this.txtAuthorNo.Location = new System.Drawing.Point(160, 16);
            this.txtAuthorNo.MaxLength = 32767;
            this.txtAuthorNo.Name = "txtAuthorNo";
            this.txtAuthorNo.PasswordChar = '\0';
            this.txtAuthorNo.ReadOnly = true;
            this.txtAuthorNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAuthorNo.SelectedText = "";
            this.txtAuthorNo.SelectionLength = 0;
            this.txtAuthorNo.SelectionStart = 0;
            this.txtAuthorNo.ShortcutsEnabled = true;
            this.txtAuthorNo.ShowButton = true;
            this.txtAuthorNo.ShowClearButton = true;
            this.txtAuthorNo.Size = new System.Drawing.Size(419, 23);
            this.txtAuthorNo.TabIndex = 72;
            this.txtAuthorNo.UseSelectable = true;
            this.txtAuthorNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAuthorNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(24, 74);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(74, 19);
            this.metroLabel3.TabIndex = 67;
            this.metroLabel3.Text = "Description";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(24, 45);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(89, 19);
            this.metroLabel2.TabIndex = 68;
            this.metroLabel2.Text = "Author Name";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 16);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(74, 19);
            this.metroLabel1.TabIndex = 69;
            this.metroLabel1.Text = "Author No.";
            // 
            // dgvAuthor
            // 
            this.dgvAuthor.AllowUserToAddRows = false;
            this.dgvAuthor.AllowUserToDeleteRows = false;
            this.dgvAuthor.AllowUserToResizeRows = false;
            this.dgvAuthor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvAuthor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAuthor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvAuthor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAuthor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAuthor.ColumnHeadersHeight = 25;
            this.dgvAuthor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.author_ID,
            this.author_Name,
            this.Description});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAuthor.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAuthor.EnableHeadersVisualStyles = false;
            this.dgvAuthor.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvAuthor.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvAuthor.Location = new System.Drawing.Point(17, 335);
            this.dgvAuthor.MultiSelect = false;
            this.dgvAuthor.Name = "dgvAuthor";
            this.dgvAuthor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("UTM Avo", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAuthor.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAuthor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAuthor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAuthor.Size = new System.Drawing.Size(598, 208);
            this.dgvAuthor.TabIndex = 59;
            this.dgvAuthor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAuthor_CellClick);
            // 
            // author_ID
            // 
            this.author_ID.DataPropertyName = "author_ID";
            this.author_ID.HeaderText = "Author ID";
            this.author_ID.Name = "author_ID";
            this.author_ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.author_ID.Width = 81;
            // 
            // author_Name
            // 
            this.author_Name.DataPropertyName = "author_Full_Name";
            this.author_Name.HeaderText = "Author Name";
            this.author_Name.Name = "author_Name";
            this.author_Name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.author_Name.Width = 220;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "author_Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Description.Width = 255;
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.Gainsboro;
            this.btCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btCancel.BackgroundImage")));
            this.btCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btCancel.Highlight = true;
            this.btCancel.Location = new System.Drawing.Point(278, 271);
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
            this.btRefresh.Location = new System.Drawing.Point(357, 271);
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
            this.btClose.Location = new System.Drawing.Point(515, 271);
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
            this.btSave.Location = new System.Drawing.Point(436, 271);
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
            this.btDelete.Location = new System.Drawing.Point(199, 271);
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
            this.btUpdate.Location = new System.Drawing.Point(120, 271);
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
            this.btInsert.Location = new System.Drawing.Point(41, 271);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(73, 44);
            this.btInsert.TabIndex = 58;
            this.btInsert.UseSelectable = true;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // frmAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 642);
            this.Controls.Add(this.metroPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAuthor";
            this.Resizable = false;
            this.RightToLeftLayout = true;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "Author";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmAuthor_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.pnAuthor.ResumeLayout(false);
            this.pnAuthor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroButton btCancel;
        private MetroFramework.Controls.MetroButton btRefresh;
        private MetroFramework.Controls.MetroButton btClose;
        private MetroFramework.Controls.MetroButton btSave;
        private MetroFramework.Controls.MetroButton btDelete;
        private MetroFramework.Controls.MetroButton btUpdate;
        private MetroFramework.Controls.MetroButton btInsert;
        private MetroFramework.Controls.MetroPanel pnAuthor;
        private MetroFramework.Controls.MetroGrid dgvAuthor;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox txtAuthorSearch;
        private MetroFramework.Controls.MetroTextBox txtAuthorDescription;
        private MetroFramework.Controls.MetroTextBox txtAuthorName;
        private MetroFramework.Controls.MetroTextBox txtAuthorNo;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn author_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn author_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}