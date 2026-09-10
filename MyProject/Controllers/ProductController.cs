using Microsoft.AspNetCore.Mvc;

using MyProject.Models;

namespace MyProject.Controllers

{

    public class ProductController : Controller

    {

        public IActionResult Index()

        {

            var products = new List<Product>

            {

                new Product { Id = 1, Name = "Laptop", Price = 3000 },

                new Product { Id = 2, Name = "Phone", Price = 2000 },

                new Product { Id = 3, Name = "Headphones", Price = 500 }

            };

            return View(products);

        }

    }

}