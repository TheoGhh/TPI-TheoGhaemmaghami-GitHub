/// ETML
/// Auteur : Théo Ghaemmaghami
/// Date : 23.05.2024
/// Description : Objet Tâche
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MyTaskManager.Models
{
    public class MyTask
    {
        // Attributs
        private string _title;
        private string _description;
        private DateTime _creationDate;
        private DateTime _endDate;
        private int _priority;
        private string _url;
        private Image _image;

        // Paramètres
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public DateTime CreationDate
        {
            get { return _creationDate; }
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

        public Image Image
        {
            get { return _image; }
            set { _image = value; }
        }

        public MyTask(string title, string description, DateTime endDate, int priority, string url, Image image)
        {
            _title = title;
            _description = description;
            _endDate = endDate;
            _priority = priority;
            _url = url;
            _image = image;
        }
    }
}
