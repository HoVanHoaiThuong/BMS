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
    public class CategoriesBUS
    {
        private static CategoriesBUS instance;

        public static CategoriesBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new CategoriesBUS();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        private CategoriesBUS() { }
        public DataTable GetCategories()
        {
            try
            {
                return CategoriesDAO.Instance.GetCategories();
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
       
        public DataTable SearchCategoryByName(string categoryName)
        {
            try
            {
                return CategoriesDAO.Instance.SearchCategoryByName(categoryName);

            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        public bool InsertCategory(string categoryName, string categoryDescription)
        {
            try
            {
                return CategoriesDAO.Instance.InsertCategory(categoryName, categoryDescription);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
        public bool UpdateCategory(string categoryID, string categoryName, string categoryDescription)
        {
            try
            {
                return CategoriesDAO.Instance.UpdateCategory(categoryID, categoryName, categoryDescription);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        public bool RemoveCategory(string categoryID)
        {
            try
            {
                return CategoriesDAO.Instance.RemoveCategory(categoryID);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        public Categories GetCategoryByID(int categoryID)
        {
            try
            {
                return CategoriesDAO.Instance.GetCategoryByID(categoryID);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }





    }
}
