using SQL_GUI.DTOs;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;

namespace SQL_GUI.Functions
{
    internal class SqliteConnStorage
    {
        private SQLiteConnection con;
        private SQLiteCommand cmd;
        private SQLiteDataReader dr;

        public void CreateDatabaseAndTable()
        {
            if (!File.Exists("connDb.sqlite"))
            {
                SQLiteConnection.CreateFile("connDb.sqlite");

                string sql = @"CREATE TABLE Connections(ID INTEGER PRIMARY KEY AUTOINCREMENT, Host TEXT NOT NULL, Username TEXT NOT NULL, Password TEXT NOT NULL, Port TEXT NOT NULL, Nickname TEXT NOT NULL, Database TEXT NOT NULL);";
                con = new SQLiteConnection("Data Source=connDb.sqlite;Version=3;");
                con.Open();
                cmd = new SQLiteCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            else
            {
                con = new SQLiteConnection("Data Source=connDb.sqlite;Version=3;");
            }
        }

        public void AddData(ConnectionDto dto)
        {
            con = new SQLiteConnection("Data Source=connDb.sqlite;Version=3;");
            cmd = new SQLiteCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = $"insert into Connections(Host, Username, Password, Port, Nickname, Database) values ('{dto.Host}', '{dto.Username}', '{dto.Password}', '{dto.Port}', '{dto.Nickname}', '{dto.Database}')";
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public List<string> GetNickNames()
        {
            con = new SQLiteConnection("Data Source=connDb.sqlite;Version=3;");
            cmd = new SQLiteCommand("Select Nickname From Connections", con);
            con.Open();
            dr = cmd.ExecuteReader();

            var nicknames = new List<string>();
            while (dr.Read())
            {
                nicknames.Add(dr.GetString(0));
            }
            con.Close();

            return nicknames;
        }

        public ConnectionDto GetConnectionInfo(string nickname)
        {
            con = new SQLiteConnection("Data Source=connDb.sqlite;Version=3;");
            cmd = new SQLiteCommand($"Select Host, Username, Password, Port, Nickname, Database From Connections Where Nickname = '{nickname}'", con);

            con.Open();
            dr = cmd.ExecuteReader();

            var conn = new ConnectionDto();

            while (dr.Read())
            {
                if (dr.FieldCount != 6)
                {
                    throw new Exception("Could not find connection info.");
                }

                conn.Host = dr.GetString(0);
                conn.Username = dr.GetString(1);
                conn.Password = dr.GetString(2);
                conn.Port = dr.GetString(3);
                conn.Nickname = dr.GetString(4);
                conn.Database = dr.GetString(5);
            }
            con.Close();

            return conn;
        }
    }
}