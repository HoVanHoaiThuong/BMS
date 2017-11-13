using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Categories
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }

        public Categories(int categoryID, string categoryName, string categoryDescription)
        {
            CategoryID = categoryID;
            CategoryName = categoryName;
            CategoryDescription = categoryDescription;
        }

        public Categories(DataRow row)
        {
            this.CategoryID = (int)row["category_ID"];
            this.CategoryName = row["category_Name"].ToString();
            this.CategoryDescription = row["category_Description"].ToString();
        }
    }
}
