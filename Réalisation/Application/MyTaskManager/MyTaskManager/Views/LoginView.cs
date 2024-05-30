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

namespace MyTaskManager.Views
{
    public partial class LoginView : Form
    {
        public UserController UserController { get; set; }  // Accès Contrôleur des utilisateurs
        public MyTaskController MyTaskController { get; set; }  // Accès Contrôleurs des tâches

        public LoginView(UserController userController, MyTaskController myTaskController)
        {
            InitializeComponent();
            UserController = userController;
            MyTaskController = myTaskController;
        }

        private void btnLoginUser_Click(object sender, EventArgs e)
        {
            // Vérifie si la connexion a réussi
            if (UserController.LoginUser(tbxLogin.Text, tbxPassword.Text).Item1 != null)
            {
                // Si connexion réussie, stocke l'id de l'utilisateur connecté
                int? idCurrentUser = UserController.LoginUser(tbxLogin.Text, tbxPassword.Text).Item1;
                MessageBox.Show("Vous êtes connecté !", "Connexion de compte");

                // Si connexion réussie, instancie l'interface principale et lui transmet l'id de l'utilisateur connecté et l'accès aux Contrôleurs
                MainView mainView = new MainView(idCurrentUser, UserController, MyTaskController);
                mainView.Show();
                this.Close();
            }
            else
            {
                // Vérifie le type d'erreur : Erreur de login/mot de passe ou autre erreur
                if (UserController.LoginUser(tbxLogin.Text, tbxPassword.Text).Item2 != null)
                {
                    string errorMessage = UserController.LoginUser(tbxLogin.Text, tbxPassword.Text).Item2.Message;
                    MessageBox.Show("Erreur : " + errorMessage, "Connexion de compte");
                }
                else
                {
                    MessageBox.Show("Erreur : Login et/ou mot de passe incorrect");
                }               
            }
        }

        private void btnToCreateUser_Click(object sender, EventArgs e)
        {
            RegisterView registerView = new RegisterView(UserController);
            registerView.ShowDialog();
        }
    }
}
