CREATE TABLE [dbo].[Recipes]
(
	[RecipeId] INT NOT NULL PRIMARY KEY IDENTITY,
	[RecipeName] NVARCHAR(50) NOT NULL,
	[Category] NVARCHAR(50) NULL,
	[Description] NVARCHAR(MAX) NOT NULL,
	[PrepTime] INT,
	[Servings] INT
)
