using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Employees
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DOB { get; set; }
        public bool? Gender { get; set; }
        public int IdentificationNo { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public byte[] Image { get; set; }
        public bool? UserType { get; set; }

        public Employees(string userName, string password, string firstName, string lastName, DateTime? DOB, bool? gender, int identificationNo, string phoneNo, byte[] image, bool? userType)
        {
            this.UserName = userName;
            this.Password = password;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DOB = DOB;
            this.Gender = gender;
            this.IdentificationNo = identificationNo;
            this.Address = Address;
            this.PhoneNumber = phoneNo;
            this.Image = image;
            this.UserType = userType;
        }

        public Employees(DataRow row)
        {
            this.UserName = row["user_Name"].ToString();
            this.Password = row["user_Password"].ToString();
            this.FirstName = row["employee_First_Name"].ToString();
            this.LastName = row["employee_Last_Name"].ToString();
            this.DOB = row["employee_DOB"].ToString() == string.Empty ? null : (DateTime?)row["employee_DOB"];
            this.Gender = row["employee_Gender"].ToString() == string.Empty ? null : (bool?)row["employee_Gender"];
            this.IdentificationNo = Convert.ToInt32(row["employee_Identification_Number"].ToString());
            this.Address = row["employee_Address"].ToString();
            this.PhoneNumber = row["employee_Phone"].ToString();
            this.Image = row["employee_Image"].ToString() == string.Empty ? null : Encoding.ASCII.GetBytes(row["employee_Image"].ToString());
            this.UserType = row["user_Type"].ToString() == string.Empty ? null : (bool?)row["user_Type"];
        }
    }
}
