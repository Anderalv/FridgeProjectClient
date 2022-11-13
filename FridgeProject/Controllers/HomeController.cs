using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FridgeProject.Models;

namespace FridgeProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AllFridges()
        {
            return View();
        }
        public IActionResult AllProducts()
        {
            return View();
        }
        public IActionResult CreateFridge()
        {
            return View();
        } 
        public IActionResult EditFridge()
        {
            return View();
        }
        public IActionResult CreateProduct()
        {
            return View();
        }
        public IActionResult EditProduct()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}