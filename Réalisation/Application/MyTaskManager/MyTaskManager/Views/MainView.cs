﻿using System;
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

        private const int MinColumns = 2;
        private const int MaxColumns = 6;
        private List<Column> columns = new List<Column>();

        public MainView(int? idUser, UserController userController, MyTaskController myTaskController)
        {
            InitializeComponent();
            UserController = userController;       
            _currentIdUser = idUser;
            MyTaskController = myTaskController;      
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            
            DisplayTasks();
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            AddTaskView addTaskView = new AddTaskView(_currentIdUser, MyTaskController);
            addTaskView.Show();
            addTaskView.TaskAdded += AddTaskView_TaskAdded;
        }

        private void AddTaskView_TaskAdded(object sender, EventArgs e)
        {
            DisplayTasks();
        }


        private void DisplayTasks()
        {
            

            var tasks = MyTaskController.GetAllTasks(_currentIdUser);
            foreach (var task in tasks)
            {
                flowLayoutPanel1.Controls.Add(task); 
            }
        }

        private void DisplayColumns()
        {
            int counter = 0;
            counter++;

            Label lblTitle= new Label();
            lblTitle.Name = counter.ToString();


            FlowLayoutPanel flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel1.Name = counter.ToString();
            flowLayoutPanel1.

        }

        private void btnAddColumn_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDeleteColumn_Click(object sender, EventArgs e)
        {
            
        }

    }
}
