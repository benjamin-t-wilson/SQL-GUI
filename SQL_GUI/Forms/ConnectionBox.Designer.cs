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
            this.SuspendLayout();
            // 
            // con_host_label
            // 
            this.con_host_label.AutoSize = true;
            this.con_host_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.con_host_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.con_host_label.Location = new System.Drawing.Point(12, 9);
            this.con_host_label.Name = "con_host_label";
            this.con_host_label.Size = new System.Drawing.Size(68, 29);
            this.con_host_label.TabIndex = 0;
            this.con_host_label.Text = "Host:";
            // 
            // con_database_label
            // 
            this.con_database_label.AutoSize = true;
            this.con_database_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.con_database_label.Location = new System.Drawing.Point(12, 74);
            this.con_database_label.Name = "con_database_label";
            this.con_database_label.Size = new System.Drawing.Size(121, 29);
            this.con_database_label.TabIndex = 1;
            this.con_database_label.Text = "Database:";
            // 
            // con_user_label
            // 
            this.con_user_label.AutoSize = true;
            this.con_user_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.con_user_label.Location = new System.Drawing.Point(12, 140);
            this.con_user_label.Name = "con_user_label";
            this.con_user_label.Size = new System.Drawing.Size(70, 29);
            this.con_user_label.TabIndex = 2;
            this.con_user_label.Text = "User:";
            // 
            // con_port_label
            // 
            this.con_port_label.AutoSize = true;
            this.con_port_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.con_port_label.Location = new System.Drawing.Point(12, 206);
            this.con_port_label.Name = "con_port_label";
            this.con_port_label.Size = new System.Drawing.Size(63, 29);
            this.con_port_label.TabIndex = 3;
            this.con_port_label.Text = "Port:";
            // 
            // con_password_label
            // 
            this.con_password_label.AutoSize = true;
            this.con_password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.con_password_label.Location = new System.Drawing.Point(12, 272);
            this.con_password_label.Name = "con_password_label";
            this.con_password_label.Size = new System.Drawing.Size(126, 29);
            this.con_password_label.TabIndex = 4;
            this.con_password_label.Text = "Password:";
            // 
            // con_host_textBox
            // 
            this.con_host_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.con_host_textBox.Location = new System.Drawing.Point(17, 41);
            this.con_host_textBox.Name = "con_host_textBox";
            this.con_host_textBox.Size = new System.Drawing.Size(423, 30);
            this.con_host_textBox.TabIndex = 5;
            // 
            // con_database_textBox
            // 
            this.con_database_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.con_database_textBox.Location = new System.Drawing.Point(17, 107);
            this.con_database_textBox.Name = "con_database_textBox";
            this.con_database_textBox.Size = new System.Drawing.Size(423, 30);
            this.con_database_textBox.TabIndex = 6;
            // 
            // con_user_textBox
            // 
            this.con_user_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.con_user_textBox.Location = new System.Drawing.Point(17, 173);
            this.con_user_textBox.Name = "con_user_textBox";
            this.con_user_textBox.Size = new System.Drawing.Size(423, 30);
            this.con_user_textBox.TabIndex = 7;
            // 
            // con_port_textBox
            // 
            this.con_port_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.con_port_textBox.Location = new System.Drawing.Point(17, 239);
            this.con_port_textBox.Name = "con_port_textBox";
            this.con_port_textBox.Size = new System.Drawing.Size(423, 30);
            this.con_port_textBox.TabIndex = 8;
            // 
            // con_password_textBox
            // 
            this.con_password_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.con_password_textBox.Location = new System.Drawing.Point(13, 305);
            this.con_password_textBox.Name = "con_password_textBox";
            this.con_password_textBox.PasswordChar = '*';
            this.con_password_textBox.Size = new System.Drawing.Size(427, 30);
            this.con_password_textBox.TabIndex = 9;
            // 
            // con_connect_button
            // 
            this.con_connect_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.con_connect_button.Location = new System.Drawing.Point(13, 362);
            this.con_connect_button.Name = "con_connect_button";
            this.con_connect_button.Size = new System.Drawing.Size(175, 46);
            this.con_connect_button.TabIndex = 10;
            this.con_connect_button.Text = "Connect";
            this.con_connect_button.UseVisualStyleBackColor = true;
            this.con_connect_button.Click += new System.EventHandler(this.con_connect_button_Click);
            // 
            // con_cancel_button
            // 
            this.con_cancel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.con_cancel_button.Location = new System.Drawing.Point(265, 362);
            this.con_cancel_button.Name = "con_cancel_button";
            this.con_cancel_button.Size = new System.Drawing.Size(175, 46);
            this.con_cancel_button.TabIndex = 11;
            this.con_cancel_button.Text = "Cancel";
            this.con_cancel_button.UseVisualStyleBackColor = true;
            this.con_cancel_button.Click += new System.EventHandler(this.con_cancel_button_Click);
            // 
            // ConnectionBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 423);
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
            this.MaximumSize = new System.Drawing.Size(471, 470);
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
    }
}

