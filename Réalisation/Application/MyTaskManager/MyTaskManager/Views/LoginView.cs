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
        public UserController UserController { get; set; }
        public MyTaskController MyTaskController { get; set; }

        public LoginView(UserController userController, MyTaskController myTaskController)
        {
            InitializeComponent();
            UserController = userController;
            MyTaskController = myTaskController;
        }

        private void btnLoginUser_Click(object sender, EventArgs e)
        {
            
            if (UserController.LoginUser(tbxLogin.Text, tbxPassword.Text) != null)
            {
                int? idCurrentUser = UserController.LoginUser(tbxLogin.Text, tbxPassword.Text);
                MessageBox.Show("Vous êtes connecté !", "Connexion de compte");
                MainView mainView = new MainView(idCurrentUser, UserController, MyTaskController);
                mainView.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Echec de la tentative de connexion...", "Création de compte");
            }
        }

        private void btnToCreateUser_Click(object sender, EventArgs e)
        {
            RegisterView registerView = new RegisterView(UserController);
            registerView.ShowDialog();
        }
    }
}
