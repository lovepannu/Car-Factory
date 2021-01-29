using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Factory.Models
{
    public class Car
    {

        [Key]
        public int CarID { get; set; }

        public String CarName { get; set; }
        public int CarModel { get; set; }
        public string FuelType { get; set; }
        
    }
}
