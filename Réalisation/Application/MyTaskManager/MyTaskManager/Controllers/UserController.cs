/// ETML
/// Auteur : Théo Ghaemmaghami
/// Date : 16.05.2024
/// Description : Contrôleur des utilisateurs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyTaskManager.Views;
using MyTaskManager.Models;


namespace MyTaskManager.Controllers
{
    public class UserController
    {
        private UserModel _model;
        private MainView _mainView;
        private LoginView _loginView;

        public UserController(UserModel model,  MainView mainView)
        {
            _model = model;
            _model.Controller = this;

            

            _mainView = mainView;
            _mainView.UserController = this;
        }

        public bool RegisterNewUser(string firstName, string lastName, string login, string password)
        {
            User newUser = new User(firstName, lastName, login, password);

            return _model.RegisterNewUserInDatabase(newUser);
        }

        public bool LoginUser(string login, string password)
        {            
            return _model.LoginUserToDB(login, password);
        }
    }
}
