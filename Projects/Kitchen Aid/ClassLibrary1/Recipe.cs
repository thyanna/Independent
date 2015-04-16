using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenAidTool
{
    public abstract class Recipe
    {
        protected string mName = "";
        protected List<string> mIngredients = new List<string>();
        protected List<string> mMaterials = new List<string>();
        protected int mTime = 0; 

        public Recipe( string name )
        { mName = name; }

        public abstract Boolean CheckTextRecipe();
        //public abstract List<string> getSteps();
        //public abstract void setSteps(List<string> Steps);
        public abstract List<string> getIngredients();
        public abstract void setIngredients(List<string> Ingredients);
        public abstract List<string> getMaterials();
        public abstract void setMaterials(List<string> Materials);
        public abstract int getTime();
        public abstract void setTime(int Time);
        public abstract string getName();

        //Add diagram 
        public virtual string getVideoPath()
        {
            return "Error: Recipe type not declared.";
        }
        public virtual List<string> getSteps()
        {
            List<string> temp = new List<string>();

            temp.Add("Error:Recipe type not declared.");
            return temp; 
        }

    }
}
