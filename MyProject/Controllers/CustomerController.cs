using Microsoft.AspNetCore.Mvc;
using MyProject.Models;

namespace MyProject.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {

            var customers = new List<Customer>

            {

                new Customer { Id = 1, Name = "Ali", Email = "ali@email.com" },

                new Customer { Id = 2, Name = "Sara", Email = "sara@email.com" },

                new Customer { Id = 3, Name = "Nora", Email = "nora@email.com" }
            };




            return View(customers);

        }



    }
}


