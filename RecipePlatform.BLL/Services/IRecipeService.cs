using RecipePlatform.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RecipePlatform.BLL.Services
{
    public interface IRecipeService
    {
        Task<IEnumerable<Recipe>> GetAllRecipesAsync();
        Task<Recipe> GetRecipeByIdAsync(int id);
        Task AddRecipeAsync(Recipe recipe);
        Task UpdateRecipeAsync(Recipe recipe);
        Task DeleteRecipeAsync(int id);
        Task<IEnumerable<Recipe>> SearchRecipesAsync(string term);

        //  الدالتين للتحقق
        Task<bool> UserExistsAsync(string userId);
        Task<bool> CategoryExistsAsync(int categoryId);
    }
}
