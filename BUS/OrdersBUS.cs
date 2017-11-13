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
    public class OrdersBUS
    {
        private static OrdersBUS instance;
        public static OrdersBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new OrdersBUS();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private OrdersBUS() { }

        public DataTable GetOrders()
        {
            try
            {
                return OrdersDAO.Instance.GetOrders();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int GetUncheckOrder()
        {
            try
            {
                return OrdersDAO.Instance.GetUncheckOrder();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int GetMaxOrderID()
        {
            try
            {
                return OrdersDAO.Instance.GetMaxOrderID();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void InsertOrder(string acc, int customerID)
        {
            try
            {
                OrdersDAO.Instance.InsertOrder(acc, customerID);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public void CheckOut(int orderID, float totalPrice)
        {
            try
            {
                OrdersDAO.Instance.CheckOut(orderID, totalPrice);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
        public DataTable GetBillByDate(DateTime startDate, DateTime endDate)
        {
            try
            {
                return OrdersDAO.Instance.GetBillByDate(startDate, endDate);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
        public int CountBill(DateTime startDate, DateTime endDate)
        {
            try
            {
                return OrdersDAO.Instance.CountBill(startDate, endDate);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
        public double Revenue(DateTime startDate, DateTime endDate)
        {
            try
            {
                return OrdersDAO.Instance.Revenue(startDate, endDate);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
        public void Delete(int orderID)
        {
            try
            {
                OrdersDAO.Instance.Delete(orderID);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        public DateTime GetOrderDateByID(int orderID)
        {
            try
            {
                return OrdersDAO.Instance.GetOrderDateByID(orderID);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

    }
}
