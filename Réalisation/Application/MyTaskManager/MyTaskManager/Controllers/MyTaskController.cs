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
        private AddTaskView _addTaskView;
        private MyTaskModel _model;

        public MyTaskController(AddTaskView addTaskView, MyTaskModel myTaskModel)
        {
            _addTaskView = addTaskView;
            _addTaskView.Controller = this;

            _model = myTaskModel;
            _model.Controller = this;
        }


    }
}
