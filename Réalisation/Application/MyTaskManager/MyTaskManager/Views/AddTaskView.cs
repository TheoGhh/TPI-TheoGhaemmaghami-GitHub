using MyTaskManager.Controllers;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MyTaskManager.Views
{
    public partial class AddTaskView : Form
    {
        public MyTaskController MyTaskController { get; set; }  // Accès au Contrôleur des tâches

        private readonly int? _idCurrentUser;   // ID de l'utilisateur actuellement connecté
        private byte[] _imgData;    // Tableau d'octets pour stocker les données de l'image                   

        // Evenement déclenché lorsqu'une tâche est ajoutée
        public event EventHandler TaskAdded;

        // Constructeur
        public AddTaskView(int? idUser, MyTaskController myTaskController)
        {
            InitializeComponent();
            _idCurrentUser = idUser;
            MyTaskController = myTaskController;   
        }

        /// <summary>
        /// Lorsque l'utilisateur clique sur le bouton "Ajouter une tâche", lance le processus de création d'une nouvelle tâche
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddTask_Click(object sender, EventArgs e)
        {
            // Vérifie que la tâche possède au moins titre
            if (tbxTitle.Text != "")
            {
                // Lance le processus d'ajout d'une tâche (envoi des informations au Contrôleur) et stocke le résultat de l'opération
                bool isSuccess = MyTaskController.AddTask(
                    tbxTitle.Text, 
                    tbxText.Text, 
                    datEndDate.Value, 
                    cbxPriority.Text, 
                    tbxUrl.Text, 
                    _imgData, 
                    _idCurrentUser).Item1;

                // Vérifie si l'ajout d'une nouvelle tâche a réussi
                if (isSuccess)
                {
                    MessageBox.Show("Nouvelle tâche ajoutée avec succès !", "Ajout d'une nouvelle tâche");

                    // Déclenche l'évenement TaskAdded
                    TaskAdded?.Invoke(this, EventArgs.Empty);
                    this.Close();
                }
                else
                {
                    // Stocke le message d'erreur 
                    string errorMessage = MyTaskController.AddTask(
                        tbxTitle.Text, 
                        tbxText.Text, 
                        datEndDate.Value, 
                        cbxPriority.Text, 
                        tbxUrl.Text,
                        _imgData, 
                        _idCurrentUser).Item2.Message;

                    // Affiche le message d'erreur si l'ajout de la tâche a échoué
                    MessageBox.Show("Erreur : " + errorMessage, "Ajout d'une nouvelle tâche");
                }
            }
            else
            {
                // Affiche un message d'erreur si le champ "Titre" n'a pas été rempli
                lblTitleEmpty.Visible = true;
                tbxTitle.BackColor = Color.LightCoral;
            }
         
        }

        /// <summary>
        /// Evenement lorsque un élément est glissé par-dessus le contrôle
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
                    MessageBox.Show("Erreur : " + ex.Message);
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
