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

<<<<<<< HEAD
        // Verbindungsobjekt zur Datenbank
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

=======
>>>>>>> 91805e2820e3aaa6d4d377b10d38ca28a0394e3c
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
<<<<<<< HEAD
                try
                {
                    con.Open();

                    // Überprüfung, ob Benutzername bereits existiert
                    string checkUser = "SELECT COUNT(*) FROM [tbl_users] WHERE [username] = ?";
                    cmd = new OleDbCommand(checkUser, con);
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    int userCount = (int)cmd.ExecuteScalar();

                    if (userCount > 0)
                    {
                        MessageBox.Show("Benutzername existiert bereits", "Registrierung fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        con.Close();
                        return;
                    }

                    // SQL-Insert-Befehl, um neuen Benutzer hinzuzufügen
                    string register = "INSERT INTO [tbl_users] ([username], [password]) VALUES (?, ?)";
                    cmd = new OleDbCommand(register, con);
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
=======
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
>>>>>>> 91805e2820e3aaa6d4d377b10d38ca28a0394e3c

                    // Zurücksetzen der Eingabefelder
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtConPassword.Text = "";

                    MessageBox.Show("Account erfolgreich erstellt", "Registrierung erfolgreich", MessageBoxButtons.OK, MessageBoxIcon.Information);
<<<<<<< HEAD
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fehler: " + ex.Message, "Registrierung fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
=======

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
>>>>>>> 91805e2820e3aaa6d4d377b10d38ca28a0394e3c
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

<<<<<<< HEAD
=======

>>>>>>> 91805e2820e3aaa6d4d377b10d38ca28a0394e3c
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
