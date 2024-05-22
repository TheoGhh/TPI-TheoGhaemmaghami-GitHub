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

            AddNewPanel();

            tbxEditTitle.Hide();

            // Style de la textbox
            tbxEditTitle.BorderStyle = BorderStyle.None;
            tbxEditTitle.Font = label1.Font;
            tbxEditTitle.BackColor = SystemColors.Control;
            tbxEditTitle.MaxLength = 15;

            // Position (dynamique) de la textbox
            tbxEditTitle.Size = new Size(panel2.Width, label1.Height);
            tbxEditTitle.Location = label1.Location; 
            

            tbxEditTitle.Leave += EditTextBox_Leave; 
            tbxEditTitle.KeyPress += EditTextBox_KeyPress; 
            panel1.Controls.Add(tbxEditTitle);
        }

        /// <summary>
        /// Méthode permettant d'instancier 
        /// </summary>
        private void AddNewPanel()
        {
            const int INT_WIDTH_CONTAINER = 170;
            const int INT_HEIGHT_CONTAINER = 590;

            Panel pnlContainer = new Panel();
            pnlContainer.Size = new Size(INT_WIDTH_CONTAINER, INT_HEIGHT_CONTAINER);
            pnlContainer.Location = new Point(0, 0);
            pnlContainer.BorderStyle = BorderStyle.FixedSingle;
            pnlContainer.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom;
            pnlMainContent.Controls.Add(pnlContainer);
            
            Label lblTitle = new Label();
            

            Panel pnlColumn = new Panel();
            pnlColumn.Size = new Size();
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
                UpdateLabel(); 
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void UpdateLabel()
        {
            label1.Text = tbxEditTitle.Text; // Met à jour le texte du label
            tbxEditTitle.Hide(); 
            label1.Show();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
            label1.Hide();
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
