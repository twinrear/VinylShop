using Microsoft.AspNetCore.Mvc;
using VinylShop.Models;

namespace VinylShop.Controllers
{
    public class VinylController : Controller
    {
        private readonly IVinylRepository vinylRepository;
        private readonly ICategoryRepository categoryRepository;
        private readonly VinylShopDbContext context;

        public VinylController(IVinylRepository vinylRepository, ICategoryRepository categoryRepository, VinylShopDbContext vinylShopDbContext)
        {
            this.vinylRepository = vinylRepository;
            this.categoryRepository = categoryRepository;
            this.context = vinylShopDbContext;
        }   

        public IActionResult List()
        {
            return View(vinylRepository.AllVinyls);
        }

        public IActionResult AddNewVinyl() 
        {
   //         var vinyl = new Vinyl();
			//vinyl.AlbumName = Request.Form["AlbumName"];
			//vinyl.ArtistName = Request.Form["ArtistName"];
			//vinyl.Price = decimal.Parse(Request.Form["Price"]);
			//vinyl.Description = Request.Form["Description"];
			//vinyl.IsVinylOfTheWeek = Request.Form.ContainsKey("VinylOfTheWeek");
			//vinyl.CategoryId = int.Parse(Request.Form["CategoryId"]);

			//context.Vinyls.Add(vinyl);
   //         context.SaveChanges();

            return View(categoryRepository.AllCategories);
		}

        [HttpPost]
        public IActionResult AddVinyl()
        {
            return RedirectToAction("List", "Vinyl");
        }
    }
}
