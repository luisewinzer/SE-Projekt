using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace L_R_Screen
{
    public partial class Graveyard : Form
    {
        private InfoWindow infoWindow;
        private string username;
        private Label LblUsername;
        private ToolTip tombstoneToolTip = new ToolTip();

        public Graveyard(string username)
        {
            InitializeComponent();
            this.username = username;
            DisplayUsername();
            DisplayDeceasedPersonInfo(1, Tombstone1);
            DisplayDeceasedPersonInfo(2, Tombstone2);
            DisplayDeceasedPersonInfo(3, Tombstone3); 
            InitializeTombstones();
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
            LblUsername.BringToFront();
        }

        private void DisplayDeceasedPersonInfo(int id, PictureBox tombstone)
        {
            try
            {
                con.Open();
                string query = "SELECT name, birthdate, deathdate, information FROM TblDeceased WHERE id = ?";
                cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@id", id);
                OleDbDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    string name = dr["name"].ToString();
                    string birthdate = dr["birthdate"] != DBNull.Value ? Convert.ToDateTime(dr["birthdate"]).ToShortDateString() : "Unknown";
                    string deathdate = dr["deathdate"] != DBNull.Value ? Convert.ToDateTime(dr["deathdate"]).ToShortDateString() : "Unknown";
                    string information = dr["information"].ToString();

                    if (!string.IsNullOrWhiteSpace(information))
                    {
                        Label LblName = new Label
                        {
                            Text = InsertLineBreaks($"{name}", 12),
                            Location = new Point(tombstone.Location.X + 23, tombstone.Location.Y + 35),
                            AutoSize = true,
                            BackColor = Color.DarkGray,
                            Font = new Font(FontFamily.GenericSansSerif, 9f, FontStyle.Regular)
                        };
                        Label LblBirthdate = new Label
                        {
                            Text = $"* {birthdate}",
                            Location = new Point(tombstone.Location.X + 23, tombstone.Location.Y + 65),
                            AutoSize = true,
                            BackColor = Color.DarkGray,
                            Font = new Font(FontFamily.GenericSansSerif, 9f, FontStyle.Regular)
                        };
                        Label LblDeathdate = new Label
                        {
                            Text = $"† {deathdate}",
                            Location = new Point(tombstone.Location.X + 23, tombstone.Location.Y + 95),
                            AutoSize = true,
                            BackColor = Color.DarkGray,
                            Font = new Font(FontFamily.GenericSansSerif, 9f, FontStyle.Regular)
                        };

                        this.Controls.Add(LblName);
                        this.Controls.Add(LblBirthdate);
                        this.Controls.Add(LblDeathdate);
                        PnlMiddle.Controls.Add(LblName);
                        PnlMiddle.Controls.Add(LblBirthdate);
                        PnlMiddle.Controls.Add(LblDeathdate);

                        // Verschiebt automatisch die Labels LblBirthdate und LblDeathdate unter LblName
                        LblBirthdate.Location = new Point(LblName.Location.X, LblName.Location.Y + LblName.Height + 10);
                        LblDeathdate.Location = new Point(LblBirthdate.Location.X, LblBirthdate.Location.Y + LblBirthdate.Height + 10);

                        LblName.BringToFront();
                        LblBirthdate.BringToFront();
                        LblDeathdate.BringToFront();

                        tombstoneToolTip.SetToolTip(tombstone, information);
                    }
                    else
                    {
                        tombstoneToolTip.SetToolTip(tombstone, string.Empty);
                    }
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

        // Fügt automatisch einen Umbruch ein, wenn eine maximale Länge an Zeichen erreicht wurde
        public string InsertLineBreaks(string text, int maxLineLength)
        {
            if (string.IsNullOrEmpty(text) || maxLineLength <= 0)
                return text;
            var lines = new List<string>();
            for (int i = 0; i < text.Length; i += maxLineLength)
            {
                if (i + maxLineLength > text.Length)
                    lines.Add(text.Substring(i));
                else
                    lines.Add(text.Substring(i, maxLineLength));
            }
            return string.Join("\n", lines);
        }

        private void InitializeTombstones()
        {
            Tombstone1.MouseHover += new EventHandler(Tombstone_MouseHover);
            Tombstone1.MouseLeave += new EventHandler(Tombstone_MouseLeave);

            Tombstone2.MouseHover += new EventHandler(Tombstone_MouseHover);
            Tombstone2.MouseLeave += new EventHandler(Tombstone_MouseLeave);

            Tombstone3.MouseHover += new EventHandler(Tombstone_MouseHover);
            Tombstone3.MouseLeave += new EventHandler(Tombstone_MouseLeave);
        }

        private void Tombstone_MouseHover(object sender, EventArgs e)
        {
            PictureBox tombstone = sender as PictureBox;
            if (tombstone != null)
            {
                // Information in einem neuen Form anzeigen
                string info = tombstoneToolTip.GetToolTip(tombstone);
                if (!string.IsNullOrWhiteSpace(info))
                {
                    if (infoWindow == null || infoWindow.IsDisposed)
                    {
                        infoWindow = new InfoWindow(info)
                        {
                            StartPosition = FormStartPosition.Manual,
                            Location = this.PointToScreen(tombstone.Location) + new Size(0, tombstone.Height)
                        };
                        infoWindow.Show();
                    }
                }
            }
        }

        private void Tombstone_MouseLeave(object sender, EventArgs e)
        {
            if (infoWindow != null && !infoWindow.IsDisposed)
            {
                infoWindow.Close();
                infoWindow = null;
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
            DataRequest dataRequest = new DataRequest(username);
            dataRequest.Show();
        }

        private void BtnGrave_Click(object sender, EventArgs e)
        {
            this.Show();
        }
    }
}