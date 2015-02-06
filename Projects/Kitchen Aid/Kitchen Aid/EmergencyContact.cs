using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenAidTool
{
    class EmergencyContact
    {
        DatabaseManager mDatabase = new DatabaseManager(); 
        public string InitiateEmergnecyContact()
        {
            string number = ""; 

            if (mDatabase.QueryForEmergencyContact())
            {
                number = mDatabase.RetrieveEmergencyContact();
            }
            else
                number = "An emergency Contact has not been added."; 

            return number; 
        }
        //Calls QueryForEmergencyContact 
        public Boolean AddContact( string number )
        {
            Boolean success = mDatabase.StoreEmergencyContact(number);
            return success; 
        }
    }
}
