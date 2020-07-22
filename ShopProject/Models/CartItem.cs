using ShopProject.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopProject.Models
{
    public class CartItem : ICartItem
    {
        public int Id { get; set; }
        public int CartId { get; set; }
        public Product Product { get; set; }
        public int Amount { get; set; }

        public CartItem() { }

        public CartItem(int cartId,Product product)
        {
            this.CartId = cartId;

            this.Product = product;
        }
    }
}
