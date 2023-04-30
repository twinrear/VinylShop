using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace VinylShop.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
