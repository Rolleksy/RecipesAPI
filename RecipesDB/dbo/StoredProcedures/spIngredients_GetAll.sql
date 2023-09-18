CREATE PROCEDURE [dbo].[spIngredients_GetAll]
AS
begin
	SELECT *
	from dbo.Ingredients;
end
