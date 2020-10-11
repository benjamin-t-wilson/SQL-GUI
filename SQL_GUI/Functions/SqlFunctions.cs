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
            con.Close();

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
                con.Close();
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
                con.Close();

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
                con.Close();

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
                con.Close();

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
                con.Close();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int DeleteRowFromTable(string tableName, ColumnDto column, string operatorSymbol, string value, ConnectionDto connDto)
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

                NpgsqlDataReader dr = cmd.ExecuteReader();

                con.Close();

                return dr.RecordsAffected;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int UpdateRowFromTable(FormUpdateDto dto, ConnectionDto connDto)
        {
            try
            {
                using var con = new NpgsqlConnection(ConnectionString(connDto));
                con.Open();

                using var cmd = new NpgsqlCommand();
                cmd.Connection = con;

                cmd.CommandText = $"UPDATE {dto.TableName} SET";

                for (int i = 0; i < dto.Columns.Count; i++)
                {
                    cmd.CommandText += $" {dto.Columns[i].ColumnName} = ";

                    if (RequiresQuotes(dto.Columns[i].Value))
                    {
                        cmd.CommandText += $"'{dto.Values[i]}'";
                    }
                    else
                    {
                        cmd.CommandText += $"{dto.Values[i]}";
                    }
                    cmd.CommandText += ",";
                }

                cmd.CommandText = cmd.CommandText.TrimEnd(',');

                cmd.CommandText += $" WHERE {dto.WhereColumn.ColumnName} {dto.WhereOperator} ";

                if (RequiresQuotes(dto.WhereColumn.Value))
                {
                    cmd.CommandText += $"'{dto.WhereValue}'";
                }
                else
                {
                    cmd.CommandText += $"{dto.WhereValue}";
                }

                NpgsqlDataReader dr = cmd.ExecuteReader();

                con.Close();

                return dr.RecordsAffected;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int AddRowToTable(AddNewRowDto tableDto, ConnectionDto connDto)
        {
            try
            {
                using var con = new NpgsqlConnection(ConnectionString(connDto));
                con.Open();

                using var cmd = new NpgsqlCommand();
                cmd.Connection = con;

                cmd.CommandText = $"INSERT INTO {tableDto.TableName} (";

                for (int i = 1; i < tableDto.Columns.Count; i++)
                {
                    cmd.CommandText += tableDto.Columns[i].ColumnName.ToString();
                    cmd.CommandText += ",";
                }

                cmd.CommandText = cmd.CommandText.TrimEnd(',');

                cmd.CommandText += ") VALUES (";

                for (int i = 0; i < tableDto.Rows.Count; i++)
                {
                    if (RequiresQuotes(tableDto.Columns[i + 1].Value))
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

                cmd.CommandText += ") RETURNING ID";

                NpgsqlDataReader dr = cmd.ExecuteReader();

                int id = 0;

                while (dr.Read())
                {
                    id = dr.GetInt32(0);
                }
                con.Close();

                return id;
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
                con.Close();

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
                con.Close();

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
                    cmd.CommandText += $" {col.ColumnName},";
                }

                cmd.CommandText = cmd.CommandText.TrimEnd(',');

                cmd.CommandText += $" FROM {dto.TableName}";

                if (dto.Where)
                {
                    cmd.CommandText += $" WHERE {dto.WhereColumn.ColumnName} {dto.WhereOperator}";

                    if (RequiresQuotes(dto.WhereColumn.Value))
                    {
                        cmd.CommandText += $" '{dto.WhereValue}'";
                    }
                    else
                    {
                        cmd.CommandText += $" {dto.WhereValue}";
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
                            ColumnName = dto.Columns[i].ColumnName,
                            Value = rdr.GetValue(i).ToString()
                        });
                    }
                }
                con.Close();

                return columns;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void AddColumnConstraint(AddColumnConstraintDto dto, ConnectionDto connDto)
        {
            try
            {
                using var con = new NpgsqlConnection(ConnectionString(connDto));
                con.Open();

                using var cmd = new NpgsqlCommand();
                cmd.Connection = con;
                cmd.CommandText = string.Empty;

                string alterTable = $"ALTER TABLE {dto.TableName} ";

                if (dto.Unique)
                {
                    cmd.CommandText += alterTable + $"ADD UNIQUE ({dto.ColumnName});";
                }

                if (dto.NotNull)
                {
                    cmd.CommandText += alterTable + $"ALTER COLUMN {dto.ColumnName} SET NOT NULL;";
                }

                if (dto.References)
                {
                    cmd.CommandText += alterTable + $"ADD FOREIGN KEY ({dto.ColumnName}) REFERENCES {dto.ReferencesTableName}({dto.ReferencesColumnName}) ON UPDATE CASCADE ON DELETE CASCADE";
                }

                if (dto.Check)
                {
                    cmd.CommandText += alterTable + $"ADD CONSTRAINT {dto.CheckName} CHECK ({dto.CheckColumn} {dto.CheckOperator} {dto.CheckValue});";
                }

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DropColumnFromTable(string tableName, string columnName, ConnectionDto connDto)
        {
            try
            {
                using var con = new NpgsqlConnection(ConnectionString(connDto));
                con.Open();

                using var cmd = new NpgsqlCommand();
                cmd.Connection = con;

                cmd.CommandText = $"ALTER TABLE {tableName} DROP COLUMN {columnName} CASCADE;";

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<string> GetConstraints(string tableName, ConnectionDto connDto)
        {
            try
            {
                using var con = new NpgsqlConnection(ConnectionString(connDto));
                con.Open();

                using var cmd = new NpgsqlCommand();
                cmd.Connection = con;

                cmd.CommandText = $"SELECT c.conname AS constraint_name FROM pg_constraint c JOIN pg_class t ON c.conrelid = t.oid JOIN pg_namespace n ON t.relnamespace = n.oid WHERE t.relname = '{tableName}';";

                using NpgsqlDataReader rdr = cmd.ExecuteReader();

                var constraints = new List<string>();

                while (rdr.Read())
                {
                    constraints.Add(rdr.GetString(0));
                }
                con.Close();

                return constraints;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DropTableConstraint(string tableName, string constraintName, ConnectionDto connDto)
        {
            try
            {
                using var con = new NpgsqlConnection(ConnectionString(connDto));
                con.Open();

                using var cmd = new NpgsqlCommand();
                cmd.Connection = con;

                cmd.CommandText = $"ALTER TABLE {tableName} DROP CONSTRAINT {constraintName};";

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void ChangeColumnDataType(string tableName, string columnName, string dataType, ConnectionDto connDto)
        {
            try
            {
                using var con = new NpgsqlConnection(ConnectionString(connDto));
                con.Open();

                using var cmd = new NpgsqlCommand();
                cmd.Connection = con;

                cmd.CommandText = $"ALTER TABLE {tableName} ALTER COLUMN {columnName} SET DATA TYPE {dataType};";

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}