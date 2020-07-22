using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShopProject.Models;
using ShopProject.Models.DataContext;

namespace ShopProject.Controllers
{
    public class OrderManagerController : Controller
    {

        private OrderManager _manager;

        public OrderManagerController(OrderManager manager)
        {
            _manager = manager;
        }
        public IActionResult Index(string name)
        {
            List<Order> orders = new List<Order>();
            if (name != null)
            {
                orders = _manager.GetOrdersByClientsName("Georgi");
            }
           
            return View();
        }
    }
}