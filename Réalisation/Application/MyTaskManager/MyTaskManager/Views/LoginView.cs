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
            
            MainView mainView = new MainView();
            mainView.UserController = Controller;
            mainView.ShowDialog();
            this.Hide();
        }

        private void btnRegisterAccount_Click(object sender, EventArgs e)
        {
            RegisterView registerView = new RegisterView();
            registerView.Controller = Controller;
            registerView.ShowDialog();
        }
    }
}
