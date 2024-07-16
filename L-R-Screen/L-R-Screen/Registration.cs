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
using System.IO;
using System.Reflection;
using Microsoft.Win32;

namespace L_R_Screen
{
    public partial class frmRegistration : Form
    {
        public frmRegistration()
        {
            InitializeComponent();
            
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" && txtPassword.Text == "" && txtConPassword.Text == "")
            {
                MessageBox.Show("Felder für Benutzername und Passwort sind leer", "Registrierung fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text.Length < 4 || txtPassword.Text.Length > 12)
            {
                MessageBox.Show("Das Passwort muss zwischen 4 und 12 Zeichen lang sein", "Registrierung fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text == txtConPassword.Text)
            {
                try { 

                    Database.OpenConnection();

                    // Überprüfung, ob Benutzername bereits existiert
                    string checkUser = "SELECT COUNT(*) FROM [tbl_users] WHERE [username] = ?";
                    using (OleDbCommand cmd = new OleDbCommand(checkUser, Database.Connection))
                    {

                        cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                        int userCount = (int)cmd.ExecuteScalar();
                

                    if (userCount > 0)
                    {
                        MessageBox.Show("Benutzername existiert bereits", "Registrierung fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Database.CloseConnection();
                    }
                    }
                    // SQL-Insert-Befehl, um neuen Benutzer hinzuzufügen
                    string register = "INSERT INTO [tbl_users] ([username], [password]) VALUES (?, ?)";

                    using (OleDbCommand cmd = new OleDbCommand(register, Database.Connection))
                    {
                        cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                        cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                        cmd.ExecuteNonQuery();
                    }

                    Database.CloseConnection();

                    // Zurücksetzen der Eingabefelder
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtConPassword.Text = "";

                    MessageBox.Show("Account erfolgreich erstellt", "Registrierung erfolgreich", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Öffnet die LoginPage
                    new frmLogin().Show();
                    this.Hide();
                }        
                catch (Exception ex)
                {
                    MessageBox.Show("Fehler: " + ex.Message, "Registrierung fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Database.CloseConnection();
                }
            }
            else
            {
                MessageBox.Show("Passwörter stimmen nicht überein", "Registrierung fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = "";
                txtConPassword.Text = "";
                txtPassword.Focus();
            }
        }


        // Event-Handler für die Checkbox zum Anzeigen/Verbergen des Passworts
        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtConPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•';
                txtConPassword.PasswordChar = '•';
            }
        }

        private void labelBackToLogin_Click(object sender, EventArgs e)
        {
            //Öffnet die LoginPage
            new frmLogin().Show();
            this.Hide();
        }
    }
}
