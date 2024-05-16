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
        private RegisterView _registerView;

        public UserController(UserModel model, RegisterView registerView)
        {
            _model = model;
            _model.Controller = this;

            _registerView = registerView;
            _registerView.Controller = this;
        }

        public bool RegisterNewUser(string firstName, string lastName, string login, string password)
        {
            User newUser = new User(firstName, lastName, login, password);

            return _model.RegisterNewUserInDatabase(newUser);
            
            
        }
    }
}
