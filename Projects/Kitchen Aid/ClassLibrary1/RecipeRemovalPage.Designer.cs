namespace KitchenAidTool
{
    partial class RecipeRemovalPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Instructions = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.RecipeList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Instructions
            // 
            this.Instructions.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Instructions.Location = new System.Drawing.Point(51, 44);
            this.Instructions.Name = "Instructions";
            this.Instructions.Size = new System.Drawing.Size(397, 108);
            this.Instructions.TabIndex = 0;
            this.Instructions.Text = "Select the recipe from list that you want to delete, then click the delete button" +
    ". ";
            this.Instructions.Click += new System.EventHandler(this.Instructions_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.LightSlateGray;
            this.Delete.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(299, 190);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(127, 64);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // RecipeList
            // 
            this.RecipeList.FormattingEnabled = true;
            this.RecipeList.ItemHeight = 20;
            this.RecipeList.Location = new System.Drawing.Point(56, 144);
            this.RecipeList.Name = "RecipeList";
            this.RecipeList.Size = new System.Drawing.Size(173, 164);
            this.RecipeList.TabIndex = 3;
            this.RecipeList.SelectedIndexChanged += new System.EventHandler(this.RecipeList_SelectedIndexChanged);
            // 
            // RecipeRemovalPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 342);
            this.Controls.Add(this.RecipeList);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Instructions);
            this.Name = "RecipeRemovalPage";
            this.Text = "RecipeRemovalPage";
            this.Load += new System.EventHandler(this.RecipeRemovalPage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Instructions;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.ListBox RecipeList;
    }
}