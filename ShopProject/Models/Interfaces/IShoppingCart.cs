using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopProject.Models.Interfaces
{
    public interface IShoppingCart
    {
        int Id { get; }

        List<CartItem> CartItems { get; set; }

        void AddProduct(Product product);

        void RemoveProduct(Product product);

        void RemoveAllItems();

        decimal CalculateTotalPrice();

        int CalculateTotalItemsCount();

        List<CartItem> GetAllItems();


    }
}
