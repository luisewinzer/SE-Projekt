using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Reflection;
using System.Xml.Linq;

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
                string path = ExtractDatabaseFile($"L_R_Screen.db_users.mdb");
                string connectionString = $@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={path}";
                connection = new OleDbConnection(connectionString);
            }
            return connection;
        }
    }

    public static void OpenConnection()
    {
        if (Connection.State == ConnectionState.Closed)
        {
            Connection.Open();
        }
    }

    public static void CloseConnection()
    {
        if (Connection.State == ConnectionState.Open)
        {
            Connection.Close();
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


