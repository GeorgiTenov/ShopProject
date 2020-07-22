using ShopProject.Models.DataContext;
using ShopProject.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopProject.Models
{
    public class ShoppingCart : IShoppingCart
    {
        private readonly ShopContext _db;
        public ShoppingCart(ShopContext db)
        {
            _db = db;
        }
        public int Id { get; }

        public List<CartItem> CartItems { get; set; }

        public void AddProduct(Product product)
        {
            CartItem currentItem = _db.CartItems
                .FirstOrDefault(i => i.Product.Id == product.Id && i.CartId == this.Id);

            if(currentItem == null)
            {
                currentItem = new CartItem(this.Id, product);

                currentItem.Amount = 1;

                _db.CartItems.Add(currentItem);
               
            }
            else
            {
                currentItem.Amount++;
            }
            _db.SaveChanges();
        }

        public void RemoveProduct(Product product)
        {
            var currentItem = _db.CartItems
                .FirstOrDefault(i => i.Product.Id == product.Id && i.CartId == this.Id);

            if(currentItem != null)
            {
                if (currentItem.Amount > 1)
                {
                    currentItem.Amount--;
                }
                else
                {
                    _db.CartItems.Remove(currentItem);
                }
                _db.SaveChanges();
            }
          
        }

        public int CalculateTotalItemsCount()
        {
            int itemsCount = 0;

            foreach (var item in GetAllItems())
            {
                itemsCount += item.Amount;
            }

            return  itemsCount;
        }

        public decimal CalculateTotalPrice()
        {
            decimal totalPrice = 0;

            foreach(var item in this.CartItems)
            {
                if(item.Product != null)
                {
                    totalPrice += item.Product.Price * item.Amount;
                }
               
            }

            return totalPrice;
        }

        public void RemoveAllItems()
        {
            var allCartItems =_db.CartItems;

            _db.CartItems.RemoveRange(allCartItems);

            _db.SaveChanges();
        }

        public List<CartItem> GetAllItems()
        {
            var allItems = _db.CartItems.Where(i => i.CartId == this.Id).ToList();

            this.CartItems = allItems;

            return this.CartItems;
        }

        public List<CartItem> ItemsDetails()
        {
            this.CartItems = _db.GetAllItems();
            foreach (var item in this.CartItems)
            {
                item.Product = _db.GetAllProducts()
                               .FirstOrDefault(p => p.Id == item.Product.Id);
            }

            return this.CartItems;
        }
    }
}
