using SQL_GUI.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_GUI.Forms
{
    public partial class DataViewer : Form
    {
        public DataViewer(DataViewerDto dto)
        {
            InitializeComponent();
            //var index = this.dataGridView1.Rows.Add();
            //this.dataGridView1.Rows[index].Cells[1].Value = "1";
            //this.dataGridView1.Rows[index].Cells[2].Value = "Baqar";

            var table = new DataTable();
            foreach(var col in dto.Columns)
            {
                table.Columns.Add(col);
            }

            foreach(var row in dto.Values)
            {
                table.Rows.Add(row);
            }

            dataViewer_dataGrid.DataSource = table;
        }
    }
}
