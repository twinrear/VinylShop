namespace VinylShop.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly VinylShopDbContext _context;

        public CategoryRepository(VinylShopDbContext context)
        {
            _context = context;
        }

        IEnumerable<Category> ICategoryRepository.AllCategories => _context.Categories.ToList();
    }
}
