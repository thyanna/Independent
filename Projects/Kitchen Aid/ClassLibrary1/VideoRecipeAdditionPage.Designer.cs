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
            this.Material = new System.Windows.Forms.Button();
            this.MaterialsDone = new System.Windows.Forms.Button();
            this.ChooseFile = new System.Windows.Forms.Button();
            this.InstructionsBox = new System.Windows.Forms.Label();
            this.Qty = new System.Windows.Forms.Label();
            this.Unit = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.ListLabel = new System.Windows.Forms.Label();
            this.ListBox = new System.Windows.Forms.TextBox();
            this.QtyBox = new System.Windows.Forms.TextBox();
            this.UnitBox = new System.Windows.Forms.TextBox();
            this.DescriptionBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DataEntry
            // 
            this.DataEntry.Location = new System.Drawing.Point(40, 172);
            this.DataEntry.Name = "DataEntry";
            this.DataEntry.Size = new System.Drawing.Size(392, 26);
            this.DataEntry.TabIndex = 1;
            this.DataEntry.TextChanged += new System.EventHandler(this.DataEntry_TextChanged);
            // 
            // RecipeName
            // 
            this.RecipeName.Location = new System.Drawing.Point(464, 165);
            this.RecipeName.Name = "RecipeName";
            this.RecipeName.Size = new System.Drawing.Size(159, 32);
            this.RecipeName.TabIndex = 2;
            this.RecipeName.Text = "Next";
            this.RecipeName.UseVisualStyleBackColor = true;
            this.RecipeName.Click += new System.EventHandler(this.RecipeName_Click);
            // 
            // Material
            // 
            this.Material.Location = new System.Drawing.Point(464, 164);
            this.Material.Name = "Material";
            this.Material.Size = new System.Drawing.Size(159, 34);
            this.Material.TabIndex = 4;
            this.Material.Text = "Add";
            this.Material.UseVisualStyleBackColor = true;
            this.Material.Visible = false;
            this.Material.Click += new System.EventHandler(this.Material_Click);
            // 
            // MaterialsDone
            // 
            this.MaterialsDone.Location = new System.Drawing.Point(464, 336);
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
            this.ChooseFile.Location = new System.Drawing.Point(464, 166);
            this.ChooseFile.Name = "ChooseFile";
            this.ChooseFile.Size = new System.Drawing.Size(159, 32);
            this.ChooseFile.TabIndex = 6;
            this.ChooseFile.Text = "Choose File";
            this.ChooseFile.UseVisualStyleBackColor = true;
            this.ChooseFile.Visible = false;
            this.ChooseFile.Click += new System.EventHandler(this.ChooseFile_Click);
            // 
            // InstructionsBox
            // 
            this.InstructionsBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionsBox.Location = new System.Drawing.Point(36, 13);
            this.InstructionsBox.Name = "InstructionsBox";
            this.InstructionsBox.Size = new System.Drawing.Size(500, 127);
            this.InstructionsBox.TabIndex = 7;
            this.InstructionsBox.Text = "Type the recipe\'s name below, then hit enter. ";
            this.InstructionsBox.Click += new System.EventHandler(this.InstructionsBox_Click);
            // 
            // Qty
            // 
            this.Qty.AutoSize = true;
            this.Qty.Location = new System.Drawing.Point(37, 140);
            this.Qty.Name = "Qty";
            this.Qty.Size = new System.Drawing.Size(33, 20);
            this.Qty.TabIndex = 8;
            this.Qty.Text = "Qty";
            this.Qty.Visible = false;
            // 
            // Unit
            // 
            this.Unit.AutoSize = true;
            this.Unit.Location = new System.Drawing.Point(104, 146);
            this.Unit.Name = "Unit";
            this.Unit.Size = new System.Drawing.Size(38, 20);
            this.Unit.TabIndex = 9;
            this.Unit.Text = "Unit";
            this.Unit.Visible = false;
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(171, 146);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(89, 20);
            this.Description.TabIndex = 10;
            this.Description.Text = "Description";
            this.Description.Visible = false;
            // 
            // ListLabel
            // 
            this.ListLabel.AutoSize = true;
            this.ListLabel.Location = new System.Drawing.Point(36, 204);
            this.ListLabel.Name = "ListLabel";
            this.ListLabel.Size = new System.Drawing.Size(102, 20);
            this.ListLabel.TabIndex = 11;
            this.ListLabel.Text = "Materials List";
            this.ListLabel.Visible = false;
            // 
            // ListBox
            // 
            this.ListBox.Location = new System.Drawing.Point(40, 227);
            this.ListBox.Multiline = true;
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(392, 141);
            this.ListBox.TabIndex = 12;
            this.ListBox.Visible = false;
            // 
            // QtyBox
            // 
            this.QtyBox.Location = new System.Drawing.Point(41, 172);
            this.QtyBox.Name = "QtyBox";
            this.QtyBox.Size = new System.Drawing.Size(47, 26);
            this.QtyBox.TabIndex = 13;
            this.QtyBox.Visible = false;
            // 
            // UnitBox
            // 
            this.UnitBox.Location = new System.Drawing.Point(108, 172);
            this.UnitBox.Name = "UnitBox";
            this.UnitBox.Size = new System.Drawing.Size(47, 26);
            this.UnitBox.TabIndex = 14;
            this.UnitBox.Visible = false;
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.Location = new System.Drawing.Point(175, 172);
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(257, 26);
            this.DescriptionBox.TabIndex = 15;
            this.DescriptionBox.Visible = false;
            // 
            // VideoRecipeAdditionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 380);
            this.Controls.Add(this.DescriptionBox);
            this.Controls.Add(this.UnitBox);
            this.Controls.Add(this.QtyBox);
            this.Controls.Add(this.ListBox);
            this.Controls.Add(this.ListLabel);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.Unit);
            this.Controls.Add(this.Qty);
            this.Controls.Add(this.InstructionsBox);
            this.Controls.Add(this.ChooseFile);
            this.Controls.Add(this.MaterialsDone);
            this.Controls.Add(this.Material);
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
        private System.Windows.Forms.Button Material;
        private System.Windows.Forms.Button MaterialsDone;
        private System.Windows.Forms.Button ChooseFile;
        private System.Windows.Forms.Label InstructionsBox;
        private System.Windows.Forms.Label Qty;
        private System.Windows.Forms.Label Unit;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label ListLabel;
        private System.Windows.Forms.TextBox ListBox;
        private System.Windows.Forms.TextBox QtyBox;
        private System.Windows.Forms.TextBox UnitBox;
        private System.Windows.Forms.TextBox DescriptionBox;
    }
}