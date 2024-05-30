using MySql.Data.MySqlClient;
using MyTaskManager.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTaskManager.Views
{
    public partial class AddTaskView : Form
    {
        public MyTaskController MyTaskController { get; set; }

        private readonly int? _idCurrentUser;
        private byte[] _imgData;

        public event EventHandler TaskAdded;

        public AddTaskView(int? idUser, MyTaskController myTaskController)
        {
            InitializeComponent();
            _idCurrentUser = idUser;
            MyTaskController = myTaskController;
            datEndDate.MinDate = DateTime.Today;
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (MyTaskController.AddTask(tbxTitle.Text, tbxText.Text, datEndDate.Value, cbxPriority.SelectedIndex, tbxUrl.Text, _imgData, _idCurrentUser).Item1)
            {
                MessageBox.Show("Nouvelle tâche ajoutée avec succès !", "Ajout d'une nouvelle tâche");
                TaskAdded?.Invoke(this, EventArgs.Empty);
                this.Close();
            }
            else
            {
                MessageBox.Show("Erreur : " + MyTaskController.AddTask(tbxTitle.Text, tbxText.Text, datEndDate.Value, cbxPriority.SelectedIndex, tbxUrl.Text, _imgData, _idCurrentUser).Item2.Message, "Ajout d'une nouvelle tâche");
            }    
        }

        /// <summary>
        /// Copie l'image qui se trouve 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlDropImage_DragEnter(object sender, DragEventArgs e)
        {
            // Vérifie si l'élément glissé est un fichier
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                // Copie l'élément dans le panel
                e.Effect = DragDropEffects.Copy;
        }

        /// <summary>
        /// Détermine ce qui se produit lorsque un élément est déposé dans le panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlDropImage_DragDrop(object sender, DragEventArgs e)
        {
            // Stocke l'élément déposé sous forme de tableau de chaînes
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            // Vérifie si au moins un fichier a été déposé
            if (files.Length > 0)
            {
                try
                {                  
                    Image image = Image.FromFile(files[0]);

                    // Affichage l'image dans le panel
                    pnlDropImage.BackgroundImage = image;
                    pnlDropImage.BackgroundImageLayout = ImageLayout.Stretch;

                    // Stocke et convertit l'image en tableau d'octets
                    _imgData = ImageToByteArray(image);

                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        /// <summary>
        /// Convertit l'image en tableau d'octets
        /// </summary>
        /// <param name="image">Image que l'utilisateur a Drag & Drop</param>
        /// <returns>Retourne un tableau d'octets</returns>
        private byte[] ImageToByteArray(Image image)
        {
            
            using (MemoryStream ms = new MemoryStream())
            {
                // Sauvegarde l'image (Format JPEG car réduit la taille que prend l'image)
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                // Convertit le résultat en tableau d'octets.
                return ms.ToArray();
            }
        }       
    }
}
