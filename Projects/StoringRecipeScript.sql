--INSERT INTO RECIPE (RecipeName, TextRecipe, RecipeTime) 
--VALUES ('Hot Cocoa', 1, 60 )

--SELECT *
--FROM Ingredients 


--INSERT INTO Ingredients (IngredientDescription, RecipeID ) 
--VALUES ('Something else 2', (SELECT RecipeID
--						           FROM Recipe
--						           WHERE RecipeName = 'Pot Roast') )

--INSERT INTO Videos (VideoPath, RecipeID ) 
--VALUES ('C:\Users\Chan\Videos\videoRecipeTest.mp4', (SELECT RecipeID
--						                                                            FROM Recipe
						                                                   --         WHERE RecipeName = 'Hot Cocoa') )

--INSERT INTO Materials (MaterialDescription, RecipeID ) 
--VALUES ('2 thing', (SELECT RecipeID
--						           FROM Recipe
--						           WHERE RecipeName = 'Pot Roast') )

--INSERT INTO Steps (StepDescription, StepIndex, RecipeID ) 
--VALUES ('step3', 3, (SELECT RecipeID
--						      FROM Recipe
--						      WHERE RecipeName = 'Pot Roast') )

--Select *
--FROM Videos