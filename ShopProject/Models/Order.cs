using ShopProject.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShopProject.Models
{
    
    public class Order : IOrder
    {
        public int Id { get; set; }
        public int CartId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }

        public DateTime OrderDate { get; set; } = DateTime.Now;

        public Order() { }

        public Order(int cartId,
                     string customerName,
                     string customerAddress,
                     string customerEmail,
                     string customerPhone)
        {
            this.CartId = cartId;

            this.CustomerName = customerName;

            this.CustomerAddress = customerAddress;

            this.CustomerEmail = customerEmail;

            this.CustomerPhone = customerPhone;

            this.OrderDate = DateTime.Now;
        }
    }
}
