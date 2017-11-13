using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public delegate void FireEventForLoginSuccess(object sender, LoginSuccessEventArgs e);
    public class LoginSuccessEventArgs:EventArgs
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    public delegate void FireEvenForAccountAuthentication(object sender, AccountPermissionArgs e);
    public class AccountPermissionArgs:EventArgs
    {
        public bool AccessPermission { get; set; }
    }

    public delegate void FireEventForPaidSuccess(object sender, PaidSuccessEventArgs e);
    public class PaidSuccessEventArgs:EventArgs
    {
        public string OrderID { get; set; }
        public string OrderDate { get; set; }
        public string EmpName { get; set; }
        public string CustomerName { get; set; }
    }

}
