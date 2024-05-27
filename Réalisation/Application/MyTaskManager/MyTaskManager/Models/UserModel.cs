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
using System.Windows.Forms;
using System.Data;

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
            catch (Exception ex)
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
            try
            {                
                // Ouvre la connexion à la base de données
                _databaseConnection.Open();

                // Prépare la requête SQL pour retrouver le mot de passe associé au login de l'utilisateur
                MySqlCommand query = new MySqlCommand(
                    "SELECT usePassword, idUser FROM t_user WHERE useLogin = @useLogin", _databaseConnection);
                
                // Data Binding (permet d'éviter les injection SQL)
                query.Parameters.AddWithValue("@useLogin", login);

                // Exécute la requête et récupère les résultats dans un objet reader
                MySqlDataReader reader = query.ExecuteReader();
                
                // Lit et contrôle le résultat. Si une ligne est lue avec le login entré par l'utilisateur, l'utilisateur existe dans la DB
                if (reader.Read())
                {
                    // Récupère le mot de passe haché de la base de données
                    string hashedPassword = reader["usePassword"].ToString();

                    // Récupère l'id de l'utilisateur connecté
                    int userId = (int)reader["idUser"];

                    // Vérifie si la correspondance entre les mots de passe
                    return BCrypt.Net.BCrypt.Verify(password, hashedPassword);  
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
