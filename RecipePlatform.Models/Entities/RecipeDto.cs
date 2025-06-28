using System;

namespace RecipePlatform.MVC.Models
{
    public class RecipeDto
    {
        public int RecipeId { get; set; }  // مهم يكون عندك لتحديث وحذف
        public string Title { get; set; }
        public string Description { get; set; }
        public string Ingredients { get; set; }
        public string Instructions { get; set; }
        public int PrepTimeMinutes { get; set; }
        public int CookTimeMinutes { get; set; }
        public int Servings { get; set; }
        public int Difficulty { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UserId { get; set; }
        public int CategoryId { get; set; }
    }
}
