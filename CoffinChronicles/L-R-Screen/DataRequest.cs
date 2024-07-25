using System;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace L_R_Screen
{
    public partial class DataRequest : Form
    {
        private string username;
        private Label LblUsername;

        public DataRequest(string username)
        {
            InitializeComponent();
            this.username = username;
            DisplayUsername();
            InitializeNameValidation();
        }

        // Verbindungsobjekt zur Datenbank
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=DatabaseCC.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void DisplayUsername()
        {
            LblUsername = new Label
            {
                Text = $"User: {username}",
                Location = new Point(10, 10),
                AutoSize = true,
                BackColor = Color.Gainsboro,
                Font = new Font(FontFamily.GenericSansSerif, 8f, FontStyle.Regular)
            };
            this.Controls.Add(LblUsername);
            PnlTop.Controls.Add(LblUsername);
        }

        private void InitializeNameValidation()
        {
            TxtName.MaxLength = 45;
        }

        private static bool IsValidDate(string date1, string date2)
        {
            // Regex für das Datum im Format dd.mm.yyyy
            string pattern = @"^(0[1-9]|[12][0-9]|3[01])\.(0[1-9]|1[0-2])\.(19[0-9]{2}|20[0-4][0-9]|2050)$";
            if (Regex.IsMatch(date1, pattern) && Regex.IsMatch(date2, pattern))
            {
                // Überprüfen, ob das Datum gültig ist und nicht in der Zukunft liegt
                if (DateTime.TryParseExact(date1, "dd.mm.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDate1) && DateTime.TryParseExact(date2, "dd.mm.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDate2))
                {
                    if (parsedDate1 <= DateTime.Now && parsedDate2 <= DateTime.Now && parsedDate1 < parsedDate2)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtName.Text) || string.IsNullOrWhiteSpace(MtxtBirthdate.Text) || string.IsNullOrWhiteSpace(MtxtDeathdate.Text) || string.IsNullOrWhiteSpace(TxtInformation.Text))
            {
                MessageBox.Show("Bitte füllen Sie alle Felder aus", "Speichern fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!IsValidDate(MtxtBirthdate.Text, MtxtDeathdate.Text))
            {
                MessageBox.Show("Bitte geben Sie gültige Daten im Format dd.mm.yyyy ein. Die Daten dürfen nicht in der Zukunft liegen und das Sterbedatum darf nicht vor dem Geburtsdatum liegen.", "Speichern fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    con.Open();

                    // SQL-Insert-Befehl, um neuen Verstorbenen hinzuzufügen
                    string register = "INSERT INTO [TblDeceased] ([name], [birthdate], [deathdate], [information]) VALUES (?, ?, ?, ?)";
                    cmd = new OleDbCommand(register, con);
                    cmd.Parameters.AddWithValue("@name", TxtName.Text);
                    cmd.Parameters.AddWithValue("@birthdate", MtxtBirthdate.Text);
                    cmd.Parameters.AddWithValue("@deathdate", MtxtDeathdate.Text);
                    cmd.Parameters.AddWithValue("@information", TxtInformation.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    // Zurücksetzen der Eingabefelder
                    TxtName.Text = "";
                    MtxtBirthdate.Text = "";
                    MtxtDeathdate.Text = "";
                    TxtInformation.Text = "";

                    MessageBox.Show("Daten erfolgreich gespeichert", "Speichern erfolgreich", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Weiterleiten zur Graveyard-Seite
                    Graveyard graveyard = new Graveyard(username);
                    graveyard.Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fehler: " + ex.Message, "Speichern fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                }
            }

        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Close();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            WelcomePage welcomePage = new WelcomePage(username);
            welcomePage.Show();
            this.Close();
        }

        private void BtnData_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void BtnGrave_Click(object sender, EventArgs e)
        {
            Graveyard graveyard = new Graveyard(username);
            graveyard.Show();
            this.Close();
        }
    }
}