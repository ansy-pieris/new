using MySql.Data.MySqlClient;

namespace EventMGTNew
{
    public partial class Form1 : Form
    {
        public Point mouseLocation;
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            textBox2.PasswordChar = '*';
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionstring = "server=localhost;database=eventmgtdb;user=root;password=;";
            string userinput1 = textBox1.Text;
            string userinput2 = textBox2.Text;

            using (MySqlConnection conn = new MySqlConnection(connectionstring))
            {
                try
                {
                    conn.Open();

                    string query1 = "SELECT id, role FROM usertable WHERE username=@username AND password=@password";

                    MySqlCommand cmd1 = new MySqlCommand(query1, conn);
                    cmd1.Parameters.AddWithValue("@username", userinput1);
                    cmd1.Parameters.AddWithValue("@password", userinput2); 

                    using (MySqlDataReader reader = cmd1.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int userID = reader.GetInt32("id");
                            string role = reader.GetString("role");

                            string capitalizedInput1 = userinput1.Substring(0, 1).ToUpper() + userinput1.Substring(1).ToLower();

                            string article = "a";
                            if (!string.IsNullOrEmpty(role) && "AEIOUaeiou".IndexOf(role[0]) >= 0)
                            {
                                article = "an";
                            }

                            MessageBox.Show($"Welcome {capitalizedInput1}. You have successfully logged in as {article} {role}.");

                            UserSession.CurrentUser = new UserSession(userID, userinput1, role);
                           

                            if (role == "admin")
                            {
                                AdminDashboard adminDashboard = new AdminDashboard();
                                adminDashboard.Show();
                            }
                            else if (role == "organizer")
                            {
                                OrganizerDashboard organizerDashboard = new OrganizerDashboard();
                                organizerDashboard.Show();
                            }
                            else if (role == "participant")
                            {
                                ParticipantDashboard participantDashboard = new ParticipantDashboard();
                                participantDashboard.Show();
                            }

                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }


        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            string connectionstring = "server=localhost;database=eventmgtdb;user=root;password=;";
            string userinput1 = textBox1.Text;
            string userinput2 = textBox2.Text;

            using (MySqlConnection conn = new MySqlConnection(connectionstring))
            {
                try
                {
                    conn.Open();

                    string query1 = "SELECT id, role FROM usertable WHERE username=@username AND password=@password";

                    MySqlCommand cmd1 = new MySqlCommand(query1, conn);
                    cmd1.Parameters.AddWithValue("@username", userinput1);
                    cmd1.Parameters.AddWithValue("@password", userinput2); 

                    using (MySqlDataReader reader = cmd1.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int userID = reader.GetInt32("id");
                            string role = reader.GetString("role");

                            string capitalizedInput1 = userinput1.Substring(0, 1).ToUpper() + userinput1.Substring(1).ToLower();

                            string article = "a";
                            if (!string.IsNullOrEmpty(role) && "AEIOUaeiou".IndexOf(role[0]) >= 0)
                            {
                                article = "an";
                            }

                            MessageBox.Show($"Welcome {capitalizedInput1}. You have successfully logged in as {article} {role}.");

                            UserSession.CurrentUser = new UserSession(userID, userinput1, role);
                           

                            if (role == "admin")
                            {
                                AdminDashboard adminDashboard = new AdminDashboard();
                                adminDashboard.Show();
                            }
                            else if (role == "organizer")
                            {
                                OrganizerDashboard organizerDashboard = new OrganizerDashboard();
                                organizerDashboard.Show();
                            }
                            else if (role == "participant")
                            {
                                ParticipantDashboard participantDashboard = new ParticipantDashboard();
                                participantDashboard.Show();
                            }

                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
            }

        }

        private void mouse_Down(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void mouse_Move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }
    }
}