using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KitchenAidTool;
using System.Windows.Forms;

namespace KitchenAidUI
{
    public class UIManager
    {
        FrontPage frontPage = new FrontPage(); 
        public void LoadMainPage()
        {
            Application.Run(frontPage);
        }
    }
}
