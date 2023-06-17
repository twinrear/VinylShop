using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
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

        public IActionResult Home()
        {
			return View(vinylRepository.AllVinyls);
		}

        public IActionResult List()
        {
            return View(vinylRepository.AllVinyls);
        }

        public IActionResult AddNewVinyl(string albumName, string artistName, decimal price, string description, bool isVinylOfWeek, string category, string ImageUrl) 
        {
            if(!albumName.IsNullOrEmpty() && !artistName.IsNullOrEmpty() && !description.IsNullOrEmpty() && !category.IsNullOrEmpty() &&
                price != 0 && !ImageUrl.IsNullOrEmpty())
            {
                var vinyl = new Vinyl();
                vinyl.AlbumName = albumName;
                vinyl.ArtistName = artistName;
                vinyl.Price = price;
                vinyl.Description = description;
                vinyl.IsVinylOfTheWeek = isVinylOfWeek;
                vinyl.CategoryId = context.Categories.Where(x => x.CategoryName == category).Select(x => x.CategoryId).FirstOrDefault();
                vinyl.ImageUrl = ImageUrl;

                context.Vinyls.Add(vinyl);
                context.SaveChanges();
            }
            return View(categoryRepository.AllCategories);
		}
    }
}
