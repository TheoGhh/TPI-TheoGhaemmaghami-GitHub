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
    public partial class RegisterView : Form
    {
        public UserController UserController { get; set; }

        public RegisterView(UserController userController)
        {
            InitializeComponent();
            UserController = userController;
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            if(UserController.RegisterUser(tbxFirstName.Text, tbxLastName.Text, tbxLogin.Text, tbxPassword.Text))
            {
                MessageBox.Show("Nouveau compte utilisateur crée avec succès !", "Création d'un compte");
                this.Close();
            }
            else
            {
                MessageBox.Show("Echec de la tentative de création d'un compte !", "Création de compte");
            }
            
            
        }
    }
}
