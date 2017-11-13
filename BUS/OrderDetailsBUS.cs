using DAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class OrderDetailsBUS
    {
        private static OrderDetailsBUS instance;
        public static OrderDetailsBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new OrderDetailsBUS();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private OrderDetailsBUS() { }

        public void InsertOrderDetails(int orderID, int bookID, int quantity)
        {
            try
            {
                OrderDetailsDAO.Instance.InsertOrderDetails(orderID, bookID, quantity);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public bool CheckBookExists(int bookID, int orderID)
        {
            try
            {
                return OrderDetailsDAO.Instance.CheckBookExists(bookID, orderID);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }



    }
}
