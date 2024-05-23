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
            
        }

   

        /// <summary>
        /// Clic du bouton qui ajoute une nouvelle colonne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddColumn_Click(object sender, EventArgs e)
        {
            int columnIndex = columnsList.Count + 1;
            if (columnsList.Count < 6)
            {
                Column newColumn = new Column("Colonne " + columnIndex, pnlMainContent);
                columnsList.Add(newColumn);
            }
        }

        private void btnDeleteColumn_Click(object sender, EventArgs e)
        {
            if (columnsList.Count > 2)
            {
                Column columnToDelete = columnsList[columnsList.Count - 1];
                columnsList.Remove(columnToDelete);
                pnlMainContent.Controls.Remove(columnToDelete);
            }
        }
    }
}
