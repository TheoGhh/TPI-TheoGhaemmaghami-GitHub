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
        
        public UserController UserController { get; set; }  // Accès Contrôleur des utilisateurs
        public MyTaskController MyTaskController { get; set; }  // Accès Contrôleur des tâches

        private int? _currentIdUser;    // Stocke l'ID de l'utilisateur actuellement connecté

        int counter = 2;
        Column columnToDo = new Column("A FAIRE");
        Column columnDone = new Column("TERMINE");

        public MainView(int? idUser, UserController userController, MyTaskController myTaskController)
        {
            InitializeComponent();
            UserController = userController;       
            _currentIdUser = idUser;
            MyTaskController = myTaskController;    
            
            MinimumSize = new Size(pnlMenu.Width + (counter*columnToDo.Width),pnlMenu.Height);
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            // Affiche les 2 colonnes par défaut
            columnToDo.DisplayColumn(pnlMainContainer);
            columnDone.DisplayColumn(pnlMainContainer);

            var tasks = MyTaskController.GetAllTasks(_currentIdUser).Item1;

            foreach (var task in tasks)
            {
                columnToDo.AddTask(task);
            }
        }

        /// <summary>
        /// Ouvre la vue "Ajout d'une nouvelle tâche"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddTask_Click(object sender, EventArgs e)
        {
            AddTaskView addTaskView = new AddTaskView(_currentIdUser, MyTaskController);
            addTaskView.Show();

            // Invoque l'évenement d'ajout d'une nouvelle tâche
            addTaskView.TaskAdded += AddTaskView_TaskAdded;
        }

        /// <summary>
        /// Affiche la dernière tâche venant d'être ajoutée 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTaskView_TaskAdded(object sender, EventArgs e)
        {
            var tasks = MyTaskController.GetAllTasks(_currentIdUser).Item1;
            columnToDo.AddTask(tasks.Last());
        }

        /// <summary>
        /// Permet d'ajouter une nouvelle colonne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddColumn_Click(object sender, EventArgs e)
        {
            // Contrôle la limite maximum de colonnes
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

        /// <summary>
        /// Permet de supprimer la dernière colonne 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteColumn_Click(object sender, EventArgs e)
        {
            if (pnlMainContainer.Controls.Count > 2)
            {
                pnlMainContainer.Controls.RemoveAt(pnlMainContainer.Controls.Count-1);
                counter--;
            }
            else
            {
                MessageBox.Show("Limitation à 2 colonnes minimum", "Limite des colonnes");
            }
        }

    }
}
