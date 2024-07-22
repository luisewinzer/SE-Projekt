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
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelMiddle = new System.Windows.Forms.Panel();
            this.Tombstone1 = new System.Windows.Forms.PictureBox();
            this.Tombstone2 = new System.Windows.Forms.PictureBox();
            this.Tombstone3 = new System.Windows.Forms.PictureBox();
            this.panelTop.SuspendLayout();
            this.panelMiddle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tombstone1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tombstone2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tombstone3)).BeginInit();
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
            this.panelMiddle.Controls.Add(this.Tombstone3);
            this.panelMiddle.Controls.Add(this.Tombstone2);
            this.panelMiddle.Controls.Add(this.Tombstone1);
            this.panelMiddle.Location = new System.Drawing.Point(0, 31);
            this.panelMiddle.Name = "panelMiddle";
            this.panelMiddle.Size = new System.Drawing.Size(816, 427);
            this.panelMiddle.TabIndex = 3;
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
            // Tombstone2
            // 
            this.Tombstone2.Image = global::L_R_Screen.Properties.Resources.Tombstone;
            this.Tombstone2.Location = new System.Drawing.Point(341, 115);
            this.Tombstone2.Name = "Tombstone2";
            this.Tombstone2.Size = new System.Drawing.Size(125, 148);
            this.Tombstone2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Tombstone2.TabIndex = 1;
            this.Tombstone2.TabStop = false;
            // 
            // Tombstone3
            // 
            this.Tombstone3.Image = global::L_R_Screen.Properties.Resources.Tombstone;
            this.Tombstone3.Location = new System.Drawing.Point(551, 115);
            this.Tombstone3.Name = "Tombstone3";
            this.Tombstone3.Size = new System.Drawing.Size(125, 148);
            this.Tombstone3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Tombstone3.TabIndex = 2;
            this.Tombstone3.TabStop = false;
            // 
            // Graveyard
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
            this.Name = "Graveyard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelTop.ResumeLayout(false);
            this.panelMiddle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Tombstone1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tombstone2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tombstone3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelMiddle;
        private System.Windows.Forms.PictureBox Tombstone1;
        private System.Windows.Forms.PictureBox Tombstone3;
        private System.Windows.Forms.PictureBox Tombstone2;
    }
}