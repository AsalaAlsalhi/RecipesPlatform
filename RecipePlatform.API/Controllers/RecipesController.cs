using Microsoft.AspNetCore.Mvc;
using RecipePlatform.Models.Entities;
using System.Collections.Generic;
using System.Linq;

namespace RecipePlatform.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RecipesController : ControllerBase
    {
        private static List<Recipe> _recipes = new List<Recipe>
        {
            new Recipe { RecipeId = 1, Title = "Shuwa", Description = "Traditional Omani dish", CreatedDate = DateTime.Now },
            new Recipe { RecipeId = 2, Title = "Kabsa", Description = "Delicious rice with meat", CreatedDate = DateTime.Now }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Recipe>> GetAll()
        {
            return Ok(_recipes);
        }

        [HttpGet("{id}")]
        public ActionResult<Recipe> GetById(int id)
        {
            var recipe = _recipes.FirstOrDefault(r => r.RecipeId == id);
            if (recipe == null) return NotFound();
            return Ok(recipe);
        }

        [HttpPost]
        public ActionResult<Recipe> Create(Recipe recipe)
        {
            recipe.RecipeId = _recipes.Max(r => r.RecipeId) + 1;
            recipe.CreatedDate = DateTime.Now;
            _recipes.Add(recipe);
            return CreatedAtAction(nameof(GetById), new { id = recipe.RecipeId }, recipe);
        }
    }
}
