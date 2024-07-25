using System;

namespace L_R_Screen
{
    partial class DataRequest
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
            this.PnlTop = new System.Windows.Forms.Panel();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnLogOut = new System.Windows.Forms.Button();
            this.PnlBottom = new System.Windows.Forms.Panel();
            this.BtnGrave = new System.Windows.Forms.PictureBox();
            this.BtnHome = new System.Windows.Forms.PictureBox();
            this.BtnData = new System.Windows.Forms.PictureBox();
            this.PnlMiddle = new System.Windows.Forms.Panel();
            this.MtxtDeathdate = new System.Windows.Forms.MaskedTextBox();
            this.MtxtBirthdate = new System.Windows.Forms.MaskedTextBox();
            this.TxtInformation = new System.Windows.Forms.TextBox();
            this.LblInformation = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.LblConPassword = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.LblInfoDeceased = new System.Windows.Forms.Label();
            this.PnlRight = new System.Windows.Forms.Panel();
            this.PnlLeft = new System.Windows.Forms.Panel();
            this.PnlTop.SuspendLayout();
            this.PnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGrave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnData)).BeginInit();
            this.PnlMiddle.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlTop
            // 
            this.PnlTop.BackColor = System.Drawing.Color.Gainsboro;
            this.PnlTop.Controls.Add(this.BtnExit);
            this.PnlTop.Controls.Add(this.BtnLogOut);
            this.PnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTop.Location = new System.Drawing.Point(0, 0);
            this.PnlTop.Name = "PnlTop";
            this.PnlTop.Size = new System.Drawing.Size(816, 31);
            this.PnlTop.TabIndex = 0;
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Transparent;
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.ForeColor = System.Drawing.Color.Gray;
            this.BtnExit.Location = new System.Drawing.Point(785, 0);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(31, 31);
            this.BtnExit.TabIndex = 10;
            this.BtnExit.Text = "X";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnLogOut
            // 
            this.BtnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogOut.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogOut.Location = new System.Drawing.Point(702, 5);
            this.BtnLogOut.Name = "BtnLogOut";
            this.BtnLogOut.Size = new System.Drawing.Size(75, 23);
            this.BtnLogOut.TabIndex = 9;
            this.BtnLogOut.Text = "Abmelden";
            this.BtnLogOut.UseVisualStyleBackColor = true;
            this.BtnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // PnlBottom
            // 
            this.PnlBottom.BackColor = System.Drawing.Color.Gainsboro;
            this.PnlBottom.Controls.Add(this.BtnGrave);
            this.PnlBottom.Controls.Add(this.BtnHome);
            this.PnlBottom.Controls.Add(this.BtnData);
            this.PnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlBottom.Location = new System.Drawing.Point(0, 458);
            this.PnlBottom.Name = "PnlBottom";
            this.PnlBottom.Size = new System.Drawing.Size(816, 31);
            this.PnlBottom.TabIndex = 0;
            // 
            // BtnGrave
            // 
            this.BtnGrave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGrave.Image = global::L_R_Screen.Properties.Resources.tombstone__1_;
            this.BtnGrave.Location = new System.Drawing.Point(455, 0);
            this.BtnGrave.Name = "BtnGrave";
            this.BtnGrave.Size = new System.Drawing.Size(31, 31);
            this.BtnGrave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnGrave.TabStop = false;
            this.BtnGrave.Click += new System.EventHandler(this.BtnGrave_Click);
            this.BtnGrave.TabIndex = 8;
            // 
            // BtnHome
            // 
            this.BtnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnHome.Image = global::L_R_Screen.Properties.Resources.home;
            this.BtnHome.Location = new System.Drawing.Point(319, 0);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(31, 31);
            this.BtnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnHome.TabStop = false;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            this.BtnHome.TabIndex = 6;
            // 
            // BtnData
            // 
            this.BtnData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnData.Image = global::L_R_Screen.Properties.Resources.form;
            this.BtnData.Location = new System.Drawing.Point(388, 0);
            this.BtnData.Name = "BtnData";
            this.BtnData.Size = new System.Drawing.Size(30, 31);
            this.BtnData.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnData.TabStop = false;
            this.BtnData.Click += new System.EventHandler(this.BtnData_Click);
            this.BtnData.TabIndex = 7;
            // 
            // PnlMiddle
            // 
            this.PnlMiddle.BackColor = System.Drawing.Color.Honeydew;
            this.PnlMiddle.Controls.Add(this.MtxtDeathdate);
            this.PnlMiddle.Controls.Add(this.MtxtBirthdate);
            this.PnlMiddle.Controls.Add(this.TxtInformation);
            this.PnlMiddle.Controls.Add(this.LblInformation);
            this.PnlMiddle.Controls.Add(this.BtnSave);
            this.PnlMiddle.Controls.Add(this.TxtName);
            this.PnlMiddle.Controls.Add(this.LblConPassword);
            this.PnlMiddle.Controls.Add(this.LblPassword);
            this.PnlMiddle.Controls.Add(this.LblName);
            this.PnlMiddle.Controls.Add(this.LblInfoDeceased);
            this.PnlMiddle.Location = new System.Drawing.Point(262, 31);
            this.PnlMiddle.Name = "PnlMiddle";
            this.PnlMiddle.Size = new System.Drawing.Size(293, 427);
            this.PnlMiddle.TabIndex = 0;
            // 
            // MtxtDeathdate
            // 
            this.MtxtDeathdate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MtxtDeathdate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MtxtDeathdate.Location = new System.Drawing.Point(40, 198);
            this.MtxtDeathdate.Mask = "00/00/0000";
            this.MtxtDeathdate.Name = "MtxtDeathdate";
            this.MtxtDeathdate.Size = new System.Drawing.Size(216, 18);
            this.MtxtDeathdate.TabIndex = 3;
            this.MtxtDeathdate.ValidatingType = typeof(System.DateTime);
            // 
            // MtxtBirthdate
            // 
            this.MtxtBirthdate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MtxtBirthdate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MtxtBirthdate.Location = new System.Drawing.Point(41, 141);
            this.MtxtBirthdate.Mask = "00/00/0000";
            this.MtxtBirthdate.Name = "MtxtBirthdate";
            this.MtxtBirthdate.Size = new System.Drawing.Size(216, 18);
            this.MtxtBirthdate.TabIndex = 2;
            this.MtxtBirthdate.ValidatingType = typeof(System.DateTime);
            // 
            // TxtInformation
            // 
            this.TxtInformation.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtInformation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtInformation.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtInformation.ForeColor = System.Drawing.Color.Black;
            this.TxtInformation.Location = new System.Drawing.Point(41, 255);
            this.TxtInformation.Multiline = true;
            this.TxtInformation.Name = "TxtInformation";
            this.TxtInformation.Size = new System.Drawing.Size(216, 95);
            this.TxtInformation.TabIndex = 4;
            // 
            // LblInformation
            // 
            this.LblInformation.AutoSize = true;
            this.LblInformation.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInformation.Location = new System.Drawing.Point(38, 235);
            this.LblInformation.Name = "LblInformation";
            this.LblInformation.Size = new System.Drawing.Size(138, 17);
            this.LblInformation.TabIndex = 0;
            this.LblInformation.Text = "Weitere Informationen";
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.Silver;
            this.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Location = new System.Drawing.Point(40, 380);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(216, 32);
            this.BtnSave.TabIndex = 5;
            this.BtnSave.Text = "Speichern";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // TxtName
            // 
            this.TxtName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtName.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.ForeColor = System.Drawing.Color.Black;
            this.TxtName.Location = new System.Drawing.Point(41, 74);
            this.TxtName.MaxLength = 60;
            this.TxtName.Multiline = true;
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(216, 29);
            this.TxtName.TabIndex = 1;
            // 
            // LblConPassword
            // 
            this.LblConPassword.AutoSize = true;
            this.LblConPassword.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblConPassword.Location = new System.Drawing.Point(38, 178);
            this.LblConPassword.Name = "LblConPassword";
            this.LblConPassword.Size = new System.Drawing.Size(83, 17);
            this.LblConPassword.TabIndex = 0;
            this.LblConPassword.Text = "Sterbedatum";
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassword.Location = new System.Drawing.Point(37, 121);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(91, 17);
            this.LblPassword.TabIndex = 0;
            this.LblPassword.Text = "Geburtsdatum";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(37, 54);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(124, 17);
            this.LblName.TabIndex = 0;
            this.LblName.Text = "Vor- und Nachname";
            // 
            // LblInfoDeceased
            // 
            this.LblInfoDeceased.AutoSize = true;
            this.LblInfoDeceased.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInfoDeceased.Location = new System.Drawing.Point(5, 12);
            this.LblInfoDeceased.Name = "LblInfoDeceased";
            this.LblInfoDeceased.Size = new System.Drawing.Size(285, 20);
            this.LblInfoDeceased.TabIndex = 0;
            this.LblInfoDeceased.Text = "Informationen zur verstorbenen Person";
            // 
            // PnlRight
            // 
            this.PnlRight.Location = new System.Drawing.Point(552, 31);
            this.PnlRight.Name = "PnlRight";
            this.PnlRight.Size = new System.Drawing.Size(264, 427);
            this.PnlRight.TabIndex = 0;
            // 
            // PnlLeft
            // 
            this.PnlLeft.Location = new System.Drawing.Point(0, 31);
            this.PnlLeft.Name = "PnlLeft";
            this.PnlLeft.Size = new System.Drawing.Size(264, 427);
            this.PnlLeft.TabIndex = 0;
            // 
            // DataRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(816, 489);
            this.Controls.Add(this.PnlMiddle);
            this.Controls.Add(this.PnlLeft);
            this.Controls.Add(this.PnlRight);
            this.Controls.Add(this.PnlBottom);
            this.Controls.Add(this.PnlTop);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DataRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.PnlTop.ResumeLayout(false);
            this.PnlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnGrave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnData)).EndInit();
            this.PnlMiddle.ResumeLayout(false);
            this.PnlMiddle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlTop;
        private System.Windows.Forms.Panel PnlBottom;
        private System.Windows.Forms.Button BtnLogOut;
        private System.Windows.Forms.Panel PnlMiddle;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Panel PnlRight;
        private System.Windows.Forms.Panel PnlLeft;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label LblConPassword;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblInfoDeceased;
        private System.Windows.Forms.TextBox TxtInformation;
        private System.Windows.Forms.Label LblInformation;
        private System.Windows.Forms.PictureBox BtnHome;
        private System.Windows.Forms.PictureBox BtnData;
        private System.Windows.Forms.PictureBox BtnGrave;
        private System.Windows.Forms.MaskedTextBox MtxtBirthdate;
        private System.Windows.Forms.MaskedTextBox MtxtDeathdate;
    }
}