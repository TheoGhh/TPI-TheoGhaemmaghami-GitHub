using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyTaskManager.Controllers;
using MyTaskManager.Models;

namespace MyTaskManager.Views
{
    public partial class MainView : Form
    {     
        
        public UserController UserController { get; set; }
        public MyTaskController MyTaskController { get; set; }
        private int? _currentIdUser;

        int counter = 2;
        Column columnToDo = new Column("A FAIRE");
        Column columnDone = new Column("TERMINE");

        public MainView(int? idUser, UserController userController, MyTaskController myTaskController)
        {
            InitializeComponent();
            UserController = userController;       
            _currentIdUser = idUser;
            MyTaskController = myTaskController;      
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            columnToDo.DisplayColumn(pnlMainContainer);
            columnDone.DisplayColumn(pnlMainContainer);

            var tasks = MyTaskController.GetAllTasks(_currentIdUser);

            foreach (var task in tasks)
            {
                columnToDo.AddTask(task);
            }
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            AddTaskView addTaskView = new AddTaskView(_currentIdUser, MyTaskController);
            addTaskView.Show();
            addTaskView.TaskAdded += AddTaskView_TaskAdded;
        }

        private void AddTaskView_TaskAdded(object sender, EventArgs e)
        {
            var tasks = MyTaskController.GetAllTasks(_currentIdUser);
            columnToDo.AddTask(tasks.Last());
        }

        private void btnAddColumn_Click(object sender, EventArgs e)
        {
            if (pnlMainContainer.Controls.Count < 6)
            {
                Column newColumn = new Column("Titre");
                newColumn.DisplayColumn(pnlMainContainer);
                counter++;
            }
            else
            {
                MessageBox.Show("Limitation à 6 colonnes maximum", "Limite des colonnes");
            }
            
        }

        private void btnDeleteColumn_Click(object sender, EventArgs e)
        {
            if (pnlMainContainer.Controls.Count > 2)
            {
                pnlMainContainer.Controls.RemoveAt(counter-1);
            }
            else
            {
                MessageBox.Show("Limitation à 2 colonnes minimum", "Limite des colonnes");
            }
        }

    }
}
