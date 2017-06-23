using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Shop.Models
{
    public class AddProduct : DropCreateDatabaseIfModelChanges<ShopContext>
    {
        protected override void Seed(ShopContext db)
        {
            db.Products.Add(new Product { ProductType = "Материнская плата", Price = 10000, Count = 10 });
            db.Products.Add(new Product { ProductType = "Процессор", Price = 19999, Count = 10 });
            db.Products.Add(new Product { ProductType = "Кулер", Price = 2500, Count = 25 });
            db.Products.Add(new Product { ProductType = "RAM", Price = 4999, Count = 20 });
            db.Products.Add(new Product { ProductType = "Видеокарта", Price = 24999, Count = 9 });
            db.Products.Add(new Product { ProductType = "HDD", Price = 2999, Count = 17 });
            db.Products.Add(new Product { ProductType = "SSD", Price = 3999, Count = 11 });
            db.Products.Add(new Product { ProductType = "Блок питания", Price = 1400, Count = 27 });
            db.Products.Add(new Product { ProductType = "Корпус", Price = 3700, Count = 16 });
            db.Products.Add(new Product { ProductType = "Монитор", Price = 15000, Count = 10 });
            db.Products.Add(new Product { ProductType = "Клавиатура", Price = 1400, Count = 27 });
            db.Products.Add(new Product { ProductType = "Мышь", Price = 799, Count = 30 });

            base.Seed(db);
        }
    }
}