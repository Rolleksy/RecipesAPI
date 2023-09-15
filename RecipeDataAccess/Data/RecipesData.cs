using RecipeDataAccess.DbAccess;
using RecipeDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeDataAccess.Data
{
    public class RecipesData : IRecipesData
    {
        private readonly ISqlDataAccess _db;

        public RecipesData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<IEnumerable<RecipeModel>> GetRecipes() =>
            _db.LoadData<RecipeModel, dynamic>("spRecipes_GetAll", new { });

        public async Task<RecipeModel?> GetRecipe(int id)
        {
            var results = await _db.LoadData<RecipeModel, dynamic>(
                "spRecipes_Get", new { recipeId = id });
            return results.FirstOrDefault();
        }

        public Task InsertRecipe(RecipeModel newRecipe) =>
            _db.SaveData("spRecipes_Insert",
                         new { newRecipe.recipeName, newRecipe.category, newRecipe.description, newRecipe.prepTime, newRecipe.servings });

        public Task UpdateRecipe(RecipeModel recipe) =>
            _db.SaveData("spRecipes_Update", recipe);

        public Task DeleteRecipe(int id) =>
            _db.SaveData("spRecipes_Delete", new { RecipeId = id });

        public async Task<RecipeModel?> GetRecipeByName(string name)
        {
            var recipe = await _db.LoadData<RecipeModel, dynamic>(
                "spRecipes_GetByName", new { RecipeName = name });
            return recipe.FirstOrDefault();
        }

        public async Task<List<IngredientsModel?>> GetRecipesIngredients(int recipeId)
        {
            var ingredients = await _db.LoadData<IngredientsModel?, dynamic>(
        "spRecipes_GetRecipeWithIngredients", new { RecipeId = recipeId });

            return ingredients.ToList();
        }

      /*  public Task InsertWithIngredients(RecipeWithIngre newRecipe) =>
            _db.SaveData("spRecipes_Insert",
                         new { newRecipe.recipe , newRecipe.ingreList });*/
    }
}
