using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenAidTool
{
    public class RecipeManager
    {
        DatabaseManager m_database = new DatabaseManager();

        public Boolean AddRecipe(Recipe recipeData ) //UI manager calls this class 
        { 
            Boolean success = false;
            m_database.StoreRecipe(recipeData); 

            return success; 
        }

        public Boolean RemoveRecipe(string recipeName)
        {
            Boolean success = false;
            success = m_database.RemoveRecipe(recipeName);

            return success; 
        }

        public List<string> LoadRecipeList()
        {
            return m_database.RetrieveRecipeList(); 
        }
        //Retrieve Recipe data from database  
        public List<List<string>> LoadRecipe(string recipeName)
        {
            List<string> type = new List<string>(); 
            List<List<string>> recipeData = new List<List<string>>(); 
            //See if recipe is in list

            if (m_database.QueryForRecipe(recipeName))  //if recipe is in database
            {
                recipeData.Add(m_database.RetrieveMaterials(recipeName));
                recipeData.Add(m_database.RetrieveIngredients(recipeName));

                if( m_database.CheckRecipeType(recipeName) == "True" ) //text recipe
                {
                    recipeData.Add(m_database.RetrieveSteps(recipeName));

                    type.Add("Text");
                    recipeData.Add(type); 
                }
                else //video recipe 
                {
                    type.Add("Video");
                    recipeData.Add(type);
                    type.Clear(); 
                    type.Add(m_database.RetrieveVideoPath(recipeName)); 
                    recipeData.Add(type);
                }
            }
            //else Recipe not in database
       
            return recipeData;
        }

    }
}
