using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyTaskManager.Controllers;
using MySql.Data.MySqlClient;

namespace MyTaskManager.Models
{
    public class MyTaskModel
    {
        public MyTaskController Controller { get; set; }

        private readonly MySqlConnection _databaseConnection = new MySqlConnection(
            "server=localhost; database=db_mytaskmanager; user id=root; password=root");

        public MyTaskModel()
        {

        }

        public bool AddNewTaskInDatabase(MyTask newTask)
        {
            try
            {
                // Ouvre la connexion à la base de données
                _databaseConnection.Open();


                // Prépare la requête SQL pour insérer un nouvel utilisateur dans la base de données
                MySqlCommand query = new MySqlCommand(
                    "INSERT INTO t_task VALUES(NULL, @tasTitle, @tasText, '" + DateTime.Now + "', @tasEndDate, @tasPriority, @tasUrl, @tasImage)", _databaseConnection);

                // Data Binding (permet d'éviter les injection SQL)
                query.Parameters.AddWithValue("@tasTitle", newTask.Title);
                query.Parameters.AddWithValue("@tasText", newTask.Description);
                query.Parameters.AddWithValue("@tasEndDate", newTask.EndDate);
                query.Parameters.AddWithValue("@tasPriority", newTask.Priority);
                query.Parameters.AddWithValue("@tasUrl", newTask.Priority);
                query.Parameters.AddWithValue("@tasImage", newTask.Image);

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
    }
}
