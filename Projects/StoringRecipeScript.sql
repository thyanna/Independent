--INSERT INTO RECIPE (RecipeName, TextRecipe, RecipeTime) 
--VALUES ('Smores', 1, 15 )

--Delete  FROM Recipe Where RecipeID is Not NULL;

--INSERT INTO Ingredients (IngredientDescription, RecipeID ) 
--VALUES ('2 Gram Crackers', (SELECT RecipeID
--						           FROM Recipe
--						           WHERE RecipeName = 'Smores') )

--INSERT INTO Videos (VideoPath, RecipeID ) 
--VALUES ('C:\Users\Chan\Documents\Visual Studio 2013\Projects\Kitchen Aid\Smores', (SELECT RecipeID
--						                                                            FROM Recipe
--						                                                            WHERE RecipeName = 'Smores') )

--INSERT INTO Materials (MaterialDescription, RecipeID ) 
--VALUES ('1 Fork', (SELECT RecipeID
--						           FROM Recipe
--						           WHERE RecipeName = 'Smores') )

--INSERT INTO Steps (StepDescription, StepIndex, RecipeID ) 
--VALUES ('Testing step 1', 1, (SELECT RecipeID
--						      FROM Recipe
--						      WHERE RecipeName = 'Smores') )