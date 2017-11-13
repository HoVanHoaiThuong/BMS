using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class OrderDetailsDAO : DataProvider
    {
        private static OrderDetailsDAO instance;
        public static OrderDetailsDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new OrderDetailsDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private OrderDetailsDAO() { }
        SqlConnection cn;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataTable dt;

        public void InsertOrderDetails(int orderID, int bookID, int quantity)
        {
            try
            {
                using (cn = new SqlConnection(DataProvider.ConnectionString()))
                {
                    cn.Open();
                    using (cmd = new SqlCommand("usp_InsertOrderDetails", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("orderID", SqlDbType.Int).Value = orderID;
                        cmd.Parameters.Add("bookID", SqlDbType.Int).Value = bookID;
                        cmd.Parameters.Add("quantity", SqlDbType.Int).Value = quantity;

                        cmd.ExecuteNonQuery();
                    }
                }
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
                dt = new DataTable();
                using (cn = new SqlConnection(DataProvider.ConnectionString()))
                {
                    using (cmd = new SqlCommand("usp_CheckBookExists", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@bookID", SqlDbType.Int).Value = bookID;
                        cmd.Parameters.Add("@orderID", SqlDbType.Int).Value = orderID;
                        using (da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                        return dt.Rows.Count > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }




    }
}
