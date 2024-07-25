using System;
using System.Drawing;
using System.Windows.Forms;

namespace L_R_Screen
{
    public partial class WelcomePage : Form
    {
        private string username;
        private Label LblUsername;
        private Label LblWelcomeMessage;

        public WelcomePage(string username)
        {
            InitializeComponent();
            this.username = username;
            DisplayUsername();
            DisplayWelcomeMessage();
            this.Activated += new EventHandler(WelcomePage_Activated);
            this.Resize += new EventHandler(WelcomePage_Resize);
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
            PnlTop.Controls.Add(LblUsername);
        }

        private void DisplayWelcomeMessage()
        {
            LblWelcomeMessage = new Label
            {
                Text = $"Willkommen bei Coffin Chronicles, {username}!",
                AutoSize = true,
                BackColor = Color.White,
                Font = new Font(FontFamily.GenericSansSerif, 12f, FontStyle.Bold)
            };

            PnlMiddle.Controls.Add(LblWelcomeMessage);
            CenterWelcomeMessage();
        }

        private void CenterWelcomeMessage()
        {
            if (LblWelcomeMessage != null && PnlMiddle != null)
            {
                int xPosition = (PnlMiddle.Width - LblWelcomeMessage.Width) / 2;
                int yPosition = 35;
                LblWelcomeMessage.Location = new Point(xPosition, yPosition);
                LblWelcomeMessage.BringToFront();
            }
        }

        private void WelcomePage_Activated(object sender, EventArgs e)
        {
            // Verwendet BeginInvoke, um sicherzustellen, dass der Fokus nach der Initialisierung gesetzt wird (Fokus andernfalls auf TxtInfo1)
            this.BeginInvoke((Action)(() => BtnExit.Focus()));
        }

        private void WelcomePage_Resize(object sender, EventArgs e)
        {
            CenterWelcomeMessage();
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
