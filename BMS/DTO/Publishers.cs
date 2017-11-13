using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Publishers
    {
        public int PublisherID { get; set; }
        public string PublisherName { get; set; }
        public string PublisherAddress { get; set; }
        public string PublisherDescription { get; set; }

        public Publishers(int publisherID, string publisherName, string publisherAdress, string publisherDescription)
        {
            PublisherID = publisherID;
            PublisherName = publisherName;
            PublisherAddress = publisherAdress;
            PublisherDescription = publisherDescription;
        }

        public Publishers(DataRow row)
        {
            PublisherID = (int)row["publisher_ID"];
            PublisherName = row["publisher_Name"].ToString();
            PublisherAddress = row["publisher_Address"].ToString();
            PublisherDescription = row["publisher_Description"].ToString();
        }
    }
}
