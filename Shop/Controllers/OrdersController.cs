using System.Data;
using System.Data.Entity;
using System.Linq;
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
        
        public void OrderPositionCount(int orderPositionId,int orderPositionCount)
        {
            var orderPosition = db.OrderPositions.Find(orderPositionId);
            var _orderPositionCount = db.OrderPositions.Find(orderPositionCount);
            
            if (orderPosition != null)
            {
                orderPosition.Count = orderPositionCount;
                db.SaveChanges();
            }
        }

        public void ConfirmOrder(int orderId, int orderTotalSum)
        {
            var _orderId = db.Orders.Find(orderId);
            var _orderTotalSum = db.Orders.Find(orderTotalSum);

            if (_orderId != null)
            {
                _orderId.TotalSum = orderTotalSum;
                db.SaveChanges();
            }
        }
    }
}
