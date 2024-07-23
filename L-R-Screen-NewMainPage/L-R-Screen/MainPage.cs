using System;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
using System.Text.RegularExpressions;
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
            InitializeDateValidation();
            InitializeNameValidation();
        }

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

        private void InitializeDateValidation()
        {
            mtxtBirthdate.Leave += new EventHandler(DateValidation);
            mtxtDeathdate.Leave += new EventHandler(DateValidation);
        }

        private void InitializeNameValidation()
        {
            txtName.MaxLength = 50; // Maximale Länge der Namen festlegen
        }

        private void DateValidation(object sender, EventArgs e)
        {
            MaskedTextBox textBox = sender as MaskedTextBox;
            if (textBox != null && !string.IsNullOrWhiteSpace(textBox.Text))
            {
                if (!IsValidDate(textBox.Text))
                {
                    MessageBox.Show("Bitte geben Sie ein gültiges Datum im Format dd.mm.yyyy ein (z.B. 31.12.2000). Das Datum darf nicht in der Zukunft liegen.", "Ungültiges Datum", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox.Focus();
                    textBox.SelectAll();
                }
            }
        }

        private bool IsValidDate(string date)
        {
            // Regex für das Datum im Format dd.mm.yyyy
            string pattern = @"^(0[1-9]|[12][0-9]|3[01])\.(0[1-9]|1[0-2])\.(19[0-9]{2}|20[0-4][0-9]|2050)$";
            if (Regex.IsMatch(date, pattern))
            {
                // Überprüfen, ob das Datum gültig ist und nicht in der Zukunft liegt
                try
                {
                    DateTime parsedDate = DateTime.ParseExact(date, "dd.mm.yyyy", CultureInfo.InvariantCulture);
                    if (parsedDate <= DateTime.Now)
                    {
                        return true;
                    }
                }
                catch (FormatException)
                {
                    return false;
                }
            }
            return false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(mtxtBirthdate.Text) || string.IsNullOrWhiteSpace(mtxtDeathdate.Text) || string.IsNullOrWhiteSpace(txtInformation.Text))
            {
                MessageBox.Show("Bitte füllen Sie alle Felder aus", "Speichern fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidDate(mtxtBirthdate.Text) || !IsValidDate(mtxtDeathdate.Text))
            {
                MessageBox.Show("Bitte geben Sie gültige Daten im Format dd.mm.yyyy ein. Die Daten dürfen nicht in der Zukunft liegen.", "Speichern fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Database.OpenConnection();

                // SQL-Insert-Befehl, um neuen Verstorbenen hinzuzufügen
                string register = "INSERT INTO [tbl_tombstones] ([name], [birthdate], [deathdate], [information]) VALUES (?, ?, ?, ?)";
                using (OleDbCommand cmd = new OleDbCommand(register, Database.Connection))
                {
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@birthdate", mtxtBirthdate.Text);
                    cmd.Parameters.AddWithValue("@deathdate", mtxtDeathdate.Text);
                    cmd.Parameters.AddWithValue("@information", txtInformation.Text);
                    cmd.ExecuteNonQuery();
                    Database.CloseConnection();
                }

                // Zurücksetzen der Eingabefelder
                txtName.Text = "";
                mtxtBirthdate.Text = "";
                mtxtDeathdate.Text = "";
                txtInformation.Text = "";

                MessageBox.Show("Daten erfolgreich gespeichert", "Speichern erfolgreich", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler: " + ex.Message, "Speichern fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Database.CloseConnection();
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