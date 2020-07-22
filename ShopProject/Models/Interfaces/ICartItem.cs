using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopProject.Models.Interfaces
{
    public interface ICartItem
    {
        int Id { get; set; }

        int CartId { get; set; }

        Product Product { get; set; }
        
        int Amount { get; set; }
    }
}
