using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using System.Data.SqlClient;
using System.IO;
using MetroFramework;

namespace BMS.Class
{
    public partial class frmCustomer : pnSlider
    {
        public event EventHandler SettingClosed;
        public frmCustomer(Form owner):base(owner)
        {
            InitializeComponent();
            dgvCustomers.DataSource = ListCustomer;
            Customer_Load();
        }

        EntityState objState = EntityState.Unchanged;
        BindingSource ListCustomer = new BindingSource();
        String strFilePath = "";
        Byte[] ImageByteArray = null;

        private void Customer_Load()
        {
            GetCustomers();
            LoadCustomersBinding();
            pnCustomerInfo.Enabled = false;
            btCancel.Enabled = false;
            btRefresh.Enabled = false;
            btSave.Enabled = false;
        }

        private void LoadCustomersBinding()
        {
            txtCustomerID.DataBindings.Add(new Binding("Text", dgvCustomers.DataSource, "customer_ID", true, DataSourceUpdateMode.Never));
            txtFullName.DataBindings.Add(new Binding("Text", dgvCustomers.DataSource, "customer_Name", true, DataSourceUpdateMode.Never));   
            dtDOB.DataBindings.Add(new Binding("Value", dgvCustomers.DataSource, "customer_DOB", true, DataSourceUpdateMode.Never));
            chkGender.DataBindings.Add(new Binding("Checked", dgvCustomers.DataSource, "customer_Gender", true, DataSourceUpdateMode.Never));
            txtAddress.DataBindings.Add(new Binding("Text", dgvCustomers.DataSource, "customer_Address", true, DataSourceUpdateMode.Never));
            txtPhone.DataBindings.Add(new Binding("Text", dgvCustomers.DataSource, "customer_Phone", true, DataSourceUpdateMode.Never));
            txtPoints.DataBindings.Add(new Binding("Text", dgvCustomers.DataSource, "accumulation_Points", true, DataSourceUpdateMode.Never));
            pbCustomer.DataBindings.Add(new Binding("Image", dgvCustomers.DataSource, "customer_Image", true, DataSourceUpdateMode.Never));
        }

        private void linkBack_Click(object sender, EventArgs e)
        {
            Swipe(false);

            EventHandler handler = SettingClosed;
            if (handler != null) handler(this, e);
        }
        private void GetCustomers()
        {
            try
            {
                DataTable dt = CustomersBUS.Instance.GetCustomers();
                ListCustomer.DataSource = dt;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        private void chkGender_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkGender.CheckState == CheckState.Checked)
            {
                chkGender.Text = "Male";
            }
            else if (chkGender.CheckState == CheckState.Unchecked)
            {
                chkGender.Text = "Female";
            }
        }

        private void btOpenFile_Click(object sender, EventArgs e)
        {
            btSave.Enabled = true;
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Images|  *.JPG; *.PNG; *.GJF", ValidateNames = true })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        strFilePath = ofd.FileName;
                        pbCustomer.Image = new Bitmap(strFilePath);
                        if (strFilePath == "")
                        {

                            if (ImageByteArray.Length != 0)
                                ImageByteArray = new byte[] { };
                        }
                        else
                        {
                            Image temp = new Bitmap(strFilePath);
                            MemoryStream strm = new MemoryStream();
                            temp.Save(strm, System.Drawing.Imaging.ImageFormat.Jpeg);
                            ImageByteArray = strm.ToArray();
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            objState = EntityState.Added;
            pnCustomerInfo.Enabled = true;
            btCancel.Enabled = true;
            btSave.Enabled = false;
            btUpdate.Enabled = false;
            btDelete.Enabled = false;
            btRefresh.Enabled = false;
            pbCustomer.Image = null;
            ClearInput();
            txtFullName.Focus();
        }

        private void ClearInput()
        {
            txtFullName.Text = string.Empty;
            chkGender.CheckState = CheckState.Unchecked;       
            txtAddress.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtPoints.Text = "0";
            txtSearch.Focus();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            objState = EntityState.Changed;
            pnCustomerInfo.Enabled = true;
            btSave.Enabled = true;
            btCancel.Enabled = true;
            btInsert.Enabled = false;
            btDelete.Enabled = false;
            btRefresh.Enabled = false;
            txtFullName.Focus();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            objState = EntityState.Deleted;
            if (MetroMessageBox.Show(this, "Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    bool result = CustomersBUS.Instance.RemoveCustomer(Convert.ToInt32(txtCustomerID.Text));
                    if (result != false)
                    {
                        pnCustomerInfo.Enabled = false;
                        btCancel.Enabled = false;
                        btSave.Enabled = false;
                        txtSearch.Focus();
                        GetCustomers();
                        objState = EntityState.Unchanged;
                    }
                }
                catch (SqlException ex)
                {
                    MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            pnCustomerInfo.Enabled = false;
            btInsert.Enabled = true;
            btUpdate.Enabled = true;
            btDelete.Enabled = true;
            btRefresh.Enabled = false;
            btSave.Enabled = false;
            btCancel.Enabled = false;
            ListCustomer.ResetCurrentItem();
            txtSearch.Focus();
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            GetCustomers();
            btRefresh.Enabled = true;
        }
        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                string fullName = txtFullName.Text;
                DateTime? dob = dtDOB.Value;
                bool? gender = (chkGender.Checked) ? true : false;
                string address = txtAddress.Text;
                string phone = txtPhone.Text;
                byte[] img = ImageByteArray;
                int points = Convert.ToInt32(txtPoints.Text);

                if (objState == EntityState.Added)
                {
                    if (img != null)
                    {
                        if (CustomersBUS.Instance.InsertCustomer(fullName, dob, gender,address, phone, img, points))
                        {
                            GetCustomers();
                            ListCustomer.MoveLast();
                            pnCustomerInfo.Enabled = false;
                            btSave.Enabled = false;
                            btCancel.Enabled = false;
                            btInsert.Enabled = true;
                            btUpdate.Enabled = true;
                            btDelete.Enabled = true;
                            txtSearch.Focus();
                            MetroMessageBox.Show(this, "Added", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        pnCustomerInfo.Enabled = false;
                        btSave.Enabled = false;
                        btCancel.Enabled = false;
                        btInsert.Enabled = true;
                        btUpdate.Enabled = true;
                        btDelete.Enabled = true;
                        txtSearch.Focus();
                        MetroMessageBox.Show(this, "Cannot insert because Image is NULL.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (objState == EntityState.Changed)
                {
                    int customerID = Convert.ToInt32(txtCustomerID.Text);
                    if (img == null)
                    {
                        img = (byte[])dgvCustomers.CurrentRow.Cells[6].Value;
                    }
                    if (CustomersBUS.Instance.UpdateCustomer(customerID, fullName, dob, gender, address, phone, img, points))
                    {
                        GetCustomers();
                        pnCustomerInfo.Enabled = false;
                        btSave.Enabled = false;
                        btCancel.Enabled = false;
                        btInsert.Enabled = true;
                        btDelete.Enabled = true;
                        MetroMessageBox.Show(this, "Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Update fail", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                objState = EntityState.Unchanged;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }



















    }
}
