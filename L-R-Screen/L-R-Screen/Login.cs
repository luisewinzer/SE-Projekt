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

namespace L_R_Screen
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();            
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try 
            { 
                Database.OpenConnection();

                // SQL abfrage zum ermitteln der benutzer daten
                string login = "SELECT * FROM tbl_users WHERE username = ? AND password = ?";

                using (OleDbCommand cmd = new OleDbCommand(login, Database.Connection))
                {
                    cmd.Parameters.AddWithValue("?", txtUsername.Text);
                    cmd.Parameters.AddWithValue("?", txtPassword.Text);

                    using (OleDbDataReader dr = cmd.ExecuteReader())
                    {

                            if (dr.Read() == true)
                            {
                                //Öffnet die MainPage
                                new frmMainPage().Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Benutzername oder Passwort ungültig", "Login fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtUsername.Text = "";
                                txtPassword.Text = "";
                                txtUsername.Focus();
                            }
                    }
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Fehler: " + ex.Message, "Login fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally 
            { 
                Database.CloseConnection(); 
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
            //Öffnet die RegistrationPage
            new frmRegistration().Show();
            this.Hide();
        }
    }
}
