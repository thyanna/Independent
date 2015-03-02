namespace KitchenAidTool
{
    partial class RecipeCompletionPage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecipeCompletionPage));
            this.RecipeListBox = new System.Windows.Forms.ListBox();
            this.MaterialsCheck = new System.Windows.Forms.CheckedListBox();
            this.IngredientsCheck = new System.Windows.Forms.CheckedListBox();
            this.NextStep = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EmergencyContact = new System.Windows.Forms.Button();
            this.PlayVideo = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.Instructions = new System.Windows.Forms.Label();
            this.FirstStep = new System.Windows.Forms.Label();
            this.RecipeCompleteText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // RecipeListBox
            // 
            this.RecipeListBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecipeListBox.FormattingEnabled = true;
            this.RecipeListBox.ItemHeight = 26;
            this.RecipeListBox.Location = new System.Drawing.Point(164, 152);
            this.RecipeListBox.Name = "RecipeListBox";
            this.RecipeListBox.Size = new System.Drawing.Size(256, 238);
            this.RecipeListBox.TabIndex = 1;
            this.RecipeListBox.SelectedIndexChanged += new System.EventHandler(this.RecipeListBox_SelectedIndexChanged);
            // 
            // MaterialsCheck
            // 
            this.MaterialsCheck.CheckOnClick = true;
            this.MaterialsCheck.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaterialsCheck.FormattingEnabled = true;
            this.MaterialsCheck.Location = new System.Drawing.Point(164, 155);
            this.MaterialsCheck.Name = "MaterialsCheck";
            this.MaterialsCheck.Size = new System.Drawing.Size(256, 214);
            this.MaterialsCheck.TabIndex = 2;
            this.MaterialsCheck.Visible = false;
            this.MaterialsCheck.SelectedIndexChanged += new System.EventHandler(this.MaterialsCheck_SelectedIndexChanged_1);
            // 
            // IngredientsCheck
            // 
            this.IngredientsCheck.CheckOnClick = true;
            this.IngredientsCheck.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngredientsCheck.FormattingEnabled = true;
            this.IngredientsCheck.Location = new System.Drawing.Point(164, 152);
            this.IngredientsCheck.Name = "IngredientsCheck";
            this.IngredientsCheck.Size = new System.Drawing.Size(256, 214);
            this.IngredientsCheck.TabIndex = 3;
            this.IngredientsCheck.Visible = false;
            this.IngredientsCheck.SelectedIndexChanged += new System.EventHandler(this.IngredientsCheck_SelectedIndexChanged);
            // 
            // NextStep
            // 
            this.NextStep.Location = new System.Drawing.Point(218, 286);
            this.NextStep.Name = "NextStep";
            this.NextStep.Size = new System.Drawing.Size(152, 46);
            this.NextStep.TabIndex = 7;
            this.NextStep.Text = "Next Step";
            this.NextStep.UseVisualStyleBackColor = true;
            this.NextStep.Visible = false;
            this.NextStep.Click += new System.EventHandler(this.NextStep_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // EmergencyContact
            // 
            this.EmergencyContact.BackColor = System.Drawing.Color.Crimson;
            this.EmergencyContact.Location = new System.Drawing.Point(549, 152);
            this.EmergencyContact.Name = "EmergencyContact";
            this.EmergencyContact.Size = new System.Drawing.Size(193, 105);
            this.EmergencyContact.TabIndex = 8;
            this.EmergencyContact.Text = "HELP";
            this.EmergencyContact.UseVisualStyleBackColor = false;
            this.EmergencyContact.Click += new System.EventHandler(this.EmergencyContact_Click);
            // 
            // PlayVideo
            // 
            this.PlayVideo.Location = new System.Drawing.Point(218, 185);
            this.PlayVideo.Name = "PlayVideo";
            this.PlayVideo.Size = new System.Drawing.Size(122, 39);
            this.PlayVideo.TabIndex = 10;
            this.PlayVideo.Text = "Play Video";
            this.PlayVideo.UseVisualStyleBackColor = true;
            this.PlayVideo.Visible = false;
            this.PlayVideo.Click += new System.EventHandler(this.PlayVideo_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(-8, -7);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(780, 449);
            this.axWindowsMediaPlayer1.TabIndex = 11;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // Instructions
            // 
            this.Instructions.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Instructions.Location = new System.Drawing.Point(52, 31);
            this.Instructions.Name = "Instructions";
            this.Instructions.Size = new System.Drawing.Size(469, 109);
            this.Instructions.TabIndex = 12;
            this.Instructions.Text = "Select the recipe you want to make from the list below! Then hit enter. ";
            // 
            // FirstStep
            // 
            this.FirstStep.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstStep.Location = new System.Drawing.Point(76, 161);
            this.FirstStep.Name = "FirstStep";
            this.FirstStep.Size = new System.Drawing.Size(411, 105);
            this.FirstStep.TabIndex = 13;
            this.FirstStep.Visible = false;
            // 
            // RecipeCompleteText
            // 
            this.RecipeCompleteText.BackColor = System.Drawing.Color.SteelBlue;
            this.RecipeCompleteText.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecipeCompleteText.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.RecipeCompleteText.Location = new System.Drawing.Point(-13, -7);
            this.RecipeCompleteText.Name = "RecipeCompleteText";
            this.RecipeCompleteText.Size = new System.Drawing.Size(785, 449);
            this.RecipeCompleteText.TabIndex = 14;
            this.RecipeCompleteText.Text = "Congratulations! You\'ve completed the recipe!";
            this.RecipeCompleteText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RecipeCompleteText.Visible = false;
            // 
            // RecipeCompletionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 441);
            this.Controls.Add(this.FirstStep);
            this.Controls.Add(this.Instructions);
            this.Controls.Add(this.PlayVideo);
            this.Controls.Add(this.EmergencyContact);
            this.Controls.Add(this.NextStep);
            this.Controls.Add(this.IngredientsCheck);
            this.Controls.Add(this.MaterialsCheck);
            this.Controls.Add(this.RecipeListBox);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.RecipeCompleteText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RecipeCompletionPage";
            this.Text = "RecipeCompletionPage";
            this.Load += new System.EventHandler(this.RecipeCompletionPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox RecipeListBox;
        private System.Windows.Forms.CheckedListBox MaterialsCheck;
        private System.Windows.Forms.CheckedListBox IngredientsCheck;
        private System.Windows.Forms.Button NextStep;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button EmergencyContact;
        private System.Windows.Forms.Button PlayVideo;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Label Instructions;
        private System.Windows.Forms.Label FirstStep;
        private System.Windows.Forms.Label RecipeCompleteText;
    }
}