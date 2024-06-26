﻿namespace BookApplication.WebApi.Models.BookCategoryModels
{
    public class BookCategoryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SlugName { get; set; }
        public string ImagePath { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
}
