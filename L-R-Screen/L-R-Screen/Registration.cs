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
    public partial class frmRegistration : Form
    {
        private OleDbConnection con;
        public frmRegistration()
        {
            InitializeComponent();
            string databasePath = ExtractDatabaseFile("L_R_Screen.db_users.mdb"); // Anpassung des Ressourcennamens
            string connectionString = $@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={databasePath};";
            con = new OleDbConnection(connectionString);
        }

        //OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private string ExtractDatabaseFile(string resourceName)
        {
            string tempPath = Path.GetTempPath();
            string databasePath = Path.Combine(tempPath, "db_users.mdb");

            using (Stream resourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName))
            {
                if (resourceStream == null)
                {
                    throw new Exception($"Ressource '{resourceName}' wurde nicht gefunden.");
                }

                using (FileStream fileStream = new FileStream(databasePath, FileMode.Create, FileAccess.Write))
                {
                    resourceStream.CopyTo(fileStream);
                }
            }

            return databasePath;
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" && txtPassword.Text == "" && txtConPassword.Text == "")
            {
                MessageBox.Show("Felder für Benutzername und Passwort sind leer", "Registrierung fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text == txtConPassword.Text)
            {
                try
                {
                    con.Open();
                    string register = "INSERT INTO tbl_users (username, password) VALUES (?, ?)";
                    cmd = new OleDbCommand(register, con);
                    cmd.Parameters.AddWithValue("?", txtUsername.Text);
                    cmd.Parameters.AddWithValue("?", txtPassword.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Account erfolgreich erstellt", "Registrierung erfolgreich", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Textfelder leeren
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtConPassword.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fehler: " + ex.Message);
                }
                finally
                {
                    if (con != null && con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
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
            new frmLogin().Show();
            this.Hide();
        }
    }
}
