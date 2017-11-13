using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class OrdersDAO : DataProvider
    {
        private static OrdersDAO instance;
        public static OrdersDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new OrdersDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private OrdersDAO() { }
        SqlConnection cn;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataTable dt;

        public DataTable GetOrders()
        {
            try
            {
                dt = new DataTable();
                using (cn = new SqlConnection(DataProvider.ConnectionString()))
                {
                    using (cmd = new SqlCommand("usp_GetOrders", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return dt;
        }

        public int GetUncheckOrder()
        {
            try
            {
                dt = new DataTable();
                using (cn = new SqlConnection(DataProvider.ConnectionString()))
                {
                    using (cmd = new SqlCommand("usp_GetUncheckOrder", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                            if (dt.Rows.Count > 0)
                            {
                                Orders order = new Orders(dt.Rows[0]);
                                return order.OrderID;
                            }
                            return -1;
                        }
                    }
                }
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
                using (cn = new SqlConnection(DataProvider.ConnectionString()))
                {
                    cn.Open();
                    using (cmd = new SqlCommand("usp_GetMaxOrderID", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                       
                        return (int)cmd.ExecuteScalar();
                    }
                }
                //return (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(order_ID) FROM dbo.Orders");
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
                using (cn = new SqlConnection(DataProvider.ConnectionString()))
                {
                    cn.Open();
                    using (cmd = new SqlCommand("usp_InsertOrder", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@acc", SqlDbType.VarChar, 50).Value = acc;
                        cmd.Parameters.Add("@customerID", SqlDbType.Int).Value = customerID;

                        cmd.ExecuteNonQuery();
                    }
                }
                //DataProvider.Instance.ExecuteNonQuery("uspInsertOrder @account", new object[] { acc });
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
                using (cn = new SqlConnection(DataProvider.ConnectionString()))
                {
                    cn.Open();
                    using (cmd= new SqlCommand("usp_CheckOut", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@orderID", orderID);
                        cmd.Parameters.AddWithValue("@totalPrice", totalPrice);

                        cmd.ExecuteNonQuery();
                    }
                }
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
                dt = new DataTable();
                using (cn = new SqlConnection(DataProvider.ConnectionString()))
                {
                    using (cmd = new SqlCommand("usp_SearchBill", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@startDate", startDate);
                        cmd.Parameters.AddWithValue("@endDate", endDate);
                        using (da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }
                return dt;
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
                using (cn = new SqlConnection(DataProvider.ConnectionString()))
                {
                    cn.Open();
                    using (cmd = new SqlCommand("usp_CountBill", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@startDate", startDate);
                        cmd.Parameters.AddWithValue("@endDate", endDate);
                        return (int)cmd.ExecuteScalar();
                    }
                }
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
                double revenue = 0;
                using (cn = new SqlConnection(DataProvider.ConnectionString()))
                {
                    cn.Open();
                    using (cmd = new SqlCommand("usp_Revenue", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@startDate", startDate);
                        cmd.Parameters.AddWithValue("@endDate", endDate);
                        object result = cmd.ExecuteScalar();
                        if (result.GetType() == typeof(DBNull))
                            return revenue;
                       else return (double)cmd.ExecuteScalar();
                    }
                }
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
                using (cn = new SqlConnection(DataProvider.ConnectionString()))
                {
                    cn.Open();
                    using (cmd = new SqlCommand("usp_DeleteOrder", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@orderID", orderID);
                        cmd.ExecuteNonQuery();
                    }
                }
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
                List<SqlParameter> paras = new List<SqlParameter>();
                paras.Add(new SqlParameter("orderID", orderID));
                Orders o = null;
                DataTable dt = GetData("usp_GetOrderDateByID", CommandType.StoredProcedure, paras);
                foreach (DataRow item in dt.Rows)
                {
                    o = new Orders(item);
                    return (DateTime)o.OrderDate;
                }
                return (DateTime)o.OrderDate;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

    }
}
