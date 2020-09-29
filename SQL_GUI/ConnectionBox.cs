using System;
using System.Windows.Forms;

namespace SQL_GUI
{
    public partial class ConnectionBox : Form
    {
        public ConnectionBox()
        {
            InitializeComponent();
        }

        private void con_cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void con_connect_button_Click(object sender, EventArgs e)
        {
            var dashboard = new Dashboard(this.con_host_textBox.Text, this.con_user_textBox.Text, this.con_database_textBox.Text, this.con_port_textBox.Text, this.con_password_textBox.Text);

            this.Hide();

            dashboard.Show();
        }
    }
}