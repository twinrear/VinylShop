using System.Reflection.Metadata.Ecma335;

namespace VinylShop.Models
{
    public class VinylRepository : IVinylRepository
    {
        private readonly VinylShopDbContext _context;

        public VinylRepository(VinylShopDbContext context)
        {
            _context = context;
        }

        IEnumerable<Vinyl> IVinylRepository.AllVinyls => _context.Vinyls.ToList();

        IEnumerable<Vinyl> IVinylRepository.VinylsOfTheWeek => _context.Vinyls.Where(x => x.IsVinylOfTheWeek);

        Vinyl? IVinylRepository.GetVinylById(int vinylId)
        {
            return _context.Vinyls.FirstOrDefault(x => x.VinylId == vinylId);
        }
    }
}
