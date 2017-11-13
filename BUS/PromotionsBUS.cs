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
    public class PromotionsBUS
    {
        private static PromotionsBUS instance;

        public static PromotionsBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PromotionsBUS();
                }
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private PromotionsBUS() { }

        public DataTable GetPromotion()
        {
            try
            {
                return PromotionsDAO.Instance.GetPromotion();
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
                return PromotionsDAO.Instance.AddPromo(promotion);
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
                return PromotionsDAO.Instance.DeletePromo(promotionID);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        public int UpdatePromo(Promotions promotion, int promotionID)
        {
            try
            {
                return PromotionsDAO.Instance.UpdatePromo(promotion, promotionID);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
        public bool CheckBookExist(int bookID)
        {
            try
            {
                return PromotionsDAO.Instance.CheckBookExist(bookID);
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
                return PromotionsDAO.Instance.SearchBookPromo(bookTitle);
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
                PromotionsDAO.Instance.UpdatePromoStatus(promotionID);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }




    }
}
