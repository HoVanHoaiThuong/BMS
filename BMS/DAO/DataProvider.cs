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
    public class DataProvider
    {
        SqlConnection cn;
        public static string ConnectionString()
        {
                return ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString;
        }
        //private static DataProvider instance;
        //public static DataProvider Instance
        //{
        //    get
        //    {
        //        if (instance == null)
        //            instance = new DataProvider();
        //        return instance;
        //    }

        //    private set
        //    {
        //        instance = value;
        //    }
        //}

        public DataProvider() { }
        DataTable dt;
        SqlCommand cmd;
        SqlDataAdapter da;

        public DataTable GetData(string query, CommandType type, List<SqlParameter> paras = null)
        {
            try
            {
                dt = new DataTable();
                using (cn = new SqlConnection(DataProvider.ConnectionString()))
                {
                    using (cmd = new SqlCommand(query, cn))
                    {
                        cmd.CommandType = type;
                        if (paras != null)
                        {
                            foreach (var i in paras)
                            {
                                cmd.Parameters.Add(i);
                            }
                        }
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


        //public DataProvider(string connectionString)
        //{
        //    cn = new SqlConnection(connectionString);
        //}
        public bool IsConnection
        {
            get
            {
                if (cn != null && cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                return true;
            }
        }

        public bool Connect(string cnStr)
        {
            try
            {
                    cn = new SqlConnection(cnStr);
             
                    cn.ConnectionString = cnStr;

                    if (cn != null && cn.State != ConnectionState.Open)
                    {
                        cn.Open();
                        return true;
                    }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return false;
        }


        //public void Connect()
        //{
        //    try
        //    {
        //        cn = new SqlConnection(cnStr);
        //        cn.ConnectionString = cnStr;

        //        if (cn != null && cn.State != ConnectionState.Open)
        //        {
        //            cn.Open();
        //        }
        //    }
        //    catch (SqlException ex)
        //    {
        //        throw (ex);
        //    }
        //}

        //public void DisConnect()
        //{
        //    if (cn != null && cn.State != ConnectionState.Closed)
        //    {
        //        cn.Close();
        //    }
        //}

        //public SqlDataReader ExecuteReader(string query)
        //{
        //    using (cn =  new SqlConnection(DataProvider.ConnectionString))
        //    {
        //        //cn.Open();
        //        try
        //        {
        //            SqlCommand cmd = new SqlCommand(query, cn);
        //            return (cmd.ExecuteReader());
        //        }
        //        catch (SqlException ex)
        //        {

        //            throw ex;
        //        }
        //        return null;
        //    }
        //}

        //public int ExcuteNonQuery(string query, CommandType type, List<SqlParameter> listParas)
        //{
        //    using (SqlConnection cn = new SqlConnection(cnStr))
        //    {
        //        Connect();
        //        try
        //        {
        //            SqlCommand cmd = new SqlCommand(query, cn);
        //            cmd.CommandType = type;

        //            if (listParas != null)
        //            {
        //                foreach (var para in listParas)
        //                {
        //                    cmd.Parameters.Add(para);
        //                }
        //            }
        //            cmd.ExecuteNonQuery();
        //            return 1;
        //        }
        //        catch (SqlException ex)
        //        {

        //            throw ex;
        //        }
        //        finally
        //        {
        //            DisConnect();
        //        }
        //    }
        //}

        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;

            using (cn = new SqlConnection(DataProvider.ConnectionString()))
            {
                cn.Open();
                try
                {
                    SqlCommand command = new SqlCommand(query, cn);

                    if (parameter != null)
                    {
                        string[] listPara = query.Split(' ');
                        int i = 0;
                        foreach (string item in listPara)
                        {
                            if (item.Contains('@'))
                            {
                                command.Parameters.AddWithValue(item, parameter[i]);
                                i++;
                            }
                        }
                    }
                    data = command.ExecuteNonQuery();
                    return data;
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
            }

        }

        public DataTable ExcuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();

            using (cn = new SqlConnection(DataProvider.ConnectionString()))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, cn);
                    if (parameter != null)
                    {
                        string[] temp = query.Split(' ');
                        List<string> listPara = new List<string>();
                        foreach (var item in temp)
                        {
                            if (item.Contains('@'))
                            {
                                listPara.Add(item);
                            }
                        }
                        for (int i = 0; i < parameter.Length; i++)
                        {
                            cmd.Parameters.AddWithValue(listPara[i], parameter[i]);
                        }
                    }
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(data);
                    return data;
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
            }
        }

        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;

            using (cn = new SqlConnection(DataProvider.ConnectionString()))
            {
                cn.Open();
                try
                {
                    SqlCommand command = new SqlCommand(query, cn);

                    if (parameter != null)
                    {
                        string[] listPara = query.Split(' ');
                        int i = 0;
                        foreach (string item in listPara)
                        {
                            if (item.Contains('@'))
                            {
                                command.Parameters.AddWithValue(item, parameter[i]);
                                i++;
                            }
                        }
                    }
                    data = command.ExecuteScalar();
                    return data;
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
            }
        }
    }


}
