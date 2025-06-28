using RecipePlatform.DAL.Repositories;
using RecipePlatform.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecipePlatform.DAL;

namespace RecipePlatform.BLL.Services
{
    public class RecipeService : IRecipeService
    {
        private readonly IRecipeRepository _recipeRepository;
        private readonly RecipeDbContext _context;  

        public RecipeService(IRecipeRepository recipeRepository, RecipeDbContext context)
        {
            _recipeRepository = recipeRepository;
            _context = context;
        }

        public async Task<IEnumerable<Recipe>> GetAllRecipesAsync()
        {
            return await _recipeRepository.GetAllAsync();
        }

        public async Task<Recipe> GetRecipeByIdAsync(int id)
        {
            return await _recipeRepository.GetByIdAsync(id);
        }

        public async Task AddRecipeAsync(Recipe recipe)
        {
            await _recipeRepository.AddAsync(recipe);
        }

        public async Task UpdateRecipeAsync(Recipe recipe)
        {
            await _recipeRepository.UpdateAsync(recipe);
        }

        public async Task DeleteRecipeAsync(int id)
        {
            await _recipeRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Recipe>> SearchRecipesAsync(string term)
        {
            return await _recipeRepository.SearchAsync(term);
        }

        // تحقق من وجود المستخدم
        public async Task<bool> UserExistsAsync(string userId)
        {
            return await _context.Users.AnyAsync(u => u.Id == userId);
        }

        // تحقق من وجود التصنيف
        public async Task<bool> CategoryExistsAsync(int categoryId)
        {
            return await _context.Categories.AnyAsync(c => c.CategoryId == categoryId);
        }
    }
}
