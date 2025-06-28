using RecipePlatform.Models.Entities;

namespace RecipePlatform.DAL.Repositories
{
    public interface IRecipeRepository : IRepository<Recipe>
    {
        // هنا اقدر اضيف دوال مخصصة للوصفات
        Task<IEnumerable<Recipe>> SearchAsync(string term);

    }
}
