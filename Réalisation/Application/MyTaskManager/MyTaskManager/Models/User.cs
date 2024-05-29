﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTaskManager.Models
{
    public class User
    {
        // Attributs
        private int _id;
        private string _firstName;
        private string _lastName;
        private string _login;
        private string _password;

        // Paramètres
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string Login
        {
            get { return _login; }
            set { _login = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        // Constructeur
        public User(string firstName, string lastName, string login, string password)
        {
            this._firstName = firstName;
            this._lastName = lastName;
            this._login = login;
            this._password = password;
        }
    }
}
