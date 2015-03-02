using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; 

namespace KitchenAidTool
{
    public partial class VideoRecipeAdditionPage : Form
    {
        RecipeManager recipeManager = new RecipeManager(); 
        List<string> dataCollection = new List<string>();
        char placementCheck = 'm';
        VideoRecipe recipeData;
        StringBuilder listAddition = new StringBuilder();

        public VideoRecipeAdditionPage()
        {
            InitializeComponent();
        }

        private void TextRecipeAdditionPage_Load(object sender, EventArgs e)
        { }

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
                recipeData = new VideoRecipe(recipeName);
                RecipeName.Visible = false;
                DataEntry.Clear();
                MaterialsPrep(); //Set UI visbilities
            }
        }

        private void Material_Click(object sender, EventArgs e)
        {
            string storeMaterial = "";

            listAddition.Append(QtyBox.Text + " ");
            storeMaterial = QtyBox.Text + " ";

            if (ListLabel.Text == "Ingredients List") //Only Ingredients have Unit inputs 
            {
                listAddition.Append(UnitBox.Text + " ");
                storeMaterial = UnitBox.Text + " ";
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
                    TimePrep(); 
                    
                }
                else if (placementCheck == 't') //If time hasn't been added, add.  
                {
                    int value = 0; 
                    if (int.TryParse(DescriptionBox.Text, out value))
                    {
                        recipeData.setTime(int.Parse(DescriptionBox.Text));
                        VideoPrep(); 
                        
                    }
                    else
                        InstructionsBox.Text = "Value entered must be given in digits (ex. 30) for a 30 minute recipe.";
                }                 

            }

        }

        private void ChooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfileDlg = new OpenFileDialog();
            if (openfileDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                DataEntry.Text = openfileDlg.FileName;
            }

            string test = Path.GetFileName(openfileDlg.FileName); 
            //copy file into local directory    
            System.IO.File.Copy(DataEntry.Text, Environment.CurrentDirectory + "\\VideoFiles\\" + Path.GetFileName(openfileDlg.FileName), true);
            recipeData.setVideoPath(Path.GetFileName(openfileDlg.FileName)); 
            recipeManager.AddRecipe(recipeData);
            ChooseFile.Hide();
            DataEntry.Hide();
            MaterialsDone.Hide(); 
            InstructionsBox.Text = "Recipe Entered. Exit screen to return to the main menu.";
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
        private void VideoPrep()
        {
            DescriptionBox.Hide();
            Description.Hide();
            DataEntry.Visible = true;
            ChooseFile.Visible = true; 

            Description.Location = new Point(Description.Location.X - 90, Description.Location.Y);
            DescriptionBox.Location = new Point(DescriptionBox.Location.X - 90, DescriptionBox.Location.Y);

            DescriptionBox.AutoSize = false;
            DescriptionBox.Size = new System.Drawing.Size(DescriptionBox.Size.Width + 90, DescriptionBox.Size.Height);

            InstructionsBox.Text = "Browse directory and select the recipe video instructions.";
        }
        private void TimePrep()
        {
            QtyBox.Hide();
            Qty.Hide();
            UnitBox.Hide();
            Unit.Hide(); 
            ListBox.Hide();
            ListLabel.Hide();
            Material.Hide();

            Description.Location = new Point(Description.Location.X - 90, Description.Location.Y);
            DescriptionBox.Location = new Point(DescriptionBox.Location.X - 90, DescriptionBox.Location.Y);

            placementCheck = 't';
            DescriptionBox.Text = "";
            Description.Text = "Time";
            InstructionsBox.Text = "Enter the time, in minutes, that the recipe will take (ex. 120)";
        }

        private void InstructionsBox_Click(object sender, EventArgs e)
        {

        }
    }
}
