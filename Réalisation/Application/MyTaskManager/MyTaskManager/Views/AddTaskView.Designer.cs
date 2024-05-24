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
            this.pnl_BackgroundDesign1 = new System.Windows.Forms.Panel();
            this.lblPriority = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblURL = new System.Windows.Forms.Label();
            this.lblImage = new System.Windows.Forms.Label();
            this.tbxTitle = new System.Windows.Forms.TextBox();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.datEndDate = new System.Windows.Forms.DateTimePicker();
            this.cbxPriority = new System.Windows.Forms.ComboBox();
            this.tbxURL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_loginAccount = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbx_logo = new System.Windows.Forms.PictureBox();
            this.pnl_BackgroundDesign1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_BackgroundDesign1
            // 
            this.pnl_BackgroundDesign1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.pnl_BackgroundDesign1.Controls.Add(this.lblImage);
            this.pnl_BackgroundDesign1.Controls.Add(this.lblURL);
            this.pnl_BackgroundDesign1.Controls.Add(this.lblPriority);
            this.pnl_BackgroundDesign1.Controls.Add(this.lblEndDate);
            this.pnl_BackgroundDesign1.Controls.Add(this.lblDescription);
            this.pnl_BackgroundDesign1.Controls.Add(this.lblTitle);
            this.pnl_BackgroundDesign1.Controls.Add(this.pbx_logo);
            this.pnl_BackgroundDesign1.Location = new System.Drawing.Point(0, 1);
            this.pnl_BackgroundDesign1.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_BackgroundDesign1.Name = "pnl_BackgroundDesign1";
            this.pnl_BackgroundDesign1.Size = new System.Drawing.Size(133, 586);
            this.pnl_BackgroundDesign1.TabIndex = 1;
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriority.Location = new System.Drawing.Point(69, 319);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(53, 17);
            this.lblPriority.TabIndex = 6;
            this.lblPriority.Text = "Priorité";
            this.lblPriority.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(45, 279);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(77, 17);
            this.lblEndDate.TabIndex = 5;
            this.lblEndDate.Text = "Date de fin";
            this.lblEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(43, 209);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(79, 17);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Description";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(85, 169);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(37, 17);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Titre";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblURL.Location = new System.Drawing.Point(55, 359);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(67, 17);
            this.lblURL.TabIndex = 7;
            this.lblURL.Text = "Lien URL";
            this.lblURL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImage.Location = new System.Drawing.Point(76, 399);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(46, 17);
            this.lblImage.TabIndex = 8;
            this.lblImage.Text = "Image";
            this.lblImage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxTitle
            // 
            this.tbxTitle.Location = new System.Drawing.Point(152, 170);
            this.tbxTitle.Name = "tbxTitle";
            this.tbxTitle.Size = new System.Drawing.Size(159, 20);
            this.tbxTitle.TabIndex = 2;
            // 
            // tbxDescription
            // 
            this.tbxDescription.Location = new System.Drawing.Point(152, 210);
            this.tbxDescription.Multiline = true;
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.Size = new System.Drawing.Size(159, 46);
            this.tbxDescription.TabIndex = 3;
            // 
            // datEndDate
            // 
            this.datEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datEndDate.Location = new System.Drawing.Point(152, 280);
            this.datEndDate.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.datEndDate.MinDate = new System.DateTime(2024, 5, 24, 0, 0, 0, 0);
            this.datEndDate.Name = "datEndDate";
            this.datEndDate.Size = new System.Drawing.Size(159, 20);
            this.datEndDate.TabIndex = 4;
            // 
            // cbxPriority
            // 
            this.cbxPriority.FormattingEnabled = true;
            this.cbxPriority.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbxPriority.Items.AddRange(new object[] {
            "Haute",
            "Moyenne",
            "Basse"});
            this.cbxPriority.Location = new System.Drawing.Point(152, 320);
            this.cbxPriority.MaxDropDownItems = 3;
            this.cbxPriority.Name = "cbxPriority";
            this.cbxPriority.Size = new System.Drawing.Size(121, 21);
            this.cbxPriority.TabIndex = 5;
            // 
            // tbxURL
            // 
            this.tbxURL.Location = new System.Drawing.Point(152, 360);
            this.tbxURL.Name = "tbxURL";
            this.tbxURL.Size = new System.Drawing.Size(159, 20);
            this.tbxURL.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ajouter une tâche";
            // 
            // btn_loginAccount
            // 
            this.btn_loginAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_loginAccount.Location = new System.Drawing.Point(283, 533);
            this.btn_loginAccount.Name = "btn_loginAccount";
            this.btn_loginAccount.Size = new System.Drawing.Size(121, 34);
            this.btn_loginAccount.TabIndex = 9;
            this.btn_loginAccount.Text = "Ajouter";
            this.btn_loginAccount.UseVisualStyleBackColor = true;
            this.btn_loginAccount.Click += new System.EventHandler(this.btn_loginAccount_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::MyTaskManager.Properties.Resources.image_icon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(152, 400);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 113);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pbx_logo
            // 
            this.pbx_logo.Image = global::MyTaskManager.Properties.Resources.TPI___MyTaskManager___Logo;
            this.pbx_logo.Location = new System.Drawing.Point(3, 3);
            this.pbx_logo.Name = "pbx_logo";
            this.pbx_logo.Size = new System.Drawing.Size(130, 126);
            this.pbx_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_logo.TabIndex = 2;
            this.pbx_logo.TabStop = false;
            // 
            // AddTaskView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 587);
            this.Controls.Add(this.btn_loginAccount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbxURL);
            this.Controls.Add(this.cbxPriority);
            this.Controls.Add(this.datEndDate);
            this.Controls.Add(this.tbxDescription);
            this.Controls.Add(this.tbxTitle);
            this.Controls.Add(this.pnl_BackgroundDesign1);
            this.Name = "AddTaskView";
            this.Text = "Ajouter une tâche";
            this.Load += new System.EventHandler(this.AddTaskView_Load);
            this.pnl_BackgroundDesign1.ResumeLayout(false);
            this.pnl_BackgroundDesign1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_BackgroundDesign1;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbx_logo;
        private System.Windows.Forms.TextBox tbxTitle;
        private System.Windows.Forms.TextBox tbxDescription;
        private System.Windows.Forms.DateTimePicker datEndDate;
        private System.Windows.Forms.ComboBox cbxPriority;
        private System.Windows.Forms.TextBox tbxURL;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_loginAccount;
    }
}