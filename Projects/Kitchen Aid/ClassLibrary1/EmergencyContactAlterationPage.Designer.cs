namespace KitchenAidTool
{
    partial class EmergencyContactAlterationPage
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
            this.ContactPhoneNumber = new System.Windows.Forms.Label();
            this.EmergencyMessage = new System.Windows.Forms.Label();
            this.NumberEdit = new System.Windows.Forms.TextBox();
            this.EditNumber = new System.Windows.Forms.Button();
            this.EditMessage = new System.Windows.Forms.Button();
            this.MessageEdit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Instructions
            // 
            this.Instructions.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Instructions.Location = new System.Drawing.Point(31, 48);
            this.Instructions.Name = "Instructions";
            this.Instructions.Size = new System.Drawing.Size(528, 132);
            this.Instructions.TabIndex = 0;
            this.Instructions.Text = "Below is the number on file for emergency contact. If you wish to leave this numb" +
    "er, click edit. To update, simply edit the number and then click the edit button" +
    ".   ";
            // 
            // ContactPhoneNumber
            // 
            this.ContactPhoneNumber.AutoSize = true;
            this.ContactPhoneNumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactPhoneNumber.Location = new System.Drawing.Point(31, 192);
            this.ContactPhoneNumber.Name = "ContactPhoneNumber";
            this.ContactPhoneNumber.Size = new System.Drawing.Size(252, 27);
            this.ContactPhoneNumber.TabIndex = 1;
            this.ContactPhoneNumber.Text = "Contact\'s Phone Number";
            this.ContactPhoneNumber.Click += new System.EventHandler(this.ContactPhoneNumber_Click);
            // 
            // EmergencyMessage
            // 
            this.EmergencyMessage.AutoSize = true;
            this.EmergencyMessage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmergencyMessage.Location = new System.Drawing.Point(31, 192);
            this.EmergencyMessage.Name = "EmergencyMessage";
            this.EmergencyMessage.Size = new System.Drawing.Size(308, 27);
            this.EmergencyMessage.TabIndex = 2;
            this.EmergencyMessage.Text = "Emergency Response Message";
            this.EmergencyMessage.Visible = false;
            // 
            // NumberEdit
            // 
            this.NumberEdit.Location = new System.Drawing.Point(36, 222);
            this.NumberEdit.Name = "NumberEdit";
            this.NumberEdit.Size = new System.Drawing.Size(311, 26);
            this.NumberEdit.TabIndex = 3;
            this.NumberEdit.TextChanged += new System.EventHandler(this.ContactEdit_TextChanged);
            // 
            // EditNumber
            // 
            this.EditNumber.Location = new System.Drawing.Point(397, 223);
            this.EditNumber.Name = "EditNumber";
            this.EditNumber.Size = new System.Drawing.Size(119, 33);
            this.EditNumber.TabIndex = 5;
            this.EditNumber.Text = "Edit Number";
            this.EditNumber.UseVisualStyleBackColor = true;
            this.EditNumber.Click += new System.EventHandler(this.EditNumber_Click);
            // 
            // EditMessage
            // 
            this.EditMessage.Location = new System.Drawing.Point(397, 222);
            this.EditMessage.Name = "EditMessage";
            this.EditMessage.Size = new System.Drawing.Size(137, 34);
            this.EditMessage.TabIndex = 6;
            this.EditMessage.Text = "Edit Message";
            this.EditMessage.UseVisualStyleBackColor = true;
            this.EditMessage.Visible = false;
            this.EditMessage.Click += new System.EventHandler(this.EditMessage_Click);
            // 
            // MessageEdit
            // 
            this.MessageEdit.Location = new System.Drawing.Point(36, 222);
            this.MessageEdit.Name = "MessageEdit";
            this.MessageEdit.Size = new System.Drawing.Size(311, 26);
            this.MessageEdit.TabIndex = 7;
            this.MessageEdit.Visible = false;
            this.MessageEdit.TextChanged += new System.EventHandler(this.MessageEdit_TextChanged);
            // 
            // EmergencyContactAlterationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 320);
            this.Controls.Add(this.MessageEdit);
            this.Controls.Add(this.EditMessage);
            this.Controls.Add(this.EditNumber);
            this.Controls.Add(this.NumberEdit);
            this.Controls.Add(this.EmergencyMessage);
            this.Controls.Add(this.ContactPhoneNumber);
            this.Controls.Add(this.Instructions);
            this.Name = "EmergencyContactAlterationPage";
            this.Text = "EmergencyContactAlterationPage";
            this.Load += new System.EventHandler(this.EmergencyContactAlterationPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Instructions;
        private System.Windows.Forms.Label ContactPhoneNumber;
        private System.Windows.Forms.Label EmergencyMessage;
        private System.Windows.Forms.TextBox NumberEdit;
        private System.Windows.Forms.Button EditNumber;
        private System.Windows.Forms.Button EditMessage;
        private System.Windows.Forms.TextBox MessageEdit;
    }
}