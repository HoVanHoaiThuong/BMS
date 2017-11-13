using BUS;
using DTO;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMS.Class
{
    public partial class pnSales : pnSlider
    {
        public event EventHandler SettingClosed;
        public delegate void SendAccount(string userName, string empName);
        public SendAccount Sender;
      
        public static string acc;
        BindingSource ListBook = new BindingSource();
        public static double totalPrice = 0;
        public pnSales(Form owner) : base(owner)
        {
            InitializeComponent();
            Sender = new SendAccount(GetAccount);
            dgvBooks.DataSource = ListBook;
            GetBooks();
            LoadBookBinding();
            LoadCustomerIntoCombobox(cbCustomerName);
            ShowBill();
        }

        private void GetAccount(string userName, string empName)
        {
            acc = userName;
            txtEmpName.Text = empName;
        }

        public void ShowSettings()
        {
            pnlSales.Visible = true;
        }

        private void linkBack_Click(object sender, EventArgs e)
        {
            Swipe(false);
            
            EventHandler handler = SettingClosed;
            if (handler != null) handler(this, e);
        }

        private void GetBooks()
        {
            try
            {
                ListBook.DataSource = BooksBUS.Instance.GetBooks();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        private void LoadBookBinding()
        {
            txtBookID.DataBindings.Add(new Binding("Text", dgvBooks.DataSource, "book_ID", true, DataSourceUpdateMode.Never));
            txtBookTitle.DataBindings.Add(new Binding("Text", dgvBooks.DataSource, "book_Title", true, DataSourceUpdateMode.Never));
            txtAuthor.DataBindings.Add(new Binding("Text", dgvBooks.DataSource, "author_Full_Name", true, DataSourceUpdateMode.Never));
            txtPublisher.DataBindings.Add(new Binding("Text", dgvBooks.DataSource, "publisher_Name", true, DataSourceUpdateMode.Never));
            txtCategory.DataBindings.Add(new Binding("Text", dgvBooks.DataSource, "category_Name", true, DataSourceUpdateMode.Never));
            txtYearofPublished.DataBindings.Add(new Binding("Text", dgvBooks.DataSource, "year_Published", true, DataSourceUpdateMode.Never));
            txtPages.DataBindings.Add(new Binding("Text", dgvBooks.DataSource, "pages", true, DataSourceUpdateMode.Never));
            txtStock.DataBindings.Add(new Binding("Text", dgvBooks.DataSource, "quantity", true, DataSourceUpdateMode.Never));
            txtPrice.DataBindings.Add(new Binding("Text", dgvBooks.DataSource, "unit_Price", true, DataSourceUpdateMode.Never));
            pbBook.DataBindings.Add(new Binding("Image", dgvBooks.DataSource, "book_Image", true, DataSourceUpdateMode.Never));

        }

        private void LoadCustomerIntoCombobox(MetroComboBox cb)
        {
            DataTable dt = CustomersBUS.Instance.GetCustomers();
            List<Customers> list = new List<Customers>();
            foreach (DataRow item in dt.Rows)
            {
                Customers customer = new Customers(item);
                list.Add(customer);
            }
            cb.DataSource = list;
            cb.DisplayMember = "CustomerName";
        }

        private void txtSearch_ButtonClick(object sender, EventArgs e)
        {
            if (rdBookTitle.Checked)
            {
                string bookTitle = txtSearch.Text;
                ListBook.DataSource = BooksBUS.Instance.SearchBookByBookTitle(bookTitle);
            }
            else if (rdBookNo.Checked)
            {
                int bookID = Convert.ToInt32(txtSearch.Text);
                ListBook.DataSource = BooksBUS.Instance.SearchBookByBookID(bookID);
            }
            else if (rdAuthorName.Checked)
            {
                string authorName = txtSearch.Text;
                ListBook.DataSource = BooksBUS.Instance.SearchBookByAuthorName(authorName);
            }
            else if (rdAuthorNo.Checked)
            {
                int authorID = Convert.ToInt32(txtSearch.Text);
                ListBook.DataSource = BooksBUS.Instance.SearchBookByAuthorID(authorID);
            }
            else if (rdPublisherName.Checked)
            {
                string publisherName = txtSearch.Text;
                ListBook.DataSource = BooksBUS.Instance.SearchBookByPublisherName(publisherName);
            }
            else if (rdPublisherNo.Checked)
            {
                int publisherID = Convert.ToInt32(txtSearch.Text);
                ListBook.DataSource = BooksBUS.Instance.SearchBookByPublisherID(publisherID);
            }
            else if (rdCategoryName.Checked)
            {
                string categoryName = txtSearch.Text;
                ListBook.DataSource = BooksBUS.Instance.SearchBookByCategoryName(categoryName);
            }
            else if (rdCategoryNo.Checked)
            {
                int categoryID = Convert.ToInt32(txtSearch.Text);
                ListBook.DataSource = BooksBUS.Instance.SearchBookByCategoryID(categoryID);
            }
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            GetBooks();
            txtSearch.Focus();
        }

        private void btAddIntoBasket_Click(object sender, EventArgs e)
        {
            try
            {
                string account = acc;
                int orderID = OrdersBUS.Instance.GetUncheckOrder();
                int bookID = int.Parse(txtBookID.Text);
                int inStock = int.Parse(txtStock.Text);
                int quantity = (int)numericQuantity.Value;
                int customerID = (cbCustomerName.SelectedItem as Customers).CustomerID;

                if (quantity < inStock)
                {
                    if (orderID == -1)
                    {
                        if (quantity >= 1)
                        {
                            OrdersBUS.Instance.InsertOrder(account, customerID);

                            OrderDetailsBUS.Instance.InsertOrderDetails(OrdersBUS.Instance.GetMaxOrderID(), bookID, quantity);
                          
                        }
                        else
                        {
                            MetroMessageBox.Show(this, "The quantity of product is invalid. Please try again!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                    }
                    else if(orderID != -1)
                    {
                        dtOrderDate.Value = OrdersBUS.Instance.GetOrderDateByID(orderID);
                        if (!OrderDetailsBUS.Instance.CheckBookExists(bookID, orderID))
                        {
                            if (quantity >= 1)
                            {
                                OrderDetailsBUS.Instance.InsertOrderDetails(orderID, bookID, quantity);
                            }
                            else
                            {
                                MetroMessageBox.Show(this, "The quantity of product is invalid. Please try again!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            OrderDetailsBUS.Instance.InsertOrderDetails(orderID, bookID, quantity);
                        }
                    }
                    ShowBill();
                }
                else
                {
                    MetroMessageBox.Show(this, "Sorry! The quantity of products in stock does not meet the demand.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    numericQuantity.Value = 1;
                    return;
                }
            }
            catch(SqlException ex)
            {
                throw ex;
            }

        }

        private void ShowBill()
        {  
            try
            {
                lvBillDetails.Items.Clear();
                int orderID = OrdersBUS.Instance.GetUncheckOrder();
                txtOrderID.Text = "";
                numericQuantity.Value = 1;
                double totalBill = 0;
                if (orderID != -1)
                {
                    txtOrderID.Text = orderID.ToString();
                    List<Bills> listBill =  BillsBUS.Instance.GetBill(orderID);

                    foreach (Bills item in listBill)
                    {
                        ListViewItem lvItem = new ListViewItem(item.BookID.ToString());
                        lvItem.SubItems.Add(item.BookTitle.ToString());
                        lvItem.SubItems.Add(item.Quantity.ToString());
                        lvItem.SubItems.Add(item.UnitPrice.ToString());
                        lvItem.SubItems.Add(item.Discount.ToString());
                        lvItem.SubItems.Add(item.TotalPrice.ToString());
                        totalBill += item.TotalPrice;

                        lvBillDetails.Items.Add(lvItem);
                    }
                }
                totalPrice = totalBill;
                CultureInfo culture = new CultureInfo("vi-VN");
                lbTotalPrice.Text = totalBill.ToString("c", culture);
                }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        private void btAddCustomer_Click(object sender, EventArgs e)
        {
            frmAddCustomer f = new frmAddCustomer();
            f.ShowDialog();
            LoadCustomerIntoCombobox(cbCustomerName);
        }

        private void btPay_Click(object sender, EventArgs e)
        {
            int orderID = OrdersBUS.Instance.GetUncheckOrder();
            if (orderID != -1)
            {
                if (MetroMessageBox.Show(this, "Do you want to pay this bill?", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    OrdersBUS.Instance.CheckOut(orderID, (float)totalPrice);
                    MetroMessageBox.Show(this, "Paid successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Open report
                   
                    frmBillInfo f = new frmBillInfo();
                    f.Getter(txtOrderID.Text, dtOrderDate.Text, txtEmpName.Text, cbCustomerName.Text);
                    f.ShowDialog();
                   
                    ShowBill();
                }
            }
        }




    }
}
