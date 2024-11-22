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
    public partial class OrganizerEvents : UserControl
    {
        public OrganizerEvents()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.OrganizerEvents_Load);
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

        private void OrganizerEvents_Load(object sender, EventArgs e)
        {
            LoadEvents();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text) || !int.TryParse(textBox1.Text, out int eventID))
                {
                    MessageBox.Show("Please enter a valid Event ID.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(textBox4.Text))
                {
                    MessageBox.Show("Please enter an Event Name.");
                    return;
                }
                string eventName = textBox4.Text;

                DateTime dateTime = dateTimePicker1.Value;

                if (string.IsNullOrWhiteSpace(numericUpDown1.Text) || !int.TryParse(numericUpDown1.Text, out int maxParticipants))
                {
                    MessageBox.Show("Please enter a valid number for Maximum Participants.");
                    return;
                }
                /*Set Current Participants to 0 by default (No need for user input)*/
                int currentParticipants = 0;

                if (string.IsNullOrWhiteSpace(textBox3.Text))
                {
                    MessageBox.Show("Please enter a Venue.");
                    return;
                }
                string venue = textBox3.Text;

                if (string.IsNullOrWhiteSpace(textBox2.Text))
                {
                    MessageBox.Show("Please enter a Location.");
                    return;
                }
                string location = textBox2.Text;

                if (string.IsNullOrWhiteSpace(richTextBox1.Text))
                {
                    MessageBox.Show("Please enter a Description.");
                    return;
                }
                string description = richTextBox1.Text;

                string startTimeStr = textBox6.Text;
                string endTimeStr = textBox7.Text;

                if (!TimeSpan.TryParse(startTimeStr, out TimeSpan startTime) ||
                    !TimeSpan.TryParse(endTimeStr, out TimeSpan endTime))
                {
                    MessageBox.Show("Please enter valid times in HH:mm format.");
                    return;
                }

                if (endTime <= startTime)
                {
                    MessageBox.Show("End Time must be after Start Time.");
                    return;
                }
                /*Get the current user's ID from the UserSession (admin or organizer)*/
                int userID = UserSession.CurrentUser?.User_ID ?? 0; 

                Events newEvent = new Events(
                    eventID,
                    eventName,
                    dateTime,
                    maxParticipants,
                    currentParticipants, 
                    venue,
                    location,
                    description,
                    startTimeStr,  
                    endTimeStr     
                );

                string result = Organizer.addEvents(newEvent, userID);

                MessageBox.Show(result);

                LoadEvents();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                    string.IsNullOrWhiteSpace(textBox4.Text) ||
                    string.IsNullOrWhiteSpace(textBox3.Text) ||
                    string.IsNullOrWhiteSpace(textBox2.Text) ||
                    string.IsNullOrWhiteSpace(richTextBox1.Text))
                {
                    MessageBox.Show("Please fill in all required fields.");
                    return;
                }

                if (!int.TryParse(textBox1.Text, out int eventID))
                {
                    MessageBox.Show("Invalid Event ID.");
                    return;
                }

                if (!int.TryParse(numericUpDown1.Text, out int maxParticipants))
                {
                    MessageBox.Show("Invalid Maximum Participants.");
                    return;
                }

                int currentParticipants = 0;

                string eventName = textBox4.Text;
                DateTime dateTime = dateTimePicker1.Value;
                string venue = textBox3.Text;
                string location = textBox2.Text;
                string description = richTextBox1.Text;
                string startTimeStr = textBox6.Text;
                string endTimeStr = textBox7.Text;

                if (!TimeSpan.TryParse(startTimeStr, out TimeSpan startTime) ||
                    !TimeSpan.TryParse(endTimeStr, out TimeSpan endTime))
                {
                    MessageBox.Show("Please enter valid times in HH:mm format.");
                    return;
                }

                if (endTime <= startTime)
                {
                    MessageBox.Show("End Time must be after Start Time.");
                    return;
                }


                if (UserSession.CurrentUser == null || UserSession.CurrentUser.Role != "organizer")
                {
                    MessageBox.Show("You are not authorized to update this event.");
                    return;
                }
                int organizerID = UserSession.CurrentUser.User_ID;


                Events updatedEvent = new Events(
                    eventID,
                    eventName,
                    dateTime,
                    maxParticipants,
                    currentParticipants, 
                    venue,
                    location,
                    description,
                    startTimeStr, 
                    endTimeStr     
                );

                string result = Organizer.updateEvent(updatedEvent);
                LoadEvents();
                MessageBox.Show(result);

            }
            catch (FormatException fe)
            {
                MessageBox.Show("Error in input format: " + fe.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    MessageBox.Show("Please enter the Event ID to delete.");
                    return;
                }

                if (!int.TryParse(textBox1.Text, out int eventID))
                {
                    MessageBox.Show("Invalid Event ID.");
                    return;
                }

                if (UserSession.CurrentUser == null || UserSession.CurrentUser.Role != "organizer")
                {
                    MessageBox.Show("You are not authorized to delete events.");
                    return;
                }

                int organizerID = UserSession.CurrentUser.User_ID;

                string result = Organizer.deleteEvent(eventID);

                MessageBox.Show(result);

                LoadEvents();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox2.Text = string.Empty;
            richTextBox1.Text = string.Empty;

            numericUpDown1.Value = numericUpDown1.Minimum;
            textBox6.Text = string.Empty;
            textBox7.Text = string.Empty;
            dateTimePicker1.Value = DateTime.Now; 

        }

        private void OrganizerEvents_Load_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                textBox1.Text = selectedRow.Cells["eventID"].Value?.ToString();
                textBox4.Text = selectedRow.Cells["eventName"].Value?.ToString();

                if (DateTime.TryParse(selectedRow.Cells["dateTime"].Value?.ToString(), out DateTime parsedDate))
                {
                    dateTimePicker1.Value = parsedDate;
                }
                else
                {
                    dateTimePicker1.Value = DateTime.Now; 
                }

                if (int.TryParse(selectedRow.Cells["maximumParticipants"].Value?.ToString(), out int parsedParticipants))
                {
                    numericUpDown1.Value = parsedParticipants;
                }
                else
                {
                    numericUpDown1.Value = numericUpDown1.Minimum; 
                }

                textBox3.Text = selectedRow.Cells["venue"].Value?.ToString();
                textBox2.Text = selectedRow.Cells["location"].Value?.ToString(); 

                textBox6.Text = selectedRow.Cells["startTime"].Value?.ToString();
                textBox7.Text = selectedRow.Cells["endTime"].Value?.ToString();
                richTextBox1.Text = selectedRow.Cells["description"].Value?.ToString();
            }

        }
    }
}
