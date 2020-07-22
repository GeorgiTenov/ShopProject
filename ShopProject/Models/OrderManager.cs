using ShopProject.Models.DataContext;
using ShopProject.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopProject.Models
{
    public class OrderManager : IOrderManager
    {
        private readonly ShopContext _db;

        public OrderManager(ShopContext db)
        {
            _db = db;
        }

        public Order GetOrderByClientEmail(string email)
        {
            var order = _db.GetAllOrders()
                        .FirstOrDefault(o => o.CustomerEmail == email);

            if(order == null)
            {
                return new Order(0, "not-found", "not found", "not found", "not found");
            }

            return order;
        }

        public Order GetOrderByClientPhone(string phone)
        {
            var order = _db.GetAllOrders().FirstOrDefault(o => o.CustomerPhone.Equals(phone));

            if(order == null)
            {
                return new Order(0, "not-found", "not found", "not found", "not found");
            }

            return order;
        }

        public Order GetOrderById(int id)
        {
            var order = _db.GetAllOrders().FirstOrDefault(o => o.Id == id);

            if(order == null)
            {
                return new Order(0, "not-found", "not found", "not found", "not found");
            }

            return order;
        }

        public List<Order> GetOrdersByClientsAddress(string address)
        {
            var orders = _db.GetAllOrders().Where(o => o.CustomerAddress.Equals(address));

            if(orders == null)
            {
                throw new Exception("Not found Orders via email address");
            }

            return orders.ToList();
        }

        public List<Order> GetOrdersByClientsName(string clientName)
        {
            var orders = _db.GetAllOrders().Where(o => o.CustomerName.Equals(clientName));

            if (orders == null)
            {
                throw new Exception("Not found Orders via email address");
            }

            return orders.ToList();
        }

        public List<Order> GetOrdersByDate(DateTime date)
        {
            var orders = _db.GetAllOrders().Where(o => o.OrderDate == date);

            if (orders == null)
            {
                throw new Exception("Not found Orders via email address");
            }

            return orders.ToList();
        }

        public void RemoveAllOrders()
        {
            _db.Orders.RemoveRange(_db.Orders);

            _db.SaveChanges();
        }

        public void RemoveOrder(Order order)
        {
            _db.Orders.Remove(order);

            _db.SaveChanges();
        }
    }
}
