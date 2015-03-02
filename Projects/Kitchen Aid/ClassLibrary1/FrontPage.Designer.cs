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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrontPage));
            this.StartCooking = new System.Windows.Forms.Button();
            this.TextRecipe = new System.Windows.Forms.Button();
            this.VideoRecipe = new System.Windows.Forms.Button();
            this.RemoveRecipe = new System.Windows.Forms.Button();
            this.EmergencyContact = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartCooking
            // 
            this.StartCooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.StartCooking.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartCooking.Location = new System.Drawing.Point(608, 316);
            this.StartCooking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StartCooking.Name = "StartCooking";
            this.StartCooking.Size = new System.Drawing.Size(225, 81);
            this.StartCooking.TabIndex = 0;
            this.StartCooking.Text = "Start Cooking!";
            this.StartCooking.UseVisualStyleBackColor = false;
            this.StartCooking.Click += new System.EventHandler(this.StartCooking_Click);
            // 
            // TextRecipe
            // 
            this.TextRecipe.BackColor = System.Drawing.Color.SlateGray;
            this.TextRecipe.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextRecipe.Location = new System.Drawing.Point(61, 127);
            this.TextRecipe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextRecipe.Name = "TextRecipe";
            this.TextRecipe.Size = new System.Drawing.Size(268, 81);
            this.TextRecipe.TabIndex = 1;
            this.TextRecipe.Text = "Add Recipe with Text";
            this.TextRecipe.UseVisualStyleBackColor = false;
            this.TextRecipe.Click += new System.EventHandler(this.TextRecipe_Click);
            // 
            // VideoRecipe
            // 
            this.VideoRecipe.BackColor = System.Drawing.Color.LightSlateGray;
            this.VideoRecipe.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VideoRecipe.Location = new System.Drawing.Point(61, 23);
            this.VideoRecipe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VideoRecipe.Name = "VideoRecipe";
            this.VideoRecipe.Size = new System.Drawing.Size(268, 81);
            this.VideoRecipe.TabIndex = 2;
            this.VideoRecipe.Text = "Add Recipe with a Video";
            this.VideoRecipe.UseVisualStyleBackColor = false;
            this.VideoRecipe.Click += new System.EventHandler(this.VideoRecipe_Click);
            // 
            // RemoveRecipe
            // 
            this.RemoveRecipe.BackColor = System.Drawing.Color.SlateGray;
            this.RemoveRecipe.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveRecipe.Location = new System.Drawing.Point(61, 329);
            this.RemoveRecipe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RemoveRecipe.Name = "RemoveRecipe";
            this.RemoveRecipe.Size = new System.Drawing.Size(268, 81);
            this.RemoveRecipe.TabIndex = 3;
            this.RemoveRecipe.Text = "Remove Recipe";
            this.RemoveRecipe.UseVisualStyleBackColor = false;
            this.RemoveRecipe.Click += new System.EventHandler(this.RemoveRecipe_Click);
            // 
            // EmergencyContact
            // 
            this.EmergencyContact.BackColor = System.Drawing.Color.SlateGray;
            this.EmergencyContact.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmergencyContact.Location = new System.Drawing.Point(61, 226);
            this.EmergencyContact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmergencyContact.Name = "EmergencyContact";
            this.EmergencyContact.Size = new System.Drawing.Size(268, 81);
            this.EmergencyContact.TabIndex = 4;
            this.EmergencyContact.Text = "Edit Emergency Contact Information";
            this.EmergencyContact.UseVisualStyleBackColor = false;
            this.EmergencyContact.Click += new System.EventHandler(this.EmergencyContact_Click);
            // 
            // FrontPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1047, 420);
            this.Controls.Add(this.EmergencyContact);
            this.Controls.Add(this.RemoveRecipe);
            this.Controls.Add(this.VideoRecipe);
            this.Controls.Add(this.TextRecipe);
            this.Controls.Add(this.StartCooking);
            this.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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