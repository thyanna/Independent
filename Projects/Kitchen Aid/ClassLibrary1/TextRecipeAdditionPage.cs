using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitchenAidTool
{
    public partial class TextRecipeAdditionPage : Form
    {
        RecipeManager recipeManager = new RecipeManager(); 
        List<string> dataCollection = new List<string>();
        char placementCheck = 'm';
        TextRecipe recipeData;

        public TextRecipeAdditionPage()
        {
            InitializeComponent();
        }

        private void TextRecipeAdditionPage_Load(object sender, EventArgs e)
        {

        }

        private void InstructionsBox_TextChanged(object sender, EventArgs e)
        {
            //do nothing
        }

        private void DataEntry_TextChanged(object sender, EventArgs e)
        {
            //do nothing 
        }

        private void RecipeName_Click(object sender, EventArgs e)
        {
            if (DataEntry.Text != "") //User must entry in a name to move forward 
            {
                string recipeName = DataEntry.Text;
                recipeData = new TextRecipe(recipeName);
                RecipeName.Visible = false;

                DataEntry.Clear();
                InstructionsBox.Text = "Enter in each material that is needed to complete the recipe (Ex. 1 Fork). Hit Done when there are no more materials.";
                Material.Visible = true;
                MaterialsDone.Visible = true;
            }
        }

        private void Material_Click(object sender, EventArgs e)
        {
            dataCollection.Add(DataEntry.Text);
            DataEntry.Clear(); 
        }

        private void MaterialsDone_Click(object sender, EventArgs e)
        {
            if (DataEntry.Text != "" )  //user must enter data  before moving forward 
            {
                if (placementCheck != 't') //time must be converted to an int 
                {
                    dataCollection.Add(DataEntry.Text);
                    DataEntry.Clear();
                }

                if (placementCheck == 'm') //If materials haven't been added, add. 
                {
                    recipeData.setMaterials(dataCollection);
                    dataCollection.Clear();
                    placementCheck = 'i';
                    InstructionsBox.Text = "Enter in each ingredient that is needed to complete the recipe (Ex. 1 tsp. Salt). Hit Done when there are no more ingredients.";
                }
                else if (placementCheck == 'i') //If ingredients haven't been added, add.
                {
                    recipeData.setIngredients(dataCollection);
                    dataCollection.Clear();
                    placementCheck = 's';
                    InstructionsBox.Text = "In order, enter in each step to complete the recipe (Ex. Mix salt in flour for 30 seconds). Hit Done when there are no more steps.";
                }
                else if (placementCheck == 's') //If steps haven't been added, add. 
                {
                    recipeData.setSteps(dataCollection);
                    InstructionsBox.Text = "Enter the time, in minutes, that the recipe will take (ex. 120)";
                    placementCheck = 't';
                    Material.Hide();
                }
                else  //If time hasn't been added, add. 
                {
                    int value; 
                    if (int.TryParse(DataEntry.Text, out value))
                    {
                        recipeData.setTime(int.Parse(DataEntry.Text));
                        recipeManager.AddRecipe(recipeData); 
                        InstructionsBox.Text = "Recipe Entered. Exit screen to return to the main menu.";
                        DataEntry.Hide();
                        MaterialsDone.Hide();
                    }
                    else
                        InstructionsBox.Text = "Value entered must be given in digits (ex. 30) for a 30 minute recipe.";
                }
            }

        }
    }
}
