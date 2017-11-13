using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BMS.Class
{
    public partial class frmReportForBillMngmt : MetroFramework.Forms.MetroForm
    {
        public delegate void GetBills(DateTime fromDate, DateTime toDate);
        public GetBills Getter;
        public frmReportForBillMngmt()
        {
            InitializeComponent();
            Getter = new GetBills(getBills);
        }
        static DateTime from;
        static DateTime to;
        private void getBills(DateTime fromDate, DateTime toDate)
        {
            from = fromDate;
            to = toDate;
        }

        private void frmReportForBillMngmt_Load(object sender, EventArgs e)
        {
            this.usp_SearchBillTableAdapter.Fill(this.bookstoreDBDataSet.usp_SearchBill, from, to);

            this.rptBillMngmt.RefreshReport();
        }
    }
}
