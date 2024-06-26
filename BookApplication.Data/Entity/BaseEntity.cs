﻿namespace BookApplication.Data.Entity
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime? CreatedDate { get; set; } = DateTime.Now;
        public DateTime? UpdateDate { get; set; } = DateTime.Now;
        public bool? IsActive { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
