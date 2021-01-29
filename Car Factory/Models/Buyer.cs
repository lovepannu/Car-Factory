using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Factory.Models
{
    public class Buyer
    {

        [Key]
        public int BuyerID { get; set; }
        public string BuyerName { get; set; }
        public int ContactNumber { get; set; }
        public string BuyerAddress { get; set; }
        //Foreign Key
        //public int HospitalID { get; set; }
        //public Hospital Hospital_obj { get; set; }
        //Foreign Key
        public int SellerID { get; set; }
        public Seller Seller_ID { get; set; }
    }
}
