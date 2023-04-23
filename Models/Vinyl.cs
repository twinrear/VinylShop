using System.ComponentModel;

namespace VinylShop.Models
{
    public class Vinyl
    {
        public int VinylId { get; set; }
        public string ArtistName { get; set; } = string.Empty;
        public string AlbumName { get; set;} = string.Empty;
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public string? ImageUrl { get; set; } 
        public int CategoryId { get; set; }
        public Category Category { get; set; } = default!;
    }
}
