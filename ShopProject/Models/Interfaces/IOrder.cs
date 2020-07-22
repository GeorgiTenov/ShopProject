using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopProject.Models.Interfaces
{
    public interface IOrder
    {
        int Id { get; set; }

        int CartId { get; set; }

        string CustomerName { get; set; }

        string CustomerAddress { get; set; }

        string CustomerEmail { get; set; }

        string CustomerPhone {get;set;}

        DateTime OrderDate { get; set; }
    }
}
