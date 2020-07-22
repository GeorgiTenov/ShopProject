using ShopProject.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopProject.Models.Interfaces
{
    public interface IProduct
    {
        int Id { get; set; }

        string Name { get; set; }

        string Description { get; set; }

        Category Category { get; set; }

        string PicturePath { get; set; }

        decimal Price { get; set; }
    }
}
