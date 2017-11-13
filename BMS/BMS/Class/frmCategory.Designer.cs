namespace BMS.Class
{
    partial class frmCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategory));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCategorySearch = new MetroFramework.Controls.MetroTextBox();
            this.pnCategory = new MetroFramework.Controls.MetroPanel();
            this.txtCategoryDiscription = new MetroFramework.Controls.MetroTextBox();
            this.txtCategoryName = new MetroFramework.Controls.MetroTextBox();
            this.txtCategoryNo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dgvCategory = new MetroFramework.Controls.MetroGrid();
            this.catefory_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.pnCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.SpringGreen;
            this.metroPanel1.Controls.Add(this.metroPanel2);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 59);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(661, 585);
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
            this.metroPanel2.Controls.Add(this.pnCategory);
            this.metroPanel2.Controls.Add(this.dgvCategory);
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
            this.groupBox1.Controls.Add(this.txtCategorySearch);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("UTM Avo", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(319, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 70);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // txtCategorySearch
            // 
            // 
            // 
            // 
            this.txtCategorySearch.CustomButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtCategorySearch.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.txtCategorySearch.CustomButton.Location = new System.Drawing.Point(219, 1);
            this.txtCategorySearch.CustomButton.Name = "";
            this.txtCategorySearch.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtCategorySearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCategorySearch.CustomButton.TabIndex = 1;
            this.txtCategorySearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCategorySearch.CustomButton.UseSelectable = true;
            this.txtCategorySearch.DisplayIcon = true;
            this.txtCategorySearch.Icon = ((System.Drawing.Image)(resources.GetObject("txtCategorySearch.Icon")));
            this.txtCategorySearch.Lines = new string[0];
            this.txtCategorySearch.Location = new System.Drawing.Point(32, 26);
            this.txtCategorySearch.MaxLength = 32767;
            this.txtCategorySearch.Name = "txtCategorySearch";
            this.txtCategorySearch.PasswordChar = '\0';
            this.txtCategorySearch.PromptText = "Enter your keywords!";
            this.txtCategorySearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCategorySearch.SelectedText = "";
            this.txtCategorySearch.SelectionLength = 0;
            this.txtCategorySearch.SelectionStart = 0;
            this.txtCategorySearch.ShortcutsEnabled = true;
            this.txtCategorySearch.ShowButton = true;
            this.txtCategorySearch.ShowClearButton = true;
            this.txtCategorySearch.Size = new System.Drawing.Size(245, 27);
            this.txtCategorySearch.TabIndex = 0;
            this.txtCategorySearch.UseSelectable = true;
            this.txtCategorySearch.WaterMark = "Enter your keywords!";
            this.txtCategorySearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCategorySearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pnCategory
            // 
            this.pnCategory.BackColor = System.Drawing.Color.White;
            this.pnCategory.Controls.Add(this.txtCategoryDiscription);
            this.pnCategory.Controls.Add(this.txtCategoryName);
            this.pnCategory.Controls.Add(this.txtCategoryNo);
            this.pnCategory.Controls.Add(this.metroLabel3);
            this.pnCategory.Controls.Add(this.metroLabel2);
            this.pnCategory.Controls.Add(this.metroLabel1);
            this.pnCategory.HorizontalScrollbarBarColor = true;
            this.pnCategory.HorizontalScrollbarHighlightOnWheel = false;
            this.pnCategory.HorizontalScrollbarSize = 10;
            this.pnCategory.Location = new System.Drawing.Point(12, 89);
            this.pnCategory.Name = "pnCategory";
            this.pnCategory.Size = new System.Drawing.Size(602, 172);
            this.pnCategory.TabIndex = 60;
            this.pnCategory.UseCustomBackColor = true;
            this.pnCategory.VerticalScrollbarBarColor = true;
            this.pnCategory.VerticalScrollbarHighlightOnWheel = false;
            this.pnCategory.VerticalScrollbarSize = 10;
            // 
            // txtCategoryDiscription
            // 
            // 
            // 
            // 
            this.txtCategoryDiscription.CustomButton.Image = null;
            this.txtCategoryDiscription.CustomButton.Location = new System.Drawing.Point(341, 2);
            this.txtCategoryDiscription.CustomButton.Name = "";
            this.txtCategoryDiscription.CustomButton.Size = new System.Drawing.Size(75, 75);
            this.txtCategoryDiscription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCategoryDiscription.CustomButton.TabIndex = 1;
            this.txtCategoryDiscription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCategoryDiscription.CustomButton.UseSelectable = true;
            this.txtCategoryDiscription.CustomButton.Visible = false;
            this.txtCategoryDiscription.Lines = new string[0];
            this.txtCategoryDiscription.Location = new System.Drawing.Point(160, 75);
            this.txtCategoryDiscription.MaxLength = 32767;
            this.txtCategoryDiscription.Multiline = true;
            this.txtCategoryDiscription.Name = "txtCategoryDiscription";
            this.txtCategoryDiscription.PasswordChar = '\0';
            this.txtCategoryDiscription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCategoryDiscription.SelectedText = "";
            this.txtCategoryDiscription.SelectionLength = 0;
            this.txtCategoryDiscription.SelectionStart = 0;
            this.txtCategoryDiscription.ShortcutsEnabled = true;
            this.txtCategoryDiscription.ShowClearButton = true;
            this.txtCategoryDiscription.Size = new System.Drawing.Size(419, 80);
            this.txtCategoryDiscription.TabIndex = 70;
            this.txtCategoryDiscription.UseSelectable = true;
            this.txtCategoryDiscription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCategoryDiscription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCategoryName
            // 
            // 
            // 
            // 
            this.txtCategoryName.CustomButton.Image = null;
            this.txtCategoryName.CustomButton.Location = new System.Drawing.Point(397, 1);
            this.txtCategoryName.CustomButton.Name = "";
            this.txtCategoryName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCategoryName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCategoryName.CustomButton.TabIndex = 1;
            this.txtCategoryName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCategoryName.CustomButton.UseSelectable = true;
            this.txtCategoryName.Lines = new string[0];
            this.txtCategoryName.Location = new System.Drawing.Point(160, 46);
            this.txtCategoryName.MaxLength = 32767;
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.PasswordChar = '\0';
            this.txtCategoryName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCategoryName.SelectedText = "";
            this.txtCategoryName.SelectionLength = 0;
            this.txtCategoryName.SelectionStart = 0;
            this.txtCategoryName.ShortcutsEnabled = true;
            this.txtCategoryName.ShowButton = true;
            this.txtCategoryName.ShowClearButton = true;
            this.txtCategoryName.Size = new System.Drawing.Size(419, 23);
            this.txtCategoryName.TabIndex = 71;
            this.txtCategoryName.UseSelectable = true;
            this.txtCategoryName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCategoryName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCategoryNo
            // 
            // 
            // 
            // 
            this.txtCategoryNo.CustomButton.Image = null;
            this.txtCategoryNo.CustomButton.Location = new System.Drawing.Point(397, 1);
            this.txtCategoryNo.CustomButton.Name = "";
            this.txtCategoryNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCategoryNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCategoryNo.CustomButton.TabIndex = 1;
            this.txtCategoryNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCategoryNo.CustomButton.UseSelectable = true;
            this.txtCategoryNo.Lines = new string[0];
            this.txtCategoryNo.Location = new System.Drawing.Point(160, 17);
            this.txtCategoryNo.MaxLength = 32767;
            this.txtCategoryNo.Name = "txtCategoryNo";
            this.txtCategoryNo.PasswordChar = '\0';
            this.txtCategoryNo.ReadOnly = true;
            this.txtCategoryNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCategoryNo.SelectedText = "";
            this.txtCategoryNo.SelectionLength = 0;
            this.txtCategoryNo.SelectionStart = 0;
            this.txtCategoryNo.ShortcutsEnabled = true;
            this.txtCategoryNo.ShowButton = true;
            this.txtCategoryNo.ShowClearButton = true;
            this.txtCategoryNo.Size = new System.Drawing.Size(419, 23);
            this.txtCategoryNo.TabIndex = 72;
            this.txtCategoryNo.UseSelectable = true;
            this.txtCategoryNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCategoryNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(24, 75);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(70, 19);
            this.metroLabel3.TabIndex = 67;
            this.metroLabel3.Text = "Discription";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(24, 46);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(104, 19);
            this.metroLabel2.TabIndex = 68;
            this.metroLabel2.Text = "Category Name";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 17);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(89, 19);
            this.metroLabel1.TabIndex = 69;
            this.metroLabel1.Text = "Category No.";
            // 
            // dgvCategory
            // 
            this.dgvCategory.AllowUserToResizeRows = false;
            this.dgvCategory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCategory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCategory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.catefory_ID,
            this.category_Name,
            this.Description});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCategory.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCategory.EnableHeadersVisualStyles = false;
            this.dgvCategory.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvCategory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvCategory.Location = new System.Drawing.Point(17, 335);
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategory.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCategory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategory.Size = new System.Drawing.Size(598, 208);
            this.dgvCategory.TabIndex = 59;
            // 
            // catefory_ID
            // 
            this.catefory_ID.DataPropertyName = "category_ID";
            this.catefory_ID.HeaderText = "Category ID";
            this.catefory_ID.Name = "catefory_ID";
            this.catefory_ID.ReadOnly = true;
            this.catefory_ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // category_Name
            // 
            this.category_Name.DataPropertyName = "category_Name";
            this.category_Name.HeaderText = "Category Name";
            this.category_Name.Name = "category_Name";
            this.category_Name.ReadOnly = true;
            this.category_Name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.category_Name.Width = 250;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "category_Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Description.Width = 210;
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
            // frmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 642);
            this.Controls.Add(this.metroPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCategory";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "Category";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmCategory_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.pnCategory.ResumeLayout(false);
            this.pnCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroGrid dgvCategory;
        private MetroFramework.Controls.MetroButton btCancel;
        private MetroFramework.Controls.MetroButton btRefresh;
        private MetroFramework.Controls.MetroButton btClose;
        private MetroFramework.Controls.MetroButton btSave;
        private MetroFramework.Controls.MetroButton btDelete;
        private MetroFramework.Controls.MetroButton btUpdate;
        private MetroFramework.Controls.MetroButton btInsert;
        private MetroFramework.Controls.MetroPanel pnCategory;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox txtCategorySearch;
        private MetroFramework.Controls.MetroTextBox txtCategoryDiscription;
        private MetroFramework.Controls.MetroTextBox txtCategoryName;
        private MetroFramework.Controls.MetroTextBox txtCategoryNo;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn catefory_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn category_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}