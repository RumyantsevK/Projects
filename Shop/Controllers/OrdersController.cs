using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Shop.Models;

namespace Shop.Controllers
{
    public class OrdersController : Controller
    {
        private ShopContext db;

        public OrdersController()
        {
            db = new ShopContext();
        }

        // GET: Orders
        public ActionResult Index()
        {
            return View(db.Orders.Include(x => x.OrderPositions).Include(x => x.OrderPositions.Select(y => y.Product)).FirstOrDefault());
        }

        [HttpGet]
        public void DeleteOrderPosition(int orderPositionId)
        {
            var orderPosition = db.OrderPositions.Find(orderPositionId);

            if (orderPosition != null)
            {
                db.OrderPositions.Remove(orderPosition);
                db.SaveChanges();
            }
        }
    }
}
