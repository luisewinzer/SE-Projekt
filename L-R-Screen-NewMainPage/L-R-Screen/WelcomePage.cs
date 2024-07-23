using System;
using System.Drawing;
using System.Windows.Forms;

namespace L_R_Screen
{
    public partial class WelcomePage : Form
    {
        private string username;
        private Label lblUsername;

        public WelcomePage(string username)
        {
            InitializeComponent();
            this.username = username;
            DisplayUsername();
        }

        private void DisplayUsername()
        {
            lblUsername = new Label
            {
                Text = $"User: {username}",
                Location = new Point(10, 10),
                AutoSize = true,
                BackColor = Color.Gainsboro,
                Font = new Font(FontFamily.GenericSansSerif, 8f, FontStyle.Regular)
            };
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

        private void lblDataRequest_Click(object sender, EventArgs e)
        {
            frmDataRequest dataRequest = new frmDataRequest(username);
            dataRequest.Show();
            this.Hide();
        }

        private void lblGraveyard_Click(object sender, EventArgs e)
        {
            Graveyard graveyard = new Graveyard(username);
            graveyard.Show();
            this.Hide();
        }
    }
}