/// ETML
/// Auteur : Théo Ghaemmaghami
/// Date : 16.05.2024
/// Description : Vue (interface utilisateur) du formulaire de création d'un compte

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
        public UserController Controller { get; set; }

        public RegisterView()
        {
            InitializeComponent();
        }

        private void registerView_Load(object sender, EventArgs e)
        {

        }

        private void btn_createAccount_Click(object sender, EventArgs e)
        {
            bool isRegistered = Controller.RegisterNewUser(tbx_firstName.Text, tbx_lastName.Text, tbx_login.Text, tbx_password.Text);
            MessageBox.Show(isRegistered ? "Compte utilisateur créé !" : "Erreur lors de la création du compte", "Création d'un compte");
            
        }
    }
}
