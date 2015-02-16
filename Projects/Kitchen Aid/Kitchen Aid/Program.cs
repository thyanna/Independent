using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using KitchenAidTool; 

namespace KitchenAid
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Testing Text input 
            //TextRecipe test = new TextRecipe();

            //List<string> and = new List<string>(); 
            
            //and.Add("Place Gram Cracker on plate.");
            //and.Add("Place Marshmallow on Gram Cracker.");
            //and.Add("Place plate in microwave for 10 seconds.");
            //and.Add("Remove plate from microwave.");
            //and.Add("Place chocolate on warm Marshmallow.");
            //and.Add("Push Gram Cracker on chocolate.");

            //test.setSteps(and);

            //int a = 0;

            //Testing Database manager
            //DatabaseManager test = new DatabaseManager();
            //List<string> des = new List<string>();
            //des = test.RetrieveSteps("Smores");
            //des = test.RetrieveMaterials("Smores");
            //des = test.RetrieveIngredients("Smores");
            //string path = test.RetrieveVideoPath("Smores");
            //Boolean exist = test.QueryForRecipe("Bacon");
            //exist = test.QueryForRecipe("Smores");

            //int g = 0; 

            //Testing TextRecipe 
            //TextRecipe smores = new TextRecipe( "Smores" ); 
           // DatabaseManager test = new DatabaseManager();
            //List<string> des = new List<string>();
            //des = test.RetrieveSteps("Smores");
            //des = test.RetrieveIngredients("Smores");
            //smores.setIngredients(des);
            //Boolean fail = test.StoreRecipe(smores);

            //Testing emergency contact 
            //test.StoreEmergencyContact("5415705748"); 

            //des.Clear(); 

            //Testing TextRecipe and DatabaseManager relationship 
            //TextRecipe salmon = new TextRecipe("Salmon");
            //des.Add("Step s 1");
            //des.Add("Step s 2");
            //des.Add("Step s 3"); 
            //salmon.setSteps(des);
            //salmon.setTime(60); 

            //des.Clear(); 
            //des.Add("A pinch of salt");
            //des.Add("Olive oil");
            //salmon.setIngredients(des);

            //des.Clear();
            //des.Add("1 Frying pan");
            //des.Add("1 Spatula");
            //des.Add("1 Long sleeve shirt");
            //salmon.setMaterials(des);
            //fail = test.StoreRecipe(salmon);
            //des.Clear(); 

            //des = test.RetrieveSteps("Salmon");

            //int a = 0; 

            //testing pantry
            RecipeManager test = new RecipeManager();
            test.LoadRecipe("Smores"); 

        }
    }
}
