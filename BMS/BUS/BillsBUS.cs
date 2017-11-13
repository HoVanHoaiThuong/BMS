using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BillsBUS
    {
        private static BillsBUS instance;
        public static BillsBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new BillsBUS();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private BillsBUS() { }

        public List<Bills> GetBill(int orderID)
        {
            try
            {
                List<Bills> list = BillsDAO.Instance.GetBill(orderID);
                return list;
            }
            catch (SqlException ex)
            { 
                throw ex;
            }
        }


    }
}
