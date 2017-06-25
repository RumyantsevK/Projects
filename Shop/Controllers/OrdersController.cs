using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Shop.Models;

namespace Shop.Controllers
{
    public class OrdersController : Controller
    {
        private ShopContext db = new ShopContext();

        
        // GET: Orders
        public ActionResult Index()
        {
            var db = new ShopContext();

            return View(db.Orders.Include(x => x.OrderPositions).Include(x => x.OrderPositions.Select(y => y.Product)).FirstOrDefault());
        }
        
    }
}
