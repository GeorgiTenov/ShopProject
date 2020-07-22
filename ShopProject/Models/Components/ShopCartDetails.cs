using Microsoft.AspNetCore.Mvc;
using ShopProject.Models.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopProject.Models.Components
{
    public class ShopCartDetails : ViewComponent
    {
        private readonly ShoppingCart _shoppingCart;
        public ShopCartDetails(ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }

        public IViewComponentResult Invoke()
        {
            return View(_shoppingCart);
        }
    }
}
