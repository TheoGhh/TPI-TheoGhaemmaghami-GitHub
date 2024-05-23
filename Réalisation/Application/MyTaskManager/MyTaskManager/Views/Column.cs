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

        public Label LblTitle
        {
            get { return _lblTitle; }
            set { _lblTitle = value; }
        }

        public TextBox TbxEditTitle
        {
            get { return _tbxEditTitle; }
            set { _tbxEditTitle = value; }
        }

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

            LblTitle = new Label();
            LblTitle.Text = strTitle;
            LblTitle.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
            LblTitle.AutoSize = true;
            LblTitle.Location = new Point(0, 0);
            pnlContainer.Controls.Add(LblTitle);

            LblTitle.MouseEnter += LblTitle_MouseEnter;
            LblTitle.MouseLeave += LblTitle_MouseLeave;
            LblTitle.Click += LblTitle_Click;  

            Panel pnlColumn = new Panel();
            pnlColumn.Size = new Size(INT_WIDTH_CONTAINER, INT_HEIGHT_CONTAINER - LblTitle.Height);
            pnlColumn.Location = new Point(0, LblTitle.Bottom);
            pnlColumn.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pnlColumn.BorderStyle = BorderStyle.FixedSingle;
            pnlColumn.AutoScroll = true;
            pnlColumn.AllowDrop = true;
            pnlContainer.Controls.Add(pnlColumn);

            TbxEditTitle = new TextBox();
            TbxEditTitle.Size = new Size(pnlColumn.Width, LblTitle.Height);
            TbxEditTitle.Location = LblTitle.Location;
            TbxEditTitle.Font = LblTitle.Font;
            TbxEditTitle.MaxLength = 15;
            TbxEditTitle.Text = LblTitle.Text;
            TbxEditTitle.BorderStyle = BorderStyle.None;
            TbxEditTitle.BackColor = SystemColors.Control;
            TbxEditTitle.Hide();
            pnlContainer.Controls.Add(TbxEditTitle);

            TbxEditTitle.LostFocus += TbxEditTitle_LostFocus;
            TbxEditTitle.KeyPress += TbxEditTitle_KeyPress;
        }

        /// <summary>
        /// Lorsque l'utilisateur passe le curseur sur un titre, le titre change de couleur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LblTitle_MouseEnter(object sender, EventArgs e)
        {
            LblTitle.ForeColor = Color.Gray;
        }

        /// <summary>
        /// Lorsque l'utilisateur sort son curseur de la zone du titre, le titre reprend sa couleur initiale
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LblTitle_MouseLeave(object sender, EventArgs e)
        {
            LblTitle.ForeColor = Color.Black;
        }

        /// <summary>
        /// Lorsque l'utilisateur clique, lance le "processus" de renommage de la colonne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LblTitle_Click(object sender, EventArgs e)
        {
            LblTitle.Hide();
            TbxEditTitle.Show();
            TbxEditTitle.Focus();
        }

        /// <summary>
        /// Met à jour le titre 
        /// </summary>
        private void UpdateLabel()
        {
            LblTitle.Text = TbxEditTitle.Text;
            TbxEditTitle.Hide();
            LblTitle.Show();
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
