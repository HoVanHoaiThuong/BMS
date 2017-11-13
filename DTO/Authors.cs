using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Authors
    {
        public int AuthorID { get; set; }
        public string AuthorName { get; set; }
        public string Description { get; set; }

        //public Authors() { }
        public Authors(/*int authorID,*/ string authorName, string description)
        {
            //this.AuthorID = AuthorID;
            this.AuthorName = authorName;
            this.Description = description;
        }
        public Authors(int authorID, string authorName, string description)
        {
            this.AuthorID = AuthorID;
            this.AuthorName = authorName;
            this.Description = description;
        }

        public Authors(DataRow row)
        {
            AuthorID = (int)row["author_ID"];
            AuthorName = row["author_Full_Name"].ToString();
            Description = row["author_Description"].ToString();
        }
    }
}
