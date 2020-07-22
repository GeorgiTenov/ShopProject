using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopProject.Models.DataContext
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions options) : base(options) 
        { 
            
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<CartItem> CartItems { get; set; }

        
        public DbSet<Order> Orders { get; set; }


      
        public void AddProduct(Product product)
        {
            this.Products.Add(product);
            this.SaveChanges();
            
        }

        public void RemoveProduct(Product product)
        {
            this.Products.Remove(product);
            this.SaveChanges();
        }

        public void RemoveAllProducts()
        {
            this.Products.RemoveRange(this.Products);
            this.SaveChanges();
        }

        public List<Product> GetAllProducts()
        {
            return this.Products.ToList();
        }

        public void AddCartItem(CartItem item)
        {
            this.CartItems.Add(item);
            this.SaveChanges();
        }

        public void RemoveCartItem(CartItem item)
        {
            this.CartItems.Remove(item);
            this.SaveChanges();
        }

        public void RemoveAllCartItems()
        {
            this.CartItems.RemoveRange(this.CartItems);
            this.SaveChanges();
        }

        public List<CartItem> GetAllItems()
        {
            return this.CartItems.ToList();
        }

        public void AddOrder(Order order)
        {
            this.Orders.Add(order);

            this.SaveChanges();
        }

        public void RemoveOrder(Order order)
        {
            this.Orders.Remove(order);

            this.SaveChanges();
        }

        public List<Order> GetAllOrders()
        {
            return this.Orders.ToList();
        }
    }
}
