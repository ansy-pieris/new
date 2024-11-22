using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EventMGTNew
{
    public partial class ParticipantsEvents : UserControl
    {
        public ParticipantsEvents()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.ParticipantsEvents_Load);
            dataGridView1.CellClick += dataGridView1_CellContentClick;

        }
        private static string connectionString = "server=localhost;database=eventmgtdb;user=root;password=;";

        private void LoadEvents()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM events";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        DataTable eventsTable = new DataTable();
                        adapter.Fill(eventsTable);

                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = eventsTable;
                        dataGridView1.Refresh();

                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message);
            }
        }

        private void ParticipantsEvents_Load(object sender, EventArgs e)
        {
            LoadEvents();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                string eventID = row.Cells["eventID"].Value.ToString();
                string eventName = row.Cells["eventName"].Value.ToString();

                textBox1.Text = eventID;
                textBox4.Text = eventName;
            }
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(textBox1.Text, out int eventID))
                {
                    MessageBox.Show("Invalid Event ID.");
                    return;
                }

                string eventName = textBox4.Text.Trim();
                if (string.IsNullOrWhiteSpace(eventName))
                {
                    MessageBox.Show("Event Name cannot be empty.");
                    return;
                }

                string fullname = textBox3.Text.Trim();
                if (string.IsNullOrWhiteSpace(fullname))
                {
                    MessageBox.Show("Full Name cannot be empty.");
                    return;
                }

                string email = textBox5.Text.Trim();
                if (!IsValidEmail(email))
                {
                    MessageBox.Show("Invalid email format.");
                    return;
                }

                string phone = textBox7.Text.Trim();
                if (!long.TryParse(phone, out _))
                {
                    MessageBox.Show("Invalid phone number format.");
                    return;
                }

                DateTime bookingDate = dateTimePicker1.Value;
                if (bookingDate > DateTime.Now)
                {
                    MessageBox.Show("Booking date cannot be in the future.");
                    return;
                }

                string result = Participant.RegisterBooking(eventID, eventName, fullname, email, phone, bookingDate);

                MessageBox.Show(result);

                var ParticipantRegistrations = Application.OpenForms.OfType<ParticipantRegistrations>().FirstOrDefault();
                if (ParticipantRegistrations != null)
                {
                    ParticipantRegistrations.RefreshBookings();
                }

                LoadEvents();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                textBox1.Text = selectedRow.Cells["eventID"].Value?.ToString();
                textBox4.Text = selectedRow.Cells["eventName"].Value?.ToString();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox7.Text = string.Empty;
            dateTimePicker1.Value = DateTime.Now;
        }
    }
}
