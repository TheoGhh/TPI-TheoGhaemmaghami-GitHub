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

namespace MyTaskManager.Views
{
    public partial class RegisterView : Form
    {
        public UserController UserController { get; set; }  // Accès Contrôleur des utilisateurs

        public RegisterView(UserController userController)
        {
            InitializeComponent();
            UserController = userController;
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            // Transmets les informations insérées au Contrôleur et vérifie si la création du nouveau compte utilisateur a fonctionnée
            if(UserController.RegisterUser(tbxFirstName.Text, tbxLastName.Text, tbxLogin.Text, tbxPassword.Text).Item1)
            {
                MessageBox.Show("Nouveau compte utilisateur crée avec succès !", "Création d'un compte");
                this.Close();
            }
            else
            {
                string errorMessage = UserController.RegisterUser(tbxFirstName.Text, tbxLastName.Text, tbxLogin.Text, tbxPassword.Text).Item2.Message;
                MessageBox.Show("Erreur : " + errorMessage, "Création de compte");
            }
        }
    }
}
