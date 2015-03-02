using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenAidTool
{
    class EmergencyContactManager
    {
        DatabaseManager mDatabase = new DatabaseManager(); 
        List<string> contactInfo = new List<string>(); 
        public string InitiateEmergencyContact()
        {
            string temp = ""; 

            if( QueryForEmergencyContact() )
            {
                //initiate text message sending 
            }
            else
             temp = "Contact has not been set.";

            return temp; 
        }
        public Boolean AddContact( string contactNumber, string emergencyMessage)
        {
            Boolean success = false; 

            success = mDatabase.StoreEmergencyContact(contactNumber, emergencyMessage);

            return success; 
        }
        public List<string> RetrieveEmergencyContact()
        {
            return mDatabase.RetrieveEmergencyContact(); 
        }
        public Boolean QueryForEmergencyContact()
        {
            return mDatabase.QueryForEmergencyContact(); 
        }
    }
}
