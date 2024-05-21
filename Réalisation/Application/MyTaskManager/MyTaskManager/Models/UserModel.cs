/// ETML
/// Auteur : Théo Ghaemmaghami
/// Date : 16.05.2024
/// Description : Modèle des utilisateurs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyTaskManager.Controllers;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace MyTaskManager.Models
{
    public class UserModel
    {
        public UserController Controller { get; set; }

        private readonly MySqlConnection _databaseConnection = new MySqlConnection(
            "server=localhost; database=db_mytaskmanager; user id=root; password=root");

        public UserModel()
        {

        }

        /*public string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }*/

        /// <summary>
        /// 
        /// </summary>
        /// <param name="newUser"></param>
        /// <returns></returns>
        public bool RegisterNewUserInDatabase(User newUser)
        {
            try
            {
                // Ouvre la connexion à la base de données
                _databaseConnection.Open();

                // Stocke et hache le mot de passe
                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(newUser.Password);

                // Prépare la requête SQL pour insérer un nouvel utilisateur dans la base de données
                MySqlCommand query = new MySqlCommand(
                    "INSERT INTO t_user VALUES(NULL, @useFirstName, @useLastName, @useLogin, @usePassword)", _databaseConnection);

                // Data Binding (permet d'éviter les injection SQL)
                query.Parameters.AddWithValue("@useFirstName", newUser.FirstName);
                query.Parameters.AddWithValue("@useLastName", newUser.LastName);
                query.Parameters.AddWithValue("@useLogin", newUser.Login);
                query.Parameters.AddWithValue("@usePassword", hashedPassword);
                
                // Exécute la requête SQL
                int result = query.ExecuteNonQuery();

                // Vérifie si l'opération a fonctionné
                if (result > 0)
                {           
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                // S'assure que la connexion se ferme peu importe si l'opération a fonctionné ou pas
                _databaseConnection.Close();
            }
        }

        public bool LoginUserToDB(string login, string password)
        {
            MySqlDataReader reader = null;
            MySqlCommand query = null;

            try
            {
                _databaseConnection.Open();

                // Prépare la requête SQL pour retrouver le mot de passe hashé de l'utilisateur
                query = new MySqlCommand(
                    "SELECT usePassword FROM t_user WHERE useLogin = @useLogin", _databaseConnection);

                // Data Binding (permet d'éviter les injection SQL)
                query.Parameters.AddWithValue("@useLogin", login);
                reader = query.ExecuteReader();

                if (reader.Read())
                {
                    string hashedPassword = reader["usePassword"].ToString();
                    bool isValidPassword = BCrypt.Net.BCrypt.Verify(password, hashedPassword);
                    reader.Close();
                    return isValidPassword;
                }
                return false;
            }
            catch (Exception)
            {

                return false;
            }
            finally 
            {
                // Properly close and dispose of all resources
                if (reader != null && !reader.IsClosed)
                {
                    reader.Close();
                }
                if (query != null)
                {
                    query.Dispose();
                }
                if (_databaseConnection != null)
                {
                    _databaseConnection.Close();
                    _databaseConnection.Dispose();
                }
            }
        }
    }
}
