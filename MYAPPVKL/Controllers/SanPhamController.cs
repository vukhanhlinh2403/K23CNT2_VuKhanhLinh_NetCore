﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace MYAPPVKL.Controllers
{
    public class SanPhamController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>()
            {
                new Product { Id = 1, Name = "Aventador LP700", Price = 500000, CreatedAt = new DateTime(2020, 12, 25), Image = "Aventador LP700-4.jpg"  },
                new Product { Id = 2, Name = "Diablo GT-R", Price = 700000, CreatedAt = new DateTime(2020, 12, 25), Image = "Diablo GT-R.jpg " },
                new Product { Id = 3, Name = "Murcielago LP640", Price = 550000, CreatedAt = new DateTime(2020, 12, 25), Image = "Murcielago LP640.jpg" },
                new Product { Id = 4, Name = "Veneno", Price = 550000, CreatedAt = new DateTime(2020, 12, 25), Image = "Veneno.jpg" },
            };

            return View(products);
        }
    }
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Image { get; set; } = string.Empty;
    }

}
