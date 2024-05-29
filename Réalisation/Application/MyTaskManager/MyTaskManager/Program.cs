using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyTaskManager.Views;
using MyTaskManager.Controllers;
using MyTaskManager.Models;

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
            

            UserModel userModel = new UserModel();
            UserController userController = new UserController(userModel);

            MyTaskModel myTaskModel = new MyTaskModel();
            MyTaskController myTaskController = new MyTaskController(myTaskModel);

            LoginView loginView = new LoginView(userController, myTaskController);

            loginView.Show();

            Application.Run();
        }
    }
}
