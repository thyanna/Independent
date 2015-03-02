using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using KitchenAidUI; 

namespace KitchenAid
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            UIManager test = new UIManager();
            test.LoadMainPage(); 
        }
    }
}
