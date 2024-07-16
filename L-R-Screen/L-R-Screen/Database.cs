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
        private static Dictionary<string, OleDbConnection> connections = new Dictionary<string, OleDbConnection>();

        public static void OpenConnection(string dbName)
        {
            if (!connections.ContainsKey(dbName))
            {
                string databasePath = ExtractDatabaseFile($"L_R_Screen.{dbName}.mdb");
                string connectionString = $@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={databasePath}";
                OleDbConnection connection = new OleDbConnection(connectionString);
                connection.Open();
                connections[dbName] = connection;
            }
            else if (connections[dbName].State == ConnectionState.Closed)
            {
                connections[dbName].Open();
            }
        }

        public static void CloseConnection(string dbName)
        {
            if (connections.ContainsKey(dbName) && connections[dbName].State == ConnectionState.Open)
            {
                connections[dbName].Close();
            }
        }

        public static OleDbConnection GetConnection(string dbName)
        {
            if (connections.ContainsKey(dbName))
            {
                return connections[dbName];
            }
            else
            {
                throw new InvalidOperationException($"Keine geöffnete Verbindung für '{dbName}' gefunden.");
            }
        }

        private static string ExtractDatabaseFile(string resourceName)
        {
            string outputPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, resourceName.Split('.')[1]);

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
    }
}
