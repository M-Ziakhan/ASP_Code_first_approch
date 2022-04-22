using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace codefirst.Models
{
    public class sale
    {
        [Key]
        public int sale_id { get; set; }
        public string sale_product { get; set; }
        public int sale_qty { get; set; }
    }
}