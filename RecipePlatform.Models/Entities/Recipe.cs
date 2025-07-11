﻿using System;
using System.Collections.Generic;
using RecipePlatform.Models.Entities;

namespace RecipePlatform.Models.Entities
{
    public enum DifficultyLevel
    {
        Easy,
        Medium,
        Hard
    }

    public class Recipe
    {
        public int RecipeId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Ingredients { get; set; }
        public string Instructions { get; set; }
        public int PrepTimeMinutes { get; set; }
        public int CookTimeMinutes { get; set; }
        public int Servings { get; set; }
        public DifficultyLevel Difficulty { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        public ICollection<Rating> Ratings { get; set; }
    }
}
