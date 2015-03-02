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
    public partial class RecipeCompletionPage : Form
    {
        RecipeManager recipeManager = new RecipeManager();
        List<List<string>> selectedRecipe = new List<List<string>>();
        EmergencyContactManager emergencyContact = new EmergencyContactManager(); 
        int stepIndex; 

        public RecipeCompletionPage()
        {
            InitializeComponent();
            axWindowsMediaPlayer1.Visible = false; 
        }

        private void RecipeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string recipeName = RecipeListBox.SelectedItem.ToString();
            selectedRecipe = recipeManager.LoadRecipe(recipeName);
            Instructions.Text = "Click on all the items you have. If you don't have them all, click on the 'x' above and pick a different recipe.";
            RecipeListBox.Visible = false;
            MaterialsCheck.Visible = true;

            //Fill Material check box
            foreach (string material in selectedRecipe[0])
            {
                MaterialsCheck.Items.Add(material);
            }
        }

        private void RecipeCompletionPage_Load(object sender, EventArgs e)
        {
            List<string> recipeList = new List<string>();
            List<List<string>> recipe = new List<List<string>>();
            Instructions.Text = "Select a recipe from the list below by clicking on it. If you ever feel like you really need help, click on the 'Help' ->";

            recipeList = recipeManager.LoadRecipeList();

            foreach (string recipeName in recipeList)
            {
                RecipeListBox.Items.Add(recipeName);
            }
        }

        private void MaterialsCheck_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if( MaterialsCheck.CheckedIndices.Count == MaterialsCheck.Items.Count)
            {
                Instructions.Text = "Click on all the ingredients you have. If you don't have them all, click on the 'x' above and pick a different recipe.";
                MaterialsCheck.Visible = false;
                IngredientsCheck.Visible = true; 

                //Fill Ingredient check box
                foreach (string ingredient in selectedRecipe[1])
                {
                    IngredientsCheck.Items.Add(ingredient);
                }
            }
        }

        private void IngredientsCheck_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IngredientsCheck.CheckedIndices.Count == IngredientsCheck.Items.Count)
            {
                IngredientsCheck.Visible = false;
                FirstStep.Visible = true; 

                if (selectedRecipe[3][0] == "Text" ) //text recipe
                {
                    //show first step, 'next' button click will direct next step
                    Instructions.Text = "When you finish the directions below, hit the 'next' button to get the next step.";
                    FirstStep.Text = selectedRecipe[2][stepIndex++];
                    FirstStep.Visible = true;
                    NextStep.Visible = true; 
                 }
                else //video recipe 
                {
                    Instructions.Text = "When you hit the 'play' button below, a video will walk you through the recipe. Make sure everything is ready first.";
                    PlayVideo.Visible = true;
                    FirstStep.Visible = false; 
                    axWindowsMediaPlayer1.Visible = true; 
                    
                }
               
            }
        }

        private void NextStep_Click(object sender, EventArgs e)
        {
            if (stepIndex == selectedRecipe[2].Count)
            {
                RecipeCompleteText.Visible = true;
                EmergencyContact.Visible = false; 
                FirstStep.Visible = false;
                Instructions.Visible = false; 
                NextStep.Hide();
            }
            else
                FirstStep.Text = selectedRecipe[2][stepIndex++];

        }

        private void FirstStep_TextChanged(object sender, EventArgs e)
        {
            //do nothing 
        }

        private void EmergencyContact_Click(object sender, EventArgs e)
        {
            emergencyContact.InitiateEmergencyContact();
            axWindowsMediaPlayer1.Ctlcontrols.stop(); 
            RecipeCompleteText.Text = Environment.NewLine + "Help is on its way! If there is a fire, get out of the house."; 
            RecipeCompleteText.Visible = true;
            RecipeCompleteText.BringToFront(); 
 
        }

        private void PlayVideo_Click(object sender, EventArgs e)
        {
            Instructions.Visible = false;
            PlayVideo.Visible = false;
            EmergencyContact.Visible = false;

            //Creating link to watch the Window Media Player's state... is not working. 
          //  axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(axWindowsMediaPlayer1_PlayStateChange);
            axWindowsMediaPlayer1.URL = Environment.CurrentDirectory + "\\VideoFiles\\" + selectedRecipe[2][0];
            axWindowsMediaPlayer1.Ctlcontrols.play();
            EmergencyContact.Visible = true;
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
        //private void axWindowsMediaPlayer1_PlayStateChange( object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        //{
        //    if (e.newState == 8) //If video has reached the end 
        //    { 
        //        RecipeCompleteText.Text = Environment.NewLine + Environment.NewLine + "Congratulations, you've completed the recipe!";
        //        RecipeCompleteText.BringToFront();
        //    }
        //    else if( e.newState == 1 ) //If video has been stopped
        //    {
        //        axWindowsMediaPlayer1.close(); 
        //    }
        //}
    }

}
