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
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.Tombstone1 = new System.Windows.Forms.PictureBox();
            this.Tombstone2 = new System.Windows.Forms.PictureBox();
            this.Tombstone3 = new System.Windows.Forms.PictureBox();
            this.Tombstone4 = new System.Windows.Forms.PictureBox();
            this.lBirth = new System.Windows.Forms.Label();
            this.lDeath = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.lInfo = new System.Windows.Forms.Label();
            this.bEdit = new System.Windows.Forms.Button();
            this.lGraveName1 = new System.Windows.Forms.Label();
            this.lGraveBirth1 = new System.Windows.Forms.Label();
            this.lGraveDeath1 = new System.Windows.Forms.Label();
            this.lFriedhof = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tombstone1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tombstone2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tombstone3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tombstone4)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Gainsboro;
            this.panelTop.Controls.Add(this.lName);
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
            this.panelBottom.Controls.Add(this.bEdit);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 458);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(816, 31);
            this.panelBottom.TabIndex = 1;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.Honeydew;
            this.panelLeft.Controls.Add(this.lInfo);
            this.panelLeft.Controls.Add(this.lDeath);
            this.panelLeft.Controls.Add(this.lBirth);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 31);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(232, 427);
            this.panelLeft.TabIndex = 2;
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.lFriedhof);
            this.panelRight.Controls.Add(this.lGraveDeath1);
            this.panelRight.Controls.Add(this.lGraveBirth1);
            this.panelRight.Controls.Add(this.lGraveName1);
            this.panelRight.Controls.Add(this.Tombstone1);
            this.panelRight.Controls.Add(this.Tombstone2);
            this.panelRight.Controls.Add(this.Tombstone3);
            this.panelRight.Controls.Add(this.Tombstone4);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(232, 31);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(584, 427);
            this.panelRight.TabIndex = 3;
            // 
            // Tombstone1
            // 
            this.Tombstone1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Tombstone1.Image = global::L_R_Screen.Properties.Resources.Tombstone;
            this.Tombstone1.Location = new System.Drawing.Point(130, 57);
            this.Tombstone1.Name = "Tombstone1";
            this.Tombstone1.Size = new System.Drawing.Size(104, 119);
            this.Tombstone1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Tombstone1.TabIndex = 7;
            this.Tombstone1.TabStop = false;
            // 
            // Tombstone2
            // 
            this.Tombstone2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Tombstone2.Image = global::L_R_Screen.Properties.Resources.Tombstone;
            this.Tombstone2.Location = new System.Drawing.Point(350, 57);
            this.Tombstone2.Name = "Tombstone2";
            this.Tombstone2.Size = new System.Drawing.Size(104, 119);
            this.Tombstone2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Tombstone2.TabIndex = 6;
            this.Tombstone2.TabStop = false;
            // 
            // Tombstone3
            // 
            this.Tombstone3.Cursor = System.Windows.Forms.Cursors.Default;
            this.Tombstone3.Image = global::L_R_Screen.Properties.Resources.Tombstone;
            this.Tombstone3.Location = new System.Drawing.Point(130, 252);
            this.Tombstone3.Name = "Tombstone3";
            this.Tombstone3.Size = new System.Drawing.Size(104, 119);
            this.Tombstone3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Tombstone3.TabIndex = 5;
            this.Tombstone3.TabStop = false;
            // 
            // Tombstone4
            // 
            this.Tombstone4.Cursor = System.Windows.Forms.Cursors.Default;
            this.Tombstone4.Image = global::L_R_Screen.Properties.Resources.Tombstone;
            this.Tombstone4.Location = new System.Drawing.Point(350, 252);
            this.Tombstone4.Name = "Tombstone4";
            this.Tombstone4.Size = new System.Drawing.Size(104, 119);
            this.Tombstone4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Tombstone4.TabIndex = 4;
            this.Tombstone4.TabStop = false;
            // 
            // lBirth
            // 
            this.lBirth.AutoSize = true;
            this.lBirth.Location = new System.Drawing.Point(13, 18);
            this.lBirth.Name = "lBirth";
            this.lBirth.Size = new System.Drawing.Size(45, 17);
            this.lBirth.TabIndex = 0;
            this.lBirth.Text = "label1";
            // 
            // lDeath
            // 
            this.lDeath.AutoSize = true;
            this.lDeath.Location = new System.Drawing.Point(13, 35);
            this.lDeath.Name = "lDeath";
            this.lDeath.Size = new System.Drawing.Size(45, 17);
            this.lDeath.TabIndex = 1;
            this.lDeath.Text = "label2";
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(78, 7);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(45, 17);
            this.lName.TabIndex = 1;
            this.lName.Text = "label3";
            // 
            // lInfo
            // 
            this.lInfo.AutoSize = true;
            this.lInfo.Location = new System.Drawing.Point(13, 134);
            this.lInfo.Name = "lInfo";
            this.lInfo.Size = new System.Drawing.Size(45, 17);
            this.lInfo.TabIndex = 2;
            this.lInfo.Text = "label4";
            // 
            // bEdit
            // 
            this.bEdit.Location = new System.Drawing.Point(157, 0);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(75, 23);
            this.bEdit.TabIndex = 0;
            this.bEdit.Text = "Edit";
            this.bEdit.UseVisualStyleBackColor = true;
            // 
            // lGraveName1
            // 
            this.lGraveName1.AutoSize = true;
            this.lGraveName1.BackColor = System.Drawing.Color.Transparent;
            this.lGraveName1.Location = new System.Drawing.Point(160, 75);
            this.lGraveName1.Name = "lGraveName1";
            this.lGraveName1.Size = new System.Drawing.Size(45, 17);
            this.lGraveName1.TabIndex = 8;
            this.lGraveName1.Text = "label1";
            // 
            // lGraveBirth1
            // 
            this.lGraveBirth1.AutoSize = true;
            this.lGraveBirth1.BackColor = System.Drawing.Color.Transparent;
            this.lGraveBirth1.Location = new System.Drawing.Point(160, 117);
            this.lGraveBirth1.Name = "lGraveBirth1";
            this.lGraveBirth1.Size = new System.Drawing.Size(45, 17);
            this.lGraveBirth1.TabIndex = 9;
            this.lGraveBirth1.Text = "label2";
            // 
            // lGraveDeath1
            // 
            this.lGraveDeath1.AutoSize = true;
            this.lGraveDeath1.BackColor = System.Drawing.Color.Transparent;
            this.lGraveDeath1.Location = new System.Drawing.Point(160, 134);
            this.lGraveDeath1.Name = "lGraveDeath1";
            this.lGraveDeath1.Size = new System.Drawing.Size(45, 17);
            this.lGraveDeath1.TabIndex = 10;
            this.lGraveDeath1.Text = "label3";
            // 
            // lFriedhof
            // 
            this.lFriedhof.AutoSize = true;
            this.lFriedhof.Location = new System.Drawing.Point(216, 18);
            this.lFriedhof.Name = "lFriedhof";
            this.lFriedhof.Size = new System.Drawing.Size(150, 17);
            this.lFriedhof.TabIndex = 11;
            this.lFriedhof.Text = "Friedhof Himmelsstadt";
            // 
            // frmMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(816, 489);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tombstone1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tombstone2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tombstone3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tombstone4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox Tombstone4;
        private System.Windows.Forms.PictureBox Tombstone1;
        private System.Windows.Forms.PictureBox Tombstone2;
        private System.Windows.Forms.PictureBox Tombstone3;
        private System.Windows.Forms.Label lDeath;
        private System.Windows.Forms.Label lBirth;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Label lInfo;
        private System.Windows.Forms.Label lFriedhof;
        private System.Windows.Forms.Label lGraveDeath1;
        private System.Windows.Forms.Label lGraveBirth1;
        private System.Windows.Forms.Label lGraveName1;
    }
}