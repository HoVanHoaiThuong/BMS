using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class CustomersDAO : DataProvider
    {
        private static CustomersDAO instance;
        public static CustomersDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new CustomersDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private CustomersDAO() { }
        SqlConnection cn;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataTable dt;

        public DataTable GetCustomers()
        {
            try
            {
                dt = new DataTable();
                using (cn = new SqlConnection(DataProvider.ConnectionString()))
                {
                    using (cmd = new SqlCommand("usp_GetCustomers", cn))
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

        public bool InsertCustomer(string name, DateTime? DOB, bool? gender, string address, string phone, byte[] image, int points)
        {
            int result = 0;
            try
            {
                using (cn = new SqlConnection(DataProvider.ConnectionString()))
                {
                    cn.Open();
                    using (cmd = new SqlCommand("usp_InsertCustomer", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@name", SqlDbType.VarChar, 100).Value = name;
                        cmd.Parameters.Add("@DOB", SqlDbType.DateTime).Value = DOB;
                        cmd.Parameters.Add("@gender", SqlDbType.Bit).Value = gender;
                        cmd.Parameters.Add("@address", SqlDbType.NVarChar, 200).Value = address;
                        cmd.Parameters.Add("@phone", SqlDbType.NVarChar, 24).Value = phone;
                        cmd.Parameters.Add("@image", SqlDbType.Image).Value = image;
                        cmd.Parameters.Add("@points", SqlDbType.Int).Value = points;

                        cmd.ExecuteNonQuery();
                        result = 1;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return result > 0;
        }
        public bool UpdateCustomer(int customerID, string name, DateTime? DOB, bool? gender, string address, string phone, byte[] image, int points)
        {
            int result = 0;
            try
            {
                using (cn = new SqlConnection(DataProvider.ConnectionString()))
                {
                    cn.Open();
                    using (cmd = new SqlCommand("usp_UpdateCustomer", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@customerID", SqlDbType.Int).Value = customerID;
                        cmd.Parameters.Add("@name", SqlDbType.VarChar, 100).Value = name;
                        cmd.Parameters.Add("@DOB", SqlDbType.DateTime).Value = DOB;
                        cmd.Parameters.Add("@gender", SqlDbType.Bit).Value = gender;
                        cmd.Parameters.Add("@address", SqlDbType.NVarChar, 200).Value = address;
                        cmd.Parameters.Add("@phone", SqlDbType.NVarChar, 24).Value = phone;
                        cmd.Parameters.Add("@image", SqlDbType.Image).Value = image;
                        cmd.Parameters.Add("@points", SqlDbType.Int).Value = points;

                        cmd.ExecuteNonQuery();
                        result = 1;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return result > 0;
        }

        public bool RemoveCustomer(int customerID)
        {
            int result = 0;
            try
            {
                using (cn = new SqlConnection(DataProvider.ConnectionString()))
                {
                    cn.Open();
                    using (cmd = new SqlCommand("usp_RemoveCustomer", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@customerID", SqlDbType.Int).Value = customerID;

                        cmd.ExecuteNonQuery();
                        result = 1;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return result > 0;
        }





    }
}
