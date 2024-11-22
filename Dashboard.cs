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
using System.Xml.Linq;

namespace EventMGTNew
{
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
            txtNewPassword.PasswordChar = '*';
            this.Load += new EventHandler(Dashboard_Load);
        }
        private static string connectionString = "server=localhost;database=eventmgtdb;user=root;password=;";

        private void Dashboard_Load(object sender, EventArgs e)
        {
            LoadUserDetails();
           
        }

       


        private void LoadUserDetails()
        {


            try
            {
                int userID = UserSession.CurrentUser.User_ID;

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT fullname, email,role, username, password FROM usertable WHERE id = @userID";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@userID", userID);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtName.Text = reader["fullname"].ToString();
                                txtEmail.Text = reader["email"].ToString();
                                textRole.Text = reader["role"].ToString();
                                txtUsername.Text = reader["username"].ToString();
                                txtPassword.Text = reader["password"].ToString(); 

                                txtName.ReadOnly = true;
                                txtEmail.ReadOnly = true;
                                txtUsername.ReadOnly = true;
                                txtPassword.ReadOnly = true;
                            }
                            else
                            {
                                MessageBox.Show("User not found.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching user details: " + ex.Message);
            }
        }

       
        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string newPassword = txtNewPassword.Text;

                if (string.IsNullOrWhiteSpace(newPassword))
                {
                    MessageBox.Show("Please enter a new password.");
                    return;
                }

                int userID = UserSession.CurrentUser.User_ID;

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "UPDATE usertable SET password = @password WHERE id = @userID";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@password", newPassword); 
                        command.Parameters.AddWithValue("@userID", userID);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Password updated successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Error updating password. User may not exist.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating password: " + ex.Message);
            }
        }

    }
}
