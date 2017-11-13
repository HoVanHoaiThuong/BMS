using BMS.Class;
using BUS;
using DTO;
using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMS
{
    public partial class frmBMS : MetroFramework.Forms.MetroForm
    {
        pnLogin _login = null;

        public static bool authenResult = false;
        public frmBMS()
        {
            Thread t = new Thread(new ThreadStart(Splash));
            t.Start();
            InitializeComponent();
            Thread.Sleep(500);
            t.Abort();
           
            Initial();
        }

        private void Initial()
        {
            linkClose.Visible = false;
            this.StyleManager = msmBMS;
            this.Shown += BMS_Shown;
            _login = new pnLogin(this);
            _login.SettingClosed += _login_SettingClosed;
            _login.FireEventLoginSuccess += _login_FireEventLoginSuccess;
            _login.Swipe();
        }

        private void _login_FireEventLoginSuccess(object sender, LoginSuccessEventArgs e)
        {
            linkSetting.Visible = false;
            linkClose.Visible = true;
            linkAccSettings.Visible = true;
            lbUserName.Text = e.UserName.ToUpper();
            lbPassword.Text = e.Password;
            DataTable dt = new DataTable();
            dt =  EmployeesBUS.Instance.GetEmpNameByUserName(e.UserName);
            lbEmployeeName.Text =  dt.Rows[0]["FullName"].ToString().ToUpper();
            picEmp.Invalidate();
            picEmp.DataBindings.Add(new Binding("Image", dt, "employee_Image", true, DataSourceUpdateMode.Never));
        }

        private void _login_SettingClosed(object sender, EventArgs e)
        {
            linkSetting.Visible = true;
            linkClose.Visible = false;
        }

        private void BMS_Shown(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void Splash()
        {
            frmSplashScreen frm = new frmSplashScreen();
            Application.Run(frm);
        }

        private void BMS_Load(object sender, EventArgs e)
        {
           

        }

        private void linkSetting_Click(object sender, EventArgs e)
        {
            _login.ShowSettings();        
        }

        private void linkClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timerDigitalClock_Tick(object sender, EventArgs e)
        {
            try
            {
                lbSec.Text = DateTime.Now.ToString("ss");
                lbHour.Text = DateTime.Now.ToString("hh:mm");
                lbDay.Text = DateTime.Now.ToString("dddd");
                lbDayMonthYear.Text = DateTime.Now.ToString("dd/MM/yyyy");
                lbAMPM.Text = DateTime.Now.ToString("tt");
                circularDigitalClock.Value = Convert.ToInt32(lbSec.Text);
            }
            catch (Exception)
            {
                return;
            }
        }

        private void mtSales_Click(object sender, EventArgs e)
        {
            pnSales _pnSales =  new pnSales(this);
            _pnSales.Sender(lbUserName.Text, lbEmployeeName.Text);

            mtSales.Enabled = false;
            mtBook.Enabled = false;
            _pnSales.Swipe();
            mtSales.Enabled = true;
            mtBook.Enabled = true;
        }

        private void mtBook_Click(object sender, EventArgs e)
        {
            pnAuthentication _pnAuthen = new pnAuthentication(this);
            _pnAuthen.FireEvenAccountAuthentication += _mtBook_FireEvenAccountAuthentication;
            _pnAuthen.Swipe();
        }

        private void _mtBook_FireEvenAccountAuthentication(object sender, AccountPermissionArgs e)
        {
            authenResult = e.AccessPermission;
            if (authenResult == true)
            {
                frmBook _pnBook = new frmBook(this);
                mtSales.Enabled = false;
                mtBook.Enabled = false;
                mtEmployee.Enabled = false;
                _pnBook.Swipe();
                mtSales.Enabled = true;
                mtBook.Enabled = true;
                mtEmployee.Enabled = true;
            }
        }

        private void mtEmployee_Click(object sender, EventArgs e)
        {
            pnAuthentication _pnAuthen = new pnAuthentication(this);
            _pnAuthen.FireEvenAccountAuthentication += _mtEmployee_FireEvenAccountAuthentication;
            _pnAuthen.Swipe();
        }

        private void _mtEmployee_FireEvenAccountAuthentication(object sender, AccountPermissionArgs e)
        {
            frmEmployee _pnEmployee = new frmEmployee(this);
            mtEmployee.Enabled = false;
            mtSales.Enabled = false;
            mtBook.Enabled = false;
            _pnEmployee.Swipe();
            mtSales.Enabled = true;
            mtBook.Enabled = true;
            mtEmployee.Enabled = true;
        }

        private void mtCustomer_Click(object sender, EventArgs e)
        {
            pnAuthentication _pnAuthen = new pnAuthentication(this);
            _pnAuthen.FireEvenAccountAuthentication += _mtCustomer_FireEvenAccountAuthentication;
            _pnAuthen.Swipe();
        }

        private void _mtCustomer_FireEvenAccountAuthentication(object sender, AccountPermissionArgs e)
        {
            frmCustomer _pnCustomer = new frmCustomer(this);
            mtCustomer.Enabled = false;
            mtEmployee.Enabled = false;
            mtSales.Enabled = false;
            mtBook.Enabled = false;
            mtBackup.Enabled = false;
            mtBillsPayment.Enabled = false;
            mtPromotion.Enabled = false;
            _pnCustomer.Swipe();
            mtSales.Enabled = true;
            mtBook.Enabled = true;
            mtEmployee.Enabled = true;
            mtCustomer.Enabled = true;
            mtBackup.Enabled = true;
            mtBillsPayment.Enabled = true;
            mtPromotion.Enabled = true;
        }

        private void mtBackup_Click(object sender, EventArgs e)
        {
            pnAuthentication _pnAuthen = new pnAuthentication(this);
            _pnAuthen.FireEvenAccountAuthentication += _mtBackup_FireEvenAccountAuthentication;
            _pnAuthen.Swipe();
          
        }

        private void _mtBackup_FireEvenAccountAuthentication(object sender, AccountPermissionArgs e)
        {
            frmBackupDB _pnBackup = new frmBackupDB(this);
            _pnBackup.Swipe();
        }

        private void mtRestore_Click(object sender, EventArgs e)
        {
            pnAuthentication _pnAuthen = new pnAuthentication(this);
            _pnAuthen.FireEvenAccountAuthentication += _mtRestore_FireEvenAccountAuthentication;
            _pnAuthen.Swipe();
        }

        private void _mtRestore_FireEvenAccountAuthentication(object sender, AccountPermissionArgs e)
        {
            frmRestoreDB _pnRestore = new frmRestoreDB(this);
            _pnRestore.Swipe();
        }

        private void mtPromotion_Click(object sender, EventArgs e)
        {
            pnAuthentication _pnAuthen = new pnAuthentication(this);
            _pnAuthen.FireEvenAccountAuthentication += _mtPromotion_FireEvenAccountAuthentication;
            _pnAuthen.Swipe();

        }

        private void _mtPromotion_FireEvenAccountAuthentication(object sender, AccountPermissionArgs e)
        {
            frmPromotion _pnPromotion = new frmPromotion(this);
            _pnPromotion.Swipe();
        }

        private void linkAccSettings_Click(object sender, EventArgs e)
        {
            frmAccountSetting f = new frmAccountSetting();
            f.Getter(lbUserName.Text, lbPassword.Text);
            f.ShowDialog();
        }

        private void mtBillsPayment_Click(object sender, EventArgs e)
        {
            pnAuthentication _pnAuthen = new pnAuthentication(this);
            _pnAuthen.FireEvenAccountAuthentication += _mtBillsPayment_FireEvenAccountAuthentication;
            _pnAuthen.Swipe();
           
        }

        private void _mtBillsPayment_FireEvenAccountAuthentication(object sender, AccountPermissionArgs e)
        {
            frmBillsMngmt _pnBillsMngmt = new frmBillsMngmt(this);
            _pnBillsMngmt.Swipe();
        }

        private void accountSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            linkAccSettings_Click(sender, e);
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void maximumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void minimizedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
