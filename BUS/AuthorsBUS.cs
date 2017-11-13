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
    public class AuthorsBUS
    {
        private static AuthorsBUS instance;

        public static AuthorsBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new AuthorsBUS();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        private AuthorsBUS() { }
        //public List<Authors> GetAuthor()
        //{
        //    try
        //    {
        //        return AuthorsDAO.Instance.GetAuthor();
        //    }
        //    catch (SqlException ex)
        //    {

        //        throw ex;
        //    }
        //}

         public DataTable GetAuthors()
        {
            try
            {
                return AuthorsDAO.Instance.GetAuthors();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        //public Authors GetAuthorByID(int authorID)
        //{
        //    try
        //    {
        //        return AuthorsDAO.Instance.GetAuthorByID(authorID);
        //    }
        //    catch (SqlException ex)
        //    {

        //        throw ex;
        //    }
        //}

        //public List<Authors> SearchAuthorByID(string authorID)
        //{
        //    try
        //    {
        //        return AuthorsDAO.Instance.SearchAuthorByID(authorID);

        //    }
        //    catch (SqlException ex)
        //    {

        //        throw ex;
        //    }
        //}

        public DataTable SearchAuthorByName(string authorName)
        {
            try
            {
                return AuthorsDAO.Instance.SearchAuthorByName(authorName);

            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        //public bool InsertAuthor(string authorName, string authorDescription)
        //{
        //    try
        //    {
        //        return AuthorsDAO.Instance.InsertAuthor(authorName, authorDescription);
        //    }
        //    catch (SqlException ex)
        //    {
        //        throw ex;
        //    }
        //}
        public void Add(DataTable dt, Authors author)
        {
            try
            {
                AuthorsDAO.Instance.Add(dt, author);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public bool UpdateAuthor(int authorID, string authorName, string authorDescription)
        {
            try
            {
                return AuthorsDAO.Instance.UpdateAuthor(authorID, authorName, authorDescription);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }


        public bool RemoveAuthor(string authorID)
        {
            try
            {
                return AuthorsDAO.Instance.RemoveAuthor(authorID);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }











    }
}
