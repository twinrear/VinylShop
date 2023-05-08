namespace VinylShop.Models
{
    public interface IVinylRepository
    {
        IEnumerable<Vinyl> AllVinyls {  get; }
        IEnumerable<Vinyl> VinylsOfTheWeek { get; }
        Vinyl? GetVinylById(int vinylId);
    }
}
