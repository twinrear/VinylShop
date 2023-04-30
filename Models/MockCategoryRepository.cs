﻿namespace VinylShop.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories => new List<Category>
        {
            new Category{CategoryId = 1, CategoryName = "Rock", CategoryDescription = "Rock music"},
            new Category{CategoryId = 2, CategoryName = "Indie", CategoryDescription = "Indie music"}
        };
    }
}
