using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L_R_Screen
{
    public partial class frmMainPage : Form
    {
        private string username;

        public frmMainPage(string username)
        {
            InitializeComponent();
            this.username = username;
            DisplayUsername();
        }

        private void DisplayUsername()
        {
            Label lblUsername = new Label();
            lblUsername.Text = $"User: {username}";
            lblUsername.Location = new Point(10, 10);
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.Gainsboro;
            lblUsername.Font = new Font(lblUsername.Font.FontFamily, 8f, FontStyle.Regular);
            this.Controls.Add(lblUsername);
            panelTop.Controls.Add(lblUsername);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            frmLogin loginForm = new frmLogin();
            loginForm.Show();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
