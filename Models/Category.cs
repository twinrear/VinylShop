﻿namespace VinylShop.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public string? CategoryDescription { get; set; }
        public List<Vinyl>? Vinyls { get; set; }
    }
}
