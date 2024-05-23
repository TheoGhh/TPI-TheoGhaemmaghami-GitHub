using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace MyTaskManager.Views
{
    public class Column : Panel
    {
        private Label _lblTitle;
        private TextBox _tbxEditTitle;


        public Column(string strTitle, Panel pnlMainContainer)
        {
            const int INT_WIDTH_CONTAINER = 170;
            const int INT_HEIGHT_CONTAINER = 590;
            const int INT_SPACING = 10;


            int panelIndex = pnlMainContainer.Controls.Count + 1;

            Panel pnlContainer = new Panel();
            pnlContainer.Name = "pnlContainer" + panelIndex;
            pnlContainer.Size = new Size(INT_WIDTH_CONTAINER, INT_HEIGHT_CONTAINER);
            pnlContainer.Location = new Point(pnlMainContainer.Controls.Count * (INT_WIDTH_CONTAINER + INT_SPACING), 0);
            pnlContainer.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom;
            pnlMainContainer.Controls.Add(pnlContainer);

            _lblTitle = new Label();
            _lblTitle.Text = strTitle;
            _lblTitle.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
            _lblTitle.AutoSize = true;
            _lblTitle.Location = new Point(0, 0);
            pnlContainer.Controls.Add(_lblTitle);

            _lblTitle.MouseEnter += LblTitle_MouseEnter;
            _lblTitle.MouseLeave += LblTitle_MouseLeave;
            _lblTitle.Click += LblTitle_Click;  

            Panel pnlColumn = new Panel();
            pnlColumn.Size = new Size(INT_WIDTH_CONTAINER, INT_HEIGHT_CONTAINER - _lblTitle.Height);
            pnlColumn.Location = new Point(0, _lblTitle.Bottom);
            pnlColumn.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pnlColumn.BorderStyle = BorderStyle.FixedSingle;
            pnlColumn.AutoScroll = true;
            pnlColumn.AllowDrop = true;
            pnlContainer.Controls.Add(pnlColumn);

            _tbxEditTitle = new TextBox();
            _tbxEditTitle.Size = new Size(pnlColumn.Width, _lblTitle.Height);
            _tbxEditTitle.Location = _lblTitle.Location;
            _tbxEditTitle.Font = _lblTitle.Font;
            _tbxEditTitle.MaxLength = 15;
            _tbxEditTitle.Text = _lblTitle.Text;
            _tbxEditTitle.BorderStyle = BorderStyle.None;
            _tbxEditTitle.BackColor = SystemColors.Control;
            _tbxEditTitle.Hide();
            pnlContainer.Controls.Add(_tbxEditTitle);

            _tbxEditTitle.LostFocus += TbxEditTitle_LostFocus;
            _tbxEditTitle.KeyPress += TbxEditTitle_KeyPress;

        }

 

        /// <summary>
        /// Lorsque l'utilisateur passe le curseur sur un titre, le titre change de couleur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LblTitle_MouseEnter(object sender, EventArgs e)
        {
            _lblTitle.ForeColor = Color.Gray;
        }

        /// <summary>
        /// Lorsque l'utilisateur sort son curseur de la zone du titre, le titre reprend sa couleur initiale
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LblTitle_MouseLeave(object sender, EventArgs e)
        {
            _lblTitle.ForeColor = Color.Black;
        }

        /// <summary>
        /// Lorsque l'utilisateur clique, lance le "processus" de renommage de la colonne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LblTitle_Click(object sender, EventArgs e)
        {
            _lblTitle.Hide();
            _tbxEditTitle.Show();
            _tbxEditTitle.Focus();
        }

        /// <summary>
        /// Met à jour le titre 
        /// </summary>
        private void UpdateLabel()
        {
            _lblTitle.Text = _tbxEditTitle.Text;
            _tbxEditTitle.Hide();
            _lblTitle.Show();
        }

        /// <summary>
        /// Si l'utilisateur clique ailleurs (sur un bouton par exemple), le titre de la colonne est mis à jour
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbxEditTitle_LostFocus(object sender, EventArgs e)
        {   
            UpdateLabel();      
        }

        /// <summary>
        /// Si l'utilisateur appuie sur Enter, le titre de la colonne est mis à jour
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbxEditTitle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                UpdateLabel();
            }
        }

        
    }
}
