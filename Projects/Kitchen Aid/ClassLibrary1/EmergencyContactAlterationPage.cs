using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitchenAidTool
{
    public partial class EmergencyContactAlterationPage : Form
    {
        EmergencyContactManager mEmergencyContact = new EmergencyContactManager(); 
        public EmergencyContactAlterationPage()
        {
            InitializeComponent();
        }

        private void EmergencyContactAlterationPage_Load(object sender, EventArgs e)
        {
            if( !mEmergencyContact.QueryForEmergencyContact() )
            {
                Instructions.Text = "Please enter a 10-digit phone number. The given number will recieve a text message in emergency situations.";
                EditMessage.Text = "Add Message";
                EditNumber.Text = "Add Number"; 
            }
            else
            {
                List<string> contactInfo = mEmergencyContact.RetrieveEmergencyContact();
                NumberEdit.Text = contactInfo[0];
                MessageEdit.Text = contactInfo[1]; 
            }

        }

        private void EditNumber_Click(object sender, EventArgs e)
        {
            if (NumberEdit.Text.Length != 10)
            {
                Instructions.Text = "Phone number must be 10-digits in length (Ex. 5414515194). No spaces or dashes.";
            }
            else
            {
                Boolean allNumbers = true;
                //Ensuring each character entered is a number
                foreach (char letter in NumberEdit.Text)
                {
                    if ( allNumbers== true && !Char.IsNumber(letter))
                        allNumbers = false;
                }

                if (allNumbers == false)
                {
                    Instructions.Text = "Phone number must be all digits (ex. 5414515194 )";
                }
                else
                {
                    EditNumber.Hide();
                    NumberEdit.Hide();
                    ContactPhoneNumber.Hide();

                    if (mEmergencyContact.QueryForEmergencyContact())
                    {
                        Instructions.Text = "Below is the message on file for an emergency contact text. If you wish to leave this message, hit edit.";
                        Instructions.Text += " To update, simply edit the message below and click the edit button.";
                    }
                    else
                    {
                        Instructions.Text = "Please enter an emergency message. Note that this is the emergency text that will be sent to the number";
                        Instructions.Text += " previously entered.";
                    }
                    
                    EditMessage.Visible = true;
                    EmergencyMessage.Visible = true;
                    MessageEdit.Visible = true; 
                }
            }
        }
        private void EditMessage_Click(object sender, EventArgs e)
        {
            EditMessage.Hide();
            EmergencyMessage.Hide();
            MessageEdit.Hide();

            Instructions.Text = "Contact has been updated.";
            mEmergencyContact.AddContact(NumberEdit.Text, MessageEdit.Text);
        }
        private void MessageEdit_TextChanged(object sender, EventArgs e)
        {

        }

        private void ContactEdit_TextChanged(object sender, EventArgs e)
        {

        }
        private void ContactPhoneNumber_Click(object sender, EventArgs e)
        {

        }
    }
}
