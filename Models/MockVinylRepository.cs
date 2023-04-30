namespace VinylShop.Models
{
    public class MockVinylRepository : IVinylRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();
        public IEnumerable<Vinyl> AllVinyls => new List<Vinyl>
        {
            new Vinyl{ VinylId = 1, CategoryId = 1, ArtistName = "The Beatles", AlbumName = "White Album", Description = "One of the best The Beatles albums",
                Price = 10M, ImageUrl="https://upload.wikimedia.org/wikipedia/commons/thumb/2/20/TheBeatles68LP.jpg/250px-TheBeatles68LP.jpg", 
                Category = _categoryRepository.AllCategories.ToList()[0], IsVinylOfTheWeek = false},
            new Vinyl{ VinylId = 2, CategoryId = 2, ArtistName = "Mac Demarko", AlbumName = "This Old Dog", Description = "We all love Mac",
                Price = 10M, ImageUrl="https://upload.wikimedia.org/wikipedia/en/5/5e/MacDeMarcoThisOldDog.png", 
                Category = _categoryRepository.AllCategories.ToList()[1], IsVinylOfTheWeek = true}
        };

        public IEnumerable<Vinyl> VinylsOfTheWeek => AllVinyls.Where(p => p.IsVinylOfTheWeek);

        public Vinyl? GetVinylById(int vinylId) => AllVinyls.FirstOrDefault(p => p.VinylId == vinylId);
    }
}
