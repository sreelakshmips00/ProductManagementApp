using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductManagementApp.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Color { get; set; }
    }
}