using Npgsql;
using SQL_GUI.DTOs;
using System;
using System.Collections.Generic;

namespace SQL_GUI
{
    public class SqlFunctions
    {
        private string ConnectionString(ConnectionDto connDto)
        {
            return $"Host={connDto.Host};Username={connDto.Username};Password={connDto.Password};Database={connDto.Database};Port={connDto.Port};SSL Mode=Prefer;Trust Server Certificate=true";
        }

        public string CheckDatabaseVersion(ConnectionDto connDto)
        {
            using var con = new NpgsqlConnection(ConnectionString(connDto));
            con.Open();

            var sql = "SELECT version()";

            using var cmd = new NpgsqlCommand(sql, con);

            var version = cmd.ExecuteScalar().ToString();

            return version;
        }

        public void DropTableIfExists(string tableName, ConnectionDto connDto)
        {
            try
            {
                using var con = new NpgsqlConnection(ConnectionString(connDto));
                con.Open();

                using var cmd = new NpgsqlCommand();
                cmd.Connection = con;

                cmd.CommandText = $"DROP TABLE IF EXISTS {tableName}";
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool CreateDatabaseTable(AddNewTableDto tableDto, ConnectionDto connDto)
        {
            try
            {
                using var con = new NpgsqlConnection(ConnectionString(connDto));
                con.Open();

                using var cmd = new NpgsqlCommand();
                cmd.Connection = con;

                cmd.CommandText = $"DROP TABLE IF EXISTS {tableDto.TableName}";
                cmd.ExecuteNonQuery();

                cmd.CommandText = $@"CREATE TABLE {tableDto.TableName}(id SERIAL PRIMARY KEY";

                foreach (var column in tableDto.Columns)
                {
                    cmd.CommandText += $", {column.ColumnName} {column.ValueType}";
                }

                cmd.CommandText += ")";

                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<string> GetListOfTables(ConnectionDto connDto)
        {
            try
            {
                using var con = new NpgsqlConnection(ConnectionString(connDto));
                con.Open();

                using var cmd = new NpgsqlCommand();
                cmd.Connection = con;

                cmd.CommandText = $"select TABLE_NAME from {connDto.Database}.information_schema.tables where table_type = 'BASE TABLE'";

                using NpgsqlDataReader rdr = cmd.ExecuteReader();

                var tableNames = new List<string>();

                while (rdr.Read())
                {
                    tableNames.Add(rdr.GetString(0));
                }

                return tableNames;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}