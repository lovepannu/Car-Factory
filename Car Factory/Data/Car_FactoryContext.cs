using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Car_Factory.Models;

namespace Car_Factory.Data
{
    public class Car_FactoryContext : DbContext
    {
        public Car_FactoryContext (DbContextOptions<Car_FactoryContext> options)
            : base(options)
        {
        }

        public DbSet<Car_Factory.Models.Car> Car { get; set; }

        public DbSet<Car_Factory.Models.Seller> Seller { get; set; }

        public DbSet<Car_Factory.Models.Buyer> Buyer { get; set; }

        public DbSet<Car_Factory.Models.Price> Price { get; set; }
    }
}
