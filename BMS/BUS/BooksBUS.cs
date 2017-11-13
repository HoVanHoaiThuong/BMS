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
    public class BooksBUS
    {
        private static BooksBUS instance;

        public static BooksBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new BooksBUS();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private BooksBUS() { }
        public DataTable GetBooks()
        {
            try
            {
                return BooksDAO.Instance.GetBooks();
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        public bool InsertBook(string bookTitle, string yearOfPublished, string pages, int quantity, double price, byte[] img, int authorID, int publisherID, int categoryID)
        {
            try
            {
                return BooksDAO.Instance.InsertBook(bookTitle, yearOfPublished, pages, quantity, price, img, authorID, publisherID, categoryID);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public bool UpdateBook(int bookID, string bookTitle, string yearOfPublished, string pages, int quantity, double price, byte[] img, int authorID, int publisherID, int categoryID)
        {
            try
            {
                return BooksDAO.Instance.UpdateBook(bookID, bookTitle, yearOfPublished, pages, quantity, price, img, authorID, publisherID, categoryID);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public bool RemoveBook(int bookID)
        {
            try
            {
                return BooksDAO.Instance.RemoveBook(bookID);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public DataTable SearchBookByBookTitle(string bookTitle)
        {
            try
            {
                return BooksDAO.Instance.SearchBookByBookTitle(bookTitle);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public DataTable SearchBookByBookID(int bookID)
        {
            try
            {
                return BooksDAO.Instance.SearchBookByBookID(bookID);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public DataTable SearchBookByAuthorName(string authorName)
        {
            try
            {
                return BooksDAO.Instance.SearchBookByAuthorName(authorName);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public DataTable SearchBookByAuthorID(int authorID)
        {
            try
            {
                return BooksDAO.Instance.SearchBookByAuthorID(authorID);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public DataTable SearchBookByPublisherName(string publisherName)
        {
            try
            {
                return BooksDAO.Instance.SearchBookByPublisherName(publisherName);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public DataTable SearchBookByPublisherID(int publisherID)
        {
            try
            {
                return BooksDAO.Instance.SearchBookByPublisherID(publisherID);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public DataTable SearchBookByCategoryName(string categoryName)
        {
            try
            {
                return BooksDAO.Instance.SearchBookByCategoryName(categoryName);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public DataTable SearchBookByCategoryID(int categoryID)
        {
            try
            {
                return BooksDAO.Instance.SearchBookByCategoryID(categoryID);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int GetMaxBookID()
        {
            try
            {
                return BooksDAO.Instance.GetMaxBookID();
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        public int GetQBook()
        {
            try
            {
                return BooksDAO.Instance.GetQBook();
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        public DataTable GetBookByPage(int @page)
        {
            try
            {
                return BooksDAO.Instance.GetBookByPage(page);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

    }
}
