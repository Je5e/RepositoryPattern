using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Diagnostics;
using System.Text;

namespace DemoPatron.RepositoryDapper
{
    public class Factory: IDisposable
    {
        public IDbConnection  connection { get; }
        public Factory()
        {
            var Provider = new Helper("Provider").GetConnectionString();
            var connString = new Helper("ConnectionString").GetConnectionString();

            switch (Provider)
            {
                case "SQLSERVER":
                    connection = new SqlConnection();
                    break;
                case "POSTGRESQL":
                    connection = new NpgsqlConnection();
                    break;
                case "SQLITE":
                    connection = new SQLiteConnection();
                    break;
                case "MYSQL":
                    connection = new SQLiteConnection();
                    break;
                default:
                    break;
            }
            connection.ConnectionString = connString;
    }

    public void Dispose()
    {
            //Console.WriteLine("Dispose!!!");
        connection.Dispose(); // cn.Close();
    }
}
}
