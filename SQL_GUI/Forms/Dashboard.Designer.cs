﻿namespace SQL_GUI.Forms
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.dash_log_richTextBox = new System.Windows.Forms.RichTextBox();
            this.dash_tables_listBox = new System.Windows.Forms.ListBox();
            this.dash_tables_label = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.columnsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addColumnToTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeColumnFromTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameColumnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeColumnDataTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeColumnConstraintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeColumnConstraintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRowToTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectRowsFromTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateRowsInTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRowFromTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSchemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameSchemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dropSchemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dropDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tables_add_tableName_textBox = new System.Windows.Forms.TextBox();
            this.tables_add_tableName_label = new System.Windows.Forms.Label();
            this.tables_add_columnNames_listBox = new System.Windows.Forms.ListBox();
            this.tables_add_columnNames_label = new System.Windows.Forms.Label();
            this.tables_add_columnNames_textBox = new System.Windows.Forms.TextBox();
            this.tables_add_addColumnNames_button = new System.Windows.Forms.Button();
            this.tables_add_removeColumnNames_button = new System.Windows.Forms.Button();
            this.tables_add_removeValueType_button = new System.Windows.Forms.Button();
            this.tables_add_addValueType_button = new System.Windows.Forms.Button();
            this.tables_add_valueTypes_label = new System.Windows.Forms.Label();
            this.tables_add_valueTypes_listBox = new System.Windows.Forms.ListBox();
            this.tables_add_tip_label = new System.Windows.Forms.Label();
            this.tables_add_addValueType_comboBox = new System.Windows.Forms.ComboBox();
            this.tables_add_addTable_button = new System.Windows.Forms.Button();
            this.tables_add_panel = new System.Windows.Forms.Panel();
            this.tables_delete_panel = new System.Windows.Forms.Panel();
            this.tables_delete_button = new System.Windows.Forms.Button();
            this.tables_delete_label = new System.Windows.Forms.Label();
            this.columns_addColumn_panel = new System.Windows.Forms.Panel();
            this.columns_add_columnTableNote_label = new System.Windows.Forms.Label();
            this.columns_add_column_button = new System.Windows.Forms.Button();
            this.columns_add_columnColumnNote_label = new System.Windows.Forms.Label();
            this.columns_add_removeColumn_button = new System.Windows.Forms.Button();
            this.columns_add_valueTypes_comboBox = new System.Windows.Forms.ComboBox();
            this.columns_add_addColumn_button = new System.Windows.Forms.Button();
            this.columns_add_valueTypes_listBox = new System.Windows.Forms.ListBox();
            this.columns_add_columnName_textBox = new System.Windows.Forms.TextBox();
            this.columns_add_columnNames_label = new System.Windows.Forms.Label();
            this.columns_add_removeValueType_button = new System.Windows.Forms.Button();
            this.columns_add_columnNames_listBox = new System.Windows.Forms.ListBox();
            this.columns_add_addValueType_button = new System.Windows.Forms.Button();
            this.columns_add_valueTypes_label = new System.Windows.Forms.Label();
            this.tables_rename_panel = new System.Windows.Forms.Panel();
            this.tables_rename_newName_button = new System.Windows.Forms.Button();
            this.tables_rename_newName_textbox = new System.Windows.Forms.TextBox();
            this.tables_rename_newName_label = new System.Windows.Forms.Label();
            this.tables_rename_toolTip_label = new System.Windows.Forms.Label();
            this.dash_columns_label = new System.Windows.Forms.Label();
            this.dash_columns_listBox = new System.Windows.Forms.ListBox();
            this.columns_rename_panel = new System.Windows.Forms.Panel();
            this.columns_rename_newName_button = new System.Windows.Forms.Button();
            this.columns_rename_newName_textbox = new System.Windows.Forms.TextBox();
            this.columns_rename_newName_label = new System.Windows.Forms.Label();
            this.columns_rename_toolTip_label = new System.Windows.Forms.Label();
            this.columns_remove_panel = new System.Windows.Forms.Panel();
            this.columns_remove_removeColumn_button = new System.Windows.Forms.Button();
            this.columns_remove_toolTip_label = new System.Windows.Forms.Label();
            this.columns_dataType_panel = new System.Windows.Forms.Panel();
            this.columns_dataType_changeType_button = new System.Windows.Forms.Button();
            this.columns_dataType_toolTip_label = new System.Windows.Forms.Label();
            this.columns_dataType_valueTypes_comboBox = new System.Windows.Forms.ComboBox();
            this.columns_dataType_valueTypes_label = new System.Windows.Forms.Label();
            this.columns_addConstraint_panel = new System.Windows.Forms.Panel();
            this.columns_addConstraint_add_button = new System.Windows.Forms.Button();
            this.columns_addConstraint_references_column_label = new System.Windows.Forms.Label();
            this.columns_addConstraint_references_table_label = new System.Windows.Forms.Label();
            this.columns_addConstraint_check_value_label = new System.Windows.Forms.Label();
            this.columns_addConstraint_check_operators_label = new System.Windows.Forms.Label();
            this.columns_addConstraint_check_column_label = new System.Windows.Forms.Label();
            this.columns_addConstraint_check_checkName_label = new System.Windows.Forms.Label();
            this.columns_addConstraint_check_value_textBox = new System.Windows.Forms.TextBox();
            this.columns_addConstraint_check_operators_comboBox = new System.Windows.Forms.ComboBox();
            this.columns_addConstraint_check_columns_comboBox = new System.Windows.Forms.ComboBox();
            this.columns_addConstraint_check_checkName_textBox = new System.Windows.Forms.TextBox();
            this.columns_addConstraint_references_column_comboBox = new System.Windows.Forms.ComboBox();
            this.columns_addConstraint_references_table_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.columns_addConstraint_check_checkBox = new System.Windows.Forms.CheckBox();
            this.columns_addConstraint_references_checkBox = new System.Windows.Forms.CheckBox();
            this.columns_addConstraint_notNull_checkBox = new System.Windows.Forms.CheckBox();
            this.columns_addConstraint_unique_checkBox = new System.Windows.Forms.CheckBox();
            this.columns_removeConstraint_panel = new System.Windows.Forms.Panel();
            this.columns_removeConstraint_remove_button = new System.Windows.Forms.Button();
            this.columns_removeConstraint_constraints_label = new System.Windows.Forms.Label();
            this.columns_removeConstraint_constraints_listBox = new System.Windows.Forms.ListBox();
            this.columns_removeConstraint_toolTip_label = new System.Windows.Forms.Label();
            this.rows_add_panel = new System.Windows.Forms.Panel();
            this.rows_add_rowValues_label = new System.Windows.Forms.Label();
            this.rows_add_addRow_button = new System.Windows.Forms.Button();
            this.rows_add_removeRowValue_button = new System.Windows.Forms.Button();
            this.rows_add_addRowValue_button = new System.Windows.Forms.Button();
            this.rows_add_rowValues_listBox = new System.Windows.Forms.ListBox();
            this.rows_add_rowValue_textBox = new System.Windows.Forms.TextBox();
            this.rows_add_rowValue_label = new System.Windows.Forms.Label();
            this.rows_add_toolTip_label = new System.Windows.Forms.Label();
            this.rows_select_panel = new System.Windows.Forms.Panel();
            this.rows_select_whereValue_label = new System.Windows.Forms.Label();
            this.rows_select_whereColumn_label = new System.Windows.Forms.Label();
            this.rows_select_whereColumn_comboBox = new System.Windows.Forms.ComboBox();
            this.rows_select_whereOperator_label = new System.Windows.Forms.Label();
            this.rows_select_whereValue_textBox = new System.Windows.Forms.TextBox();
            this.rows_select_whereOperator_comboBox = new System.Windows.Forms.ComboBox();
            this.rows_select_where_checkBox = new System.Windows.Forms.CheckBox();
            this.rows_select_select_button = new System.Windows.Forms.Button();
            this.rows_select_removeSelectedRow_button = new System.Windows.Forms.Button();
            this.rows_select_addSelectedRow_button = new System.Windows.Forms.Button();
            this.rows_select_selectedColumns_listBox = new System.Windows.Forms.ListBox();
            this.rows_select_selectedRows_label = new System.Windows.Forms.Label();
            this.rows_select_availableColumns_listBox = new System.Windows.Forms.ListBox();
            this.rows_select_availableColumns_label = new System.Windows.Forms.Label();
            this.rows_select_toolTip_label = new System.Windows.Forms.Label();
            this.rows_delete_panel = new System.Windows.Forms.Panel();
            this.rows_delete_value_textBox = new System.Windows.Forms.TextBox();
            this.rows_delete_operator_comboBox = new System.Windows.Forms.ComboBox();
            this.rows_delete_column_comboBox = new System.Windows.Forms.ComboBox();
            this.rows_delete_delete_button = new System.Windows.Forms.Button();
            this.rows_delete_value_label = new System.Windows.Forms.Label();
            this.rows_delete_operator_label = new System.Windows.Forms.Label();
            this.rows_delete_column_label = new System.Windows.Forms.Label();
            this.rows_delete_toolTip_label = new System.Windows.Forms.Label();
            this.rows_update_panel = new System.Windows.Forms.Panel();
            this.rows_update_removeValue_button = new System.Windows.Forms.Button();
            this.rows_update_addValue_button = new System.Windows.Forms.Button();
            this.rows_update_whereValue_label = new System.Windows.Forms.Label();
            this.rows_update_whereOperator_label = new System.Windows.Forms.Label();
            this.rows_update_whereColumn_label = new System.Windows.Forms.Label();
            this.rows_update_whereValue_textBox = new System.Windows.Forms.TextBox();
            this.rows_update_whereOperator_comboBox = new System.Windows.Forms.ComboBox();
            this.rows_update_whereColumn_comboBox = new System.Windows.Forms.ComboBox();
            this.rows_update_where_label = new System.Windows.Forms.Label();
            this.rows_update_removeColumn_button = new System.Windows.Forms.Button();
            this.rows_update_addColumn_button = new System.Windows.Forms.Button();
            this.rows_update_update_button = new System.Windows.Forms.Button();
            this.rows_update_value_textBox = new System.Windows.Forms.TextBox();
            this.rows_update_value_label = new System.Windows.Forms.Label();
            this.rows_update_values_listBox = new System.Windows.Forms.ListBox();
            this.rows_update_values_label = new System.Windows.Forms.Label();
            this.rows_update_selectedColumns_listBox = new System.Windows.Forms.ListBox();
            this.rows_update_selectedColumns_label = new System.Windows.Forms.Label();
            this.rows_update_availableColumns_listBox = new System.Windows.Forms.ListBox();
            this.rows_update_availableColumns_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dash_statusStrip = new System.Windows.Forms.StatusStrip();
            this.dash_statusStrip_database_label = new System.Windows.Forms.ToolStripStatusLabel();
            this.dash_statusStrip_database_value = new System.Windows.Forms.ToolStripStatusLabel();
            this.dash_statusStrip_schema_label = new System.Windows.Forms.ToolStripStatusLabel();
            this.dash_statusStrip_schema_value = new System.Windows.Forms.ToolStripDropDownButton();
            this.schemas_add_panel = new System.Windows.Forms.Panel();
            this.schemas_add_addSchema_button = new System.Windows.Forms.Button();
            this.schemas_add_schemaName_textBox = new System.Windows.Forms.TextBox();
            this.schemas_add_schemaName_label = new System.Windows.Forms.Label();
            this.schemas_add_toolTip = new System.Windows.Forms.Label();
            this.schemas_rename_panel = new System.Windows.Forms.Panel();
            this.schemas_rename_rename_button = new System.Windows.Forms.Button();
            this.schemas_rename_newName_textBox = new System.Windows.Forms.TextBox();
            this.schemas_rename_newName_label = new System.Windows.Forms.Label();
            this.schemas_rename_toolTip = new System.Windows.Forms.Label();
            this.schemas_delete_panel = new System.Windows.Forms.Panel();
            this.schemas_delete_delete_button = new System.Windows.Forms.Button();
            this.schemas_delete_toolTip = new System.Windows.Forms.Label();
            this.databases_add_panel = new System.Windows.Forms.Panel();
            this.databases_add_addDb_button = new System.Windows.Forms.Button();
            this.databases_add_dbName_textBox = new System.Windows.Forms.TextBox();
            this.databases_add_dbName_label = new System.Windows.Forms.Label();
            this.databases_add_toolTip_label = new System.Windows.Forms.Label();
            this.databases_add_dbList_label = new System.Windows.Forms.Label();
            this.databases_add_dbList_listBox = new System.Windows.Forms.ListBox();
            this.databases_rename_panel = new System.Windows.Forms.Panel();
            this.databases_rename_renameDb_button = new System.Windows.Forms.Button();
            this.databases_rename_dbName_textBox = new System.Windows.Forms.TextBox();
            this.databases_rename_dbName_label = new System.Windows.Forms.Label();
            this.databases_rename_toolTip_label = new System.Windows.Forms.Label();
            this.databases_rename_dbList_label = new System.Windows.Forms.Label();
            this.databases_rename_dbList_listBox = new System.Windows.Forms.ListBox();
            this.databases_delete_panel = new System.Windows.Forms.Panel();
            this.databases_delete_delete_button = new System.Windows.Forms.Button();
            this.databases_delete_toolTip_label = new System.Windows.Forms.Label();
            this.databases_delete_dbList_label = new System.Windows.Forms.Label();
            this.databases_delete_dbList_listBox = new System.Windows.Forms.ListBox();
            this.rows_select_addAllCols_button = new System.Windows.Forms.Button();
            this.rows_select_removeAllCols_button = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tables_add_panel.SuspendLayout();
            this.tables_delete_panel.SuspendLayout();
            this.columns_addColumn_panel.SuspendLayout();
            this.tables_rename_panel.SuspendLayout();
            this.columns_rename_panel.SuspendLayout();
            this.columns_remove_panel.SuspendLayout();
            this.columns_dataType_panel.SuspendLayout();
            this.columns_addConstraint_panel.SuspendLayout();
            this.columns_removeConstraint_panel.SuspendLayout();
            this.rows_add_panel.SuspendLayout();
            this.rows_select_panel.SuspendLayout();
            this.rows_delete_panel.SuspendLayout();
            this.rows_update_panel.SuspendLayout();
            this.dash_statusStrip.SuspendLayout();
            this.schemas_add_panel.SuspendLayout();
            this.schemas_rename_panel.SuspendLayout();
            this.schemas_delete_panel.SuspendLayout();
            this.databases_add_panel.SuspendLayout();
            this.databases_rename_panel.SuspendLayout();
            this.databases_delete_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dash_log_richTextBox
            // 
            this.dash_log_richTextBox.Location = new System.Drawing.Point(232, 425);
            this.dash_log_richTextBox.Name = "dash_log_richTextBox";
            this.dash_log_richTextBox.Size = new System.Drawing.Size(918, 297);
            this.dash_log_richTextBox.TabIndex = 0;
            this.dash_log_richTextBox.Text = "";
            // 
            // dash_tables_listBox
            // 
            this.dash_tables_listBox.FormattingEnabled = true;
            this.dash_tables_listBox.ItemHeight = 16;
            this.dash_tables_listBox.Location = new System.Drawing.Point(12, 93);
            this.dash_tables_listBox.Name = "dash_tables_listBox";
            this.dash_tables_listBox.Size = new System.Drawing.Size(202, 292);
            this.dash_tables_listBox.TabIndex = 1;
            this.dash_tables_listBox.SelectedIndexChanged += new System.EventHandler(this.dash_tables_listBox_SelectedIndexChanged);
            // 
            // dash_tables_label
            // 
            this.dash_tables_label.AutoSize = true;
            this.dash_tables_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dash_tables_label.Location = new System.Drawing.Point(12, 61);
            this.dash_tables_label.Name = "dash_tables_label";
            this.dash_tables_label.Size = new System.Drawing.Size(78, 25);
            this.dash_tables_label.TabIndex = 2;
            this.dash_tables_label.Text = "Tables:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.tablesToolStripMenuItem,
            this.columnsToolStripMenuItem,
            this.rowsToolStripMenuItem,
            this.schemaToolStripMenuItem,
            this.databasesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1165, 30);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disconnectToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // tablesToolStripMenuItem
            // 
            this.tablesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTableToolStripMenuItem,
            this.deleteTableToolStripMenuItem,
            this.renameTableToolStripMenuItem});
            this.tablesToolStripMenuItem.Name = "tablesToolStripMenuItem";
            this.tablesToolStripMenuItem.Size = new System.Drawing.Size(64, 26);
            this.tablesToolStripMenuItem.Text = "Tables";
            // 
            // addTableToolStripMenuItem
            // 
            this.addTableToolStripMenuItem.Name = "addTableToolStripMenuItem";
            this.addTableToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.addTableToolStripMenuItem.Text = "Add table";
            this.addTableToolStripMenuItem.Click += new System.EventHandler(this.addTableToolStripMenuItem_Click);
            // 
            // deleteTableToolStripMenuItem
            // 
            this.deleteTableToolStripMenuItem.Name = "deleteTableToolStripMenuItem";
            this.deleteTableToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.deleteTableToolStripMenuItem.Text = "Delete table";
            this.deleteTableToolStripMenuItem.Click += new System.EventHandler(this.deleteTableToolStripMenuItem_Click);
            // 
            // renameTableToolStripMenuItem
            // 
            this.renameTableToolStripMenuItem.Name = "renameTableToolStripMenuItem";
            this.renameTableToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.renameTableToolStripMenuItem.Text = "Rename table";
            this.renameTableToolStripMenuItem.Click += new System.EventHandler(this.renameTableToolStripMenuItem_Click);
            // 
            // columnsToolStripMenuItem
            // 
            this.columnsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addColumnToTableToolStripMenuItem,
            this.removeColumnFromTableToolStripMenuItem,
            this.renameColumnToolStripMenuItem,
            this.changeColumnDataTypeToolStripMenuItem,
            this.changeColumnConstraintToolStripMenuItem,
            this.removeColumnConstraintToolStripMenuItem});
            this.columnsToolStripMenuItem.Name = "columnsToolStripMenuItem";
            this.columnsToolStripMenuItem.Size = new System.Drawing.Size(80, 26);
            this.columnsToolStripMenuItem.Text = "Columns";
            // 
            // addColumnToTableToolStripMenuItem
            // 
            this.addColumnToTableToolStripMenuItem.Name = "addColumnToTableToolStripMenuItem";
            this.addColumnToTableToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.addColumnToTableToolStripMenuItem.Text = "Add column to table";
            this.addColumnToTableToolStripMenuItem.Click += new System.EventHandler(this.addColumnToTableToolStripMenuItem_Click);
            // 
            // removeColumnFromTableToolStripMenuItem
            // 
            this.removeColumnFromTableToolStripMenuItem.Name = "removeColumnFromTableToolStripMenuItem";
            this.removeColumnFromTableToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.removeColumnFromTableToolStripMenuItem.Text = "Remove column from table";
            this.removeColumnFromTableToolStripMenuItem.Click += new System.EventHandler(this.removeColumnFromTableToolStripMenuItem_Click);
            // 
            // renameColumnToolStripMenuItem
            // 
            this.renameColumnToolStripMenuItem.Name = "renameColumnToolStripMenuItem";
            this.renameColumnToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.renameColumnToolStripMenuItem.Text = "Rename column";
            this.renameColumnToolStripMenuItem.Click += new System.EventHandler(this.renameColumnToolStripMenuItem_Click);
            // 
            // changeColumnDataTypeToolStripMenuItem
            // 
            this.changeColumnDataTypeToolStripMenuItem.Name = "changeColumnDataTypeToolStripMenuItem";
            this.changeColumnDataTypeToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.changeColumnDataTypeToolStripMenuItem.Text = "Change column data type";
            this.changeColumnDataTypeToolStripMenuItem.Click += new System.EventHandler(this.changeColumnDataTypeToolStripMenuItem_Click);
            // 
            // changeColumnConstraintToolStripMenuItem
            // 
            this.changeColumnConstraintToolStripMenuItem.Name = "changeColumnConstraintToolStripMenuItem";
            this.changeColumnConstraintToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.changeColumnConstraintToolStripMenuItem.Text = "Add column constraint";
            this.changeColumnConstraintToolStripMenuItem.Click += new System.EventHandler(this.changeColumnConstraintToolStripMenuItem_Click);
            // 
            // removeColumnConstraintToolStripMenuItem
            // 
            this.removeColumnConstraintToolStripMenuItem.Name = "removeColumnConstraintToolStripMenuItem";
            this.removeColumnConstraintToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.removeColumnConstraintToolStripMenuItem.Text = "Remove column constraint";
            this.removeColumnConstraintToolStripMenuItem.Click += new System.EventHandler(this.removeColumnConstraintToolStripMenuItem_Click);
            // 
            // rowsToolStripMenuItem
            // 
            this.rowsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRowToTableToolStripMenuItem,
            this.selectRowsFromTableToolStripMenuItem,
            this.updateRowsInTableToolStripMenuItem,
            this.deleteRowFromTableToolStripMenuItem});
            this.rowsToolStripMenuItem.Name = "rowsToolStripMenuItem";
            this.rowsToolStripMenuItem.Size = new System.Drawing.Size(58, 26);
            this.rowsToolStripMenuItem.Text = "Rows";
            // 
            // addRowToTableToolStripMenuItem
            // 
            this.addRowToTableToolStripMenuItem.Name = "addRowToTableToolStripMenuItem";
            this.addRowToTableToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.addRowToTableToolStripMenuItem.Text = "Add row to table";
            this.addRowToTableToolStripMenuItem.Click += new System.EventHandler(this.addRowToTableToolStripMenuItem_Click);
            // 
            // selectRowsFromTableToolStripMenuItem
            // 
            this.selectRowsFromTableToolStripMenuItem.Name = "selectRowsFromTableToolStripMenuItem";
            this.selectRowsFromTableToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.selectRowsFromTableToolStripMenuItem.Text = "Select row(s) from table";
            this.selectRowsFromTableToolStripMenuItem.Click += new System.EventHandler(this.selectRowsFromTableToolStripMenuItem_Click);
            // 
            // updateRowsInTableToolStripMenuItem
            // 
            this.updateRowsInTableToolStripMenuItem.Name = "updateRowsInTableToolStripMenuItem";
            this.updateRowsInTableToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.updateRowsInTableToolStripMenuItem.Text = "Update row(s) in table";
            this.updateRowsInTableToolStripMenuItem.Click += new System.EventHandler(this.updateRowsInTableToolStripMenuItem_Click);
            // 
            // deleteRowFromTableToolStripMenuItem
            // 
            this.deleteRowFromTableToolStripMenuItem.Name = "deleteRowFromTableToolStripMenuItem";
            this.deleteRowFromTableToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.deleteRowFromTableToolStripMenuItem.Text = "Delete row from table";
            this.deleteRowFromTableToolStripMenuItem.Click += new System.EventHandler(this.deleteRowFromTableToolStripMenuItem_Click);
            // 
            // schemaToolStripMenuItem
            // 
            this.schemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSchemaToolStripMenuItem,
            this.renameSchemaToolStripMenuItem,
            this.dropSchemaToolStripMenuItem});
            this.schemaToolStripMenuItem.Name = "schemaToolStripMenuItem";
            this.schemaToolStripMenuItem.Size = new System.Drawing.Size(81, 26);
            this.schemaToolStripMenuItem.Text = "Schemas";
            // 
            // addSchemaToolStripMenuItem
            // 
            this.addSchemaToolStripMenuItem.Name = "addSchemaToolStripMenuItem";
            this.addSchemaToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.addSchemaToolStripMenuItem.Text = "Add schema";
            this.addSchemaToolStripMenuItem.Click += new System.EventHandler(this.addSchemaToolStripMenuItem_Click);
            // 
            // renameSchemaToolStripMenuItem
            // 
            this.renameSchemaToolStripMenuItem.Name = "renameSchemaToolStripMenuItem";
            this.renameSchemaToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.renameSchemaToolStripMenuItem.Text = "Rename schema";
            this.renameSchemaToolStripMenuItem.Click += new System.EventHandler(this.renameSchemaToolStripMenuItem_Click);
            // 
            // dropSchemaToolStripMenuItem
            // 
            this.dropSchemaToolStripMenuItem.Name = "dropSchemaToolStripMenuItem";
            this.dropSchemaToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.dropSchemaToolStripMenuItem.Text = "Drop schema";
            this.dropSchemaToolStripMenuItem.Click += new System.EventHandler(this.dropSchemaToolStripMenuItem_Click);
            // 
            // databasesToolStripMenuItem
            // 
            this.databasesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDatabaseToolStripMenuItem,
            this.renameDatabaseToolStripMenuItem,
            this.dropDatabaseToolStripMenuItem});
            this.databasesToolStripMenuItem.Name = "databasesToolStripMenuItem";
            this.databasesToolStripMenuItem.Size = new System.Drawing.Size(92, 26);
            this.databasesToolStripMenuItem.Text = "Databases";
            // 
            // addDatabaseToolStripMenuItem
            // 
            this.addDatabaseToolStripMenuItem.Name = "addDatabaseToolStripMenuItem";
            this.addDatabaseToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.addDatabaseToolStripMenuItem.Text = "Add database";
            this.addDatabaseToolStripMenuItem.Click += new System.EventHandler(this.addDatabaseToolStripMenuItem_Click);
            // 
            // renameDatabaseToolStripMenuItem
            // 
            this.renameDatabaseToolStripMenuItem.Name = "renameDatabaseToolStripMenuItem";
            this.renameDatabaseToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.renameDatabaseToolStripMenuItem.Text = "Rename database";
            this.renameDatabaseToolStripMenuItem.Click += new System.EventHandler(this.renameDatabaseToolStripMenuItem_Click);
            // 
            // dropDatabaseToolStripMenuItem
            // 
            this.dropDatabaseToolStripMenuItem.Name = "dropDatabaseToolStripMenuItem";
            this.dropDatabaseToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.dropDatabaseToolStripMenuItem.Text = "Drop database";
            this.dropDatabaseToolStripMenuItem.Click += new System.EventHandler(this.dropDatabaseToolStripMenuItem_Click);
            // 
            // tables_add_tableName_textBox
            // 
            this.tables_add_tableName_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tables_add_tableName_textBox.Location = new System.Drawing.Point(142, 49);
            this.tables_add_tableName_textBox.Name = "tables_add_tableName_textBox";
            this.tables_add_tableName_textBox.Size = new System.Drawing.Size(198, 26);
            this.tables_add_tableName_textBox.TabIndex = 4;
            // 
            // tables_add_tableName_label
            // 
            this.tables_add_tableName_label.AutoSize = true;
            this.tables_add_tableName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tables_add_tableName_label.Location = new System.Drawing.Point(22, 52);
            this.tables_add_tableName_label.Name = "tables_add_tableName_label";
            this.tables_add_tableName_label.Size = new System.Drawing.Size(101, 20);
            this.tables_add_tableName_label.TabIndex = 5;
            this.tables_add_tableName_label.Text = "Table name:";
            // 
            // tables_add_columnNames_listBox
            // 
            this.tables_add_columnNames_listBox.FormattingEnabled = true;
            this.tables_add_columnNames_listBox.ItemHeight = 16;
            this.tables_add_columnNames_listBox.Location = new System.Drawing.Point(384, 149);
            this.tables_add_columnNames_listBox.Name = "tables_add_columnNames_listBox";
            this.tables_add_columnNames_listBox.Size = new System.Drawing.Size(142, 196);
            this.tables_add_columnNames_listBox.TabIndex = 6;
            // 
            // tables_add_columnNames_label
            // 
            this.tables_add_columnNames_label.AutoSize = true;
            this.tables_add_columnNames_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tables_add_columnNames_label.Location = new System.Drawing.Point(241, 150);
            this.tables_add_columnNames_label.Name = "tables_add_columnNames_label";
            this.tables_add_columnNames_label.Size = new System.Drawing.Size(124, 20);
            this.tables_add_columnNames_label.TabIndex = 7;
            this.tables_add_columnNames_label.Text = "Column Names";
            // 
            // tables_add_columnNames_textBox
            // 
            this.tables_add_columnNames_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tables_add_columnNames_textBox.Location = new System.Drawing.Point(237, 174);
            this.tables_add_columnNames_textBox.Name = "tables_add_columnNames_textBox";
            this.tables_add_columnNames_textBox.Size = new System.Drawing.Size(133, 26);
            this.tables_add_columnNames_textBox.TabIndex = 8;
            // 
            // tables_add_addColumnNames_button
            // 
            this.tables_add_addColumnNames_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tables_add_addColumnNames_button.Location = new System.Drawing.Point(237, 228);
            this.tables_add_addColumnNames_button.Name = "tables_add_addColumnNames_button";
            this.tables_add_addColumnNames_button.Size = new System.Drawing.Size(133, 28);
            this.tables_add_addColumnNames_button.TabIndex = 9;
            this.tables_add_addColumnNames_button.Text = "Add";
            this.tables_add_addColumnNames_button.UseVisualStyleBackColor = true;
            this.tables_add_addColumnNames_button.Click += new System.EventHandler(this.tables_add_addColumnNames_button_Click);
            // 
            // tables_add_removeColumnNames_button
            // 
            this.tables_add_removeColumnNames_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tables_add_removeColumnNames_button.Location = new System.Drawing.Point(237, 262);
            this.tables_add_removeColumnNames_button.Name = "tables_add_removeColumnNames_button";
            this.tables_add_removeColumnNames_button.Size = new System.Drawing.Size(133, 28);
            this.tables_add_removeColumnNames_button.TabIndex = 10;
            this.tables_add_removeColumnNames_button.Text = "Remove";
            this.tables_add_removeColumnNames_button.UseVisualStyleBackColor = true;
            this.tables_add_removeColumnNames_button.Click += new System.EventHandler(this.tables_add_removeColumnNames_button_Click);
            // 
            // tables_add_removeValueType_button
            // 
            this.tables_add_removeValueType_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tables_add_removeValueType_button.Location = new System.Drawing.Point(612, 262);
            this.tables_add_removeValueType_button.Name = "tables_add_removeValueType_button";
            this.tables_add_removeValueType_button.Size = new System.Drawing.Size(133, 28);
            this.tables_add_removeValueType_button.TabIndex = 15;
            this.tables_add_removeValueType_button.Text = "Remove";
            this.tables_add_removeValueType_button.UseVisualStyleBackColor = true;
            this.tables_add_removeValueType_button.Click += new System.EventHandler(this.tables_add_removeValueType_button_Click);
            // 
            // tables_add_addValueType_button
            // 
            this.tables_add_addValueType_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tables_add_addValueType_button.Location = new System.Drawing.Point(612, 228);
            this.tables_add_addValueType_button.Name = "tables_add_addValueType_button";
            this.tables_add_addValueType_button.Size = new System.Drawing.Size(133, 28);
            this.tables_add_addValueType_button.TabIndex = 14;
            this.tables_add_addValueType_button.Text = "Add";
            this.tables_add_addValueType_button.UseVisualStyleBackColor = true;
            this.tables_add_addValueType_button.Click += new System.EventHandler(this.tables_add_addValueType_button_Click);
            // 
            // tables_add_valueTypes_label
            // 
            this.tables_add_valueTypes_label.AutoSize = true;
            this.tables_add_valueTypes_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tables_add_valueTypes_label.Location = new System.Drawing.Point(631, 149);
            this.tables_add_valueTypes_label.Name = "tables_add_valueTypes_label";
            this.tables_add_valueTypes_label.Size = new System.Drawing.Size(101, 20);
            this.tables_add_valueTypes_label.TabIndex = 12;
            this.tables_add_valueTypes_label.Text = "Value Types";
            // 
            // tables_add_valueTypes_listBox
            // 
            this.tables_add_valueTypes_listBox.FormattingEnabled = true;
            this.tables_add_valueTypes_listBox.ItemHeight = 16;
            this.tables_add_valueTypes_listBox.Location = new System.Drawing.Point(759, 150);
            this.tables_add_valueTypes_listBox.Name = "tables_add_valueTypes_listBox";
            this.tables_add_valueTypes_listBox.Size = new System.Drawing.Size(142, 196);
            this.tables_add_valueTypes_listBox.TabIndex = 11;
            // 
            // tables_add_tip_label
            // 
            this.tables_add_tip_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tables_add_tip_label.Location = new System.Drawing.Point(24, 86);
            this.tables_add_tip_label.Name = "tables_add_tip_label";
            this.tables_add_tip_label.Size = new System.Drawing.Size(207, 253);
            this.tables_add_tip_label.TabIndex = 17;
            this.tables_add_tip_label.Text = "Please add columns and values in the desired order. The first column will be pair" +
    "ed with the first value type, and so on.\r\n\r\nDo not add an \"ID\" column. This is h" +
    "andled automatically.";
            // 
            // tables_add_addValueType_comboBox
            // 
            this.tables_add_addValueType_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tables_add_addValueType_comboBox.FormattingEnabled = true;
            this.tables_add_addValueType_comboBox.Items.AddRange(new object[] {
            "CHAR",
            "VARCHAR",
            "TEXT",
            "BOOLEAN",
            "INT",
            "FLOAT",
            "DECIMAL",
            "DATE",
            "DATETIME",
            "TIMESTAMP"});
            this.tables_add_addValueType_comboBox.Location = new System.Drawing.Point(612, 172);
            this.tables_add_addValueType_comboBox.Name = "tables_add_addValueType_comboBox";
            this.tables_add_addValueType_comboBox.Size = new System.Drawing.Size(133, 28);
            this.tables_add_addValueType_comboBox.TabIndex = 18;
            // 
            // tables_add_addTable_button
            // 
            this.tables_add_addTable_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tables_add_addTable_button.Location = new System.Drawing.Point(375, 43);
            this.tables_add_addTable_button.Name = "tables_add_addTable_button";
            this.tables_add_addTable_button.Size = new System.Drawing.Size(97, 38);
            this.tables_add_addTable_button.TabIndex = 19;
            this.tables_add_addTable_button.Text = "Add Table";
            this.tables_add_addTable_button.UseVisualStyleBackColor = true;
            this.tables_add_addTable_button.Click += new System.EventHandler(this.tables_add_addTable_button_Click);
            // 
            // tables_add_panel
            // 
            this.tables_add_panel.Controls.Add(this.tables_add_addTable_button);
            this.tables_add_panel.Controls.Add(this.tables_add_tip_label);
            this.tables_add_panel.Controls.Add(this.tables_add_removeColumnNames_button);
            this.tables_add_panel.Controls.Add(this.tables_add_addValueType_comboBox);
            this.tables_add_panel.Controls.Add(this.tables_add_addColumnNames_button);
            this.tables_add_panel.Controls.Add(this.tables_add_valueTypes_listBox);
            this.tables_add_panel.Controls.Add(this.tables_add_columnNames_textBox);
            this.tables_add_panel.Controls.Add(this.tables_add_tableName_label);
            this.tables_add_panel.Controls.Add(this.tables_add_columnNames_label);
            this.tables_add_panel.Controls.Add(this.tables_add_removeValueType_button);
            this.tables_add_panel.Controls.Add(this.tables_add_tableName_textBox);
            this.tables_add_panel.Controls.Add(this.tables_add_columnNames_listBox);
            this.tables_add_panel.Controls.Add(this.tables_add_addValueType_button);
            this.tables_add_panel.Controls.Add(this.tables_add_valueTypes_label);
            this.tables_add_panel.Location = new System.Drawing.Point(235, 62);
            this.tables_add_panel.Name = "tables_add_panel";
            this.tables_add_panel.Size = new System.Drawing.Size(920, 360);
            this.tables_add_panel.TabIndex = 20;
            // 
            // tables_delete_panel
            // 
            this.tables_delete_panel.Controls.Add(this.tables_delete_button);
            this.tables_delete_panel.Controls.Add(this.tables_delete_label);
            this.tables_delete_panel.Location = new System.Drawing.Point(235, 62);
            this.tables_delete_panel.Name = "tables_delete_panel";
            this.tables_delete_panel.Size = new System.Drawing.Size(920, 360);
            this.tables_delete_panel.TabIndex = 20;
            // 
            // tables_delete_button
            // 
            this.tables_delete_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tables_delete_button.Location = new System.Drawing.Point(692, 138);
            this.tables_delete_button.Name = "tables_delete_button";
            this.tables_delete_button.Size = new System.Drawing.Size(189, 62);
            this.tables_delete_button.TabIndex = 1;
            this.tables_delete_button.Text = "DROP TABLE";
            this.tables_delete_button.UseVisualStyleBackColor = true;
            this.tables_delete_button.Click += new System.EventHandler(this.tables_delete_button_Click);
            // 
            // tables_delete_label
            // 
            this.tables_delete_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tables_delete_label.Location = new System.Drawing.Point(22, 33);
            this.tables_delete_label.Name = "tables_delete_label";
            this.tables_delete_label.Size = new System.Drawing.Size(248, 273);
            this.tables_delete_label.TabIndex = 0;
            this.tables_delete_label.Text = "Please beware! There is no confirmation for this.\r\n\r\nSelect a table from the list" +
    " on the left, then you may click the delete button.\r\n\r\nThis may cause irreversib" +
    "le loss of data. Use this tool wisely.";
            // 
            // columns_addColumn_panel
            // 
            this.columns_addColumn_panel.Controls.Add(this.columns_add_columnTableNote_label);
            this.columns_addColumn_panel.Controls.Add(this.columns_add_column_button);
            this.columns_addColumn_panel.Controls.Add(this.columns_add_columnColumnNote_label);
            this.columns_addColumn_panel.Controls.Add(this.columns_add_removeColumn_button);
            this.columns_addColumn_panel.Controls.Add(this.columns_add_valueTypes_comboBox);
            this.columns_addColumn_panel.Controls.Add(this.columns_add_addColumn_button);
            this.columns_addColumn_panel.Controls.Add(this.columns_add_valueTypes_listBox);
            this.columns_addColumn_panel.Controls.Add(this.columns_add_columnName_textBox);
            this.columns_addColumn_panel.Controls.Add(this.columns_add_columnNames_label);
            this.columns_addColumn_panel.Controls.Add(this.columns_add_removeValueType_button);
            this.columns_addColumn_panel.Controls.Add(this.columns_add_columnNames_listBox);
            this.columns_addColumn_panel.Controls.Add(this.columns_add_addValueType_button);
            this.columns_addColumn_panel.Controls.Add(this.columns_add_valueTypes_label);
            this.columns_addColumn_panel.Location = new System.Drawing.Point(235, 62);
            this.columns_addColumn_panel.Name = "columns_addColumn_panel";
            this.columns_addColumn_panel.Size = new System.Drawing.Size(918, 358);
            this.columns_addColumn_panel.TabIndex = 21;
            // 
            // columns_add_columnTableNote_label
            // 
            this.columns_add_columnTableNote_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columns_add_columnTableNote_label.Location = new System.Drawing.Point(19, 42);
            this.columns_add_columnTableNote_label.Name = "columns_add_columnTableNote_label";
            this.columns_add_columnTableNote_label.Size = new System.Drawing.Size(166, 54);
            this.columns_add_columnTableNote_label.TabIndex = 20;
            this.columns_add_columnTableNote_label.Text = "Select a table from the list on the left";
            // 
            // columns_add_column_button
            // 
            this.columns_add_column_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columns_add_column_button.Location = new System.Drawing.Point(217, 48);
            this.columns_add_column_button.Name = "columns_add_column_button";
            this.columns_add_column_button.Size = new System.Drawing.Size(153, 38);
            this.columns_add_column_button.TabIndex = 19;
            this.columns_add_column_button.Text = "Add Column(s)";
            this.columns_add_column_button.UseVisualStyleBackColor = true;
            this.columns_add_column_button.Click += new System.EventHandler(this.columns_add_column_button_Click);
            // 
            // columns_add_columnColumnNote_label
            // 
            this.columns_add_columnColumnNote_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columns_add_columnColumnNote_label.Location = new System.Drawing.Point(20, 140);
            this.columns_add_columnColumnNote_label.Name = "columns_add_columnColumnNote_label";
            this.columns_add_columnColumnNote_label.Size = new System.Drawing.Size(142, 196);
            this.columns_add_columnColumnNote_label.TabIndex = 17;
            this.columns_add_columnColumnNote_label.Text = "Please add columns and values in the desired order. The first column will be pair" +
    "ed with the first value type, and so on.";
            // 
            // columns_add_removeColumn_button
            // 
            this.columns_add_removeColumn_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columns_add_removeColumn_button.Location = new System.Drawing.Point(217, 262);
            this.columns_add_removeColumn_button.Name = "columns_add_removeColumn_button";
            this.columns_add_removeColumn_button.Size = new System.Drawing.Size(133, 28);
            this.columns_add_removeColumn_button.TabIndex = 10;
            this.columns_add_removeColumn_button.Text = "Remove";
            this.columns_add_removeColumn_button.UseVisualStyleBackColor = true;
            this.columns_add_removeColumn_button.Click += new System.EventHandler(this.columns_add_removeColumn_button_Click);
            // 
            // columns_add_valueTypes_comboBox
            // 
            this.columns_add_valueTypes_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columns_add_valueTypes_comboBox.FormattingEnabled = true;
            this.columns_add_valueTypes_comboBox.Items.AddRange(new object[] {
            "CHAR",
            "VARCHAR",
            "TEXT",
            "BOOLEAN",
            "INT",
            "FLOAT",
            "DECIMAL",
            "DATE",
            "DATETIME",
            "TIMESTAMP"});
            this.columns_add_valueTypes_comboBox.Location = new System.Drawing.Point(592, 172);
            this.columns_add_valueTypes_comboBox.Name = "columns_add_valueTypes_comboBox";
            this.columns_add_valueTypes_comboBox.Size = new System.Drawing.Size(133, 28);
            this.columns_add_valueTypes_comboBox.TabIndex = 18;
            // 
            // columns_add_addColumn_button
            // 
            this.columns_add_addColumn_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columns_add_addColumn_button.Location = new System.Drawing.Point(217, 228);
            this.columns_add_addColumn_button.Name = "columns_add_addColumn_button";
            this.columns_add_addColumn_button.Size = new System.Drawing.Size(133, 28);
            this.columns_add_addColumn_button.TabIndex = 9;
            this.columns_add_addColumn_button.Text = "Add";
            this.columns_add_addColumn_button.UseVisualStyleBackColor = true;
            this.columns_add_addColumn_button.Click += new System.EventHandler(this.columns_add_addColumn_button_Click);
            // 
            // columns_add_valueTypes_listBox
            // 
            this.columns_add_valueTypes_listBox.FormattingEnabled = true;
            this.columns_add_valueTypes_listBox.ItemHeight = 16;
            this.columns_add_valueTypes_listBox.Location = new System.Drawing.Point(739, 150);
            this.columns_add_valueTypes_listBox.Name = "columns_add_valueTypes_listBox";
            this.columns_add_valueTypes_listBox.Size = new System.Drawing.Size(142, 196);
            this.columns_add_valueTypes_listBox.TabIndex = 11;
            // 
            // columns_add_columnName_textBox
            // 
            this.columns_add_columnName_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columns_add_columnName_textBox.Location = new System.Drawing.Point(217, 174);
            this.columns_add_columnName_textBox.Name = "columns_add_columnName_textBox";
            this.columns_add_columnName_textBox.Size = new System.Drawing.Size(133, 26);
            this.columns_add_columnName_textBox.TabIndex = 8;
            // 
            // columns_add_columnNames_label
            // 
            this.columns_add_columnNames_label.AutoSize = true;
            this.columns_add_columnNames_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columns_add_columnNames_label.Location = new System.Drawing.Point(221, 150);
            this.columns_add_columnNames_label.Name = "columns_add_columnNames_label";
            this.columns_add_columnNames_label.Size = new System.Drawing.Size(124, 20);
            this.columns_add_columnNames_label.TabIndex = 7;
            this.columns_add_columnNames_label.Text = "Column Names";
            // 
            // columns_add_removeValueType_button
            // 
            this.columns_add_removeValueType_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columns_add_removeValueType_button.Location = new System.Drawing.Point(592, 262);
            this.columns_add_removeValueType_button.Name = "columns_add_removeValueType_button";
            this.columns_add_removeValueType_button.Size = new System.Drawing.Size(133, 28);
            this.columns_add_removeValueType_button.TabIndex = 15;
            this.columns_add_removeValueType_button.Text = "Remove";
            this.columns_add_removeValueType_button.UseVisualStyleBackColor = true;
            this.columns_add_removeValueType_button.Click += new System.EventHandler(this.columns_add_removeValueType_button_Click);
            // 
            // columns_add_columnNames_listBox
            // 
            this.columns_add_columnNames_listBox.FormattingEnabled = true;
            this.columns_add_columnNames_listBox.ItemHeight = 16;
            this.columns_add_columnNames_listBox.Location = new System.Drawing.Point(364, 149);
            this.columns_add_columnNames_listBox.Name = "columns_add_columnNames_listBox";
            this.columns_add_columnNames_listBox.Size = new System.Drawing.Size(142, 196);
            this.columns_add_columnNames_listBox.TabIndex = 6;
            // 
            // columns_add_addValueType_button
            // 
            this.columns_add_addValueType_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columns_add_addValueType_button.Location = new System.Drawing.Point(592, 228);
            this.columns_add_addValueType_button.Name = "columns_add_addValueType_button";
            this.columns_add_addValueType_button.Size = new System.Drawing.Size(133, 28);
            this.columns_add_addValueType_button.TabIndex = 14;
            this.columns_add_addValueType_button.Text = "Add";
            this.columns_add_addValueType_button.UseVisualStyleBackColor = true;
            this.columns_add_addValueType_button.Click += new System.EventHandler(this.columns_add_addValueType_button_Click);
            // 
            // columns_add_valueTypes_label
            // 
            this.columns_add_valueTypes_label.AutoSize = true;
            this.columns_add_valueTypes_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columns_add_valueTypes_label.Location = new System.Drawing.Point(611, 149);
            this.columns_add_valueTypes_label.Name = "columns_add_valueTypes_label";
            this.columns_add_valueTypes_label.Size = new System.Drawing.Size(101, 20);
            this.columns_add_valueTypes_label.TabIndex = 12;
            this.columns_add_valueTypes_label.Text = "Value Types";
            // 
            // tables_rename_panel
            // 
            this.tables_rename_panel.Controls.Add(this.tables_rename_newName_button);
            this.tables_rename_panel.Controls.Add(this.tables_rename_newName_textbox);
            this.tables_rename_panel.Controls.Add(this.tables_rename_newName_label);
            this.tables_rename_panel.Controls.Add(this.tables_rename_toolTip_label);
            this.tables_rename_panel.Location = new System.Drawing.Point(235, 62);
            this.tables_rename_panel.Name = "tables_rename_panel";
            this.tables_rename_panel.Size = new System.Drawing.Size(920, 360);
            this.tables_rename_panel.TabIndex = 21;
            // 
            // tables_rename_newName_button
            // 
            this.tables_rename_newName_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tables_rename_newName_button.Location = new System.Drawing.Point(204, 231);
            this.tables_rename_newName_button.Name = "tables_rename_newName_button";
            this.tables_rename_newName_button.Size = new System.Drawing.Size(108, 32);
            this.tables_rename_newName_button.TabIndex = 3;
            this.tables_rename_newName_button.Text = "Rename";
            this.tables_rename_newName_button.UseVisualStyleBackColor = true;
            this.tables_rename_newName_button.Click += new System.EventHandler(this.tables_rename_newName_button_Click);
            // 
            // tables_rename_newName_textbox
            // 
            this.tables_rename_newName_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tables_rename_newName_textbox.Location = new System.Drawing.Point(26, 234);
            this.tables_rename_newName_textbox.Name = "tables_rename_newName_textbox";
            this.tables_rename_newName_textbox.Size = new System.Drawing.Size(172, 26);
            this.tables_rename_newName_textbox.TabIndex = 2;
            // 
            // tables_rename_newName_label
            // 
            this.tables_rename_newName_label.AutoSize = true;
            this.tables_rename_newName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tables_rename_newName_label.Location = new System.Drawing.Point(22, 210);
            this.tables_rename_newName_label.Name = "tables_rename_newName_label";
            this.tables_rename_newName_label.Size = new System.Drawing.Size(93, 20);
            this.tables_rename_newName_label.TabIndex = 1;
            this.tables_rename_newName_label.Text = "New name:";
            // 
            // tables_rename_toolTip_label
            // 
            this.tables_rename_toolTip_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tables_rename_toolTip_label.Location = new System.Drawing.Point(25, 33);
            this.tables_rename_toolTip_label.Name = "tables_rename_toolTip_label";
            this.tables_rename_toolTip_label.Size = new System.Drawing.Size(206, 162);
            this.tables_rename_toolTip_label.TabIndex = 0;
            this.tables_rename_toolTip_label.Text = "Select a table on the left to be renamed, then rename it using the interface belo" +
    "w";
            // 
            // dash_columns_label
            // 
            this.dash_columns_label.AutoSize = true;
            this.dash_columns_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dash_columns_label.Location = new System.Drawing.Point(12, 398);
            this.dash_columns_label.Name = "dash_columns_label";
            this.dash_columns_label.Size = new System.Drawing.Size(96, 25);
            this.dash_columns_label.TabIndex = 23;
            this.dash_columns_label.Text = "Columns:";
            // 
            // dash_columns_listBox
            // 
            this.dash_columns_listBox.FormattingEnabled = true;
            this.dash_columns_listBox.ItemHeight = 16;
            this.dash_columns_listBox.Location = new System.Drawing.Point(12, 430);
            this.dash_columns_listBox.Name = "dash_columns_listBox";
            this.dash_columns_listBox.Size = new System.Drawing.Size(202, 292);
            this.dash_columns_listBox.TabIndex = 22;
            // 
            // columns_rename_panel
            // 
            this.columns_rename_panel.Controls.Add(this.columns_rename_newName_button);
            this.columns_rename_panel.Controls.Add(this.columns_rename_newName_textbox);
            this.columns_rename_panel.Controls.Add(this.columns_rename_newName_label);
            this.columns_rename_panel.Controls.Add(this.columns_rename_toolTip_label);
            this.columns_rename_panel.Location = new System.Drawing.Point(235, 62);
            this.columns_rename_panel.Name = "columns_rename_panel";
            this.columns_rename_panel.Size = new System.Drawing.Size(920, 360);
            this.columns_rename_panel.TabIndex = 24;
            // 
            // columns_rename_newName_button
            // 
            this.columns_rename_newName_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columns_rename_newName_button.Location = new System.Drawing.Point(204, 247);
            this.columns_rename_newName_button.Name = "columns_rename_newName_button";
            this.columns_rename_newName_button.Size = new System.Drawing.Size(108, 33);
            this.columns_rename_newName_button.TabIndex = 3;
            this.columns_rename_newName_button.Text = "Rename";
            this.columns_rename_newName_button.UseVisualStyleBackColor = true;
            this.columns_rename_newName_button.Click += new System.EventHandler(this.columns_rename_newName_button_Click);
            // 
            // columns_rename_newName_textbox
            // 
            this.columns_rename_newName_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columns_rename_newName_textbox.Location = new System.Drawing.Point(26, 250);
            this.columns_rename_newName_textbox.Name = "columns_rename_newName_textbox";
            this.columns_rename_newName_textbox.Size = new System.Drawing.Size(172, 26);
            this.columns_rename_newName_textbox.TabIndex = 2;
            // 
            // columns_rename_newName_label
            // 
            this.columns_rename_newName_label.AutoSize = true;
            this.columns_rename_newName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columns_rename_newName_label.Location = new System.Drawing.Point(22, 226);
            this.columns_rename_newName_label.Name = "columns_rename_newName_label";
            this.columns_rename_newName_label.Size = new System.Drawing.Size(93, 20);
            this.columns_rename_newName_label.TabIndex = 1;
            this.columns_rename_newName_label.Text = "New name:";
            // 
            // columns_rename_toolTip_label
            // 
            this.columns_rename_toolTip_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columns_rename_toolTip_label.Location = new System.Drawing.Point(25, 33);
            this.columns_rename_toolTip_label.Name = "columns_rename_toolTip_label";
            this.columns_rename_toolTip_label.Size = new System.Drawing.Size(206, 162);
            this.columns_rename_toolTip_label.TabIndex = 0;
            this.columns_rename_toolTip_label.Text = "Select a table on the left, then a column to be renamed, then rename it using the" +
    " interface below";
            // 
            // columns_remove_panel
            // 
            this.columns_remove_panel.Controls.Add(this.columns_remove_removeColumn_button);
            this.columns_remove_panel.Controls.Add(this.columns_remove_toolTip_label);
            this.columns_remove_panel.Location = new System.Drawing.Point(235, 62);
            this.columns_remove_panel.Name = "columns_remove_panel";
            this.columns_remove_panel.Size = new System.Drawing.Size(920, 360);
            this.columns_remove_panel.TabIndex = 25;
            // 
            // columns_remove_removeColumn_button
            // 
            this.columns_remove_removeColumn_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columns_remove_removeColumn_button.Location = new System.Drawing.Point(683, 137);
            this.columns_remove_removeColumn_button.Name = "columns_remove_removeColumn_button";
            this.columns_remove_removeColumn_button.Size = new System.Drawing.Size(189, 62);
            this.columns_remove_removeColumn_button.TabIndex = 1;
            this.columns_remove_removeColumn_button.Text = "DROP COLUMN";
            this.columns_remove_removeColumn_button.UseVisualStyleBackColor = true;
            this.columns_remove_removeColumn_button.Click += new System.EventHandler(this.columns_remove_removeColumn_button_Click);
            // 
            // columns_remove_toolTip_label
            // 
            this.columns_remove_toolTip_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columns_remove_toolTip_label.Location = new System.Drawing.Point(24, 57);
            this.columns_remove_toolTip_label.Name = "columns_remove_toolTip_label";
            this.columns_remove_toolTip_label.Size = new System.Drawing.Size(220, 224);
            this.columns_remove_toolTip_label.TabIndex = 0;
            this.columns_remove_toolTip_label.Text = "Please beware! There is no confirmation for this.\r\n\r\nDropping a column can cause " +
    "irreversible data loss.\r\n\r\nSelect a table, then a column from the left, then cli" +
    "ck the button to the right\r\n";
            // 
            // columns_dataType_panel
            // 
            this.columns_dataType_panel.Controls.Add(this.columns_dataType_changeType_button);
            this.columns_dataType_panel.Controls.Add(this.columns_dataType_toolTip_label);
            this.columns_dataType_panel.Controls.Add(this.columns_dataType_valueTypes_comboBox);
            this.columns_dataType_panel.Controls.Add(this.columns_dataType_valueTypes_label);
            this.columns_dataType_panel.Location = new System.Drawing.Point(235, 62);
            this.columns_dataType_panel.Name = "columns_dataType_panel";
            this.columns_dataType_panel.Size = new System.Drawing.Size(920, 360);
            this.columns_dataType_panel.TabIndex = 26;
            // 
            // columns_dataType_changeType_button
            // 
            this.columns_dataType_changeType_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columns_dataType_changeType_button.Location = new System.Drawing.Point(683, 186);
            this.columns_dataType_changeType_button.Name = "columns_dataType_changeType_button";
            this.columns_dataType_changeType_button.Size = new System.Drawing.Size(133, 34);
            this.columns_dataType_changeType_button.TabIndex = 22;
            this.columns_dataType_changeType_button.Text = "Change Type";
            this.columns_dataType_changeType_button.UseVisualStyleBackColor = true;
            this.columns_dataType_changeType_button.Click += new System.EventHandler(this.columns_dataType_changeType_button_Click);
            // 
            // columns_dataType_toolTip_label
            // 
            this.columns_dataType_toolTip_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columns_dataType_toolTip_label.Location = new System.Drawing.Point(19, 23);
            this.columns_dataType_toolTip_label.Name = "columns_dataType_toolTip_label";
            this.columns_dataType_toolTip_label.Size = new System.Drawing.Size(359, 305);
            this.columns_dataType_toolTip_label.TabIndex = 21;
            this.columns_dataType_toolTip_label.Text = resources.GetString("columns_dataType_toolTip_label.Text");
            // 
            // columns_dataType_valueTypes_comboBox
            // 
            this.columns_dataType_valueTypes_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columns_dataType_valueTypes_comboBox.FormattingEnabled = true;
            this.columns_dataType_valueTypes_comboBox.Items.AddRange(new object[] {
            "CHAR",
            "VARCHAR",
            "TEXT",
            "BOOLEAN",
            "INT",
            "FLOAT",
            "DECIMAL",
            "DATE",
            "DATETIME",
            "TIMESTAMP"});
            this.columns_dataType_valueTypes_comboBox.Location = new System.Drawing.Point(683, 136);
            this.columns_dataType_valueTypes_comboBox.Name = "columns_dataType_valueTypes_comboBox";
            this.columns_dataType_valueTypes_comboBox.Size = new System.Drawing.Size(133, 28);
            this.columns_dataType_valueTypes_comboBox.TabIndex = 20;
            // 
            // columns_dataType_valueTypes_label
            // 
            this.columns_dataType_valueTypes_label.AutoSize = true;
            this.columns_dataType_valueTypes_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columns_dataType_valueTypes_label.Location = new System.Drawing.Point(699, 113);
            this.columns_dataType_valueTypes_label.Name = "columns_dataType_valueTypes_label";
            this.columns_dataType_valueTypes_label.Size = new System.Drawing.Size(101, 20);
            this.columns_dataType_valueTypes_label.TabIndex = 19;
            this.columns_dataType_valueTypes_label.Text = "Value Types";
            // 
            // columns_addConstraint_panel
            // 
            this.columns_addConstraint_panel.Controls.Add(this.columns_addConstraint_add_button);
            this.columns_addConstraint_panel.Controls.Add(this.columns_addConstraint_references_column_label);
            this.columns_addConstraint_panel.Controls.Add(this.columns_addConstraint_references_table_label);
            this.columns_addConstraint_panel.Controls.Add(this.columns_addConstraint_check_value_label);
            this.columns_addConstraint_panel.Controls.Add(this.columns_addConstraint_check_operators_label);
            this.columns_addConstraint_panel.Controls.Add(this.columns_addConstraint_check_column_label);
            this.columns_addConstraint_panel.Controls.Add(this.columns_addConstraint_check_checkName_label);
            this.columns_addConstraint_panel.Controls.Add(this.columns_addConstraint_check_value_textBox);
            this.columns_addConstraint_panel.Controls.Add(this.columns_addConstraint_check_operators_comboBox);
            this.columns_addConstraint_panel.Controls.Add(this.columns_addConstraint_check_columns_comboBox);
            this.columns_addConstraint_panel.Controls.Add(this.columns_addConstraint_check_checkName_textBox);
            this.columns_addConstraint_panel.Controls.Add(this.columns_addConstraint_references_column_comboBox);
            this.columns_addConstraint_panel.Controls.Add(this.columns_addConstraint_references_table_comboBox);
            this.columns_addConstraint_panel.Controls.Add(this.label1);
            this.columns_addConstraint_panel.Controls.Add(this.columns_addConstraint_check_checkBox);
            this.columns_addConstraint_panel.Controls.Add(this.columns_addConstraint_references_checkBox);
            this.columns_addConstraint_panel.Controls.Add(this.columns_addConstraint_notNull_checkBox);
            this.columns_addConstraint_panel.Controls.Add(this.columns_addConstraint_unique_checkBox);
            this.columns_addConstraint_panel.Location = new System.Drawing.Point(235, 62);
            this.columns_addConstraint_panel.Name = "columns_addConstraint_panel";
            this.columns_addConstraint_panel.Size = new System.Drawing.Size(920, 360);
            this.columns_addConstraint_panel.TabIndex = 27;
            // 
            // columns_addConstraint_add_button
            // 
            this.columns_addConstraint_add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columns_addConstraint_add_button.Location = new System.Drawing.Point(713, 296);
            this.columns_addConstraint_add_button.Name = "columns_addConstraint_add_button";
            this.columns_addConstraint_add_button.Size = new System.Drawing.Size(159, 40);
            this.columns_addConstraint_add_button.TabIndex = 17;
            this.columns_addConstraint_add_button.Text = "Add Constraint";
            this.columns_addConstraint_add_button.UseVisualStyleBackColor = true;
            this.columns_addConstraint_add_button.Click += new System.EventHandler(this.columns_addConstraint_add_button_Click);
            // 
            // columns_addConstraint_references_column_label
            // 
            this.columns_addConstraint_references_column_label.AutoSize = true;
            this.columns_addConstraint_references_column_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columns_addConstraint_references_column_label.Location = new System.Drawing.Point(699, 118);
            this.columns_addConstraint_references_column_label.Name = "columns_addConstraint_references_column_label";
            this.columns_addConstraint_references_column_label.Size = new System.Drawing.Size(66, 20);
            this.columns_addConstraint_references_column_label.TabIndex = 16;
            this.columns_addConstraint_references_column_label.Text = "Column";
            // 
            // columns_addConstraint_references_table_label
            // 
            this.columns_addConstraint_references_table_label.AutoSize = true;
            this.columns_addConstraint_references_table_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columns_addConstraint_references_table_label.Location = new System.Drawing.Point(527, 119);
            this.columns_addConstraint_references_table_label.Name = "columns_addConstraint_references_table_label";
            this.columns_addConstraint_references_table_label.Size = new System.Drawing.Size(50, 20);
            this.columns_addConstraint_references_table_label.TabIndex = 15;
            this.columns_addConstraint_references_table_label.Text = "Table";
            // 
            // columns_addConstraint_check_value_label
            // 
            this.columns_addConstraint_check_value_label.AutoSize = true;
            this.columns_addConstraint_check_value_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columns_addConstraint_check_value_label.Location = new System.Drawing.Point(782, 232);
            this.columns_addConstraint_check_value_label.Name = "columns_addConstraint_check_value_label";
            this.columns_addConstraint_check_value_label.Size = new System.Drawing.Size(51, 20);
            this.columns_addConstraint_check_value_label.TabIndex = 14;
            this.columns_addConstraint_check_value_label.Text = "Value";
            // 
            // columns_addConstraint_check_operators_label
            // 
            this.columns_addConstraint_check_operators_label.AutoSize = true;
            this.columns_addConstraint_check_operators_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columns_addConstraint_check_operators_label.Location = new System.Drawing.Point(666, 232);
            this.columns_addConstraint_check_operators_label.Name = "columns_addConstraint_check_operators_label";
            this.columns_addConstraint_check_operators_label.Size = new System.Drawing.Size(75, 20);
            this.columns_addConstraint_check_operators_label.TabIndex = 13;
            this.columns_addConstraint_check_operators_label.Text = "Operator";
            // 
            // columns_addConstraint_check_column_label
            // 
            this.columns_addConstraint_check_column_label.AutoSize = true;
            this.columns_addConstraint_check_column_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columns_addConstraint_check_column_label.Location = new System.Drawing.Point(564, 232);
            this.columns_addConstraint_check_column_label.Name = "columns_addConstraint_check_column_label";
            this.columns_addConstraint_check_column_label.Size = new System.Drawing.Size(66, 20);
            this.columns_addConstraint_check_column_label.TabIndex = 12;
            this.columns_addConstraint_check_column_label.Text = "Column";
            // 
            // columns_addConstraint_check_checkName_label
            // 
            this.columns_addConstraint_check_checkName_label.AutoSize = true;
            this.columns_addConstraint_check_checkName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columns_addConstraint_check_checkName_label.Location = new System.Drawing.Point(405, 232);
            this.columns_addConstraint_check_checkName_label.Name = "columns_addConstraint_check_checkName_label";
            this.columns_addConstraint_check_checkName_label.Size = new System.Drawing.Size(102, 20);
            this.columns_addConstraint_check_checkName_label.TabIndex = 11;
            this.columns_addConstraint_check_checkName_label.Text = "Check name";
            // 
            // columns_addConstraint_check_value_textBox
            // 
            this.columns_addConstraint_check_value_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columns_addConstraint_check_value_textBox.Location = new System.Drawing.Point(759, 199);
            this.columns_addConstraint_check_value_textBox.Name = "columns_addConstraint_check_value_textBox";
            this.columns_addConstraint_check_value_textBox.Size = new System.Drawing.Size(100, 26);
            this.columns_addConstraint_check_value_textBox.TabIndex = 10;
            // 
            // columns_addConstraint_check_operators_comboBox
            // 
            this.columns_addConstraint_check_operators_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columns_addConstraint_check_operators_comboBox.FormattingEnabled = true;
            this.columns_addConstraint_check_operators_comboBox.Items.AddRange(new object[] {
            "=",
            "!=",
            "<",
            "<=",
            ">",
            ">="});
            this.columns_addConstraint_check_operators_comboBox.Location = new System.Drawing.Point(679, 198);
            this.columns_addConstraint_check_operators_comboBox.Name = "columns_addConstraint_check_operators_comboBox";
            this.columns_addConstraint_check_operators_comboBox.Size = new System.Drawing.Size(46, 28);
            this.columns_addConstraint_check_operators_comboBox.TabIndex = 9;
            // 
            // columns_addConstraint_check_columns_comboBox
            // 
            this.columns_addConstraint_check_columns_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columns_addConstraint_check_columns_comboBox.FormattingEnabled = true;
            this.columns_addConstraint_check_columns_comboBox.Location = new System.Drawing.Point(537, 198);
            this.columns_addConstraint_check_columns_comboBox.Name = "columns_addConstraint_check_columns_comboBox";
            this.columns_addConstraint_check_columns_comboBox.Size = new System.Drawing.Size(121, 28);
            this.columns_addConstraint_check_columns_comboBox.TabIndex = 8;
            // 
            // columns_addConstraint_check_checkName_textBox
            // 
            this.columns_addConstraint_check_checkName_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columns_addConstraint_check_checkName_textBox.Location = new System.Drawing.Point(405, 198);
            this.columns_addConstraint_check_checkName_textBox.Name = "columns_addConstraint_check_checkName_textBox";
            this.columns_addConstraint_check_checkName_textBox.Size = new System.Drawing.Size(100, 26);
            this.columns_addConstraint_check_checkName_textBox.TabIndex = 7;
            // 
            // columns_addConstraint_references_column_comboBox
            // 
            this.columns_addConstraint_references_column_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columns_addConstraint_references_column_comboBox.FormattingEnabled = true;
            this.columns_addConstraint_references_column_comboBox.Location = new System.Drawing.Point(675, 142);
            this.columns_addConstraint_references_column_comboBox.Name = "columns_addConstraint_references_column_comboBox";
            this.columns_addConstraint_references_column_comboBox.Size = new System.Drawing.Size(121, 28);
            this.columns_addConstraint_references_column_comboBox.TabIndex = 6;
            // 
            // columns_addConstraint_references_table_comboBox
            // 
            this.columns_addConstraint_references_table_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columns_addConstraint_references_table_comboBox.FormattingEnabled = true;
            this.columns_addConstraint_references_table_comboBox.Location = new System.Drawing.Point(453, 141);
            this.columns_addConstraint_references_table_comboBox.Name = "columns_addConstraint_references_table_comboBox";
            this.columns_addConstraint_references_table_comboBox.Size = new System.Drawing.Size(196, 28);
            this.columns_addConstraint_references_table_comboBox.TabIndex = 5;
            this.columns_addConstraint_references_table_comboBox.SelectionChangeCommitted += new System.EventHandler(this.columns_addConstraint_references_table_comboBox_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 263);
            this.label1.TabIndex = 4;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // columns_addConstraint_check_checkBox
            // 
            this.columns_addConstraint_check_checkBox.AutoSize = true;
            this.columns_addConstraint_check_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columns_addConstraint_check_checkBox.Location = new System.Drawing.Point(320, 200);
            this.columns_addConstraint_check_checkBox.Name = "columns_addConstraint_check_checkBox";
            this.columns_addConstraint_check_checkBox.Size = new System.Drawing.Size(78, 24);
            this.columns_addConstraint_check_checkBox.TabIndex = 3;
            this.columns_addConstraint_check_checkBox.Text = "Check";
            this.columns_addConstraint_check_checkBox.UseVisualStyleBackColor = true;
            // 
            // columns_addConstraint_references_checkBox
            // 
            this.columns_addConstraint_references_checkBox.AutoSize = true;
            this.columns_addConstraint_references_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columns_addConstraint_references_checkBox.Location = new System.Drawing.Point(320, 145);
            this.columns_addConstraint_references_checkBox.Name = "columns_addConstraint_references_checkBox";
            this.columns_addConstraint_references_checkBox.Size = new System.Drawing.Size(117, 24);
            this.columns_addConstraint_references_checkBox.TabIndex = 2;
            this.columns_addConstraint_references_checkBox.Text = "References";
            this.columns_addConstraint_references_checkBox.UseVisualStyleBackColor = true;
            // 
            // columns_addConstraint_notNull_checkBox
            // 
            this.columns_addConstraint_notNull_checkBox.AutoSize = true;
            this.columns_addConstraint_notNull_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columns_addConstraint_notNull_checkBox.Location = new System.Drawing.Point(320, 90);
            this.columns_addConstraint_notNull_checkBox.Name = "columns_addConstraint_notNull_checkBox";
            this.columns_addConstraint_notNull_checkBox.Size = new System.Drawing.Size(88, 24);
            this.columns_addConstraint_notNull_checkBox.TabIndex = 1;
            this.columns_addConstraint_notNull_checkBox.Text = "Not null";
            this.columns_addConstraint_notNull_checkBox.UseVisualStyleBackColor = true;
            // 
            // columns_addConstraint_unique_checkBox
            // 
            this.columns_addConstraint_unique_checkBox.AutoSize = true;
            this.columns_addConstraint_unique_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columns_addConstraint_unique_checkBox.Location = new System.Drawing.Point(320, 50);
            this.columns_addConstraint_unique_checkBox.Name = "columns_addConstraint_unique_checkBox";
            this.columns_addConstraint_unique_checkBox.Size = new System.Drawing.Size(83, 24);
            this.columns_addConstraint_unique_checkBox.TabIndex = 0;
            this.columns_addConstraint_unique_checkBox.Text = "Unique";
            this.columns_addConstraint_unique_checkBox.UseVisualStyleBackColor = true;
            // 
            // columns_removeConstraint_panel
            // 
            this.columns_removeConstraint_panel.Controls.Add(this.columns_removeConstraint_remove_button);
            this.columns_removeConstraint_panel.Controls.Add(this.columns_removeConstraint_constraints_label);
            this.columns_removeConstraint_panel.Controls.Add(this.columns_removeConstraint_constraints_listBox);
            this.columns_removeConstraint_panel.Controls.Add(this.columns_removeConstraint_toolTip_label);
            this.columns_removeConstraint_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columns_removeConstraint_panel.Location = new System.Drawing.Point(235, 62);
            this.columns_removeConstraint_panel.Name = "columns_removeConstraint_panel";
            this.columns_removeConstraint_panel.Size = new System.Drawing.Size(920, 360);
            this.columns_removeConstraint_panel.TabIndex = 28;
            // 
            // columns_removeConstraint_remove_button
            // 
            this.columns_removeConstraint_remove_button.Location = new System.Drawing.Point(502, 145);
            this.columns_removeConstraint_remove_button.Name = "columns_removeConstraint_remove_button";
            this.columns_removeConstraint_remove_button.Size = new System.Drawing.Size(139, 45);
            this.columns_removeConstraint_remove_button.TabIndex = 3;
            this.columns_removeConstraint_remove_button.Text = "Drop Constraint";
            this.columns_removeConstraint_remove_button.UseVisualStyleBackColor = true;
            this.columns_removeConstraint_remove_button.Click += new System.EventHandler(this.columns_removeConstraint_remove_button_Click);
            // 
            // columns_removeConstraint_constraints_label
            // 
            this.columns_removeConstraint_constraints_label.AutoSize = true;
            this.columns_removeConstraint_constraints_label.Location = new System.Drawing.Point(304, 10);
            this.columns_removeConstraint_constraints_label.Name = "columns_removeConstraint_constraints_label";
            this.columns_removeConstraint_constraints_label.Size = new System.Drawing.Size(95, 20);
            this.columns_removeConstraint_constraints_label.TabIndex = 2;
            this.columns_removeConstraint_constraints_label.Text = "Constraints";
            // 
            // columns_removeConstraint_constraints_listBox
            // 
            this.columns_removeConstraint_constraints_listBox.FormattingEnabled = true;
            this.columns_removeConstraint_constraints_listBox.ItemHeight = 20;
            this.columns_removeConstraint_constraints_listBox.Location = new System.Drawing.Point(255, 33);
            this.columns_removeConstraint_constraints_listBox.Name = "columns_removeConstraint_constraints_listBox";
            this.columns_removeConstraint_constraints_listBox.Size = new System.Drawing.Size(202, 284);
            this.columns_removeConstraint_constraints_listBox.TabIndex = 1;
            // 
            // columns_removeConstraint_toolTip_label
            // 
            this.columns_removeConstraint_toolTip_label.Location = new System.Drawing.Point(18, 65);
            this.columns_removeConstraint_toolTip_label.Name = "columns_removeConstraint_toolTip_label";
            this.columns_removeConstraint_toolTip_label.Size = new System.Drawing.Size(215, 216);
            this.columns_removeConstraint_toolTip_label.TabIndex = 0;
            this.columns_removeConstraint_toolTip_label.Text = "Select a table from the left\r\n\r\nThat action will populate the list of constraints" +
    " present on the column on the right\r\n\r\nSelect a constraint and click the button " +
    "to drop it";
            // 
            // rows_add_panel
            // 
            this.rows_add_panel.Controls.Add(this.rows_add_rowValues_label);
            this.rows_add_panel.Controls.Add(this.rows_add_addRow_button);
            this.rows_add_panel.Controls.Add(this.rows_add_removeRowValue_button);
            this.rows_add_panel.Controls.Add(this.rows_add_addRowValue_button);
            this.rows_add_panel.Controls.Add(this.rows_add_rowValues_listBox);
            this.rows_add_panel.Controls.Add(this.rows_add_rowValue_textBox);
            this.rows_add_panel.Controls.Add(this.rows_add_rowValue_label);
            this.rows_add_panel.Controls.Add(this.rows_add_toolTip_label);
            this.rows_add_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rows_add_panel.Location = new System.Drawing.Point(235, 62);
            this.rows_add_panel.Name = "rows_add_panel";
            this.rows_add_panel.Size = new System.Drawing.Size(920, 360);
            this.rows_add_panel.TabIndex = 29;
            // 
            // rows_add_rowValues_label
            // 
            this.rows_add_rowValues_label.AutoSize = true;
            this.rows_add_rowValues_label.Location = new System.Drawing.Point(474, 49);
            this.rows_add_rowValues_label.Name = "rows_add_rowValues_label";
            this.rows_add_rowValues_label.Size = new System.Drawing.Size(65, 20);
            this.rows_add_rowValues_label.TabIndex = 7;
            this.rows_add_rowValues_label.Text = "Values:";
            // 
            // rows_add_addRow_button
            // 
            this.rows_add_addRow_button.Location = new System.Drawing.Point(737, 155);
            this.rows_add_addRow_button.Name = "rows_add_addRow_button";
            this.rows_add_addRow_button.Size = new System.Drawing.Size(122, 44);
            this.rows_add_addRow_button.TabIndex = 6;
            this.rows_add_addRow_button.Text = "Add Row";
            this.rows_add_addRow_button.UseVisualStyleBackColor = true;
            this.rows_add_addRow_button.Click += new System.EventHandler(this.rows_add_addRow_button_Click);
            // 
            // rows_add_removeRowValue_button
            // 
            this.rows_add_removeRowValue_button.Location = new System.Drawing.Point(322, 195);
            this.rows_add_removeRowValue_button.Name = "rows_add_removeRowValue_button";
            this.rows_add_removeRowValue_button.Size = new System.Drawing.Size(90, 28);
            this.rows_add_removeRowValue_button.TabIndex = 5;
            this.rows_add_removeRowValue_button.Text = "Remove";
            this.rows_add_removeRowValue_button.UseVisualStyleBackColor = true;
            this.rows_add_removeRowValue_button.Click += new System.EventHandler(this.rows_add_removeRowValue_button_Click);
            // 
            // rows_add_addRowValue_button
            // 
            this.rows_add_addRowValue_button.Location = new System.Drawing.Point(322, 155);
            this.rows_add_addRowValue_button.Name = "rows_add_addRowValue_button";
            this.rows_add_addRowValue_button.Size = new System.Drawing.Size(90, 28);
            this.rows_add_addRowValue_button.TabIndex = 4;
            this.rows_add_addRowValue_button.Text = "Add";
            this.rows_add_addRowValue_button.UseVisualStyleBackColor = true;
            this.rows_add_addRowValue_button.Click += new System.EventHandler(this.rows_add_addRowValue_button_Click);
            // 
            // rows_add_rowValues_listBox
            // 
            this.rows_add_rowValues_listBox.FormattingEnabled = true;
            this.rows_add_rowValues_listBox.ItemHeight = 20;
            this.rows_add_rowValues_listBox.Location = new System.Drawing.Point(478, 72);
            this.rows_add_rowValues_listBox.Name = "rows_add_rowValues_listBox";
            this.rows_add_rowValues_listBox.Size = new System.Drawing.Size(153, 204);
            this.rows_add_rowValues_listBox.TabIndex = 3;
            // 
            // rows_add_rowValue_textBox
            // 
            this.rows_add_rowValue_textBox.Location = new System.Drawing.Point(298, 115);
            this.rows_add_rowValue_textBox.Name = "rows_add_rowValue_textBox";
            this.rows_add_rowValue_textBox.Size = new System.Drawing.Size(139, 26);
            this.rows_add_rowValue_textBox.TabIndex = 2;
            // 
            // rows_add_rowValue_label
            // 
            this.rows_add_rowValue_label.AutoSize = true;
            this.rows_add_rowValue_label.Location = new System.Drawing.Point(294, 92);
            this.rows_add_rowValue_label.Name = "rows_add_rowValue_label";
            this.rows_add_rowValue_label.Size = new System.Drawing.Size(118, 20);
            this.rows_add_rowValue_label.TabIndex = 1;
            this.rows_add_rowValue_label.Text = "Column Value:";
            // 
            // rows_add_toolTip_label
            // 
            this.rows_add_toolTip_label.Location = new System.Drawing.Point(30, 26);
            this.rows_add_toolTip_label.Name = "rows_add_toolTip_label";
            this.rows_add_toolTip_label.Size = new System.Drawing.Size(240, 300);
            this.rows_add_toolTip_label.TabIndex = 0;
            this.rows_add_toolTip_label.Text = resources.GetString("rows_add_toolTip_label.Text");
            // 
            // rows_select_panel
            // 
            this.rows_select_panel.Controls.Add(this.rows_select_removeAllCols_button);
            this.rows_select_panel.Controls.Add(this.rows_select_addAllCols_button);
            this.rows_select_panel.Controls.Add(this.rows_select_whereValue_label);
            this.rows_select_panel.Controls.Add(this.rows_select_whereColumn_label);
            this.rows_select_panel.Controls.Add(this.rows_select_whereColumn_comboBox);
            this.rows_select_panel.Controls.Add(this.rows_select_whereOperator_label);
            this.rows_select_panel.Controls.Add(this.rows_select_whereValue_textBox);
            this.rows_select_panel.Controls.Add(this.rows_select_whereOperator_comboBox);
            this.rows_select_panel.Controls.Add(this.rows_select_where_checkBox);
            this.rows_select_panel.Controls.Add(this.rows_select_select_button);
            this.rows_select_panel.Controls.Add(this.rows_select_removeSelectedRow_button);
            this.rows_select_panel.Controls.Add(this.rows_select_addSelectedRow_button);
            this.rows_select_panel.Controls.Add(this.rows_select_selectedColumns_listBox);
            this.rows_select_panel.Controls.Add(this.rows_select_selectedRows_label);
            this.rows_select_panel.Controls.Add(this.rows_select_availableColumns_listBox);
            this.rows_select_panel.Controls.Add(this.rows_select_availableColumns_label);
            this.rows_select_panel.Controls.Add(this.rows_select_toolTip_label);
            this.rows_select_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rows_select_panel.Location = new System.Drawing.Point(235, 62);
            this.rows_select_panel.Name = "rows_select_panel";
            this.rows_select_panel.Size = new System.Drawing.Size(920, 360);
            this.rows_select_panel.TabIndex = 30;
            // 
            // rows_select_whereValue_label
            // 
            this.rows_select_whereValue_label.AutoSize = true;
            this.rows_select_whereValue_label.Location = new System.Drawing.Point(682, 270);
            this.rows_select_whereValue_label.Name = "rows_select_whereValue_label";
            this.rows_select_whereValue_label.Size = new System.Drawing.Size(51, 20);
            this.rows_select_whereValue_label.TabIndex = 15;
            this.rows_select_whereValue_label.Text = "Value";
            // 
            // rows_select_whereColumn_label
            // 
            this.rows_select_whereColumn_label.AutoSize = true;
            this.rows_select_whereColumn_label.Location = new System.Drawing.Point(431, 270);
            this.rows_select_whereColumn_label.Name = "rows_select_whereColumn_label";
            this.rows_select_whereColumn_label.Size = new System.Drawing.Size(66, 20);
            this.rows_select_whereColumn_label.TabIndex = 14;
            this.rows_select_whereColumn_label.Text = "Column";
            // 
            // rows_select_whereColumn_comboBox
            // 
            this.rows_select_whereColumn_comboBox.FormattingEnabled = true;
            this.rows_select_whereColumn_comboBox.Location = new System.Drawing.Point(404, 293);
            this.rows_select_whereColumn_comboBox.Name = "rows_select_whereColumn_comboBox";
            this.rows_select_whereColumn_comboBox.Size = new System.Drawing.Size(121, 28);
            this.rows_select_whereColumn_comboBox.TabIndex = 13;
            // 
            // rows_select_whereOperator_label
            // 
            this.rows_select_whereOperator_label.AutoSize = true;
            this.rows_select_whereOperator_label.Location = new System.Drawing.Point(542, 270);
            this.rows_select_whereOperator_label.Name = "rows_select_whereOperator_label";
            this.rows_select_whereOperator_label.Size = new System.Drawing.Size(75, 20);
            this.rows_select_whereOperator_label.TabIndex = 12;
            this.rows_select_whereOperator_label.Text = "Operator";
            // 
            // rows_select_whereValue_textBox
            // 
            this.rows_select_whereValue_textBox.Location = new System.Drawing.Point(637, 293);
            this.rows_select_whereValue_textBox.Name = "rows_select_whereValue_textBox";
            this.rows_select_whereValue_textBox.Size = new System.Drawing.Size(147, 26);
            this.rows_select_whereValue_textBox.TabIndex = 11;
            // 
            // rows_select_whereOperator_comboBox
            // 
            this.rows_select_whereOperator_comboBox.FormattingEnabled = true;
            this.rows_select_whereOperator_comboBox.Items.AddRange(new object[] {
            "=",
            "!=",
            "<",
            "<=",
            ">",
            ">="});
            this.rows_select_whereOperator_comboBox.Location = new System.Drawing.Point(548, 293);
            this.rows_select_whereOperator_comboBox.Name = "rows_select_whereOperator_comboBox";
            this.rows_select_whereOperator_comboBox.Size = new System.Drawing.Size(64, 28);
            this.rows_select_whereOperator_comboBox.TabIndex = 10;
            // 
            // rows_select_where_checkBox
            // 
            this.rows_select_where_checkBox.AutoSize = true;
            this.rows_select_where_checkBox.Location = new System.Drawing.Point(280, 297);
            this.rows_select_where_checkBox.Name = "rows_select_where_checkBox";
            this.rows_select_where_checkBox.Size = new System.Drawing.Size(80, 24);
            this.rows_select_where_checkBox.TabIndex = 8;
            this.rows_select_where_checkBox.Text = "Where";
            this.rows_select_where_checkBox.UseVisualStyleBackColor = true;
            // 
            // rows_select_select_button
            // 
            this.rows_select_select_button.Location = new System.Drawing.Point(759, 128);
            this.rows_select_select_button.Name = "rows_select_select_button";
            this.rows_select_select_button.Size = new System.Drawing.Size(100, 36);
            this.rows_select_select_button.TabIndex = 7;
            this.rows_select_select_button.Text = "Select";
            this.rows_select_select_button.UseVisualStyleBackColor = true;
            this.rows_select_select_button.Click += new System.EventHandler(this.rows_select_select_button_Click);
            // 
            // rows_select_removeSelectedRow_button
            // 
            this.rows_select_removeSelectedRow_button.Location = new System.Drawing.Point(425, 149);
            this.rows_select_removeSelectedRow_button.Name = "rows_select_removeSelectedRow_button";
            this.rows_select_removeSelectedRow_button.Size = new System.Drawing.Size(100, 29);
            this.rows_select_removeSelectedRow_button.TabIndex = 6;
            this.rows_select_removeSelectedRow_button.Text = "Remove";
            this.rows_select_removeSelectedRow_button.UseVisualStyleBackColor = true;
            this.rows_select_removeSelectedRow_button.Click += new System.EventHandler(this.rows_select_removeSelectedRow_button_Click);
            // 
            // rows_select_addSelectedRow_button
            // 
            this.rows_select_addSelectedRow_button.Location = new System.Drawing.Point(425, 106);
            this.rows_select_addSelectedRow_button.Name = "rows_select_addSelectedRow_button";
            this.rows_select_addSelectedRow_button.Size = new System.Drawing.Size(100, 29);
            this.rows_select_addSelectedRow_button.TabIndex = 5;
            this.rows_select_addSelectedRow_button.Text = "Add";
            this.rows_select_addSelectedRow_button.UseVisualStyleBackColor = true;
            this.rows_select_addSelectedRow_button.Click += new System.EventHandler(this.rows_select_addSelectedRow_button_Click);
            // 
            // rows_select_selectedColumns_listBox
            // 
            this.rows_select_selectedColumns_listBox.FormattingEnabled = true;
            this.rows_select_selectedColumns_listBox.ItemHeight = 20;
            this.rows_select_selectedColumns_listBox.Location = new System.Drawing.Point(537, 72);
            this.rows_select_selectedColumns_listBox.Name = "rows_select_selectedColumns_listBox";
            this.rows_select_selectedColumns_listBox.Size = new System.Drawing.Size(132, 164);
            this.rows_select_selectedColumns_listBox.TabIndex = 4;
            // 
            // rows_select_selectedRows_label
            // 
            this.rows_select_selectedRows_label.AutoSize = true;
            this.rows_select_selectedRows_label.Location = new System.Drawing.Point(529, 43);
            this.rows_select_selectedRows_label.Name = "rows_select_selectedRows_label";
            this.rows_select_selectedRows_label.Size = new System.Drawing.Size(145, 20);
            this.rows_select_selectedRows_label.TabIndex = 3;
            this.rows_select_selectedRows_label.Text = "Selected Columns";
            // 
            // rows_select_availableColumns_listBox
            // 
            this.rows_select_availableColumns_listBox.FormattingEnabled = true;
            this.rows_select_availableColumns_listBox.ItemHeight = 20;
            this.rows_select_availableColumns_listBox.Location = new System.Drawing.Point(280, 72);
            this.rows_select_availableColumns_listBox.Name = "rows_select_availableColumns_listBox";
            this.rows_select_availableColumns_listBox.Size = new System.Drawing.Size(132, 164);
            this.rows_select_availableColumns_listBox.TabIndex = 2;
            // 
            // rows_select_availableColumns_label
            // 
            this.rows_select_availableColumns_label.AutoSize = true;
            this.rows_select_availableColumns_label.Location = new System.Drawing.Point(274, 40);
            this.rows_select_availableColumns_label.Name = "rows_select_availableColumns_label";
            this.rows_select_availableColumns_label.Size = new System.Drawing.Size(147, 20);
            this.rows_select_availableColumns_label.TabIndex = 1;
            this.rows_select_availableColumns_label.Text = "Available Columns";
            // 
            // rows_select_toolTip_label
            // 
            this.rows_select_toolTip_label.Location = new System.Drawing.Point(25, 40);
            this.rows_select_toolTip_label.Name = "rows_select_toolTip_label";
            this.rows_select_toolTip_label.Size = new System.Drawing.Size(219, 296);
            this.rows_select_toolTip_label.TabIndex = 0;
            this.rows_select_toolTip_label.Text = "Select a table from the left\r\n\r\nThen pick which columns you would like to select " +
    "from\r\n\r\nCheck the \"where\" box and fill out those forms if you are seeking specif" +
    "ic values";
            // 
            // rows_delete_panel
            // 
            this.rows_delete_panel.Controls.Add(this.rows_delete_value_textBox);
            this.rows_delete_panel.Controls.Add(this.rows_delete_operator_comboBox);
            this.rows_delete_panel.Controls.Add(this.rows_delete_column_comboBox);
            this.rows_delete_panel.Controls.Add(this.rows_delete_delete_button);
            this.rows_delete_panel.Controls.Add(this.rows_delete_value_label);
            this.rows_delete_panel.Controls.Add(this.rows_delete_operator_label);
            this.rows_delete_panel.Controls.Add(this.rows_delete_column_label);
            this.rows_delete_panel.Controls.Add(this.rows_delete_toolTip_label);
            this.rows_delete_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rows_delete_panel.Location = new System.Drawing.Point(235, 62);
            this.rows_delete_panel.Name = "rows_delete_panel";
            this.rows_delete_panel.Size = new System.Drawing.Size(920, 360);
            this.rows_delete_panel.TabIndex = 31;
            // 
            // rows_delete_value_textBox
            // 
            this.rows_delete_value_textBox.Location = new System.Drawing.Point(531, 155);
            this.rows_delete_value_textBox.Name = "rows_delete_value_textBox";
            this.rows_delete_value_textBox.Size = new System.Drawing.Size(119, 26);
            this.rows_delete_value_textBox.TabIndex = 7;
            // 
            // rows_delete_operator_comboBox
            // 
            this.rows_delete_operator_comboBox.FormattingEnabled = true;
            this.rows_delete_operator_comboBox.Items.AddRange(new object[] {
            "=",
            "!=",
            "<",
            "<=",
            ">",
            ">="});
            this.rows_delete_operator_comboBox.Location = new System.Drawing.Point(433, 155);
            this.rows_delete_operator_comboBox.Name = "rows_delete_operator_comboBox";
            this.rows_delete_operator_comboBox.Size = new System.Drawing.Size(57, 28);
            this.rows_delete_operator_comboBox.TabIndex = 6;
            // 
            // rows_delete_column_comboBox
            // 
            this.rows_delete_column_comboBox.FormattingEnabled = true;
            this.rows_delete_column_comboBox.Location = new System.Drawing.Point(277, 155);
            this.rows_delete_column_comboBox.Name = "rows_delete_column_comboBox";
            this.rows_delete_column_comboBox.Size = new System.Drawing.Size(121, 28);
            this.rows_delete_column_comboBox.TabIndex = 5;
            // 
            // rows_delete_delete_button
            // 
            this.rows_delete_delete_button.Location = new System.Drawing.Point(759, 144);
            this.rows_delete_delete_button.Name = "rows_delete_delete_button";
            this.rows_delete_delete_button.Size = new System.Drawing.Size(130, 51);
            this.rows_delete_delete_button.TabIndex = 4;
            this.rows_delete_delete_button.Text = "Delete";
            this.rows_delete_delete_button.UseVisualStyleBackColor = true;
            this.rows_delete_delete_button.Click += new System.EventHandler(this.rows_delete_delete_button_Click);
            // 
            // rows_delete_value_label
            // 
            this.rows_delete_value_label.AutoSize = true;
            this.rows_delete_value_label.Location = new System.Drawing.Point(566, 132);
            this.rows_delete_value_label.Name = "rows_delete_value_label";
            this.rows_delete_value_label.Size = new System.Drawing.Size(51, 20);
            this.rows_delete_value_label.TabIndex = 3;
            this.rows_delete_value_label.Text = "Value";
            // 
            // rows_delete_operator_label
            // 
            this.rows_delete_operator_label.AutoSize = true;
            this.rows_delete_operator_label.Location = new System.Drawing.Point(425, 132);
            this.rows_delete_operator_label.Name = "rows_delete_operator_label";
            this.rows_delete_operator_label.Size = new System.Drawing.Size(75, 20);
            this.rows_delete_operator_label.TabIndex = 2;
            this.rows_delete_operator_label.Text = "Operator";
            // 
            // rows_delete_column_label
            // 
            this.rows_delete_column_label.AutoSize = true;
            this.rows_delete_column_label.Location = new System.Drawing.Point(304, 131);
            this.rows_delete_column_label.Name = "rows_delete_column_label";
            this.rows_delete_column_label.Size = new System.Drawing.Size(66, 20);
            this.rows_delete_column_label.TabIndex = 1;
            this.rows_delete_column_label.Text = "Column";
            // 
            // rows_delete_toolTip_label
            // 
            this.rows_delete_toolTip_label.Location = new System.Drawing.Point(24, 33);
            this.rows_delete_toolTip_label.Name = "rows_delete_toolTip_label";
            this.rows_delete_toolTip_label.Size = new System.Drawing.Size(211, 268);
            this.rows_delete_toolTip_label.TabIndex = 0;
            this.rows_delete_toolTip_label.Text = "Warning! This does not have a confirmation\r\n\r\nSelect a table on the left, then en" +
    "ter a column and condition on the right\r\n\r\nThen you can click delete to drop the" +
    " row";
            // 
            // rows_update_panel
            // 
            this.rows_update_panel.Controls.Add(this.rows_update_removeValue_button);
            this.rows_update_panel.Controls.Add(this.rows_update_addValue_button);
            this.rows_update_panel.Controls.Add(this.rows_update_whereValue_label);
            this.rows_update_panel.Controls.Add(this.rows_update_whereOperator_label);
            this.rows_update_panel.Controls.Add(this.rows_update_whereColumn_label);
            this.rows_update_panel.Controls.Add(this.rows_update_whereValue_textBox);
            this.rows_update_panel.Controls.Add(this.rows_update_whereOperator_comboBox);
            this.rows_update_panel.Controls.Add(this.rows_update_whereColumn_comboBox);
            this.rows_update_panel.Controls.Add(this.rows_update_where_label);
            this.rows_update_panel.Controls.Add(this.rows_update_removeColumn_button);
            this.rows_update_panel.Controls.Add(this.rows_update_addColumn_button);
            this.rows_update_panel.Controls.Add(this.rows_update_update_button);
            this.rows_update_panel.Controls.Add(this.rows_update_value_textBox);
            this.rows_update_panel.Controls.Add(this.rows_update_value_label);
            this.rows_update_panel.Controls.Add(this.rows_update_values_listBox);
            this.rows_update_panel.Controls.Add(this.rows_update_values_label);
            this.rows_update_panel.Controls.Add(this.rows_update_selectedColumns_listBox);
            this.rows_update_panel.Controls.Add(this.rows_update_selectedColumns_label);
            this.rows_update_panel.Controls.Add(this.rows_update_availableColumns_listBox);
            this.rows_update_panel.Controls.Add(this.rows_update_availableColumns_label);
            this.rows_update_panel.Controls.Add(this.label2);
            this.rows_update_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rows_update_panel.Location = new System.Drawing.Point(235, 62);
            this.rows_update_panel.Name = "rows_update_panel";
            this.rows_update_panel.Size = new System.Drawing.Size(920, 360);
            this.rows_update_panel.TabIndex = 32;
            // 
            // rows_update_removeValue_button
            // 
            this.rows_update_removeValue_button.Location = new System.Drawing.Point(643, 165);
            this.rows_update_removeValue_button.Name = "rows_update_removeValue_button";
            this.rows_update_removeValue_button.Size = new System.Drawing.Size(90, 35);
            this.rows_update_removeValue_button.TabIndex = 20;
            this.rows_update_removeValue_button.Text = "Remove";
            this.rows_update_removeValue_button.UseVisualStyleBackColor = true;
            this.rows_update_removeValue_button.Click += new System.EventHandler(this.rows_update_removeValue_button_Click);
            // 
            // rows_update_addValue_button
            // 
            this.rows_update_addValue_button.Location = new System.Drawing.Point(643, 118);
            this.rows_update_addValue_button.Name = "rows_update_addValue_button";
            this.rows_update_addValue_button.Size = new System.Drawing.Size(90, 35);
            this.rows_update_addValue_button.TabIndex = 19;
            this.rows_update_addValue_button.Text = "Add";
            this.rows_update_addValue_button.UseVisualStyleBackColor = true;
            this.rows_update_addValue_button.Click += new System.EventHandler(this.rows_update_addValue_button_Click);
            // 
            // rows_update_whereValue_label
            // 
            this.rows_update_whereValue_label.AutoSize = true;
            this.rows_update_whereValue_label.Location = new System.Drawing.Point(598, 236);
            this.rows_update_whereValue_label.Name = "rows_update_whereValue_label";
            this.rows_update_whereValue_label.Size = new System.Drawing.Size(51, 20);
            this.rows_update_whereValue_label.TabIndex = 18;
            this.rows_update_whereValue_label.Text = "Value";
            // 
            // rows_update_whereOperator_label
            // 
            this.rows_update_whereOperator_label.AutoSize = true;
            this.rows_update_whereOperator_label.Location = new System.Drawing.Point(458, 236);
            this.rows_update_whereOperator_label.Name = "rows_update_whereOperator_label";
            this.rows_update_whereOperator_label.Size = new System.Drawing.Size(75, 20);
            this.rows_update_whereOperator_label.TabIndex = 17;
            this.rows_update_whereOperator_label.Text = "Operator";
            // 
            // rows_update_whereColumn_label
            // 
            this.rows_update_whereColumn_label.AutoSize = true;
            this.rows_update_whereColumn_label.Location = new System.Drawing.Point(335, 236);
            this.rows_update_whereColumn_label.Name = "rows_update_whereColumn_label";
            this.rows_update_whereColumn_label.Size = new System.Drawing.Size(66, 20);
            this.rows_update_whereColumn_label.TabIndex = 16;
            this.rows_update_whereColumn_label.Text = "Column";
            // 
            // rows_update_whereValue_textBox
            // 
            this.rows_update_whereValue_textBox.Location = new System.Drawing.Point(558, 263);
            this.rows_update_whereValue_textBox.Name = "rows_update_whereValue_textBox";
            this.rows_update_whereValue_textBox.Size = new System.Drawing.Size(137, 26);
            this.rows_update_whereValue_textBox.TabIndex = 15;
            // 
            // rows_update_whereOperator_comboBox
            // 
            this.rows_update_whereOperator_comboBox.FormattingEnabled = true;
            this.rows_update_whereOperator_comboBox.Items.AddRange(new object[] {
            "=",
            "!=",
            "<",
            "<=",
            ">",
            ">="});
            this.rows_update_whereOperator_comboBox.Location = new System.Drawing.Point(467, 263);
            this.rows_update_whereOperator_comboBox.Name = "rows_update_whereOperator_comboBox";
            this.rows_update_whereOperator_comboBox.Size = new System.Drawing.Size(55, 28);
            this.rows_update_whereOperator_comboBox.TabIndex = 14;
            // 
            // rows_update_whereColumn_comboBox
            // 
            this.rows_update_whereColumn_comboBox.FormattingEnabled = true;
            this.rows_update_whereColumn_comboBox.Location = new System.Drawing.Point(300, 263);
            this.rows_update_whereColumn_comboBox.Name = "rows_update_whereColumn_comboBox";
            this.rows_update_whereColumn_comboBox.Size = new System.Drawing.Size(137, 28);
            this.rows_update_whereColumn_comboBox.TabIndex = 13;
            // 
            // rows_update_where_label
            // 
            this.rows_update_where_label.AutoSize = true;
            this.rows_update_where_label.Location = new System.Drawing.Point(224, 266);
            this.rows_update_where_label.Name = "rows_update_where_label";
            this.rows_update_where_label.Size = new System.Drawing.Size(58, 20);
            this.rows_update_where_label.TabIndex = 12;
            this.rows_update_where_label.Text = "Where";
            // 
            // rows_update_removeColumn_button
            // 
            this.rows_update_removeColumn_button.Location = new System.Drawing.Point(364, 137);
            this.rows_update_removeColumn_button.Name = "rows_update_removeColumn_button";
            this.rows_update_removeColumn_button.Size = new System.Drawing.Size(90, 35);
            this.rows_update_removeColumn_button.TabIndex = 11;
            this.rows_update_removeColumn_button.Text = "Remove";
            this.rows_update_removeColumn_button.UseVisualStyleBackColor = true;
            this.rows_update_removeColumn_button.Click += new System.EventHandler(this.rows_update_removeColumn_button_Click);
            // 
            // rows_update_addColumn_button
            // 
            this.rows_update_addColumn_button.Location = new System.Drawing.Point(364, 90);
            this.rows_update_addColumn_button.Name = "rows_update_addColumn_button";
            this.rows_update_addColumn_button.Size = new System.Drawing.Size(90, 35);
            this.rows_update_addColumn_button.TabIndex = 10;
            this.rows_update_addColumn_button.Text = "Add";
            this.rows_update_addColumn_button.UseVisualStyleBackColor = true;
            this.rows_update_addColumn_button.Click += new System.EventHandler(this.rows_update_addColumn_button_Click);
            // 
            // rows_update_update_button
            // 
            this.rows_update_update_button.Location = new System.Drawing.Point(769, 253);
            this.rows_update_update_button.Name = "rows_update_update_button";
            this.rows_update_update_button.Size = new System.Drawing.Size(120, 37);
            this.rows_update_update_button.TabIndex = 9;
            this.rows_update_update_button.Text = "Update";
            this.rows_update_update_button.UseVisualStyleBackColor = true;
            this.rows_update_update_button.Click += new System.EventHandler(this.rows_update_update_button_Click);
            // 
            // rows_update_value_textBox
            // 
            this.rows_update_value_textBox.Location = new System.Drawing.Point(623, 86);
            this.rows_update_value_textBox.Name = "rows_update_value_textBox";
            this.rows_update_value_textBox.Size = new System.Drawing.Size(130, 26);
            this.rows_update_value_textBox.TabIndex = 8;
            // 
            // rows_update_value_label
            // 
            this.rows_update_value_label.AutoSize = true;
            this.rows_update_value_label.Location = new System.Drawing.Point(662, 60);
            this.rows_update_value_label.Name = "rows_update_value_label";
            this.rows_update_value_label.Size = new System.Drawing.Size(51, 20);
            this.rows_update_value_label.TabIndex = 7;
            this.rows_update_value_label.Text = "Value";
            // 
            // rows_update_values_listBox
            // 
            this.rows_update_values_listBox.FormattingEnabled = true;
            this.rows_update_values_listBox.ItemHeight = 20;
            this.rows_update_values_listBox.Location = new System.Drawing.Point(769, 52);
            this.rows_update_values_listBox.Name = "rows_update_values_listBox";
            this.rows_update_values_listBox.Size = new System.Drawing.Size(120, 164);
            this.rows_update_values_listBox.TabIndex = 6;
            // 
            // rows_update_values_label
            // 
            this.rows_update_values_label.AutoSize = true;
            this.rows_update_values_label.Location = new System.Drawing.Point(796, 23);
            this.rows_update_values_label.Name = "rows_update_values_label";
            this.rows_update_values_label.Size = new System.Drawing.Size(60, 20);
            this.rows_update_values_label.TabIndex = 5;
            this.rows_update_values_label.Text = "Values";
            // 
            // rows_update_selectedColumns_listBox
            // 
            this.rows_update_selectedColumns_listBox.FormattingEnabled = true;
            this.rows_update_selectedColumns_listBox.ItemHeight = 20;
            this.rows_update_selectedColumns_listBox.Location = new System.Drawing.Point(471, 52);
            this.rows_update_selectedColumns_listBox.Name = "rows_update_selectedColumns_listBox";
            this.rows_update_selectedColumns_listBox.Size = new System.Drawing.Size(120, 164);
            this.rows_update_selectedColumns_listBox.TabIndex = 4;
            // 
            // rows_update_selectedColumns_label
            // 
            this.rows_update_selectedColumns_label.AutoSize = true;
            this.rows_update_selectedColumns_label.Location = new System.Drawing.Point(458, 23);
            this.rows_update_selectedColumns_label.Name = "rows_update_selectedColumns_label";
            this.rows_update_selectedColumns_label.Size = new System.Drawing.Size(145, 20);
            this.rows_update_selectedColumns_label.TabIndex = 3;
            this.rows_update_selectedColumns_label.Text = "Selected Columns";
            // 
            // rows_update_availableColumns_listBox
            // 
            this.rows_update_availableColumns_listBox.FormattingEnabled = true;
            this.rows_update_availableColumns_listBox.ItemHeight = 20;
            this.rows_update_availableColumns_listBox.Location = new System.Drawing.Point(228, 52);
            this.rows_update_availableColumns_listBox.Name = "rows_update_availableColumns_listBox";
            this.rows_update_availableColumns_listBox.Size = new System.Drawing.Size(120, 164);
            this.rows_update_availableColumns_listBox.TabIndex = 2;
            // 
            // rows_update_availableColumns_label
            // 
            this.rows_update_availableColumns_label.AutoSize = true;
            this.rows_update_availableColumns_label.Location = new System.Drawing.Point(213, 23);
            this.rows_update_availableColumns_label.Name = "rows_update_availableColumns_label";
            this.rows_update_availableColumns_label.Size = new System.Drawing.Size(147, 20);
            this.rows_update_availableColumns_label.TabIndex = 1;
            this.rows_update_availableColumns_label.Text = "Available Columns";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(20, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 297);
            this.label2.TabIndex = 0;
            this.label2.Text = "Warning! There is no confirmation for this\r\n\r\nSelect a table from the left, then " +
    "compile a list of selected columns and matching number of values\r\n\r\nEnter a wher" +
    "e condition, then click update";
            // 
            // dash_statusStrip
            // 
            this.dash_statusStrip.Dock = System.Windows.Forms.DockStyle.Top;
            this.dash_statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.dash_statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dash_statusStrip_database_label,
            this.dash_statusStrip_database_value,
            this.dash_statusStrip_schema_label,
            this.dash_statusStrip_schema_value});
            this.dash_statusStrip.Location = new System.Drawing.Point(0, 30);
            this.dash_statusStrip.Name = "dash_statusStrip";
            this.dash_statusStrip.Size = new System.Drawing.Size(1165, 26);
            this.dash_statusStrip.TabIndex = 33;
            this.dash_statusStrip.Text = "dash_statusStrip";
            // 
            // dash_statusStrip_database_label
            // 
            this.dash_statusStrip_database_label.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.dash_statusStrip_database_label.Enabled = false;
            this.dash_statusStrip_database_label.Name = "dash_statusStrip_database_label";
            this.dash_statusStrip_database_label.Size = new System.Drawing.Size(75, 20);
            this.dash_statusStrip_database_label.Text = "Database:";
            // 
            // dash_statusStrip_database_value
            // 
            this.dash_statusStrip_database_value.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.dash_statusStrip_database_value.Enabled = false;
            this.dash_statusStrip_database_value.Name = "dash_statusStrip_database_value";
            this.dash_statusStrip_database_value.Size = new System.Drawing.Size(79, 20);
            this.dash_statusStrip_database_value.Text = "current_db";
            // 
            // dash_statusStrip_schema_label
            // 
            this.dash_statusStrip_schema_label.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.dash_statusStrip_schema_label.Enabled = false;
            this.dash_statusStrip_schema_label.Margin = new System.Windows.Forms.Padding(40, 4, 0, 2);
            this.dash_statusStrip_schema_label.Name = "dash_statusStrip_schema_label";
            this.dash_statusStrip_schema_label.Size = new System.Drawing.Size(64, 20);
            this.dash_statusStrip_schema_label.Text = "Schema:";
            // 
            // dash_statusStrip_schema_value
            // 
            this.dash_statusStrip_schema_value.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.dash_statusStrip_schema_value.Name = "dash_statusStrip_schema_value";
            this.dash_statusStrip_schema_value.Size = new System.Drawing.Size(125, 24);
            this.dash_statusStrip_schema_value.Text = "current_schema";
            this.dash_statusStrip_schema_value.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.dash_statusStrip_schema_value_DropDownItemClicked);
            // 
            // schemas_add_panel
            // 
            this.schemas_add_panel.Controls.Add(this.schemas_add_addSchema_button);
            this.schemas_add_panel.Controls.Add(this.schemas_add_schemaName_textBox);
            this.schemas_add_panel.Controls.Add(this.schemas_add_schemaName_label);
            this.schemas_add_panel.Controls.Add(this.schemas_add_toolTip);
            this.schemas_add_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schemas_add_panel.Location = new System.Drawing.Point(235, 62);
            this.schemas_add_panel.Name = "schemas_add_panel";
            this.schemas_add_panel.Size = new System.Drawing.Size(920, 360);
            this.schemas_add_panel.TabIndex = 34;
            // 
            // schemas_add_addSchema_button
            // 
            this.schemas_add_addSchema_button.Location = new System.Drawing.Point(283, 163);
            this.schemas_add_addSchema_button.Name = "schemas_add_addSchema_button";
            this.schemas_add_addSchema_button.Size = new System.Drawing.Size(144, 36);
            this.schemas_add_addSchema_button.TabIndex = 3;
            this.schemas_add_addSchema_button.Text = "Add Schema";
            this.schemas_add_addSchema_button.UseVisualStyleBackColor = true;
            this.schemas_add_addSchema_button.Click += new System.EventHandler(this.schemas_add_addSchema_button_Click);
            // 
            // schemas_add_schemaName_textBox
            // 
            this.schemas_add_schemaName_textBox.Location = new System.Drawing.Point(283, 123);
            this.schemas_add_schemaName_textBox.Name = "schemas_add_schemaName_textBox";
            this.schemas_add_schemaName_textBox.Size = new System.Drawing.Size(154, 26);
            this.schemas_add_schemaName_textBox.TabIndex = 2;
            // 
            // schemas_add_schemaName_label
            // 
            this.schemas_add_schemaName_label.AutoSize = true;
            this.schemas_add_schemaName_label.Location = new System.Drawing.Point(279, 90);
            this.schemas_add_schemaName_label.Name = "schemas_add_schemaName_label";
            this.schemas_add_schemaName_label.Size = new System.Drawing.Size(124, 20);
            this.schemas_add_schemaName_label.TabIndex = 1;
            this.schemas_add_schemaName_label.Text = "Schema Name:";
            // 
            // schemas_add_toolTip
            // 
            this.schemas_add_toolTip.Location = new System.Drawing.Point(25, 78);
            this.schemas_add_toolTip.Name = "schemas_add_toolTip";
            this.schemas_add_toolTip.Size = new System.Drawing.Size(186, 191);
            this.schemas_add_toolTip.TabIndex = 0;
            this.schemas_add_toolTip.Text = "Type a name for the new schema, then click the button to add it to the database";
            // 
            // schemas_rename_panel
            // 
            this.schemas_rename_panel.Controls.Add(this.schemas_rename_rename_button);
            this.schemas_rename_panel.Controls.Add(this.schemas_rename_newName_textBox);
            this.schemas_rename_panel.Controls.Add(this.schemas_rename_newName_label);
            this.schemas_rename_panel.Controls.Add(this.schemas_rename_toolTip);
            this.schemas_rename_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schemas_rename_panel.Location = new System.Drawing.Point(235, 62);
            this.schemas_rename_panel.Name = "schemas_rename_panel";
            this.schemas_rename_panel.Size = new System.Drawing.Size(920, 360);
            this.schemas_rename_panel.TabIndex = 35;
            // 
            // schemas_rename_rename_button
            // 
            this.schemas_rename_rename_button.Location = new System.Drawing.Point(312, 160);
            this.schemas_rename_rename_button.Name = "schemas_rename_rename_button";
            this.schemas_rename_rename_button.Size = new System.Drawing.Size(118, 38);
            this.schemas_rename_rename_button.TabIndex = 3;
            this.schemas_rename_rename_button.Text = "Rename";
            this.schemas_rename_rename_button.UseVisualStyleBackColor = true;
            this.schemas_rename_rename_button.Click += new System.EventHandler(this.schemas_rename_rename_button_Click);
            // 
            // schemas_rename_newName_textBox
            // 
            this.schemas_rename_newName_textBox.Location = new System.Drawing.Point(312, 122);
            this.schemas_rename_newName_textBox.Name = "schemas_rename_newName_textBox";
            this.schemas_rename_newName_textBox.Size = new System.Drawing.Size(160, 26);
            this.schemas_rename_newName_textBox.TabIndex = 2;
            // 
            // schemas_rename_newName_label
            // 
            this.schemas_rename_newName_label.AutoSize = true;
            this.schemas_rename_newName_label.Location = new System.Drawing.Point(308, 91);
            this.schemas_rename_newName_label.Name = "schemas_rename_newName_label";
            this.schemas_rename_newName_label.Size = new System.Drawing.Size(96, 20);
            this.schemas_rename_newName_label.TabIndex = 1;
            this.schemas_rename_newName_label.Text = "New Name:";
            // 
            // schemas_rename_toolTip
            // 
            this.schemas_rename_toolTip.Location = new System.Drawing.Point(22, 33);
            this.schemas_rename_toolTip.Name = "schemas_rename_toolTip";
            this.schemas_rename_toolTip.Size = new System.Drawing.Size(246, 290);
            this.schemas_rename_toolTip.TabIndex = 0;
            this.schemas_rename_toolTip.Text = "This will rename the currently selected schema.\r\n\r\nSelect the desired schema to r" +
    "ename from the drop down at the top of the app.\r\n\r\nThen you may enter the new na" +
    "me and click the button to rename.";
            // 
            // schemas_delete_panel
            // 
            this.schemas_delete_panel.Controls.Add(this.schemas_delete_delete_button);
            this.schemas_delete_panel.Controls.Add(this.schemas_delete_toolTip);
            this.schemas_delete_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schemas_delete_panel.Location = new System.Drawing.Point(235, 62);
            this.schemas_delete_panel.Name = "schemas_delete_panel";
            this.schemas_delete_panel.Size = new System.Drawing.Size(920, 360);
            this.schemas_delete_panel.TabIndex = 36;
            // 
            // schemas_delete_delete_button
            // 
            this.schemas_delete_delete_button.Location = new System.Drawing.Point(713, 130);
            this.schemas_delete_delete_button.Name = "schemas_delete_delete_button";
            this.schemas_delete_delete_button.Size = new System.Drawing.Size(167, 51);
            this.schemas_delete_delete_button.TabIndex = 1;
            this.schemas_delete_delete_button.Text = "Drop Schema";
            this.schemas_delete_delete_button.UseVisualStyleBackColor = true;
            this.schemas_delete_delete_button.Click += new System.EventHandler(this.schemas_delete_delete_button_Click);
            // 
            // schemas_delete_toolTip
            // 
            this.schemas_delete_toolTip.Location = new System.Drawing.Point(22, 31);
            this.schemas_delete_toolTip.Name = "schemas_delete_toolTip";
            this.schemas_delete_toolTip.Size = new System.Drawing.Size(281, 290);
            this.schemas_delete_toolTip.TabIndex = 0;
            this.schemas_delete_toolTip.Text = resources.GetString("schemas_delete_toolTip.Text");
            // 
            // databases_add_panel
            // 
            this.databases_add_panel.Controls.Add(this.databases_add_addDb_button);
            this.databases_add_panel.Controls.Add(this.databases_add_dbName_textBox);
            this.databases_add_panel.Controls.Add(this.databases_add_dbName_label);
            this.databases_add_panel.Controls.Add(this.databases_add_toolTip_label);
            this.databases_add_panel.Controls.Add(this.databases_add_dbList_label);
            this.databases_add_panel.Controls.Add(this.databases_add_dbList_listBox);
            this.databases_add_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.databases_add_panel.Location = new System.Drawing.Point(235, 62);
            this.databases_add_panel.Name = "databases_add_panel";
            this.databases_add_panel.Size = new System.Drawing.Size(920, 360);
            this.databases_add_panel.TabIndex = 37;
            // 
            // databases_add_addDb_button
            // 
            this.databases_add_addDb_button.Location = new System.Drawing.Point(541, 180);
            this.databases_add_addDb_button.Name = "databases_add_addDb_button";
            this.databases_add_addDb_button.Size = new System.Drawing.Size(145, 40);
            this.databases_add_addDb_button.TabIndex = 5;
            this.databases_add_addDb_button.Text = "Add Database";
            this.databases_add_addDb_button.UseVisualStyleBackColor = true;
            this.databases_add_addDb_button.Click += new System.EventHandler(this.databases_add_addDb_button_Click);
            // 
            // databases_add_dbName_textBox
            // 
            this.databases_add_dbName_textBox.Location = new System.Drawing.Point(541, 142);
            this.databases_add_dbName_textBox.Name = "databases_add_dbName_textBox";
            this.databases_add_dbName_textBox.Size = new System.Drawing.Size(145, 26);
            this.databases_add_dbName_textBox.TabIndex = 4;
            // 
            // databases_add_dbName_label
            // 
            this.databases_add_dbName_label.AutoSize = true;
            this.databases_add_dbName_label.Location = new System.Drawing.Point(537, 113);
            this.databases_add_dbName_label.Name = "databases_add_dbName_label";
            this.databases_add_dbName_label.Size = new System.Drawing.Size(135, 20);
            this.databases_add_dbName_label.TabIndex = 3;
            this.databases_add_dbName_label.Text = "Database Name:";
            // 
            // databases_add_toolTip_label
            // 
            this.databases_add_toolTip_label.Location = new System.Drawing.Point(248, 38);
            this.databases_add_toolTip_label.Name = "databases_add_toolTip_label";
            this.databases_add_toolTip_label.Size = new System.Drawing.Size(235, 275);
            this.databases_add_toolTip_label.TabIndex = 2;
            this.databases_add_toolTip_label.Text = resources.GetString("databases_add_toolTip_label.Text");
            // 
            // databases_add_dbList_label
            // 
            this.databases_add_dbList_label.AutoSize = true;
            this.databases_add_dbList_label.Location = new System.Drawing.Point(22, 6);
            this.databases_add_dbList_label.Name = "databases_add_dbList_label";
            this.databases_add_dbList_label.Size = new System.Drawing.Size(95, 20);
            this.databases_add_dbList_label.TabIndex = 1;
            this.databases_add_dbList_label.Text = "Databases:";
            // 
            // databases_add_dbList_listBox
            // 
            this.databases_add_dbList_listBox.FormattingEnabled = true;
            this.databases_add_dbList_listBox.ItemHeight = 20;
            this.databases_add_dbList_listBox.Location = new System.Drawing.Point(23, 33);
            this.databases_add_dbList_listBox.Name = "databases_add_dbList_listBox";
            this.databases_add_dbList_listBox.Size = new System.Drawing.Size(202, 284);
            this.databases_add_dbList_listBox.TabIndex = 0;
            // 
            // databases_rename_panel
            // 
            this.databases_rename_panel.Controls.Add(this.databases_rename_renameDb_button);
            this.databases_rename_panel.Controls.Add(this.databases_rename_dbName_textBox);
            this.databases_rename_panel.Controls.Add(this.databases_rename_dbName_label);
            this.databases_rename_panel.Controls.Add(this.databases_rename_toolTip_label);
            this.databases_rename_panel.Controls.Add(this.databases_rename_dbList_label);
            this.databases_rename_panel.Controls.Add(this.databases_rename_dbList_listBox);
            this.databases_rename_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.databases_rename_panel.Location = new System.Drawing.Point(235, 62);
            this.databases_rename_panel.Name = "databases_rename_panel";
            this.databases_rename_panel.Size = new System.Drawing.Size(920, 360);
            this.databases_rename_panel.TabIndex = 38;
            // 
            // databases_rename_renameDb_button
            // 
            this.databases_rename_renameDb_button.Location = new System.Drawing.Point(541, 190);
            this.databases_rename_renameDb_button.Name = "databases_rename_renameDb_button";
            this.databases_rename_renameDb_button.Size = new System.Drawing.Size(145, 40);
            this.databases_rename_renameDb_button.TabIndex = 11;
            this.databases_rename_renameDb_button.Text = "Rename";
            this.databases_rename_renameDb_button.UseVisualStyleBackColor = true;
            this.databases_rename_renameDb_button.Click += new System.EventHandler(this.databases_rename_renameDb_button_Click);
            // 
            // databases_rename_dbName_textBox
            // 
            this.databases_rename_dbName_textBox.Location = new System.Drawing.Point(541, 152);
            this.databases_rename_dbName_textBox.Name = "databases_rename_dbName_textBox";
            this.databases_rename_dbName_textBox.Size = new System.Drawing.Size(145, 26);
            this.databases_rename_dbName_textBox.TabIndex = 10;
            // 
            // databases_rename_dbName_label
            // 
            this.databases_rename_dbName_label.AutoSize = true;
            this.databases_rename_dbName_label.Location = new System.Drawing.Point(537, 123);
            this.databases_rename_dbName_label.Name = "databases_rename_dbName_label";
            this.databases_rename_dbName_label.Size = new System.Drawing.Size(135, 20);
            this.databases_rename_dbName_label.TabIndex = 9;
            this.databases_rename_dbName_label.Text = "Database Name:";
            // 
            // databases_rename_toolTip_label
            // 
            this.databases_rename_toolTip_label.Location = new System.Drawing.Point(248, 65);
            this.databases_rename_toolTip_label.Name = "databases_rename_toolTip_label";
            this.databases_rename_toolTip_label.Size = new System.Drawing.Size(224, 258);
            this.databases_rename_toolTip_label.TabIndex = 8;
            this.databases_rename_toolTip_label.Text = resources.GetString("databases_rename_toolTip_label.Text");
            // 
            // databases_rename_dbList_label
            // 
            this.databases_rename_dbList_label.AutoSize = true;
            this.databases_rename_dbList_label.Location = new System.Drawing.Point(22, 16);
            this.databases_rename_dbList_label.Name = "databases_rename_dbList_label";
            this.databases_rename_dbList_label.Size = new System.Drawing.Size(95, 20);
            this.databases_rename_dbList_label.TabIndex = 7;
            this.databases_rename_dbList_label.Text = "Databases:";
            // 
            // databases_rename_dbList_listBox
            // 
            this.databases_rename_dbList_listBox.FormattingEnabled = true;
            this.databases_rename_dbList_listBox.ItemHeight = 20;
            this.databases_rename_dbList_listBox.Location = new System.Drawing.Point(23, 43);
            this.databases_rename_dbList_listBox.Name = "databases_rename_dbList_listBox";
            this.databases_rename_dbList_listBox.Size = new System.Drawing.Size(202, 284);
            this.databases_rename_dbList_listBox.TabIndex = 6;
            // 
            // databases_delete_panel
            // 
            this.databases_delete_panel.Controls.Add(this.databases_delete_delete_button);
            this.databases_delete_panel.Controls.Add(this.databases_delete_toolTip_label);
            this.databases_delete_panel.Controls.Add(this.databases_delete_dbList_label);
            this.databases_delete_panel.Controls.Add(this.databases_delete_dbList_listBox);
            this.databases_delete_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.databases_delete_panel.Location = new System.Drawing.Point(235, 62);
            this.databases_delete_panel.Name = "databases_delete_panel";
            this.databases_delete_panel.Size = new System.Drawing.Size(920, 360);
            this.databases_delete_panel.TabIndex = 39;
            // 
            // databases_delete_delete_button
            // 
            this.databases_delete_delete_button.Location = new System.Drawing.Point(723, 147);
            this.databases_delete_delete_button.Name = "databases_delete_delete_button";
            this.databases_delete_delete_button.Size = new System.Drawing.Size(166, 48);
            this.databases_delete_delete_button.TabIndex = 17;
            this.databases_delete_delete_button.Text = "Delete Database";
            this.databases_delete_delete_button.UseVisualStyleBackColor = true;
            this.databases_delete_delete_button.Click += new System.EventHandler(this.databases_delete_delete_button_Click);
            // 
            // databases_delete_toolTip_label
            // 
            this.databases_delete_toolTip_label.Location = new System.Drawing.Point(249, 35);
            this.databases_delete_toolTip_label.Name = "databases_delete_toolTip_label";
            this.databases_delete_toolTip_label.Size = new System.Drawing.Size(258, 284);
            this.databases_delete_toolTip_label.TabIndex = 14;
            this.databases_delete_toolTip_label.Text = resources.GetString("databases_delete_toolTip_label.Text");
            // 
            // databases_delete_dbList_label
            // 
            this.databases_delete_dbList_label.AutoSize = true;
            this.databases_delete_dbList_label.Location = new System.Drawing.Point(22, 8);
            this.databases_delete_dbList_label.Name = "databases_delete_dbList_label";
            this.databases_delete_dbList_label.Size = new System.Drawing.Size(95, 20);
            this.databases_delete_dbList_label.TabIndex = 13;
            this.databases_delete_dbList_label.Text = "Databases:";
            // 
            // databases_delete_dbList_listBox
            // 
            this.databases_delete_dbList_listBox.FormattingEnabled = true;
            this.databases_delete_dbList_listBox.ItemHeight = 20;
            this.databases_delete_dbList_listBox.Location = new System.Drawing.Point(23, 35);
            this.databases_delete_dbList_listBox.Name = "databases_delete_dbList_listBox";
            this.databases_delete_dbList_listBox.Size = new System.Drawing.Size(202, 284);
            this.databases_delete_dbList_listBox.TabIndex = 12;
            // 
            // rows_select_addAllCols_button
            // 
            this.rows_select_addAllCols_button.Location = new System.Drawing.Point(425, 65);
            this.rows_select_addAllCols_button.Name = "rows_select_addAllCols_button";
            this.rows_select_addAllCols_button.Size = new System.Drawing.Size(100, 29);
            this.rows_select_addAllCols_button.TabIndex = 16;
            this.rows_select_addAllCols_button.Text = "Add All";
            this.rows_select_addAllCols_button.UseVisualStyleBackColor = true;
            this.rows_select_addAllCols_button.Click += new System.EventHandler(this.rows_select_addAllCols_button_Click);
            // 
            // rows_select_removeAllCols_button
            // 
            this.rows_select_removeAllCols_button.Location = new System.Drawing.Point(425, 189);
            this.rows_select_removeAllCols_button.Name = "rows_select_removeAllCols_button";
            this.rows_select_removeAllCols_button.Size = new System.Drawing.Size(100, 54);
            this.rows_select_removeAllCols_button.TabIndex = 17;
            this.rows_select_removeAllCols_button.Text = "Remove All";
            this.rows_select_removeAllCols_button.UseVisualStyleBackColor = true;
            this.rows_select_removeAllCols_button.Click += new System.EventHandler(this.rows_select_removeAllCols_button_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 734);
            this.Controls.Add(this.dash_statusStrip);
            this.Controls.Add(this.dash_columns_label);
            this.Controls.Add(this.dash_columns_listBox);
            this.Controls.Add(this.dash_tables_label);
            this.Controls.Add(this.dash_tables_listBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dash_log_richTextBox);
            this.Controls.Add(this.rows_add_panel);
            this.Controls.Add(this.columns_removeConstraint_panel);
            this.Controls.Add(this.columns_addConstraint_panel);
            this.Controls.Add(this.columns_dataType_panel);
            this.Controls.Add(this.columns_addColumn_panel);
            this.Controls.Add(this.databases_delete_panel);
            this.Controls.Add(this.databases_rename_panel);
            this.Controls.Add(this.databases_add_panel);
            this.Controls.Add(this.schemas_delete_panel);
            this.Controls.Add(this.schemas_rename_panel);
            this.Controls.Add(this.schemas_add_panel);
            this.Controls.Add(this.rows_update_panel);
            this.Controls.Add(this.rows_delete_panel);
            this.Controls.Add(this.tables_add_panel);
            this.Controls.Add(this.columns_remove_panel);
            this.Controls.Add(this.columns_rename_panel);
            this.Controls.Add(this.rows_select_panel);
            this.Controls.Add(this.tables_delete_panel);
            this.Controls.Add(this.tables_rename_panel);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.Text = "SQL GUI Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dashboard_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tables_add_panel.ResumeLayout(false);
            this.tables_add_panel.PerformLayout();
            this.tables_delete_panel.ResumeLayout(false);
            this.columns_addColumn_panel.ResumeLayout(false);
            this.columns_addColumn_panel.PerformLayout();
            this.tables_rename_panel.ResumeLayout(false);
            this.tables_rename_panel.PerformLayout();
            this.columns_rename_panel.ResumeLayout(false);
            this.columns_rename_panel.PerformLayout();
            this.columns_remove_panel.ResumeLayout(false);
            this.columns_dataType_panel.ResumeLayout(false);
            this.columns_dataType_panel.PerformLayout();
            this.columns_addConstraint_panel.ResumeLayout(false);
            this.columns_addConstraint_panel.PerformLayout();
            this.columns_removeConstraint_panel.ResumeLayout(false);
            this.columns_removeConstraint_panel.PerformLayout();
            this.rows_add_panel.ResumeLayout(false);
            this.rows_add_panel.PerformLayout();
            this.rows_select_panel.ResumeLayout(false);
            this.rows_select_panel.PerformLayout();
            this.rows_delete_panel.ResumeLayout(false);
            this.rows_delete_panel.PerformLayout();
            this.rows_update_panel.ResumeLayout(false);
            this.rows_update_panel.PerformLayout();
            this.dash_statusStrip.ResumeLayout(false);
            this.dash_statusStrip.PerformLayout();
            this.schemas_add_panel.ResumeLayout(false);
            this.schemas_add_panel.PerformLayout();
            this.schemas_rename_panel.ResumeLayout(false);
            this.schemas_rename_panel.PerformLayout();
            this.schemas_delete_panel.ResumeLayout(false);
            this.databases_add_panel.ResumeLayout(false);
            this.databases_add_panel.PerformLayout();
            this.databases_rename_panel.ResumeLayout(false);
            this.databases_rename_panel.PerformLayout();
            this.databases_delete_panel.ResumeLayout(false);
            this.databases_delete_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox dash_log_richTextBox;
        private System.Windows.Forms.ListBox dash_tables_listBox;
        private System.Windows.Forms.Label dash_tables_label;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem columnsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addColumnToTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeColumnFromTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRowToTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectRowsFromTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateRowsInTableToolStripMenuItem;
        private System.Windows.Forms.TextBox tables_add_tableName_textBox;
        private System.Windows.Forms.Label tables_add_tableName_label;
        private System.Windows.Forms.ListBox tables_add_columnNames_listBox;
        private System.Windows.Forms.Label tables_add_columnNames_label;
        private System.Windows.Forms.TextBox tables_add_columnNames_textBox;
        private System.Windows.Forms.Button tables_add_addColumnNames_button;
        private System.Windows.Forms.Button tables_add_removeColumnNames_button;
        private System.Windows.Forms.Button tables_add_removeValueType_button;
        private System.Windows.Forms.Button tables_add_addValueType_button;
        private System.Windows.Forms.Label tables_add_valueTypes_label;
        private System.Windows.Forms.ListBox tables_add_valueTypes_listBox;
        private System.Windows.Forms.Label tables_add_tip_label;
        private System.Windows.Forms.ComboBox tables_add_addValueType_comboBox;
        private System.Windows.Forms.Button tables_add_addTable_button;
        private System.Windows.Forms.Panel tables_add_panel;
        private System.Windows.Forms.Panel tables_delete_panel;
        private System.Windows.Forms.Button tables_delete_button;
        private System.Windows.Forms.Label tables_delete_label;
        private System.Windows.Forms.Panel columns_addColumn_panel;
        private System.Windows.Forms.Label columns_add_columnTableNote_label;
        private System.Windows.Forms.Button columns_add_column_button;
        private System.Windows.Forms.Label columns_add_columnColumnNote_label;
        private System.Windows.Forms.Button columns_add_removeColumn_button;
        private System.Windows.Forms.ComboBox columns_add_valueTypes_comboBox;
        private System.Windows.Forms.Button columns_add_addColumn_button;
        private System.Windows.Forms.ListBox columns_add_valueTypes_listBox;
        private System.Windows.Forms.TextBox columns_add_columnName_textBox;
        private System.Windows.Forms.Label columns_add_columnNames_label;
        private System.Windows.Forms.Button columns_add_removeValueType_button;
        private System.Windows.Forms.ListBox columns_add_columnNames_listBox;
        private System.Windows.Forms.Button columns_add_addValueType_button;
        private System.Windows.Forms.Label columns_add_valueTypes_label;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameColumnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeColumnDataTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeColumnConstraintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteRowFromTableToolStripMenuItem;
        private System.Windows.Forms.Panel tables_rename_panel;
        private System.Windows.Forms.Label tables_rename_toolTip_label;
        private System.Windows.Forms.Label tables_rename_newName_label;
        private System.Windows.Forms.Button tables_rename_newName_button;
        private System.Windows.Forms.TextBox tables_rename_newName_textbox;
        private System.Windows.Forms.Label dash_columns_label;
        private System.Windows.Forms.ListBox dash_columns_listBox;
        private System.Windows.Forms.Panel columns_rename_panel;
        private System.Windows.Forms.Button columns_rename_newName_button;
        private System.Windows.Forms.TextBox columns_rename_newName_textbox;
        private System.Windows.Forms.Label columns_rename_newName_label;
        private System.Windows.Forms.Label columns_rename_toolTip_label;
        private System.Windows.Forms.Panel columns_remove_panel;
        private System.Windows.Forms.Button columns_remove_removeColumn_button;
        private System.Windows.Forms.Label columns_remove_toolTip_label;
        private System.Windows.Forms.Panel columns_dataType_panel;
        private System.Windows.Forms.Button columns_dataType_changeType_button;
        private System.Windows.Forms.Label columns_dataType_toolTip_label;
        private System.Windows.Forms.ComboBox columns_dataType_valueTypes_comboBox;
        private System.Windows.Forms.Label columns_dataType_valueTypes_label;
        private System.Windows.Forms.Panel columns_addConstraint_panel;
        private System.Windows.Forms.Label columns_addConstraint_references_column_label;
        private System.Windows.Forms.Label columns_addConstraint_references_table_label;
        private System.Windows.Forms.Label columns_addConstraint_check_value_label;
        private System.Windows.Forms.Label columns_addConstraint_check_operators_label;
        private System.Windows.Forms.Label columns_addConstraint_check_column_label;
        private System.Windows.Forms.Label columns_addConstraint_check_checkName_label;
        private System.Windows.Forms.TextBox columns_addConstraint_check_value_textBox;
        private System.Windows.Forms.ComboBox columns_addConstraint_check_operators_comboBox;
        private System.Windows.Forms.ComboBox columns_addConstraint_check_columns_comboBox;
        private System.Windows.Forms.TextBox columns_addConstraint_check_checkName_textBox;
        private System.Windows.Forms.ComboBox columns_addConstraint_references_column_comboBox;
        private System.Windows.Forms.ComboBox columns_addConstraint_references_table_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox columns_addConstraint_check_checkBox;
        private System.Windows.Forms.CheckBox columns_addConstraint_references_checkBox;
        private System.Windows.Forms.CheckBox columns_addConstraint_notNull_checkBox;
        private System.Windows.Forms.CheckBox columns_addConstraint_unique_checkBox;
        private System.Windows.Forms.ToolStripMenuItem removeColumnConstraintToolStripMenuItem;
        private System.Windows.Forms.Button columns_addConstraint_add_button;
        private System.Windows.Forms.Panel columns_removeConstraint_panel;
        private System.Windows.Forms.Button columns_removeConstraint_remove_button;
        private System.Windows.Forms.Label columns_removeConstraint_constraints_label;
        private System.Windows.Forms.ListBox columns_removeConstraint_constraints_listBox;
        private System.Windows.Forms.Label columns_removeConstraint_toolTip_label;
        private System.Windows.Forms.Panel rows_add_panel;
        private System.Windows.Forms.Label rows_add_rowValues_label;
        private System.Windows.Forms.Button rows_add_addRow_button;
        private System.Windows.Forms.Button rows_add_removeRowValue_button;
        private System.Windows.Forms.Button rows_add_addRowValue_button;
        private System.Windows.Forms.ListBox rows_add_rowValues_listBox;
        private System.Windows.Forms.TextBox rows_add_rowValue_textBox;
        private System.Windows.Forms.Label rows_add_rowValue_label;
        private System.Windows.Forms.Label rows_add_toolTip_label;
        private System.Windows.Forms.Panel rows_select_panel;
        private System.Windows.Forms.Label rows_select_whereValue_label;
        private System.Windows.Forms.Label rows_select_whereColumn_label;
        private System.Windows.Forms.ComboBox rows_select_whereColumn_comboBox;
        private System.Windows.Forms.Label rows_select_whereOperator_label;
        private System.Windows.Forms.TextBox rows_select_whereValue_textBox;
        private System.Windows.Forms.ComboBox rows_select_whereOperator_comboBox;
        private System.Windows.Forms.CheckBox rows_select_where_checkBox;
        private System.Windows.Forms.Button rows_select_select_button;
        private System.Windows.Forms.Button rows_select_removeSelectedRow_button;
        private System.Windows.Forms.Button rows_select_addSelectedRow_button;
        private System.Windows.Forms.ListBox rows_select_selectedColumns_listBox;
        private System.Windows.Forms.Label rows_select_selectedRows_label;
        private System.Windows.Forms.ListBox rows_select_availableColumns_listBox;
        private System.Windows.Forms.Label rows_select_availableColumns_label;
        private System.Windows.Forms.Label rows_select_toolTip_label;
        private System.Windows.Forms.Panel rows_delete_panel;
        private System.Windows.Forms.TextBox rows_delete_value_textBox;
        private System.Windows.Forms.ComboBox rows_delete_operator_comboBox;
        private System.Windows.Forms.ComboBox rows_delete_column_comboBox;
        private System.Windows.Forms.Button rows_delete_delete_button;
        private System.Windows.Forms.Label rows_delete_value_label;
        private System.Windows.Forms.Label rows_delete_operator_label;
        private System.Windows.Forms.Label rows_delete_column_label;
        private System.Windows.Forms.Label rows_delete_toolTip_label;
        private System.Windows.Forms.Panel rows_update_panel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button rows_update_removeColumn_button;
        private System.Windows.Forms.Button rows_update_addColumn_button;
        private System.Windows.Forms.Button rows_update_update_button;
        private System.Windows.Forms.TextBox rows_update_value_textBox;
        private System.Windows.Forms.Label rows_update_value_label;
        private System.Windows.Forms.ListBox rows_update_values_listBox;
        private System.Windows.Forms.Label rows_update_values_label;
        private System.Windows.Forms.ListBox rows_update_selectedColumns_listBox;
        private System.Windows.Forms.Label rows_update_selectedColumns_label;
        private System.Windows.Forms.ListBox rows_update_availableColumns_listBox;
        private System.Windows.Forms.Label rows_update_availableColumns_label;
        private System.Windows.Forms.Label rows_update_whereValue_label;
        private System.Windows.Forms.Label rows_update_whereOperator_label;
        private System.Windows.Forms.Label rows_update_whereColumn_label;
        private System.Windows.Forms.TextBox rows_update_whereValue_textBox;
        private System.Windows.Forms.ComboBox rows_update_whereOperator_comboBox;
        private System.Windows.Forms.ComboBox rows_update_whereColumn_comboBox;
        private System.Windows.Forms.Label rows_update_where_label;
        private System.Windows.Forms.Button rows_update_removeValue_button;
        private System.Windows.Forms.Button rows_update_addValue_button;
        private System.Windows.Forms.StatusStrip dash_statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel dash_statusStrip_database_label;
        private System.Windows.Forms.ToolStripStatusLabel dash_statusStrip_database_value;
        private System.Windows.Forms.ToolStripStatusLabel dash_statusStrip_schema_label;
        private System.Windows.Forms.ToolStripDropDownButton dash_statusStrip_schema_value;
        private System.Windows.Forms.ToolStripMenuItem schemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSchemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameSchemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dropSchemaToolStripMenuItem;
        private System.Windows.Forms.Panel schemas_add_panel;
        private System.Windows.Forms.Button schemas_add_addSchema_button;
        private System.Windows.Forms.TextBox schemas_add_schemaName_textBox;
        private System.Windows.Forms.Label schemas_add_schemaName_label;
        private System.Windows.Forms.Label schemas_add_toolTip;
        private System.Windows.Forms.Panel schemas_rename_panel;
        private System.Windows.Forms.Button schemas_rename_rename_button;
        private System.Windows.Forms.TextBox schemas_rename_newName_textBox;
        private System.Windows.Forms.Label schemas_rename_newName_label;
        private System.Windows.Forms.Label schemas_rename_toolTip;
        private System.Windows.Forms.Panel schemas_delete_panel;
        private System.Windows.Forms.Button schemas_delete_delete_button;
        private System.Windows.Forms.Label schemas_delete_toolTip;
        private System.Windows.Forms.ToolStripMenuItem databasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dropDatabaseToolStripMenuItem;
        private System.Windows.Forms.Panel databases_add_panel;
        private System.Windows.Forms.Button databases_add_addDb_button;
        private System.Windows.Forms.TextBox databases_add_dbName_textBox;
        private System.Windows.Forms.Label databases_add_dbName_label;
        private System.Windows.Forms.Label databases_add_toolTip_label;
        private System.Windows.Forms.Label databases_add_dbList_label;
        private System.Windows.Forms.ListBox databases_add_dbList_listBox;
        private System.Windows.Forms.Panel databases_rename_panel;
        private System.Windows.Forms.Button databases_rename_renameDb_button;
        private System.Windows.Forms.TextBox databases_rename_dbName_textBox;
        private System.Windows.Forms.Label databases_rename_dbName_label;
        private System.Windows.Forms.Label databases_rename_toolTip_label;
        private System.Windows.Forms.Label databases_rename_dbList_label;
        private System.Windows.Forms.ListBox databases_rename_dbList_listBox;
        private System.Windows.Forms.Panel databases_delete_panel;
        private System.Windows.Forms.Button databases_delete_delete_button;
        private System.Windows.Forms.Label databases_delete_toolTip_label;
        private System.Windows.Forms.Label databases_delete_dbList_label;
        private System.Windows.Forms.ListBox databases_delete_dbList_listBox;
        private System.Windows.Forms.Button rows_select_removeAllCols_button;
        private System.Windows.Forms.Button rows_select_addAllCols_button;
    }
}