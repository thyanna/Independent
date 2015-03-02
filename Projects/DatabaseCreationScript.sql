USE [master]

GO
IF OBJECT_ID( 'KitchenAidDatabase' ) IS NOT NULL
BEGIN
drop database KitchenAidDatabase
create database KitchenAidDatabase
END

GO
USE [KitchenAidDatabase]

IF OBJECT_ID( 'Ingedients' ) IS NOT NULL
DROP TABLE Ingredients

GO
IF OBJECT_ID( 'EmergencyContact' ) IS NOT NULL
DROP TABLE EmergencyContact

GO
IF OBJECT_ID( 'Materials' ) IS NOT NULL
DROP TABLE Materials

GO
IF OBJECT_ID( 'Steps' ) IS NOT NULL
DROP TABLE Steps

GO
IF OBJECT_ID( 'Videos' ) IS NOT NULL
DROP TABLE Videos

Go
IF OBJECT_ID( 'Recipe' ) IS NOT NULL
DROP TABLE Recipe

GO
CREATE TABLE [dbo].[Recipe]
(
	RecipeID int NOT NULL PRIMARY KEY IDENTITY,
	RecipeName VARCHAR(30) NOT NULL,
	TextRecipe BIT NOT NULL,
	RecipeTime int NOT NULL 
)

GO
CREATE TABLE [dbo].[Ingredients]
(
	IngredientID int NOT NULL PRIMARY KEY IDENTITY,
	IngredientDescription VARCHAR(30) NOT NULL, 
	RecipeID int REFERENCES Recipe( RecipeID )
)

GO
CREATE TABLE [dbo].[Materials]
(
	MaterialID int NOT NULL PRIMARY KEY IDENTITY,
	MaterialDescription VARCHAR(30) NOT NULL,
	RecipeID int REFERENCES Recipe( RecipeID )
)

GO
CREATE TABLE [dbo].[Steps]
(
	StepID int NOT NULL PRIMARY KEY IDENTITY,
	StepDescription VARCHAR(500) NOT NULL,
	StepIndex int NOT NULL, 
	RecipeID int REFERENCES Recipe( RecipeID )
)

GO
CREATE TABLE [dbo].[Videos]
(
	VideoID int NOT NULL PRIMARY KEY IDENTITY,
	VideoPath VARCHAR(MAX) NOT NULL,
	RecipeID int REFERENCES Recipe( RecipeID ) 
)

GO
CREATE TABLE [dbo].[EmergencyContact]
(
	EmergencyContactID int NOT NULL PRIMARY KEY IDENTITY,
	ContactNumber VARCHAR(10) NOT NULL,
	EmergencyMessage VARCHAR(MAX) NOT NULL,
	firstIndex int NOT NULL
)