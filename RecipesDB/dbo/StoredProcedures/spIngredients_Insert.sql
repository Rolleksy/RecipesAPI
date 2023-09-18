CREATE PROCEDURE [dbo].[spIngredients_Insert]
	@recipeId int,
	@ingredientId int,
	@quantity int,
	@quantityType nvarchar(50)
AS
begin
	Insert into RecipeIngredients (recipeId, ingredientId) values (@recipeId, @ingredientId);
	Insert into IngredientQuantities (RecipeId, IngredientId, Quantity, QuantityType) values (@recipeId, @ingredientId, @quantity, @quantityType)
end