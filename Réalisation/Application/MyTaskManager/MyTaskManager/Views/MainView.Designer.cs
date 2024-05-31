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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnDeleteColumn = new System.Windows.Forms.Button();
            this.btnAddColumn = new System.Windows.Forms.Button();
            this.lblPersonalization = new System.Windows.Forms.Label();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.pnlMainContainer = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.pnlMenu.Controls.Add(this.btnDeleteColumn);
            this.pnlMenu.Controls.Add(this.btnAddColumn);
            this.pnlMenu.Controls.Add(this.lblPersonalization);
            this.pnlMenu.Controls.Add(this.btnAddTask);
            this.pnlMenu.Controls.Add(this.pbxLogo);
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(159, 550);
            this.pnlMenu.TabIndex = 4;
            // 
            // btnDeleteColumn
            // 
            this.btnDeleteColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteColumn.Location = new System.Drawing.Point(13, 327);
            this.btnDeleteColumn.Margin = new System.Windows.Forms.Padding(10);
            this.btnDeleteColumn.Name = "btnDeleteColumn";
            this.btnDeleteColumn.Size = new System.Drawing.Size(134, 48);
            this.btnDeleteColumn.TabIndex = 16;
            this.btnDeleteColumn.Text = "Supprimer une colonne";
            this.btnDeleteColumn.UseVisualStyleBackColor = true;
            this.btnDeleteColumn.Click += new System.EventHandler(this.btnDeleteColumn_Click);
            // 
            // btnAddColumn
            // 
            this.btnAddColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddColumn.Location = new System.Drawing.Point(13, 270);
            this.btnAddColumn.Margin = new System.Windows.Forms.Padding(10);
            this.btnAddColumn.Name = "btnAddColumn";
            this.btnAddColumn.Size = new System.Drawing.Size(134, 48);
            this.btnAddColumn.TabIndex = 15;
            this.btnAddColumn.Text = "Ajouter une colonne";
            this.btnAddColumn.UseVisualStyleBackColor = true;
            this.btnAddColumn.Click += new System.EventHandler(this.btnAddColumn_Click);
            // 
            // lblPersonalization
            // 
            this.lblPersonalization.AutoSize = true;
            this.lblPersonalization.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonalization.Location = new System.Drawing.Point(13, 242);
            this.lblPersonalization.Name = "lblPersonalization";
            this.lblPersonalization.Size = new System.Drawing.Size(134, 18);
            this.lblPersonalization.TabIndex = 14;
            this.lblPersonalization.Text = "Personnalisation";
            // 
            // btnAddTask
            // 
            this.btnAddTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTask.Location = new System.Drawing.Point(13, 153);
            this.btnAddTask.Margin = new System.Windows.Forms.Padding(10);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(134, 35);
            this.btnAddTask.TabIndex = 13;
            this.btnAddTask.Text = "Ajouter une tâche";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // pbxLogo
            // 
            this.pbxLogo.BackgroundImage = global::MyTaskManager.Properties.Resources.TPI___MyTaskManager___Logo;
            this.pbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxLogo.Location = new System.Drawing.Point(10, 0);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(140, 140);
            this.pbxLogo.TabIndex = 1;
            this.pbxLogo.TabStop = false;
            // 
            // pnlMainContainer
            // 
            this.pnlMainContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMainContainer.AutoScroll = true;
            this.pnlMainContainer.Location = new System.Drawing.Point(165, 10);
            this.pnlMainContainer.Name = "pnlMainContainer";
            this.pnlMainContainer.Size = new System.Drawing.Size(515, 531);
            this.pnlMainContainer.TabIndex = 5;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 550);
            this.Controls.Add(this.pnlMainContainer);
            this.Controls.Add(this.pnlMenu);
            this.Name = "MainView";
            this.Text = "MyTaskManager";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Panel pnlMainContainer;
        private System.Windows.Forms.Button btnDeleteColumn;
        private System.Windows.Forms.Button btnAddColumn;
        private System.Windows.Forms.Label lblPersonalization;
    }
}