using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace L_R_Screen
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        // Verbindungsobjekt zur Datenbank
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=DatabaseCC.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                // SQL-Select-Befehl zum Überprüfen der Benutzerdaten
                string login = "SELECT * FROM [TblUsers] WHERE [username] = ? AND [password] = ?";
                cmd = new OleDbCommand(login, con);
                cmd.Parameters.AddWithValue("@username", TxtUsername.Text);
                cmd.Parameters.AddWithValue("@password", TxtPassword.Text);
                OleDbDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    // Benutzername wird beim erfolgreichen Login gespeichert
                    string username = TxtUsername.Text;

                    // WelcomePage öffnen und den Benutzernamen übergeben
                    WelcomePage welcomePage = new WelcomePage(username);
                    welcomePage.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Benutzername oder Passwort ungültig", "Login fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtUsername.Text = "";
                    TxtPassword.Text = "";
                    TxtUsername.Focus();
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
        private void CbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (CbShowPassword.Checked)
            {
                TxtPassword.PasswordChar = '\0';
            }
            else
            {
                TxtPassword.PasswordChar = '•';
            }
        }

        private void LblCreateAccount_Click(object sender, EventArgs e)
        {
            new Registration().Show();
            this.Hide();
        }
    }
}