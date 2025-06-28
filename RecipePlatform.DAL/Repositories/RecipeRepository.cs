using RecipePlatform.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace RecipePlatform.DAL.Repositories
{
    public class RecipeRepository : IRecipeRepository
    {
        private readonly RecipeDbContext _context;

        public RecipeRepository(RecipeDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Recipe>> GetAllAsync()
        {
            return await _context.Recipes
                .Include(r => r.User)
                .Include(r => r.Category)
                .ToListAsync();
        }

        public async Task<Recipe> GetByIdAsync(int id)
        {
            return await _context.Recipes
                .Include(r => r.User)
                .Include(r => r.Category)
                .FirstOrDefaultAsync(r => r.RecipeId == id);
        }

        public async Task<IEnumerable<Recipe>> SearchAsync(string term)
        {
            return await _context.Recipes
                .Where(r => r.Title.Contains(term) || r.Description.Contains(term))
                .ToListAsync();
        }


        public async Task AddAsync(Recipe recipe)
        {
            await _context.Recipes.AddAsync(recipe);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Recipe recipe)
        {
            _context.Recipes.Update(recipe);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var recipe = await _context.Recipes.FindAsync(id);
            if (recipe != null)
            {
                _context.Recipes.Remove(recipe);
                await _context.SaveChangesAsync();
            }
        }
    }
}
