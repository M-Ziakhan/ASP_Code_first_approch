using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace codefirst.Models
{
    public class ProductContext :DbContext
    {
        public DbSet<Products> products { get; set; }
        public DbSet<sale> Sales { get; set; }
    }
}