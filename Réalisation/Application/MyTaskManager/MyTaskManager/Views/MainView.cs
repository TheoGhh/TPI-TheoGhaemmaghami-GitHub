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
        List<Panel> panelList = new List<Panel>();
        
        private TextBox tbxEditTitle = new TextBox();

        public MainView()
        {
            InitializeComponent();
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            tbxEditTitle.Hide();
            tbxEditTitle.MaxLength = 15;
            tbxEditTitle.Size = label1.Size;
            tbxEditTitle.Location = label1.Location;           
            tbxEditTitle.Leave += EditTextBox_Leave; // Gère la perte de focus
            tbxEditTitle.KeyPress += EditTextBox_KeyPress; // Gère la pression sur la touche Entrée
            panel1.Controls.Add(tbxEditTitle);


     
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
            }
        }
        private void UpdateLabel()
        {
            label1.Text = tbxEditTitle.Text; // Met à jour le texte du label
            tbxEditTitle.Hide(); // Cache le TextBox
            label1.Show();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
            label1.Hide();
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

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
