using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace MVCBarApplication.Models
{
    public class OrdersContext : DbContext
    {
        public DbSet<Orders> Orders { get; set; }
    }
}