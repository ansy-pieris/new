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

namespace EventMGTNew
{
    public partial class ParticipantRegistrations : UserControl
    {
        public ParticipantRegistrations()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.ParticipantsBookings_Load);
            dataGridView1.CellClick += dataGridView1_CellContentClick;

        }
        private static string connectionString = "server=localhost;database=eventmgtdb;user=root;password=;";
        private void LoadBookings()
        {
            try
            {
                if (!UserSession.IsLoggedIn() || !UserSession.CurrentUser.Role.Equals("participant", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Access denied. Only participants can view their bookings.");
                    return;
                }


                int currentParticipantID = UserSession.CurrentUser.User_ID;

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                SELECT b.booking_id, b.eventID, b.eventname, b.fullname, b.email, b.phone, b.booking_date
                FROM bookings b
                WHERE b.Participant_ID = @participantID";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@participantID", currentParticipantID);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable bookingTable = new DataTable();
                            adapter.Fill(bookingTable);

                            dataGridView1.DataSource = null;
                            dataGridView1.DataSource = bookingTable;
                            dataGridView1.Refresh();

                            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            dataGridView1.RowTemplate.Height = 25;
                            dataGridView1.ScrollBars = ScrollBars.Both;
                        }
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
        private void ParticipantsBookings_Load(object sender, EventArgs e)
        {
            LoadBookings();
        }
        public void RefreshBookings()
        {
            LoadBookings();
        }

        private void ParticipantRegistrations_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox2.Text, out int bookingID))
            {
                string result = Participant.CancelBooking(bookingID);

                MessageBox.Show(result);
            }
            else
            {
                MessageBox.Show("Please enter a valid Booking ID.");
            }

            LoadBookings();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox6.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox5.Text) ||
                string.IsNullOrWhiteSpace(textBox7.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (!int.TryParse(textBox2.Text, out int bookingID) ||
                !int.TryParse(textBox6.Text, out int eventID))
            {
                MessageBox.Show("Please enter valid ID.");
                return;
            }

            string result = Participant.UpdateBooking(bookingID, eventID, textBox4.Text, textBox3.Text,
                                          textBox5.Text, textBox7.Text, dateTimePicker1.Value);

            LoadBookings();
            MessageBox.Show(result);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                textBox6.Text = selectedRow.Cells["eventID"].Value?.ToString();
                textBox4.Text = selectedRow.Cells["eventName"].Value?.ToString();
                textBox3.Text = selectedRow.Cells["fullname"].Value?.ToString();
                textBox5.Text = selectedRow.Cells["email"].Value?.ToString();
                textBox7.Text = selectedRow.Cells["phone"].Value?.ToString();
                textBox2.Text = selectedRow.Cells["booking_id"].Value?.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadBookings();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox6.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox7.Text = string.Empty;
            textBox2.Text = string.Empty;
            dateTimePicker1.Value = DateTime.Now;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
