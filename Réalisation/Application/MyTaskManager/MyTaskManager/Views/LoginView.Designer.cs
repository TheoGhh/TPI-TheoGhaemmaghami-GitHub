namespace MyTaskManager
{
    partial class LoginView
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbx_loginLogin = new System.Windows.Forms.TextBox();
            this.tbx_loginPassword = new System.Windows.Forms.TextBox();
            this.lbl_loginLogin = new System.Windows.Forms.Label();
            this.lbl_loginPassword = new System.Windows.Forms.Label();
            this.pbx_logo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_loginAccount = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_logo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbx_loginLogin
            // 
            this.tbx_loginLogin.Location = new System.Drawing.Point(49, 167);
            this.tbx_loginLogin.Margin = new System.Windows.Forms.Padding(40, 8, 8, 8);
            this.tbx_loginLogin.Name = "tbx_loginLogin";
            this.tbx_loginLogin.Size = new System.Drawing.Size(180, 20);
            this.tbx_loginLogin.TabIndex = 0;
            // 
            // tbx_loginPassword
            // 
            this.tbx_loginPassword.Location = new System.Drawing.Point(278, 167);
            this.tbx_loginPassword.Margin = new System.Windows.Forms.Padding(8, 8, 40, 8);
            this.tbx_loginPassword.Name = "tbx_loginPassword";
            this.tbx_loginPassword.Size = new System.Drawing.Size(180, 20);
            this.tbx_loginPassword.TabIndex = 1;
            // 
            // lbl_loginLogin
            // 
            this.lbl_loginLogin.AutoSize = true;
            this.lbl_loginLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loginLogin.Location = new System.Drawing.Point(46, 142);
            this.lbl_loginLogin.Name = "lbl_loginLogin";
            this.lbl_loginLogin.Size = new System.Drawing.Size(43, 17);
            this.lbl_loginLogin.TabIndex = 4;
            this.lbl_loginLogin.Text = "Login";
            this.lbl_loginLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_loginPassword
            // 
            this.lbl_loginPassword.AutoSize = true;
            this.lbl_loginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loginPassword.Location = new System.Drawing.Point(275, 142);
            this.lbl_loginPassword.Name = "lbl_loginPassword";
            this.lbl_loginPassword.Size = new System.Drawing.Size(93, 17);
            this.lbl_loginPassword.TabIndex = 5;
            this.lbl_loginPassword.Text = "Mot de passe";
            this.lbl_loginPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pbx_logo
            // 
            this.pbx_logo.Image = global::MyTaskManager.Properties.Resources.TPI___MyTaskManager___Logo;
            this.pbx_logo.Location = new System.Drawing.Point(3, 0);
            this.pbx_logo.Name = "pbx_logo";
            this.pbx_logo.Size = new System.Drawing.Size(125, 120);
            this.pbx_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_logo.TabIndex = 7;
            this.pbx_logo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.pbx_logo);
            this.panel1.Controls.Add(this.lbl_title);
            this.panel1.Location = new System.Drawing.Point(-8, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(517, 120);
            this.panel1.TabIndex = 6;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(298, 44);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(185, 26);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "MyTaskManager";
            // 
            // btn_loginAccount
            // 
            this.btn_loginAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_loginAccount.Location = new System.Drawing.Point(337, 218);
            this.btn_loginAccount.Name = "btn_loginAccount";
            this.btn_loginAccount.Size = new System.Drawing.Size(121, 34);
            this.btn_loginAccount.TabIndex = 7;
            this.btn_loginAccount.Text = "Se connecter";
            this.btn_loginAccount.UseVisualStyleBackColor = true;
            this.btn_loginAccount.Click += new System.EventHandler(this.btn_loginAccount_Click);
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 284);
            this.Controls.Add(this.btn_loginAccount);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_loginPassword);
            this.Controls.Add(this.lbl_loginLogin);
            this.Controls.Add(this.tbx_loginPassword);
            this.Controls.Add(this.tbx_loginLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LoginView";
            this.Text = "Connexion";
            this.Load += new System.EventHandler(this.loginView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_logo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_loginLogin;
        private System.Windows.Forms.TextBox tbx_loginPassword;
        private System.Windows.Forms.Label lbl_loginLogin;
        private System.Windows.Forms.Label lbl_loginPassword;
        private System.Windows.Forms.PictureBox pbx_logo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_loginAccount;
    }
}

