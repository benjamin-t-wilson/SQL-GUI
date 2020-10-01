using System;
using System.Windows.Forms;

namespace SQL_GUI.Forms
{
    public partial class ConnectionBox : Form
    {
        public ConnectionBox()
        {
            InitializeComponent();
        }

        private void con_cancel_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void con_connect_button_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(con_host_textBox.Text) || string.IsNullOrWhiteSpace(con_user_textBox.Text) || string.IsNullOrWhiteSpace(con_database_textBox.Text) || string.IsNullOrWhiteSpace(con_port_textBox.Text) || string.IsNullOrWhiteSpace(con_password_textBox.Text))
            {
                return;
            }

            var dashboard = new Dashboard(con_host_textBox.Text, con_user_textBox.Text, con_database_textBox.Text, con_port_textBox.Text, con_password_textBox.Text);

            Hide();

            dashboard.Show();
        }
    }
}