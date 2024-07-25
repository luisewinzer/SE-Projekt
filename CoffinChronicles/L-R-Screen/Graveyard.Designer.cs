namespace L_R_Screen
{
    partial class Graveyard
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
            this.BtnData = new System.Windows.Forms.PictureBox();
            this.BtnGrave = new System.Windows.Forms.PictureBox();
            this.BtnHome = new System.Windows.Forms.PictureBox();
            this.PnlMiddle = new System.Windows.Forms.Panel();
            this.Tombstone3 = new System.Windows.Forms.PictureBox();
            this.Tombstone2 = new System.Windows.Forms.PictureBox();
            this.Tombstone1 = new System.Windows.Forms.PictureBox();
            this.PnlTop.SuspendLayout();
            this.PnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGrave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnHome)).BeginInit();
            this.PnlMiddle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tombstone3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tombstone2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tombstone1)).BeginInit();
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
            this.BtnExit.TabIndex = 5;
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
            this.BtnLogOut.TabIndex = 4;
            this.BtnLogOut.Text = "Abmelden";
            this.BtnLogOut.UseVisualStyleBackColor = true;
            this.BtnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // PnlBottom
            // 
            this.PnlBottom.BackColor = System.Drawing.Color.Gainsboro;
            this.PnlBottom.Controls.Add(this.BtnData);
            this.PnlBottom.Controls.Add(this.BtnGrave);
            this.PnlBottom.Controls.Add(this.BtnHome);
            this.PnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlBottom.Location = new System.Drawing.Point(0, 458);
            this.PnlBottom.Name = "PnlBottom";
            this.PnlBottom.Size = new System.Drawing.Size(816, 31);
            this.PnlBottom.TabIndex = 0;
            // 
            // BtnData
            // 
            this.BtnData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnData.Image = global::L_R_Screen.Properties.Resources.form;
            this.BtnData.Location = new System.Drawing.Point(388, 0);
            this.BtnData.Name = "BtnData";
            this.BtnData.Size = new System.Drawing.Size(30, 31);
            this.BtnData.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnData.TabIndex = 2;
            this.BtnData.TabStop = false;
            this.BtnData.Click += new System.EventHandler(this.BtnData_Click);
            // 
            // BtnGrave
            // 
            this.BtnGrave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGrave.Image = global::L_R_Screen.Properties.Resources.tombstone__1_;
            this.BtnGrave.Location = new System.Drawing.Point(455, 0);
            this.BtnGrave.Name = "BtnGrave";
            this.BtnGrave.Size = new System.Drawing.Size(31, 31);
            this.BtnGrave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnGrave.TabIndex = 3;
            this.BtnGrave.TabStop = false;
            this.BtnGrave.Click += new System.EventHandler(this.BtnGrave_Click);
            // 
            // BtnHome
            // 
            this.BtnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnHome.Image = global::L_R_Screen.Properties.Resources.home;
            this.BtnHome.Location = new System.Drawing.Point(319, 0);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(31, 31);
            this.BtnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnHome.TabIndex = 1;
            this.BtnHome.TabStop = false;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // PnlMiddle
            // 
            this.PnlMiddle.BackColor = System.Drawing.Color.Honeydew;
            this.PnlMiddle.Controls.Add(this.Tombstone3);
            this.PnlMiddle.Controls.Add(this.Tombstone2);
            this.PnlMiddle.Controls.Add(this.Tombstone1);
            this.PnlMiddle.Location = new System.Drawing.Point(0, 31);
            this.PnlMiddle.Name = "PnlMiddle";
            this.PnlMiddle.Size = new System.Drawing.Size(816, 427);
            this.PnlMiddle.TabIndex = 0;
            // 
            // Tombstone3
            // 
            this.Tombstone3.Image = global::L_R_Screen.Properties.Resources.Tombstone;
            this.Tombstone3.Location = new System.Drawing.Point(551, 115);
            this.Tombstone3.Name = "Tombstone3";
            this.Tombstone3.Size = new System.Drawing.Size(125, 148);
            this.Tombstone3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Tombstone3.TabIndex = 0;
            this.Tombstone3.TabStop = false;
            // 
            // Tombstone2
            // 
            this.Tombstone2.Image = global::L_R_Screen.Properties.Resources.Tombstone;
            this.Tombstone2.Location = new System.Drawing.Point(341, 115);
            this.Tombstone2.Name = "Tombstone2";
            this.Tombstone2.Size = new System.Drawing.Size(125, 148);
            this.Tombstone2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Tombstone2.TabIndex = 0;
            this.Tombstone2.TabStop = false;
            // 
            // Tombstone1
            // 
            this.Tombstone1.Image = global::L_R_Screen.Properties.Resources.Tombstone;
            this.Tombstone1.Location = new System.Drawing.Point(132, 115);
            this.Tombstone1.Name = "Tombstone1";
            this.Tombstone1.Size = new System.Drawing.Size(125, 148);
            this.Tombstone1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Tombstone1.TabIndex = 0;
            this.Tombstone1.TabStop = false;
            // 
            // Graveyard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 52F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(816, 489);
            this.Controls.Add(this.PnlMiddle);
            this.Controls.Add(this.PnlBottom);
            this.Controls.Add(this.PnlTop);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Graveyard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.PnlTop.ResumeLayout(false);
            this.PnlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGrave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnHome)).EndInit();
            this.PnlMiddle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Tombstone3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tombstone2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tombstone1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlTop;
        private System.Windows.Forms.Panel PnlBottom;
        private System.Windows.Forms.Button BtnLogOut;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Panel PnlMiddle;
        private System.Windows.Forms.PictureBox Tombstone1;
        private System.Windows.Forms.PictureBox Tombstone3;
        private System.Windows.Forms.PictureBox Tombstone2;
        private System.Windows.Forms.PictureBox BtnGrave;
        private System.Windows.Forms.PictureBox BtnHome;
        private System.Windows.Forms.PictureBox BtnData;
    }
}