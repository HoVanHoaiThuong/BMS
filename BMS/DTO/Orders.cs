using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Orders
    {
        public int OrderID { get; set; }
        public DateTime? OrderDate { get; set; }
        public string UserName { get; set; }
        public int CustomerID { get; set; }
        public int Status { get; set; }

        public Orders(int orderID, DateTime? orderDate, string userName, int customerID, int status)
        {
            OrderID = orderID;
            OrderDate = orderDate;
            UserName = userName;
            CustomerID = customerID;
            Status = status;
        }

        public Orders(DataRow row)
        {
            OrderID = Convert.ToInt32(row["order_ID"]);
            OrderDate = row["order_Date"].ToString() == string.Empty ? null : (DateTime?)row["order_Date"];
            UserName = row["user_Name"].ToString();
            CustomerID = Convert.ToInt32(row["customer_ID"]);
            Status = Convert.ToInt32(row["order_Status"]);
        }

    }
}
