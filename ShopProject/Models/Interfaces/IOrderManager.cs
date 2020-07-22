using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopProject.Models.Interfaces
{
    public interface IOrderManager
    {
        Order GetOrderById(int id);

        List<Order> GetOrdersByClientsName(string clientName);

        List<Order> GetOrdersByClientsAddress(string address);

        List<Order> GetOrdersByDate(DateTime date);

        Order GetOrderByClientEmail(string email);

        Order GetOrderByClientPhone(string phone);

        void RemoveOrder(Order order);

        void RemoveAllOrders();
    }
}
