namespace BMS.Class
{
    partial class frmReportForBillMngmt
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
            this.rptBillMngmt = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bookstoreDBDataSet = new BMS.BookstoreDBDataSet();
            this.uspSearchBillBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usp_SearchBillTableAdapter = new BMS.BookstoreDBDataSetTableAdapters.usp_SearchBillTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bookstoreDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspSearchBillBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rptBillMngmt
            // 
            this.rptBillMngmt.BackColor = System.Drawing.Color.LightGray;
            this.rptBillMngmt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rptBillMngmt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.uspSearchBillBindingSource;
            this.rptBillMngmt.LocalReport.DataSources.Add(reportDataSource1);
            this.rptBillMngmt.LocalReport.ReportEmbeddedResource = "BMS.Class.RptBillMngmt.rdlc";
            this.rptBillMngmt.Location = new System.Drawing.Point(1, 26);
            this.rptBillMngmt.Name = "rptBillMngmt";
            this.rptBillMngmt.Size = new System.Drawing.Size(756, 537);
            this.rptBillMngmt.TabIndex = 0;
            // 
            // bookstoreDBDataSet
            // 
            this.bookstoreDBDataSet.DataSetName = "BookstoreDBDataSet";
            this.bookstoreDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uspSearchBillBindingSource
            // 
            this.uspSearchBillBindingSource.DataMember = "usp_SearchBill";
            this.uspSearchBillBindingSource.DataSource = this.bookstoreDBDataSet;
            // 
            // usp_SearchBillTableAdapter
            // 
            this.usp_SearchBillTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportForBillMngmt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 572);
            this.Controls.Add(this.rptBillMngmt);
            this.DisplayHeader = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReportForBillMngmt";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.Load += new System.EventHandler(this.frmReportForBillMngmt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookstoreDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspSearchBillBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptBillMngmt;
        private System.Windows.Forms.BindingSource uspSearchBillBindingSource;
        private BookstoreDBDataSet bookstoreDBDataSet;
        private BookstoreDBDataSetTableAdapters.usp_SearchBillTableAdapter usp_SearchBillTableAdapter;
    }
}