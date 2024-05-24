using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyTaskManager.Controllers;

namespace MyTaskManager.Views
{
    public partial class AddTaskView : Form
    {
        public MyTaskController Controller { get; set; }
        public AddTaskView()
        {
            InitializeComponent();
        }

        private void AddTaskView_Load(object sender, EventArgs e)
        {
            pnlDropImage.Size = pbxImage.Size;
            pnlDropImage.AllowDrop = true;

            pnlDropImage.DragEnter += PnlDropImage_DragEnter;
            pnlDropImage.DragDrop += PnlDropImage_DragDrop;
        }

        private void PnlDropImage_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void PnlDropImage_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length > 0)
            {             
                Image image = Image.FromFile(files[0]);
                AddImage(image);
            }   
        }

        private void AddImage(Image image)
        {
            pbxImage.BackgroundImage = image;
            pbxImage.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {

        }
    }
}
