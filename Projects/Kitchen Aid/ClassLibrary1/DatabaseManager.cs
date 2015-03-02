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
        //Check for recipe existence must already be made 
        public string CheckRecipeType( string recipeName)
        {
            string type = "";

            string query = "SELECT TextRecipe ";
            query = query + "FROM RECIPE ";
            query = query + "WHERE RECIPE.RecipeName = '" + recipeName + "' ";

            using (SqlConnection sqlConn = new SqlConnection(GetConnectionString()))
            using (SqlCommand cmd = new SqlCommand(query, sqlConn))
            {
                sqlConn.Open();
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());

                foreach (DataRow row in dt.Rows)
                {
                    type = (row["TextRecipe"].ToString());
                }
               
            }
            return type;
        }
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
                        query = "INSERT INTO Videos (VideoPath, RecipeID ) ";
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
        public List<string> RetrieveRecipeList()
        {
            List<string> recipeList = new List<string>();

            string query = "SELECT RecipeName ";
            query = query + "FROM RECIPE";

            using (SqlConnection sqlConn = new SqlConnection(GetConnectionString()))
            using (SqlCommand cmd = new SqlCommand(query, sqlConn))
            {
                sqlConn.Open();
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());

                foreach (DataRow row in dt.Rows)
                {
                    recipeList.Add(row["RecipeName"].ToString());
                }
            }
            return recipeList;
        }
        public Boolean StoreEmergencyContact( string number, string emergencyMessage )
        {
            Boolean success = false;
            string query = "";
            List<string> executionList = new List<string>();

            //Open for extension but not precisely closed for modification 
            if (QueryForEmergencyContact())
            {
                query = "UPDATE EmergencyContact SET ContactNumber = '" + number + "', EmergencyMessage = '" + emergencyMessage + "' ";
                query = query + "WHERE firstIndex = 0";
            }
            else
            {
                query = "INSERT INTO EmergencyContact VALUES ( '" + number + "','" + emergencyMessage + "', 0 )";
            }
            
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
           Boolean success = false;
           string query = "";
           string recipeType = "";
           int recipeId = 0; 
           List<string> executionList = new List<string>();

            //Get recipe ID
           query = "SELECT RecipeID, TextRecipe FROM RECIPE WHERE RecipeName = '" + recipeName + "'";

           using (SqlConnection sqlConn = new SqlConnection(GetConnectionString()))
           using (SqlCommand cmd = new SqlCommand(query, sqlConn))
           {
               sqlConn.Open();
               DataTable dt = new DataTable();
               dt.Load(cmd.ExecuteReader());

               foreach (DataRow row in dt.Rows) //should only be one 
               {
                   recipeId = (int)row["RecipeID"];
                   recipeType = row["TextRecipe"].ToString();
               }
               
           }

           query = "Delete FROM Materials WHERE RecipeID = " + recipeId;
           executionList.Add(query);
           query = "Delete FROM Ingredients WHERE RecipeID = " + recipeId;
           executionList.Add(query);

           if( recipeType == "True")//text recipe
                query = "Delete FROM Steps WHERE RecipeID = " + recipeId;
           else
                query = "Delete FROM Videos WHERE RecipeID = " + recipeId;
           executionList.Add(query);

           query = "Delete FROM Recipe WHERE RecipeID = " + recipeId;
           executionList.Add(query);

           ExecuteStorage(executionList);  //needs to return boolean 
           success = true;

           return success;
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

        public List<string> RetrieveEmergencyContact()
        {
            List<string> temp = new List<string>(); 
            string query = "SELECT * " + "FROM EmergencyContact ";

            using (SqlConnection sqlConn = new SqlConnection(GetConnectionString()))
            using (SqlCommand cmd = new SqlCommand(query, sqlConn))
            {
                sqlConn.Open();
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());

                foreach (DataRow row in dt.Rows)
                {
                    temp.Add(row["ContactNumber"].ToString());
                    temp.Add(row["EmergencyMessage"].ToString());
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
        //Data Source=(LocalDB)\v11.0;AttachDbFilename="C:\Users\Chan\Documents\Senior Project\Independent\Projects\Kitchen Aid\Kitchen Aid\KitchenAidDatabase.mdf";Integrated Security=True;Connect Timeout=30
        
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
