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
    public class BillsDAO:DataProvider
    {
        private static BillsDAO instance;
        public static BillsDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BillsDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private BillsDAO() { }
        SqlConnection cn;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataTable dt;

        public List<Bills> GetBill(int orderID)
        {
            List<Bills> list = new List<Bills>();
            try
            {
                dt = new DataTable();
                using (cn = new SqlConnection(DataProvider.ConnectionString()))
                {
                    using (cmd = new SqlCommand("usp_GetBill", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@orderID", SqlDbType.Int).Value = orderID;
                        using (da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                            foreach (DataRow item in dt.Rows)
                            {
                                Bills bill = new Bills(item);
                                list.Add(bill);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return list;
        }












    }
}
