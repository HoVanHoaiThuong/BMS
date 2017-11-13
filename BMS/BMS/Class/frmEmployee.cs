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
using System.IO;
using System.Data.SqlClient;
using MetroFramework;

namespace BMS.Class
{
    public partial class frmEmployee : pnSlider
    {
        public event EventHandler SettingClosed;
        public frmEmployee(Form owner):base(owner)
        {
            InitializeComponent();
            dgvEmployees.DataSource = ListEmp;
            Employee_Load();
        }
        private void linkBack_Click(object sender, EventArgs e)
        {
            Swipe(false);

            EventHandler handler = SettingClosed;
            if (handler != null) handler(this, e);
        }

        EntityState objState = EntityState.Unchanged;
        BindingSource ListEmp = new BindingSource();
        String strFilePath = "";
        Byte[] ImageByteArray = null;
        private void Employee_Load()
        {
            GetAccounts();
            LoadEmpBinding();
            pnEmployeeInfo.Enabled = false;
            btCancel.Enabled = false;
            btRefresh.Enabled = false;
            btSave.Enabled = false;
        }

        private void GetAccounts()
        {
            try
            {
                DataTable dt = EmployeesBUS.Instance.GetAccounts();
                ListEmp.DataSource = dt;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        private void LoadEmpBinding()
        {
            txtUserName.DataBindings.Add(new Binding("Text", dgvEmployees.DataSource, "user_Name", true, DataSourceUpdateMode.Never));
            txtPassword.DataBindings.Add(new Binding("Text", dgvEmployees.DataSource, "user_Password", true, DataSourceUpdateMode.Never));
            chkType.DataBindings.Add(new Binding("Checked", dgvEmployees.DataSource, "user_Type", true, DataSourceUpdateMode.Never));
            dtDOB.DataBindings.Add(new Binding("Value", dgvEmployees.DataSource, "employee_DOB", true, DataSourceUpdateMode.Never));
            chkGender.DataBindings.Add(new Binding("Checked", dgvEmployees.DataSource, "employee_Gender", true, DataSourceUpdateMode.Never));
            txtLastName.DataBindings.Add(new Binding("Text", dgvEmployees.DataSource, "employee_Last_Name", true, DataSourceUpdateMode.Never));
            txtFirstName.DataBindings.Add(new Binding("Text", dgvEmployees.DataSource, "employee_First_Name", true, DataSourceUpdateMode.Never));
            txtIDNo.DataBindings.Add(new Binding("Text", dgvEmployees.DataSource, "employee_Identification_Number", true, DataSourceUpdateMode.Never));
            txtAddress.DataBindings.Add(new Binding("Text", dgvEmployees.DataSource, "employee_Address", true, DataSourceUpdateMode.Never));
            txtPhone.DataBindings.Add(new Binding("Text", dgvEmployees.DataSource, "employee_Phone", true, DataSourceUpdateMode.Never)); 
            pbEmployee.DataBindings.Add(new Binding("Image", dgvEmployees.DataSource, "employee_Image", true, DataSourceUpdateMode.Never));
        }

        private void chkGender_CheckStateChanged(object sender, EventArgs e)
        {
            if(chkGender.CheckState == CheckState.Checked)
            {
                chkGender.Text = "Male";
            }
            else if(chkGender.CheckState == CheckState.Unchecked)
            {
                chkGender.Text = "Female";
            }
        }

        private void chkType_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkType.CheckState == CheckState.Checked)
            {
                chkType.Text = "Admin";
            }
            else if (chkType.CheckState == CheckState.Unchecked)
            {
                chkType.Text = "User";
            }
        }

        private void btOpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Images|  *.JPG; *.PNG; *.GJF", ValidateNames = true })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        strFilePath = ofd.FileName;
                        pbEmployee.Image = new Bitmap(strFilePath);
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
            pnEmployeeInfo.Enabled = true;
            btCancel.Enabled = true;
            btSave.Enabled = true;
            btUpdate.Enabled = false;
            btDelete.Enabled = false;
            btRefresh.Enabled = false;
            pbEmployee.Image = null;
            ClearInput();
            txtUserName.Focus();
        }

        private void ClearInput()
        {
            txtUserName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            chkGender.CheckState = CheckState.Unchecked;
            txtIDNo.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtPhone.Text = string.Empty;
            chkType.CheckState = CheckState.Unchecked;
            txtSearch.Focus();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            objState = EntityState.Changed;
            pnEmployeeInfo.Enabled = true;
            btSave.Enabled = true;
            btCancel.Enabled = true;
            btInsert.Enabled = false;
            btDelete.Enabled = false;
            btRefresh.Enabled = false;
            txtUserName.Enabled = false;
            txtLastName.Focus();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            objState = EntityState.Deleted;
            if (MetroMessageBox.Show(this, "Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    bool result = EmployeesBUS.Instance.RemoveEmployee(txtUserName.Text);
                    if (result != false)
                    {
                        pnEmployeeInfo.Enabled = false;
                        btCancel.Enabled = false;
                        btSave.Enabled = false;
                        txtSearch.Focus();
                        GetAccounts();
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
            pnEmployeeInfo.Enabled = false;
            btInsert.Enabled = true;
            btUpdate.Enabled = true;
            btDelete.Enabled = true;
            btRefresh.Enabled = false;
            btSave.Enabled = false;
            ListEmp.ResetCurrentItem();
            txtSearch.Focus();
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            GetAccounts();
            btRefresh.Enabled = true;
        }
        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = txtUserName.Text;
                string password = txtPassword.Text;
                string lastName = txtLastName.Text;
                string firstName = txtFirstName.Text;
                DateTime? dob = dtDOB.Value;
                bool? gender = (chkGender.Checked) ? true : false;
                int identificationNo = Convert.ToInt32(txtIDNo.Text);
                string address = txtAddress.Text;
                string phone = txtPhone.Text;
                byte[] img = ImageByteArray;
                bool? type = (chkType.Checked) ? true : false;

                if (objState == EntityState.Added)
                {
                    if (img != null)
                    {
                        if (EmployeesBUS.Instance.InsertEmployee(userName, password, firstName, lastName, dob, gender, identificationNo, address, phone, img, type))
                        {
                            GetAccounts();
                            ListEmp.MoveLast();
                            pnEmployeeInfo.Enabled = false;
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
                        pnEmployeeInfo.Enabled = false;
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
                    if (img == null)
                    {
                        img = (byte[])dgvEmployees.CurrentRow.Cells[9].Value;
                    }
                    if (EmployeesBUS.Instance.UpdateEmployee(userName, password, firstName, lastName, dob, gender, identificationNo, address, phone, img, type))
                    {
                        GetAccounts();
                        txtUserName.Enabled = true;
                        pnEmployeeInfo.Enabled = false;
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
