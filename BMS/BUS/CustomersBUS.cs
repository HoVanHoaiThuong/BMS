using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class CustomersBUS
    {
        private static CustomersBUS instance;
        public static CustomersBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new CustomersBUS();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private CustomersBUS() { }

        public DataTable GetCustomers()
        {
            try
            {
                return CustomersDAO.Instance.GetCustomers();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public bool InsertCustomer(string name, DateTime? DOB, bool? gender, string address, string phone, byte[] image, int points)
        {
            try
            {
                return CustomersDAO.Instance.InsertCustomer(name, DOB, gender, address, phone, image, points);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public bool UpdateCustomer(int customerID, string name, DateTime? DOB, bool? gender, string address, string phone, byte[] image, int points)
        {
            try
            {
                return CustomersDAO.Instance.UpdateCustomer(customerID, name, DOB, gender, address, phone, image, points);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public bool RemoveCustomer(int customerID)
        {
            try
            {
                return CustomersDAO.Instance.RemoveCustomer(customerID);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
