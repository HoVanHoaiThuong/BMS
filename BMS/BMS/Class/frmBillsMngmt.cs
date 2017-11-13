using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using System.Data.SqlClient;
using MetroFramework;
using BUS;
using System.Globalization;
using Excel = Microsoft.Office.Interop.Excel;

namespace BMS.Class
{
    public partial class frmBillsMngmt : pnSlider
    {
        public event EventHandler SettingClosed;
        public frmBillsMngmt(Form owner) : base(owner)
        {
            InitializeComponent();
        }

        private void linkBack_Click(object sender, EventArgs e)
        {
            Swipe(false);

            EventHandler handler = SettingClosed;
            if (handler != null) handler(this, e);
        }

        private void GetBill()
        {
            DataTable dt = OrdersBUS.Instance.GetOrders();
            dgvBill.DataSource = dt;
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtStartDate.Value;
            DateTime endDate = dtEndDate.Value;
            try
            {
                if (endDate < startDate)
                {
                    MetroMessageBox.Show(this, "The start date cannot be greater than the end of date. Please check again!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
                else
                {
                    DataTable dt = OrdersBUS.Instance.GetBillByDate(startDate, endDate);
                    dgvBill.DataSource = dt;
                    CultureInfo culture = new CultureInfo("vi-VN");
                    int count = OrdersBUS.Instance.CountBill(startDate, endDate);
                    double revenue = OrdersBUS.Instance.Revenue(startDate, endDate);
                    lbTotalBill.Text = count.ToString();
                    lbRevenue.Text = revenue.ToString("c", culture);
                }
            }
            catch (SqlException ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btExport_Click(object sender, EventArgs e)
        {
            string startDate = dtStartDate.Value.ToString();
            string endDate = dtEndDate.Value.ToString();
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel Documents 2007 (*.xlsx)|*.xlsx";
                //sfd.FileName = "Sheet1";
                sfd.ShowDialog();
                if (!String.IsNullOrEmpty(sfd.FileName))
                {
                    Excel.Application app = new Excel.Application();
                    Excel.Workbook wb = app.Workbooks.Add(Type.Missing);
                    Excel._Worksheet sheet = null;
                    try
                    {
                        sheet = wb.ActiveSheet;
                        sheet.Name = "Bills payment";
                        //Header
                        sheet.Range[sheet.Cells[1, 1], sheet.Cells[1, dgvBill.Columns.Count-1]].Merge();
                        sheet.Cells[1, 1].Value = "Bills payment [ " + startDate + " - " + endDate + " ]";
                        sheet.Cells[1, 1].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                        sheet.Cells[1, 1].VerticalAlignment = Excel.Constants.xlCenter;
                        sheet.Cells[1, 1].Font.Size = 13;
                        sheet.Cells[1, 1].Font.Bold = true;
                        sheet.Cells[1, 1].Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White);
                        sheet.Cells[1, 1].Interior.Color = Excel.XlRgbColor.rgbRed;
                        sheet.Cells[1, 1].RowHeight = 30;
                        sheet.Cells[1, 1].Borders.Weight = Excel.XlBorderWeight.xlThin;
                        //Tieu de cot
                        for (int i = 1; i <= dgvBill.Columns.Count-1; i++)
                        {
                            sheet.Cells[2, i] = dgvBill.Columns[i].HeaderText;
                            sheet.Cells[2, i].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                            sheet.Cells[2, i].Font.Bold = true;
                            sheet.Cells[2, i].Borders.Weight = Excel.XlBorderWeight.xlThin;
                        }
                        //Lay du lieu
                        for (int i = 1; i <= dgvBill.Rows.Count; i++)
                        {
                            for (int j = 0; j < dgvBill.Columns.Count-1; j++)
                            {
                                sheet.Cells[i + 2, j+1] = dgvBill.Rows[i-1].Cells[j+1].Value.ToString();
                                sheet.Cells[i + 2, j+1].HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;
                                sheet.Cells[i + 2, j+1].Borders.Weight = Excel.XlBorderWeight.xlThin;
                            }
                        }
                        //Dinh dang do rong cho cac cot
                        for (int k = 1; k <= dgvBill.Rows.Count; k++)
                            ((Excel.Range)sheet.Cells[1, k + 1]).EntireColumn.AutoFit();

                        wb.SaveAs(sfd.FileName);
                        MetroMessageBox.Show(this, "Exported successfull!.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MetroMessageBox.Show(this, ex.Message, "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        app.Quit();
                        wb = null;
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "File name cannot be null!.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        private void dgvBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int col = e.ColumnIndex;
            if (dgvBill.Columns[e.ColumnIndex] is DataGridViewButtonColumn && dgvBill.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                int orderID = (int)dgvBill.SelectedCells[0].OwningRow.Cells["Column1"].Value;
                try
                {
                    OrdersBUS.Instance.Delete(orderID);
                    btSearch_Click(sender, e);
                }
                catch (SqlException ex)
                {
                    MetroMessageBox.Show(this, ex.Message, "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int orderID = (int)dgvBill.SelectedCells[0].OwningRow.Cells["Column1"].Value;
            try
            {
                OrdersBUS.Instance.Delete(orderID);
                btSearch_Click(sender, e);
            }
            catch (SqlException ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
