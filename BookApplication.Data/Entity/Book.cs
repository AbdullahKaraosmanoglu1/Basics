﻿using System.ComponentModel.DataAnnotations;

namespace BookApplication.Data.Entity
{
    public class Book : BaseEntity
    {
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(100)]
        public string Author { get; set; }
        [StringLength(50)]
        public string Language { get; set; }
        [StringLength(100)]
        public string Publisher { get; set; }
        [StringLength(500)]
        public string? ImagePath { get; set; }
        [StringLength(100)]
        public string? SlugName { get; set; }
        public int PageCount { get; set; }
        public int PrintingYear { get; set; }
        public decimal Price { get; set; }
        public bool IsHomePage { get; set; }
        public bool IsApproved { get; set; }

        public int BookCategoryId { get; set; }
        public BookCategory BookCategory { get; set; }

        public ICollection<UserBook> UserBooks { get; set; }
    }
}
