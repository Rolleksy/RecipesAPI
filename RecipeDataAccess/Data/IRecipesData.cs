using RecipeDataAccess.Models;

namespace RecipeDataAccess.Data
{
    public interface IRecipesData
    {
        Task DeleteRecipe(int id);
        Task<RecipeModel?> GetRecipe(int id);
        Task<RecipeModel?> GetRecipeByName(string name);
        Task<IEnumerable<RecipeModel>> GetRecipes();
        Task InsertRecipe(RecipeModel newRecipe);
        Task UpdateRecipe(RecipeModel recipe);
    }
}