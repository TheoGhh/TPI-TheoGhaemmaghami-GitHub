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
                _databaseConnection.Open();
                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(newUser.Password);

                MySqlCommand query = new MySqlCommand(
                    "INSERT INTO t_user VALUES(NULL, @useFirstName, @useLastName, @useLogin, @usePassword)", _databaseConnection);
                
                query.Parameters.AddWithValue("@useFirstName", newUser.FirstName);
                query.Parameters.AddWithValue("@useLastName", newUser.LastName);
                query.Parameters.AddWithValue("@useLogin", newUser.Login);
                query.Parameters.AddWithValue("@usePassword", hashedPassword);
                
                int result = query.ExecuteNonQuery();
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
    }
}
