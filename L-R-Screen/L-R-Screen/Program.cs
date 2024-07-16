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
                Database.OpenConnection();

                // Beispiel für eine Datenbankoperation fürs Debuggen
                string query = "SELECT COUNT(*) FROM tbl_users";
                using (OleDbCommand cmd = new OleDbCommand(query, Database.Connection))
                {
                    int userCount = (int)cmd.ExecuteScalar();
                    MessageBox.Show("Anzahl der Benutzer: " + userCount);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler bei der Datenbankverbindung: " + ex.Message);
            }
            finally
            {
                Database.CloseConnection();
            }
            Application.Run(new frmLogin());
                       
        }
    }
}
