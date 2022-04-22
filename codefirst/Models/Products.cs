using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace codefirst.Models
{
    public class Products
    {   [Key]
        public int productid { get; set; }

        public string productName { get; set; }

        public int price { get; set; }

        public int qty { get; set; }

        public string remarks { get; set; }
    }
}