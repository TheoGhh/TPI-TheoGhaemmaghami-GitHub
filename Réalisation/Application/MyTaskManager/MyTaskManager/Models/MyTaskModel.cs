using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MyTaskManager.Controllers;

namespace MyTaskManager.Models
{
    public class MyTaskModel
    {
        public MyTaskController MyTaskController { get; set; }

        private readonly MySqlConnection _connection = new MySqlConnection(
            "server=localhost; database=db_mytaskmanager; user id=root; password=root");

        public MyTaskModel()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="newTask"></param>
        /// <returns></returns>
        public bool AddTaskToDatabase(MyTask newTask)
        {
            try
            {
                // Ouvre la connexion à la base de données
                _connection.Open();

                // Prépare la requête SQL pour insérer un nouvel utilisateur dans la base de données
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
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                _connection.Close();
            }
        }

        public List<MyTask> GetTasksFromDatabase(int? currentUserId)
        {
            try
            {
                List<MyTask> tasks = new List<MyTask>();

                // Ouvre la connexion à la base de données
                _connection.Open();

                // Prépare la requête SQL pour insérer un nouvel utilisateur dans la base de données
                MySqlCommand query = new MySqlCommand(
                    "SELECT * FROM t_task WHERE fkUser = @currentUserId", _connection);

                query.Parameters.AddWithValue("@currentUserid", currentUserId); 
   
                MySqlDataReader reader = query.ExecuteReader();

                while(reader.Read())
                {
                    byte[] image = null;
                    if(reader["tasImage"] != DBNull.Value)
                    {
                        image = (byte[])reader["tasImage"];
                    }

                    MyTask task = new MyTask(
                        reader["tasTitle"].ToString(),
                        reader["tasText"].ToString(),
                        Convert.ToDateTime(reader["tasCreationDate"]),
                        Convert.ToDateTime(reader["tasEndDate"]),
                        Convert.ToInt32(reader["tasPriority"]),
                        reader["tasUrl"].ToString(),
                        image,
                        reader["fkUser"] as int?
                    );

                    tasks.Add(task);
                }

                return tasks;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                _connection.Close();
            }
        }
    }
}
