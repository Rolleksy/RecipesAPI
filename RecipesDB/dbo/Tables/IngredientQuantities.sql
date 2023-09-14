CREATE TABLE [dbo].[IngredientQuantities]
(
	RecipeId INT,
    IngredientId INT,
    Primary KEY (RecipeId, IngredientId),
    Foreign key (RecipeId) References Recipes(RecipeId),
    Foreign key (IngredientId) References Ingredients(IngredientId),
    Quantity INT, -- Przechowuje ilość składnika
    QuantityType NVARCHAR(20)
)
