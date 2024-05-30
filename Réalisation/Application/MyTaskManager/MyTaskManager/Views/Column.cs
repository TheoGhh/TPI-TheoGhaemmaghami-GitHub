﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using MyTaskManager.Models;

namespace MyTaskManager.Views
{
 

    public class Column : Panel
    {
        private Panel _pnlColumnContainer;
        private Label _lblTitle;
        private TextBox _tbxEditTitle;
        private FlowLayoutPanel _flpnlColumn; 

        const int INT_SPACING = 10; // Espacement entre les colonnes
        const int COLUMN_WIDTH = 150; // Largeur de la colonne

        /// <summary>
        /// Constructeur 
        /// </summary>
        /// <param name="strTitle"></param>
        public Column(string strTitle)
        {
            // Conteneur de la colonne (contient le titre et la colonne)
            _pnlColumnContainer = new Panel();  
            _pnlColumnContainer.BorderStyle = BorderStyle.FixedSingle;

            // Titre de la colonne
            _lblTitle = new Label();
            _lblTitle.Text = strTitle;
            _lblTitle.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
            _lblTitle.Width = COLUMN_WIDTH;
            _lblTitle.AutoSize = true;
            _lblTitle.Location = new Point(0, 0);
            _pnlColumnContainer.Controls.Add(_lblTitle);

            // Evenements visuels et qui permettent de changer le titre de la colonne
            _lblTitle.MouseEnter += LblTitle_MouseEnter;
            _lblTitle.MouseLeave += LblTitle_MouseLeave;
            _lblTitle.Click += LblTitle_Click;

            // Colonne où vont s'afficher les tâches (zone de Drag & Drop)
            _flpnlColumn = new FlowLayoutPanel();
            _flpnlColumn.Size = new Size(_pnlColumnContainer.Width, _pnlColumnContainer.Height - _lblTitle.Height);
            _flpnlColumn.Location = new Point(0, _lblTitle.Bottom);
            _flpnlColumn.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom;      
            _flpnlColumn.AllowDrop = true;
            _flpnlColumn.FlowDirection = FlowDirection.TopDown;
            _flpnlColumn.AutoScroll = true;
            _flpnlColumn.WrapContents = false;
            _pnlColumnContainer.Controls.Add(_flpnlColumn);
            // EVENEMENTS DRAG & DROP A AJOUTER ICI ! //

            // Textbox "invisible" permettant de renommer le titre de la colonne
            _tbxEditTitle = new TextBox();
            _tbxEditTitle.Size = new Size(_flpnlColumn.Width, _lblTitle.Height);
            _tbxEditTitle.Location = _lblTitle.Location;
            _tbxEditTitle.Font = _lblTitle.Font;
            _tbxEditTitle.MaxLength = 12;
            _tbxEditTitle.Text = _lblTitle.Text;
            _tbxEditTitle.BorderStyle = BorderStyle.None;
            _tbxEditTitle.BackColor = SystemColors.Control;
            _tbxEditTitle.Hide();
            _pnlColumnContainer.Controls.Add(_tbxEditTitle);
         
            _tbxEditTitle.LostFocus += TbxEditTitle_LostFocus;
            _tbxEditTitle.KeyPress += TbxEditTitle_KeyPress;
            
        }

        /// <summary>
        /// Permet de placer et d'afficher la colonne dans l'interface principale
        /// </summary>
        /// <param name="pnlMainContainer">Conteneur pour les colonnes</param>
        public void DisplayColumn(Panel pnlMainContainer)
        {
            _pnlColumnContainer.Size = new Size(COLUMN_WIDTH, pnlMainContainer.Height - 10);
            _pnlColumnContainer.Location = new Point(pnlMainContainer.Controls.Count * (_pnlColumnContainer.Width + INT_SPACING), 0);
            _pnlColumnContainer.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom;
            pnlMainContainer.Controls.Add(_pnlColumnContainer);
        }

        /// <summary>
        /// Permet d'ajouter une tâche à une colonne
        /// </summary>
        /// <param name="task"></param>
        public void AddTask(MyTask task)
        {
            _flpnlColumn.Controls.Add(task);
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
