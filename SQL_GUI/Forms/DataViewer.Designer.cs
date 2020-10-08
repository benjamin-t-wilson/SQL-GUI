namespace SQL_GUI.Forms
{
    partial class DataViewer
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
            this.dataViewer_dataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewer_dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataViewer_dataGrid
            // 
            this.dataViewer_dataGrid.AllowUserToAddRows = false;
            this.dataViewer_dataGrid.AllowUserToDeleteRows = false;
            this.dataViewer_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewer_dataGrid.Location = new System.Drawing.Point(12, 12);
            this.dataViewer_dataGrid.Name = "dataViewer_dataGrid";
            this.dataViewer_dataGrid.ReadOnly = true;
            this.dataViewer_dataGrid.RowHeadersWidth = 51;
            this.dataViewer_dataGrid.RowTemplate.Height = 24;
            this.dataViewer_dataGrid.Size = new System.Drawing.Size(1141, 507);
            this.dataViewer_dataGrid.TabIndex = 0;
            // 
            // DataViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 531);
            this.Controls.Add(this.dataViewer_dataGrid);
            this.Name = "DataViewer";
            this.Text = "DataViewer";
            ((System.ComponentModel.ISupportInitialize)(this.dataViewer_dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataViewer_dataGrid;
    }
}