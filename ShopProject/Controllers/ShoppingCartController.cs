using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShopProject.Models;
using ShopProject.Models.DataContext;
using ShopProject.Models.Enums;

namespace ShopProject.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly ShoppingCart _cart;

        private readonly ShopContext _db;
        public ShoppingCartController(ShoppingCart cart,ShopContext db)
        {
            _cart = cart;

            _db = db;
        }
        public IActionResult Index()
        {
            //_db.RemoveAllProducts();
            _cart.CartItems = _db.GetAllItems();
           
            return View(_db.GetAllProducts());
        }

        public RedirectToActionResult Add(int id)
        {
            var product = _db.GetAllProducts().FirstOrDefault(p => p.Id == id);

            _cart.CartItems = _db.GetAllItems();

            _cart.AddProduct(product);

            decimal price = _cart.CalculateTotalPrice();

            return RedirectToAction("Index");
        }

        public RedirectToActionResult Remove(int id)
        {
            var product = _db.GetAllProducts().FirstOrDefault(p => p.Id == id);

            _cart.RemoveProduct(product);

            return RedirectToAction("Index");
        }

        public IActionResult CartDetails()
        {
            return View(_cart.ItemsDetails());
        }

        public RedirectToActionResult CartRemove(int id)
        {
            var product = _db.GetAllProducts().FirstOrDefault(p => p.Id == id);

            _cart.RemoveProduct(product);

            return RedirectToAction("CartDetails");
        }
    }
}