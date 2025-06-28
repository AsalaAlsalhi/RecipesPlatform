using System.Collections.Generic;
using RecipePlatform.Models.Entities;

namespace RecipePlatform.Models
{
    public class ApplicationUser
    {
        public string Id { get; set; }
        public string UserName { get; set; }

        public ICollection<Recipe> Recipes { get; set; }
        public ICollection<Rating> Ratings { get; set; }
    }
}
