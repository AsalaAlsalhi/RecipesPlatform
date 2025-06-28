using System.Collections.Generic;
using RecipePlatform.Models.Entities;

namespace RecipePlatform.Models.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }

        public ICollection<Recipe> Recipes { get; set; }
    }
}
