using SQL_GUI.DTOs;
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

            foreach (var tableName in tablesList)
            {
                dash_tables_listBox.Items.Add(tableName);
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
            tables_add_columnNames_listBox.Items.Add(tables_add_columnNames_textBox.Text);
            tables_add_columnNames_textBox.Text = string.Empty;
        }

        private void tables_add_removeColumnNames_button_Click(object sender, EventArgs e)
        {
            tables_add_columnNames_listBox.Items.RemoveAt(tables_add_columnNames_listBox.SelectedIndex);
        }

        private void tables_add_addValueType_button_Click(object sender, EventArgs e)
        {
            tables_add_valueTypes_listBox.Items.Add(tables_add_addValueType_comboBox.SelectedItem.ToString());
        }

        private void tables_add_removeValueType_button_Click(object sender, EventArgs e)
        {
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
                    ValueType = valueTypes[i].ToString()
                });
            }

            try
            {
                var addTable = _sql.CreateDatabaseTable(newTableDto, connDto);

                WriteToLog("Successfully created new table:");
                WriteToLog(tableName);

                resetTableList();
                tables_add_columnNames_listBox.Items.Clear();
                tables_add_valueTypes_listBox.Items.Clear();
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
            columns_add_columnNames_listBox.Items.RemoveAt(columns_add_columnNames_listBox.SelectedIndex);
        }

        private void columns_add_addValueType_button_Click(object sender, EventArgs e)
        {
            columns_add_valueTypes_listBox.Items.Add(columns_add_valueTypes_comboBox.SelectedItem.ToString());
        }

        private void columns_add_removeValueType_button_Click(object sender, EventArgs e)
        {
            columns_add_valueTypes_listBox.Items.RemoveAt(columns_add_valueTypes_listBox.SelectedIndex);
        }

        private void columns_add_column_button_Click(object sender, EventArgs e)
        {
            var tableName = dash_tables_listBox.SelectedItem.ToString();
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
                    ValueType = valueTypes[i].ToString()
                });
            }

            try
            {
                var addTable = _sql.AddColumnToTable(newTableDto, connDto);

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
    }
}