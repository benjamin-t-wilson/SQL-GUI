using SQL_GUI.DTOs;
using System.Data;
using System.Windows.Forms;

namespace SQL_GUI.Forms
{
    public partial class DataViewer : Form
    {
        public DataViewer(DataViewerDto dto)
        {
            InitializeComponent();

            var table = new DataTable();

            if (dto.Columns.Count == 0 || dto.Values.Count == 0)
            {
                table.Columns.Add("Query yielded");
                table.Rows.Add(new string[] { "no results" });
            }
            else
            {
                foreach (var col in dto.Columns)
                {
                    table.Columns.Add(col);
                }

                foreach (var row in dto.Values)
                {
                    table.Rows.Add(row.ToArray());
                }
            }

            dataViewer_dataGrid.DataSource = table;
        }
    }
}