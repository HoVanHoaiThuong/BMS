using BUS;
using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMS.Class
{
    public partial class frmAccountSetting : MetroFramework.Forms.MetroForm
    {
        public delegate void GetAccount(string userName, string password);
        public GetAccount Getter;
        public frmAccountSetting()
        {
            InitializeComponent();
            Getter = new GetAccount(getAccount);
        }

        private void getAccount(string userName, string password)
        {
            txtUserName.Text = userName;
            txtPassword.Text = password;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string oldPassword = txtPassword.Text;
            string verify = txtVeirfyPassword.Text;
            string newPassword = txtNewPassword.Text;
            string confirmNewPassword = txtConfirmNewPassword.Text;
            if (!oldPassword.Equals(verify))
            {
                MetroMessageBox.Show(this, "Password and Verify password do not match. Please try again!", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtVeirfyPassword.Clear();
            }
            else
            {
                if (string.IsNullOrEmpty(newPassword) || string.IsNullOrWhiteSpace(newPassword))
                {
                    MetroMessageBox.Show(this, "You have not entered a new password yet.", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    if (!newPassword.Equals(confirmNewPassword))
                    {
                        MetroMessageBox.Show(this, "New password and Confirm new password do not match. Please try again!", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        txtNewPassword.Clear();
                        txtConfirmNewPassword.Clear();
                    }
                    else
                    {
                        try
                        {
                            if (EmployeesBUS.Instance.UpdatePassword(userName, newPassword) != 0)
                            {
                                MetroMessageBox.Show(this, "Updated successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MetroMessageBox.Show(this, "Update failed.", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (SqlException ex)
                        {
                            MetroMessageBox.Show(this, ex.Message, "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
















    }
}
