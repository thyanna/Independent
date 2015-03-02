--SELECT StepDescription, StepIndex
--FROM RECIPE JOIN STEPS ON RECIPE.RecipeID = STEPS.RecipeID 
--WHERE RECIPE.RecipeName = 'Hot Cocoa' 
--ORDER BY StepIndex

--SELECT IngredientDescription
--FROM RECIPE JOIN Ingredients ON Recipe.RecipeID = Ingredients.RecipeID 

--INSERT INTO EmergencyContact (ContactNumber, EmergencyMessage )
--values ('Default', 'Default Message')

SELECT *
FROM Recipe

--SELECT ContactNumber, EmergencyMessage, EmergencyContactID
--FROM EmergencyContact
--WHERE EmergencyContactID = 2

--SELECT MaterialDescription
--FROM RECIPE JOIN Materials ON Recipe.RecipeID = Materials.RecipeID 

--SELECT VideoPath
--FROM RECIPE JOIN VIDEOS ON Recipe.RecipeID = VIDEOS.RecipeID 