using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Books
    {
        public int BookID { get; set; }
        public string BookTitle { get; set; }
        public string AuthorName { get; set; }
        public string PublisherName { get; set; }
        public string CategoryName { get; set; }
        public string YearPublished { get; set; }
        public string Pages { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public int AuthorID { get; set; }
        public int PublisherID { get; set; }
        public int CategoryID { get; set; }
        public byte[] Image { get; set; }

        public Books(int bookId, string bookTitle, string authorName, string publisherName, string categoryName, string yearPublished, string pages, int quantity, double unitPrice, int authorID, int publisherID, int categoryID, byte[] bookImage)
        {
            BookID = BookID;
            BookTitle = bookTitle;
            AuthorName = authorName;
            PublisherName = publisherName;
            CategoryName = categoryName;
            YearPublished = yearPublished;
            Pages = pages;
            Quantity = quantity;
            UnitPrice = unitPrice;
            AuthorID = authorID;
            PublisherID = publisherID;
            CategoryID = categoryID;
            Image = bookImage;
        }
        public Books(DataRow row)
        {
            BookID = (int)row["book_ID"];
            BookTitle = row["book_Title"].ToString();
            AuthorName = row["author_Full_Name"].ToString();
            PublisherName = row["publisher_Name"].ToString();
            CategoryName = row["category_Name"].ToString();
            YearPublished = row["year_Published"].ToString();
            Pages = row["pages"].ToString();
            Quantity = int.Parse(row["quantity"].ToString());
            UnitPrice = double.Parse(row["unit_Price"].ToString());
            //AuthorID = int.Parse(row["author_ID"].ToString());
            //PublisherID = int.Parse(row["publisher_ID"].ToString());
            //CategoryID = int.Parse(row["category_ID"].ToString());
            //Image = row["book_Image"].ToString() == string.Empty ? null : Encoding.ASCII.GetBytes(row["book_Image"].ToString());
        }




    }

}
