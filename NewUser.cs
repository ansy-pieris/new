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
    public partial class NewUser : UserControl
    {
        public NewUser()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.NewUser_Load);
            dataGridView1.CellClick += dataGridView1_CellContentClick;
        }
        private static string connectionString = "server=localhost;database=eventmgtdb;user=root;password=;";
        private void LoadUsers()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM usertable";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        DataTable userTable = new DataTable();
                        adapter.Fill(userTable);

                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = userTable;
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
        private void NewUser_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string fullname = textBox1.Text;
                string email = textBox2.Text;

                int phone;
                if (!int.TryParse(textBox3.Text, out phone))
                {
                    MessageBox.Show("Invalid phone number format.");
                    return;
                }

                string username = textBox4.Text;
                string password = textBox5.Text;

                if (cmbRole.SelectedItem == null)
                {
                    MessageBox.Show("Please select a role.");
                    return;
                }
                string role = cmbRole.SelectedItem.ToString();

                string result = Admin.CreateUser(fullname, email, phone, username, password, role);


                MessageBox.Show(result);
                LoadUsers();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Input format error: " + ex.Message);
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

        private void txtFullname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                
                textBox6.Text = selectedRow.Cells["id"].Value?.ToString();
                textBox1.Text = selectedRow.Cells["fullname"].Value?.ToString();
                textBox2.Text = selectedRow.Cells["email"].Value?.ToString();
                textBox4.Text = selectedRow.Cells["username"].Value?.ToString();
                textBox3.Text = selectedRow.Cells["Phone"].Value?.ToString();
                textBox5.Text = selectedRow.Cells["password"].Value?.ToString(); 
                cmbRole.Text = selectedRow.Cells["role"].Value?.ToString();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NewUser_Load_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox6.Text = string.Empty;
            cmbRole.SelectedIndex = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int userId;
                if (!int.TryParse(textBox6.Text, out userId))
                {
                    MessageBox.Show("Invalid User ID format.");
                    return;
                }

                string fullname = textBox1.Text;
                string email = textBox2.Text;

                int phone;
                if (!int.TryParse(textBox3.Text, out phone))
                {
                    MessageBox.Show("Invalid phone number format.");
                    return;
                }

                string username = textBox4.Text;
                string password = textBox5.Text;

                if (cmbRole.SelectedItem == null)
                {
                    MessageBox.Show("Please select a role.");
                    return;
                }
                string role = cmbRole.SelectedItem.ToString();

                string result = Admin.UpdateUser(userId, fullname, email, phone, username, password, role);

                MessageBox.Show(result);
                LoadUsers();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Input format error: " + ex.Message);
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrEmpty(textBox6.Text))
                {
                    MessageBox.Show("Please enter a valid User ID.");
                    return;
                }

                int userID;
                if (!int.TryParse(textBox6.Text, out userID))
                {
                    MessageBox.Show("Invalid User ID format.");
                    return;
                }

                DataTable userTable = Admin.SearchUserByID(userID);

                if (userTable != null && userTable.Rows.Count > 0)
                {
                    dataGridView1.DataSource = userTable;
                }
                else
                {
                    MessageBox.Show("No user found with the specified ID.");
                }
               LoadUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBox6.Text))
                {
                    MessageBox.Show("Please enter a valid User ID.");
                    return;
                }

                int userID;
                if (!int.TryParse(textBox6.Text, out userID))
                {
                    MessageBox.Show("Invalid User ID format.");
                    return;
                }

                string result = Admin.DeleteUser(userID);

                MessageBox.Show(result);
                LoadUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
