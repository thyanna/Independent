namespace KitchenAidTool
{
    partial class TextRecipeAdditionPage
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
            this.InstructionsBox = new System.Windows.Forms.Label();
            this.ListBox = new System.Windows.Forms.TextBox();
            this.ListDescription = new System.Windows.Forms.Label();
            this.Qty = new System.Windows.Forms.Label();
            this.Unit = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.QtyBox = new System.Windows.Forms.TextBox();
            this.UnitBox = new System.Windows.Forms.TextBox();
            this.DescriptionBox = new System.Windows.Forms.TextBox();
            this.ListLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DataEntry
            // 
            this.DataEntry.Location = new System.Drawing.Point(36, 116);
            this.DataEntry.Name = "DataEntry";
            this.DataEntry.Size = new System.Drawing.Size(392, 26);
            this.DataEntry.TabIndex = 1;
            this.DataEntry.TextChanged += new System.EventHandler(this.DataEntry_TextChanged);
            // 
            // RecipeName
            // 
            this.RecipeName.Location = new System.Drawing.Point(474, 110);
            this.RecipeName.Name = "RecipeName";
            this.RecipeName.Size = new System.Drawing.Size(159, 32);
            this.RecipeName.TabIndex = 2;
            this.RecipeName.Text = "Next";
            this.RecipeName.UseVisualStyleBackColor = true;
            this.RecipeName.Click += new System.EventHandler(this.RecipeName_Click);
            // 
            // Material
            // 
            this.Material.Location = new System.Drawing.Point(474, 112);
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
            this.MaterialsDone.Location = new System.Drawing.Point(474, 346);
            this.MaterialsDone.Name = "MaterialsDone";
            this.MaterialsDone.Size = new System.Drawing.Size(86, 32);
            this.MaterialsDone.TabIndex = 5;
            this.MaterialsDone.Text = "Done";
            this.MaterialsDone.UseVisualStyleBackColor = true;
            this.MaterialsDone.Visible = false;
            this.MaterialsDone.Click += new System.EventHandler(this.MaterialsDone_Click);
            // 
            // InstructionsBox
            // 
            this.InstructionsBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionsBox.Location = new System.Drawing.Point(36, 9);
            this.InstructionsBox.Name = "InstructionsBox";
            this.InstructionsBox.Size = new System.Drawing.Size(609, 80);
            this.InstructionsBox.TabIndex = 6;
            this.InstructionsBox.Text = "Type the recipe\'s name below then hit the enter button. ";
            this.InstructionsBox.Click += new System.EventHandler(this.InstructionsBox_Click);
            // 
            // ListBox
            // 
            this.ListBox.Location = new System.Drawing.Point(36, 204);
            this.ListBox.Multiline = true;
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(392, 174);
            this.ListBox.TabIndex = 7;
            this.ListBox.Visible = false;
            // 
            // ListDescription
            // 
            this.ListDescription.AutoSize = true;
            this.ListDescription.Location = new System.Drawing.Point(32, 181);
            this.ListDescription.Name = "ListDescription";
            this.ListDescription.Size = new System.Drawing.Size(0, 20);
            this.ListDescription.TabIndex = 8;
            this.ListDescription.Visible = false;
            // 
            // Qty
            // 
            this.Qty.AutoSize = true;
            this.Qty.Location = new System.Drawing.Point(36, 90);
            this.Qty.Name = "Qty";
            this.Qty.Size = new System.Drawing.Size(33, 20);
            this.Qty.TabIndex = 9;
            this.Qty.Text = "Qty";
            this.Qty.Visible = false;
            // 
            // Unit
            // 
            this.Unit.AutoSize = true;
            this.Unit.Location = new System.Drawing.Point(100, 89);
            this.Unit.Name = "Unit";
            this.Unit.Size = new System.Drawing.Size(38, 20);
            this.Unit.TabIndex = 10;
            this.Unit.Text = "Unit";
            this.Unit.Visible = false;
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(172, 89);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(89, 20);
            this.Description.TabIndex = 11;
            this.Description.Text = "Description";
            this.Description.Visible = false;
            // 
            // QtyBox
            // 
            this.QtyBox.Location = new System.Drawing.Point(36, 116);
            this.QtyBox.Name = "QtyBox";
            this.QtyBox.Size = new System.Drawing.Size(43, 26);
            this.QtyBox.TabIndex = 12;
            this.QtyBox.Visible = false;
            this.QtyBox.TextChanged += new System.EventHandler(this.QtyBox_TextChanged);
            // 
            // UnitBox
            // 
            this.UnitBox.Location = new System.Drawing.Point(104, 116);
            this.UnitBox.Name = "UnitBox";
            this.UnitBox.Size = new System.Drawing.Size(48, 26);
            this.UnitBox.TabIndex = 13;
            this.UnitBox.Visible = false;
            this.UnitBox.TextChanged += new System.EventHandler(this.UnitBox_TextChanged);
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.Location = new System.Drawing.Point(176, 116);
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(252, 26);
            this.DescriptionBox.TabIndex = 14;
            this.DescriptionBox.Visible = false;
            this.DescriptionBox.TextChanged += new System.EventHandler(this.DescriptionBox_TextChanged);
            // 
            // ListLabel
            // 
            this.ListLabel.AutoSize = true;
            this.ListLabel.Location = new System.Drawing.Point(36, 178);
            this.ListLabel.Name = "ListLabel";
            this.ListLabel.Size = new System.Drawing.Size(102, 20);
            this.ListLabel.TabIndex = 15;
            this.ListLabel.Text = "Materials List";
            this.ListLabel.Visible = false;
            // 
            // TextRecipeAdditionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 390);
            this.Controls.Add(this.ListLabel);
            this.Controls.Add(this.DescriptionBox);
            this.Controls.Add(this.UnitBox);
            this.Controls.Add(this.QtyBox);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.Unit);
            this.Controls.Add(this.Qty);
            this.Controls.Add(this.ListDescription);
            this.Controls.Add(this.ListBox);
            this.Controls.Add(this.InstructionsBox);
            this.Controls.Add(this.MaterialsDone);
            this.Controls.Add(this.Material);
            this.Controls.Add(this.RecipeName);
            this.Controls.Add(this.DataEntry);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TextRecipeAdditionPage";
            this.Text = "Add Text Recipe ";
            this.Load += new System.EventHandler(this.TextRecipeAdditionPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DataEntry;
        private System.Windows.Forms.Button RecipeName;
        private System.Windows.Forms.Button Material;
        private System.Windows.Forms.Button MaterialsDone;
        private System.Windows.Forms.Label InstructionsBox;
        private System.Windows.Forms.TextBox ListBox;
        private System.Windows.Forms.Label ListDescription;
        private System.Windows.Forms.Label Qty;
        private System.Windows.Forms.Label Unit;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.TextBox QtyBox;
        private System.Windows.Forms.TextBox UnitBox;
        private System.Windows.Forms.TextBox DescriptionBox;
        private System.Windows.Forms.Label ListLabel;
    }
}