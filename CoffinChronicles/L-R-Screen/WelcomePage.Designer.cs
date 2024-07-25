namespace L_R_Screen
{
    partial class WelcomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomePage));
            this.PnlTop = new System.Windows.Forms.Panel();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnLogOut = new System.Windows.Forms.Button();
            this.PnlBottom = new System.Windows.Forms.Panel();
            this.PnlMiddle = new System.Windows.Forms.Panel();
            this.LblGraveyard = new System.Windows.Forms.Label();
            this.TxtInfo3 = new System.Windows.Forms.TextBox();
            this.TxtInfo2 = new System.Windows.Forms.TextBox();
            this.TxtInfo1 = new System.Windows.Forms.TextBox();
            this.LblDataRequest = new System.Windows.Forms.Label();
            this.LblChronicles = new System.Windows.Forms.Label();
            this.LblCoffin = new System.Windows.Forms.Label();
            this.IconCC = new System.Windows.Forms.PictureBox();
            this.PnlTop.SuspendLayout();
            this.PnlMiddle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconCC)).BeginInit();
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
            this.BtnExit.TabIndex = 4;
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
            this.BtnLogOut.TabIndex = 3;
            this.BtnLogOut.Text = "Abmelden";
            this.BtnLogOut.UseVisualStyleBackColor = true;
            this.BtnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // PnlBottom
            // 
            this.PnlBottom.BackColor = System.Drawing.Color.Gainsboro;
            this.PnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlBottom.Location = new System.Drawing.Point(0, 458);
            this.PnlBottom.Name = "PnlBottom";
            this.PnlBottom.Size = new System.Drawing.Size(816, 31);
            this.PnlBottom.TabIndex = 0;
            // 
            // PnlMiddle
            // 
            this.PnlMiddle.Controls.Add(this.LblGraveyard);
            this.PnlMiddle.Controls.Add(this.TxtInfo3);
            this.PnlMiddle.Controls.Add(this.TxtInfo2);
            this.PnlMiddle.Controls.Add(this.TxtInfo1);
            this.PnlMiddle.Controls.Add(this.LblDataRequest);
            this.PnlMiddle.Controls.Add(this.LblChronicles);
            this.PnlMiddle.Controls.Add(this.LblCoffin);
            this.PnlMiddle.Controls.Add(this.IconCC);
            this.PnlMiddle.Location = new System.Drawing.Point(0, 31);
            this.PnlMiddle.Name = "PnlMiddle";
            this.PnlMiddle.Size = new System.Drawing.Size(816, 427);
            this.PnlMiddle.TabIndex = 0;
            // 
            // LblGraveyard
            // 
            this.LblGraveyard.AutoSize = true;
            this.LblGraveyard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblGraveyard.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGraveyard.ForeColor = System.Drawing.Color.Black;
            this.LblGraveyard.Location = new System.Drawing.Point(333, 394);
            this.LblGraveyard.Name = "LblGraveyard";
            this.LblGraveyard.Size = new System.Drawing.Size(162, 13);
            this.LblGraveyard.TabIndex = 2;
            this.LblGraveyard.Text = "Weiter zum digitalen Friedhof";
            this.LblGraveyard.Click += new System.EventHandler(this.LblGraveyard_Click);
            // 
            // TxtInfo3
            // 
            this.TxtInfo3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtInfo3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtInfo3.Location = new System.Drawing.Point(177, 346);
            this.TxtInfo3.Multiline = true;
            this.TxtInfo3.Name = "TxtInfo3";
            this.TxtInfo3.Size = new System.Drawing.Size(473, 35);
            this.TxtInfo3.TabIndex = 0;
            this.TxtInfo3.Text = "Über den Button \"Weiter zum digitalen Friedhof\" gelangen Sie direkt zur interakti" +
    "ven Gedenkseite.";
            this.TxtInfo3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtInfo2
            // 
            this.TxtInfo2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtInfo2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtInfo2.Location = new System.Drawing.Point(177, 256);
            this.TxtInfo2.Multiline = true;
            this.TxtInfo2.Name = "TxtInfo2";
            this.TxtInfo2.Size = new System.Drawing.Size(473, 60);
            this.TxtInfo2.TabIndex = 0;
            this.TxtInfo2.Text = "Über den Button \"Weiter zur Dateneingabe\" können Sie als Angehöriger Informatione" +
    "n über die verstorbene Person mit uns teilen, die wir auf unserer interaktiven G" +
    "edenkseite für Sie aufbereiten.";
            this.TxtInfo2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtInfo1
            // 
            this.TxtInfo1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtInfo1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtInfo1.Location = new System.Drawing.Point(177, 171);
            this.TxtInfo1.Multiline = true;
            this.TxtInfo1.Name = "TxtInfo1";
            this.TxtInfo1.Size = new System.Drawing.Size(473, 79);
            this.TxtInfo1.TabIndex = 0;
            this.TxtInfo1.Text = resources.GetString("TxtInfo1.Text");
            this.TxtInfo1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblDataRequest
            // 
            this.LblDataRequest.AutoSize = true;
            this.LblDataRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblDataRequest.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDataRequest.ForeColor = System.Drawing.Color.Black;
            this.LblDataRequest.Location = new System.Drawing.Point(345, 319);
            this.LblDataRequest.Name = "LblDataRequest";
            this.LblDataRequest.Size = new System.Drawing.Size(136, 13);
            this.LblDataRequest.TabIndex = 1;
            this.LblDataRequest.Text = "Weiter zur Dateneingabe";
            this.LblDataRequest.Click += new System.EventHandler(this.LblDataRequest_Click);
            // 
            // LblChronicles
            // 
            this.LblChronicles.AutoSize = true;
            this.LblChronicles.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblChronicles.Location = new System.Drawing.Point(394, 128);
            this.LblChronicles.Name = "LblChronicles";
            this.LblChronicles.Size = new System.Drawing.Size(87, 16);
            this.LblChronicles.TabIndex = 0;
            this.LblChronicles.Text = "Chronicles";
            // 
            // LblCoffin
            // 
            this.LblCoffin.AutoSize = true;
            this.LblCoffin.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCoffin.Location = new System.Drawing.Point(333, 128);
            this.LblCoffin.Name = "LblCoffin";
            this.LblCoffin.Size = new System.Drawing.Size(55, 16);
            this.LblCoffin.TabIndex = 0;
            this.LblCoffin.Text = "Coffin";
            // 
            // IconCC
            // 
            this.IconCC.Image = global::L_R_Screen.Properties.Resources.IconCC;
            this.IconCC.Location = new System.Drawing.Point(327, 76);
            this.IconCC.Name = "IconCC";
            this.IconCC.Size = new System.Drawing.Size(163, 68);
            this.IconCC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IconCC.TabIndex = 0;
            this.IconCC.TabStop = false;
            // 
            // WelcomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
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
            this.Name = "WelcomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.PnlTop.ResumeLayout(false);
            this.PnlMiddle.ResumeLayout(false);
            this.PnlMiddle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconCC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlTop;
        private System.Windows.Forms.Panel PnlBottom;
        private System.Windows.Forms.Button BtnLogOut;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Panel PnlMiddle;
        private System.Windows.Forms.Label LblWelcome;
        private System.Windows.Forms.Label LblChronicles;
        private System.Windows.Forms.Label LblCoffin;
        private System.Windows.Forms.PictureBox IconCC;
        private System.Windows.Forms.Label LblDataRequest;
        private System.Windows.Forms.TextBox TxtInfo1;
        private System.Windows.Forms.TextBox TxtInfo2;
        private System.Windows.Forms.TextBox TxtInfo3;
        private System.Windows.Forms.Label LblGraveyard;
    }
}