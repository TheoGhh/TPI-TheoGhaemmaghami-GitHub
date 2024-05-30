using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using MyTaskManager.Models;

namespace MyTaskManager.Views
{
    public class lol : Panel
    {
        
        public int ColumnIndex { get; set; }
        public Label ColumnTitle { get; set; }

        public lol(int columnIndex)
        {
            ColumnIndex = columnIndex;
            InitializeColumn();
        }

        private void InitializeColumn()
        {
            this.Width = 200;
            this.Dock = DockStyle.Left;
            this.BorderStyle = BorderStyle.FixedSingle;

            ColumnTitle = new Label();
            ColumnTitle.Text = "Colonne " + ColumnIndex;
            ColumnTitle.Dock = DockStyle.Top;
            ColumnTitle.Height = 30;
            ColumnTitle.TextAlign = ContentAlignment.MiddleCenter;
            ColumnTitle.Font = new Font("Arial", 12, FontStyle.Bold);
            
            this.Controls.Add(ColumnTitle);
        }

        public void AddTask(MyTask task)
        {
            this.Controls.Add(task);
        }

        public void ClearTasks()
        {
            var controlsToRemove = this.Controls.OfType<MyTask>().ToList();
            foreach (var control in controlsToRemove)
            {
                this.Controls.Remove(control);
            }
        }

    }

    public class Column : Panel
    {
        private Panel _pnlColumnContainer;
        private Label _lblTitle;
        private TextBox _tbxEditTitle;
        private FlowLayoutPanel _flpnlColumn;

        const int INT_SPACING = 10;
        const int COLUMN_WIDTH = 120;

        List<Column> columns = new List<Column>();
        public Column(string strTitle)
        {
            _pnlColumnContainer = new Panel();
            _pnlColumnContainer.BorderStyle = BorderStyle.FixedSingle;
            _pnlColumnContainer.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom;           

            _lblTitle = new Label();
            _lblTitle.Text = strTitle;
            _lblTitle.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
            _lblTitle.Width = COLUMN_WIDTH;
            _lblTitle.AutoSize = true;
            _lblTitle.Location = new Point(0, 0);
            _pnlColumnContainer.Controls.Add(_lblTitle);

            _lblTitle.MouseEnter += LblTitle_MouseEnter;
            _lblTitle.MouseLeave += LblTitle_MouseLeave;
            _lblTitle.Click += LblTitle_Click;

            _flpnlColumn = new FlowLayoutPanel();
            _flpnlColumn.Size = new Size(_pnlColumnContainer.Width, _pnlColumnContainer.Height - _lblTitle.Height);
            _flpnlColumn.Location = new Point(0, _lblTitle.Bottom);
            _flpnlColumn.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom;
            _flpnlColumn.BorderStyle = BorderStyle.FixedSingle;
            _flpnlColumn.AutoScroll = true;
            _flpnlColumn.AllowDrop = true;
            _flpnlColumn.FlowDirection = FlowDirection.TopDown;
            _pnlColumnContainer.Controls.Add(_flpnlColumn);

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

        public void DisplayColumn(Panel pnlMainContainer)
        {
            _pnlColumnContainer.Size = new Size(COLUMN_WIDTH, pnlMainContainer.Height - 10);
            _pnlColumnContainer.Location = new Point(pnlMainContainer.Controls.Count * (_pnlColumnContainer.Width + INT_SPACING), 0);
            pnlMainContainer.Controls.Add(_pnlColumnContainer);
        }

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
