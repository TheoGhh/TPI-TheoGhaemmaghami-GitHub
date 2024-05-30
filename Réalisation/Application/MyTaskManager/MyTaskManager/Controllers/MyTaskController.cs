using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyTaskManager.Models;
using MyTaskManager.Views;

namespace MyTaskManager.Controllers
{
    public class MyTaskController
    {
        private MyTaskModel _model;

        public MyTaskController(MyTaskModel model)
        {
            _model = model;
            _model.MyTaskController = this;
        }

        public (bool, Exception) AddTask(string title, string text, DateTime endDate, int priority, string url, byte[] img,int? fkUser)
        {
            try
            {
                DateTime creationDate = DateTime.Now.Date;
                MyTask newTask = new MyTask(title, text, creationDate, endDate, priority, url, img, fkUser);
                return _model.AddTaskToDatabase(newTask);
            }
            catch (Exception ex)
            {
                return (false, ex);
            }            
        }

        public (List<MyTask>, Exception) GetAllTasks(int? currentUserId)
        {      
            return _model.GetTasksFromDatabase(currentUserId);   
        }
    }
}
