using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTaskManager.Views
{
    public partial class MainView : Form
    {
        private TextBox tbxEditTitle = new TextBox();

        public MainView()
        {
            InitializeComponent();
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            tbxEditTitle.Size = label1.Size;
            tbxEditTitle.Location = label1.Location;
            tbxEditTitle.Hide();
            tbxEditTitle.Leave += EditTextBox_Leave; // Gère la perte de focus
            tbxEditTitle.KeyPress += EditTextBox_KeyPress; // Gère la pression sur la touche Entrée

        }
        private void EditTextBox_Leave(object sender, EventArgs e)
        {
            UpdateLabel(); // Met à jour le label quand le TextBox perd le focus
        }

        private void EditTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Vérifie si la touche Entrée est pressée
            if (e.KeyChar == (char)Keys.Enter)
            {
                UpdateLabel(); // Met à jour le label et cache le TextBox
                e.Handled = true; // Indique que l'événement de touche est géré
            }
        }
        private void UpdateLabel()
        {
            label1.Text = tbxEditTitle.Text; // Met à jour le texte du label
            tbxEditTitle.Hide(); // Cache le TextBox
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
            tbxEditTitle.Text = label1.Text;
            tbxEditTitle.Show();
            tbxEditTitle.Focus();
        }

        private void lblTitle_MouseUp(object sender, MouseEventArgs e)
        {
            label1.ForeColor = Color.Gray;
            this.Cursor = Cursors.Hand;
            
        }

        private void lblTitle_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            label1.ForeColor = Color.Black;
        }
    }
}
