using System;

namespace L_R_Screen
{
    partial class frmDataRequest
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnGrave = new System.Windows.Forms.PictureBox();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.btnData = new System.Windows.Forms.PictureBox();
            this.panelMiddle = new System.Windows.Forms.Panel();
            this.mtxtDeathdate = new System.Windows.Forms.MaskedTextBox();
            this.mtxtBirthdate = new System.Windows.Forms.MaskedTextBox();
            this.txtInformation = new System.Windows.Forms.TextBox();
            this.lblInformation = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblDeathdate = new System.Windows.Forms.Label();
            this.lblBirthdate = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblInfoDeceased = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnGrave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnData)).BeginInit();
            this.panelMiddle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Gainsboro;
            this.panelTop.Controls.Add(this.btnExit);
            this.panelTop.Controls.Add(this.btnLogOut);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(816, 31);
            this.panelTop.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Gray;
            this.btnExit.Location = new System.Drawing.Point(785, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(31, 31);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(702, 5);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 0;
            this.btnLogOut.Text = "Abmelden";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.Gainsboro;
            this.panelBottom.Controls.Add(this.btnGrave);
            this.panelBottom.Controls.Add(this.btnHome);
            this.panelBottom.Controls.Add(this.btnData);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 458);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(816, 31);
            this.panelBottom.TabIndex = 1;
            // 
            // btnGrave
            // 
            this.btnGrave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrave.Image = global::L_R_Screen.Properties.Resources.tombstone__1_;
            this.btnGrave.Location = new System.Drawing.Point(455, 0);
            this.btnGrave.Name = "btnGrave";
            this.btnGrave.Size = new System.Drawing.Size(31, 31);
            this.btnGrave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnGrave.TabIndex = 8;
            this.btnGrave.TabStop = false;
            this.btnGrave.Click += new System.EventHandler(this.btnGrave_Click);
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Image = global::L_R_Screen.Properties.Resources.home;
            this.btnHome.Location = new System.Drawing.Point(319, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(31, 31);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHome.TabIndex = 7;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnData
            // 
            this.btnData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnData.Image = global::L_R_Screen.Properties.Resources.form;
            this.btnData.Location = new System.Drawing.Point(388, 0);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(30, 31);
            this.btnData.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnData.TabIndex = 6;
            this.btnData.TabStop = false;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // panelMiddle
            // 
            this.panelMiddle.BackColor = System.Drawing.Color.Honeydew;
            this.panelMiddle.Controls.Add(this.mtxtDeathdate);
            this.panelMiddle.Controls.Add(this.mtxtBirthdate);
            this.panelMiddle.Controls.Add(this.txtInformation);
            this.panelMiddle.Controls.Add(this.lblInformation);
            this.panelMiddle.Controls.Add(this.btnSave);
            this.panelMiddle.Controls.Add(this.txtName);
            this.panelMiddle.Controls.Add(this.lblDeathdate);
            this.panelMiddle.Controls.Add(this.lblBirthdate);
            this.panelMiddle.Controls.Add(this.lblName);
            this.panelMiddle.Controls.Add(this.lblInfoDeceased);
            this.panelMiddle.Location = new System.Drawing.Point(262, 31);
            this.panelMiddle.Name = "panelMiddle";
            this.panelMiddle.Size = new System.Drawing.Size(293, 427);
            this.panelMiddle.TabIndex = 2;
            // 
            // mtxtDeathdate
            // 
            this.mtxtDeathdate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mtxtDeathdate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtxtDeathdate.Location = new System.Drawing.Point(40, 198);
            this.mtxtDeathdate.Mask = "00/00/0000";
            this.mtxtDeathdate.Name = "mtxtDeathdate";
            this.mtxtDeathdate.Size = new System.Drawing.Size(216, 18);
            this.mtxtDeathdate.TabIndex = 0;
            this.mtxtDeathdate.ValidatingType = typeof(System.DateTime);
            // 
            // mtxtBirthdate
            // 
            this.mtxtBirthdate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mtxtBirthdate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtxtBirthdate.Location = new System.Drawing.Point(41, 141);
            this.mtxtBirthdate.Mask = "00/00/0000";
            this.mtxtBirthdate.Name = "mtxtBirthdate";
            this.mtxtBirthdate.Size = new System.Drawing.Size(216, 18);
            this.mtxtBirthdate.TabIndex = 1;
            this.mtxtBirthdate.ValidatingType = typeof(System.DateTime);
            // 
            // txtInformation
            // 
            this.txtInformation.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtInformation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInformation.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInformation.ForeColor = System.Drawing.Color.Black;
            this.txtInformation.Location = new System.Drawing.Point(41, 255);
            this.txtInformation.Multiline = true;
            this.txtInformation.Name = "txtInformation";
            this.txtInformation.Size = new System.Drawing.Size(216, 95);
            this.txtInformation.TabIndex = 41;
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformation.Location = new System.Drawing.Point(38, 235);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(138, 17);
            this.lblInformation.TabIndex = 40;
            this.lblInformation.Text = "Weitere Informationen";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Silver;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(40, 380);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(216, 32);
            this.btnSave.TabIndex = 39;
            this.btnSave.Text = "Speichern";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(41, 74);
            this.txtName.MaxLength = 60;
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(216, 29);
            this.txtName.TabIndex = 35;
            // 
            // lblDeathdate
            // 
            this.lblDeathdate.AutoSize = true;
            this.lblDeathdate.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeathdate.Location = new System.Drawing.Point(38, 178);
            this.lblDeathdate.Name = "lblDeathdate";
            this.lblDeathdate.Size = new System.Drawing.Size(83, 17);
            this.lblDeathdate.TabIndex = 33;
            this.lblDeathdate.Text = "Sterbedatum";
            // 
            // lblBirthdate
            // 
            this.lblBirthdate.AutoSize = true;
            this.lblBirthdate.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthdate.Location = new System.Drawing.Point(37, 121);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.Size = new System.Drawing.Size(91, 17);
            this.lblBirthdate.TabIndex = 32;
            this.lblBirthdate.Text = "Geburtsdatum";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(37, 54);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(124, 17);
            this.lblName.TabIndex = 31;
            this.lblName.Text = "Vor- und Nachname";
            // 
            // lblInfoDeceased
            // 
            this.lblInfoDeceased.AutoSize = true;
            this.lblInfoDeceased.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoDeceased.Location = new System.Drawing.Point(5, 12);
            this.lblInfoDeceased.Name = "lblInfoDeceased";
            this.lblInfoDeceased.Size = new System.Drawing.Size(285, 20);
            this.lblInfoDeceased.TabIndex = 30;
            this.lblInfoDeceased.Text = "Informationen zur verstorbenen Person";
            // 
            // panelRight
            // 
            this.panelRight.Location = new System.Drawing.Point(552, 31);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(264, 427);
            this.panelRight.TabIndex = 3;
            // 
            // panelLeft
            // 
            this.panelLeft.Location = new System.Drawing.Point(0, 31);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(264, 427);
            this.panelLeft.TabIndex = 4;
            // 
            // frmDataRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(816, 489);
            this.Controls.Add(this.panelMiddle);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDataRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelTop.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnGrave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnData)).EndInit();
            this.panelMiddle.ResumeLayout(false);
            this.panelMiddle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Panel panelMiddle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDeathdate;
        private System.Windows.Forms.Label lblBirthdate;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblInfoDeceased;
        private System.Windows.Forms.TextBox txtInformation;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.PictureBox btnData;
        private System.Windows.Forms.PictureBox btnGrave;
        private System.Windows.Forms.MaskedTextBox mtxtBirthdate;
        private System.Windows.Forms.MaskedTextBox mtxtDeathdate;
    }
}