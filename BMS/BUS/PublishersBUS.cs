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
    public class PublishersBUS
    {
        private static PublishersBUS instance;

        public static PublishersBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new PublishersBUS();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private PublishersBUS() { }
        public DataTable GetPublishers()
        {
            try
            {
                return PublishersDAO.Instance.GetPublishers();
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        public DataTable SearchPublisherByName(string publisherName)
        {
            try
            {
                return PublishersDAO.Instance.SearchPublisherByName(publisherName);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public bool InsertPublisher(string publisherName, string publisherAddress, string publisherDescription)
        {
            try
            {
                return PublishersDAO.Instance.InsertPublisher(publisherName, publisherAddress, publisherDescription);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public bool UpdatePublisher(string publisherID, string publisherName, string publisherAddress, string publisherDescription)
        {
            try
            {
                return PublishersDAO.Instance.UpdatePublisher(publisherID, publisherName, publisherAddress, publisherDescription);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public bool RemovePublisher(string publisherID)
        {
            try
            {
                return PublishersDAO.Instance.RemovePublisher(publisherID);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }




    }
}
