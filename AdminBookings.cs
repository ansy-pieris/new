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
    public partial class AdminBookings : UserControl
    {
        public AdminBookings()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.ParticipantsBookings_Load);
        }
        private static string connectionString = "server=localhost;database=eventmgtdb;user=root;password=;";
        private void LoadBookings()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM bookings";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
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

        private void AdminBookings_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int bookingID))
            {
                
                string result = Admin.CancelBooking(bookingID);

                
                MessageBox.Show(result);
            }
            else
            {
                MessageBox.Show("Please enter a valid Booking ID.");
            }
            LoadBookings();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
