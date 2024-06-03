using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using MyTaskManager.Controllers;

namespace MyTaskManager.Models
{
    public class MyTaskModel
    {
        public MyTaskController MyTaskController { get; set; }  // Accès au Contrôleur des Tâches

        // Connexion à la base de données MySQL
        private readonly MySqlConnection _connection = new MySqlConnection(
            "server=localhost; database=db_mytaskmanager; user id=root; password=root");

        // Constructeur
        public MyTaskModel()
        {

        }

        /// <summary>
        /// Ajoute une nouvelle tâche à la base de données de manière sécurisée
        /// </summary>
        /// <param name="newTask">La tâche contenant les informations insérées par l'utilisateur à ajouter à la base de données</param>
        /// <returns>Retourne un booléen : True si l'ajout de la nouvelle tâche a réussi ou False si l'ajout a échoué avec l'erreur affilié</returns>
        public (bool, Exception) AddTaskToDatabase(MyTask newTask)
        {
            try
            {
                // Ouvre la connexion à la base de données
                _connection.Open();

                // Prépare la requête SQL pour insérer une nouvelle tâche dans la base de données
                MySqlCommand query = new MySqlCommand(
                    "INSERT INTO t_task VALUES(NULL, @tasTitle, @tasText, @tasCreationDate, @tasEndDate, @tasPriority, @tasUrl, @tasImage, @fkUser)", _connection);

                // Data Binding (permet d'éviter les injection SQL)
                query.Parameters.AddWithValue("@tasTitle", newTask.Title);
                query.Parameters.AddWithValue("@tasText", newTask.Text);
                query.Parameters.AddWithValue("@tasCreationDate", newTask.CreationDate);
                query.Parameters.AddWithValue("@tasEndDate", newTask.EndDate);
                query.Parameters.AddWithValue("@tasPriority", newTask.Priority);
                query.Parameters.AddWithValue("@tasUrl", newTask.Url);
                query.Parameters.AddWithValue("@tasImage", newTask.Image);
                query.Parameters.AddWithValue("@fkUser", newTask.FkUser);

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
                // Retourne une erreur en cas d'erreur
                return (false, ex);
            }
            finally
            {
                // Ferme la connexion indépendamment du résultat de l'opération (succès ou échec)
                _connection.Close();
            }
        }

        /// <summary>
        /// Récupère toutes les tâches de la base de données de l'utilisateur connecté
        /// </summary>
        /// <param name="currentUserId">ID de l'utilisateur actuellement connecté</param>
        /// <returns>Retourne une liste de tâches ou une erreur en cas de problème</returns>
        public (List<MyTask>, Exception) GetTasksFromDatabase(int? currentUserId)
        {
            try
            {
                List<MyTask> tasks = new List<MyTask>();

                // Ouvre la connexion à la base de données
                _connection.Open();

                // Prépare la requête SQL pour trouve et récupérer les tâches de l'utilisateur connecté dans la base de données
                MySqlCommand query = new MySqlCommand(
                    "SELECT * FROM t_task WHERE fkUser = @currentUserId", _connection);

                // Data Binding (permet d'éviter les injection SQL)
                query.Parameters.AddWithValue("@currentUserid", currentUserId); 
   
                // Exécute la requête et récupère les résultats
                MySqlDataReader reader = query.ExecuteReader();

                // Lit les résultats 
                while(reader.Read())
                {
                    byte[] image = null;

                    // Vérifie si la tâche a une image
                    if(reader["tasImage"] != DBNull.Value)
                    {
                        image = (byte[])reader["tasImage"];
                    }

                    // Crée un objet Tâche pour chaque ligne récupérée
                    MyTask task = new MyTask(
                        reader["tasTitle"].ToString(),
                        reader["tasText"].ToString(),
                        Convert.ToDateTime(reader["tasCreationDate"]),
                        Convert.ToDateTime(reader["tasEndDate"]),
                        reader["tasPriority"].ToString(),
                        reader["tasUrl"].ToString(),
                        image,
                        reader["fkUser"] as int?
                    );

                    // Ajoute la tâche à la liste qui sera renvoyée à la Vue
                    tasks.Add(task);
                }

                // Retourne la liste de tâches
                return (tasks, null);
            }
            catch (Exception ex)
            {
                // Retourne une erreur en cas d'erreur
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
