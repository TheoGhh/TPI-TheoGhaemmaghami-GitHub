using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;


namespace MyTaskManager.Models
{
    public class MyTask : Panel
    {
        // Attributs
        private string _title;              // Titre de la tâche
        private string _text;               // Texte de la tâche
        private DateTime _creationDate;     // Date de création de la tâche
        private DateTime _endDate;          // Date de fin (deadline) de la tâche
        private string _priority;           // Niveau de priorité de la tâche
        private string _url;                // Lien URL de la tâche
        private byte[] _image;              // Image de la tâche
        private readonly int? _fkUser;      // ID de l'utilisateur qui crée la tâche


        // Paramètres
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public override string Text
        {
            get { return _text; }
            set { _text = value; }
        }

        public DateTime CreationDate
        {
            get { return _creationDate; }
            set { _creationDate = value; }
        }

        public DateTime EndDate
        {
            get { return _endDate; }
            set { _endDate = value; }
        }

        public string Priority
        {
            get { return _priority; }
            set { _priority = value; }
        }

        public string Url
        {
            get { return _url; }
            set { _url = value; }
        }

        public byte[] Image
        {
            get { return _image; }
            set { _image = value; }
        }

        public int? FkUser
        {
            get { return _fkUser; }
        }

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="title">Titre de la tâche</param>
        /// <param name="text">Texte de la tâche</param>
        /// <param name="creationDate">Date de création de la tâche</param>
        /// <param name="endDate">Date de fin de la tâche</param>
        /// <param name="priority">Niveau de priorité de la tâche</param>
        /// <param name="url">Lien URL de la tâche</param>
        /// <param name="image">Image de l'URL</param>
        /// <param name="fkUser">ID de l'utilisateur connecté qui a créé la tâche</param>
        public MyTask(string title, string text, DateTime creationDate, DateTime endDate, string priority, string url, byte[] image, int? fkUser)
        {
            _title = title;
            _text = text;
            _creationDate = creationDate;
            _endDate = endDate;
            _priority = priority;
            _url = url;
            _image = image;
            _fkUser = fkUser;         
        }

        /// <summary>
        /// Affiche la tâche
        /// </summary>
        public void DisplayTask()
        {
            const int TASK_SIZE = 142;   // Taille de la tâche
            const int SPACING = 5;      // Espacement entre les attributs d'une tâche
            int horizontalDynamicPosition = 20; // Variable qui permet de placer les éléments horizontalement dans la tâche selon le nombre d'éléments présents
            
            // Définit l'apparence et la taille d'une tâche
            this.Size = new Size(TASK_SIZE, TASK_SIZE);
            this.BackColor = Color.FromArgb(255, 207, 0);
            this.BorderStyle = BorderStyle.FixedSingle;

            // Abonnent la tâche à des méthodes "d'animations visuelles" et qui permettent le déplacement des tâches
            this.MouseEnter += MyTask_MouseEnter;
            this.MouseLeave += MyTask_MouseLeave;
            this.MouseDown += MyTask_MouseDown;

            // Instancie un panel pour contenir le titre (uniquement pour le rendu visuel de la tâche)
            Panel pnlTitle = new Panel();
            pnlTitle.BorderStyle = BorderStyle.FixedSingle;
            pnlTitle.Size = new Size(TASK_SIZE + 10, horizontalDynamicPosition);
            pnlTitle.Location = new Point(-1, -1);
            this.Controls.Add(pnlTitle);

            // Instancie un label pour afficher le titre de la tâche
            Label lblTitle = new Label();
            lblTitle.Text = Title;
            lblTitle.Font = new Font("Arial", 10, FontStyle.Bold);
            lblTitle.Dock = DockStyle.Fill;
            pnlTitle.Controls.Add(lblTitle);

            // Abonnent le titre à des méthodes "d'animations visuelles" et qui permettent le déplacement des tâches
            lblTitle.MouseEnter += MyTask_MouseEnter;
            lblTitle.MouseLeave += MyTask_MouseLeave;
            lblTitle.MouseDown += MyTask_MouseDown;

            // Vérifie si la tâche possède un texte
            if (Text != "")
            {
                // Instancie un label pour afficher le texte de la tâche
                Label lblText = new Label();
                lblText.Text = Text;
                lblText.Font = new Font("Arial", 9);

                // Limite la place maximum que peut prendre le texte (3 lignes)
                lblText.MaximumSize = new Size(TASK_SIZE, 70);   
                lblText.AutoSize = true;
                lblText.Location = new Point(-1, horizontalDynamicPosition);               
                this.Controls.Add(lblText);

                // Abonnent le texte à des méthodes "d'animations visuelles" et qui permettent le déplacement des tâches
                lblText.MouseEnter += MyTask_MouseEnter;
                lblText.MouseLeave += MyTask_MouseLeave;
                lblText.MouseDown += MyTask_MouseDown;

                // Met à jour la position verticale pour le prochain élément
                horizontalDynamicPosition += lblText.Height + SPACING;
            }

            // Vérifie si la tâche possède une date de fin
            if (EndDate >= DateTime.Today)
            {
                // Instancie un label pour afficher la date de fin de la tâche
                Label lblEndDate = new Label();
                lblEndDate.Text = "Deadline : " + CreationDate.Date.ToShortDateString();
                lblEndDate.Font = new Font("Arial", 9);
                lblEndDate.AutoSize = true;
                lblEndDate.Location = new Point(-1, horizontalDynamicPosition);
                this.Controls.Add(lblEndDate);

                // Abonnent la date de fin à des méthodes "d'animations visuelles" et qui permettent le déplacement des tâches
                lblEndDate.MouseEnter += MyTask_MouseEnter;
                lblEndDate.MouseLeave += MyTask_MouseLeave;
                lblEndDate.MouseDown += MyTask_MouseDown;

                // Met à jour la position verticale pour le prochain élément
                horizontalDynamicPosition += lblEndDate.Height + SPACING;
            }

            // Vérifie si la tâche possède une priorité
            if (Priority != "")
            {
                // Instancie un label pour afficher la priorité de la tâche
                Label lblPriority = new Label();
                lblPriority.Text = "Priorité : " + Priority.ToString();
                lblPriority.Font = new Font("Arial", 9);
                lblPriority.AutoSize = true;
                lblPriority.Location = new Point(-1, horizontalDynamicPosition);
                this.Controls.Add(lblPriority);

                // Abonnent la priorité à des méthodes "d'animations visuelles" et qui permettent le déplacement des tâches
                lblPriority.MouseEnter += MyTask_MouseEnter;
                lblPriority.MouseLeave += MyTask_MouseLeave;
                lblPriority.MouseDown += MyTask_MouseDown;

                // Met à jour la position verticale pour le prochain élément
                horizontalDynamicPosition += lblPriority.Height + SPACING;
            }

            // Vérifie si la tâche possède un lien URL
            if (Url != "")
            {
                // Instancie un label pour afficher le lien URL de la tâche
                Label lblUrl = new Label();
                lblUrl.Text = "Lien URL";
                lblUrl.ForeColor = Color.DarkBlue;
                lblUrl.Font = new Font("Arial", 9, FontStyle.Underline);
                lblUrl.AutoSize = true;
                lblUrl.Location = new Point(-1, horizontalDynamicPosition);

                // Abonnent le lien URL à des méthodes "d'animations visuelles" et qui permettent de rendre le lien effectif lorsque l'utilisateur clique dessus
                lblUrl.MouseEnter += LblUrl_MouseEnter;
                lblUrl.MouseLeave += LblUrl_MouseLeave;
                lblUrl.Click += LblUrl_Click;

                this.Controls.Add(lblUrl);

                // Met à jour la position verticale pour le prochain élément
                horizontalDynamicPosition += lblUrl.Height + SPACING;
            }

            // Vérifie si la tâche possède une image
            if (_image != null)
            {
                // Instancie un Picturebox pour afficher l'image de la tâche
                PictureBox pbxImage = new PictureBox();
                pbxImage.Size = new Size(30, 30);          
                pbxImage.SizeMode = PictureBoxSizeMode.StretchImage;
                pbxImage.Location = new Point(-1, horizontalDynamicPosition);
                this.Controls.Add(pbxImage);
            }
        }

        /// <summary>
        /// Lorsque le curseur de l'utilisateur quitte la zone de la tâche, rétablis la couleur de la tâche par défaut
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyTask_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 207, 0);
        }

        /// <summary>
        /// Lorsque le curseur de l'utilisateur passe sur la tâche, change la couleur de la tâche
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyTask_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 195, 0);
        }

        /// <summary>
        /// Lorsque l'utilisateur fait un clic-gauche sur la tâche, permet le déplacement (pour le drag & drop) de cette dernière 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyTask_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DoDragDrop(this, DragDropEffects.Move);
            }
        }

        /// <summary>
        /// Lorsque le curseur de l'utilisateur quitte la zone de l'URL, rétablis le curseur par défaut
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LblUrl_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        /// <summary>
        /// Lorsque le curseur de l'utilisateur passe sur l'URL, change le curseur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LblUrl_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        /// <summary>
        /// Lorsque l'utilisateur clique sur l'URL, le lien URL s'ouvre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LblUrl_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(Url);
            }
            catch (Exception)
            { 

            }         
        }
    }   
}
