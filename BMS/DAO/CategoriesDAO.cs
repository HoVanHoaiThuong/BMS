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
    public class CategoriesDAO : DataProvider
    {
        private static CategoriesDAO instance;

        public static CategoriesDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new CategoriesDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private CategoriesDAO() { }
        SqlConnection cn;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataTable dt;
        public DataTable GetCategories()
        {
            try
            {
                dt = new DataTable();
                using (cn = new SqlConnection(DataProvider.ConnectionString()))
                {
                    using (da = new SqlDataAdapter("usp_GetCategories", cn))
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

       
        public DataTable SearchCategoryByName(string categoryName)
        {
            List<Categories> list = new List<Categories>();
            DataTable dt = new DataTable();
            using (cn = new SqlConnection(DataProvider.ConnectionString()))
            {
                try
                {
                    using (cmd = new SqlCommand("usp_SearchCategoryByCategoryName", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@categoryName", SqlDbType.NVarChar, 100).Value = categoryName;

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
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

        public bool InsertCategory(string categoryName, string categoryDescription)
        {
            int result = 0;
            using (SqlConnection cn = new SqlConnection(DataProvider.ConnectionString()))
            {
                try
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand("usp_InsertCategory", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@categoryName", SqlDbType.NVarChar, 100).Value = categoryName;
                        cmd.Parameters.Add("@categoryDescription", SqlDbType.NVarChar, 200).Value = categoryDescription;

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

        public bool UpdateCategory(string categoryID, string categoryName, string categoryDescription)
        {
            int result = 0;
            using (cn = new SqlConnection(DataProvider.ConnectionString()))
            {
                try
                {
                    cn.Open();
                    using (cmd = new SqlCommand("usp_UpdateCategory", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@categoryID", SqlDbType.Int).Value = categoryID;
                        cmd.Parameters.Add("@categoryName", SqlDbType.NVarChar, 100).Value = categoryName;
                        cmd.Parameters.Add("@categoryDescription", SqlDbType.NVarChar, 200).Value = categoryDescription;

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
        public bool RemoveCategory(string categoryID)
        {
            int result = 0;
            using (cn = new SqlConnection(DataProvider.ConnectionString()))
            {
                try
                {
                    cn.Open();
                    using (cmd = new SqlCommand("usp_RemoveCategory", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@categoryID", SqlDbType.Int).Value = categoryID;

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

        public Categories GetCategoryByID(int categoryID)
        {
            Categories category = null;
            try
            {
                dt = new DataTable();
                using (cn = new SqlConnection(DataProvider.ConnectionString()))
                {
                    using (cmd = new SqlCommand("usp_GetCategoryByID", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@categoryID", SqlDbType.Int).Value = category;
                        using (da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                        foreach (DataRow item in dt.Rows)
                        {
                            category = new Categories(item);
                            return category;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return category;
        }



    }
}
