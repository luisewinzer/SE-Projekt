namespace L_R_Screen
{
    partial class Login
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
            this.BtnLogin = new System.Windows.Forms.Button();
            this.CbShowPassword = new System.Windows.Forms.CheckBox();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.LblCreateAccount = new System.Windows.Forms.Label();
            this.LblUsername = new System.Windows.Forms.Label();
            this.LblLogin = new System.Windows.Forms.Label();
            this.LblChronicles = new System.Windows.Forms.Label();
            this.LblCoffin = new System.Windows.Forms.Label();
            this.IconCC = new System.Windows.Forms.PictureBox();
            this.LblPassword = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.IconCC)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.Silver;
            this.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Location = new System.Drawing.Point(36, 374);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(216, 32);
            this.BtnLogin.TabIndex = 29;
            this.BtnLogin.Text = "Anmelden";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // CbShowPassword
            // 
            this.CbShowPassword.AutoSize = true;
            this.CbShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CbShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbShowPassword.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbShowPassword.ForeColor = System.Drawing.Color.Gray;
            this.CbShowPassword.Location = new System.Drawing.Point(132, 325);
            this.CbShowPassword.Name = "CbShowPassword";
            this.CbShowPassword.Size = new System.Drawing.Size(120, 17);
            this.CbShowPassword.TabIndex = 28;
            this.CbShowPassword.Text = "Passwort anzeigen";
            this.CbShowPassword.UseVisualStyleBackColor = true;
            this.CbShowPassword.CheckedChanged += new System.EventHandler(this.CbShowPassword_CheckedChanged);
            // 
            // TxtUsername
            // 
            this.TxtUsername.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUsername.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsername.ForeColor = System.Drawing.Color.Black;
            this.TxtUsername.Location = new System.Drawing.Point(36, 221);
            this.TxtUsername.Multiline = true;
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(216, 31);
            this.TxtUsername.TabIndex = 25;
            // 
            // LblCreateAccount
            // 
            this.LblCreateAccount.AutoSize = true;
            this.LblCreateAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblCreateAccount.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCreateAccount.ForeColor = System.Drawing.Color.DarkGray;
            this.LblCreateAccount.Location = new System.Drawing.Point(95, 419);
            this.LblCreateAccount.Name = "LblCreateAccount";
            this.LblCreateAccount.Size = new System.Drawing.Size(97, 13);
            this.LblCreateAccount.TabIndex = 24;
            this.LblCreateAccount.Text = "Account erstellen";
            this.LblCreateAccount.Click += new System.EventHandler(this.LblCreateAccount_Click);
            // 
            // LblUsername
            // 
            this.LblUsername.AutoSize = true;
            this.LblUsername.Location = new System.Drawing.Point(32, 199);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(96, 17);
            this.LblUsername.TabIndex = 21;
            this.LblUsername.Text = "Benutzername";
            // 
            // LblLogin
            // 
            this.LblLogin.AutoSize = true;
            this.LblLogin.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLogin.Location = new System.Drawing.Point(94, 153);
            this.LblLogin.Name = "LblLogin";
            this.LblLogin.Size = new System.Drawing.Size(100, 21);
            this.LblLogin.TabIndex = 20;
            this.LblLogin.Text = "Anmeldung";
            // 
            // LblChronicles
            // 
            this.LblChronicles.AutoSize = true;
            this.LblChronicles.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblChronicles.Location = new System.Drawing.Point(129, 106);
            this.LblChronicles.Name = "LblChronicles";
            this.LblChronicles.Size = new System.Drawing.Size(87, 16);
            this.LblChronicles.TabIndex = 19;
            this.LblChronicles.Text = "Chronicles";
            // 
            // LblCoffin
            // 
            this.LblCoffin.AutoSize = true;
            this.LblCoffin.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCoffin.Location = new System.Drawing.Point(68, 106);
            this.LblCoffin.Name = "LblCoffin";
            this.LblCoffin.Size = new System.Drawing.Size(55, 16);
            this.LblCoffin.TabIndex = 18;
            this.LblCoffin.Text = "Coffin";
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
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Location = new System.Drawing.Point(32, 266);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(63, 17);
            this.LblPassword.TabIndex = 22;
            this.LblPassword.Text = "Passwort";
            // 
            // TxtPassword
            // 
            this.TxtPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPassword.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.ForeColor = System.Drawing.Color.Black;
            this.TxtPassword.Location = new System.Drawing.Point(36, 288);
            this.TxtPassword.Multiline = true;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '•';
            this.TxtPassword.Size = new System.Drawing.Size(216, 31);
            this.TxtPassword.TabIndex = 26;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(285, 544);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.CbShowPassword);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUsername);
            this.Controls.Add(this.LblCreateAccount);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.LblUsername);
            this.Controls.Add(this.LblLogin);
            this.Controls.Add(this.LblChronicles);
            this.Controls.Add(this.LblCoffin);
            this.Controls.Add(this.IconCC);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.IconCC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.CheckBox CbShowPassword;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.Label LblCreateAccount;
        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.Label LblLogin;
        private System.Windows.Forms.Label LblChronicles;
        private System.Windows.Forms.Label LblCoffin;
        private System.Windows.Forms.PictureBox IconCC;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.TextBox TxtPassword;
    }
}