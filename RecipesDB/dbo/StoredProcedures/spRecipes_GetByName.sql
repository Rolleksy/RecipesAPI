CREATE PROCEDURE [dbo].[spRecipes_GetByName]
	@RecipeName Nvarchar(max)
AS 
begin
	select *
	from dbo.[Recipes]
	where recipeName = @RecipeName;
end