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

        public UserController(UserModel model)
        {
            _model = model;
            _model.UserController = this;
        }

        public bool RegisterUser(string firstName , string lastName, string login, string password)
        {
            User newUser = new User(firstName, lastName, login, password);

            return _model.RegisterUserInDatabase(newUser);
        }

        public int? LoginUser(string login, string password)
        {
            return _model.LoginUserToDB(login, password);   
        }

       
    }
}
