using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenAidTool
{
    public class TextRecipe : Recipe
    {
        List<string> mSteps = new List<string>();

        public TextRecipe(string name): base(name) {}

        public override Boolean CheckTextRecipe()
        {
            return true; 
        }
        public List<string> getSteps()
        {
            return mSteps; 
        }
        public void setSteps(List<string> Steps)
        {
            foreach( string step in Steps)
            {
                mSteps.Add(step);
            }
        }

        public override List<string> getIngredients()
        {
            return mIngredients;
        }
        public override void setIngredients(List<string> Ingredients)
        {
            foreach (string ingredient in Ingredients )
            {
                mIngredients.Add(ingredient);
            }
        }

        public override List<string> getMaterials()
        {
            return mMaterials;
        }
        public override void setMaterials(List<string> Materials)
        {
            foreach (string material in Materials)
            {
                mMaterials.Add(material);
            }
        }

        public override int getTime()
        {
            return mTime;
        }
        public override void setTime(int Time)
        {
            mTime = Time; 
        }
        public override string getName()
        {
            return mName;
        }
    }
}
