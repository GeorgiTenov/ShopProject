using ShopProject.Models.Enums;
using ShopProject.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace ShopProject.Models
{
    public class Product : IProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
        public string PicturePath { get; set; }
        public decimal Price { get; set; }

        public Product() { }

        public Product(string name,
                       string description,
                       Category category,
                       decimal price,
                       string picturePath ="defaultPath"
                       )
        {
            this.Name = name;

            this.Description = description;

            this.Category = category;

            this.Price = price;

            this.PicturePath = picturePath;
        }
    }
}
