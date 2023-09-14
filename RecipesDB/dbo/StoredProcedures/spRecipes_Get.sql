CREATE PROCEDURE [dbo].[spRecipes_Get]
	@RecipeId int
AS 
begin
	select *
	from dbo.Recipes
	where RecipeId = @RecipeId;
end