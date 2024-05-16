namespace MyTaskManager.Views
{
    partial class RegisterView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterView));
            this.pnl_BackgroundDesign1 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbx_logo = new System.Windows.Forms.PictureBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_firstName = new System.Windows.Forms.Label();
            this.lbl_lastName = new System.Windows.Forms.Label();
            this.lbl_login = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.tbx_firstName = new System.Windows.Forms.TextBox();
            this.tbx_lastName = new System.Windows.Forms.TextBox();
            this.tbx_login = new System.Windows.Forms.TextBox();
            this.tbx_password = new System.Windows.Forms.TextBox();
            this.btn_createAccount = new System.Windows.Forms.Button();
            this.pnl_BackgroundDesign1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_BackgroundDesign1
            // 
            this.pnl_BackgroundDesign1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.pnl_BackgroundDesign1.Controls.Add(this.lbl_password);
            this.pnl_BackgroundDesign1.Controls.Add(this.lbl_login);
            this.pnl_BackgroundDesign1.Controls.Add(this.lbl_lastName);
            this.pnl_BackgroundDesign1.Controls.Add(this.lbl_firstName);
            this.pnl_BackgroundDesign1.Controls.Add(this.pbx_logo);
            this.pnl_BackgroundDesign1.Location = new System.Drawing.Point(-3, -2);
            this.pnl_BackgroundDesign1.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_BackgroundDesign1.Name = "pnl_BackgroundDesign1";
            this.pnl_BackgroundDesign1.Size = new System.Drawing.Size(131, 415);
            this.pnl_BackgroundDesign1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.lbl_title);
            this.panel1.Location = new System.Drawing.Point(128, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 120);
            this.panel1.TabIndex = 1;
            // 
            // pbx_logo
            // 
            this.pbx_logo.Image = global::MyTaskManager.Properties.Resources.TPI___MyTaskManager___Logo;
            this.pbx_logo.Location = new System.Drawing.Point(3, 3);
            this.pbx_logo.Name = "pbx_logo";
            this.pbx_logo.Size = new System.Drawing.Size(125, 126);
            this.pbx_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_logo.TabIndex = 2;
            this.pbx_logo.TabStop = false;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(16, 49);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(185, 26);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "MyTaskManager";
            // 
            // lbl_firstName
            // 
            this.lbl_firstName.AutoSize = true;
            this.lbl_firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_firstName.Location = new System.Drawing.Point(65, 171);
            this.lbl_firstName.Name = "lbl_firstName";
            this.lbl_firstName.Size = new System.Drawing.Size(57, 17);
            this.lbl_firstName.TabIndex = 3;
            this.lbl_firstName.Text = "Prénom";
            this.lbl_firstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_lastName
            // 
            this.lbl_lastName.AutoSize = true;
            this.lbl_lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lastName.Location = new System.Drawing.Point(85, 220);
            this.lbl_lastName.Name = "lbl_lastName";
            this.lbl_lastName.Size = new System.Drawing.Size(37, 17);
            this.lbl_lastName.TabIndex = 4;
            this.lbl_lastName.Text = "Nom";
            this.lbl_lastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.Location = new System.Drawing.Point(79, 265);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(43, 17);
            this.lbl_login.TabIndex = 5;
            this.lbl_login.Text = "Login";
            this.lbl_login.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(29, 310);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(93, 17);
            this.lbl_password.TabIndex = 6;
            this.lbl_password.Text = "Mot de passe";
            this.lbl_password.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbx_firstName
            // 
            this.tbx_firstName.Location = new System.Drawing.Point(149, 168);
            this.tbx_firstName.Name = "tbx_firstName";
            this.tbx_firstName.Size = new System.Drawing.Size(198, 20);
            this.tbx_firstName.TabIndex = 2;
            // 
            // tbx_lastName
            // 
            this.tbx_lastName.Location = new System.Drawing.Point(149, 217);
            this.tbx_lastName.Name = "tbx_lastName";
            this.tbx_lastName.Size = new System.Drawing.Size(198, 20);
            this.tbx_lastName.TabIndex = 3;
            // 
            // tbx_login
            // 
            this.tbx_login.Location = new System.Drawing.Point(149, 262);
            this.tbx_login.Name = "tbx_login";
            this.tbx_login.Size = new System.Drawing.Size(198, 20);
            this.tbx_login.TabIndex = 4;
            // 
            // tbx_password
            // 
            this.tbx_password.Location = new System.Drawing.Point(149, 307);
            this.tbx_password.Name = "tbx_password";
            this.tbx_password.Size = new System.Drawing.Size(198, 20);
            this.tbx_password.TabIndex = 5;
            // 
            // btn_createAccount
            // 
            this.btn_createAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_createAccount.Location = new System.Drawing.Point(226, 351);
            this.btn_createAccount.Name = "btn_createAccount";
            this.btn_createAccount.Size = new System.Drawing.Size(121, 34);
            this.btn_createAccount.TabIndex = 6;
            this.btn_createAccount.Text = "Créer un compte";
            this.btn_createAccount.UseVisualStyleBackColor = true;
            this.btn_createAccount.Click += new System.EventHandler(this.btn_createAccount_Click);
            // 
            // registerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 410);
            this.Controls.Add(this.btn_createAccount);
            this.Controls.Add(this.tbx_password);
            this.Controls.Add(this.tbx_login);
            this.Controls.Add(this.tbx_lastName);
            this.Controls.Add(this.tbx_firstName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_BackgroundDesign1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "registerView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Création d\'un compte";
            this.Load += new System.EventHandler(this.registerView_Load);
            this.pnl_BackgroundDesign1.ResumeLayout(false);
            this.pnl_BackgroundDesign1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_BackgroundDesign1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbx_logo;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Label lbl_lastName;
        private System.Windows.Forms.Label lbl_firstName;
        private System.Windows.Forms.TextBox tbx_firstName;
        private System.Windows.Forms.TextBox tbx_lastName;
        private System.Windows.Forms.TextBox tbx_login;
        private System.Windows.Forms.TextBox tbx_password;
        private System.Windows.Forms.Button btn_createAccount;
    }
}