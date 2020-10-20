using SQL_GUI.DTOs;
using SQL_GUI.Functions;
using System;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace SQL_GUI.Forms
{
    public partial class ConnectionBox : Form
    {
        private readonly SqliteConnStorage _sqlite = new SqliteConnStorage();

        public ConnectionBox()
        {
            InitializeComponent();

            ResetNickNames();
        }

        public void PlayErrorSound()
        {
            SoundPlayer player = new SoundPlayer(@"C:\Windows\Media\Windows Ding.wav");
            player.Load();
            player.Play();
        }

        private void con_cancel_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void con_connect_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(con_host_textBox.Text) || string.IsNullOrWhiteSpace(con_user_textBox.Text) || string.IsNullOrWhiteSpace(con_database_textBox.Text) || string.IsNullOrWhiteSpace(con_port_textBox.Text) || string.IsNullOrWhiteSpace(con_password_textBox.Text))
            {
                PlayErrorSound();
                return;
            }

            var dto = new ConnectionDto()
            {
                Host = con_host_textBox.Text,
                Username = con_user_textBox.Text,
                Database = con_database_textBox.Text,
                Port = con_port_textBox.Text,
                Password = con_password_textBox.Text,
                Nickname = con_nickname_textbox.Text
            };

            if (con_saveConnection_checkbox.Checked)
            {
                _sqlite.AddData(dto);
            }

            foreach (Control ctrl in Controls.OfType<TextBox>())
            {
                ctrl.Text = string.Empty;
            }

            con_savedConnections_comboBox.ResetText();
            con_forget_button.Visible = false;

            var dashboard = new Dashboard(dto, this);

            Hide();

            dashboard.Show();
        }

        private void con_savedConnections_comboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var dto = _sqlite.GetConnectionInfo(con_savedConnections_comboBox.SelectedItem.ToString());

            con_host_textBox.Text = dto.Host;
            con_user_textBox.Text = dto.Username;
            con_database_textBox.Text = dto.Database;
            con_port_textBox.Text = dto.Port;
            con_password_textBox.Text = dto.Password;
            con_nickname_textbox.Text = dto.Nickname;

            con_forget_button.Visible = true;
        }

        private void con_forget_button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(con_nickname_textbox.Text))
            {
                _sqlite.RemoveData(con_nickname_textbox.Text);
                ResetNickNames();
                con_forget_button.Visible = false;
                con_savedConnections_comboBox.SelectedIndex = -1;
            }
        }

        private void ResetNickNames()
        {
            var names = _sqlite.GetNickNames();

            foreach (var name in names)
            {
                con_savedConnections_comboBox.Items.Add(name);
            }
        }
    }
}