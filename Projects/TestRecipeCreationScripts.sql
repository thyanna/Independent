--SELECT StepDescription, StepIndex
--FROM RECIPE JOIN STEPS ON RECIPE.RecipeID = STEPS.RecipeID 
--WHERE RECIPE.RecipeName = 'Smores' 
--ORDER BY StepIndex

--SELECT IngredientDescription
--FROM RECIPE JOIN Ingredients ON Recipe.RecipeID = Ingredients.RecipeID 

--SELECT *
--FROM Recipe

SELECT TextRecipe
FROM RECIPE
WHERE RecipeName = 'Smores'

--SELECT MaterialDescription
--FROM RECIPE JOIN Materials ON Recipe.RecipeID = Materials.RecipeID 

--SELECT VideoPath
--FROM RECIPE JOIN VIDEOS ON Recipe.RecipeID = VIDEOS.RecipeID 