using Npgsql;
using SQL_GUI.DTOs;
using System;
using System.Collections.Generic;

namespace SQL_GUI.Functions
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

            var sql = "SELECT VERSION()";

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
            catch (Exception ex)
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

        public bool AddColumnToTable(AddNewTableDto tableDto, ConnectionDto connDto)
        {
            try
            {
                using var con = new NpgsqlConnection(ConnectionString(connDto));
                con.Open();

                using var cmd = new NpgsqlCommand();
                cmd.Connection = con;

                cmd.CommandText = $"ALTER TABLE IF EXISTS {tableDto.TableName}";

                foreach (var column in tableDto.Columns)
                {
                    cmd.CommandText += $" ADD COLUMN {column.ColumnName} {column.ValueType},";
                }

                cmd.CommandText = cmd.CommandText.TrimEnd(',');

                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool AddRowToTable(AddNewRowDto tableDto, ConnectionDto connDto)
        {
            try
            {
                using var con = new NpgsqlConnection(ConnectionString(connDto));
                con.Open();

                using var cmd = new NpgsqlCommand();
                cmd.Connection = con;

                cmd.CommandText = $"INSERT INTO {tableDto.TableName} (";
                //for loop to index list of columns and row values
                // switch statement on col.valueType
                for (int i = 1; i < tableDto.Columns.Count; i++)
                {
                    cmd.CommandText += tableDto.Columns[i].ColumnName.ToString();
                    cmd.CommandText += ",";
                }

                cmd.CommandText = cmd.CommandText.TrimEnd(',');

                cmd.CommandText += ") VALUES (";

                for (int i = 0; i < tableDto.Rows.Count; i++)
                {

                    switch (tableDto.Columns[i].ValueType)
                    {
                        case "CHAR":
                        case "VARCHAR":
                        case "TEXT":
                        case "DATETIME":
                        case "DATE":
                        case "TIMESTAMP":
                            cmd.CommandText += $"'tableDto.Rows[i]'";
                            break;

                        default:
                            cmd.CommandText += tableDto.Rows[i];
                            break;
                    }

                    cmd.CommandText += ",";

                }
                    cmd.CommandText = cmd.CommandText.TrimEnd(',');

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

                cmd.CommandText = $"SELECT TABLE_NAME FROM {connDto.Database}.information_schema.tables WHERE table_type = 'BASE TABLE'";

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

        public List<ColumnDto> GetColumnList(string tableName, ConnectionDto connDto)
        {
            try
            {
                using var con = new NpgsqlConnection(ConnectionString(connDto));
                con.Open();

                using var cmd = new NpgsqlCommand();
                cmd.Connection = con;

                cmd.CommandText = $"SELECT column_name, data_type FROM information_schema.columns WHERE table_name = '{tableName}'";

                using NpgsqlDataReader rdr = cmd.ExecuteReader();

                var columns = new List<ColumnDto>();

                while (rdr.Read())
                {
                    columns.Add(new ColumnDto()
                    {
                        ColumnName = rdr.GetString(0),
                        ValueType = rdr.GetString(1)
                    });
                }

                return columns;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}