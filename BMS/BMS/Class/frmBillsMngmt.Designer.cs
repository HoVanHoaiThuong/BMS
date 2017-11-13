namespace BMS.Class
{
    partial class frmBillsMngmt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBillsMngmt));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.linkBack = new MetroFramework.Controls.MetroLink();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.dgvBill = new MetroFramework.Controls.MetroGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ContextMenuDelete = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbRevenue = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.lbTotalBill = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.btExport = new MetroFramework.Controls.MetroButton();
            this.btSearch = new MetroFramework.Controls.MetroButton();
            this.dtEndDate = new MetroFramework.Controls.MetroDateTime();
            this.dtStartDate = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.ContextMenuDelete.SuspendLayout();
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
            this.metroPanel1.Location = new System.Drawing.Point(0, 3);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1369, 600);
            this.metroPanel1.TabIndex = 2;
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
            this.metroPanel2.Controls.Add(this.dgvBill);
            this.metroPanel2.Controls.Add(this.lbRevenue);
            this.metroPanel2.Controls.Add(this.metroLabel3);
            this.metroPanel2.Controls.Add(this.lbTotalBill);
            this.metroPanel2.Controls.Add(this.metroLabel7);
            this.metroPanel2.Controls.Add(this.btExport);
            this.metroPanel2.Controls.Add(this.btSearch);
            this.metroPanel2.Controls.Add(this.dtEndDate);
            this.metroPanel2.Controls.Add(this.dtStartDate);
            this.metroPanel2.Controls.Add(this.metroLabel5);
            this.metroPanel2.Controls.Add(this.metroLabel4);
            this.metroPanel2.Controls.Add(this.metroLabel1);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(215, 10);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(939, 581);
            this.metroPanel2.TabIndex = 5;
            this.metroPanel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // dgvBill
            // 
            this.dgvBill.AllowUserToAddRows = false;
            this.dgvBill.AllowUserToDeleteRows = false;
            this.dgvBill.AllowUserToResizeColumns = false;
            this.dgvBill.AllowUserToResizeRows = false;
            this.dgvBill.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBill.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvBill.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("UTM Avo", 8.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBill.ColumnHeadersHeight = 40;
            this.dgvBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvBill.ContextMenuStrip = this.ContextMenuDelete;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("UTM Avo", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Aquamarine;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBill.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBill.EnableHeadersVisualStyles = false;
            this.dgvBill.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvBill.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvBill.Location = new System.Drawing.Point(255, 42);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBill.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBill.RowHeadersWidth = 5;
            this.dgvBill.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBill.Size = new System.Drawing.Size(681, 536);
            this.dgvBill.TabIndex = 30;
            this.dgvBill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBill_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "order_ID";
            this.Column1.HeaderText = "Order ID";
            this.Column1.Name = "Column1";
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "order_Date";
            this.Column2.HeaderText = "Date Created";
            this.Column2.Name = "Column2";
            this.Column2.Width = 130;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "user_Name";
            this.Column3.HeaderText = "Emp Account";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "customer_ID";
            this.Column4.HeaderText = "Customer ID";
            this.Column4.Name = "Column4";
            this.Column4.Width = 70;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "customer_Name";
            this.Column5.HeaderText = "Customer Name";
            this.Column5.Name = "Column5";
            this.Column5.Width = 110;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "total_Price";
            this.Column6.HeaderText = "Total Price";
            this.Column6.Name = "Column6";
            this.Column6.Width = 130;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Delete";
            this.Column7.Name = "Column7";
            this.Column7.Text = "Delete";
            this.Column7.ToolTipText = "Delete this record?";
            this.Column7.UseColumnTextForButtonValue = true;
            this.Column7.Width = 50;
            // 
            // ContextMenuDelete
            // 
            this.ContextMenuDelete.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.ContextMenuDelete.Name = "ContextMenuDelete";
            this.ContextMenuDelete.Size = new System.Drawing.Size(115, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.deleteToolStripMenuItem.Font = new System.Drawing.Font("UTM Avo", 9F);
            this.deleteToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // lbRevenue
            // 
            this.lbRevenue.BackColor = System.Drawing.Color.Transparent;
            this.lbRevenue.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbRevenue.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbRevenue.ForeColor = System.Drawing.Color.Gold;
            this.lbRevenue.Location = new System.Drawing.Point(4, 414);
            this.lbRevenue.Name = "lbRevenue";
            this.lbRevenue.Size = new System.Drawing.Size(247, 25);
            this.lbRevenue.TabIndex = 26;
            this.lbRevenue.Text = "0.00";
            this.lbRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbRevenue.UseCustomBackColor = true;
            this.lbRevenue.UseCustomForeColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.ForeColor = System.Drawing.Color.White;
            this.metroLabel3.Location = new System.Drawing.Point(2, 389);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(64, 19);
            this.metroLabel3.TabIndex = 27;
            this.metroLabel3.Text = "Revenue:";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // lbTotalBill
            // 
            this.lbTotalBill.AutoSize = true;
            this.lbTotalBill.BackColor = System.Drawing.Color.Transparent;
            this.lbTotalBill.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbTotalBill.ForeColor = System.Drawing.Color.White;
            this.lbTotalBill.Location = new System.Drawing.Point(110, 361);
            this.lbTotalBill.Name = "lbTotalBill";
            this.lbTotalBill.Size = new System.Drawing.Size(17, 19);
            this.lbTotalBill.TabIndex = 28;
            this.lbTotalBill.Text = "0";
            this.lbTotalBill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbTotalBill.UseCustomBackColor = true;
            this.lbTotalBill.UseCustomForeColor = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.ForeColor = System.Drawing.Color.White;
            this.metroLabel7.Location = new System.Drawing.Point(1, 361);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(62, 19);
            this.metroLabel7.TabIndex = 29;
            this.metroLabel7.Text = "Total bill:";
            this.metroLabel7.UseCustomBackColor = true;
            this.metroLabel7.UseCustomForeColor = true;
            // 
            // btExport
            // 
            this.btExport.BackColor = System.Drawing.Color.LawnGreen;
            this.btExport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btExport.BackgroundImage")));
            this.btExport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btExport.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btExport.Location = new System.Drawing.Point(4, 281);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(247, 48);
            this.btExport.TabIndex = 25;
            this.btExport.Text = "E&xport             ";
            this.btExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btExport.UseCustomBackColor = true;
            this.btExport.UseSelectable = true;
            this.btExport.Click += new System.EventHandler(this.btExport_Click);
            // 
            // btSearch
            // 
            this.btSearch.BackColor = System.Drawing.Color.Turquoise;
            this.btSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btSearch.BackgroundImage")));
            this.btSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btSearch.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btSearch.Location = new System.Drawing.Point(4, 227);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(247, 48);
            this.btSearch.TabIndex = 25;
            this.btSearch.Text = "&Search                ";
            this.btSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSearch.UseCustomBackColor = true;
            this.btSearch.UseSelectable = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // dtEndDate
            // 
            this.dtEndDate.CalendarFont = new System.Drawing.Font("UTM Avo", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtEndDate.CustomFormat = "dd/MM/yyyy 23:59:59";
            this.dtEndDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEndDate.Location = new System.Drawing.Point(4, 164);
            this.dtEndDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(247, 29);
            this.dtEndDate.TabIndex = 22;
            this.dtEndDate.Value = new System.DateTime(2017, 8, 23, 23, 59, 59, 0);
            // 
            // dtStartDate
            // 
            this.dtStartDate.CalendarFont = new System.Drawing.Font("UTM Avo", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtStartDate.CalendarTitleBackColor = System.Drawing.Color.Red;
            this.dtStartDate.CustomFormat = "dd/MM/yyyy 00:00:00";
            this.dtStartDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStartDate.Location = new System.Drawing.Point(4, 101);
            this.dtStartDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(247, 29);
            this.dtStartDate.TabIndex = 23;
            this.dtStartDate.Value = new System.DateTime(2017, 8, 1, 0, 0, 0, 0);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.ForeColor = System.Drawing.Color.White;
            this.metroLabel5.Location = new System.Drawing.Point(1, 142);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(65, 19);
            this.metroLabel5.TabIndex = 20;
            this.metroLabel5.Text = "End Date";
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.ForeColor = System.Drawing.Color.White;
            this.metroLabel4.Location = new System.Drawing.Point(2, 79);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(71, 19);
            this.metroLabel4.TabIndex = 21;
            this.metroLabel4.Text = "Start Date";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
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
            this.metroLabel1.Size = new System.Drawing.Size(939, 39);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "BILL MANAGEMENT";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // frmBillsMngmt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroPanel1);
            this.Name = "frmBillsMngmt";
            this.Size = new System.Drawing.Size(1366, 768);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.ContextMenuDelete.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLink linkBack;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime dtEndDate;
        private MetroFramework.Controls.MetroDateTime dtStartDate;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton btExport;
        private MetroFramework.Controls.MetroButton btSearch;
        private MetroFramework.Controls.MetroLabel lbRevenue;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel lbTotalBill;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroGrid dgvBill;
        private MetroFramework.Controls.MetroContextMenu ContextMenuDelete;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewButtonColumn Column7;
    }
}
