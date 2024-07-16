using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L_R_Screen
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Öffnen der Datenbankverbindung
            try
            {
                //Datenbank für Login und Registieung
                Database.OpenConnection("db_users");
                //Datenbank für MainPage
                Database.OpenConnection("db_graves");

                // Beispiel für eine Datenbankoperation fürs Debugen für db_users
                string query1 = "SELECT COUNT(*) FROM tbl_users";
                using (OleDbCommand cmd1 = new OleDbCommand(query1, Database.GetConnection("db_users")))
                {
                    int userCount1 = (int)cmd1.ExecuteScalar();
                    MessageBox.Show("Anzahl der Benutzer in db_users: " + userCount1);
                }

                // Beispiel für eine Datenbankoperation für Debugen für db_graves
                string query2 = "SELECT COUNT(*) FROM tbl_graves";
                using (OleDbCommand cmd2 = new OleDbCommand(query2, Database.GetConnection("db_graves")))
                {
                    int userCount2 = (int)cmd2.ExecuteScalar();
                    MessageBox.Show("Anzahl der Benutzer in db_graves: " + userCount2);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler bei der Datenbankverbindung: " + ex.Message);
            }
            finally
            {
                Database.CloseConnection("db_users");
                Database.CloseConnection("db_graves");
            }

            Application.Run(new frmLogin());

        }
    }
}
