CREATE PROCEDURE [dbo].[spRecipes_Delete]
	@RecipeId int
AS
begin
	delete
	from dbo.Recipes
	where RecipeId = @RecipeId;
end