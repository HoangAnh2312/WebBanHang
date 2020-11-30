using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerces_asp.net.Areas.Admin.Models;
using Microsoft.EntityFrameworkCore;
namespace Ecommerces_asp.net.Areas.Admin.Data
{
    public class MarketContext:DbContext
    {
        public MarketContext(DbContextOptions<MarketContext> options) : base(options)
        {

        }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<supplier> Suppliers { get; set; }
    }
}
