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
            this.dash_select_label = new System.Windows.Forms.Label();
            this.dash_select_listBox = new System.Windows.Forms.ListBox();
            this.dash_selectFrom_label = new System.Windows.Forms.Label();
            this.dash_selectFrom_listBox = new System.Windows.Forms.ListBox();
            this.dash_selectExecute_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dash_log_richTextBox
            // 
            this.dash_log_richTextBox.Location = new System.Drawing.Point(12, 303);
            this.dash_log_richTextBox.Name = "dash_log_richTextBox";
            this.dash_log_richTextBox.Size = new System.Drawing.Size(736, 226);
            this.dash_log_richTextBox.TabIndex = 0;
            this.dash_log_richTextBox.Text = "";
            // 
            // dash_select_label
            // 
            this.dash_select_label.AutoSize = true;
            this.dash_select_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dash_select_label.Location = new System.Drawing.Point(9, 9);
            this.dash_select_label.Name = "dash_select_label";
            this.dash_select_label.Size = new System.Drawing.Size(73, 25);
            this.dash_select_label.TabIndex = 1;
            this.dash_select_label.Text = "Select:";
            // 
            // dash_select_listBox
            // 
            this.dash_select_listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dash_select_listBox.FormattingEnabled = true;
            this.dash_select_listBox.ItemHeight = 25;
            this.dash_select_listBox.Location = new System.Drawing.Point(88, 9);
            this.dash_select_listBox.Name = "dash_select_listBox";
            this.dash_select_listBox.Size = new System.Drawing.Size(221, 29);
            this.dash_select_listBox.TabIndex = 2;
            // 
            // dash_selectFrom_label
            // 
            this.dash_selectFrom_label.AutoSize = true;
            this.dash_selectFrom_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dash_selectFrom_label.Location = new System.Drawing.Point(315, 9);
            this.dash_selectFrom_label.Name = "dash_selectFrom_label";
            this.dash_selectFrom_label.Size = new System.Drawing.Size(50, 25);
            this.dash_selectFrom_label.TabIndex = 3;
            this.dash_selectFrom_label.Text = "from";
            // 
            // dash_selectFrom_listBox
            // 
            this.dash_selectFrom_listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dash_selectFrom_listBox.FormattingEnabled = true;
            this.dash_selectFrom_listBox.ItemHeight = 25;
            this.dash_selectFrom_listBox.Location = new System.Drawing.Point(371, 9);
            this.dash_selectFrom_listBox.Name = "dash_selectFrom_listBox";
            this.dash_selectFrom_listBox.Size = new System.Drawing.Size(221, 29);
            this.dash_selectFrom_listBox.TabIndex = 4;
            // 
            // dash_selectExecute_button
            // 
            this.dash_selectExecute_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dash_selectExecute_button.Location = new System.Drawing.Point(624, 9);
            this.dash_selectExecute_button.Name = "dash_selectExecute_button";
            this.dash_selectExecute_button.Size = new System.Drawing.Size(124, 29);
            this.dash_selectExecute_button.TabIndex = 5;
            this.dash_selectExecute_button.Text = "Execute";
            this.dash_selectExecute_button.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.dash_selectExecute_button.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 541);
            this.Controls.Add(this.dash_selectExecute_button);
            this.Controls.Add(this.dash_selectFrom_listBox);
            this.Controls.Add(this.dash_selectFrom_label);
            this.Controls.Add(this.dash_select_listBox);
            this.Controls.Add(this.dash_select_label);
            this.Controls.Add(this.dash_log_richTextBox);
            this.Name = "Dashboard";
            this.Text = "SQL GUI Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox dash_log_richTextBox;
        private System.Windows.Forms.Label dash_select_label;
        private System.Windows.Forms.ListBox dash_select_listBox;
        private System.Windows.Forms.Label dash_selectFrom_label;
        private System.Windows.Forms.ListBox dash_selectFrom_listBox;
        private System.Windows.Forms.Button dash_selectExecute_button;
    }
}