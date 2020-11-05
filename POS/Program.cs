﻿using POS.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
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

            Interfaces.IMainWindow mainWindow = null;
            UserManager.instance = new UserManager();
            do
            {
                var login = new Forms.LoginForm();
                Application.Run(login);

                if (login.LoginSuccessful)
                {
                    var main = new Main();
                    //choose which main is to open
                    mainWindow = main;

                    Application.Run(main);
                }
            }
            while (mainWindow?.IsSignout() ?? false);

            //Application.Run(new POS.Forms.ReceiptPrintingForm());
        }
    }
}
