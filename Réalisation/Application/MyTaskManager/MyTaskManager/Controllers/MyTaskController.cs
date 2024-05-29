using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyTaskManager.Models;
using MyTaskManager.Views;
using System.Windows.Forms;

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

        public bool AddTask(string title, string text, DateTime endDate, int priority, string url, byte[] img,int? fkUser)
        {
            DateTime creationDate = DateTime.Now.Date;

            MyTask newTask = new MyTask(title, text, creationDate, endDate, priority, url, img, fkUser);

            try
            {
                return _model.AddTaskToDatabase(newTask);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }            
        }

        public List<MyTask> GetAllTasks(int? currentUserId)
        {
            try
            {
                return _model.GetTasksFromDatabase(currentUserId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
