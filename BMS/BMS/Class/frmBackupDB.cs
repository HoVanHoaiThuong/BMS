using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Sdk;
using BUS;
using System.Data.SqlClient;
using DAO;

namespace BMS.Class
{
    public partial class frmBackupDB : pnSlider
    {
        public event EventHandler SettingClosed;
        public frmBackupDB(Form owner) : base(owner)
        {
            InitializeComponent();
            cbServerName.Items.Add(".");
            cbServerName.Items.Add("(local)");
            cbServerName.Items.Add(@".\SQLEXPRESS");
            cbServerName.Items.Add(string.Format(@"{0}\SQLEXPRESS", Environment.MachineName));
            cbServerName.Items.Add(string.Format(@"{0}\HENRYSQLSERVER", Environment.MachineName));
            cbServerName.SelectedIndex = 4;
        }

        private void linkBack_Click(object sender, EventArgs e)
        {
            Swipe(false);

            EventHandler handler = SettingClosed;
            if (handler != null) handler(this, e);
        }

        private void timerBackup_Tick(object sender, EventArgs e)
        {
            if (ProgrSpinnerBK.Value == 100)
            {
                timerBackup.Stop();
            }
        }

        private void btBackup_Click(object sender, EventArgs e)
        {
            ProgrBarProcess.Value = 0;
            try
            {
                string cnStr = "";
                string serverName = cbServerName.Text;
                string strPath = txtLocation.Text;
                if(!String.IsNullOrEmpty(txtDbName.Text) && !String.IsNullOrWhiteSpace(txtDbName.Text))
                {
                    string dbName = txtDbName.Text;
                    cnStr = @"Server = " + serverName + "; Initial Catalog = " + dbName;
                    if(!String.IsNullOrEmpty(txtUserName.Text) && !String.IsNullOrEmpty(txtPassword.Text))
                    {
                        string userName = txtUserName.Text;
                        string password = txtPassword.Text;
                        cnStr += "; User ID = " + userName + "; Password = " + password;
                        DataProvider dp = new DataProvider();
                        if (dp.Connect(cnStr))
                        {
                            Server dbServer = new Server(new ServerConnection(serverName, userName, password));
                            Backup dbBackup = new Backup() { Action = BackupActionType.Database, Database = dbName };
                            dbBackup.Devices.AddDevice(strPath + "\\" + dbName + "_" + DateTime.Now.ToString("dd-MM-yyyy--hh-mm-ss--tt") + ".bak", DeviceType.File);
                            dbBackup.Initialize = true;
                            dbBackup.PercentComplete += DbBackup_PercentComplete;
                            dbBackup.Complete += DbBackup_Complete;
                            dbBackup.SqlBackupAsync(dbServer);
                            btBackup.Enabled = false;
                        }
                        else
                        {
                            MetroMessageBox.Show(this, "Cannot connect to server. Please try again!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Username/Password is incorect. Please try again!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Database Name have not allow null.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                 
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Cannot connect to server. Please try again!" + Environment.NewLine + ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DbBackup_Complete(object sender, ServerMessageEventArgs e)
        {
           if(e.Error != null)
            {
                lbStatus.Invoke((MethodInvoker) delegate
                {
                    lbStatus.Text = e.Error.Message;
                });
            }
        }

        private void DbBackup_PercentComplete(object sender, PercentCompleteEventArgs e)
        {
           // ProgrBarProcess.Invoke((MethodInvoker)delegate
           //{
           //    ProgrBarProcess.Value = e.Percent;
           //    ProgrBarProcess.Update();
           //});
           // lbProcessPercent.Invoke((MethodInvoker)delegate
           //{
           //    lbProcessPercent.Text = $"{e.Percent}%";
           //});
        }

        private void txtLocation_ButtonClick(object sender, EventArgs e)
        {
            using (FolderBrowserDialog ofd = new FolderBrowserDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtLocation.Text = ofd.SelectedPath;
                    btBackup.Enabled = true;
                }
            }
        }
    }
}
