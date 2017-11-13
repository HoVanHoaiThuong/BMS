using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Customers
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public DateTime? DOB { get; set; }
        public bool? Gender { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public byte[] Image { get; set; }
        public int AccumulationPoints { get; set; }

        public Customers(int customerID, string customerName, DateTime? dob, bool? gender, string address, string phone, byte[] image, int accPoint)
        {
            this.CustomerID = customerID;
            this.CustomerName = customerName;
            this.DOB = dob;
            this.Gender = gender;
            this.Address = address;
            this.Phone = phone;
            this.Image = image;
            this.AccumulationPoints = accPoint;
        }
        public Customers(DataRow row)
        {
            this.CustomerID = Convert.ToInt32(row["customer_ID"]);
            this.CustomerName = row["customer_Name"].ToString();
            this.DOB = row["customer_DOB"].ToString() == string.Empty ? null : (DateTime?)row["customer_DOB"];
            this.Gender = row["customer_Gender"].ToString() == string.Empty ? null : (bool?)row["customer_Gender"];
            this.Address = row["customer_Address"].ToString();
            this.Phone = row["customer_Phone"].ToString();
            this.Image = row["customer_Image"].ToString() == string.Empty ? null : Encoding.ASCII.GetBytes(row["customer_Image"].ToString());
            this.AccumulationPoints = Convert.ToInt32(row["accumulation_Points"]);
        }
    }
}
