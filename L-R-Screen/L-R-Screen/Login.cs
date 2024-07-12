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
        private OleDbConnection con;
        public frmLogin()
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

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            con.Open();
            // Verwende Parameter, um SQL-Injection zu vermeiden
            string login = "SELECT * FROM tbl_users WHERE username = ? AND password = ?";
            cmd = new OleDbCommand(login, con);
            cmd.Parameters.AddWithValue("?", txtUsername.Text);
            cmd.Parameters.AddWithValue("?", txtPassword.Text);

            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
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
