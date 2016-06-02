using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;
using Google.Apis.Auth;



namespace twitchBot
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ApplicationExit += globalSettings.save;
            //Application.Run(new playerWindow());

            winforms.goHome();
            globalSettings.load();

            loginInfo li = new loginInfo("", "", "");
            LoginWindow lw;
            if (li.load()) {
                lw = new LoginWindow(false, li);
                Application.Run();
            }
            else {
                lw = new LoginWindow();
                Application.Run();
            }
            
        }
    }
}
