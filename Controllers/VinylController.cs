using Microsoft.AspNetCore.Mvc;
using VinylShop.Models;

namespace VinylShop.Controllers
{
    public class VinylController : Controller
    {
        private readonly IVinylRepository vinylRepository;
        private readonly ICategoryRepository categoryRepository;

        public VinylController(IVinylRepository vinylRepository, ICategoryRepository categoryRepository)
        {
            this.vinylRepository = vinylRepository;
            this.categoryRepository = categoryRepository;
        }   

        public IActionResult List()
        {
            return View(vinylRepository.AllVinyls);
        }
    }
}
