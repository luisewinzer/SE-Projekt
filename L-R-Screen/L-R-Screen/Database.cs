using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace L_R_Screen
{
    public static class Database
    {
        private static OleDbConnection connection;
        public static OleDbConnection Connection 
        {
            get
            {
                if (connection == null)
                {
                    string databasePath = ExtractDatabaseFile("L_R_Screen.db_users.mdb");
                    string connectionString = $@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={databasePath}";
                    connection = new OleDbConnection(connectionString);
                }
                return connection;
            }
        }

        private static string ExtractDatabaseFile(string resourceName)
        {
            string outputPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "db_users.mdb");

            if (!File.Exists(outputPath))
            {
                using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName))
                {
                    if (stream == null)
                    {
                        throw new Exception($"Resource '{resourceName}' not found.");
                    }

                    using (FileStream fileStream = new FileStream(outputPath, FileMode.Create, FileAccess.Write))
                    {
                        stream.CopyTo(fileStream);
                    }
                }
            }

            return outputPath;
        }

        public static void OpenConnection()
        {
            if (Connection != null && Connection.State == ConnectionState.Closed)
            {
                Connection.Open();
            }
        }

        public static void CloseConnection()
        {
            if (Connection != null && Connection.State == ConnectionState.Open)
            {
                Connection.Close();
            }
        }
    }
}
