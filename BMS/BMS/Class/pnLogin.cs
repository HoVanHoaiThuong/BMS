using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework;
using MetroFramework.Forms;
using System.Data.SqlClient;
using DTO;
using BUS;
using DAO;
using System.Configuration;

namespace BMS.Class
{
    public partial class pnLogin : pnSlider
    {
        public event EventHandler SettingClosed;
        public event FireEventForLoginSuccess FireEventLoginSuccess = null;
        public pnLogin(Form owner) : base(owner)
        {
            InitializeComponent();
            for (int i = 3; i < 13; i++)
            {
                MetroTile _tile = new MetroTile();
                _tile.Size = new Size(45, 45);
                _tile.Tag = i;
                _tile.Style = (MetroColorStyle)i;
                _tile.Click += _tile_Click;
                flpSettings.Controls.Add(_tile);
            }
            cbServerName.Items.Add(".");
            cbServerName.Items.Add("(local)");
            cbServerName.Items.Add(@".\SQLEXPRESS");
            cbServerName.Items.Add(string.Format(@"{0}\SQLEXPRESS", Environment.MachineName));
            cbServerName.Items.Add(string.Format(@"{0}\HENRYSQLSERVER", Environment.MachineName));
            cbServerName.SelectedIndex = 4;
        }
        DataProvider dp = new DataProvider();

        private void _tile_Click(object sender, EventArgs e)
        {
            ((MetroForm)this.Parent).StyleManager.Style = (MetroColorStyle)((MetroTile)sender).Tag;
        }

        public void ShowSettings()
        {
            pnSettings.Visible = true;
            pnCenter.Enabled = false;
        }

        private void linkBack_Click(object sender, EventArgs e)
        {
            pnSettings.Visible = false;
            pnCenter.Enabled = true;
           
            EventHandler handler = SettingClosed;
            if (handler != null) handler(this, e);
        }

        private void rdDark_CheckedChanged(object sender, EventArgs e)
        {
            if(rdDark.Checked)
            {
                ((MetroForm)this.Parent).StyleManager.Theme = MetroThemeStyle.Dark;
            }
        }

        private void rdLight_CheckedChanged(object sender, EventArgs e)
        {
            if (rdLight.Checked)
            {
                ((MetroForm)this.Parent).StyleManager.Theme = MetroThemeStyle.Light;
            }
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text;
            if (Login(userName, password))
            {
                if(FireEventLoginSuccess != null)
                {
                    FireEventLoginSuccess(this, new LoginSuccessEventArgs { UserName = txtUserName.Text, Password = txtPassword.Text });
                }
                 Swipe(false);
            }
            else
            {
                MetroMessageBox.Show(this, "Username or Password is incorrect. Please try again!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Clear();
                txtPassword.Clear();
                txtUserName.Focus();
            }
        }

        public bool Login(string userName, string password)
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

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            string cnStr = "";
            string serverName = cbServerName.Text;
            string dbName = txtDbName.Text;
            try
            {
                if (dbName != "")
                {
                    cnStr = @"Server = " + serverName + "; Initial Catalog = " + dbName;
                    if (rdWindowsAuthentication.Checked == true)
                    {
                        cnStr += "; Integrated Security = true;";
                    }
                    else
                    {
                        string dbUserName = txtDbUserName.Text;
                        string dbPassword = txtDbPassword.Text;
                        if (dbUserName != "" && dbPassword != "")
                            cnStr += "; User ID = " + dbUserName + "; Password = " + dbPassword;
                    }
                    if (dp.Connect(cnStr))
                    {
                        MetroMessageBox.Show(this, "Test connection succeeded!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Cannot conect to server. Please try again!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Database Name not allow NULL!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                MetroMessageBox.Show(this, "Cannot connect to server. Please try again!" + Environment.NewLine + ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rdWindowsAuthentication_CheckedChanged(object sender, EventArgs e)
        {
            txtDbUserName.Enabled = false;
            txtDbPassword.Enabled = false;
        }

        private void rdSQLServerAuthentication_CheckedChanged(object sender, EventArgs e)
        {
            txtDbUserName.Enabled = true;
            txtDbPassword.Enabled = true;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            string cnStr = "";
            string serverName = cbServerName.Text;
            string dbName = txtDbName.Text;
            try
            {
                if (dbName != "")
                {
                    cnStr = @"Server = " + serverName + "; Initial Catalog = " + dbName;
                    if (rdWindowsAuthentication.Checked == true)
                    {
                        cnStr += "; Integrated Security = true;";
                    }
                    else
                    {
                        string dbUserName = txtDbUserName.Text;
                        string dbPassword = txtDbPassword.Text;
                        if (dbUserName != "" && dbPassword != "")
                            cnStr += "; User ID = " + dbUserName + "; Password = " + dbPassword;
                        else
                        {
                            MetroMessageBox.Show(this, "Username/Password is incorect. Please try again!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            return;
                        }
                    }
                    if (dp.Connect(cnStr))
                    {
                        SqlConnection cn = new SqlConnection(cnStr);
                        AppSetting setting = new AppSetting();
                        setting.SaveConnectionString("cnStr", cnStr);
                      
                        MetroMessageBox.Show(this, "Your connection string has been successfully saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Update failed. Please try again!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Database Name have not allow NULL.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                MetroMessageBox.Show(this, "Cannot connect to server. Please try again!" + Environment.NewLine + ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
