using System;
using System.Drawing;
using System.Windows.Forms;

namespace L_R_Screen
{
    public partial class WelcomePage : Form
    {
        private string username;
        private Label LblUsername;

        public WelcomePage(string username)
        {
            InitializeComponent();
            this.username = username;
            DisplayUsername();
        }

        private void DisplayUsername()
        {
            LblUsername = new Label
            {
                Text = $"User: {username}",
                Location = new Point(10, 10),
                AutoSize = true,
                BackColor = Color.Gainsboro,
                Font = new Font(FontFamily.GenericSansSerif, 8f, FontStyle.Regular)
            };
            this.Controls.Add(LblUsername);
            PnlTop.Controls.Add(LblUsername);
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LblDataRequest_Click(object sender, EventArgs e)
        {
            DataRequest dataRequest = new DataRequest(username);
            dataRequest.Show();
            this.Hide();
        }

        private void LblGraveyard_Click(object sender, EventArgs e)
        {
            Graveyard graveyard = new Graveyard(username);
            graveyard.Show();
            this.Hide();
        }
    }
}