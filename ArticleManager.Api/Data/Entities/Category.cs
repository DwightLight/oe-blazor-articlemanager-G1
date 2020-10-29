﻿using System.ComponentModel.DataAnnotations;

namespace ArticleManager.Api.Data.Entities
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
