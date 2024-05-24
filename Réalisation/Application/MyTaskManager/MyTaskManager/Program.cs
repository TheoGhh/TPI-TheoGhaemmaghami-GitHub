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
            LoginView aLoginView = new LoginView();
            MainView aMainView = new MainView();
            AddTaskView aAddTaskView = new AddTaskView();

            UserModel aUserModel = new UserModel();

            UserController aUserController = new UserController(aUserModel, aRegisterView, aLoginView);

            //Application.Run(aRegisterView);
            //Application.Run(aLoginView);
            //Application.Run(aMainView);
            Application.Run(aAddTaskView);
        }
    }
}
