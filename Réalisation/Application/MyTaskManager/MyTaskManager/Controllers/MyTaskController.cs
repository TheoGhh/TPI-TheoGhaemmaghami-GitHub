using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyTaskManager.Models;
using MyTaskManager.Views;
using System.Drawing;

namespace MyTaskManager.Controllers
{
    public class MyTaskController
    {
        private AddTaskView _addTaskView;
        
        private MyTaskModel _model;

        public MyTaskController(AddTaskView addTaskView, MyTaskModel myTaskModel)
        {
            _addTaskView = addTaskView;
            _addTaskView.Controller = this;

            _model = myTaskModel;
            _model.Controller = this;
        }

        public void AddTask(string title, string description, DateTime endDate, int priority, string url, Image image)
        {
            MyTask newTask = new MyTask(title, description, endDate, priority, url, image);
            
        }

    }
}
