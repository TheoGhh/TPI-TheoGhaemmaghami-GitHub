﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Diagnostics;

namespace MyTaskManager.Models
{
    public class MyTask : Panel
    {
        // Attributs
        private string _title;
        private string _text;
        private DateTime _creationDate;
        private DateTime _endDate;
        private int _priority;
        private string _url;
        private byte[] _image;
        private readonly int? _fkUser;

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

        public int Priority
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

        public MyTask(string title, string text, DateTime creationDate,DateTime endDate, int priority, string url, byte[] image, int? fkUser)
        {
            _title = title;
            _text = text;
            _creationDate = creationDate;
            _endDate = endDate;
            _priority = priority;
            _url = url;
            _image = image;
            _fkUser = fkUser;

            DisplayTask();

            this.MouseDown += MyTask_MouseDown;

        }

        private void MyTask_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DoDragDrop(this, DragDropEffects.Move);
            }
        }

        

        public void DisplayTask()
        {
            const int INT_SIZE = 135;
            int counter = 0;

            this.Size = new Size(INT_SIZE, INT_SIZE);
            this.BackColor = Color.FromArgb(255, 207, 0);
            this.BorderStyle = BorderStyle.FixedSingle;

            Panel pnlTitle = new Panel();
            pnlTitle.BorderStyle = BorderStyle.FixedSingle;
            pnlTitle.Size = new Size(INT_SIZE + 10, INT_SIZE * 20 / 100);
            pnlTitle.Location = new Point(-1, -1);
            this.Controls.Add(pnlTitle);

            Label lblTitle = new Label();
            lblTitle.Text = Title;
            lblTitle.Font = new Font("Arial", 11, FontStyle.Bold);
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            pnlTitle.Controls.Add(lblTitle);

            if (Text != "")
            {
                Label lblText = new Label();
                lblText.Text = Text;
                lblText.Font = new Font("Arial", 9);
                lblText.AutoSize = true;
                lblText.Location = new Point(-1, pnlTitle.Bottom + 5);
                lblText.MaximumSize = new Size(INT_SIZE, INT_SIZE * 75 / 100);
                this.Controls.Add(lblText);
                counter++;
            }

            if (EndDate >= DateTime.Today)
            {
                Label lblEndDate = new Label();
                lblEndDate.Text = "Deadline : " + CreationDate.Date.ToShortDateString();
                lblEndDate.Font = new Font("Arial", 9);
                lblEndDate.AutoSize = true;
                lblEndDate.Location = new Point(-1, counter * 5);
                lblEndDate.MaximumSize = new Size(INT_SIZE, INT_SIZE * 75 / 100);
                this.Controls.Add(lblEndDate);
                counter++;
            }
            

            Label lblPriority = new Label();
            lblPriority.Text = "Priorité : " + Priority.ToString();
            lblPriority.Font = new Font("Arial", 9);
            lblPriority.AutoSize = true;
            //lblPriority.Location = new Point(-1, lblEndDate.Bottom + 5);
            lblPriority.MaximumSize = new Size(INT_SIZE, INT_SIZE * 75 / 100);
            this.Controls.Add(lblPriority);

            if (!string.IsNullOrEmpty(Url))
            {
                Label lblUrl = new Label();
                lblUrl.Text = "Lien URL";
                lblUrl.ForeColor = Color.DarkBlue;
                lblUrl.Font = new Font("Arial", 9, FontStyle.Underline);
                lblUrl.AutoSize = true;
                lblUrl.Location = new Point(-1, lblPriority.Bottom + 5);
                lblUrl.MaximumSize = new Size(INT_SIZE, INT_SIZE * 75 / 100);

                lblUrl.Click += LblUrl_Click;

                this.Controls.Add(lblUrl);
            }

            

            /*if (_image != null && _image.Length > 0)
            {
                PictureBox pbxImage = new PictureBox();
                pbxImage.Image = ByteArrayToImage(_image);
                pbxImage.Size = new Size(INT_SIZE, INT_SIZE);
                pbxImage.SizeMode = PictureBoxSizeMode.StretchImage;
                pbxImage.Location = new Point(-1, lblPriority.Bottom + 5);
                this.Controls.Add(pbxImage);
            }*/
        }

        private void LblUrl_Click(object sender, EventArgs e)
        {
            Process.Start(Url);
            
        }
        /*private Image ByteArrayToImage(byte[] byteArray)
{
   using (MemoryStream ms = new MemoryStream(byteArray))
   {
       return Image.FromS;
   }
}*/
    }
}
