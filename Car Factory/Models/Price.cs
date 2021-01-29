using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Factory.Models
{
    public class Price
    {

        [Key]
        public int PriceID { get; set; }
        public string CarName { get; set; }
        public int CarPrice { get; set; }
        //Foreign Key
        public int CarID { get; set; }
        public Car Car_ID { get; set; }
    }
}
