using System;
using System.Collections.Generic;
using MyTaskManager.Models;

namespace MyTaskManager.Controllers
{
    public class MyTaskController
    {
        private MyTaskModel _model;

        // Constructeur
        public MyTaskController(MyTaskModel model)
        {
            _model = model;
            _model.MyTaskController = this;
        }

        /// <summary>
        /// Crée un objet Tâche avec les informations envoyées par la Vue pour l'envoyer au Modèle
        /// </summary>
        /// <param name="title">titre de la tâche</param>
        /// <param name="text">texte de la tâche</param>
        /// <param name="endDate">date de fin de la tâche</param>
        /// <param name="priority">priorité de la tâche</param>
        /// <param name="url">lien url de la tâche</param>
        /// <param name="img">image de la tâche</param>
        /// <param name="fkUser">id de l'utilisateur qui a crée la tâche</param>
        /// <returns>Retourne un booléen True si la création d'une nouvelle tâche a réussi ou False si la création a échoué, avec l'erreur affilié</returns>
        public (bool, Exception) AddTask(string title, string text, DateTime endDate, string priority, string url, byte[] img,int? fkUser)
        {
            try
            {
                DateTime creationDate = DateTime.Now.Date;  // Définit la date de création de la tâche (maintenant)
                MyTask newTask = new MyTask(title, text, creationDate, endDate, priority, url, img, fkUser);
                return _model.AddTaskToDatabase(newTask);
            }
            catch (Exception ex)
            {
                return (false, ex);
            }            
        }

        /// <summary>
        /// Récupère toutes les tâches d'un utilisateur
        /// </summary>
        /// <param name="currentUserId"></param>
        /// <returns>Retourne la liste de toutes les tâches de l'utilisateur connecté. Si l'opération n'a pas fonctionné, retourne l'erreur</returns>
        public (List<MyTask>, Exception) GetAllTasks(int? currentUserId)
        {      
            return _model.GetTasksFromDatabase(currentUserId);   
        }
    }
}
