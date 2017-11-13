using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BUS;
using MetroFramework;
using DTO;

namespace BMS.Class
{
    public partial class pnAuthentication : pnSlider
    {
        public event FireEventForLoginSuccess FireEventLoginSuccess = null;
        public event FireEvenForAccountAuthentication FireEvenAccountAuthentication = null;
        public pnAuthentication(Form owner) : base(owner)
        {
            InitializeComponent();
        }

        private void AccountAuthentication()
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text;
            if (Login(userName, password) == true)
            {
                if (EmployeesBUS.Instance.GetPermission(userName))
                {
                    Swipe(false);
                    if (FireEventLoginSuccess != null)
                    {
                        FireEventLoginSuccess(this, new LoginSuccessEventArgs { UserName = txtUserName.Text, Password = txtPassword.Text });
                    }
                    if(FireEvenAccountAuthentication != null)
                    {
                        FireEvenAccountAuthentication(this, new AccountPermissionArgs { AccessPermission = true });
                    }
                }
                else
                {
                    if(MetroMessageBox.Show(this, "Access denied. You are not authorized to access this module.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Hand) == DialogResult.OK)
                    {
                        Swipe(false);
                    }
                }
            }
            else
            {
                MetroMessageBox.Show(this, "Username or Password is incorrect. Please try again!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Clear();
                txtPassword.Clear();
                txtUserName.Focus();
            }
        }

        private bool Login(string userName, string password)
        {
            try
            {
                return EmployeesBUS.Instance.Login(userName, password);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            AccountAuthentication();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Swipe(false);
        }
    }
}
