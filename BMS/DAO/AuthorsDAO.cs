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
    public class AuthorsDAO : DataProvider
    {
        private static AuthorsDAO instance;
        public static AuthorsDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new AuthorsDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private AuthorsDAO() { }

        // string cnStr = ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString;

        SqlConnection cn;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataTable dt;

        //public List<Authors> GetAuthor()
        //{
        //    List<Authors> list = new List<Authors>();
        //    string query = "SELECT * FROM Authors";
        //    try
        //    {
        //        DataTable data = DataProvider.Instance.ExcuteQuery(query);

        //        foreach (DataRow item in data.Rows)
        //        {
        //            Authors author = new Authors(item);
        //            list.Add(author);
        //        }

        //    }
        //    catch (SqlException ex)
        //    {
        //        throw ex;
        //    }
        //    return list;
        //}

        //use DataTable.
        public DataTable GetAuthors()
        {
            try
            {
                return dt = GetData("usp_GetAuthors", CommandType.StoredProcedure);
                //using (cn = new SqlConnection(DataProvider.ConnectionString()))
                //{
                //    using (da = new SqlDataAdapter("usp_GetAuthors", cn))
                //    {
                //        da.SelectCommand.CommandType = CommandType.StoredProcedure;
                //        da.Fill(dt);
                //    }
                //}
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            //return dt;
        }

        //public Authors GetAuthorByID(int authorID)
        //{
        //    Authors author = null;
        //    string query = "SELECT * FROM Authors WHERE author_ID = " + authorID;
        //    try
        //    {
        //        DataTable data = DataProvider.Instance.ExcuteQuery(query);

        //        foreach (DataRow item in data.Rows)
        //        {
        //            author = new Authors(item);
        //            return author;
        //        }
        //        return author;
        //    }
        //    catch (SqlException ex)
        //    {
        //        throw ex;
        //    }
        //}

        //public List<Authors> SearchAuthorByID(string authorID)
        //{
        //    List<Authors> list = new List<Authors>();
        //    DataTable dt = new DataTable();
        //    using (SqlConnection cn = new SqlConnection(DataProvider.ConnectionString))
        //    {
        //        try
        //        {
        //            using (SqlCommand cmd = new SqlCommand("uspSearchAuthorByAuthorID", cn))
        //            {
        //                cmd.CommandType = CommandType.StoredProcedure;
        //                cmd.Parameters.Add("@authorID", SqlDbType.Int).Value = authorID;

        //                SqlDataAdapter da = new SqlDataAdapter(cmd);
        //                da.Fill(dt);
        //                Authors author = null;
        //                foreach (DataRow item in dt.Rows)
        //                {
        //                    author = new Authors(item);
        //                    list.Add(author);
        //                }
        //            }
        //        }
        //        catch (SqlException ex)
        //        {
        //            throw ex;
        //        }
        //    }
        //    return list;
        //}

        public DataTable SearchAuthorByName(string authorName)
        {
            dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(DataProvider.ConnectionString()))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("usp_SearchAuthorByAuthorName", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@authorName", SqlDbType.NVarChar, 100).Value = authorName;

                        da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                        //Authors author = null;
                        //foreach (DataRow item in dt.Rows)
                        //{
                        //    author = new Authors(item);
                        //    list.Add(author);
                        //}
                    }
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
            }
            return dt;
        }

        //public bool InsertAuthor(string authorName, string authorDescription)
        //{
        //    int result = 0;
        //    using (cn = new SqlConnection(DataProvider.ConnectionString()))
        //    {
        //        try
        //        {
        //            cn.Open();
        //            using (cmd = new SqlCommand("usp_InsertAuthor", cn))
        //            {
        //                cmd.CommandType = CommandType.StoredProcedure;
        //                cmd.Parameters.Add("@authorName", SqlDbType.NVarChar, 100).Value = authorName;
        //                cmd.Parameters.Add("@authorDescription", SqlDbType.NVarChar, 200).Value = authorDescription;

        //                cmd.ExecuteNonQuery();
        //                result = 1;
        //            }
        //        }
        //        catch (SqlException ex)
        //        {
        //            throw ex;
        //        }
        //        finally
        //        {
        //            cn.Close();
        //        }
        //        return result > 0;
        //    }
            
        //}
        public void Add(DataTable dt, Authors author)
        {
            try
            {
                using (cn = new SqlConnection(DataProvider.ConnectionString()))
                {
                    using (cmd = new SqlCommand("usp_InsertAuthor", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@authorName", author.AuthorName);
                        cmd.Parameters.AddWithValue("@authorDescription", author.Description);
                        using (da = new SqlDataAdapter())
                        {
                            da.InsertCommand = cmd;
                            da.Update(dt);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public bool UpdateAuthor(int authorID, string authorName, string authorDescription)
        {
            int result = 0;
            using (SqlConnection cn = new SqlConnection(DataProvider.ConnectionString()))
            {
                try
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand("usp_UpdateAuthor", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@authorID", SqlDbType.Int).Value = authorID;
                        cmd.Parameters.Add("@authorName", SqlDbType.NVarChar, 100).Value = authorName;
                        cmd.Parameters.Add("@authorDescription", SqlDbType.NVarChar, 200).Value = authorDescription;

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

        public bool RemoveAuthor(string authorID)
        {
            int result = 0;
            using (SqlConnection cn = new SqlConnection(DataProvider.ConnectionString()))
            {
                try
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand("usp_RemoveAuthor", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@authorID", SqlDbType.Int).Value = authorID;
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
