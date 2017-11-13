using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Promotions
    {
        public int PromotionID { get; set; }
        public int BookID { get; set; }
        public string BookTitle { get; set; }
        public int DiscountPercent { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Status { get; set; }
        public Promotions(/*int promotionID,*/ int bookID/*, string bookTitle*/, int discount, DateTime? startDate, DateTime? endDate, string status)
        {
           //PromotionID = promotionID;
            BookID = bookID;
            //BookTitle = bookTitle;
            DiscountPercent = discount;
            StartDate = startDate;
            EndDate = endDate;
            Status = status;
        }

        public Promotions(DataRow row)
        {
            PromotionID = (int)row["promotion_ID"];
            BookID = (int)row["book_ID"];
            BookTitle = row["book_Title"].ToString();
            DiscountPercent = (int)row["discount_Percent"];
            StartDate = row["start_Date"].ToString() == string.Empty ? null : (DateTime?)row["start_Date"];
            EndDate = row["end_Date"].ToString() == string.Empty ? null : (DateTime?)row["end_Date"];
            Status = row["promotion_Status"].ToString();
        }

    }
}
