using System;
using MySql.Data.MySqlClient;
using MyTaskManager.Controllers;


namespace MyTaskManager.Models
{
    public class UserModel
    {
        public UserController UserController { get; set; }  // Accès au Contrôleur des Utilisateurs

        // Connexion à la base de données MySQL
        private readonly MySqlConnection _connection = new MySqlConnection(
            "server=localhost; database=db_mytaskmanager; user id=root; password=root");

        // Constructeur
        public UserModel()
        {

        }

        /// <summary>
        /// Enregistre le nouvel utilisateur dans la base de données de manière sécurisée
        /// </summary>
        /// <param name="newUser">Objet Utilisateur regroupant les informations insérées par l'utilisateur</param>
        /// <returns>Retourne un booléen : True si la création du nouveau compte a réussi ou False si la création a échoué avec l'erreur affilié</returns>
        public (bool,Exception) RegisterUserInDatabase(User newUser)
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
                
                // Data Binding (permet de faire de la liaison de données et par conséquent d'éviter les injection SQL)
                query.Parameters.AddWithValue("@useFirstName", newUser.FirstName);
                query.Parameters.AddWithValue("@useLastName", newUser.LastName);
                query.Parameters.AddWithValue("@useLogin", newUser.Login);
                query.Parameters.AddWithValue("@usePassword", hashedPassword);

                // Exécute la requête SQL
                int result = query.ExecuteNonQuery();

                // Vérifie si au moins une colonne a été affectée et par conséquent si l'opération a fonctionnée
                if (result > 0)
                {
                    return (true, null);
                }
                else
                {
                    return (false, null);
                }
            }
            catch (Exception ex)
            {
                return (false, ex);              
            }
            finally
            {
                // Ferme la connexion indépendamment du résultat de l'opération (succès ou échec)
                _connection.Close();
            }
        }

        /// <summary>
        /// Connecte l'utilisateur en vérifiant ses informations d'identification
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns>Retourne l'id de l'utilisateur connecté si la connexion au compte a réussi. Retourne null ou bien l'erreur si la connexion a échoué</returns>
        public (int?, Exception) LoginUserToDB(string login, string password)
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

                    // Vérifie la correspondance entre les mots de passe
                    if(BCrypt.Net.BCrypt.Verify(password, hashedPassword))
                    {
                        // Stocke et retourne l'id de l'utilisateur actuel 
                        int currentUserId = (int)reader["idUser"];
                        return (currentUserId, null);
                    }
                    else
                    {
                        return (null, null);
                    }
                }
                else
                {
                    return (null, null);
                }
            }
            catch (Exception ex)
            {
                return (null, ex);
            }
            finally
            {
                // Ferme la connexion indépendamment du résultat de l'opération (succès ou échec)
                _connection.Close();
            }

        }
    }
}
