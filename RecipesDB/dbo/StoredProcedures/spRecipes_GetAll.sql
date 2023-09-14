CREATE PROCEDURE [dbo].[spRecipes_GetAll]

AS
begin
	select *
	from dbo.Recipes;
end