using NotEnoughNotifications.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotEnoughNotifications
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (ConfigReader.LoadConfig()) {
                // Maybe send a special argument with it
                Application.Run(new MainPage());
            } else {
                Application.Run(new MainPage());
            }
        }
    }
}
