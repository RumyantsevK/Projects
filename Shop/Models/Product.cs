using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shop.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductType { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
    }
}