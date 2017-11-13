namespace BMS.Class
{
    partial class frmBillInfo
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.uspGetBillForReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookstoreDBDataSet = new BMS.BookstoreDBDataSet();
            this.uspGetBillBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookstoreDBDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.usp_GetBillForReportTableAdapter = new BMS.BookstoreDBDataSetTableAdapters.usp_GetBillForReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.uspGetBillForReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookstoreDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspGetBillBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookstoreDBDataSet1BindingSource)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uspGetBillForReportBindingSource
            // 
            this.uspGetBillForReportBindingSource.DataMember = "usp_GetBillForReport";
            this.uspGetBillForReportBindingSource.DataSource = this.bookstoreDBDataSet;
            // 
            // bookstoreDBDataSet
            // 
            this.bookstoreDBDataSet.DataSetName = "BookstoreDBDataSet";
            this.bookstoreDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroTextBox1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(134, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(337, 42);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            this.metroPanel1.Visible = false;
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(139, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[] {
        "metroTextBox1"};
            this.metroTextBox1.Location = new System.Drawing.Point(137, 9);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(161, 23);
            this.metroTextBox1.TabIndex = 2;
            this.metroTextBox1.Text = "metroTextBox1";
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.LightGray;
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.uspGetBillForReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BMS.Class.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 28);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(767, 474);
            this.reportViewer1.TabIndex = 2;
            // 
            // usp_GetBillForReportTableAdapter
            // 
            this.usp_GetBillForReportTableAdapter.ClearBeforeFill = true;
            // 
            // frmBillInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 504);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.metroPanel1);
            this.DisplayHeader = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBillInfo";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.Text = "frmBillInfo";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmBillInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uspGetBillForReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookstoreDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspGetBillBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookstoreDBDataSet1BindingSource)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
  
        private System.Windows.Forms.BindingSource bookstoreDBDataSet1BindingSource;
        private System.Windows.Forms.BindingSource uspGetBillBindingSource;
        private System.Windows.Forms.BindingSource uspGetBillForReportBindingSource;
        private BookstoreDBDataSet bookstoreDBDataSet;
        private BookstoreDBDataSetTableAdapters.usp_GetBillForReportTableAdapter usp_GetBillForReportTableAdapter;
    }
}