using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class OrderDetails
    {
        public int OrderDetailsID { get; set; }
        public int OrderID { get; set; }
        public int BookID { get; set; }
        public int Quantity { get; set; }
        public int DiscountPercent { get; set; }
        public float UnitPrice { get; set; }

        public OrderDetails(int orderDetailID, int orderID, int bookID, int quantity, int discount, float unitPrice)
        {
            OrderDetailsID = orderDetailID;
            OrderID = orderID;
            BookID = bookID;
            Quantity = quantity;
            DiscountPercent = discount;
            UnitPrice = unitPrice;
        }
        public OrderDetails(DataRow row)
        {
            OrderDetailsID = (int)row["order_Details_ID"];
            OrderID = (int)row["orderID"];
            BookID = (int)row["bookID"];
            Quantity = (int)row["quantity"];
            DiscountPercent = (int)row["discount_Percent"];
            UnitPrice = (float)row["unit_Price"];
        }
    }
}
