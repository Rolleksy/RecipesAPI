CREATE PROCEDURE [dbo].[spRecipes_Insert]
	@recipeName nvarchar(50),
	@category nvarchar(50),
	@description nvarchar(max),
	@prepTime int,
	@servings int
AS
begin
	insert into dbo.Recipes (RecipeName, Category, Description, PrepTime, Servings)
	values (@recipeName, @category, @description, @prepTime, @servings);
end