namespace BMS.Class
{
    partial class frmBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBook));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlBook = new MetroFramework.Controls.MetroPanel();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.pnControl = new MetroFramework.Controls.MetroPanel();
            this.btLast = new MetroFramework.Controls.MetroButton();
            this.txtPage = new MetroFramework.Controls.MetroTextBox();
            this.btFirst = new MetroFramework.Controls.MetroButton();
            this.btNext = new MetroFramework.Controls.MetroButton();
            this.lbTotalRecord = new MetroFramework.Controls.MetroLabel();
            this.btPrevious = new MetroFramework.Controls.MetroButton();
            this.dgvBooks = new MetroFramework.Controls.MetroGrid();
            this.book_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisher_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year_Published = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.image = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnBookSearch = new MetroFramework.Controls.MetroPanel();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.rdCategoryNo = new MetroFramework.Controls.MetroRadioButton();
            this.rdCategoryName = new MetroFramework.Controls.MetroRadioButton();
            this.rdPublisherNo = new MetroFramework.Controls.MetroRadioButton();
            this.rdPublisherName = new MetroFramework.Controls.MetroRadioButton();
            this.rdBookNo = new MetroFramework.Controls.MetroRadioButton();
            this.rdAuthorNo = new MetroFramework.Controls.MetroRadioButton();
            this.rdAuthorName = new MetroFramework.Controls.MetroRadioButton();
            this.rdBookTitle = new MetroFramework.Controls.MetroRadioButton();
            this.linkBack = new MetroFramework.Controls.MetroLink();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel5 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.pnBookDetails = new MetroFramework.Controls.MetroPanel();
            this.cbCategory = new MetroFramework.Controls.MetroComboBox();
            this.cbPublisher = new MetroFramework.Controls.MetroComboBox();
            this.cbAuthor = new MetroFramework.Controls.MetroComboBox();
            this.btOpenFile = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtQuantity = new MetroFramework.Controls.MetroTextBox();
            this.txtPrice = new MetroFramework.Controls.MetroTextBox();
            this.txtPages = new MetroFramework.Controls.MetroTextBox();
            this.txtYearofPublished = new MetroFramework.Controls.MetroTextBox();
            this.txtBookTitle = new MetroFramework.Controls.MetroTextBox();
            this.txtBookID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pbBook = new System.Windows.Forms.PictureBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.mtCategory = new MetroFramework.Controls.MetroTile();
            this.mtPublisher = new MetroFramework.Controls.MetroTile();
            this.mtAuthor = new MetroFramework.Controls.MetroTile();
            this.mtHome = new MetroFramework.Controls.MetroTile();
            this.btRefresh = new MetroFramework.Controls.MetroButton();
            this.btCancel = new MetroFramework.Controls.MetroButton();
            this.btSave = new MetroFramework.Controls.MetroButton();
            this.btDelete = new MetroFramework.Controls.MetroButton();
            this.btUpdate = new MetroFramework.Controls.MetroButton();
            this.btInsert = new MetroFramework.Controls.MetroButton();
            this.pnlBook.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            this.pnControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.pnBookSearch.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroPanel5.SuspendLayout();
            this.pnBookDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBook)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBook
            // 
            this.pnlBook.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBook.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBook.Controls.Add(this.metroPanel4);
            this.pnlBook.Controls.Add(this.pnBookSearch);
            this.pnlBook.Controls.Add(this.linkBack);
            this.pnlBook.Controls.Add(this.metroPanel2);
            this.pnlBook.HorizontalScrollbarBarColor = true;
            this.pnlBook.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlBook.HorizontalScrollbarSize = 10;
            this.pnlBook.Location = new System.Drawing.Point(0, 3);
            this.pnlBook.Name = "pnlBook";
            this.pnlBook.Size = new System.Drawing.Size(1294, 648);
            this.pnlBook.TabIndex = 0;
            this.pnlBook.UseCustomBackColor = true;
            this.pnlBook.VerticalScrollbarBarColor = true;
            this.pnlBook.VerticalScrollbarHighlightOnWheel = false;
            this.pnlBook.VerticalScrollbarSize = 10;
            // 
            // metroPanel4
            // 
            this.metroPanel4.BackColor = System.Drawing.Color.Black;
            this.metroPanel4.Controls.Add(this.pnControl);
            this.metroPanel4.Controls.Add(this.dgvBooks);
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(716, 134);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(541, 407);
            this.metroPanel4.TabIndex = 11;
            this.metroPanel4.UseCustomBackColor = true;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // pnControl
            // 
            this.pnControl.BackColor = System.Drawing.Color.Transparent;
            this.pnControl.Controls.Add(this.btLast);
            this.pnControl.Controls.Add(this.txtPage);
            this.pnControl.Controls.Add(this.btFirst);
            this.pnControl.Controls.Add(this.btNext);
            this.pnControl.Controls.Add(this.lbTotalRecord);
            this.pnControl.Controls.Add(this.btPrevious);
            this.pnControl.HorizontalScrollbarBarColor = true;
            this.pnControl.HorizontalScrollbarHighlightOnWheel = false;
            this.pnControl.HorizontalScrollbarSize = 10;
            this.pnControl.Location = new System.Drawing.Point(3, 1);
            this.pnControl.Name = "pnControl";
            this.pnControl.Size = new System.Drawing.Size(538, 29);
            this.pnControl.TabIndex = 12;
            this.pnControl.UseCustomBackColor = true;
            this.pnControl.VerticalScrollbarBarColor = true;
            this.pnControl.VerticalScrollbarHighlightOnWheel = false;
            this.pnControl.VerticalScrollbarSize = 10;
            // 
            // btLast
            // 
            this.btLast.BackColor = System.Drawing.SystemColors.Control;
            this.btLast.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btLast.BackgroundImage")));
            this.btLast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btLast.Location = new System.Drawing.Point(473, 2);
            this.btLast.Name = "btLast";
            this.btLast.Size = new System.Drawing.Size(59, 26);
            this.btLast.TabIndex = 9;
            this.btLast.UseSelectable = true;
            this.btLast.Click += new System.EventHandler(this.btLast_Click);
            // 
            // txtPage
            // 
            this.txtPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPage.BackColor = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.txtPage.CustomButton.Image = null;
            this.txtPage.CustomButton.Location = new System.Drawing.Point(12, 1);
            this.txtPage.CustomButton.Name = "";
            this.txtPage.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPage.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPage.CustomButton.TabIndex = 1;
            this.txtPage.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPage.CustomButton.UseSelectable = true;
            this.txtPage.CustomButton.Visible = false;
            this.txtPage.ForeColor = System.Drawing.Color.White;
            this.txtPage.Lines = new string[] {
        "1"};
            this.txtPage.Location = new System.Drawing.Point(215, 4);
            this.txtPage.MaxLength = 32767;
            this.txtPage.Name = "txtPage";
            this.txtPage.PasswordChar = '\0';
            this.txtPage.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPage.SelectedText = "";
            this.txtPage.SelectionLength = 0;
            this.txtPage.SelectionStart = 0;
            this.txtPage.ShortcutsEnabled = true;
            this.txtPage.Size = new System.Drawing.Size(34, 23);
            this.txtPage.TabIndex = 11;
            this.txtPage.Text = "1";
            this.txtPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPage.UseCustomBackColor = true;
            this.txtPage.UseCustomForeColor = true;
            this.txtPage.UseSelectable = true;
            this.txtPage.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPage.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPage.TextChanged += new System.EventHandler(this.txtPage_TextChanged);
            // 
            // btFirst
            // 
            this.btFirst.BackColor = System.Drawing.SystemColors.Control;
            this.btFirst.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btFirst.BackgroundImage")));
            this.btFirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btFirst.Location = new System.Drawing.Point(2, 2);
            this.btFirst.Name = "btFirst";
            this.btFirst.Size = new System.Drawing.Size(59, 26);
            this.btFirst.TabIndex = 9;
            this.btFirst.UseSelectable = true;
            this.btFirst.Click += new System.EventHandler(this.btFirst_Click);
            // 
            // btNext
            // 
            this.btNext.BackColor = System.Drawing.SystemColors.Control;
            this.btNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btNext.BackgroundImage")));
            this.btNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btNext.Location = new System.Drawing.Point(408, 2);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(59, 26);
            this.btNext.TabIndex = 9;
            this.btNext.UseSelectable = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // lbTotalRecord
            // 
            this.lbTotalRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTotalRecord.BackColor = System.Drawing.Color.Transparent;
            this.lbTotalRecord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTotalRecord.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lbTotalRecord.ForeColor = System.Drawing.Color.White;
            this.lbTotalRecord.Location = new System.Drawing.Point(255, 4);
            this.lbTotalRecord.Name = "lbTotalRecord";
            this.lbTotalRecord.Size = new System.Drawing.Size(65, 23);
            this.lbTotalRecord.TabIndex = 10;
            this.lbTotalRecord.UseCustomBackColor = true;
            this.lbTotalRecord.UseCustomForeColor = true;
            // 
            // btPrevious
            // 
            this.btPrevious.BackColor = System.Drawing.SystemColors.Control;
            this.btPrevious.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btPrevious.BackgroundImage")));
            this.btPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btPrevious.Location = new System.Drawing.Point(67, 3);
            this.btPrevious.Name = "btPrevious";
            this.btPrevious.Size = new System.Drawing.Size(59, 26);
            this.btPrevious.TabIndex = 9;
            this.btPrevious.UseSelectable = true;
            this.btPrevious.Click += new System.EventHandler(this.btPrevious_Click);
            // 
            // dgvBooks
            // 
            this.dgvBooks.AllowUserToAddRows = false;
            this.dgvBooks.AllowUserToDeleteRows = false;
            this.dgvBooks.AllowUserToResizeRows = false;
            this.dgvBooks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvBooks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBooks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvBooks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBooks.ColumnHeadersHeight = 30;
            this.dgvBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.book_ID,
            this.book_Title,
            this.author_Name,
            this.publisher_Name,
            this.category_ID,
            this.year_Published,
            this.pages,
            this.quantity,
            this.unit_Price,
            this.image});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBooks.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBooks.EnableHeadersVisualStyles = false;
            this.dgvBooks.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvBooks.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvBooks.Location = new System.Drawing.Point(5, 34);
            this.dgvBooks.MultiSelect = false;
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.ReadOnly = true;
            this.dgvBooks.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBooks.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBooks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooks.Size = new System.Drawing.Size(530, 360);
            this.dgvBooks.TabIndex = 8;
            // 
            // book_ID
            // 
            this.book_ID.DataPropertyName = "book_ID";
            this.book_ID.HeaderText = "Book ID";
            this.book_ID.Name = "book_ID";
            this.book_ID.ReadOnly = true;
            this.book_ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.book_ID.Width = 80;
            // 
            // book_Title
            // 
            this.book_Title.DataPropertyName = "book_Title";
            this.book_Title.HeaderText = "Book Title";
            this.book_Title.Name = "book_Title";
            this.book_Title.ReadOnly = true;
            this.book_Title.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.book_Title.Width = 200;
            // 
            // author_Name
            // 
            this.author_Name.DataPropertyName = "author_Full_Name";
            this.author_Name.HeaderText = "Author Name";
            this.author_Name.Name = "author_Name";
            this.author_Name.ReadOnly = true;
            this.author_Name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.author_Name.Width = 150;
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
            // category_ID
            // 
            this.category_ID.DataPropertyName = "category_Name";
            this.category_ID.HeaderText = "Category Name";
            this.category_ID.Name = "category_ID";
            this.category_ID.ReadOnly = true;
            this.category_ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.category_ID.Width = 150;
            // 
            // year_Published
            // 
            this.year_Published.DataPropertyName = "year_Published";
            this.year_Published.HeaderText = "Year Published";
            this.year_Published.Name = "year_Published";
            this.year_Published.ReadOnly = true;
            this.year_Published.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // pages
            // 
            this.pages.DataPropertyName = "pages";
            this.pages.HeaderText = "Pages";
            this.pages.Name = "pages";
            this.pages.ReadOnly = true;
            this.pages.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "quantity";
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // unit_Price
            // 
            this.unit_Price.DataPropertyName = "unit_Price";
            this.unit_Price.HeaderText = "Unit Price";
            this.unit_Price.Name = "unit_Price";
            this.unit_Price.ReadOnly = true;
            this.unit_Price.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // image
            // 
            this.image.DataPropertyName = "book_Image";
            this.image.HeaderText = "Image";
            this.image.Name = "image";
            this.image.ReadOnly = true;
            this.image.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // pnBookSearch
            // 
            this.pnBookSearch.BackColor = System.Drawing.Color.Black;
            this.pnBookSearch.Controls.Add(this.metroPanel3);
            this.pnBookSearch.Controls.Add(this.rdCategoryNo);
            this.pnBookSearch.Controls.Add(this.rdCategoryName);
            this.pnBookSearch.Controls.Add(this.rdPublisherNo);
            this.pnBookSearch.Controls.Add(this.rdPublisherName);
            this.pnBookSearch.Controls.Add(this.rdBookNo);
            this.pnBookSearch.Controls.Add(this.rdAuthorNo);
            this.pnBookSearch.Controls.Add(this.rdAuthorName);
            this.pnBookSearch.Controls.Add(this.rdBookTitle);
            this.pnBookSearch.HorizontalScrollbarBarColor = true;
            this.pnBookSearch.HorizontalScrollbarHighlightOnWheel = false;
            this.pnBookSearch.HorizontalScrollbarSize = 10;
            this.pnBookSearch.Location = new System.Drawing.Point(716, 17);
            this.pnBookSearch.Name = "pnBookSearch";
            this.pnBookSearch.Size = new System.Drawing.Size(541, 111);
            this.pnBookSearch.TabIndex = 12;
            this.pnBookSearch.UseCustomBackColor = true;
            this.pnBookSearch.VerticalScrollbarBarColor = true;
            this.pnBookSearch.VerticalScrollbarHighlightOnWheel = false;
            this.pnBookSearch.VerticalScrollbarSize = 10;
            // 
            // metroPanel3
            // 
            this.metroPanel3.BackColor = System.Drawing.Color.Red;
            this.metroPanel3.Controls.Add(this.txtSearch);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(0, 5);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(541, 32);
            this.metroPanel3.TabIndex = 9;
            this.metroPanel3.UseCustomBackColor = true;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(251, 1);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.DisplayIcon = true;
            this.txtSearch.Icon = ((System.Drawing.Image)(resources.GetObject("txtSearch.Icon")));
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(258, 3);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PromptText = "Enter your keywords!";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.ShowButton = true;
            this.txtSearch.Size = new System.Drawing.Size(277, 27);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "Enter your keywords!";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearch.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.txtSearch_ButtonClick);
            // 
            // rdCategoryNo
            // 
            this.rdCategoryNo.AutoSize = true;
            this.rdCategoryNo.ForeColor = System.Drawing.Color.White;
            this.rdCategoryNo.Location = new System.Drawing.Point(386, 75);
            this.rdCategoryNo.Name = "rdCategoryNo";
            this.rdCategoryNo.Size = new System.Drawing.Size(93, 15);
            this.rdCategoryNo.TabIndex = 7;
            this.rdCategoryNo.Text = "Category No.";
            this.rdCategoryNo.UseCustomBackColor = true;
            this.rdCategoryNo.UseCustomForeColor = true;
            this.rdCategoryNo.UseSelectable = true;
            // 
            // rdCategoryName
            // 
            this.rdCategoryName.AutoSize = true;
            this.rdCategoryName.ForeColor = System.Drawing.Color.White;
            this.rdCategoryName.Location = new System.Drawing.Point(386, 53);
            this.rdCategoryName.Name = "rdCategoryName";
            this.rdCategoryName.Size = new System.Drawing.Size(106, 15);
            this.rdCategoryName.TabIndex = 8;
            this.rdCategoryName.Text = "Category Name";
            this.rdCategoryName.UseCustomBackColor = true;
            this.rdCategoryName.UseCustomForeColor = true;
            this.rdCategoryName.UseSelectable = true;
            // 
            // rdPublisherNo
            // 
            this.rdPublisherNo.AutoSize = true;
            this.rdPublisherNo.ForeColor = System.Drawing.Color.White;
            this.rdPublisherNo.Location = new System.Drawing.Point(258, 75);
            this.rdPublisherNo.Name = "rdPublisherNo";
            this.rdPublisherNo.Size = new System.Drawing.Size(94, 15);
            this.rdPublisherNo.TabIndex = 3;
            this.rdPublisherNo.Text = "Publisher No.";
            this.rdPublisherNo.UseCustomBackColor = true;
            this.rdPublisherNo.UseCustomForeColor = true;
            this.rdPublisherNo.UseSelectable = true;
            // 
            // rdPublisherName
            // 
            this.rdPublisherName.AutoSize = true;
            this.rdPublisherName.ForeColor = System.Drawing.Color.White;
            this.rdPublisherName.Location = new System.Drawing.Point(258, 53);
            this.rdPublisherName.Name = "rdPublisherName";
            this.rdPublisherName.Size = new System.Drawing.Size(107, 15);
            this.rdPublisherName.TabIndex = 3;
            this.rdPublisherName.Text = "Publisher Name";
            this.rdPublisherName.UseCustomBackColor = true;
            this.rdPublisherName.UseCustomForeColor = true;
            this.rdPublisherName.UseSelectable = true;
            // 
            // rdBookNo
            // 
            this.rdBookNo.AutoSize = true;
            this.rdBookNo.ForeColor = System.Drawing.Color.White;
            this.rdBookNo.Location = new System.Drawing.Point(48, 75);
            this.rdBookNo.Name = "rdBookNo";
            this.rdBookNo.Size = new System.Drawing.Size(72, 15);
            this.rdBookNo.TabIndex = 3;
            this.rdBookNo.Text = "Book No.";
            this.rdBookNo.UseCustomBackColor = true;
            this.rdBookNo.UseCustomForeColor = true;
            this.rdBookNo.UseSelectable = true;
            // 
            // rdAuthorNo
            // 
            this.rdAuthorNo.AutoSize = true;
            this.rdAuthorNo.ForeColor = System.Drawing.Color.White;
            this.rdAuthorNo.Location = new System.Drawing.Point(144, 74);
            this.rdAuthorNo.Name = "rdAuthorNo";
            this.rdAuthorNo.Size = new System.Drawing.Size(82, 15);
            this.rdAuthorNo.TabIndex = 3;
            this.rdAuthorNo.Text = "Author No.";
            this.rdAuthorNo.UseCustomBackColor = true;
            this.rdAuthorNo.UseCustomForeColor = true;
            this.rdAuthorNo.UseSelectable = true;
            // 
            // rdAuthorName
            // 
            this.rdAuthorName.AutoSize = true;
            this.rdAuthorName.ForeColor = System.Drawing.Color.White;
            this.rdAuthorName.Location = new System.Drawing.Point(144, 53);
            this.rdAuthorName.Name = "rdAuthorName";
            this.rdAuthorName.Size = new System.Drawing.Size(95, 15);
            this.rdAuthorName.TabIndex = 3;
            this.rdAuthorName.Text = "Author Name";
            this.rdAuthorName.UseCustomBackColor = true;
            this.rdAuthorName.UseCustomForeColor = true;
            this.rdAuthorName.UseSelectable = true;
            // 
            // rdBookTitle
            // 
            this.rdBookTitle.AutoSize = true;
            this.rdBookTitle.Checked = true;
            this.rdBookTitle.ForeColor = System.Drawing.Color.White;
            this.rdBookTitle.Location = new System.Drawing.Point(48, 53);
            this.rdBookTitle.Name = "rdBookTitle";
            this.rdBookTitle.Size = new System.Drawing.Size(76, 15);
            this.rdBookTitle.TabIndex = 3;
            this.rdBookTitle.TabStop = true;
            this.rdBookTitle.Text = "Book Title";
            this.rdBookTitle.UseCustomBackColor = true;
            this.rdBookTitle.UseCustomForeColor = true;
            this.rdBookTitle.UseSelectable = true;
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
            this.linkBack.Location = new System.Drawing.Point(0, 17);
            this.linkBack.Name = "linkBack";
            this.linkBack.Size = new System.Drawing.Size(70, 37);
            this.linkBack.Style = MetroFramework.MetroColorStyle.Blue;
            this.linkBack.TabIndex = 9;
            this.linkBack.UseCustomBackColor = true;
            this.linkBack.UseCustomForeColor = true;
            this.linkBack.UseSelectable = true;
            this.linkBack.Click += new System.EventHandler(this.linkBack_Click);
            // 
            // metroPanel2
            // 
            this.metroPanel2.BackColor = System.Drawing.Color.Black;
            this.metroPanel2.Controls.Add(this.metroPanel5);
            this.metroPanel2.Controls.Add(this.pnBookDetails);
            this.metroPanel2.Controls.Add(this.metroPanel1);
            this.metroPanel2.Controls.Add(this.btRefresh);
            this.metroPanel2.Controls.Add(this.btCancel);
            this.metroPanel2.Controls.Add(this.btSave);
            this.metroPanel2.Controls.Add(this.btDelete);
            this.metroPanel2.Controls.Add(this.btUpdate);
            this.metroPanel2.Controls.Add(this.btInsert);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(105, 17);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(605, 524);
            this.metroPanel2.TabIndex = 10;
            this.metroPanel2.UseCustomBackColor = true;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroPanel5
            // 
            this.metroPanel5.BackColor = System.Drawing.Color.Red;
            this.metroPanel5.Controls.Add(this.metroLabel10);
            this.metroPanel5.HorizontalScrollbarBarColor = true;
            this.metroPanel5.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel5.HorizontalScrollbarSize = 10;
            this.metroPanel5.Location = new System.Drawing.Point(0, 5);
            this.metroPanel5.Name = "metroPanel5";
            this.metroPanel5.Size = new System.Drawing.Size(605, 32);
            this.metroPanel5.TabIndex = 13;
            this.metroPanel5.UseCustomBackColor = true;
            this.metroPanel5.VerticalScrollbarBarColor = true;
            this.metroPanel5.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel5.VerticalScrollbarSize = 10;
            // 
            // metroLabel10
            // 
            this.metroLabel10.BackColor = System.Drawing.Color.Red;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel10.ForeColor = System.Drawing.Color.White;
            this.metroLabel10.Location = new System.Drawing.Point(246, 2);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(113, 29);
            this.metroLabel10.TabIndex = 5;
            this.metroLabel10.Text = "BOOK DETAILS";
            this.metroLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel10.UseCustomBackColor = true;
            this.metroLabel10.UseCustomForeColor = true;
            // 
            // pnBookDetails
            // 
            this.pnBookDetails.Controls.Add(this.cbCategory);
            this.pnBookDetails.Controls.Add(this.cbPublisher);
            this.pnBookDetails.Controls.Add(this.cbAuthor);
            this.pnBookDetails.Controls.Add(this.btOpenFile);
            this.pnBookDetails.Controls.Add(this.metroLabel3);
            this.pnBookDetails.Controls.Add(this.txtQuantity);
            this.pnBookDetails.Controls.Add(this.txtPrice);
            this.pnBookDetails.Controls.Add(this.txtPages);
            this.pnBookDetails.Controls.Add(this.txtYearofPublished);
            this.pnBookDetails.Controls.Add(this.txtBookTitle);
            this.pnBookDetails.Controls.Add(this.txtBookID);
            this.pnBookDetails.Controls.Add(this.metroLabel5);
            this.pnBookDetails.Controls.Add(this.metroLabel6);
            this.pnBookDetails.Controls.Add(this.metroLabel8);
            this.pnBookDetails.Controls.Add(this.metroLabel4);
            this.pnBookDetails.Controls.Add(this.metroLabel9);
            this.pnBookDetails.Controls.Add(this.metroLabel2);
            this.pnBookDetails.Controls.Add(this.metroLabel7);
            this.pnBookDetails.Controls.Add(this.metroLabel1);
            this.pnBookDetails.Controls.Add(this.pbBook);
            this.pnBookDetails.HorizontalScrollbarBarColor = true;
            this.pnBookDetails.HorizontalScrollbarHighlightOnWheel = false;
            this.pnBookDetails.HorizontalScrollbarSize = 10;
            this.pnBookDetails.Location = new System.Drawing.Point(4, 47);
            this.pnBookDetails.Name = "pnBookDetails";
            this.pnBookDetails.Size = new System.Drawing.Size(596, 296);
            this.pnBookDetails.TabIndex = 12;
            this.pnBookDetails.VerticalScrollbarBarColor = true;
            this.pnBookDetails.VerticalScrollbarHighlightOnWheel = false;
            this.pnBookDetails.VerticalScrollbarSize = 10;
            // 
            // cbCategory
            // 
            this.cbCategory.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cbCategory.FontWeight = MetroFramework.MetroComboBoxWeight.Light;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.ItemHeight = 19;
            this.cbCategory.Location = new System.Drawing.Point(298, 134);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(275, 25);
            this.cbCategory.TabIndex = 32;
            this.cbCategory.UseSelectable = true;
            // 
            // cbPublisher
            // 
            this.cbPublisher.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cbPublisher.FontWeight = MetroFramework.MetroComboBoxWeight.Light;
            this.cbPublisher.FormattingEnabled = true;
            this.cbPublisher.ItemHeight = 19;
            this.cbPublisher.Location = new System.Drawing.Point(298, 104);
            this.cbPublisher.Name = "cbPublisher";
            this.cbPublisher.Size = new System.Drawing.Size(275, 25);
            this.cbPublisher.TabIndex = 31;
            this.cbPublisher.UseSelectable = true;
            // 
            // cbAuthor
            // 
            this.cbAuthor.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cbAuthor.FontWeight = MetroFramework.MetroComboBoxWeight.Light;
            this.cbAuthor.FormattingEnabled = true;
            this.cbAuthor.ItemHeight = 19;
            this.cbAuthor.Location = new System.Drawing.Point(298, 74);
            this.cbAuthor.Name = "cbAuthor";
            this.cbAuthor.Size = new System.Drawing.Size(275, 25);
            this.cbAuthor.TabIndex = 30;
            this.cbAuthor.UseSelectable = true;
            // 
            // btOpenFile
            // 
            this.btOpenFile.BackColor = System.Drawing.Color.Gainsboro;
            this.btOpenFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btOpenFile.BackgroundImage")));
            this.btOpenFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btOpenFile.Location = new System.Drawing.Point(22, 180);
            this.btOpenFile.Name = "btOpenFile";
            this.btOpenFile.Size = new System.Drawing.Size(147, 39);
            this.btOpenFile.TabIndex = 29;
            this.btOpenFile.UseSelectable = true;
            this.btOpenFile.Click += new System.EventHandler(this.btOpenFile_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(188, 139);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(70, 15);
            this.metroLabel3.TabIndex = 28;
            this.metroLabel3.Text = "Category(*)";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtQuantity
            // 
            // 
            // 
            // 
            this.txtQuantity.CustomButton.Image = null;
            this.txtQuantity.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.txtQuantity.CustomButton.Name = "";
            this.txtQuantity.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtQuantity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQuantity.CustomButton.TabIndex = 1;
            this.txtQuantity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQuantity.CustomButton.UseSelectable = true;
            this.txtQuantity.Lines = new string[0];
            this.txtQuantity.Location = new System.Drawing.Point(298, 225);
            this.txtQuantity.MaxLength = 4;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PasswordChar = '\0';
            this.txtQuantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.SelectionLength = 0;
            this.txtQuantity.SelectionStart = 0;
            this.txtQuantity.ShortcutsEnabled = true;
            this.txtQuantity.ShowButton = true;
            this.txtQuantity.ShowClearButton = true;
            this.txtQuantity.Size = new System.Drawing.Size(168, 25);
            this.txtQuantity.TabIndex = 26;
            this.txtQuantity.UseSelectable = true;
            this.txtQuantity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtQuantity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // txtPrice
            // 
            // 
            // 
            // 
            this.txtPrice.CustomButton.Image = null;
            this.txtPrice.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.txtPrice.CustomButton.Name = "";
            this.txtPrice.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrice.CustomButton.TabIndex = 1;
            this.txtPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrice.CustomButton.UseSelectable = true;
            this.txtPrice.Lines = new string[0];
            this.txtPrice.Location = new System.Drawing.Point(298, 256);
            this.txtPrice.MaxLength = 8;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrice.SelectedText = "";
            this.txtPrice.SelectionLength = 0;
            this.txtPrice.SelectionStart = 0;
            this.txtPrice.ShortcutsEnabled = true;
            this.txtPrice.ShowButton = true;
            this.txtPrice.ShowClearButton = true;
            this.txtPrice.Size = new System.Drawing.Size(168, 25);
            this.txtPrice.TabIndex = 26;
            this.txtPrice.UseSelectable = true;
            this.txtPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // txtPages
            // 
            // 
            // 
            // 
            this.txtPages.CustomButton.Image = null;
            this.txtPages.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.txtPages.CustomButton.Name = "";
            this.txtPages.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtPages.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPages.CustomButton.TabIndex = 1;
            this.txtPages.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPages.CustomButton.UseSelectable = true;
            this.txtPages.Lines = new string[0];
            this.txtPages.Location = new System.Drawing.Point(298, 194);
            this.txtPages.MaxLength = 6;
            this.txtPages.Name = "txtPages";
            this.txtPages.PasswordChar = '\0';
            this.txtPages.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPages.SelectedText = "";
            this.txtPages.SelectionLength = 0;
            this.txtPages.SelectionStart = 0;
            this.txtPages.ShortcutsEnabled = true;
            this.txtPages.ShowButton = true;
            this.txtPages.ShowClearButton = true;
            this.txtPages.Size = new System.Drawing.Size(168, 25);
            this.txtPages.TabIndex = 24;
            this.txtPages.UseSelectable = true;
            this.txtPages.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPages.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPages.TextChanged += new System.EventHandler(this.txtPages_TextChanged);
            this.txtPages.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPages_KeyPress);
            // 
            // txtYearofPublished
            // 
            // 
            // 
            // 
            this.txtYearofPublished.CustomButton.Image = null;
            this.txtYearofPublished.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.txtYearofPublished.CustomButton.Name = "";
            this.txtYearofPublished.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtYearofPublished.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtYearofPublished.CustomButton.TabIndex = 1;
            this.txtYearofPublished.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtYearofPublished.CustomButton.UseSelectable = true;
            this.txtYearofPublished.Lines = new string[0];
            this.txtYearofPublished.Location = new System.Drawing.Point(298, 164);
            this.txtYearofPublished.MaxLength = 4;
            this.txtYearofPublished.Name = "txtYearofPublished";
            this.txtYearofPublished.PasswordChar = '\0';
            this.txtYearofPublished.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtYearofPublished.SelectedText = "";
            this.txtYearofPublished.SelectionLength = 0;
            this.txtYearofPublished.SelectionStart = 0;
            this.txtYearofPublished.ShortcutsEnabled = true;
            this.txtYearofPublished.ShowButton = true;
            this.txtYearofPublished.ShowClearButton = true;
            this.txtYearofPublished.Size = new System.Drawing.Size(168, 25);
            this.txtYearofPublished.TabIndex = 27;
            this.txtYearofPublished.UseCustomForeColor = true;
            this.txtYearofPublished.UseSelectable = true;
            this.txtYearofPublished.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtYearofPublished.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtYearofPublished.TextChanged += new System.EventHandler(this.txtYearofPublished_TextChanged);
            this.txtYearofPublished.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYearofPublished_KeyPress);
            // 
            // txtBookTitle
            // 
            // 
            // 
            // 
            this.txtBookTitle.CustomButton.Image = null;
            this.txtBookTitle.CustomButton.Location = new System.Drawing.Point(251, 1);
            this.txtBookTitle.CustomButton.Name = "";
            this.txtBookTitle.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtBookTitle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBookTitle.CustomButton.TabIndex = 1;
            this.txtBookTitle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBookTitle.CustomButton.UseSelectable = true;
            this.txtBookTitle.Lines = new string[0];
            this.txtBookTitle.Location = new System.Drawing.Point(298, 44);
            this.txtBookTitle.MaxLength = 150;
            this.txtBookTitle.Name = "txtBookTitle";
            this.txtBookTitle.PasswordChar = '\0';
            this.txtBookTitle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBookTitle.SelectedText = "";
            this.txtBookTitle.SelectionLength = 0;
            this.txtBookTitle.SelectionStart = 0;
            this.txtBookTitle.ShortcutsEnabled = true;
            this.txtBookTitle.ShowButton = true;
            this.txtBookTitle.ShowClearButton = true;
            this.txtBookTitle.Size = new System.Drawing.Size(275, 25);
            this.txtBookTitle.TabIndex = 23;
            this.txtBookTitle.UseSelectable = true;
            this.txtBookTitle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBookTitle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtBookID
            // 
            // 
            // 
            // 
            this.txtBookID.CustomButton.Image = null;
            this.txtBookID.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.txtBookID.CustomButton.Name = "";
            this.txtBookID.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtBookID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBookID.CustomButton.TabIndex = 1;
            this.txtBookID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBookID.CustomButton.UseSelectable = true;
            this.txtBookID.Enabled = false;
            this.txtBookID.Lines = new string[0];
            this.txtBookID.Location = new System.Drawing.Point(298, 14);
            this.txtBookID.MaxLength = 32767;
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.PasswordChar = '\0';
            this.txtBookID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBookID.SelectedText = "";
            this.txtBookID.SelectionLength = 0;
            this.txtBookID.SelectionStart = 0;
            this.txtBookID.ShortcutsEnabled = true;
            this.txtBookID.ShowButton = true;
            this.txtBookID.ShowClearButton = true;
            this.txtBookID.Size = new System.Drawing.Size(168, 25);
            this.txtBookID.TabIndex = 22;
            this.txtBookID.UseSelectable = true;
            this.txtBookID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBookID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(188, 79);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(59, 15);
            this.metroLabel5.TabIndex = 20;
            this.metroLabel5.Text = "Author(*)";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(188, 169);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(100, 15);
            this.metroLabel6.TabIndex = 19;
            this.metroLabel6.Text = "Year Published(*)";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.Location = new System.Drawing.Point(188, 230);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(68, 15);
            this.metroLabel8.TabIndex = 17;
            this.metroLabel8.Text = "Quantity(*)";
            this.metroLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(188, 109);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(71, 15);
            this.metroLabel4.TabIndex = 18;
            this.metroLabel4.Text = "Publisher(*)";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel9.Location = new System.Drawing.Point(188, 258);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(48, 15);
            this.metroLabel9.TabIndex = 17;
            this.metroLabel9.Text = "Price(*)";
            this.metroLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(188, 49);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(77, 15);
            this.metroLabel2.TabIndex = 15;
            this.metroLabel2.Text = "Book Title(*)";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.Location = new System.Drawing.Point(188, 199);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(52, 15);
            this.metroLabel7.TabIndex = 14;
            this.metroLabel7.Text = "Pages(*)";
            this.metroLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(188, 19);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(58, 15);
            this.metroLabel1.TabIndex = 21;
            this.metroLabel1.Text = "Book No.";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbBook
            // 
            this.pbBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pbBook.BackColor = System.Drawing.Color.White;
            this.pbBook.Location = new System.Drawing.Point(22, 19);
            this.pbBook.Name = "pbBook";
            this.pbBook.Size = new System.Drawing.Size(147, 155);
            this.pbBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBook.TabIndex = 13;
            this.pbBook.TabStop = false;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.LemonChiffon;
            this.metroPanel1.Controls.Add(this.mtCategory);
            this.metroPanel1.Controls.Add(this.mtPublisher);
            this.metroPanel1.Controls.Add(this.mtAuthor);
            this.metroPanel1.Controls.Add(this.mtHome);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(3, 419);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(599, 92);
            this.metroPanel1.TabIndex = 11;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // mtCategory
            // 
            this.mtCategory.ActiveControl = null;
            this.mtCategory.Location = new System.Drawing.Point(410, 7);
            this.mtCategory.Name = "mtCategory";
            this.mtCategory.Size = new System.Drawing.Size(93, 79);
            this.mtCategory.Style = MetroFramework.MetroColorStyle.Purple;
            this.mtCategory.TabIndex = 2;
            this.mtCategory.Text = "&Category";
            this.mtCategory.TileImage = ((System.Drawing.Image)(resources.GetObject("mtCategory.TileImage")));
            this.mtCategory.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mtCategory.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtCategory.UseSelectable = true;
            this.mtCategory.UseTileImage = true;
            this.mtCategory.Click += new System.EventHandler(this.mtCategory_Click);
            // 
            // mtPublisher
            // 
            this.mtPublisher.ActiveControl = null;
            this.mtPublisher.Location = new System.Drawing.Point(310, 7);
            this.mtPublisher.Name = "mtPublisher";
            this.mtPublisher.Size = new System.Drawing.Size(93, 79);
            this.mtPublisher.Style = MetroFramework.MetroColorStyle.Silver;
            this.mtPublisher.TabIndex = 2;
            this.mtPublisher.Text = "&Publisher";
            this.mtPublisher.TileImage = ((System.Drawing.Image)(resources.GetObject("mtPublisher.TileImage")));
            this.mtPublisher.TileImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.mtPublisher.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtPublisher.UseSelectable = true;
            this.mtPublisher.UseTileImage = true;
            this.mtPublisher.Click += new System.EventHandler(this.mtPublisher_Click);
            // 
            // mtAuthor
            // 
            this.mtAuthor.ActiveControl = null;
            this.mtAuthor.Location = new System.Drawing.Point(212, 7);
            this.mtAuthor.Name = "mtAuthor";
            this.mtAuthor.Size = new System.Drawing.Size(93, 79);
            this.mtAuthor.Style = MetroFramework.MetroColorStyle.Lime;
            this.mtAuthor.TabIndex = 2;
            this.mtAuthor.Text = "&Author";
            this.mtAuthor.TileImage = ((System.Drawing.Image)(resources.GetObject("mtAuthor.TileImage")));
            this.mtAuthor.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mtAuthor.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtAuthor.UseSelectable = true;
            this.mtAuthor.UseTileImage = true;
            this.mtAuthor.Click += new System.EventHandler(this.mtAuthor_Click);
            // 
            // mtHome
            // 
            this.mtHome.ActiveControl = null;
            this.mtHome.Location = new System.Drawing.Point(113, 7);
            this.mtHome.Name = "mtHome";
            this.mtHome.Size = new System.Drawing.Size(93, 79);
            this.mtHome.Style = MetroFramework.MetroColorStyle.Red;
            this.mtHome.TabIndex = 2;
            this.mtHome.Text = "&Home";
            this.mtHome.TileImage = ((System.Drawing.Image)(resources.GetObject("mtHome.TileImage")));
            this.mtHome.TileImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.mtHome.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtHome.UseSelectable = true;
            this.mtHome.UseTileImage = true;
            this.mtHome.Click += new System.EventHandler(this.linkBack_Click);
            // 
            // btRefresh
            // 
            this.btRefresh.BackColor = System.Drawing.Color.Gainsboro;
            this.btRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btRefresh.BackgroundImage")));
            this.btRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btRefresh.Highlight = true;
            this.btRefresh.Location = new System.Drawing.Point(409, 360);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(73, 44);
            this.btRefresh.TabIndex = 10;
            this.btRefresh.UseSelectable = true;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.Gainsboro;
            this.btCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btCancel.BackgroundImage")));
            this.btCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btCancel.Highlight = true;
            this.btCancel.Location = new System.Drawing.Point(323, 360);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(73, 44);
            this.btCancel.TabIndex = 10;
            this.btCancel.UseSelectable = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.Color.Gainsboro;
            this.btSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btSave.BackgroundImage")));
            this.btSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btSave.Highlight = true;
            this.btSave.Location = new System.Drawing.Point(495, 360);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(73, 44);
            this.btSave.TabIndex = 10;
            this.btSave.UseSelectable = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.Gainsboro;
            this.btDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btDelete.BackgroundImage")));
            this.btDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btDelete.Highlight = true;
            this.btDelete.Location = new System.Drawing.Point(237, 360);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(73, 44);
            this.btDelete.TabIndex = 10;
            this.btDelete.UseSelectable = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.BackColor = System.Drawing.Color.Gainsboro;
            this.btUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btUpdate.BackgroundImage")));
            this.btUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btUpdate.Highlight = true;
            this.btUpdate.Location = new System.Drawing.Point(151, 360);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(73, 44);
            this.btUpdate.TabIndex = 10;
            this.btUpdate.UseSelectable = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btInsert
            // 
            this.btInsert.BackColor = System.Drawing.Color.Gainsboro;
            this.btInsert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btInsert.BackgroundImage")));
            this.btInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btInsert.Highlight = true;
            this.btInsert.Location = new System.Drawing.Point(65, 360);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(73, 44);
            this.btInsert.TabIndex = 10;
            this.btInsert.UseSelectable = true;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // frmBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlBook);
            this.Name = "frmBook";
            this.Size = new System.Drawing.Size(1294, 651);
            this.pnlBook.ResumeLayout(false);
            this.metroPanel4.ResumeLayout(false);
            this.pnControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.pnBookSearch.ResumeLayout(false);
            this.pnBookSearch.PerformLayout();
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel5.ResumeLayout(false);
            this.pnBookDetails.ResumeLayout(false);
            this.pnBookDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBook)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnlBook;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private MetroFramework.Controls.MetroPanel pnBookSearch;
        private MetroFramework.Controls.MetroRadioButton rdCategoryNo;
        private MetroFramework.Controls.MetroRadioButton rdCategoryName;
        private MetroFramework.Controls.MetroRadioButton rdPublisherNo;
        private MetroFramework.Controls.MetroRadioButton rdPublisherName;
        private MetroFramework.Controls.MetroRadioButton rdBookNo;
        private MetroFramework.Controls.MetroRadioButton rdAuthorNo;
        private MetroFramework.Controls.MetroRadioButton rdAuthorName;
        private MetroFramework.Controls.MetroRadioButton rdBookTitle;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroLink linkBack;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile mtCategory;
        private MetroFramework.Controls.MetroTile mtPublisher;
        private MetroFramework.Controls.MetroTile mtAuthor;
        private MetroFramework.Controls.MetroTile mtHome;
        private MetroFramework.Controls.MetroButton btSave;
        private MetroFramework.Controls.MetroButton btDelete;
        private MetroFramework.Controls.MetroButton btUpdate;
        private MetroFramework.Controls.MetroButton btInsert;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroButton btCancel;

        private MetroFramework.Controls.MetroGrid dgvBooks;
        //private System.Windows.Forms.DataGridViewTextBoxColumn bookIDDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn bookTitleDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn authorNameDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn publisherNameDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn yearPublishedDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn pagesDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn authorIDDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn publisherIDDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn categoryIDDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewImageColumn bookImageDataGridViewImageColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        //private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private MetroFramework.Controls.MetroPanel pnBookDetails;
        private MetroFramework.Controls.MetroComboBox cbCategory;
        private MetroFramework.Controls.MetroComboBox cbPublisher;
        private MetroFramework.Controls.MetroComboBox cbAuthor;
        private MetroFramework.Controls.MetroButton btOpenFile;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtPrice;
        private MetroFramework.Controls.MetroTextBox txtPages;
        private MetroFramework.Controls.MetroTextBox txtYearofPublished;
        private MetroFramework.Controls.MetroTextBox txtBookTitle;
        private MetroFramework.Controls.MetroTextBox txtBookID;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.PictureBox pbBook;
        private MetroFramework.Controls.MetroButton btRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn book_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn book_Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn author_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisher_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn category_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn year_Published;
        private System.Windows.Forms.DataGridViewTextBoxColumn pages;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn image;
        private MetroFramework.Controls.MetroTextBox txtQuantity;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroPanel metroPanel5;
        private MetroFramework.Controls.MetroTextBox txtPage;
        private MetroFramework.Controls.MetroLabel lbTotalRecord;
        private MetroFramework.Controls.MetroButton btNext;
        private MetroFramework.Controls.MetroButton btLast;
        private MetroFramework.Controls.MetroButton btPrevious;
        private MetroFramework.Controls.MetroButton btFirst;
        private MetroFramework.Controls.MetroPanel pnControl;
    }
}
