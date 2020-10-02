namespace SQL_GUI.Forms
{
    partial class ConnectionBox
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
            this.con_host_label = new System.Windows.Forms.Label();
            this.con_database_label = new System.Windows.Forms.Label();
            this.con_user_label = new System.Windows.Forms.Label();
            this.con_port_label = new System.Windows.Forms.Label();
            this.con_password_label = new System.Windows.Forms.Label();
            this.con_host_textBox = new System.Windows.Forms.TextBox();
            this.con_database_textBox = new System.Windows.Forms.TextBox();
            this.con_user_textBox = new System.Windows.Forms.TextBox();
            this.con_port_textBox = new System.Windows.Forms.TextBox();
            this.con_password_textBox = new System.Windows.Forms.TextBox();
            this.con_connect_button = new System.Windows.Forms.Button();
            this.con_cancel_button = new System.Windows.Forms.Button();
            this.con_nickname_textbox = new System.Windows.Forms.TextBox();
            this.con_nickname_label = new System.Windows.Forms.Label();
            this.con_savedConnections_label = new System.Windows.Forms.Label();
            this.con_saveConnection_checkbox = new System.Windows.Forms.CheckBox();
            this.con_savedConnections_comboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // con_host_label
            // 
            this.con_host_label.AutoSize = true;
            this.con_host_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.con_host_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.con_host_label.Location = new System.Drawing.Point(12, 9);
            this.con_host_label.Name = "con_host_label";
            this.con_host_label.Size = new System.Drawing.Size(50, 20);
            this.con_host_label.TabIndex = 0;
            this.con_host_label.Text = "Host:";
            // 
            // con_database_label
            // 
            this.con_database_label.AutoSize = true;
            this.con_database_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.con_database_label.Location = new System.Drawing.Point(12, 61);
            this.con_database_label.Name = "con_database_label";
            this.con_database_label.Size = new System.Drawing.Size(86, 20);
            this.con_database_label.TabIndex = 1;
            this.con_database_label.Text = "Database:";
            // 
            // con_user_label
            // 
            this.con_user_label.AutoSize = true;
            this.con_user_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.con_user_label.Location = new System.Drawing.Point(12, 113);
            this.con_user_label.Name = "con_user_label";
            this.con_user_label.Size = new System.Drawing.Size(50, 20);
            this.con_user_label.TabIndex = 2;
            this.con_user_label.Text = "User:";
            // 
            // con_port_label
            // 
            this.con_port_label.AutoSize = true;
            this.con_port_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.con_port_label.Location = new System.Drawing.Point(12, 165);
            this.con_port_label.Name = "con_port_label";
            this.con_port_label.Size = new System.Drawing.Size(45, 20);
            this.con_port_label.TabIndex = 3;
            this.con_port_label.Text = "Port:";
            // 
            // con_password_label
            // 
            this.con_password_label.AutoSize = true;
            this.con_password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.con_password_label.Location = new System.Drawing.Point(12, 217);
            this.con_password_label.Name = "con_password_label";
            this.con_password_label.Size = new System.Drawing.Size(88, 20);
            this.con_password_label.TabIndex = 4;
            this.con_password_label.Text = "Password:";
            // 
            // con_host_textBox
            // 
            this.con_host_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.con_host_textBox.Location = new System.Drawing.Point(17, 32);
            this.con_host_textBox.Name = "con_host_textBox";
            this.con_host_textBox.Size = new System.Drawing.Size(423, 26);
            this.con_host_textBox.TabIndex = 5;
            // 
            // con_database_textBox
            // 
            this.con_database_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.con_database_textBox.Location = new System.Drawing.Point(17, 84);
            this.con_database_textBox.Name = "con_database_textBox";
            this.con_database_textBox.Size = new System.Drawing.Size(423, 26);
            this.con_database_textBox.TabIndex = 6;
            // 
            // con_user_textBox
            // 
            this.con_user_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.con_user_textBox.Location = new System.Drawing.Point(17, 136);
            this.con_user_textBox.Name = "con_user_textBox";
            this.con_user_textBox.Size = new System.Drawing.Size(423, 26);
            this.con_user_textBox.TabIndex = 7;
            // 
            // con_port_textBox
            // 
            this.con_port_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.con_port_textBox.Location = new System.Drawing.Point(17, 188);
            this.con_port_textBox.Name = "con_port_textBox";
            this.con_port_textBox.Size = new System.Drawing.Size(423, 26);
            this.con_port_textBox.TabIndex = 8;
            // 
            // con_password_textBox
            // 
            this.con_password_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.con_password_textBox.Location = new System.Drawing.Point(17, 240);
            this.con_password_textBox.Name = "con_password_textBox";
            this.con_password_textBox.PasswordChar = '*';
            this.con_password_textBox.Size = new System.Drawing.Size(423, 26);
            this.con_password_textBox.TabIndex = 9;
            // 
            // con_connect_button
            // 
            this.con_connect_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.con_connect_button.Location = new System.Drawing.Point(12, 429);
            this.con_connect_button.Name = "con_connect_button";
            this.con_connect_button.Size = new System.Drawing.Size(175, 46);
            this.con_connect_button.TabIndex = 10;
            this.con_connect_button.Text = "Connect";
            this.con_connect_button.UseVisualStyleBackColor = true;
            this.con_connect_button.Click += new System.EventHandler(this.con_connect_button_Click);
            // 
            // con_cancel_button
            // 
            this.con_cancel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.con_cancel_button.Location = new System.Drawing.Point(264, 429);
            this.con_cancel_button.Name = "con_cancel_button";
            this.con_cancel_button.Size = new System.Drawing.Size(175, 46);
            this.con_cancel_button.TabIndex = 11;
            this.con_cancel_button.Text = "Cancel";
            this.con_cancel_button.UseVisualStyleBackColor = true;
            this.con_cancel_button.Click += new System.EventHandler(this.con_cancel_button_Click);
            // 
            // con_nickname_textbox
            // 
            this.con_nickname_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.con_nickname_textbox.Location = new System.Drawing.Point(17, 292);
            this.con_nickname_textbox.Name = "con_nickname_textbox";
            this.con_nickname_textbox.Size = new System.Drawing.Size(423, 26);
            this.con_nickname_textbox.TabIndex = 13;
            // 
            // con_nickname_label
            // 
            this.con_nickname_label.AutoSize = true;
            this.con_nickname_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.con_nickname_label.Location = new System.Drawing.Point(12, 269);
            this.con_nickname_label.Name = "con_nickname_label";
            this.con_nickname_label.Size = new System.Drawing.Size(88, 20);
            this.con_nickname_label.TabIndex = 12;
            this.con_nickname_label.Text = "Nickname:";
            // 
            // con_savedConnections_label
            // 
            this.con_savedConnections_label.AutoSize = true;
            this.con_savedConnections_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.con_savedConnections_label.Location = new System.Drawing.Point(12, 372);
            this.con_savedConnections_label.Name = "con_savedConnections_label";
            this.con_savedConnections_label.Size = new System.Drawing.Size(153, 20);
            this.con_savedConnections_label.TabIndex = 14;
            this.con_savedConnections_label.Text = "Saved Connections";
            // 
            // con_saveConnection_checkbox
            // 
            this.con_saveConnection_checkbox.AutoSize = true;
            this.con_saveConnection_checkbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.con_saveConnection_checkbox.Location = new System.Drawing.Point(16, 331);
            this.con_saveConnection_checkbox.Name = "con_saveConnection_checkbox";
            this.con_saveConnection_checkbox.Size = new System.Drawing.Size(186, 24);
            this.con_saveConnection_checkbox.TabIndex = 15;
            this.con_saveConnection_checkbox.Text = "Save this connection";
            this.con_saveConnection_checkbox.UseVisualStyleBackColor = true;
            // 
            // con_savedConnections_comboBox
            // 
            this.con_savedConnections_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.con_savedConnections_comboBox.FormattingEnabled = true;
            this.con_savedConnections_comboBox.Location = new System.Drawing.Point(193, 369);
            this.con_savedConnections_comboBox.Name = "con_savedConnections_comboBox";
            this.con_savedConnections_comboBox.Size = new System.Drawing.Size(246, 28);
            this.con_savedConnections_comboBox.TabIndex = 16;
            this.con_savedConnections_comboBox.SelectionChangeCommitted += new System.EventHandler(this.con_savedConnections_comboBox_SelectionChangeCommitted);
            // 
            // ConnectionBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 487);
            this.Controls.Add(this.con_savedConnections_comboBox);
            this.Controls.Add(this.con_saveConnection_checkbox);
            this.Controls.Add(this.con_savedConnections_label);
            this.Controls.Add(this.con_nickname_textbox);
            this.Controls.Add(this.con_nickname_label);
            this.Controls.Add(this.con_cancel_button);
            this.Controls.Add(this.con_connect_button);
            this.Controls.Add(this.con_password_textBox);
            this.Controls.Add(this.con_port_textBox);
            this.Controls.Add(this.con_user_textBox);
            this.Controls.Add(this.con_database_textBox);
            this.Controls.Add(this.con_host_textBox);
            this.Controls.Add(this.con_password_label);
            this.Controls.Add(this.con_port_label);
            this.Controls.Add(this.con_user_label);
            this.Controls.Add(this.con_database_label);
            this.Controls.Add(this.con_host_label);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(471, 470);
            this.Name = "ConnectionBox";
            this.Text = "Connect to database";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label con_host_label;
        private System.Windows.Forms.Label con_database_label;
        private System.Windows.Forms.Label con_user_label;
        private System.Windows.Forms.Label con_port_label;
        private System.Windows.Forms.Label con_password_label;
        private System.Windows.Forms.TextBox con_host_textBox;
        private System.Windows.Forms.TextBox con_database_textBox;
        private System.Windows.Forms.TextBox con_user_textBox;
        private System.Windows.Forms.TextBox con_port_textBox;
        private System.Windows.Forms.TextBox con_password_textBox;
        private System.Windows.Forms.Button con_connect_button;
        private System.Windows.Forms.Button con_cancel_button;
        private System.Windows.Forms.TextBox con_nickname_textbox;
        private System.Windows.Forms.Label con_nickname_label;
        private System.Windows.Forms.Label con_savedConnections_label;
        private System.Windows.Forms.CheckBox con_saveConnection_checkbox;
        private System.Windows.Forms.ComboBox con_savedConnections_comboBox;
    }
}

