
using DTO;
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
    public partial class frmBillInfo : MetroFramework.Forms.MetroForm
    {
        public delegate void GetBillInfo(string orderID, string orderDate, string empName, string customerName);
        public delegate void GetOrderID(string orderID);
        public GetBillInfo Getter;
        public GetOrderID getter;
        public frmBillInfo()
        {
            InitializeComponent();
            Getter = new GetBillInfo(getBill);
            getter = new GetOrderID(getOrderID);
        }

        private void getOrderID(string orderID)
        {
            metroTextBox1.Text = orderID;
        }

        private void getBill(string orderID, string orderDate, string empName, string customerName)
        {
            metroTextBox1.Text = orderID;
        }

        private void frmBillInfo_Load(object sender, EventArgs e)
        {
            this.usp_GetBillForReportTableAdapter.Fill(this.bookstoreDBDataSet.usp_GetBillForReport, Convert.ToInt32(metroTextBox1.Text));
           
            this.reportViewer1.RefreshReport();
        }
    }
}
