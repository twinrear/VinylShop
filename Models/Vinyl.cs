using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VinylShop.Models
{
    public class Vinyl
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VinylId { get; set; }
        public string ArtistName { get; set; } = string.Empty;
        public string AlbumName { get; set;} = string.Empty;
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public string? ImageUrl { get; set; } 
        public bool IsVinylOfTheWeek { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; } = default!;
    }
}
