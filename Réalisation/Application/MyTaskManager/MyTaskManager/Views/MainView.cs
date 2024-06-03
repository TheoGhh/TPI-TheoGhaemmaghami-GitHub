using System;
using System.Linq;
using System.Windows.Forms;
using MyTaskManager.Controllers;
using System.Drawing;

namespace MyTaskManager.Views
{
    public partial class MainView : Form
    {        
        public UserController UserController { get; set; }  // Accès Contrôleur des utilisateurs
        public MyTaskController MyTaskController { get; set; }  // Accès Contrôleur des tâches

        private int? _currentIdUser;    // Stocke l'ID de l'utilisateur actuellement connecté

        Column columnToDo = new Column("A FAIRE");  // Colonne A FAIRE par défaut
        Column columnDone = new Column("TERMINE");  // Colonne TERMINE par défaut

        // Constructeur
        public MainView(int? idUser, UserController userController, MyTaskController myTaskController)
        {
            InitializeComponent();
            UserController = userController;       
            _currentIdUser = idUser;
            MyTaskController = myTaskController;    
        }

        /// <summary>
        /// Détermine ce qui se produit lorsque la fenêtre se charge 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainView_Load(object sender, EventArgs e)
        {
            // Affiche les 2 colonnes par défaut
            columnToDo.DisplayColumn(pnlMainContainer);
            columnDone.DisplayColumn(pnlMainContainer);

            MinimumSize = new Size(pnlMenu.Width + pnlMainContainer.Controls.Count * columnToDo.Width, pnlMenu.Height);

            // Stocke et récupère toutes les tâches de l'utilisateur connecté
            var tasks = MyTaskController.GetAllTasks(_currentIdUser).Item1;

            // Ajoute toutes les tâches à la colonne A FAIRE et les affiche
            foreach (var task in tasks)
            {
                columnToDo.AddTask(task);
                task.DisplayTask();
            }
        }

        /// <summary>
        /// Lorsque l'utilisateur clique sur le bouton "Ajouter une tâche", ouvre la vue "Ajout d'une nouvelle tâche"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddTask_Click(object sender, EventArgs e)
        {
            AddTaskView addTaskView = new AddTaskView(_currentIdUser, MyTaskController);
            addTaskView.Show();

            // Abonne l'évenement TaskAdded à la méthode correspondante
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
            tasks.Last().DisplayTask();
        }

        /// <summary>
        /// Lorsque l'utilisateur clique sur "Ajouter une colonne", permet d'ajouter une nouvelle colonne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddColumn_Click(object sender, EventArgs e)
        {
            // Contrôle la limite maximum du nombre de colonnes
            if (pnlMainContainer.Controls.Count < 6)
            {
                Column newColumn = new Column("Titre");
                newColumn.DisplayColumn(pnlMainContainer);
                
            }
            else
            {
                MessageBox.Show("Limitation à 6 colonnes maximum", "Limite des colonnes");
            }
            
        }

        /// <summary>
        /// Lorsque l'utilisateur clique sur "Supprimer une colonne", permet de supprimer la dernière colonne 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteColumn_Click(object sender, EventArgs e)
        {
            // Contrôle la limite minimum du nombre de colonnes
            if (pnlMainContainer.Controls.Count > 2)
            {
                DialogResult result = MessageBox.Show("La suppression de la dernière colonne entraînera la suppression temporaires des tâches qu'elle contient." +
                    "\n\nLa suppression n'est que visuelle. Les tâches réapparaîtront dans la première colonne lorsque vous redémarrerez l'application" +
                    "\n\n\nVoulez-vous vraiment continuer ?", 
                    "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    pnlMainContainer.Controls.RemoveAt(pnlMainContainer.Controls.Count - 1);
                }           
            }
            else
            {
                MessageBox.Show("Limitation à 2 colonnes minimum", "Limite des colonnes");
            }
        }

    }
}
