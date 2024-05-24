﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyTaskManager.Views;
using MyTaskManager.Models;
using MyTaskManager.Controllers;

namespace MyTaskManager
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            UserModel aUserModel = new UserModel();

            MainView aMainView = new MainView();

            UserController aUserController = new UserController(aUserModel, aMainView);

            Application.Run(aMainView);
        }
    }
}
