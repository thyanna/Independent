using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Data;
using System.Configuration;

namespace KitchenAidTool
{
    public class DatabaseManager
    {
        public Boolean StoreRecipe( Recipe recipe)
        {
            Boolean success = false;
            string query = "";
            int recipeType = 0; 
            List<string> executionList = new List<string>();
            string RecipeID = "(SELECT RecipeID FROM RECIPE WHERE RecipeName = '" + recipe.getName() + "' ) )";

            if (recipe.CheckTextRecipe())
                recipeType = 1; //recipe is a TextRecipe 

            //Ensuring recipe doesn't already exist in database 
            if (!QueryForRecipe(recipe.getName()))
            {
                //Adding Recipe
                query = "INSERT INTO RECIPE (RecipeName, TextRecipe, RecipeTime) ";
                query = query + "VALUES ( '" + recipe.getName() + "', " + recipeType.ToString() + ", " + recipe.getTime() + " ) ";
                executionList.Add(query);

                    foreach (string ingredient in recipe.getIngredients())
                    {
                        query = "INSERT INTO Ingredients (IngredientDescription, RecipeID ) ";
                        query = query + "VALUES ( '" + ingredient + "', " + RecipeID;
                        executionList.Add(query);
                    }
                    foreach (string material in recipe.getMaterials())
                    {
                        query = "INSERT INTO Materials (MaterialDescription, RecipeID ) ";
                        query = query + "VALUES ( '" + material + "', " + RecipeID;
                        executionList.Add(query);
                    }
                    if (recipeType == 1)
                    {
                        foreach (string step in recipe.getSteps())
                        {
                            int index = 0;

                            query = "INSERT INTO Steps (StepDescription, StepIndex, RecipeID ) ";
                            query = query + "VALUES( '" + step + "', " + index++ + ", " + RecipeID;
                            executionList.Add(query);
                        }
                    }
                    else
                    {
                        query = "INSERT INTO Video (VideoPath, RecipeID ) ";
                        query = query + "VALUES ( '" + recipe.getVideoPath() + "', " + RecipeID; ;
                        executionList.Add(query);
                    }

                ExecuteStorage(executionList);
                success = true; 
            }

            return success;
        }
        public void ExecuteStorage(List<string> ExecutionList)
        {
            foreach (string query in ExecutionList)
            {
                using (SqlConnection sqlConn = new SqlConnection(GetConnectionString()))
                using (SqlCommand cmd = new SqlCommand(query, sqlConn))
                {
                    sqlConn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public Boolean StoreEmergencyContact( string number )
        {
            Boolean success = false;
            string query = "";
            List<string> executionList = new List<string>();

            query = "INSERT INTO EmergencyContact (ContactNumber) ";
            query = query + "VALUES ( '" + number + "' ) ";
            
            using (SqlConnection sqlConn = new SqlConnection(GetConnectionString()))
            using (SqlCommand cmd = new SqlCommand(query, sqlConn))
            {
                sqlConn.Open();
                cmd.ExecuteNonQuery();
                success = true;
            }
            return success; 
        }
        public Boolean RemoveRecipe(string recipeName )
        {
            //Boolean success = false;
            //string query = "";
            //int recipeType = 0;
            //List<string> executionList = new List<string>();

            //string RecipeID = "(SELECT RecipeID FROM RECIPE WHERE RecipeName = '" + recipe.getName() + "' ) )";

            //if (recipe.CheckTextRecipe())
            //    recipeType = 1; //recipe is a TextRecipe 

            ////Ensuring recipe doesn't already exist in database 
            //if (!QueryForRecipe(recipe.getName()))
            //{
            //    //Adding Recipe
            //    query = "INSERT INTO RECIPE (RecipeName, TextRecipe, RecipeTime) ";
            //    query = query + "VALUES ( '" + recipe.getName() + "', " + recipeType.ToString() + ", " + recipe.getTime() + " ) ";
            //    executionList.Add(query);

            //    foreach (string ingredient in recipe.getIngredients())
            //    {
            //        query = "INSERT INTO Ingredients (IngredientDescription, RecipeID ) ";
            //        query = query + "VALUES ( '" + ingredient + "', (SELECT RecipeID FROM RECIPE WHERE RecipeName = '" + recipe.getName() + "' ) )";
            //        executionList.Add(query);
            //    }
            //    foreach (string material in recipe.getMaterials())
            //    {
            //        query = "INSERT INTO Materials (MaterialDescription, RecipeID ) ";
            //        query = query + "VALUES ( '" + material + "', (SELECT RecipeID FROM RECIPE WHERE RecipeName = '" + recipe.getName() + "' ) )";
            //        executionList.Add(query);
            //    }
            //    if (recipeType == 1)
            //    {
            //        foreach (string step in recipe.getSteps())
            //        {
            //            int index = 0;

            //            query = "INSERT INTO Steps (StepDescription, StepIndex, RecipeID ) ";
            //            query = query + "VALUES( '" + step + "', " + index++ + ", ( SELECT RecipeID FROM RECIPE WHERE RecipeName = '" + recipe.getName() + "' ) )";
            //            executionList.Add(query);
            //        }
            //    }
            //    else
            //    {
            //        query = "INSERT INTO Video (VideoPath, RecipeID ) ";
            //        query = query + "VALUES ( '" + recipe.getVideoPath() + "', (SELECT RecipeID FROM RECIPE WHERE RecipeName = '" + recipe.getName() + "' ) )";
            //        executionList.Add(query);
            //    }

            //    ExecuteStorage(executionList);
            //    success = true;
            //}

            //return success;
            return true;
        }

        public Boolean QueryForRecipe(string recipeName)
        {
            Boolean exist = false; 

            string query =  "SELECT RecipeID ";
            query = query + "FROM RECIPE ";
            query = query + "WHERE RECIPE.RecipeName = '" + recipeName + "' ";

            using (SqlConnection sqlConn = new SqlConnection(GetConnectionString()))
            using (SqlCommand cmd = new SqlCommand(query, sqlConn))
            {
                sqlConn.Open();
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());

                if (dt.Rows.Count == 1)
                    exist = true;
                else 
                    exist = false;
                //Same name recipe rainy day is handled during recipe insertion 

            }
            return exist;  
        }

        public Boolean QueryForEmergencyContact()
        {
            Boolean exist = false;

            string query = "SELECT EmergencyContactID ";
            query = query + "FROM EmergencyContact ";

            using (SqlConnection sqlConn = new SqlConnection(GetConnectionString()))
            using (SqlCommand cmd = new SqlCommand(query, sqlConn))
            {
                sqlConn.Open();
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());

                if (dt.Rows.Count == 1)
                    exist = true;
                else
                    exist = false;
            }
            return exist;
        }

        public string RetrieveEmergencyContact()
        {
            string temp = ""; 
            string query = "SELECT * " + "FROM EmergencyContact ";

            using (SqlConnection sqlConn = new SqlConnection(GetConnectionString()))
            using (SqlCommand cmd = new SqlCommand(query, sqlConn))
            {
                sqlConn.Open();
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());

                foreach (DataRow row in dt.Rows)
                {
                    temp = (row["ContactNumber"].ToString());
                }

            }
            return temp;
        }

        public List<string> RetrieveIngredients( string recipeName )
        {
            List<string> temp = new List<string>();

            string query = "SELECT IngredientId, IngredientDescription ";
            query = query + "FROM RECIPE JOIN INGREDIENTS ON RECIPE.RecipeID = INGREDIENTS.RecipeID ";
            query = query + "WHERE RECIPE.RecipeName = '" + recipeName + "' ";

            using (SqlConnection sqlConn = new SqlConnection(GetConnectionString()))
            using (SqlCommand cmd = new SqlCommand(query, sqlConn))
            {
                sqlConn.Open();
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());

                foreach (DataRow row in dt.Rows)
                {
                    temp.Add(row["IngredientDescription"].ToString());
                }

            }
            return temp;
        }

        public List<string> RetrieveMaterials(string recipeName)
        {
            List<string> temp = new List<string>();

            string query = "SELECT MaterialId, MaterialDescription ";
            query = query + "FROM RECIPE JOIN MATERIALS ON RECIPE.RecipeID = MATERIALS.RecipeID ";
            query = query + "WHERE RECIPE.RecipeName = '" + recipeName + "' ";

            using (SqlConnection sqlConn = new SqlConnection(GetConnectionString()))
            using (SqlCommand cmd = new SqlCommand(query, sqlConn))
            {
                sqlConn.Open();
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());

                foreach (DataRow row in dt.Rows)
                {
                    temp.Add(row["MaterialDescription"].ToString());
                }

            }
            return temp;
        }

        public List<string> RetrieveSteps(string recipeName)
        {
            List<string> temp = new List<string>();

            //Ask about injection protection 
            string query =  "SELECT StepId, StepDescription, StepIndex ";
            query = query + "FROM RECIPE JOIN STEPS ON RECIPE.RecipeID = STEPS.RecipeID ";
            query = query + "WHERE RECIPE.RecipeName = '" + recipeName + "' ";
            query = query + "ORDER BY STEPS.StepIndex";

            using (SqlConnection sqlConn = new SqlConnection(GetConnectionString()) )
            using (SqlCommand cmd = new SqlCommand(query, sqlConn))
            {
                sqlConn.Open();
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());

                foreach(DataRow row in dt.Rows)
                {
                    temp.Add( row["StepDescription"].ToString() ); 
                }
 
            }
            return temp;
        }
        public string GetConnectionString() //Needs to be extended for modification 
        { return ("Data Source=(LocalDB)\\v11.0;Initial Catalog=KitchenAidDatabase;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False"); }

        
        public string RetrieveVideoPath(string recipeName)
        {
            string temp = "";

            string query = "SELECT VideoId, VideoPath ";
            query = query + "FROM RECIPE JOIN VIDEOS ON RECIPE.RecipeID = VIDEOS.RecipeID ";
            query = query + "WHERE RECIPE.RecipeName = '" + recipeName + "' ";

            using (SqlConnection sqlConn = new SqlConnection(GetConnectionString()))
            using (SqlCommand cmd = new SqlCommand(query, sqlConn))
            {
                sqlConn.Open();
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());

                foreach (DataRow row in dt.Rows)
                {
                    temp = (row["VideoPath"].ToString());
                }

            }
            return temp;
        }
    }
}
