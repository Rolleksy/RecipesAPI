CREATE PROCEDURE [dbo].[spRecipes_Delete]
	@Id int
AS
begin
	delete
	from dbo.Recipes
	where RecipeId = @Id;
end