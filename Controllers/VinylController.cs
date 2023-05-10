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

        public IActionResult AddNewVinyl(string albumName, string artistName, decimal price, string description, bool isVinylOfWeek, string category) 
        {
            var vinyl = new Vinyl();
            vinyl.AlbumName = albumName;
            vinyl.ArtistName = artistName;
            vinyl.Price = price;
            vinyl.Description = description;
            vinyl.IsVinylOfTheWeek = Request.Form.ContainsKey("VinylOfTheWeek");
            vinyl.CategoryId = int.Parse(Request.Form["CategoryId"]);

            context.Vinyls.Add(vinyl);
            context.SaveChanges();

            return View(categoryRepository.AllCategories);
		}

        [HttpPost]
        public IActionResult AddVinyl()
        {
            return RedirectToAction("List", "Vinyl");
        }
    }
}
