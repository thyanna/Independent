namespace KitchenAidTool
{
    partial class VideoRecipeAdditionPage
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
            this.DataEntry = new System.Windows.Forms.TextBox();
            this.RecipeName = new System.Windows.Forms.Button();
            this.InstructionsBox = new System.Windows.Forms.TextBox();
            this.Material = new System.Windows.Forms.Button();
            this.MaterialsDone = new System.Windows.Forms.Button();
            this.ChooseFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DataEntry
            // 
            this.DataEntry.Location = new System.Drawing.Point(36, 118);
            this.DataEntry.Name = "DataEntry";
            this.DataEntry.Size = new System.Drawing.Size(392, 26);
            this.DataEntry.TabIndex = 1;
            this.DataEntry.TextChanged += new System.EventHandler(this.DataEntry_TextChanged);
            // 
            // RecipeName
            // 
            this.RecipeName.Location = new System.Drawing.Point(36, 150);
            this.RecipeName.Name = "RecipeName";
            this.RecipeName.Size = new System.Drawing.Size(159, 32);
            this.RecipeName.TabIndex = 2;
            this.RecipeName.Text = "Next";
            this.RecipeName.UseVisualStyleBackColor = true;
            this.RecipeName.Click += new System.EventHandler(this.RecipeName_Click);
            // 
            // InstructionsBox
            // 
            this.InstructionsBox.Location = new System.Drawing.Point(36, 22);
            this.InstructionsBox.Multiline = true;
            this.InstructionsBox.Name = "InstructionsBox";
            this.InstructionsBox.ReadOnly = true;
            this.InstructionsBox.Size = new System.Drawing.Size(392, 76);
            this.InstructionsBox.TabIndex = 3;
            this.InstructionsBox.Text = "Type the recipe\'s name below, then hit the Next button. ";
            this.InstructionsBox.TextChanged += new System.EventHandler(this.InstructionsBox_TextChanged);
            // 
            // Material
            // 
            this.Material.Location = new System.Drawing.Point(36, 148);
            this.Material.Name = "Material";
            this.Material.Size = new System.Drawing.Size(159, 34);
            this.Material.TabIndex = 4;
            this.Material.Text = "Next";
            this.Material.UseVisualStyleBackColor = true;
            this.Material.Visible = false;
            this.Material.Click += new System.EventHandler(this.Material_Click);
            // 
            // MaterialsDone
            // 
            this.MaterialsDone.Location = new System.Drawing.Point(323, 150);
            this.MaterialsDone.Name = "MaterialsDone";
            this.MaterialsDone.Size = new System.Drawing.Size(78, 32);
            this.MaterialsDone.TabIndex = 5;
            this.MaterialsDone.Text = "Done";
            this.MaterialsDone.UseVisualStyleBackColor = true;
            this.MaterialsDone.Visible = false;
            this.MaterialsDone.Click += new System.EventHandler(this.MaterialsDone_Click);
            // 
            // ChooseFile
            // 
            this.ChooseFile.Location = new System.Drawing.Point(238, 150);
            this.ChooseFile.Name = "ChooseFile";
            this.ChooseFile.Size = new System.Drawing.Size(143, 32);
            this.ChooseFile.TabIndex = 6;
            this.ChooseFile.Text = "Choose File";
            this.ChooseFile.UseVisualStyleBackColor = true;
            this.ChooseFile.Visible = false;
            this.ChooseFile.Click += new System.EventHandler(this.ChooseFile_Click);
            // 
            // VideoRecipeAdditionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 244);
            this.Controls.Add(this.ChooseFile);
            this.Controls.Add(this.MaterialsDone);
            this.Controls.Add(this.Material);
            this.Controls.Add(this.InstructionsBox);
            this.Controls.Add(this.RecipeName);
            this.Controls.Add(this.DataEntry);
            this.Name = "VideoRecipeAdditionPage";
            this.Text = "Add Video Recipe ";
            this.Load += new System.EventHandler(this.TextRecipeAdditionPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DataEntry;
        private System.Windows.Forms.Button RecipeName;
        private System.Windows.Forms.TextBox InstructionsBox;
        private System.Windows.Forms.Button Material;
        private System.Windows.Forms.Button MaterialsDone;
        private System.Windows.Forms.Button ChooseFile;
    }
}