using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L_R_Screen
{
    public partial class frmMainPage : Form
    {
        string datenbankName = "db_users";
        private List<DeceasedPerson> deceasedPersons;
        public frmMainPage()
        {
            InitializeComponent();
            LoadDeceasedPersons();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            frmLogin loginForm = new frmLogin();
            loginForm.Show();
            this.Close();
        }

        private void bEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoadDeceasedPersons()
        {
            deceasedPersons = new List<DeceasedPerson>();

            string query = "SELECT name, birthdate, deathdate, info FROM tbl_graves";

            try
            {
                Database.OpenConnection(datenbankName);

                using (OleDbCommand cmd = new OleDbCommand(query, Database.GetConnection(datenbankName)))
                {
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string name = reader["name"].ToString();
                            string furtherInformation = reader["info"].ToString();
                            string birthdate = reader["birthdate"].ToString();
                            string deathdate = reader["deathdate"].ToString();

                            DeceasedPerson person = new DeceasedPerson(name, furtherInformation, birthdate, deathdate);
                            deceasedPersons.Add(person);
                        }
                        MessageBox.Show(deceasedPersons[0].name + "");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Laden der Daten: " + ex.Message);
            }
            finally
            {
                Database.CloseConnection("db_graves");
            }
        }



    }
}
