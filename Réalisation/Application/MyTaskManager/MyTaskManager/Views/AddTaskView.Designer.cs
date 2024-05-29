namespace MyTaskManager.Views
{
    partial class AddTaskView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblImage = new System.Windows.Forms.Label();
            this.lblUrl = new System.Windows.Forms.Label();
            this.lblPriority = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.lblTaskTitle = new System.Windows.Forms.Label();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.tbxTitle = new System.Windows.Forms.TextBox();
            this.tbxText = new System.Windows.Forms.TextBox();
            this.tbxUrl = new System.Windows.Forms.TextBox();
            this.pnlDropImage = new System.Windows.Forms.Panel();
            this.datEndDate = new System.Windows.Forms.DateTimePicker();
            this.cbxPriority = new System.Windows.Forms.ComboBox();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.lblImage);
            this.panel1.Controls.Add(this.lblUrl);
            this.panel1.Controls.Add(this.lblPriority);
            this.panel1.Controls.Add(this.lblEndDate);
            this.panel1.Controls.Add(this.lblText);
            this.panel1.Controls.Add(this.lblTaskTitle);
            this.panel1.Controls.Add(this.pbxLogo);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(111, 570);
            this.panel1.TabIndex = 5;
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImage.Location = new System.Drawing.Point(57, 380);
            this.lblImage.Margin = new System.Windows.Forms.Padding(10, 10, 6, 12);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(48, 18);
            this.lblImage.TabIndex = 11;
            this.lblImage.Text = "Image";
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrl.Location = new System.Drawing.Point(36, 340);
            this.lblUrl.Margin = new System.Windows.Forms.Padding(10, 10, 6, 12);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(69, 18);
            this.lblUrl.TabIndex = 10;
            this.lblUrl.Text = "Lien URL";
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriority.Location = new System.Drawing.Point(50, 300);
            this.lblPriority.Margin = new System.Windows.Forms.Padding(10, 10, 6, 12);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(55, 18);
            this.lblPriority.TabIndex = 9;
            this.lblPriority.Text = "Priorité";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(27, 260);
            this.lblEndDate.Margin = new System.Windows.Forms.Padding(10, 10, 6, 12);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(78, 18);
            this.lblEndDate.TabIndex = 8;
            this.lblEndDate.Text = "Date de fin";
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(61, 164);
            this.lblText.Margin = new System.Windows.Forms.Padding(10, 10, 6, 12);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(44, 18);
            this.lblText.TabIndex = 7;
            this.lblText.Text = "Texte";
            // 
            // lblTaskTitle
            // 
            this.lblTaskTitle.AutoSize = true;
            this.lblTaskTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskTitle.Location = new System.Drawing.Point(68, 124);
            this.lblTaskTitle.Margin = new System.Windows.Forms.Padding(10, 10, 6, 12);
            this.lblTaskTitle.Name = "lblTaskTitle";
            this.lblTaskTitle.Size = new System.Drawing.Size(37, 18);
            this.lblTaskTitle.TabIndex = 6;
            this.lblTaskTitle.Text = "Titre";
            // 
            // pbxLogo
            // 
            this.pbxLogo.BackgroundImage = global::MyTaskManager.Properties.Resources.TPI___MyTaskManager___Logo;
            this.pbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxLogo.Location = new System.Drawing.Point(0, 0);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(110, 110);
            this.pbxLogo.TabIndex = 1;
            this.pbxLogo.TabStop = false;
            // 
            // tbxTitle
            // 
            this.tbxTitle.Location = new System.Drawing.Point(128, 124);
            this.tbxTitle.Name = "tbxTitle";
            this.tbxTitle.Size = new System.Drawing.Size(134, 20);
            this.tbxTitle.TabIndex = 6;
            // 
            // tbxText
            // 
            this.tbxText.Location = new System.Drawing.Point(128, 164);
            this.tbxText.Multiline = true;
            this.tbxText.Name = "tbxText";
            this.tbxText.Size = new System.Drawing.Size(134, 71);
            this.tbxText.TabIndex = 7;
            // 
            // tbxUrl
            // 
            this.tbxUrl.Location = new System.Drawing.Point(128, 340);
            this.tbxUrl.Name = "tbxUrl";
            this.tbxUrl.Size = new System.Drawing.Size(134, 20);
            this.tbxUrl.TabIndex = 8;
            // 
            // pnlDropImage
            // 
            this.pnlDropImage.AllowDrop = true;
            this.pnlDropImage.BackgroundImage = global::MyTaskManager.Properties.Resources.image_icon;
            this.pnlDropImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlDropImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDropImage.Location = new System.Drawing.Point(128, 380);
            this.pnlDropImage.Name = "pnlDropImage";
            this.pnlDropImage.Size = new System.Drawing.Size(110, 110);
            this.pnlDropImage.TabIndex = 9;
            this.pnlDropImage.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlDropImage_DragDrop);
            this.pnlDropImage.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnlDropImage_DragEnter);
            // 
            // datEndDate
            // 
            this.datEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datEndDate.Location = new System.Drawing.Point(128, 260);
            this.datEndDate.Name = "datEndDate";
            this.datEndDate.Size = new System.Drawing.Size(134, 20);
            this.datEndDate.TabIndex = 10;
            this.datEndDate.Value = new System.DateTime(2024, 5, 16, 0, 0, 0, 0);
            // 
            // cbxPriority
            // 
            this.cbxPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPriority.FormattingEnabled = true;
            this.cbxPriority.Items.AddRange(new object[] {
            "Urgent",
            "Haute",
            "Moyenne",
            "Faible"});
            this.cbxPriority.Location = new System.Drawing.Point(128, 300);
            this.cbxPriority.Name = "cbxPriority";
            this.cbxPriority.Size = new System.Drawing.Size(134, 21);
            this.cbxPriority.TabIndex = 11;
            // 
            // btnAddTask
            // 
            this.btnAddTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTask.Location = new System.Drawing.Point(182, 519);
            this.btnAddTask.Margin = new System.Windows.Forms.Padding(10);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(153, 30);
            this.btnAddTask.TabIndex = 12;
            this.btnAddTask.Text = "Ajouter une tâche";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(124, 38);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(176, 24);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Ajouter une tâche";
            // 
            // AddTaskView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 568);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.cbxPriority);
            this.Controls.Add(this.datEndDate);
            this.Controls.Add(this.pnlDropImage);
            this.Controls.Add(this.tbxUrl);
            this.Controls.Add(this.tbxText);
            this.Controls.Add(this.tbxTitle);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddTaskView";
            this.Text = "AddTaskView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblTaskTitle;
        private System.Windows.Forms.TextBox tbxTitle;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.TextBox tbxText;
        private System.Windows.Forms.TextBox tbxUrl;
        private System.Windows.Forms.Panel pnlDropImage;
        private System.Windows.Forms.DateTimePicker datEndDate;
        private System.Windows.Forms.ComboBox cbxPriority;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Label lblTitle;
    }
}