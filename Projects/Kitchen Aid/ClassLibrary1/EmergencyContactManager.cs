using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Net;
using System.IO;
using System.Web;

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
                contactInfo = mDatabase.RetrieveEmergencyContact();  
                SendSMS(); 
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
        public void SendSMS()
        {
            WebClient client = new WebClient ();
            // Add a user agent header in case the requested URI contains a query
            client.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 6.3; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/42.0.2311.22 Safari/537.36;)");
            
            string baseurl = "http://api.clickatell.com/http/sendmsg?api_id=3530771&user=IndependenceSystems&password=eQQPWSgNKVFeXd&to=" + "1";
            baseurl += contactInfo[0].ToString() + "&text=" + contactInfo[1].ToString() + "&from=15033609953&mo=1";
       
            Stream data = client.OpenRead(baseurl);
            StreamReader reader = new StreamReader (data);
            string s = reader.ReadToEnd ();
            data.Close ();
            reader.Close ();
            
        }
    }
}
