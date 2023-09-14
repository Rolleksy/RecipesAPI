using RecipeDataAccess.DbAccess;
using System.Runtime.CompilerServices;

namespace RecipesAPI
{
    public static class API
    {
        public static void ConfigureApi(this WebApplication app)
        {
            app.MapGet("/Recipes", GetRecipes);
            app.MapGet("/Recipes/ById/{id}", GetRecipe);
            app.MapGet("/Recipes/ByName/{RecipeName}", GetByName);
            app.MapPost("/Recipes", InsertRecipe);
            app.MapPut("/Recipes", UpdateRecipe);
            app.MapDelete("/Recipes", DeleteRecipe);
        }

        private static async Task<IResult> DeleteRecipe(int RecipeId, IRecipesData data)
        {
            try
            {
                await data.DeleteRecipe(RecipeId);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
        private static async Task<IResult> UpdateRecipe(IRecipesData data, RecipeModel recipe)
        {
            try
            {
                await data.UpdateRecipe(recipe);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> InsertRecipe(IRecipesData data, RecipeModel recipe)
        {
            try
            {
                await data.InsertRecipe(recipe);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> GetRecipes(IRecipesData data)
        {
            try
            {
                return Results.Ok(await data.GetRecipes());
            }
            catch (Exception ex)
            {

                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> GetRecipe(IRecipesData data, int RecipeId)
        {
            try
            {
                var results = await data.GetRecipe(RecipeId);
                if (results == null) return Results.NotFound();
                return Results.Ok(results);
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }


        private static async Task<IResult> GetByName(string RecipeName, IRecipesData data)
        {
            try
            {
                var results = await data.GetRecipeByName(RecipeName);
                if (results == null) return Results.NotFound(); 
                return Results.Ok(results);
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

    }
}
