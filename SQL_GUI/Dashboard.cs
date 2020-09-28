using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_GUI
{
    public partial class Dashboard : Form
    {
        private string host;
        private string username;
        private string database;
        private string port;
        private string password;
        private SqlFunctions _sql = new SqlFunctions();

        public Dashboard(string host, string username, string database, string port, string password)
        {
            InitializeComponent();
            this.host = host;
            this.username = username;
            this.database = database;
            this.port = port;
            this.password = password;

            try
            {
                var version = _sql.CheckDatabaseVersion(host, username, password, database);

                this.dash_log_richTextBox.Text += "Successfully connected to database";
                this.dash_log_richTextBox.Text += Environment.NewLine;
                this.dash_log_richTextBox.Text += version;
            }
            catch(Exception ex)
            {
                this.dash_log_richTextBox.Text += "Error connecting to database:";
                this.dash_log_richTextBox.Text += Environment.NewLine;
                this.dash_log_richTextBox.Text += ex.Message;
            }
        }
    }
}
