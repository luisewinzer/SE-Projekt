using System;

namespace L_R_Screen
{
    partial class frmMainPage
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
            this.panelMiddle = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtDeathdate = new System.Windows.Forms.TextBox();
            this.txtBirthdate = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labelConPassword = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblInfoDeceased = new System.Windows.Forms.Label();
            this.txtInformation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
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
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 458);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(816, 31);
            this.panelBottom.TabIndex = 1;
            // 
            // panelMiddle
            // 
            this.panelMiddle.BackColor = System.Drawing.Color.Honeydew;
            this.panelMiddle.Controls.Add(this.txtInformation);
            this.panelMiddle.Controls.Add(this.label1);
            this.panelMiddle.Controls.Add(this.btnSave);
            this.panelMiddle.Controls.Add(this.txtDeathdate);
            this.panelMiddle.Controls.Add(this.txtBirthdate);
            this.panelMiddle.Controls.Add(this.txtName);
            this.panelMiddle.Controls.Add(this.labelConPassword);
            this.panelMiddle.Controls.Add(this.labelPassword);
            this.panelMiddle.Controls.Add(this.lblName);
            this.panelMiddle.Controls.Add(this.lblInfoDeceased);
            this.panelMiddle.Location = new System.Drawing.Point(262, 31);
            this.panelMiddle.Name = "panelMiddle";
            this.panelMiddle.Size = new System.Drawing.Size(293, 427);
            this.panelMiddle.TabIndex = 2;
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
            // txtDeathdate
            // 
            this.txtDeathdate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDeathdate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDeathdate.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeathdate.ForeColor = System.Drawing.Color.Black;
            this.txtDeathdate.Location = new System.Drawing.Point(41, 209);
            this.txtDeathdate.Multiline = true;
            this.txtDeathdate.Name = "txtDeathdate";
            this.txtDeathdate.Size = new System.Drawing.Size(216, 31);
            this.txtDeathdate.TabIndex = 37;
            // 
            // txtBirthdate
            // 
            this.txtBirthdate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBirthdate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBirthdate.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBirthdate.ForeColor = System.Drawing.Color.Black;
            this.txtBirthdate.Location = new System.Drawing.Point(41, 143);
            this.txtBirthdate.Multiline = true;
            this.txtBirthdate.Name = "txtBirthdate";
            this.txtBirthdate.Size = new System.Drawing.Size(216, 31);
            this.txtBirthdate.TabIndex = 36;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(41, 76);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(216, 31);
            this.txtName.TabIndex = 35;
            // 
            // labelConPassword
            // 
            this.labelConPassword.AutoSize = true;
            this.labelConPassword.Location = new System.Drawing.Point(37, 187);
            this.labelConPassword.Name = "labelConPassword";
            this.labelConPassword.Size = new System.Drawing.Size(87, 17);
            this.labelConPassword.TabIndex = 33;
            this.labelConPassword.Text = "Sterbedatum";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(37, 121);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(96, 17);
            this.labelPassword.TabIndex = 32;
            this.labelPassword.Text = "Geburtsdatum";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(37, 54);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(130, 17);
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
            // txtInformation
            // 
            this.txtInformation.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtInformation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInformation.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInformation.ForeColor = System.Drawing.Color.Black;
            this.txtInformation.Location = new System.Drawing.Point(41, 277);
            this.txtInformation.Multiline = true;
            this.txtInformation.Name = "txtInformation";
            this.txtInformation.Size = new System.Drawing.Size(216, 83);
            this.txtInformation.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "Weitere Informationen";
            // 
            // frmMainPage
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
            this.Name = "frmMainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelTop.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox txtDeathdate;
        private System.Windows.Forms.TextBox txtBirthdate;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labelConPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblInfoDeceased;
        private System.Windows.Forms.TextBox txtInformation;
        private System.Windows.Forms.Label label1;
    }
}