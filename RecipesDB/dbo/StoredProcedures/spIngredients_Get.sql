CREATE PROCEDURE [dbo].[spIngredients_Get]
	@recipeId int
AS
begin
	SELECT I.Name AS IngredientName, IQ.Quantity, IQ.QuantityType
	FROM IngredientQuantities IQ
	INNER JOIN Ingredients I ON IQ.IngredientId = I.IngredientId
	WHERE IQ.RecipeId = @recipeId;
end
