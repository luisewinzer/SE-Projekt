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
    public partial class frmRegistration : Form
    {
        public frmRegistration()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" && txtPassword.Text == "" && txtConPassword.Text == "")
            {
                MessageBox.Show("Felder für Benutzername und Passwort sind leer", "Registrierung fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text == txtConPassword.Text)
            {
                con.Open();
                string register = "INSERT INTO tbl.users VALUES ('" + txtUsername.Text + "', '" + txtPassword.Text + "')";
                cmd = new OleDbCommand(register, con);
                cmd.ExecuteNonQuery();
                con.Close();

                txtUsername.Text = "";
                txtPassword.Text = "";
                txtConPassword.Text = "";

                MessageBox.Show("Account erfolgreich erstellt", "Registrierung erfolgreich", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
