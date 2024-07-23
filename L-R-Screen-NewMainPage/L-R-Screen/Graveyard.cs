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
        private Label lblUsername;
        private ToolTip tombstoneToolTip = new ToolTip();

        public Graveyard(string username)
        {
            InitializeComponent();
            this.username = username;
            DisplayUsername();
            
            DisplayDeceasedPersonInfo(1, Tombstone1); // Beispiel-ID 1
            DisplayDeceasedPersonInfo(2, Tombstone2); // Beispiel-ID 2
            DisplayDeceasedPersonInfo(3, Tombstone3); // Beispiel-ID 3
            InitializeTombstones();
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
            lblUsername.BringToFront();
        }

        private void DisplayDeceasedPersonInfo(int id, PictureBox tombstone)
        {
            try
            {
                Database.OpenConnection();
                string query = "SELECT name, birthdate, deathdate, information FROM tbl_tombstones WHERE id = ?";
                using (OleDbCommand cmd = new OleDbCommand(query, Database.Connection))
                {
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
                                Label lblName = new Label
                                {
                                    Text = InsertLineBreaks($"{name}",20),
                                    Location = new Point(tombstone.Location.X + 23, tombstone.Location.Y + 35),
                                    AutoSize = true,
                                    BackColor = Color.DarkGray,
                                    Font = new Font(FontFamily.GenericSansSerif, 9f, FontStyle.Regular)
                                };
                                Label lblBirthdate = new Label
                                {
                                    Text = $"* {birthdate}",
                                    //Location = new Point(tombstone.Location.X + 23, tombstone.Location.Y + 65),
                                    AutoSize = true,
                                    BackColor = Color.DarkGray,
                                    Font = new Font(FontFamily.GenericSansSerif, 9f, FontStyle.Regular)
                                };
                                Label lblDeathdate = new Label
                                {
                                    Text = $"† {deathdate}",
                                    //Location = new Point(tombstone.Location.X + 23, tombstone.Location.Y + 95),
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

                                lblBirthdate.Location = new Point(lblName.Location.X, lblName.Location.Y + lblName.Height + 10);
                                lblDeathdate.Location = new Point(lblBirthdate.Location.X, lblBirthdate.Location.Y + lblBirthdate.Height + 10);

                            lblName.BringToFront();
                                lblBirthdate.BringToFront();
                                lblDeathdate.BringToFront();

                                // Initialize the tooltip with information
                                tombstoneToolTip.SetToolTip(tombstone, information);
                            }
                            else
                            {
                                // Clear the tooltip if no information is present
                                tombstoneToolTip.SetToolTip(tombstone, string.Empty);
                            }
                        }

                    

                    dr.Close();
                    Database.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler: " + ex.Message, "Datenbankfehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Database.CloseConnection();
            }
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
                // Show the information in a new form
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

        private void btnHome_Click(object sender, EventArgs e)
        {
            WelcomePage welcomePage = new WelcomePage(username);
            welcomePage.Show();
            this.Close();
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            frmMainPage mainPage = new frmMainPage(username);
            mainPage.Show();
            this.Close();
        }

        private void btnGrave_Click(object sender, EventArgs e)
        {
            this.Show();
        }

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


    }
}
