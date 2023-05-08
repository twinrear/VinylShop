using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VinylShop.Models;

namespace VinylShop.Controllers
{
    public class HomeController : Controller
    {
		private readonly VinylController _vinylController;

		public HomeController(VinylController vinylController)
		{
			_vinylController = vinylController;
		}

		public IActionResult Index()
        {
			IEnumerable<Vinyl>? vinyls = (_vinylController.List() as ViewResult).Model as IEnumerable<Vinyl>;
			return View(vinyls);
        }
    }
}
