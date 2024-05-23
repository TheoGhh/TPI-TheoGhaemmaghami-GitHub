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
        List<Column> columnsList = new List<Column>();
        
        private TextBox tbxEditTitle = new TextBox();

        public MainView()
        {
            InitializeComponent();
            
        }

        private void MainView_Load(object sender, EventArgs e)
        { 
            Column column = new Column("A FAIRE", pnlMainContent);
            Column column2 = new Column("TERMINE", pnlMainContent);
            columnsList.Add(column);
            columnsList.Add(column2);
            //AddNewPanel("A FAIRE");
            //AddNewPanel("TERMINE");


            //tbxEditTitle.Hide();

            //// Style de la textbox
            //tbxEditTitle.BorderStyle = BorderStyle.None;
            //tbxEditTitle.Font = label1.Font;
            //tbxEditTitle.BackColor = SystemColors.Control;
            //tbxEditTitle.MaxLength = 15;

            //// Position (dynamique) de la textbox
            //tbxEditTitle.Size = new Size(panel2.Width, label1.Height);
            //tbxEditTitle.Location = label1.Location;


            //tbxEditTitle.Leave += EditTextBox_Leave;
            //tbxEditTitle.KeyPress += EditTextBox_KeyPress;
            //panel1.Controls.Add(tbxEditTitle);
        }

        

        /// <summary>
        /// Méthode permettant d'instancier 
        /// </summary>
        private void AddNewPanel(string strTitle)
        {
            //const int INT_WIDTH_CONTAINER = 170;
            //const int INT_HEIGHT_CONTAINER = 590;
            //const int INT_SPACING = 10;

            //int panelIndex = panelList.Count() + 1;
            
            //Panel pnlContainer = new Panel();
            //pnlContainer.Name = "pnlContainer" + panelIndex;
            //pnlContainer.Size = new Size(INT_WIDTH_CONTAINER, INT_HEIGHT_CONTAINER);
            //pnlContainer.Location = new Point(panelList.Count * (INT_WIDTH_CONTAINER + INT_SPACING), 0);
            //pnlContainer.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom;
            //pnlMainContent.Controls.Add(pnlContainer);
            
            //Label lblTitle = new Label(); 
            //lblTitle.Text = strTitle;
            //lblTitle.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
            //lblTitle.AutoSize = true;
            //lblTitle.Location = new Point(0, 0);
            //pnlContainer.Controls.Add(lblTitle);

            //lblTitle.MouseEnter += LblTitle_MouseEnter; 
            //lblTitle.MouseLeave += lblTitle_MouseLeave;

            //Panel pnlColumn = new Panel();
            //pnlColumn.Size = new Size(INT_WIDTH_CONTAINER, INT_HEIGHT_CONTAINER-lblTitle.Height);
            //pnlColumn.Location = new Point(0, lblTitle.Bottom);
            //pnlColumn.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            //pnlColumn.BorderStyle = BorderStyle.FixedSingle;
            //pnlColumn.AutoScroll = true;
            //pnlColumn.AllowDrop = true;
            //pnlContainer.Controls.Add(pnlColumn);

            //panelList.Add(pnlContainer);
        }

        //private void LblTitle_MouseEnter(object sender, EventArgs e)
        //{
        //    Label lblTitle = sender as Label;
        //    lblTitle.ForeColor = Color.Gray;
        //    this.Cursor = Cursors.Hand;
        //}

        //private void EditTextBox_Leave(object sender, EventArgs e)
        //{
        //    Label lblTitle = sender as Label;
        //    UpdateLabel(lblTitle); // Met à jour le label quand le TextBox perd le focus
        //}

        //private void EditTextBox_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    Label lblTitle = sender as Label;
        //    // Vérifie si la touche Entrée est pressée
        //    if (e.KeyChar == (char)Keys.Enter)
        //    {
        //        UpdateLabel(lblTitle); 
        //    }
        //}

        ///// <summary>
        ///// 
        ///// </summary>
        //private void UpdateLabel(Label labelToUpdate)
        //{
        //    labelToUpdate.Text = tbxEditTitle.Text; // Met à jour le texte du label
        //    tbxEditTitle.Hide(); 
        //    labelToUpdate.Show();
        //}

        //private void lblTitle_Click(object sender, EventArgs e)
        //{
        //    Label lblTitle = sender as Label;
        //    lblTitle.Hide();
        //    tbxEditTitle.Show();
        //    tbxEditTitle.Focus();
        //}

        //private void lblTitle_MouseLeave(object sender, EventArgs e)
        //{
        //    Label lblTitle = sender as Label;
        //    lblTitle.ForeColor = Color.Black;
        //    this.Cursor = Cursors.Default;
            
        //}

        private void btnAddColumn_Click(object sender, EventArgs e)
        {
            int columnIndex = columnsList.Count + 1;
            if (columnsList.Count < 6)
            {
                Column newColumn = new Column("Colonne " + columnIndex, pnlMainContent);
                columnsList.Add(newColumn);
            }
        }

    }
}
