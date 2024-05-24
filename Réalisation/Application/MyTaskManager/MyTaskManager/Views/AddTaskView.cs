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
    public partial class AddTaskView : Form
    {
        public MyTaskController Controller { get; set; }
        public AddTaskView()
        {
            InitializeComponent();
        }

        private void AddTaskView_Load(object sender, EventArgs e)
        {

        }

        private void btn_loginAccount_Click(object sender, EventArgs e)
        {

        }
    }
}
