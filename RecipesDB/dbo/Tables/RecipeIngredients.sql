CREATE TABLE [dbo].[RecipeIngredients]
(
	[RecipeId] INT,
	[IngredientId] INT,
	PRIMARY KEY (RecipeId, IngredientId),
	FOREIGN KEY (RecipeId) REFERENCES Recipes(RecipeId),
	FOREIGN KEY (IngredientId) REFERENCES Ingredients(IngredientId)
)
