namespace KitchenAidTool
{
    partial class FrontPage
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
            this.StartCooking = new System.Windows.Forms.Button();
            this.TextRecipe = new System.Windows.Forms.Button();
            this.VideoRecipe = new System.Windows.Forms.Button();
            this.RemoveRecipe = new System.Windows.Forms.Button();
            this.EmergencyContact = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartCooking
            // 
            this.StartCooking.Location = new System.Drawing.Point(353, 137);
            this.StartCooking.Name = "StartCooking";
            this.StartCooking.Size = new System.Drawing.Size(146, 38);
            this.StartCooking.TabIndex = 0;
            this.StartCooking.Text = "Start Cooking!";
            this.StartCooking.UseVisualStyleBackColor = true;
            // 
            // TextRecipe
            // 
            this.TextRecipe.Location = new System.Drawing.Point(23, 113);
            this.TextRecipe.Name = "TextRecipe";
            this.TextRecipe.Size = new System.Drawing.Size(193, 35);
            this.TextRecipe.TabIndex = 1;
            this.TextRecipe.Text = "Add Recipe with Text";
            this.TextRecipe.UseVisualStyleBackColor = true;
            // 
            // VideoRecipe
            // 
            this.VideoRecipe.Location = new System.Drawing.Point(23, 166);
            this.VideoRecipe.Name = "VideoRecipe";
            this.VideoRecipe.Size = new System.Drawing.Size(193, 33);
            this.VideoRecipe.TabIndex = 2;
            this.VideoRecipe.Text = "Add Recipe with a Video";
            this.VideoRecipe.UseVisualStyleBackColor = true;
            // 
            // RemoveRecipe
            // 
            this.RemoveRecipe.Location = new System.Drawing.Point(23, 217);
            this.RemoveRecipe.Name = "RemoveRecipe";
            this.RemoveRecipe.Size = new System.Drawing.Size(193, 32);
            this.RemoveRecipe.TabIndex = 3;
            this.RemoveRecipe.Text = "Remove Recipe";
            this.RemoveRecipe.UseVisualStyleBackColor = true;
            // 
            // EmergencyContact
            // 
            this.EmergencyContact.Location = new System.Drawing.Point(23, 264);
            this.EmergencyContact.Name = "EmergencyContact";
            this.EmergencyContact.Size = new System.Drawing.Size(199, 33);
            this.EmergencyContact.TabIndex = 4;
            this.EmergencyContact.Text = "Set Emergency Contact";
            this.EmergencyContact.UseVisualStyleBackColor = true;
            // 
            // FrontPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 320);
            this.Controls.Add(this.EmergencyContact);
            this.Controls.Add(this.RemoveRecipe);
            this.Controls.Add(this.VideoRecipe);
            this.Controls.Add(this.TextRecipe);
            this.Controls.Add(this.StartCooking);
            this.Name = "FrontPage";
            this.Text = "Independence";
            this.Load += new System.EventHandler(this.FrontPage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartCooking;
        private System.Windows.Forms.Button TextRecipe;
        private System.Windows.Forms.Button VideoRecipe;
        private System.Windows.Forms.Button RemoveRecipe;
        private System.Windows.Forms.Button EmergencyContact;
    }
}