using Microsoft.AspNetCore.Mvc;

using MyProject.Models;

namespace MyProject.Controllers

{

    public class CategoryController : Controller

    {

        public IActionResult Index()

        {

            var categories = new List<Category>

            {

                new Category { Id = 1, Name = "Electronics" },

                new Category { Id = 2, Name = "Clothes" },

                new Category { Id = 3, Name = "Books" }

            };

            return View(categories);

        }

    }

}
