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

namespace MyTaskManager
{
    public partial class LoginView : Form
    {
        public UserController Controller { get; set; }

        public LoginView()
        {
            InitializeComponent();
        }

        private void loginView_Load(object sender, EventArgs e)
        {

        }

        private void btn_loginAccount_Click(object sender, EventArgs e)
        {
            bool isLogged = Controller.LoginUser(tbx_loginLogin.Text, tbx_loginPassword.Text);
            MessageBox.Show(isLogged ? "Vous êtes connecté !" : "Erreur lors de la connexion", "Connexion à un compte");
            
        }
    }
}
