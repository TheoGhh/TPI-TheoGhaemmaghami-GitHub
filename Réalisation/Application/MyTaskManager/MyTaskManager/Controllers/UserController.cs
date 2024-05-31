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

        /// <summary>
        /// Crée un objet Utilisateur avec les informations de l'utilisateur envoyées par la Vue pour l'envoyer au Modèle
        /// </summary>
        /// <param name="firstName">Prénom du compte Utilisateur</param>
        /// <param name="lastName">Nom du compte Utilisateur</param>
        /// <param name="login">Identifiant du compte Utilisateur</param>
        /// <param name="password">Mot de passe du compte Utilisateur</param>
        /// <returns>Retourne un booléen True si la création de nouveau compte a réussi ou False si la création a échoué avec l'erreur affilié</returns>
        public (bool, Exception) RegisterUser(string firstName , string lastName, string login, string password)
        {
            try
            {
                User newUser = new User(firstName, lastName, login, password);

                // Transmets les informations du nouveau compte utilisateur au Modèle
                return _model.RegisterUserInDatabase(newUser);
            }
            catch (Exception ex)
            {
                return (false, ex);
            }          
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="login">Login de l'utilisateur</param>
        /// <param name="password">Mot de passe de l'utilisateur</param>
        /// <returns>Retourne l'id de l'utilisateur connecté si la connexion au compte a réussi. Retourne null ou bien l'erreur si la connexion a échoué</returns>
        public (int?, Exception) LoginUser(string login, string password)
        {
            return _model.LoginUserToDB(login, password);   
        }

       
    }
}
