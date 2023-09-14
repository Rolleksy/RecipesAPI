CREATE PROCEDURE [dbo].[spRecipes_Update]
	@id int,
	@recipeName nvarchar(50),
	@category nvarchar(50),
	@description nvarchar(max),
	@prepTime int,
	@servings int
AS
begin
	update dbo.Recipes
	set RecipeName = @recipeName, Category = @category, Description = @description,
		PrepTime = @prepTime, Servings = @servings
	WHERE RecipeId = @id;
end