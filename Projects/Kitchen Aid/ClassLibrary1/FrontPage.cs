using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics; 

namespace KitchenAidTool
{
    public partial class FrontPage : Form
    {
        public FrontPage()
        {
            InitializeComponent();
        }

        private void FrontPage_Load(object sender, EventArgs e)
        {

        }

        private void TextRecipe_Click(object sender, EventArgs e)
        {
            TextRecipeAdditionPage additionForm = new TextRecipeAdditionPage();
            this.Hide();
            additionForm.ShowDialog();
            this.Show();
        }

        private void VideoRecipe_Click(object sender, EventArgs e)
        {
            VideoRecipeAdditionPage additionForm = new VideoRecipeAdditionPage();
            this.Hide();
            additionForm.ShowDialog();
            this.Show();
        }

        private void RemoveRecipe_Click(object sender, EventArgs e)
        {
            RecipeRemovalPage additionForm = new RecipeRemovalPage();
            this.Hide();
            additionForm.ShowDialog();
            this.Show();
        }

        private void EmergencyContact_Click(object sender, EventArgs e)
        {
            EmergencyContactAlterationPage additionForm = new EmergencyContactAlterationPage();
            this.Hide();
            additionForm.ShowDialog();
            this.Show();
        }

        private void StartCooking_Click(object sender, EventArgs e)
        {
            RecipeCompletionPage completionForm = new RecipeCompletionPage();
            this.Hide();
            completionForm.ShowDialog();
            this.Show();
        }

    }
}
