using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class EmployeesDAO : DataProvider
    {
        private static EmployeesDAO instance;

        public static EmployeesDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new EmployeesDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private EmployeesDAO() { }
        SqlConnection cn;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataTable dt;
        public bool Login(string userName, string password)
        {
            //byte[] temp = ASCIIEncoding.ASCII.GetBytes(password);
            //byte[] hashData = new MD5CryptoServiceProvider().ComputeHash(temp);

            //string hashPassword = "";

            //foreach (byte item in hashData)
            //{
            //    hashPassword += item;
            //}
            dt = new DataTable();
            try
            {
                using (cn = new SqlConnection(DataProvider.ConnectionString()))
                {
                    using (cmd = new SqlCommand("usp_Login", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@userName", SqlDbType.VarChar, 50).Value = userName;
                        cmd.Parameters.Add("@password", SqlDbType.VarChar, 50).Value = password;
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
            return dt.Rows.Count > 0;
        }

        public DataTable GetAccounts()
        {
            try
            {
                dt = new DataTable();
                using (cn = new SqlConnection(DataProvider.ConnectionString()))
                {
                    using (cmd = new SqlCommand("usp_GetAccounts", cn))
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

        //public UserAccounts GetAccountByUserName(string userName)
        //{
        //    try
        //    {
        //        dt = DataProvider.Instance.ExcuteQuery("SELECT * FROM UserAccounts WHERE user_Name = '" + userName + "'");
        //        foreach (DataRow item in dt.Rows)
        //        {
        //            return new UserAccounts(item);
        //        }
        //        return null;
        //    }
        //    catch (SqlException ex)
        //    {
        //        throw ex;
        //    }
        //}
        public DataTable GetAccountByUserName(string userName)
        {
            try
            {
                dt = new DataTable();
                using (cn = new SqlConnection(DataProvider.ConnectionString()))
                {
                    using (cmd = new SqlCommand("usp_GetEmpByUserName", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@userName", SqlDbType.VarChar, 50).Value = userName;
                        using (da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }
                //dt = DataProvider.Instance.ExcuteQuery("SELECT * FROM UserAccounts WHERE user_Name = '" + userName + "'");
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return dt;
        }

        //public bool UpdateAccount(string userName, string displayName, string password, string newPassword)
        //{
        //    byte[] temp = ASCIIEncoding.ASCII.GetBytes(password);
        //    byte[] hashData = new MD5CryptoServiceProvider().ComputeHash(temp);

        //    string hashPassword = "";

        //    foreach (byte item in hashData)
        //    {
        //        hashPassword += item;
        //    }
        //    int result = DataProvider.Instance.ExecuteNonQuery("EXEC uspUpdateAccount @userName , @displayName , @password , @newPassword", new object[] { userName, displayName, hashPassword, newPassword });
        //    return result > 0;
        //}

        public bool InsertEmployee(string userName, string password, string firstName, string lastName, DateTime? DOB, bool? gender, int IDNo, string address, string phone, byte[] image, bool? type)
        {
            int result = 0;
            try
            {
                using (cn = new SqlConnection(DataProvider.ConnectionString()))
                {
                    cn.Open();
                    using (cmd = new SqlCommand("usp_InsertAccount", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@userName", SqlDbType.VarChar, 50).Value = userName;
                        cmd.Parameters.Add("@password", SqlDbType.VarChar, 50).Value = password;
                        cmd.Parameters.Add("@firstName", SqlDbType.VarChar, 50).Value = firstName;
                        cmd.Parameters.Add("@lastName", SqlDbType.VarChar, 50).Value = lastName;
                        cmd.Parameters.Add("@DOB", SqlDbType.DateTime).Value = DOB;
                        cmd.Parameters.Add("@gender", SqlDbType.Bit).Value = gender;
                        cmd.Parameters.Add("@IDNo", SqlDbType.Int).Value = IDNo;
                        cmd.Parameters.Add("@address", SqlDbType.NVarChar, 200).Value = address;
                        cmd.Parameters.Add("@phone", SqlDbType.NVarChar, 24).Value = phone;
                        cmd.Parameters.Add("@image", SqlDbType.Image).Value = image;
                        cmd.Parameters.Add("@userType", SqlDbType.Bit).Value = type;

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

        public bool UpdateEmployee(string userName, string password, string firstName, string lastName, DateTime? DOB, bool? gender, int IDNo, string address, string phone, byte[] image, bool? type)
        {
            int result = 0;
            try
            {
                using (cn = new SqlConnection(DataProvider.ConnectionString()))
                {
                    cn.Open();
                    using (cmd = new SqlCommand("usp_UpdateAccount", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@userName", SqlDbType.VarChar, 50).Value = userName;
                        cmd.Parameters.Add("@password", SqlDbType.VarChar, 50).Value = password;
                        cmd.Parameters.Add("@firstName", SqlDbType.VarChar, 50).Value = firstName;
                        cmd.Parameters.Add("@lastName", SqlDbType.VarChar, 50).Value = lastName;
                        cmd.Parameters.Add("@DOB", SqlDbType.DateTime).Value = DOB;
                        cmd.Parameters.Add("@gender", SqlDbType.Bit).Value = gender;
                        cmd.Parameters.Add("@IDNo", SqlDbType.Int).Value = IDNo;
                        cmd.Parameters.Add("@address", SqlDbType.NVarChar, 200).Value = address;
                        cmd.Parameters.Add("@phone", SqlDbType.NVarChar, 24).Value = phone;
                        cmd.Parameters.Add("@image", SqlDbType.Image).Value = image;
                        cmd.Parameters.Add("@userType", SqlDbType.Bit).Value = type;

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

        public bool RemoveEmployee(string userName)
        {
            int result = 0;
            try
            {
                using (cn = new SqlConnection(DataProvider.ConnectionString()))
                {
                    cn.Open();
                    using (cmd = new SqlCommand("usp_RemoveAccount", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@userName", SqlDbType.VarChar, 50).Value = userName;
                       
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

        //public bool RemoveAccount(string userName)
        //{
        //    string query = string.Format("DELETE FROM UserAccounts WHERE user_Name = N'{0}'", userName);
        //    int result = DataProvider.Instance.ExecuteNonQuery(query);

        //    return result > 0;
        //}

        //public bool UpdateAccount(string userName, string displayName, bool userType)
        //{
        //    string query = string.Format("UPDATE dbo.UserAccounts SET user_Display_Name = N'{1}', user_Type = {2} WHERE user_Name = N'{0}'", userName, displayName, userType);
        //    int result = DataProvider.Instance.ExecuteNonQuery(query);

        //    return result > 0;
        //}

        //public bool ResetPassword(string userName)
        //{
        //    string query = string.Format("UPDATE UserAccounts SET user_Password = N'1962026656160185351301320480154111117132155' where user_Name = N'{0}'", userName);
        //    int result = DataProvider.Instance.ExecuteNonQuery(query);

        //    return result > 0;
        //}

        public DataTable GetEmpNameByUserName(string userName)
        {  
            try
            {
                dt = new DataTable();
                
                using (cn = new SqlConnection(DataProvider.ConnectionString()))
                {
                    using (cmd = new SqlCommand("usp_GetEmpNameByUserName", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@userName", SqlDbType.VarChar, 50).Value = userName;
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

        public bool GetPermission(string userName)
        {
            try
            {
                dt = new DataTable();
                using (cn = new SqlConnection(DataProvider.ConnectionString()))
                {
                    using (cmd = new SqlCommand("usp_GetPermission", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@userName", SqlDbType.VarChar, 50).Value = userName;
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

        public int UpdatePassword(string userName, string newPassword)
        {
            try
            {
                using (cn = new SqlConnection(DataProvider.ConnectionString()))
                {
                    cn.Open();
                    using (cmd = new SqlCommand("usp_UpdatePassword", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@userName", userName);
                        cmd.Parameters.AddWithValue("@newPassword", newPassword);
                        return cmd.ExecuteNonQuery();
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
