using System;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace L_R_Screen
{
    public partial class Graveyard : Form
    {
        private InfoWindow infoWindow;
        private string username;
        private Label lblUsername;
        private ToolTip tombstoneToolTip = new ToolTip();

        public Graveyard(string username)
        {
            InitializeComponent();
            this.username = username;
            DisplayUsername();
            DisplayDeceasedPersonInfo(1); // Beispiel-ID 1
            InitializeTombstones();
        }

        // Verbindungsobjekt zur Datenbank
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

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
            lblUsername.BringToFront();
        }

        private void DisplayDeceasedPersonInfo(int id)
        {
            try
            {
                con.Open();
                string query = "SELECT name, birthdate, deathdate, information FROM tbl_tombstones WHERE id = ?";
                cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@id", id);
                OleDbDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    string name = dr["name"].ToString();
                    string birthdate = dr["birthdate"] != DBNull.Value ? Convert.ToDateTime(dr["birthdate"]).ToShortDateString() : "Unknown";
                    string deathdate = dr["deathdate"] != DBNull.Value ? Convert.ToDateTime(dr["deathdate"]).ToShortDateString() : "Unknown";
                    string information = dr["information"].ToString();

                    Label lblName = new Label
                    {
                        Text = $"{name}",
                        Location = new Point(155, 150),
                        AutoSize = true,
                        BackColor = Color.DarkGray,
                        Font = new Font(FontFamily.GenericSansSerif, 9f, FontStyle.Regular)
                    };
                    Label lblBirthdate = new Label
                    {
                        Text = $"* {birthdate}",
                        Location = new Point(155, 180),
                        AutoSize = true,
                        BackColor = Color.DarkGray,
                        Font = new Font(FontFamily.GenericSansSerif, 9f, FontStyle.Regular)
                    };
                    Label lblDeathdate = new Label
                    {
                        Text = $"† {deathdate}",
                        Location = new Point(155, 210),
                        AutoSize = true,
                        BackColor = Color.DarkGray,
                        Font = new Font(FontFamily.GenericSansSerif, 9f, FontStyle.Regular)
                    };

                    this.Controls.Add(lblName);
                    this.Controls.Add(lblBirthdate);
                    this.Controls.Add(lblDeathdate);
                    panelMiddle.Controls.Add(lblName);
                    panelMiddle.Controls.Add(lblBirthdate);
                    panelMiddle.Controls.Add(lblDeathdate);

                    lblName.BringToFront();
                    lblBirthdate.BringToFront();
                    lblDeathdate.BringToFront();

                    // Initialize the tooltip with information
                    tombstoneToolTip.SetToolTip(Tombstone1, information);
                }

                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler: " + ex.Message, "Datenbankfehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        private void InitializeTombstones()
        {
            Tombstone1.MouseHover += new EventHandler(Tombstone1_MouseHover);
            Tombstone1.MouseLeave += new EventHandler(Tombstone1_MouseLeave);
        }

        private void Tombstone1_MouseHover(object sender, EventArgs e)
        {
            // Show the information in a new form
            string info = tombstoneToolTip.GetToolTip(Tombstone1);
            if (infoWindow == null || infoWindow.IsDisposed)
            {
                infoWindow = new InfoWindow(info)
                {
                    StartPosition = FormStartPosition.Manual,
                    Location = this.PointToScreen(Tombstone1.Location) + new Size(0, Tombstone1.Height)
                };
                infoWindow.Show();
            }
        }

        private void Tombstone1_MouseLeave(object sender, EventArgs e)
        {
            if (infoWindow != null && !infoWindow.IsDisposed)
            {
                infoWindow.Close();
                infoWindow = null; // Clear the reference
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
    }
}


