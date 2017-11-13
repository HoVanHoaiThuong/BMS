using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class EmployeesBUS
    {
        private static EmployeesBUS instance;

        public static EmployeesBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new EmployeesBUS();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private EmployeesBUS() { }

        public bool Login(string userName, string password)
        {
            try
            {
                return EmployeesDAO.Instance.Login(userName, password);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public DataTable GetAccounts()
        {
            try
            {
                return EmployeesDAO.Instance.GetAccounts();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public bool InsertEmployee(string userName, string password, string firstName, string lastName, DateTime? DOB, bool? gender, int IDNo, string address, string phone, byte[] image, bool? type)
        {
            try
            {
                return EmployeesDAO.Instance.InsertEmployee(userName, password, firstName, lastName, DOB, gender, IDNo, address, phone, image, type);
            }
            catch (SqlException ex)
            { 
                throw ex;
            }
        }

        public bool UpdateEmployee(string userName, string password, string firstName, string lastName, DateTime? DOB, bool? gender, int IDNo, string address, string phone, byte[] image, bool? type)
        {
            try
            {
                return EmployeesDAO.Instance.UpdateEmployee(userName, password, firstName, lastName, DOB, gender, IDNo, address, phone, image, type);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }




        public DataTable GetAccountByUserName(string userName)
        {
            try
            {
                return EmployeesDAO.Instance.GetAccountByUserName(userName);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        //public bool UpdateAccount(string userName, string displayName, string pasword, string newPassword)
        //{
        //    try
        //    {
        //        return UserAccountsDAO.Instance.UpdateAccount(userName, displayName, pasword, newPassword);
        //    }
        //    catch (SqlException ex)
        //    {

        //        throw ex;
        //    }
        //}


        

        public bool RemoveEmployee(string userName)
        {
            return EmployeesDAO.Instance.RemoveEmployee(userName);
        }

        //public bool UpdateAccount(string userName, string displayName, bool userType)
        //{
        //    return UserAccountsDAO.Instance.UpdateAccount(userName, displayName, userType);
        //}

        //public bool ResetPassword(string userName)
        //{
        //    return EmployeesDAO.Instance.ResetPassword(userName);
        //}

        public DataTable GetEmpNameByUserName(string userName)
        {
            try
            {
                return EmployeesDAO.Instance.GetEmpNameByUserName(userName);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public bool GetPermission(string userName)
        {
            try
            {
                return EmployeesDAO.Instance.GetPermission(userName);
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
                return EmployeesDAO.Instance.UpdatePassword(userName, newPassword);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

    }
}
