using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkingWithVisualStudio.Models;
using Microsoft.AspNetCore.Mvc;



namespace WorkingWithVisualStudio.Controllers
{
    public class HomeController : Controller
    {
        public IRepository Repository { get; set; } = SimpleRepository.SharedRepository;
        public IActionResult Index() =>
            View(Repository.Products);

        [HttpGet]
        public IActionResult AddProduct() => View(new Product());

        [HttpPost]
        public IActionResult AddProduct(Product p)
        {
            Repository.AddProduct(p);
            return RedirectToAction("Index");
        }
    }
}
