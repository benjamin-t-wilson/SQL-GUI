using Npgsql;
using SQL_GUI.DTOs;
using System;
using System.Collections.Generic;

namespace SQL_GUI.Functions
{
    public class SqlFunctions

    {
        public bool RequiresQuotes(string value)
        {
            switch (value.ToUpper())
            {

                case "CHARACTER":
                case "VARCHAR":
                case "TEXT":
                case "DATETIME":
                case "DATE":
                case "TIMESTAMP":
                    return true;

                default:
                    return false;
            }


        }
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
                    cmd.CommandText += $", {column.ColumnName} {column.Value}";
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
                    cmd.CommandText += $" ADD COLUMN {column.ColumnName} {column.Value},";
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

        public bool RenameColumn(string tableName, string columnName, string newColumnName, ConnectionDto connDto)
        {
            try
            {
                using var con = new NpgsqlConnection(ConnectionString(connDto));
                con.Open();

                using var cmd = new NpgsqlCommand();
                cmd.Connection = con;

                cmd.CommandText = $"ALTER TABLE IF EXISTS {tableName} RENAME {columnName} TO {newColumnName}";

                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool RenameTable(string tableName, string newTableName, ConnectionDto connDto)
        {
            try
            {
                using var con = new NpgsqlConnection(ConnectionString(connDto));
                con.Open();

                using var cmd = new NpgsqlCommand();
                cmd.Connection = con;

                cmd.CommandText = $"ALTER TABLE IF EXISTS {tableName} RENAME TO {newTableName}";

                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool DeleteRowFromTable(string tableName, ColumnDto column, string operatorSymbol, string value, ConnectionDto connDto)
        {
            try
            {

                using var con = new NpgsqlConnection(ConnectionString(connDto));
                con.Open();

                using var cmd = new NpgsqlCommand();
                cmd.Connection = con;

                cmd.CommandText = $"DELETE FROM {tableName} WHERE {column.ColumnName} {operatorSymbol} ";

                if (RequiresQuotes(column.Value))
                {
                    cmd.CommandText += $"'{value}'";
                }
                else
                {
                    cmd.CommandText += $"{value}";
                }


                cmd.ExecuteNonQuery();

                return true;
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public bool UpdateRowFromTable(string tableName,  List<ColumnDto> columns, List<string> values, string whereColumnName, string operatorSymbol, string operatorValue, ConnectionDto connDto)
        {
            try
            {
                using var con = new NpgsqlConnection(ConnectionString(connDto));
                con.Open();

                using var cmd = new NpgsqlCommand();
                cmd.Connection = con;

                cmd.CommandText = $"UPDATE {tableName} SET";

                for (int i = 1; i < columns.Count; i++)
                {
                    cmd.CommandText += $" {columns[i].ColumnName} = ";

                    if (RequiresQuotes(columns[i].Value))
                    {
                        cmd.CommandText += $"'{values[i]}'";
                    }
                    else
                    {
                        cmd.CommandText += $"{values[i]}";
                    }
                    cmd.CommandText += ",";
                }

                cmd.CommandText = cmd.CommandText.TrimEnd(',');

                cmd.CommandText += $" WHERE {whereColumnName} {operatorSymbol} ";

                if (RequiresQuotes(operatorValue))
                {
                    cmd.CommandText += $"'{operatorValue}'";
                }
                else
                {
                    cmd.CommandText += $"{operatorValue}";
                }

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

                    if(RequiresQuotes(tableDto.Columns[i + 1].Value))
                    {
                        cmd.CommandText += $"'{tableDto.Rows[i]}'";
                    } 
                    else
                    {
                        cmd.CommandText += tableDto.Rows[i];
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
                        Value = rdr.GetString(1)
                    });
                }

                return columns;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<ColumnDto> GetRows(FormSelectDto dto, ConnectionDto connDto)
        {
            try
            {
                using var con = new NpgsqlConnection(ConnectionString(connDto));
                con.Open();

                using var cmd = new NpgsqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "SELECT";

                foreach (var col in dto.Columns)
                {
                    cmd.CommandText += $" {col},";
                }

                cmd.CommandText = cmd.CommandText.TrimEnd(',');

                cmd.CommandText += $" FROM {dto.TableName}";

                if (dto.Where)
                {
                    cmd.CommandText += $" WHERE {dto.WhereColumn} {dto.WhereOperator}";

                    if (bool.TryParse(dto.WhereValue, out var boolWhere) || decimal.TryParse(dto.WhereValue, out var numWhere) || DateTime.TryParse(dto.WhereValue, out var dateWhere) || TimeSpan.TryParse(dto.WhereValue, out var timeWhere))
                    {
                        cmd.CommandText += $" {dto.WhereValue}";
                    }
                    else
                    {
                        cmd.CommandText += $" '{dto.WhereValue}'";
                    }
                }

                cmd.CommandText += ";";

                using NpgsqlDataReader rdr = cmd.ExecuteReader();

                var columns = new List<ColumnDto>();

                while (rdr.Read())
                {
                    for (int i = 0; i < dto.Columns.Count; i++)
                    {
                        columns.Add(new ColumnDto()
                        {
                            ColumnName = dto.Columns[i],
                            Value = rdr.GetValue(i).ToString()
                        });
                    }
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