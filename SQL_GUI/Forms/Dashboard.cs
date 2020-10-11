﻿using SQL_GUI.DTOs;
using SQL_GUI.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SQL_GUI.Forms
{
    public partial class Dashboard : Form
    {
        private ConnectionDto connDto = new ConnectionDto();
        private SqlFunctions _sql = new SqlFunctions();
        private ConnectionBox _connBox = null;

        public Dashboard(ConnectionDto _connDto, ConnectionBox connBox)
        {
            InitializeComponent();
            connDto = _connDto;
            _connBox = connBox;

            resetControlDisplay();

            try
            {
                var version = _sql.CheckDatabaseVersion(connDto);

                WriteToLog("Successfully connected to database");
                WriteToLog(version);

                resetTableList();
            }
            catch (Exception ex)
            {
                WriteToLog("Error connecting to database:");
                WriteToLog(ex.Message);
            }
        }

        private void resetTableList()
        {
            var tablesList = _sql.GetListOfTables(connDto);
            WriteToLog("Reset tables list...");

            dash_tables_listBox.Items.Clear();
            columns_addConstraint_references_table_comboBox.Items.Clear();

            foreach (var tableName in tablesList)
            {
                dash_tables_listBox.Items.Add(tableName);
                columns_addConstraint_references_table_comboBox.Items.Add(tableName);
            }
        }

        private void resetControlDisplay()
        {
            foreach (Control ctrl in Controls.OfType<Panel>())
            {
                ctrl.Hide();
            }
        }

        private void WriteToLog(string text)
        {
            var rtb = dash_log_richTextBox;

            if (rtb.Lines.Length > 1000)
            {
                rtb.Select(0, rtb.GetFirstCharIndexFromLine(rtb.Lines.Length - 1000));
                rtb.SelectedText = "";
            }

            rtb.AppendText($"{text}\r");
        }

        private void tables_add_addColumnNames_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tables_add_columnNames_textBox.Text))
            {
                WriteToLog("You must type a value.");
                return;
            }
            tables_add_columnNames_listBox.Items.Add(tables_add_columnNames_textBox.Text);
            tables_add_columnNames_textBox.Text = string.Empty;
        }

        private void tables_add_removeColumnNames_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tables_add_columnNames_listBox.SelectedItem?.ToString()))
            {
                WriteToLog("You must select an item.");
                return;
            }
            tables_add_columnNames_listBox.Items.RemoveAt(tables_add_columnNames_listBox.SelectedIndex);
        }

        private void tables_add_addValueType_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tables_add_addValueType_comboBox.SelectedItem?.ToString()))
            {
                WriteToLog("You must select an item.");
                return;
            }
            tables_add_valueTypes_listBox.Items.Add(tables_add_addValueType_comboBox.SelectedItem?.ToString());
        }

        private void tables_add_removeValueType_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tables_add_valueTypes_listBox.SelectedItem?.ToString()))
            {
                WriteToLog("You must select an item");
                return;
            }
            tables_add_valueTypes_listBox.Items.RemoveAt(tables_add_valueTypes_listBox.SelectedIndex);
        }

        private void tables_add_addTable_button_Click(object sender, EventArgs e)
        {
            var tableName = tables_add_tableName_textBox.Text;
            var columns = tables_add_columnNames_listBox.Items;
            var valueTypes = tables_add_valueTypes_listBox.Items;

            if (string.IsNullOrWhiteSpace(tableName) || columns.Count == 0 || valueTypes.Count == 0 || columns.Count != valueTypes.Count)
            {
                WriteToLog("Table name, columns, and value types must not be empty. Column and values count must match.");
                return;
            }

            var newTableDto = new AddNewTableDto()
            {
                TableName = tableName,
                Columns = new List<ColumnDto>()
            };

            for (var i = 0; i < columns.Count; i++)
            {
                newTableDto.Columns.Add(new ColumnDto
                {
                    ColumnName = columns[i].ToString(),
                    Value = valueTypes[i].ToString()
                });
            }

            try
            {
                _sql.CreateDatabaseTable(newTableDto, connDto);

                WriteToLog("Successfully created new table:");
                WriteToLog(tableName);

                resetTableList();
                tables_add_columnNames_listBox.Items.Clear();
                tables_add_valueTypes_listBox.Items.Clear();
                tables_add_tableName_textBox.Text = string.Empty;
            }
            catch (Exception ex)
            {
                WriteToLog("Error creating new table:");
                WriteToLog(ex.Message);
            }
        }

        private void addTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetControlDisplay();
            tables_add_panel.Show();
        }

        private void deleteTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetControlDisplay();
            tables_delete_panel.Show();
        }

        private void tables_delete_button_Click(object sender, EventArgs e)
        {
            var tableName = dash_tables_listBox.SelectedItem?.ToString();
            if (string.IsNullOrWhiteSpace(tableName))
            {
                WriteToLog("You must make a selection first.");
                return;
            }

            try
            {
                _sql.DropTableIfExists(tableName, connDto);
                WriteToLog($"Successfully dropped table: {tableName}");
                resetTableList();
            }
            catch (Exception ex)
            {
                WriteToLog($"Error while dropping table: {tableName}");
                WriteToLog(ex.Message);
            }
        }

        private void columns_add_addColumn_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(columns_add_columnName_textBox.Text))
            {
                WriteToLog("You must type a value");
                return;
            }
            columns_add_columnNames_listBox.Items.Add(columns_add_columnName_textBox.Text);
            columns_add_columnName_textBox.Text = string.Empty;
        }

        private void addColumnToTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetControlDisplay();
            columns_addColumn_panel.Show();
        }

        private void columns_add_removeColumn_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(columns_add_columnNames_listBox.SelectedItem?.ToString()))
            {
                WriteToLog("You must select an item.");
                return;
            }
            columns_add_columnNames_listBox.Items.RemoveAt(columns_add_columnNames_listBox.SelectedIndex);
        }

        private void columns_add_addValueType_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(columns_add_valueTypes_comboBox.SelectedItem?.ToString()))
            {
                WriteToLog("You must select an item.");
                return;
            }
            columns_add_valueTypes_listBox.Items.Add(columns_add_valueTypes_comboBox.SelectedItem.ToString());
        }

        private void columns_add_removeValueType_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(columns_add_valueTypes_listBox.SelectedItem?.ToString()))
            {
                WriteToLog("You must select an item.");
                return;
            }
            columns_add_valueTypes_listBox.Items.RemoveAt(columns_add_valueTypes_listBox.SelectedIndex);
        }

        private void columns_add_column_button_Click(object sender, EventArgs e)
        {
            var tableName = dash_tables_listBox.SelectedItem?.ToString();
            var columns = columns_add_columnNames_listBox.Items;
            var valueTypes = columns_add_valueTypes_listBox.Items;

            if (string.IsNullOrWhiteSpace(tableName) || columns.Count == 0 || valueTypes.Count == 0 || columns.Count != valueTypes.Count)
            {
                WriteToLog("Table name, columns, and value types must not be empty. Column and values count must match.");
                return;
            }

            var newTableDto = new AddNewTableDto()
            {
                TableName = tableName,
                Columns = new List<ColumnDto>()
            };

            for (var i = 0; i < columns.Count; i++)
            {
                newTableDto.Columns.Add(new ColumnDto
                {
                    ColumnName = columns[i].ToString(),
                    Value = valueTypes[i].ToString()
                });
            }

            try
            {
                _sql.AddColumnToTable(newTableDto, connDto);

                WriteToLog("Successfully added columns to table:");
                WriteToLog(tableName);

                resetTableList();
                columns_add_columnNames_listBox.Items.Clear();
                columns_add_valueTypes_listBox.Items.Clear();
            }
            catch (Exception ex)
            {
                WriteToLog("Error adding columns to table:");
                WriteToLog(ex.Message);
            }
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _connBox.Show();
            Close();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void renameTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetControlDisplay();
            tables_rename_panel.Show();
        }

        private void removeColumnFromTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetControlDisplay();
            columns_remove_panel.Show();
        }

        private void renameColumnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetControlDisplay();
            columns_rename_panel.Show();
        }

        private void changeColumnDataTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetControlDisplay();
            columns_dataType_panel.Show();
        }

        private void changeColumnConstraintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetControlDisplay();
            columns_addConstraint_panel.Show();
        }

        private void removeColumnConstraintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetControlDisplay();
            columns_removeConstraint_panel.Show();
        }

        private void addRowToTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetControlDisplay();
            rows_add_panel.Show();
        }

        private void rows_add_addRowValue_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rows_add_rowValue_textBox.Text))
            {
                WriteToLog("You must type a value");
                return;
            }
            rows_add_rowValues_listBox.Items.Add(rows_add_rowValue_textBox.Text);
            rows_add_rowValue_textBox.Text = string.Empty;
        }

        private void rows_add_removeRowValue_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rows_add_rowValues_listBox.SelectedItem?.ToString()))
            {
                WriteToLog("You must select an item");
                return;
            }
            rows_add_rowValues_listBox.Items.RemoveAt(rows_add_rowValues_listBox.SelectedIndex);
        }

        private void rows_add_addRow_button_Click(object sender, EventArgs e)
        {
            var table = dash_tables_listBox.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(table))
            {
                WriteToLog("Must select table");
                return;
            }

            if (dash_columns_listBox.Items.Count - 1 != rows_add_rowValues_listBox.Items.Count)
            {
                WriteToLog("Must provide a value for every column except ID");
                return;
            }

            var columns = new List<ColumnDto>();
            foreach (var col in dash_columns_listBox.Items)
            {
                var name = col.ToString().Split(' ')[0];
                var type = col.ToString().Split(' ')[1].Trim(new char[] { '(', ')' });

                columns.Add(new ColumnDto()
                {
                    ColumnName = name,
                    Value = type
                });
            }
            var rows = new List<string>();

            foreach (var row in rows_add_rowValues_listBox.Items)
            {
                rows.Add(row.ToString());
            }

            var dto = new AddNewRowDto()
            {
                TableName = table,
                Columns = columns,
                Rows = rows
            };

            try
            {
                var id = _sql.AddRowToTable(dto, connDto);

                WriteToLog($"Successfully added values into row ID: {id}");
                rows_add_rowValues_listBox.Items.Clear();
                rows_add_rowValue_textBox.Text = string.Empty;
            }
            catch (Exception ex)
            {
                WriteToLog("Error adding values:");
                WriteToLog(ex.Message);
            }
        }

        private void dash_tables_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var columns = _sql.GetColumnList(dash_tables_listBox.SelectedItem?.ToString(), connDto);

                dash_columns_listBox.Items.Clear();
                rows_select_availableColumns_listBox.Items.Clear();
                rows_select_whereColumn_comboBox.Items.Clear();
                rows_delete_column_comboBox.Items.Clear();
                rows_select_selectedColumns_listBox.Items.Clear();
                rows_update_availableColumns_listBox.Items.Clear();
                rows_update_whereColumn_comboBox.Items.Clear();

                foreach (var col in columns)
                {
                    dash_columns_listBox.Items.Add($"{col.ColumnName} ({col.Value})");
                    rows_select_availableColumns_listBox.Items.Add($"{col.ColumnName} ({col.Value})");
                    rows_select_whereColumn_comboBox.Items.Add($"{col.ColumnName} ({col.Value})");
                    rows_delete_column_comboBox.Items.Add($"{col.ColumnName} ({col.Value})");
                    rows_update_availableColumns_listBox.Items.Add($"{col.ColumnName} ({col.Value})");
                    rows_update_whereColumn_comboBox.Items.Add($"{col.ColumnName} ({col.Value})");
                }
            }
            catch (Exception ex)
            {
                WriteToLog("Error getting columns for table:");
                WriteToLog(ex.Message);
            }

            try
            {
                var constraints = _sql.GetConstraints(dash_tables_listBox.SelectedItem?.ToString(), connDto);

                columns_removeConstraint_constraints_listBox.Items.Clear();

                foreach (var constraint in constraints)
                {
                    columns_removeConstraint_constraints_listBox.Items.Add(constraint);
                }
            }
            catch (Exception ex)
            {
                WriteToLog("Error getting constraints from table:");
                WriteToLog(ex.Message);
            }
        }

        private void columns_rename_newName_button_Click(object sender, EventArgs e)
        {
            try
            {
                var tableName = dash_tables_listBox.SelectedItem?.ToString();
                var columnName = dash_columns_listBox.SelectedItem?.ToString();
                var newColumnName = columns_rename_newName_textbox.Text;

                if (string.IsNullOrWhiteSpace(tableName) || string.IsNullOrWhiteSpace(columnName) || string.IsNullOrWhiteSpace(newColumnName))
                {
                    WriteToLog("You must have a table and column selected. You must have a column name typed.");
                    return;
                }

                tableName = tableName.Replace(' ', '_');

                _sql.RenameColumn(tableName, columnName.Split(' ')[0], newColumnName, connDto);

                WriteToLog("Successfully renamed column");
                dash_tables_listBox_SelectedIndexChanged(sender, e);
                columns_rename_newName_textbox.Text = string.Empty;
            }
            catch (Exception ex)
            {
                WriteToLog("Error renaming column:");
                WriteToLog(ex.Message);
            }
        }

        private void tables_rename_newName_button_Click(object sender, EventArgs e)
        {
            try
            {
                var tableName = dash_tables_listBox.SelectedItem?.ToString();
                var newTableName = tables_rename_newName_textbox.Text;

                if (string.IsNullOrWhiteSpace(tableName) || string.IsNullOrWhiteSpace(newTableName))
                {
                    WriteToLog("You must have a table selected. You must have a table name typed");
                    return;
                }

                newTableName = newTableName.Replace(' ', '_');

                _sql.RenameTable(tableName, newTableName, connDto);

                WriteToLog("Successfully renamed table");
                resetTableList();
                tables_rename_newName_textbox.Text = string.Empty;
            }
            catch (Exception ex)
            {
                WriteToLog("Error renaming table:");
                WriteToLog(ex.Message);
            }
        }

        private void selectRowsFromTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetControlDisplay();
            rows_select_panel.Show();
        }

        private void rows_select_addSelectedRow_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rows_select_availableColumns_listBox.SelectedItem?.ToString()))
            {
                WriteToLog("You must type a value");
                return;
            }
            rows_select_selectedColumns_listBox.Items.Add(rows_select_availableColumns_listBox.SelectedItem?.ToString());
            rows_select_availableColumns_listBox.Items.RemoveAt(rows_select_availableColumns_listBox.SelectedIndex);
        }

        private void rows_select_removeSelectedRow_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rows_select_selectedColumns_listBox.SelectedItem?.ToString()))
            {
                WriteToLog("You must type a value");
                return;
            }
            rows_select_availableColumns_listBox.Items.Add(rows_select_selectedColumns_listBox.SelectedItem.ToString());
            rows_select_selectedColumns_listBox.Items.RemoveAt(rows_select_selectedColumns_listBox.SelectedIndex);
        }

        private void rows_select_select_button_Click(object sender, EventArgs e)
        {
            if (rows_select_selectedColumns_listBox.Items.Count == 0 || string.IsNullOrWhiteSpace(dash_tables_listBox.SelectedItem?.ToString()))
            {
                WriteToLog("You must select a table columns.");
                return;
            }

            if (rows_select_where_checkBox.Checked)
            {
                if (string.IsNullOrWhiteSpace(rows_select_whereColumn_comboBox.SelectedItem?.ToString()) || string.IsNullOrWhiteSpace(rows_select_whereOperator_comboBox.SelectedItem?.ToString()) || string.IsNullOrWhiteSpace(rows_select_whereValue_textBox.Text))
                {
                    WriteToLog("All 'where' forms must have value.");
                    return;
                }
            }

            var dto = new FormSelectDto()
            {
                TableName = dash_tables_listBox.SelectedItem?.ToString(),
                Columns = new List<ColumnDto>()
            };

            foreach (var col in rows_select_selectedColumns_listBox.Items)
            {
                dto.Columns.Add(new ColumnDto()
                {
                    ColumnName = col.ToString().Split('(')[0].Trim(),
                    Value = col.ToString().Split('(')[1].TrimEnd(')')
                });
            }

            if (rows_select_where_checkBox.Checked)
            {
                dto.Where = true;
                dto.WhereColumn = new ColumnDto()
                {
                    ColumnName = rows_select_whereColumn_comboBox.SelectedItem?.ToString().Split('(')[0].Trim(),
                    Value = rows_select_whereColumn_comboBox.SelectedItem?.ToString().Split('(')[1].TrimEnd(')')
                };
                dto.WhereOperator = rows_select_whereOperator_comboBox.SelectedItem?.ToString();
                dto.WhereValue = rows_select_whereValue_textBox.Text;
            }

            try
            {
                var rows = _sql.GetRows(dto, connDto);

                WriteToLog($"Successfully retrieved {rows.Count} rows");
                WriteToLog("Opening data grid");

                while (rows_select_selectedColumns_listBox.Items.Count > 0)
                {
                    rows_select_availableColumns_listBox.Items.Add(rows_select_selectedColumns_listBox.Items[0]);
                    rows_select_selectedColumns_listBox.Items.RemoveAt(0);
                }

                rows_select_where_checkBox.Checked = false;
                rows_select_whereColumn_comboBox.SelectedIndex = -1;
                rows_select_whereOperator_comboBox.SelectedIndex = -1;
                rows_select_whereValue_textBox.Text = string.Empty;

                var data = new DataViewerDto()
                {
                    Columns = new List<string>(),
                    Values = new List<List<string>>()
                };

                var uniqueColumns = rows.Select(x => x.ColumnName).Distinct();

                data.Columns.AddRange(uniqueColumns);

                var listToAdd = new List<string>();
                for (int i = 0; i < rows.Count; i++)
                {
                    listToAdd.Add(rows[i].Value);
                    if (i + 1 == uniqueColumns.Count() || (i + 1) % uniqueColumns.Count() == 0)
                    {
                        data.Values.Add(listToAdd);
                        listToAdd = new List<string>();
                    }
                }

                var dataGrid = new DataViewer(data);
                dataGrid.Show();
            }
            catch (Exception ex)
            {
                WriteToLog("Error getting rows:");
                WriteToLog(ex.Message);
            }
        }

        private void deleteRowFromTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetControlDisplay();
            rows_delete_panel.Show();
        }

        private void rows_delete_delete_button_Click(object sender, EventArgs e)
        {
            var tableName = dash_tables_listBox.SelectedItem?.ToString();
            var columnName = rows_delete_column_comboBox.SelectedItem?.ToString();
            var opSymbol = rows_delete_operator_comboBox.SelectedItem?.ToString();
            var value = rows_delete_value_textBox.Text;

            if (string.IsNullOrWhiteSpace(tableName) || string.IsNullOrWhiteSpace(columnName) || string.IsNullOrWhiteSpace(opSymbol) || string.IsNullOrWhiteSpace(value))
            {
                WriteToLog("Table, column, operator, and value must be selected.");
                return;
            }

            try
            {
                var column = new ColumnDto()
                {
                    ColumnName = columnName.Split('(')[0].Trim(),
                    Value = columnName.Split('(')[1].TrimEnd(')')
                };

                var count = _sql.DeleteRowFromTable(tableName, column, opSymbol, value, connDto);

                rows_delete_value_textBox.Text = string.Empty;
                rows_delete_column_comboBox.SelectedIndex = -1;
                rows_delete_operator_comboBox.SelectedIndex = -1;

                WriteToLog($"Successfully deleted {count} row(s)");
            }
            catch (Exception ex)
            {
                WriteToLog("Error deleting row(s):");
                WriteToLog(ex.Message);
            }
        }

        private void updateRowsInTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetControlDisplay();
            rows_update_panel.Show();
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_connBox != null)
            {
                _connBox.Show();
            }
        }

        private void columns_addConstraint_references_table_comboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                var columns = _sql.GetColumnList(columns_addConstraint_references_table_comboBox.SelectedItem?.ToString(), connDto);

                columns_addConstraint_references_column_comboBox.Items.Clear();

                foreach (var col in columns)
                {
                    columns_addConstraint_references_column_comboBox.Items.Add($"{col.ColumnName} ({col.Value})");
                }
            }
            catch (Exception ex)
            {
                WriteToLog("Error retrieving column list:");
                WriteToLog(ex.Message);
            }
        }

        private void columns_addConstraint_add_button_Click(object sender, EventArgs e)
        {
            var tableName = dash_tables_listBox.SelectedItem?.ToString();
            var columnName = dash_columns_listBox.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(tableName) || string.IsNullOrWhiteSpace(columnName))
            {
                WriteToLog("Table and column must be selected.");
                return;
            }

            if (!columns_addConstraint_unique_checkBox.Checked && !columns_addConstraint_notNull_checkBox.Checked && !columns_addConstraint_references_checkBox.Checked && !columns_addConstraint_check_checkBox.Checked)
            {
                WriteToLog("You must check one constraint");
                return;
            }

            if (columns_addConstraint_references_checkBox.Checked && (string.IsNullOrWhiteSpace(columns_addConstraint_references_table_comboBox.SelectedItem?.ToString()) || string.IsNullOrWhiteSpace(columns_addConstraint_references_column_comboBox.SelectedItem?.ToString())))
            {
                WriteToLog("You must select a reference table and column.");
                return;
            }

            if (columns_addConstraint_check_checkBox.Checked && (string.IsNullOrWhiteSpace(columns_addConstraint_check_checkName_textBox.Text) || string.IsNullOrWhiteSpace(columns_addConstraint_check_columns_comboBox.SelectedItem?.ToString()) || string.IsNullOrWhiteSpace(columns_addConstraint_check_operators_comboBox.SelectedItem?.ToString()) || string.IsNullOrWhiteSpace(columns_addConstraint_check_value_textBox.Text)))
            {
                WriteToLog("You must have a check name, column, operator, and value.");
                return;
            }

            var dto = new AddColumnConstraintDto()
            {
                TableName = tableName,
                ColumnName = columnName.Split(' ')[0],
                Unique = columns_addConstraint_unique_checkBox.Checked,
                NotNull = columns_addConstraint_notNull_checkBox.Checked,
                References = columns_addConstraint_references_checkBox.Checked,
                Check = columns_addConstraint_check_checkBox.Checked
            };

            if (dto.References)
            {
                dto.ReferencesTableName = columns_addConstraint_references_table_comboBox.SelectedItem?.ToString();
                dto.ReferencesColumnName = columns_addConstraint_references_column_comboBox.SelectedItem?.ToString();
            }

            if (dto.Check)
            {
                dto.CheckName = columns_addConstraint_check_checkName_textBox.Text;
                dto.CheckColumn = columns_addConstraint_check_columns_comboBox.SelectedItem?.ToString();
                dto.CheckOperator = columns_addConstraint_check_operators_comboBox.SelectedItem?.ToString();
                dto.CheckValue = columns_addConstraint_check_value_textBox.Text;
            }

            try
            {
                _sql.AddColumnConstraint(dto, connDto);

                WriteToLog("Successfully added constraint(s)");

                dash_tables_listBox_SelectedIndexChanged(sender, e);

                columns_addConstraint_check_checkBox.Checked = false;
                columns_addConstraint_notNull_checkBox.Checked = false;
                columns_addConstraint_references_checkBox.Checked = false;
                columns_addConstraint_unique_checkBox.Checked = false;

                columns_addConstraint_check_columns_comboBox.SelectedIndex = -1;
                columns_addConstraint_check_operators_comboBox.SelectedIndex = -1;
                columns_addConstraint_references_column_comboBox.SelectedIndex = -1;
                columns_addConstraint_references_table_comboBox.SelectedIndex = -1;

                columns_addConstraint_check_checkName_textBox.Text = string.Empty;
                columns_addConstraint_check_value_textBox.Text = string.Empty;
            }
            catch (Exception ex)
            {
                WriteToLog("Error adding column constraint:");
                WriteToLog(ex.Message);
            }
        }

        private void columns_remove_removeColumn_button_Click(object sender, EventArgs e)
        {
            var tableName = dash_tables_listBox.SelectedItem?.ToString();
            var columnName = dash_columns_listBox.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(tableName) || string.IsNullOrWhiteSpace(columnName))
            {
                WriteToLog("Table and column must be selected.");
                return;
            }

            try
            {
                _sql.DropColumnFromTable(tableName, columnName.Split(' ')[0], connDto);

                WriteToLog($"Successfully dropped {columnName} from {tableName}");
                dash_tables_listBox_SelectedIndexChanged(sender, e);
            }
            catch (Exception ex)
            {
                WriteToLog("Error dropping column:");
                WriteToLog(ex.Message);
            }
        }

        private void columns_removeConstraint_remove_button_Click(object sender, EventArgs e)
        {
            var tableName = dash_tables_listBox.SelectedItem?.ToString();
            var constraint = columns_removeConstraint_constraints_listBox.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(tableName) || string.IsNullOrWhiteSpace(constraint))
            {
                WriteToLog("Table and constraint must be selected.");
                return;
            }

            try
            {
                _sql.DropTableConstraint(tableName, constraint, connDto);

                WriteToLog("Successfully dropped constraint from table.");

                dash_tables_listBox_SelectedIndexChanged(sender, e);
                columns_removeConstraint_constraints_listBox.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                WriteToLog("Error dropping table constraint:");
                WriteToLog(ex.Message);
            }
        }

        private void columns_dataType_changeType_button_Click(object sender, EventArgs e)
        {
            var tableName = dash_tables_listBox.SelectedItem?.ToString();
            var columnName = dash_columns_listBox.SelectedItem?.ToString();
            var dataType = columns_dataType_valueTypes_comboBox.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(tableName) || string.IsNullOrWhiteSpace(columnName) || string.IsNullOrWhiteSpace(dataType))
            {
                WriteToLog("Table, column, and data type must be selected.");
                return;
            }

            try
            {
                _sql.ChangeColumnDataType(tableName, columnName.Split(' ')[0], dataType, connDto);

                WriteToLog("Successfully changed data type");
                dash_tables_listBox_SelectedIndexChanged(sender, e);
                columns_dataType_valueTypes_comboBox.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                WriteToLog("Error changing data type:");
                WriteToLog(ex.Message);
            }
        }

        private void rows_update_addColumn_button_Click(object sender, EventArgs e)
        {
            var column = rows_update_availableColumns_listBox.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(column))
            {
                WriteToLog("You must select a column.");
                return;
            }

            rows_update_selectedColumns_listBox.Items.Add(column);
            rows_update_availableColumns_listBox.Items.RemoveAt(rows_update_availableColumns_listBox.SelectedIndex);
        }

        private void rows_update_removeColumn_button_Click(object sender, EventArgs e)
        {
            var column = rows_update_selectedColumns_listBox.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(column))
            {
                WriteToLog("You must select a column.");
                return;
            }

            rows_update_availableColumns_listBox.Items.Add(column);
            rows_update_selectedColumns_listBox.Items.RemoveAt(rows_update_selectedColumns_listBox.SelectedIndex);
        }

        private void rows_update_addValue_button_Click(object sender, EventArgs e)
        {
            var value = rows_update_value_textBox.Text;

            if (string.IsNullOrWhiteSpace(value))
            {
                WriteToLog("You must enter a value");
                return;
            }

            rows_update_values_listBox.Items.Add(value);
            rows_update_value_textBox.Text = string.Empty;
        }

        private void rows_update_removeValue_button_Click(object sender, EventArgs e)
        {
            var value = rows_update_values_listBox.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(value))
            {
                WriteToLog("You must select a value");
                return;
            }

            rows_update_values_listBox.Items.RemoveAt(rows_update_values_listBox.SelectedIndex);
        }

        private void rows_update_update_button_Click(object sender, EventArgs e)
        {
            var tableName = dash_tables_listBox.SelectedItem?.ToString();

            var selectedColumns = rows_update_selectedColumns_listBox.Items;
            var values = rows_update_values_listBox.Items;

            var whereColumn = rows_update_whereColumn_comboBox.SelectedItem?.ToString();
            var whereOperator = rows_update_whereOperator_comboBox.SelectedItem?.ToString();
            var whereValue = rows_update_whereValue_textBox.Text;

            if (string.IsNullOrWhiteSpace(tableName))
            {
                WriteToLog("Must select a table.");
                return;
            }
            if (selectedColumns.Count != values.Count)
            {
                WriteToLog("Selected columns and values counts must match");
                return;
            }

            if (string.IsNullOrWhiteSpace(whereColumn) || string.IsNullOrWhiteSpace(whereOperator) || string.IsNullOrWhiteSpace(whereValue))
            {
                WriteToLog("Must have WHERE column, operator, and value");
                return;
            }

            try
            {
                var dto = new FormUpdateDto()
                {
                    TableName = tableName,
                    Columns = new List<ColumnDto>(),
                    WhereColumn = new ColumnDto()
                    {
                        ColumnName = whereColumn.Split(' ')[0],
                        Value = whereColumn.Split(' ')[1].Trim(new char[] { '(', ')' })
                    },
                    WhereOperator = whereOperator,
                    WhereValue = whereValue,
                    Values = new List<string>()
                };

                foreach (var val in values)
                {
                    dto.Values.Add(val.ToString());
                }
                foreach (var col in selectedColumns)
                {
                    dto.Columns.Add(new ColumnDto()
                    {
                        ColumnName = col.ToString().Split(' ')[0],
                        Value = col.ToString().Split(' ')[1].Trim(new char[] { '(', ')' })
                    });
                }

                var count = _sql.UpdateRowFromTable(dto, connDto);

                WriteToLog($"Successfully updated {count} row(s).");

                rows_update_whereColumn_comboBox.SelectedIndex = -1;
                dash_tables_listBox_SelectedIndexChanged(sender, e);
                rows_update_selectedColumns_listBox.Items.Clear();
                rows_update_values_listBox.Items.Clear();
                rows_update_whereOperator_comboBox.SelectedIndex = -1;
                rows_update_whereValue_textBox.Text = string.Empty;
            }
            catch (Exception ex)
            {
                WriteToLog("Error updating rows:");
                WriteToLog(ex.Message);
            }
        }
    }
}