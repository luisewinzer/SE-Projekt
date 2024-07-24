using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace L_R_Screen
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        // Verbindungsobjekt zur Datenbank
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                // SQL-Select-Befehl zum Überprüfen der Benutzerdaten
                string login = "SELECT * FROM [tbl_users] WHERE [username] = ? AND [password] = ?";
                cmd = new OleDbCommand(login, con);
                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                OleDbDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    // Benutzername wird beim erfolgreichen Login gespeichert
                    string username = txtUsername.Text;

                    // WelcomePage öffnen und den Benutzernamen übergeben
                    WelcomePage welcomePage = new WelcomePage(username);
                    welcomePage.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Benutzername oder Passwort ungültig", "Login fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtUsername.Focus();
                }

                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler: " + ex.Message, "Login fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        // Event-Handler für die Checkbox zum Anzeigen/Verbergen des Passworts
        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•';
            }
        }

        private void labelCreateAccount_Click(object sender, EventArgs e)
        {
            new frmRegistration().Show();
            this.Hide();
        }
    }
}

