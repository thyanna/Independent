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
            this.FirstStep = new System.Windows.Forms.TextBox();
            this.RecipeCompleteText = new System.Windows.Forms.TextBox();
            this.NextStep = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EmergencyContact = new System.Windows.Forms.Button();
            this.Instructions = new System.Windows.Forms.TextBox();
            this.PlayVideo = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // RecipeListBox
            // 
            this.RecipeListBox.FormattingEnabled = true;
            this.RecipeListBox.ItemHeight = 20;
            this.RecipeListBox.Location = new System.Drawing.Point(151, 100);
            this.RecipeListBox.Name = "RecipeListBox";
            this.RecipeListBox.Size = new System.Drawing.Size(178, 124);
            this.RecipeListBox.TabIndex = 1;
            this.RecipeListBox.SelectedIndexChanged += new System.EventHandler(this.RecipeListBox_SelectedIndexChanged);
            // 
            // MaterialsCheck
            // 
            this.MaterialsCheck.CheckOnClick = true;
            this.MaterialsCheck.FormattingEnabled = true;
            this.MaterialsCheck.Location = new System.Drawing.Point(151, 100);
            this.MaterialsCheck.Name = "MaterialsCheck";
            this.MaterialsCheck.Size = new System.Drawing.Size(179, 130);
            this.MaterialsCheck.TabIndex = 2;
            this.MaterialsCheck.Visible = false;
            this.MaterialsCheck.SelectedIndexChanged += new System.EventHandler(this.MaterialsCheck_SelectedIndexChanged_1);
            // 
            // IngredientsCheck
            // 
            this.IngredientsCheck.CheckOnClick = true;
            this.IngredientsCheck.FormattingEnabled = true;
            this.IngredientsCheck.Location = new System.Drawing.Point(151, 100);
            this.IngredientsCheck.Name = "IngredientsCheck";
            this.IngredientsCheck.Size = new System.Drawing.Size(179, 130);
            this.IngredientsCheck.TabIndex = 3;
            this.IngredientsCheck.Visible = false;
            this.IngredientsCheck.SelectedIndexChanged += new System.EventHandler(this.IngredientsCheck_SelectedIndexChanged);
            // 
            // FirstStep
            // 
            this.FirstStep.Location = new System.Drawing.Point(66, 130);
            this.FirstStep.Multiline = true;
            this.FirstStep.Name = "FirstStep";
            this.FirstStep.ReadOnly = true;
            this.FirstStep.Size = new System.Drawing.Size(353, 94);
            this.FirstStep.TabIndex = 4;
            this.FirstStep.Visible = false;
            this.FirstStep.WordWrap = false;
            this.FirstStep.TextChanged += new System.EventHandler(this.FirstStep_TextChanged);
            // 
            // RecipeCompleteText
            // 
            this.RecipeCompleteText.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.RecipeCompleteText.Font = new System.Drawing.Font("Rockwell Condensed", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecipeCompleteText.Location = new System.Drawing.Point(-14, -54);
            this.RecipeCompleteText.Multiline = true;
            this.RecipeCompleteText.Name = "RecipeCompleteText";
            this.RecipeCompleteText.ReadOnly = true;
            this.RecipeCompleteText.Size = new System.Drawing.Size(516, 304);
            this.RecipeCompleteText.TabIndex = 6;
            this.RecipeCompleteText.Text = "\r\n\r\n\r\nCongratulations the recipe is done!";
            this.RecipeCompleteText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RecipeCompleteText.Visible = false;
            // 
            // NextStep
            // 
            this.NextStep.Location = new System.Drawing.Point(166, 230);
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
            this.EmergencyContact.Location = new System.Drawing.Point(359, 41);
            this.EmergencyContact.Name = "EmergencyContact";
            this.EmergencyContact.Size = new System.Drawing.Size(122, 53);
            this.EmergencyContact.TabIndex = 8;
            this.EmergencyContact.Text = "HELP";
            this.EmergencyContact.UseVisualStyleBackColor = false;
            this.EmergencyContact.Click += new System.EventHandler(this.EmergencyContact_Click);
            // 
            // Instructions
            // 
            this.Instructions.Location = new System.Drawing.Point(13, 12);
            this.Instructions.Multiline = true;
            this.Instructions.Name = "Instructions";
            this.Instructions.ReadOnly = true;
            this.Instructions.Size = new System.Drawing.Size(317, 82);
            this.Instructions.TabIndex = 9;
            // 
            // PlayVideo
            // 
            this.PlayVideo.Location = new System.Drawing.Point(177, 141);
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
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(-14, -1);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(516, 294);
            this.axWindowsMediaPlayer1.TabIndex = 11;
            // 
            // RecipeCompletionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 281);
            this.Controls.Add(this.PlayVideo);
            this.Controls.Add(this.Instructions);
            this.Controls.Add(this.EmergencyContact);
            this.Controls.Add(this.NextStep);
            this.Controls.Add(this.FirstStep);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox RecipeListBox;
        private System.Windows.Forms.CheckedListBox MaterialsCheck;
        private System.Windows.Forms.CheckedListBox IngredientsCheck;
        private System.Windows.Forms.TextBox FirstStep;
        private System.Windows.Forms.TextBox RecipeCompleteText;
        private System.Windows.Forms.Button NextStep;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button EmergencyContact;
        private System.Windows.Forms.TextBox Instructions;
        private System.Windows.Forms.Button PlayVideo;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}