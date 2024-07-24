using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace L_R_Screen
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        // Verbindungsobjekt zur Datenbank
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=DatabaseCC.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            if (TxtUsername.Text == "" && TxtPassword.Text == "" && TxtConPassword.Text == "")
            {
                MessageBox.Show("Felder für Benutzername und Passwort sind leer", "Registrierung fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TxtPassword.Text.Length < 4 || TxtPassword.Text.Length > 12)
            {
                MessageBox.Show("Das Passwort muss zwischen 4 und 12 Zeichen lang sein", "Registrierung fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TxtPassword.Text == TxtConPassword.Text)
            {
                try
                {
                    con.Open();

                    // Überprüfung, ob Benutzername bereits existiert
                    string checkUser = "SELECT COUNT(*) FROM [TblUsers] WHERE [username] = ?";
                    cmd = new OleDbCommand(checkUser, con);
                    cmd.Parameters.AddWithValue("@username", TxtUsername.Text);
                    int userCount = (int)cmd.ExecuteScalar();

                    if (userCount > 0)
                    {
                        MessageBox.Show("Benutzername existiert bereits", "Registrierung fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        con.Close();
                        return;
                    }

                    // SQL-Insert-Befehl, um neuen Benutzer hinzuzufügen
                    string register = "INSERT INTO [TblUsers] ([username], [password]) VALUES (?, ?)";
                    cmd = new OleDbCommand(register, con);
                    cmd.Parameters.AddWithValue("@name", TxtUsername.Text);
                    cmd.Parameters.AddWithValue("@password", TxtPassword.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    // Zurücksetzen der Eingabefelder
                    TxtUsername.Text = "";
                    TxtPassword.Text = "";
                    TxtConPassword.Text = "";

                    MessageBox.Show("Account erfolgreich erstellt", "Registrierung erfolgreich", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    new Login().Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fehler: " + ex.Message, "Registrierung fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Passwörter stimmen nicht überein", "Registrierung fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtPassword.Text = "";
                TxtConPassword.Text = "";
                TxtPassword.Focus();
            }
        }

        // Event-Handler für die Checkbox zum Anzeigen/Verbergen des Passworts
        private void CbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (CbShowPassword.Checked)
            {
                TxtPassword.PasswordChar = '\0';
                TxtConPassword.PasswordChar = '\0';
            }
            else
            {
                TxtPassword.PasswordChar = '•';
                TxtConPassword.PasswordChar = '•';
            }
        }

        private void LblBackToLogin_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}