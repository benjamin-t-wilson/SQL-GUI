namespace SQL_GUI.Forms
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
            this.dash_log_richTextBox = new System.Windows.Forms.RichTextBox();
            this.dash_tables_listBox = new System.Windows.Forms.ListBox();
            this.dash_tables_label = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.columnsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addColumnToTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeColumnFromTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRowToTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectRowsFromTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateRowsInTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tables_add_tableName_textBox = new System.Windows.Forms.TextBox();
            this.tables_add_tableName_label = new System.Windows.Forms.Label();
            this.tables_add_columnNames_listBox = new System.Windows.Forms.ListBox();
            this.tables_add_columnNames_label = new System.Windows.Forms.Label();
            this.tables_add_columnNames_textBox = new System.Windows.Forms.TextBox();
            this.tables_add_addColumnNames_button = new System.Windows.Forms.Button();
            this.tables_add_removeColumnNames_button = new System.Windows.Forms.Button();
            this.tables_add_removeValueType_button = new System.Windows.Forms.Button();
            this.tables_add_addValueType_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tables_add_valueTypes_listBox = new System.Windows.Forms.ListBox();
            this.tables_add_tip_label = new System.Windows.Forms.Label();
            this.tables_add_addValueType_comboBox = new System.Windows.Forms.ComboBox();
            this.tables_add_addTable_button = new System.Windows.Forms.Button();
            this.tables_add_panel = new System.Windows.Forms.Panel();
            this.tables_delete_panel = new System.Windows.Forms.Panel();
            this.tables_delete_button = new System.Windows.Forms.Button();
            this.tables_delete_label = new System.Windows.Forms.Label();
            this.columns_addColumn_panel = new System.Windows.Forms.Panel();
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
            this.columns_add_columnTableNote_label = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tables_add_panel.SuspendLayout();
            this.tables_delete_panel.SuspendLayout();
            this.columns_addColumn_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dash_log_richTextBox
            // 
            this.dash_log_richTextBox.Location = new System.Drawing.Point(232, 393);
            this.dash_log_richTextBox.Name = "dash_log_richTextBox";
            this.dash_log_richTextBox.Size = new System.Drawing.Size(918, 297);
            this.dash_log_richTextBox.TabIndex = 0;
            this.dash_log_richTextBox.Text = "";
            // 
            // dash_tables_listBox
            // 
            this.dash_tables_listBox.FormattingEnabled = true;
            this.dash_tables_listBox.ItemHeight = 16;
            this.dash_tables_listBox.Location = new System.Drawing.Point(12, 77);
            this.dash_tables_listBox.Name = "dash_tables_listBox";
            this.dash_tables_listBox.Size = new System.Drawing.Size(202, 612);
            this.dash_tables_listBox.TabIndex = 1;
            // 
            // dash_tables_label
            // 
            this.dash_tables_label.AutoSize = true;
            this.dash_tables_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dash_tables_label.Location = new System.Drawing.Point(7, 49);
            this.dash_tables_label.Name = "dash_tables_label";
            this.dash_tables_label.Size = new System.Drawing.Size(78, 25);
            this.dash_tables_label.TabIndex = 2;
            this.dash_tables_label.Text = "Tables:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tablesToolStripMenuItem,
            this.columnsToolStripMenuItem,
            this.rowsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1165, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tablesToolStripMenuItem
            // 
            this.tablesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTableToolStripMenuItem,
            this.deleteTableToolStripMenuItem});
            this.tablesToolStripMenuItem.Name = "tablesToolStripMenuItem";
            this.tablesToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.tablesToolStripMenuItem.Text = "Tables";
            // 
            // addTableToolStripMenuItem
            // 
            this.addTableToolStripMenuItem.Name = "addTableToolStripMenuItem";
            this.addTableToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.addTableToolStripMenuItem.Text = "Add table";
            this.addTableToolStripMenuItem.Click += new System.EventHandler(this.addTableToolStripMenuItem_Click);
            // 
            // deleteTableToolStripMenuItem
            // 
            this.deleteTableToolStripMenuItem.Name = "deleteTableToolStripMenuItem";
            this.deleteTableToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.deleteTableToolStripMenuItem.Text = "Delete table";
            this.deleteTableToolStripMenuItem.Click += new System.EventHandler(this.deleteTableToolStripMenuItem_Click);
            // 
            // columnsToolStripMenuItem
            // 
            this.columnsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addColumnToTableToolStripMenuItem,
            this.removeColumnFromTableToolStripMenuItem});
            this.columnsToolStripMenuItem.Name = "columnsToolStripMenuItem";
            this.columnsToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
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
            // 
            // rowsToolStripMenuItem
            // 
            this.rowsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRowToTableToolStripMenuItem,
            this.selectRowsFromTableToolStripMenuItem,
            this.updateRowsInTableToolStripMenuItem});
            this.rowsToolStripMenuItem.Name = "rowsToolStripMenuItem";
            this.rowsToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.rowsToolStripMenuItem.Text = "Rows";
            // 
            // addRowToTableToolStripMenuItem
            // 
            this.addRowToTableToolStripMenuItem.Name = "addRowToTableToolStripMenuItem";
            this.addRowToTableToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.addRowToTableToolStripMenuItem.Text = "Add row to table";
            // 
            // selectRowsFromTableToolStripMenuItem
            // 
            this.selectRowsFromTableToolStripMenuItem.Name = "selectRowsFromTableToolStripMenuItem";
            this.selectRowsFromTableToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.selectRowsFromTableToolStripMenuItem.Text = "Select row(s) from table";
            // 
            // updateRowsInTableToolStripMenuItem
            // 
            this.updateRowsInTableToolStripMenuItem.Name = "updateRowsInTableToolStripMenuItem";
            this.updateRowsInTableToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.updateRowsInTableToolStripMenuItem.Text = "Update row(s) in table";
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
            this.tables_add_columnNames_listBox.Location = new System.Drawing.Point(364, 149);
            this.tables_add_columnNames_listBox.Name = "tables_add_columnNames_listBox";
            this.tables_add_columnNames_listBox.Size = new System.Drawing.Size(142, 196);
            this.tables_add_columnNames_listBox.TabIndex = 6;
            // 
            // tables_add_columnNames_label
            // 
            this.tables_add_columnNames_label.AutoSize = true;
            this.tables_add_columnNames_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tables_add_columnNames_label.Location = new System.Drawing.Point(221, 150);
            this.tables_add_columnNames_label.Name = "tables_add_columnNames_label";
            this.tables_add_columnNames_label.Size = new System.Drawing.Size(124, 20);
            this.tables_add_columnNames_label.TabIndex = 7;
            this.tables_add_columnNames_label.Text = "Column Names";
            // 
            // tables_add_columnNames_textBox
            // 
            this.tables_add_columnNames_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tables_add_columnNames_textBox.Location = new System.Drawing.Point(217, 174);
            this.tables_add_columnNames_textBox.Name = "tables_add_columnNames_textBox";
            this.tables_add_columnNames_textBox.Size = new System.Drawing.Size(133, 26);
            this.tables_add_columnNames_textBox.TabIndex = 8;
            // 
            // tables_add_addColumnNames_button
            // 
            this.tables_add_addColumnNames_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tables_add_addColumnNames_button.Location = new System.Drawing.Point(217, 228);
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
            this.tables_add_removeColumnNames_button.Location = new System.Drawing.Point(217, 262);
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
            this.tables_add_removeValueType_button.Location = new System.Drawing.Point(592, 262);
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
            this.tables_add_addValueType_button.Location = new System.Drawing.Point(592, 228);
            this.tables_add_addValueType_button.Name = "tables_add_addValueType_button";
            this.tables_add_addValueType_button.Size = new System.Drawing.Size(133, 28);
            this.tables_add_addValueType_button.TabIndex = 14;
            this.tables_add_addValueType_button.Text = "Add";
            this.tables_add_addValueType_button.UseVisualStyleBackColor = true;
            this.tables_add_addValueType_button.Click += new System.EventHandler(this.tables_add_addValueType_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(611, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Value Types";
            // 
            // tables_add_valueTypes_listBox
            // 
            this.tables_add_valueTypes_listBox.FormattingEnabled = true;
            this.tables_add_valueTypes_listBox.ItemHeight = 16;
            this.tables_add_valueTypes_listBox.Location = new System.Drawing.Point(739, 150);
            this.tables_add_valueTypes_listBox.Name = "tables_add_valueTypes_listBox";
            this.tables_add_valueTypes_listBox.Size = new System.Drawing.Size(142, 196);
            this.tables_add_valueTypes_listBox.TabIndex = 11;
            // 
            // tables_add_tip_label
            // 
            this.tables_add_tip_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tables_add_tip_label.Location = new System.Drawing.Point(20, 140);
            this.tables_add_tip_label.Name = "tables_add_tip_label";
            this.tables_add_tip_label.Size = new System.Drawing.Size(142, 196);
            this.tables_add_tip_label.TabIndex = 17;
            this.tables_add_tip_label.Text = "Please add columns and values in the desired order. The first column will be pair" +
    "ed with the first value type, and so on.";
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
            "DOUBLE",
            "DECIMAL",
            "DATE",
            "DATETIME",
            "TIMESTAMP"});
            this.tables_add_addValueType_comboBox.Location = new System.Drawing.Point(592, 172);
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
            this.tables_add_panel.Controls.Add(this.label1);
            this.tables_add_panel.Location = new System.Drawing.Point(235, 28);
            this.tables_add_panel.Name = "tables_add_panel";
            this.tables_add_panel.Size = new System.Drawing.Size(918, 358);
            this.tables_add_panel.TabIndex = 20;
            // 
            // tables_delete_panel
            // 
            this.tables_delete_panel.Controls.Add(this.tables_delete_button);
            this.tables_delete_panel.Controls.Add(this.tables_delete_label);
            this.tables_delete_panel.Location = new System.Drawing.Point(235, 28);
            this.tables_delete_panel.Name = "tables_delete_panel";
            this.tables_delete_panel.Size = new System.Drawing.Size(918, 358);
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
            this.tables_delete_label.Location = new System.Drawing.Point(22, 72);
            this.tables_delete_label.Name = "tables_delete_label";
            this.tables_delete_label.Size = new System.Drawing.Size(223, 212);
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
            this.columns_addColumn_panel.Location = new System.Drawing.Point(235, 29);
            this.columns_addColumn_panel.Name = "columns_addColumn_panel";
            this.columns_addColumn_panel.Size = new System.Drawing.Size(918, 358);
            this.columns_addColumn_panel.TabIndex = 21;
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
            "DOUBLE",
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
            // columns_add_columnTableNote_label
            // 
            this.columns_add_columnTableNote_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columns_add_columnTableNote_label.Location = new System.Drawing.Point(19, 42);
            this.columns_add_columnTableNote_label.Name = "columns_add_columnTableNote_label";
            this.columns_add_columnTableNote_label.Size = new System.Drawing.Size(166, 54);
            this.columns_add_columnTableNote_label.TabIndex = 20;
            this.columns_add_columnTableNote_label.Text = "Select a table from the list on the left";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 708);
            this.Controls.Add(this.columns_addColumn_panel);
            this.Controls.Add(this.tables_add_panel);
            this.Controls.Add(this.dash_tables_label);
            this.Controls.Add(this.dash_tables_listBox);
            this.Controls.Add(this.dash_log_richTextBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tables_delete_panel);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.Text = "SQL GUI Dashboard";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tables_add_panel.ResumeLayout(false);
            this.tables_add_panel.PerformLayout();
            this.tables_delete_panel.ResumeLayout(false);
            this.columns_addColumn_panel.ResumeLayout(false);
            this.columns_addColumn_panel.PerformLayout();
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
        private System.Windows.Forms.Label label1;
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
    }
}