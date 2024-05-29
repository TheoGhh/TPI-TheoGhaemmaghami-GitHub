using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MyTaskManager.Controllers;
using System.Windows.Forms;

namespace MyTaskManager.Models
{
    public class UserModel
    {
        public UserController UserController { get; set; }

        private readonly MySqlConnection _connection = new MySqlConnection(
            "server=localhost; database=db_mytaskmanager; user id=root; password=root");

        public UserModel()
        {

        }

        public bool RegisterUserInDatabase(User newUser)
        {
            try
            {
                // Ouvre la connexion à la base de données
                _connection.Open();

                // Stocke et hache le mot de passe
                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(newUser.Password);

                // Prépare la requête SQL pour insérer un nouvel utilisateur dans la base de données
                MySqlCommand query = new MySqlCommand(
                    "INSERT INTO t_user VALUES(NULL, @useFirstName, @useLastName, @useLogin, @usePassword)", _connection);

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
                _connection.Close();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public int? LoginUserToDB(string login, string password)
        {
            try
            {
                // Ouvre la connexion à la base de données
                _connection.Open();

                // Prépare la requête SQL pour retrouver le mot de passe associé au login de l'utilisateur
                MySqlCommand query = new MySqlCommand(
                    "SELECT * FROM t_user WHERE useLogin = @useLogin", _connection);

                // Data Binding (permet d'éviter les injection SQL)
                query.Parameters.AddWithValue("@useLogin", login);

                // Exécute la requête et récupère les résultats dans un objet reader
                MySqlDataReader reader = query.ExecuteReader();

                // Lit et contrôle le résultat. Si une ligne est lue avec le login entré par l'utilisateur, l'utilisateur existe dans la DB
                if (reader.Read())
                {
                    // Récupère le mot de passe haché de la base de données
                    string hashedPassword = reader["usePassword"].ToString();                  

                    // Vérifie si la correspondance entre les mots de passe
                    if(BCrypt.Net.BCrypt.Verify(password, hashedPassword))
                    {
                        // Stocke et retourne l'id de l'utilisateur actuel 
                        int currentUserId = (int)reader["idUser"];
                        return currentUserId;
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                // S'assure que la connexion se ferme peu importe si l'opération a fonctionné ou pas
                _connection.Close();
            }

        }
    }
}
