using DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class BooksDAO:DataProvider
    {
        private static BooksDAO instance;
        public static BooksDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BooksDAO();
                return instance;
            }
            private set { instance = value; }
        }
        private BooksDAO() { }
        SqlConnection cn;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataTable dt;

        public DataTable GetBooks()
        {
            //dt = new DataTable();
            try
            {
                //using (cn = new SqlConnection(DataProvider.ConnectionString()))
                //{
                //    using (cmd = new SqlCommand("usp_GetBooks", cn))
                //    {
                //        cmd.CommandType = CommandType.StoredProcedure;

                //        using (da = new SqlDataAdapter(cmd))
                //        {
                //            da.Fill(dt);
                //        }
                //    }
                //}
                return dt = GetData("usp_GetBooks", CommandType.StoredProcedure);
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            //return dt;
        }

        public bool InsertBook(string bookTitle, string yearOfPublished, string pages, int quantity, double price, byte[] img, int authorID, int publisherID, int categoryID)
        {
            int result = 0;
            using (cn = new SqlConnection(DataProvider.ConnectionString()))
            {
                try
                {
                    cn.Open();
                    using (cmd = new SqlCommand("usp_InsertBook", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@bookTitle", SqlDbType.NVarChar, 150).Value = bookTitle;                     
                        cmd.Parameters.Add("@yearPublished", SqlDbType.NVarChar, 4).Value = yearOfPublished;
                        cmd.Parameters.Add("@pages", SqlDbType.NVarChar, 10).Value = pages;
                        cmd.Parameters.Add("@quantity", SqlDbType.Int).Value = quantity;
                        cmd.Parameters.Add("@price", SqlDbType.Float).Value = price;
                        cmd.Parameters.Add("@image", SqlDbType.Image).Value = img;
                        cmd.Parameters.Add("@authorID", SqlDbType.Int).Value = authorID;
                        cmd.Parameters.Add("@publisherID", SqlDbType.Int).Value = publisherID;
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

        public bool UpdateBook(int bookID, string bookTitle, string yearOfPublished, string pages, int quantity, double price, byte[] img, int authorID, int publisherID, int categoryID)
        {
            int result = 0;
            using (cn = new SqlConnection(DataProvider.ConnectionString()))
            {
                try
                {
                    cn.Open();
                    using (cmd = new SqlCommand("usp_UpdateBook", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@bookID", SqlDbType.Int).Value = bookID;
                        cmd.Parameters.Add("@bookTitle", SqlDbType.NVarChar, 150).Value = bookTitle;
                        cmd.Parameters.Add("@yearPublished", SqlDbType.NVarChar, 4).Value = yearOfPublished;
                        cmd.Parameters.Add("@pages", SqlDbType.NVarChar, 10).Value = pages;
                        cmd.Parameters.Add("@quantity", SqlDbType.Int).Value = quantity;
                        cmd.Parameters.Add("@price", SqlDbType.Float).Value = price;
                        cmd.Parameters.Add("@image", SqlDbType.Image).Value = img;
                        cmd.Parameters.Add("@authorID", SqlDbType.Int).Value = authorID;
                        cmd.Parameters.Add("@publisherID", SqlDbType.Int).Value = publisherID;
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

        public bool RemoveBook(int bookID)
        {
            int result = 0; 
            using (cn = new SqlConnection(DataProvider.ConnectionString()))
            {
                try
                {
                    cn.Open();
                    using (cmd = new SqlCommand("usp_RemoveBook", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@bookID", SqlDbType.Int).Value = bookID;
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

        public DataTable SearchBookByBookTitle(string BookTitle)
        {
            dt = new DataTable();
            using (cn = new SqlConnection(DataProvider.ConnectionString()))
            {
                try
                {                
                    using (cmd = new SqlCommand("usp_SearchBookByBookTitle", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@bookTitle", SqlDbType.NVarChar, 150).Value = BookTitle;
                        using (da = new SqlDataAdapter(cmd))
                        {
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
        }

        public DataTable SearchBookByBookID(int bookID)
        {
            dt = new DataTable();
            using (cn = new SqlConnection(DataProvider.ConnectionString()))
            {
                try
                {
                    using (cmd = new SqlCommand("usp_SearchBookByBookID", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@bookID", SqlDbType.Int).Value = bookID;
                        using (da = new SqlDataAdapter(cmd))
                        {
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
        }
        public DataTable SearchBookByAuthorName(string authorName)
        {
            dt = new DataTable();
            using (cn = new SqlConnection(DataProvider.ConnectionString()))
            {
                try
                {
                    using (cmd = new SqlCommand("usp_SearchBookByAuthorName", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@authorName", SqlDbType.NVarChar, 100).Value = authorName;
                        using (da = new SqlDataAdapter(cmd))
                        {
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
        }
        public DataTable SearchBookByAuthorID(int authorID)
        {
            dt = new DataTable();
            using (cn = new SqlConnection(DataProvider.ConnectionString()))
            {
                try
                {
                    using (cmd = new SqlCommand("usp_SearchBookByAuthorID", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@authorID", SqlDbType.Int).Value = authorID;
                        using (da = new SqlDataAdapter(cmd))
                        {
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
        }
        public DataTable SearchBookByPublisherName(string publisherName)
        {
            dt = new DataTable();
            using (cn = new SqlConnection(DataProvider.ConnectionString()))
            {
                try
                {
                    using (cmd = new SqlCommand("usp_SearchBookByPublisherName", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@publisherName", SqlDbType.NVarChar, 80).Value = publisherName;
                        using (da = new SqlDataAdapter(cmd))
                        {
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
        }
        public DataTable SearchBookByPublisherID(int publisherID)
        {
            dt = new DataTable();
            using (cn = new SqlConnection(DataProvider.ConnectionString()))
            {
                try
                {
                    using (cmd = new SqlCommand("usp_SearchBookByPublisherID", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@publisherID", SqlDbType.Int).Value = publisherID;
                        using (da = new SqlDataAdapter(cmd))
                        {
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
        }
        public DataTable SearchBookByCategoryName(string categoryName)
        {
            dt = new DataTable();
            using (cn = new SqlConnection(DataProvider.ConnectionString()))
            {
                try
                {
                    using (cmd = new SqlCommand("usp_SearchBookByCategoryName", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@categoryName", SqlDbType.NVarChar, 100).Value = categoryName;
                        using (da = new SqlDataAdapter(cmd))
                        {
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
        }
        public DataTable SearchBookByCategoryID(int categoryID)
        {
            dt = new DataTable();
            using (cn = new SqlConnection(DataProvider.ConnectionString()))
            {
                try
                {
                    using (cmd = new SqlCommand("usp_SearchBookByCategoryID", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@categoryID", SqlDbType.Int).Value = categoryID;
                        using (da = new SqlDataAdapter(cmd))
                        {
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
        }
        public int GetMaxBookID()
        {
            try
            {
                using (cn = new SqlConnection(DataProvider.ConnectionString()))
                {
                    cn.Open();
                    using (cmd = new SqlCommand("usp_GetMaxBookID", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        return (int)cmd.ExecuteScalar();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int GetQBook()
        {
            try
            {
                using (cn = new SqlConnection(DataProvider.ConnectionString()))
                {
                    cn.Open();
                    using (cmd = new SqlCommand("usp_GetQBook", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        return (int)cmd.ExecuteScalar();
                    }
                }
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        public DataTable GetBookByPage(int @page)
        {
            try
            {
                dt = new DataTable();
                using (cn = new SqlConnection(DataProvider.ConnectionString()))
                {
                    using (cmd = new SqlCommand("usp_GetBookAndPage", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@page", page);
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


    }
}
