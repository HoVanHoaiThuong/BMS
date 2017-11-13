using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Bills
    {
        //public int BookID { get; set; }
        public string BookTitle { get; set; }
        public int Quantity { get; set; }
        public float UnitPrice { get; set; }
        public int Discount { get; set; }
        public double TotalPrice { get; set; }
        public Bills(string bookTitle, int quantiy, float unitPrice, int discount, double totalPrice)
        {
            BookTitle = bookTitle;
            Quantity = quantiy;
            UnitPrice = unitPrice;
            Discount = discount;
            TotalPrice = totalPrice;
        }
        public Bills(DataRow row)
        {
            BookTitle = row["book_Title"].ToString();
            Quantity = (int)row["quantity"];
            UnitPrice = (float)Convert.ToDouble(row["unit_Price"].ToString());
            Discount = (int)row["discount_Percent"];
            TotalPrice = Convert.ToDouble(row["total_Price"].ToString());
        }
    }
}
