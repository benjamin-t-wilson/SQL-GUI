using SQL_GUI.DTOs;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SQL_GUI
{
    public partial class Dashboard : Form
    {
        private ConnectionDto connDto = new ConnectionDto();
        private SqlFunctions _sql = new SqlFunctions();

        public Dashboard(string host, string username, string database, string port, string password)
        {
            InitializeComponent();
            connDto.Host = host;
            connDto.Username = username;
            connDto.Database = database;
            connDto.Port = port;
            connDto.Password = password;

            try
            {
                var version = _sql.CheckDatabaseVersion(connDto);

                dash_log_richTextBox.Text += "Successfully connected to database";
                dash_log_richTextBox.Text += Environment.NewLine;
                dash_log_richTextBox.Text += version;

                resetTableList();
            }
            catch (Exception ex)
            {
                dash_log_richTextBox.Text += "Error connecting to database:";
                dash_log_richTextBox.Text += Environment.NewLine;
                dash_log_richTextBox.Text += ex.Message;
            }
        }

        private void resetTableList()
        {
            var tablesList = _sql.GetListOfTables(connDto);
            dash_log_richTextBox.Text += Environment.NewLine;
            dash_log_richTextBox.Text += "Reset tables list...";

            dash_tables_listBox.Items.Clear();

            foreach (var tableName in tablesList)
            {
                dash_tables_listBox.Items.Add(tableName);
            }
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
                dash_log_richTextBox.Text += Environment.NewLine;
                dash_log_richTextBox.Text += "Table name, columns, and value types must not be empty. Column and values count must match.";
                return;
            }

            var newTableDto = new AddNewTableDto()
            {
                TableName = tables_add_tableName_textBox.Text,
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

                dash_log_richTextBox.Text += Environment.NewLine;
                dash_log_richTextBox.Text += "Successfully created new table:";
                dash_log_richTextBox.Text += Environment.NewLine;
                dash_log_richTextBox.Text += tableName;

                resetTableList();
            }
            catch (Exception ex)
            {
                dash_log_richTextBox.Text += Environment.NewLine;
                dash_log_richTextBox.Text += "Error creating new table:";
                dash_log_richTextBox.Text += Environment.NewLine;
                dash_log_richTextBox.Text += ex.Message;
            }
        }
    }
}