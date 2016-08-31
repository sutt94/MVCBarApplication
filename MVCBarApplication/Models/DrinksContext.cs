using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVCBarApplication.Models
{
    public class DrinksContext : DbContext
    {
        public DbSet<Drinks> Drinks { get; set; }
    }
}