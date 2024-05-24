namespace MyTaskManager.Views
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
            this.btnLoginAccount = new System.Windows.Forms.Button();
            this.btnRegisterAccount = new System.Windows.Forms.Button();
            this.lblNoAccount = new System.Windows.Forms.Label();
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
            // btnLoginAccount
            // 
            this.btnLoginAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginAccount.Location = new System.Drawing.Point(337, 218);
            this.btnLoginAccount.Name = "btnLoginAccount";
            this.btnLoginAccount.Size = new System.Drawing.Size(121, 34);
            this.btnLoginAccount.TabIndex = 7;
            this.btnLoginAccount.Text = "Se connecter";
            this.btnLoginAccount.UseVisualStyleBackColor = true;
            this.btnLoginAccount.Click += new System.EventHandler(this.btn_loginAccount_Click);
            // 
            // btnRegisterAccount
            // 
            this.btnRegisterAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterAccount.Location = new System.Drawing.Point(337, 278);
            this.btnRegisterAccount.Name = "btnRegisterAccount";
            this.btnRegisterAccount.Size = new System.Drawing.Size(121, 34);
            this.btnRegisterAccount.TabIndex = 8;
            this.btnRegisterAccount.Text = "Créer un compte";
            this.btnRegisterAccount.UseVisualStyleBackColor = true;
            this.btnRegisterAccount.Click += new System.EventHandler(this.btnRegisterAccount_Click);
            // 
            // lblNoAccount
            // 
            this.lblNoAccount.AutoSize = true;
            this.lblNoAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoAccount.Location = new System.Drawing.Point(208, 287);
            this.lblNoAccount.Name = "lblNoAccount";
            this.lblNoAccount.Size = new System.Drawing.Size(114, 17);
            this.lblNoAccount.TabIndex = 9;
            this.lblNoAccount.Text = "Pas de compte ?";
            this.lblNoAccount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 335);
            this.Controls.Add(this.lblNoAccount);
            this.Controls.Add(this.btnRegisterAccount);
            this.Controls.Add(this.btnLoginAccount);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_loginPassword);
            this.Controls.Add(this.lbl_loginLogin);
            this.Controls.Add(this.tbx_loginPassword);
            this.Controls.Add(this.tbx_loginLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LoginView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button btnLoginAccount;
        private System.Windows.Forms.Button btnRegisterAccount;
        private System.Windows.Forms.Label lblNoAccount;
    }
}

