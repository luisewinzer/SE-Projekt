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
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.panelMiddle = new System.Windows.Forms.Panel();
            this.lblGraveyard = new System.Windows.Forms.Label();
            this.txtInfo3 = new System.Windows.Forms.TextBox();
            this.txtInfo2 = new System.Windows.Forms.TextBox();
            this.txtInfo1 = new System.Windows.Forms.TextBox();
            this.lblDataRequest = new System.Windows.Forms.Label();
            this.labelChronicles = new System.Windows.Forms.Label();
            this.labelCoffin = new System.Windows.Forms.Label();
            this.IconCC = new System.Windows.Forms.PictureBox();
            this.panelTop.SuspendLayout();
            this.panelMiddle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconCC)).BeginInit();
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
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(284, 35);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(251, 20);
            this.lblWelcome.TabIndex = 30;
            this.lblWelcome.Text = "Willkommen bei Coffin Chronicles!";
            // 
            // panelMiddle
            // 
            this.panelMiddle.Controls.Add(this.lblGraveyard);
            this.panelMiddle.Controls.Add(this.txtInfo3);
            this.panelMiddle.Controls.Add(this.txtInfo2);
            this.panelMiddle.Controls.Add(this.txtInfo1);
            this.panelMiddle.Controls.Add(this.lblDataRequest);
            this.panelMiddle.Controls.Add(this.labelChronicles);
            this.panelMiddle.Controls.Add(this.labelCoffin);
            this.panelMiddle.Controls.Add(this.IconCC);
            this.panelMiddle.Controls.Add(this.lblWelcome);
            this.panelMiddle.Location = new System.Drawing.Point(0, 31);
            this.panelMiddle.Name = "panelMiddle";
            this.panelMiddle.Size = new System.Drawing.Size(816, 427);
            this.panelMiddle.TabIndex = 3;
            // 
            // lblGraveyard
            // 
            this.lblGraveyard.AutoSize = true;
            this.lblGraveyard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblGraveyard.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGraveyard.ForeColor = System.Drawing.Color.Black;
            this.lblGraveyard.Location = new System.Drawing.Point(333, 394);
            this.lblGraveyard.Name = "lblGraveyard";
            this.lblGraveyard.Size = new System.Drawing.Size(162, 13);
            this.lblGraveyard.TabIndex = 39;
            this.lblGraveyard.Text = "Weiter zum digitalen Friedhof";
            this.lblGraveyard.Click += new System.EventHandler(this.lblGraveyard_Click);
            // 
            // txtInfo3
            // 
            this.txtInfo3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInfo3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfo3.Location = new System.Drawing.Point(177, 346);
            this.txtInfo3.Multiline = true;
            this.txtInfo3.Name = "txtInfo3";
            this.txtInfo3.Size = new System.Drawing.Size(473, 35);
            this.txtInfo3.TabIndex = 38;
            this.txtInfo3.Text = "Über den Button \"Weiter zum digitalen Friedhof\" gelangen Sie direkt zur interakti" +
    "ven Gedenkseite.";
            this.txtInfo3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtInfo2
            // 
            this.txtInfo2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInfo2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfo2.Location = new System.Drawing.Point(177, 256);
            this.txtInfo2.Multiline = true;
            this.txtInfo2.Name = "txtInfo2";
            this.txtInfo2.Size = new System.Drawing.Size(473, 60);
            this.txtInfo2.TabIndex = 37;
            this.txtInfo2.Text = "Über den Button \"Weiter zur Dateneingabe\" können Sie als Angehöriger Informatione" +
    "n über die verstorbene Person mit uns teilen, die wir auf unserer interaktiven G" +
    "edenkseite für Sie aufbereiten.";
            this.txtInfo2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtInfo1
            // 
            this.txtInfo1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInfo1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfo1.Location = new System.Drawing.Point(177, 171);
            this.txtInfo1.Multiline = true;
            this.txtInfo1.Name = "txtInfo1";
            this.txtInfo1.Size = new System.Drawing.Size(473, 79);
            this.txtInfo1.TabIndex = 36;
            this.txtInfo1.Text = resources.GetString("txtInfo1.Text");
            this.txtInfo1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDataRequest
            // 
            this.lblDataRequest.AutoSize = true;
            this.lblDataRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDataRequest.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataRequest.ForeColor = System.Drawing.Color.Black;
            this.lblDataRequest.Location = new System.Drawing.Point(345, 319);
            this.lblDataRequest.Name = "lblDataRequest";
            this.lblDataRequest.Size = new System.Drawing.Size(136, 13);
            this.lblDataRequest.TabIndex = 35;
            this.lblDataRequest.Text = "Weiter zur Dateneingabe";
            this.lblDataRequest.Click += new System.EventHandler(this.lblDataRequest_Click);
            // 
            // labelChronicles
            // 
            this.labelChronicles.AutoSize = true;
            this.labelChronicles.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChronicles.Location = new System.Drawing.Point(394, 128);
            this.labelChronicles.Name = "labelChronicles";
            this.labelChronicles.Size = new System.Drawing.Size(87, 16);
            this.labelChronicles.TabIndex = 34;
            this.labelChronicles.Text = "Chronicles";
            // 
            // labelCoffin
            // 
            this.labelCoffin.AutoSize = true;
            this.labelCoffin.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCoffin.Location = new System.Drawing.Point(333, 128);
            this.labelCoffin.Name = "labelCoffin";
            this.labelCoffin.Size = new System.Drawing.Size(55, 16);
            this.labelCoffin.TabIndex = 33;
            this.labelCoffin.Text = "Coffin";
            // 
            // IconCC
            // 
            this.IconCC.Image = global::L_R_Screen.Properties.Resources.IconCC;
            this.IconCC.Location = new System.Drawing.Point(327, 76);
            this.IconCC.Name = "IconCC";
            this.IconCC.Size = new System.Drawing.Size(163, 68);
            this.IconCC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IconCC.TabIndex = 32;
            this.IconCC.TabStop = false;
            // 
            // WelcomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(816, 489);
            this.Controls.Add(this.panelMiddle);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WelcomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelTop.ResumeLayout(false);
            this.panelMiddle.ResumeLayout(false);
            this.panelMiddle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconCC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelMiddle;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label labelChronicles;
        private System.Windows.Forms.Label labelCoffin;
        private System.Windows.Forms.PictureBox IconCC;
        private System.Windows.Forms.Label lblDataRequest;
        private System.Windows.Forms.TextBox txtInfo1;
        private System.Windows.Forms.TextBox txtInfo2;
        private System.Windows.Forms.TextBox txtInfo3;
        private System.Windows.Forms.Label lblGraveyard;
    }
}