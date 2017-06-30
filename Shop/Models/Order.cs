using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shop.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }
        public List<OrderPosition> OrderPositions { get; set; }
        public int TotalSum { get; set; }
    }
}