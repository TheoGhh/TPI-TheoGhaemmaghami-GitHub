using System;
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
            
            RegisterView aRegisterView = new RegisterView();

            UserModel aUserModel = new UserModel();

            UserController aUserController = new UserController(aUserModel, aRegisterView);

            Application.Run(aRegisterView);
        }
    }
}
