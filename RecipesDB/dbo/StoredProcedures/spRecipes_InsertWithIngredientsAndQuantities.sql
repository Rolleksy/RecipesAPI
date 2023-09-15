CREATE PROCEDURE [dbo].[spRecipes_InsertWithIngredientsAndQuantities]
    @recipeName NVARCHAR(50),
    @category NVARCHAR(50),
    @description NVARCHAR(MAX),
    @prepTime INT,
    @servings INT,
    @ingredientData NVARCHAR(MAX)  -- Przekazywanie danych w formie JSON lub XML
AS
BEGIN
    DECLARE @RecipeId INT;

    -- Dodaj przepis do tabeli Recipes
    INSERT INTO [dbo].[Recipes] ([RecipeName], [Category], [Description], [PrepTime], [Servings])
    VALUES (@recipeName, @category, @description, @prepTime, @servings);

    -- Pobierz ID ostatnio dodanego przepisu
    SET @RecipeId = SCOPE_IDENTITY();

    -- Parsuj dane o składnikach
    DECLARE @IngredientsTable TABLE
    (
        [IngredientId] INT,
        [Quantity] DECIMAL(18, 2),
        [QuantityType] NVARCHAR(20)
    );

    INSERT INTO @IngredientsTable ([IngredientId], [Quantity], [QuantityType])
    SELECT [IngredientId], [Quantity], [QuantityType]
    FROM OPENJSON(@ingredientData)
    WITH (
        [IngredientId] INT '$.IngredientId',
        [Quantity] DECIMAL(18, 2) '$.Quantity',
        [QuantityType] NVARCHAR(20) '$.QuantityType'
    );

    -- Dodaj składniki przypisane do przepisu do tabeli IngredientQuantities
    INSERT INTO [dbo].[IngredientQuantities] ([RecipeId], [IngredientId], [Quantity], [QuantityType])
    SELECT @RecipeId, [IngredientId], [Quantity], [QuantityType]
    FROM @IngredientsTable;
END
