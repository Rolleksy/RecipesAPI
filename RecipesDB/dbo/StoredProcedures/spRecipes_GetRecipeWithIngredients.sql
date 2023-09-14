CREATE PROCEDURE [dbo].[spRecipes_GetRecipeWithIngredients]
	@RecipeId INT
AS
Begin
    SELECT  I.Name, RI.Quantity, RI.QuantityType
    FROM dbo.[Ingredients] AS I
    INNER JOIN dbo.[IngredientQuantities] AS RI ON I.IngredientId = RI.IngredientId
    WHERE RI.RecipeId = @RecipeId;
end
