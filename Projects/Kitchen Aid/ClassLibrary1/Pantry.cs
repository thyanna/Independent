using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenAidTool
{
    public class Pantry 
    {
        public Boolean AddRecipe(string recipeName)
        { return true; }

        public Boolean AddMaterial( List<string> materials )
        { return true; }

        public Boolean AddIngredients(List<string> ingredients)
        { return true; }

        public Boolean AddSteps(List<string> steps)
        { return true; }

        public Boolean AddVideo(string videoPath)
        { return true; }

        public List<string> RunSteps()
        { List<string> temp = new List<string>(); return temp; }

        public string RunVideo()
        { string temp = ""; return temp; }

        public Boolean RemoveRecipe(string recipeName)
        { return true; }

        //Don't forget to set recipe index 
        public Boolean LoadRecipe(string recipeName)
        { return true; }

        //Use current index and recipe list to get name 
        //Simply hands the data up 
        public List<string> RunMaterialCheck()
        { List<string> temp = new List<string>();  return temp; }

        //Use current index and recipe list to get name 
        //Simply hands the data up 
        public List<string> RunIngredientCheck()
        { List<string> temp = new List<string>(); return temp; }

   

    }
}
