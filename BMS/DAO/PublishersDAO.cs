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
    public class PublishersDAO:DataProvider
    {
        private static PublishersDAO instance;

        public static PublishersDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new PublishersDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private PublishersDAO() { }
        SqlConnection cn;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataTable dt;
        public DataTable GetPublishers()
        {
            try
            {
                dt = new DataTable();
                using (cn = new SqlConnection(DataProvider.ConnectionString()))
                {
                    using (da = new SqlDataAdapter("usp_GetPublishers", cn))
                    {
                        da.SelectCommand.CommandType = CommandType.StoredProcedure;
                        da.Fill(dt);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return dt;
        }

        public DataTable SearchPublisherByName(string publisherName)
        {
            dt = new DataTable();
            using (cn = new SqlConnection(DataProvider.ConnectionString()))
            {
                try
                {
                    using (cmd = new SqlCommand("usp_SearchPublisherByPublisherName", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@publisherName", SqlDbType.NVarChar, 80).Value = publisherName;

                        da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                    }
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
            }
            return dt;
        }

        public bool InsertPublisher(string publisherName, string publisherAddress, string publisherDescription)
        {
            int result = 0;
            using (cn = new SqlConnection(DataProvider.ConnectionString()))
            {
                try
                {
                    cn.Open();
                    using (cmd = new SqlCommand("usp_InsertPublisher", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@publisherName", SqlDbType.NVarChar, 80).Value = publisherName;
                        cmd.Parameters.Add("@publisherAddress", SqlDbType.NVarChar, 200).Value = publisherAddress;
                        cmd.Parameters.Add("@publisherDescription", SqlDbType.NVarChar, 200).Value = publisherDescription;

                        cmd.ExecuteNonQuery();
                        result = 1;
                    }
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
                finally
                {
                    cn.Close();
                }
            }
            return result > 0;
        }

        public bool UpdatePublisher(string publisherID, string publisherName, string publisherAddress, string publisherDescription)
        {
            int result = 0;
            using (cn = new SqlConnection(DataProvider.ConnectionString()))
            {
                try
                {
                    cn.Open();
                    using (cmd = new SqlCommand("usp_UpdatePublisher", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@publisherID", SqlDbType.Int).Value = publisherID;
                        cmd.Parameters.Add("@publisherName", SqlDbType.NVarChar, 80).Value = publisherName;
                        cmd.Parameters.Add("@publisherAddress", SqlDbType.NVarChar, 200).Value = publisherAddress;
                        cmd.Parameters.Add("@publisherDescription", SqlDbType.NVarChar, 200).Value = publisherDescription;

                        cmd.ExecuteNonQuery();
                        result = 1;
                    }
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
                finally
                {
                    cn.Close();
                }
            }
            return result > 0;
        }

        public bool RemovePublisher(string publisherID)
        {
            int result = 0;
            using (cn = new SqlConnection(DataProvider.ConnectionString()))
            {
                try
                {
                    cn.Open();
                    using (cmd = new SqlCommand("usp_RemovePublisher", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@publisherID", SqlDbType.Int).Value = publisherID;

                        cmd.ExecuteNonQuery();
                        result = 1;
                    }
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
                finally
                {
                    cn.Close();
                }
            }
            return result > 0;
        }









    }
}
