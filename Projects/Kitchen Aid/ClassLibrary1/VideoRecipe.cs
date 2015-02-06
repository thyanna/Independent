using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenAidTool
{
    class VideoRecipe: Recipe
    {
         string mVideoPath = "";

        public VideoRecipe(string name): base(name) {}

        public override Boolean CheckTextRecipe()
        {
            return false; 
        }
        public string getVideoPath()
        {
            return mVideoPath; 
        }
        public void setVideoPath(string videoPath)
        {
            mVideoPath = videoPath; 
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
