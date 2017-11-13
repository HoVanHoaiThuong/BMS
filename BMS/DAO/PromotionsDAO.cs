using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAO
{
    public class PromotionsDAO : DataProvider
    {
        private static PromotionsDAO instance;

        public static PromotionsDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PromotionsDAO();
                }
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        public PromotionsDAO() { }
        SqlConnection cn;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataTable dt;

        public DataTable GetPromotion()
        {
            try
            {
                dt = new DataTable();
                using (cn = new SqlConnection(DataProvider.ConnectionString()))
                {
                    using (cmd = new SqlCommand("usp_GetPromotion", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
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



        public int AddPromo(Promotions promotion)
        {
            try
            {
                using (cn = new SqlConnection(DataProvider.ConnectionString()))
                {
                    cn.Open();
                    using (cmd = new SqlCommand("usp_InsertPromo", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@bookID", SqlDbType.Int).Value = promotion.BookID;
                        cmd.Parameters.Add("@discountPercent", SqlDbType.Int).Value = promotion.DiscountPercent;
                        cmd.Parameters.Add("@startDate", SqlDbType.DateTime).Value = promotion.StartDate;
                        cmd.Parameters.Add("@endDate", SqlDbType.DateTime).Value = promotion.EndDate;
                        cmd.Parameters.Add("@status", SqlDbType.NVarChar, 50).Value = promotion.Status;
                        return cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        public int DeletePromo(int promotionID)
        {
            try
            {
                using (cn = new SqlConnection(DataProvider.ConnectionString()))
                {
                    cn.Open();
                    using (cmd = new SqlCommand("usp_DeletePromo", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@promotionID", SqlDbType.Int).Value = promotionID;
                        return cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                cn.Close();
                throw ex;
            }
        }

        public int UpdatePromo(Promotions promotion, int promotionID)
        {
            try
            {
                using (cn = new SqlConnection(DataProvider.ConnectionString()))
                {
                    cn.Open();
                    using (cmd= new SqlCommand("usp_UpdatePromo", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@promotionID", promotionID);
                        cmd.Parameters.AddWithValue("@bookID", promotion.BookID);
                        cmd.Parameters.AddWithValue("@discountPercent", promotion.DiscountPercent);
                        cmd.Parameters.AddWithValue("@startDate", promotion.StartDate);
                        cmd.Parameters.AddWithValue("@endDate", promotion.EndDate);
                        cmd.Parameters.AddWithValue("@status", promotion.Status);
                        return cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                cn.Close();
                throw ex;
            }
        }

        public bool CheckBookExist(int bookID)
        {
            try
            {
                dt = new DataTable();
                using (cn = new SqlConnection(DataProvider.ConnectionString()))
                {
                    using (cmd = new SqlCommand("usp_CheckBookExistsInPromotion" ,cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@bookID", bookID);
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

        public DataTable SearchBookPromo(string bookTitle)
        {
            try
            {
                dt = new DataTable();
                using (cn = new SqlConnection(DataProvider.ConnectionString()))
                {
                    using (cmd = new SqlCommand("usp_SearchBookPromo", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@bookTitle", bookTitle);
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

        public void UpdatePromoStatus(int promotionID)
        {
            try
            {
                using (cn = new SqlConnection(DataProvider.ConnectionString()))
                {
                    cn.Open();
                    using (cmd = new SqlCommand("usp_UpdatePromoStatus" , cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@promotionID", promotionID);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                cn.Close();
                throw ex;
            }
        }

    }
}
