using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Factory.Models
{
    public class Seller
    {
        [Key]
        public int SellerID { get; set; }
        public string SellerName { get; set; }
        public int ContactNumber { get; set; }
        public string EmailId { get; set; }
        //Foreign Key
        public int CarID { get; set; }
        public Car Car_ID { get; set; }
    }
}
