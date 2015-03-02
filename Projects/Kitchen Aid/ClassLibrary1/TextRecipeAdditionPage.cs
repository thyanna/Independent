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
        StringBuilder listAddition = new StringBuilder(); 

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
                MaterialsPrep(); //Set UI visbilities
            }
        }

        private void Material_Click(object sender, EventArgs e)
        {
            string storeMaterial = "";

            if (ListLabel.Text != "Steps List")  //Steps do not have Qty or Unit inputs
            {
                listAddition.Append(QtyBox.Text + " ");
                storeMaterial = QtyBox.Text + " ";

                if (ListLabel.Text == "Ingredients List") //Only Ingredients have Unit inputs 
                {
                    listAddition.Append(UnitBox.Text + " ");
                    storeMaterial = UnitBox.Text + " ";
                }
            }

            listAddition.Append(DescriptionBox.Text); //All three (steps, ingredients, materials) have Description inputs
            storeMaterial += DescriptionBox.Text; 

            dataCollection.Add(storeMaterial);
            listAddition.Append(Environment.NewLine);
            ListBox.Text = listAddition.ToString(); 
        }

        private void MaterialsDone_Click(object sender, EventArgs e)
        {
            if (ListBox.Text != "" )  //user must enter data  before moving forward 
            {
                if (placementCheck == 'm') //If materials haven't been added, add. 
                {
                    recipeData.setMaterials(dataCollection);
                    dataCollection.Clear();
                    IngredientsPrep();
                }
                else if (placementCheck == 'i') //If ingredients haven't been added, add.
                {
                    recipeData.setIngredients(dataCollection);
                    dataCollection.Clear();
                    StepsPrep(); 
                }
                else if (placementCheck == 's') //If steps haven't been added, add. 
                {
                    recipeData.setSteps(dataCollection);
                    TimePrep(); 
                }
                else  //If time hasn't been added, add. 
                {
                    int value = 0; 
                    if (int.TryParse(DescriptionBox.Text, out value))
                    {
                        recipeData.setTime(int.Parse(DescriptionBox.Text));
                        DescriptionBox.Hide();
                        Description.Hide();
                        MaterialsDone.Hide(); 
                        recipeManager.AddRecipe(recipeData); 
                        InstructionsBox.Text = "Recipe Entered. Exit screen to return to the main menu.";
                        
                    }
                    else
                        InstructionsBox.Text = "Value entered must be given in digits (ex. 30) for a 30 minute recipe.";
                }
            }

        }

        private void IngredientsPrep()
        {
            UnitBox.Visible = true;
            Unit.Visible = true;
            listAddition.Clear();
            placementCheck = 'i';
            ListBox.Text = "";
            QtyBox.Text = "";
            DescriptionBox.Text = "";
            ListLabel.Text = "Ingredients List";
            InstructionsBox.Text = "Enter in each ingredient that is needed to complete the recipe (Qty: 1 Unit: tsp Description: Salt). Hit Done when there are no more ingredients.";
        }
        private void MaterialsPrep()
        {
            InstructionsBox.Text = "Enter in each material needed to complete the recipe (Ex. Qty: 1 Description: Fork). Hit Done when there are no more materials to add.";
            Material.Visible = true;
            MaterialsDone.Visible = true;
            QtyBox.Visible = true;
            Qty.Visible = true;
            DescriptionBox.Visible = true;
            Description.Visible = true;
            ListBox.Visible = true;
            ListLabel.Visible = true;
            DataEntry.Visible = false;
        }
        private void StepsPrep()
        {
            QtyBox.Visible = false;
            Qty.Visible = false;
            UnitBox.Visible = false;
            Unit.Visible = false;
            Description.Location = new Point(Description.Location.X - 90, Description.Location.Y);
            DescriptionBox.Location = new Point(DescriptionBox.Location.X - 90, DescriptionBox.Location.Y);
            DescriptionBox.AutoSize = false;
            DescriptionBox.Size = new System.Drawing.Size(DescriptionBox.Size.Width + 90, DescriptionBox.Size.Height);

            listAddition.Clear();
            placementCheck = 's';
            ListBox.Text = "";
            DescriptionBox.Text = "";
            ListLabel.Text = "Steps List";
            InstructionsBox.Text = "In order, enter in each step to complete the recipe (Ex. Mix salt in flour for 30 seconds). Hit Done when there are no more steps.";
        }
        private void TimePrep()
        {
            DescriptionBox.Text = "";
            ListBox.Hide();
            ListLabel.Hide();
            Material.Hide();
            placementCheck = 't';
            Description.Text = "Time";
            InstructionsBox.Text = "Enter the time, in minutes, that the recipe will take (ex. 120)";
        }

        private void QtyBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void UnitBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void DescriptionBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void InstructionsBox_Click(object sender, EventArgs e)
        {

        }
    }
}
