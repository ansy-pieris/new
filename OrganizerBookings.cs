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
    public partial class OrganizerBookings : UserControl
    {
        public OrganizerBookings()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.ParticipantsBookings_Load);
        }
        private static string connectionString = "server=localhost;database=eventmgtdb;user=root;password=;";
        private void LoadBookings()
        {
            try
            {
                int currentUserID = UserSession.CurrentUserID;

                if (UserSession.CurrentUserRole != "organizer")
                {
                    MessageBox.Show("Access denied. Only organizers can view bookings.");
                    return;
                }

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                SELECT b.booking_id, b.eventID, b.Participant_ID, b.eventname, b.fullname, b.email, b.phone, b.booking_date
                FROM bookings b
                JOIN events e ON b.eventID = e.eventID
                WHERE e.id = @organizerID";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@organizerID", currentUserID);

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

        private void OrganizerBookings_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int bookingID))
            {
                string result = Organizer.CancelBooking(bookingID);

                MessageBox.Show(result);
            }
            else
            {
                MessageBox.Show("Please enter a valid Booking ID.");
            }

            LoadBookings();
        }
    }
}
