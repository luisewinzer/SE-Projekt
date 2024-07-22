using System;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace L_R_Screen
{
    public partial class frmMainPage : Form
    {

        private string username;
        private Label lblUsername;

        public frmMainPage(string username)
        {
            InitializeComponent();
            this.username = username;
            DisplayUsername();
        }

        // Verbindungsobjekt zur Datenbank
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtBirthdate.Text) || string.IsNullOrWhiteSpace(txtDeathdate.Text) || string.IsNullOrWhiteSpace(txtInformation.Text))
            {
                MessageBox.Show("Bitte füllen Sie alle Felder aus", "Speichern fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                con.Open();

                // SQL-Insert-Befehl, um neuen Verstorbenen hinzuzufügen
                string register = "INSERT INTO [tbl_tombstones] ([name], [birthdate], [deathdate], [information]) VALUES (?, ?, ?, ?)";
                cmd = new OleDbCommand(register, con);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@birthdate", txtBirthdate.Text);
                cmd.Parameters.AddWithValue("@deathdate", txtDeathdate.Text);
                cmd.Parameters.AddWithValue("@information", txtInformation.Text);
                cmd.ExecuteNonQuery();
                con.Close();

                // Zurücksetzen der Eingabefelder
                txtName.Text = "";
                txtBirthdate.Text = "";
                txtDeathdate.Text = "";
                txtInformation.Text = "";

                MessageBox.Show("Daten erfolgreich gespeichert", "Speichern erfolgreich", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler: " + ex.Message, "Speichern fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
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

        private void btnHome_Click(object sender, EventArgs e)
        {
            WelcomePage welcomePage = new WelcomePage(username);
            welcomePage.Show();
            this.Close();
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void btnGrave_Click(object sender, EventArgs e)
        {
            Graveyard graveyard = new Graveyard(username);
            graveyard.Show();
            this.Close();
        }
    }
}


