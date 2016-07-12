using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCApp.Models;

namespace MVCApp.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            var products = new List<Product>();
            products.Add(new Product()
            {
                ProductID = 1,
                Name = "Шариковая ручка",
                Category = "Канцтовары"
            });
            products.Add(new Product()
            {
                ProductID = 2,
                Name = "Бумага А4",
                Category = "Канцтовары"
            });
            products.Add(new Product()
            {
                ProductID = 3,
                Name = "Мобильный телефон",
                Category = "Техника"
            });
            return View(products);
        }
    }
}