namespace SQL_GUI
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tables_add_valueTypes_textBox = new System.Windows.Forms.ListBox();
            this.tables_add_tip_label = new System.Windows.Forms.Label();
            this.tables_add_addValueType_comboBox = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dash_log_richTextBox
            // 
            this.dash_log_richTextBox.Location = new System.Drawing.Point(236, 303);
            this.dash_log_richTextBox.Name = "dash_log_richTextBox";
            this.dash_log_richTextBox.Size = new System.Drawing.Size(526, 226);
            this.dash_log_richTextBox.TabIndex = 0;
            this.dash_log_richTextBox.Text = "";
            // 
            // dash_tables_listBox
            // 
            this.dash_tables_listBox.FormattingEnabled = true;
            this.dash_tables_listBox.ItemHeight = 16;
            this.dash_tables_listBox.Location = new System.Drawing.Point(12, 77);
            this.dash_tables_listBox.Name = "dash_tables_listBox";
            this.dash_tables_listBox.Size = new System.Drawing.Size(202, 452);
            this.dash_tables_listBox.TabIndex = 1;
            // 
            // dash_tables_label
            // 
            this.dash_tables_label.AutoSize = true;
            this.dash_tables_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dash_tables_label.Location = new System.Drawing.Point(12, 38);
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
            this.menuStrip1.Size = new System.Drawing.Size(774, 28);
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
            // 
            // deleteTableToolStripMenuItem
            // 
            this.deleteTableToolStripMenuItem.Name = "deleteTableToolStripMenuItem";
            this.deleteTableToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.deleteTableToolStripMenuItem.Text = "Delete table";
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
            this.tables_add_tableName_textBox.Location = new System.Drawing.Point(238, 77);
            this.tables_add_tableName_textBox.Name = "tables_add_tableName_textBox";
            this.tables_add_tableName_textBox.Size = new System.Drawing.Size(198, 26);
            this.tables_add_tableName_textBox.TabIndex = 4;
            // 
            // tables_add_tableName_label
            // 
            this.tables_add_tableName_label.AutoSize = true;
            this.tables_add_tableName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tables_add_tableName_label.Location = new System.Drawing.Point(235, 54);
            this.tables_add_tableName_label.Name = "tables_add_tableName_label";
            this.tables_add_tableName_label.Size = new System.Drawing.Size(101, 20);
            this.tables_add_tableName_label.TabIndex = 5;
            this.tables_add_tableName_label.Text = "Table name:";
            // 
            // tables_add_columnNames_listBox
            // 
            this.tables_add_columnNames_listBox.FormattingEnabled = true;
            this.tables_add_columnNames_listBox.ItemHeight = 16;
            this.tables_add_columnNames_listBox.Location = new System.Drawing.Point(373, 131);
            this.tables_add_columnNames_listBox.Name = "tables_add_columnNames_listBox";
            this.tables_add_columnNames_listBox.Size = new System.Drawing.Size(120, 148);
            this.tables_add_columnNames_listBox.TabIndex = 6;
            // 
            // tables_add_columnNames_label
            // 
            this.tables_add_columnNames_label.AutoSize = true;
            this.tables_add_columnNames_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tables_add_columnNames_label.Location = new System.Drawing.Point(234, 117);
            this.tables_add_columnNames_label.Name = "tables_add_columnNames_label";
            this.tables_add_columnNames_label.Size = new System.Drawing.Size(124, 20);
            this.tables_add_columnNames_label.TabIndex = 7;
            this.tables_add_columnNames_label.Text = "Column Names";
            // 
            // tables_add_columnNames_textBox
            // 
            this.tables_add_columnNames_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tables_add_columnNames_textBox.Location = new System.Drawing.Point(239, 140);
            this.tables_add_columnNames_textBox.Name = "tables_add_columnNames_textBox";
            this.tables_add_columnNames_textBox.Size = new System.Drawing.Size(120, 26);
            this.tables_add_columnNames_textBox.TabIndex = 8;
            // 
            // tables_add_addColumnNames_button
            // 
            this.tables_add_addColumnNames_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tables_add_addColumnNames_button.Location = new System.Drawing.Point(236, 179);
            this.tables_add_addColumnNames_button.Name = "tables_add_addColumnNames_button";
            this.tables_add_addColumnNames_button.Size = new System.Drawing.Size(120, 28);
            this.tables_add_addColumnNames_button.TabIndex = 9;
            this.tables_add_addColumnNames_button.Text = "Add";
            this.tables_add_addColumnNames_button.UseVisualStyleBackColor = true;
            // 
            // tables_add_removeColumnNames_button
            // 
            this.tables_add_removeColumnNames_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tables_add_removeColumnNames_button.Location = new System.Drawing.Point(238, 251);
            this.tables_add_removeColumnNames_button.Name = "tables_add_removeColumnNames_button";
            this.tables_add_removeColumnNames_button.Size = new System.Drawing.Size(120, 28);
            this.tables_add_removeColumnNames_button.TabIndex = 10;
            this.tables_add_removeColumnNames_button.Text = "Remove";
            this.tables_add_removeColumnNames_button.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(508, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 28);
            this.button1.TabIndex = 15;
            this.button1.Text = "Remove";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(508, 179);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 28);
            this.button2.TabIndex = 14;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(504, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Value Types";
            // 
            // tables_add_valueTypes_textBox
            // 
            this.tables_add_valueTypes_textBox.FormattingEnabled = true;
            this.tables_add_valueTypes_textBox.ItemHeight = 16;
            this.tables_add_valueTypes_textBox.Location = new System.Drawing.Point(634, 131);
            this.tables_add_valueTypes_textBox.Name = "tables_add_valueTypes_textBox";
            this.tables_add_valueTypes_textBox.Size = new System.Drawing.Size(129, 148);
            this.tables_add_valueTypes_textBox.TabIndex = 11;
            // 
            // tables_add_tip_label
            // 
            this.tables_add_tip_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tables_add_tip_label.Location = new System.Drawing.Point(456, 43);
            this.tables_add_tip_label.Name = "tables_add_tip_label";
            this.tables_add_tip_label.Size = new System.Drawing.Size(306, 65);
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
            this.tables_add_addValueType_comboBox.Location = new System.Drawing.Point(507, 140);
            this.tables_add_addValueType_comboBox.Name = "tables_add_addValueType_comboBox";
            this.tables_add_addValueType_comboBox.Size = new System.Drawing.Size(121, 28);
            this.tables_add_addValueType_comboBox.TabIndex = 18;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 541);
            this.Controls.Add(this.tables_add_addValueType_comboBox);
            this.Controls.Add(this.tables_add_tip_label);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tables_add_valueTypes_textBox);
            this.Controls.Add(this.tables_add_removeColumnNames_button);
            this.Controls.Add(this.tables_add_addColumnNames_button);
            this.Controls.Add(this.tables_add_columnNames_textBox);
            this.Controls.Add(this.tables_add_columnNames_label);
            this.Controls.Add(this.tables_add_columnNames_listBox);
            this.Controls.Add(this.tables_add_tableName_label);
            this.Controls.Add(this.tables_add_tableName_textBox);
            this.Controls.Add(this.dash_tables_label);
            this.Controls.Add(this.dash_tables_listBox);
            this.Controls.Add(this.dash_log_richTextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.Text = "SQL GUI Dashboard";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox tables_add_valueTypes_textBox;
        private System.Windows.Forms.Label tables_add_tip_label;
        private System.Windows.Forms.ComboBox tables_add_addValueType_comboBox;
    }
}