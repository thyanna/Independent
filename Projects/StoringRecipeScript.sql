--INSERT INTO RECIPE (RecipeName, TextRecipe, RecipeTime) 
--VALUES ('Hot Cocoa', 1, 60 )

--Delete  FROM Recipe Where RecipeID is Not NULL;

--SELECT RecipeName
--FROM Recipe

--INSERT INTO Ingredients (IngredientDescription, RecipeID ) 
--VALUES ('2 tbls Hot Cocoa', (SELECT RecipeID
--						           FROM Recipe
--						           WHERE RecipeName = 'Hot Cocoa') )

--INSERT INTO Videos (VideoPath, RecipeID ) 
--VALUES ('C:\Users\Chan\Videos\videoRecipeTest.mp4', (SELECT RecipeID
--						                                                            FROM Recipe
						                                                   --         WHERE RecipeName = 'Hot Cocoa') )

--INSERT INTO Materials (MaterialDescription, RecipeID ) 
--VALUES ('1 Mug', (SELECT RecipeID
--						           FROM Recipe
--						           WHERE RecipeName = 'Hot Cocoa') )

--INSERT INTO Steps (StepDescription, StepIndex, RecipeID ) 
--VALUES ('Hot Cocoa Step 3', 3, (SELECT RecipeID
--						      FROM Recipe
--						      WHERE RecipeName = 'Hot Cocoa') )

Select *
FROM Videos