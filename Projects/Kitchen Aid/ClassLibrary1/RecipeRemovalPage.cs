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
    public partial class RecipeRemovalPage : Form
    {
        RecipeManager recipeManager = new RecipeManager();
        public RecipeRemovalPage()
        {
            InitializeComponent();
        }

        private void RecipeRemovalPage_Load(object sender, EventArgs e)
        {
            List<string> recipeList = new List<string>(); 

            recipeList = recipeManager.LoadRecipeList();

            foreach (string recipeName in recipeList)
            {
                RecipeList.Items.Add(recipeName);
            }
        }

        private void RecipeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string test = RecipeList.SelectedItem.ToString(); 
            Boolean success = recipeManager.RemoveRecipe( RecipeList.SelectedItem.ToString() );
            Delete.Hide();
            RecipeList.Hide(); 

            if (success)
            {
                Instructions.Text = "Recipe has been deleted. Exit screen to return to main menu.";
            }
            else
                Instructions.Text = "Recipe could not be deleted. Contact admin through email provided in the help tab on main page.";
        }

        private void Instructions_Click(object sender, EventArgs e)
        {

        }
    }
}
