using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShopProject.Models;
using ShopProject.Models.DataContext;

namespace ShopProject.Controllers
{
    public class OrderController : Controller
    {
        private readonly ShoppingCart _cart;

        private readonly ShopContext _db;

        public OrderController(ShoppingCart cart,ShopContext db)
        {
            _cart = cart;

            _db = db;
        }

        public IActionResult Index()
        {

            return View();
        }

        public IActionResult OrderMade(Order order)
        {
            _db.AddOrder(order);
            return View(order);
        }
    }
}