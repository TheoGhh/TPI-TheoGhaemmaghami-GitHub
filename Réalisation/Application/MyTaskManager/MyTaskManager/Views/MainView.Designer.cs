namespace MyTaskManager.Views
{
    partial class MainView
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
            this.pnlNavBar = new System.Windows.Forms.Panel();
            this.btnDeleteColumn = new System.Windows.Forms.Button();
            this.btnAddColumn = new System.Windows.Forms.Button();
            this.pnlMainContent = new System.Windows.Forms.Panel();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.pnlNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlNavBar
            // 
            this.pnlNavBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlNavBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.pnlNavBar.Controls.Add(this.btnAddTask);
            this.pnlNavBar.Controls.Add(this.btnDeleteColumn);
            this.pnlNavBar.Controls.Add(this.btnAddColumn);
            this.pnlNavBar.Controls.Add(this.pbxLogo);
            this.pnlNavBar.Location = new System.Drawing.Point(0, 0);
            this.pnlNavBar.Margin = new System.Windows.Forms.Padding(0);
            this.pnlNavBar.Name = "pnlNavBar";
            this.pnlNavBar.Size = new System.Drawing.Size(160, 623);
            this.pnlNavBar.TabIndex = 7;
            // 
            // btnDeleteColumn
            // 
            this.btnDeleteColumn.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteColumn.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteColumn.Location = new System.Drawing.Point(12, 235);
            this.btnDeleteColumn.Name = "btnDeleteColumn";
            this.btnDeleteColumn.Size = new System.Drawing.Size(133, 37);
            this.btnDeleteColumn.TabIndex = 9;
            this.btnDeleteColumn.Text = "Supprimer une colonne";
            this.btnDeleteColumn.UseVisualStyleBackColor = false;
            this.btnDeleteColumn.Click += new System.EventHandler(this.btnDeleteColumn_Click);
            // 
            // btnAddColumn
            // 
            this.btnAddColumn.BackColor = System.Drawing.Color.Transparent;
            this.btnAddColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddColumn.ForeColor = System.Drawing.Color.Black;
            this.btnAddColumn.Location = new System.Drawing.Point(12, 167);
            this.btnAddColumn.Name = "btnAddColumn";
            this.btnAddColumn.Size = new System.Drawing.Size(133, 37);
            this.btnAddColumn.TabIndex = 8;
            this.btnAddColumn.Text = "Ajouter une colonne";
            this.btnAddColumn.UseVisualStyleBackColor = false;
            this.btnAddColumn.Click += new System.EventHandler(this.btnAddColumn_Click);
            // 
            // pnlMainContent
            // 
            this.pnlMainContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMainContent.Location = new System.Drawing.Point(177, 12);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.Size = new System.Drawing.Size(976, 593);
            this.pnlMainContent.TabIndex = 9;
            // 
            // pbxLogo
            // 
            this.pbxLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxLogo.Image = global::MyTaskManager.Properties.Resources.TPI___MyTaskManager___Logo;
            this.pbxLogo.Location = new System.Drawing.Point(0, 0);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(160, 129);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 7;
            this.pbxLogo.TabStop = false;
            // 
            // btnAddTask
            // 
            this.btnAddTask.BackColor = System.Drawing.Color.Transparent;
            this.btnAddTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTask.ForeColor = System.Drawing.Color.Black;
            this.btnAddTask.Location = new System.Drawing.Point(14, 293);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(133, 37);
            this.btnAddTask.TabIndex = 10;
            this.btnAddTask.Text = "Ajouter une tâche";
            this.btnAddTask.UseVisualStyleBackColor = false;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 620);
            this.Controls.Add(this.pnlMainContent);
            this.Controls.Add(this.pnlNavBar);
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyTaskManager";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.pnlNavBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNavBar;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Button btnAddColumn;
        private System.Windows.Forms.Panel pnlMainContent;
        private System.Windows.Forms.Button btnDeleteColumn;
        private System.Windows.Forms.Button btnAddTask;
    }
}