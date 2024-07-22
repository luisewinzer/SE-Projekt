namespace L_R_Screen
{
    partial class frmRegistration
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
            this.buttonRegister = new System.Windows.Forms.Button();
            this.showPassword = new System.Windows.Forms.CheckBox();
            this.txtConPassword = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.labelBackToLogin = new System.Windows.Forms.Label();
            this.labelConPassword = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelRegistration = new System.Windows.Forms.Label();
            this.labelChronicles = new System.Windows.Forms.Label();
            this.labelCoffin = new System.Windows.Forms.Label();
            this.IconCC = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.IconCC)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.Silver;
            this.buttonRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.Location = new System.Drawing.Point(36, 433);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(216, 32);
            this.buttonRegister.TabIndex = 29;
            this.buttonRegister.Text = "Registrieren";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // showPassword
            // 
            this.showPassword.AutoSize = true;
            this.showPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showPassword.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPassword.ForeColor = System.Drawing.Color.Gray;
            this.showPassword.Location = new System.Drawing.Point(132, 391);
            this.showPassword.Name = "showPassword";
            this.showPassword.Size = new System.Drawing.Size(120, 17);
            this.showPassword.TabIndex = 28;
            this.showPassword.Text = "Passwort anzeigen";
            this.showPassword.UseVisualStyleBackColor = true;
            this.showPassword.CheckedChanged += new System.EventHandler(this.showPassword_CheckedChanged);
            // 
            // txtConPassword
            // 
            this.txtConPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtConPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConPassword.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConPassword.ForeColor = System.Drawing.Color.Black;
            this.txtConPassword.Location = new System.Drawing.Point(36, 354);
            this.txtConPassword.Multiline = true;
            this.txtConPassword.Name = "txtConPassword";
            this.txtConPassword.PasswordChar = '•';
            this.txtConPassword.Size = new System.Drawing.Size(216, 31);
            this.txtConPassword.TabIndex = 27;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(36, 288);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(216, 31);
            this.txtPassword.TabIndex = 26;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.Location = new System.Drawing.Point(36, 221);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(216, 31);
            this.txtUsername.TabIndex = 25;
            // 
            // labelBackToLogin
            // 
            this.labelBackToLogin.AutoSize = true;
            this.labelBackToLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelBackToLogin.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBackToLogin.ForeColor = System.Drawing.Color.DarkGray;
            this.labelBackToLogin.Location = new System.Drawing.Point(78, 478);
            this.labelBackToLogin.Name = "labelBackToLogin";
            this.labelBackToLogin.Size = new System.Drawing.Size(127, 13);
            this.labelBackToLogin.TabIndex = 24;
            this.labelBackToLogin.Text = "Zurück zur Anmeldung";
            this.labelBackToLogin.Click += new System.EventHandler(this.labelBackToLogin_Click);
            // 
            // labelConPassword
            // 
            this.labelConPassword.AutoSize = true;
            this.labelConPassword.Location = new System.Drawing.Point(32, 332);
            this.labelConPassword.Name = "labelConPassword";
            this.labelConPassword.Size = new System.Drawing.Size(143, 17);
            this.labelConPassword.TabIndex = 23;
            this.labelConPassword.Text = "Passwort wiederholen";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(32, 266);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(63, 17);
            this.labelPassword.TabIndex = 22;
            this.labelPassword.Text = "Passwort";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(32, 199);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(96, 17);
            this.labelUsername.TabIndex = 21;
            this.labelUsername.Text = "Benutzername";
            // 
            // labelRegistration
            // 
            this.labelRegistration.AutoSize = true;
            this.labelRegistration.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistration.Location = new System.Drawing.Point(86, 153);
            this.labelRegistration.Name = "labelRegistration";
            this.labelRegistration.Size = new System.Drawing.Size(113, 21);
            this.labelRegistration.TabIndex = 20;
            this.labelRegistration.Text = "Registrierung";
            // 
            // labelChronicles
            // 
            this.labelChronicles.AutoSize = true;
            this.labelChronicles.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChronicles.Location = new System.Drawing.Point(129, 106);
            this.labelChronicles.Name = "labelChronicles";
            this.labelChronicles.Size = new System.Drawing.Size(87, 16);
            this.labelChronicles.TabIndex = 19;
            this.labelChronicles.Text = "Chronicles";
            // 
            // labelCoffin
            // 
            this.labelCoffin.AutoSize = true;
            this.labelCoffin.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCoffin.Location = new System.Drawing.Point(68, 106);
            this.labelCoffin.Name = "labelCoffin";
            this.labelCoffin.Size = new System.Drawing.Size(55, 16);
            this.labelCoffin.TabIndex = 18;
            this.labelCoffin.Text = "Coffin";
            // 
            // IconCC
            // 
            this.IconCC.Image = global::L_R_Screen.Properties.Resources.IconCC;
            this.IconCC.Location = new System.Drawing.Point(62, 54);
            this.IconCC.Name = "IconCC";
            this.IconCC.Size = new System.Drawing.Size(163, 68);
            this.IconCC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IconCC.TabIndex = 17;
            this.IconCC.TabStop = false;
            // 
            // frmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(285, 544);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.showPassword);
            this.Controls.Add(this.txtConPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.labelBackToLogin);
            this.Controls.Add(this.labelConPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelRegistration);
            this.Controls.Add(this.labelChronicles);
            this.Controls.Add(this.labelCoffin);
            this.Controls.Add(this.IconCC);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.IconCC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.CheckBox showPassword;
        private System.Windows.Forms.TextBox txtConPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label labelBackToLogin;
        private System.Windows.Forms.Label labelConPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelRegistration;
        private System.Windows.Forms.Label labelChronicles;
        private System.Windows.Forms.Label labelCoffin;
        private System.Windows.Forms.PictureBox IconCC;
    }
}

