using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMGTNew
{
    internal class DataBase
    {
        private static string connectionString = "server=localhost;database=eventmgtdb;user=root;password=;";

        public static string AddEvent(Events events, int userId)
        {

            /*Checks if the event object is null and return an error message if it is.*/
            if (events == null)
            {
                return "Event cannot be null.";
            }

            try
            {
                /*Creating a connection to the MySQL database*/
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    /*Opens the database connection*/
                    connection.Open();

                    /*checks if an event with the same eventID already exists in the database.*/
                    string checkQuery = "SELECT COUNT(*) FROM events WHERE eventID = @eventID";
                    using (MySqlCommand checkCommand = new MySqlCommand(checkQuery, connection))
                    {
                        /*Add the eventID parameter to the query to avoid SQL injection.*/
                        checkCommand.Parameters.AddWithValue("@eventID", events.EventID);

                        /* Execute the query and store the result (number of events with the same eventID).*/
                        int count = Convert.ToInt32(checkCommand.ExecuteScalar());

                        /*If the count is greater than 0, it means the event already exists, so return an error message.*/
                        if (count > 0)
                        {
                            return "Event with the same ID already exists.";
                        }
                    }
                    /*Insert query to add the new event into the 'events' table in the database.*/
                    string query = @"INSERT INTO events (eventID, eventName, dateTime, maximumParticipants, currentParticipants, venue, location, description, startTime, endTime, id) 
                                    VALUES (@eventID, @eventName, @dateTime, @maximumParticipants, @currentParticipants, @venue, @location, @description, @startTime, @endTime, @userId)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        /*Add all the parameters to the insert query, mapping them to the event's properties and the userId.*/
                        command.Parameters.AddWithValue("@eventID", events.EventID);
                        command.Parameters.AddWithValue("@eventName", events.EventName);
                        command.Parameters.AddWithValue("@dateTime", events.DateTime);
                        command.Parameters.AddWithValue("@maximumParticipants", events.MaximumParticipants);
                        command.Parameters.AddWithValue("@currentParticipants", events.CurrentParticipants);
                        command.Parameters.AddWithValue("@venue", events.Venue);
                        command.Parameters.AddWithValue("@location", events.Location);
                        command.Parameters.AddWithValue("@description", events.Description);
                        command.Parameters.AddWithValue("@startTime", events.StartTime);
                        command.Parameters.AddWithValue("@endTime", events.EndTime);
                        command.Parameters.AddWithValue("@userId", userId);

                        /*Execute the insert command to add the event to the database.*/
                        command.ExecuteNonQuery();
                    }
                }
                return "Event added successfully!";
            }
            catch (MySqlException ex)
            {
                /*If there is any MySQL-related error, catch the exception and return an error message with details.*/
                return "Error adding the event: " + ex.Message;
            }
        }

        public static string UpdateEvent(Events updatedEvent)
        {
            /*Check if the updated event object is null, and return an error message if it is.*/
            if (updatedEvent == null)
            {
                return "Event cannot be null.";
            }

            /*Retrieve the current user ID and role from the user session.*/
            int currentUserID = UserSession.CurrentUser.User_ID;  
            string currentUserRole = UserSession.CurrentUser.Role; 

            try
            {
                /*connection to the MySQL database.*/
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    /*check if the event with the specified eventID exists and retrieve the organizer's ID.*/
                    string checkQuery = "SELECT id FROM events WHERE eventID = @eventID";
                    int eventOrganizerID;
                    using (MySqlCommand checkCommand = new MySqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@eventID", updatedEvent.EventID);

                        /*Execute the query and store the result (organizer's ID)*/
                        object result = checkCommand.ExecuteScalar();

                        /*If the event does not exist, return an error message.*/
                        if (result == null)
                        {
                            return "Event with the specified ID does not exist.";
                        }
                        /*Convert the result to an integer, which represents the organizer's ID.*/
                        eventOrganizerID = Convert.ToInt32(result);
                    }

                    /*If the current user is not an admin and is not the organizer of the event, deny the update.*/
                    if (currentUserRole != "admin" && eventOrganizerID != currentUserID)
                    {
                        return "You do not have permission to update this event.";
                    }

                    string query = "UPDATE events SET eventName = @eventName, dateTime = @dateTime, maximumParticipants = @maximumParticipants, " +
                                   "currentParticipants = @currentParticipants, venue = @venue, location = @location, description = @description, " +
                                   "startTime = @startTime, endTime = @endTime WHERE eventID = @eventID";

                    /*Executes the updated query with the provided event details.*/
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@eventID", updatedEvent.EventID);
                        command.Parameters.AddWithValue("@eventName", updatedEvent.EventName);
                        command.Parameters.AddWithValue("@dateTime", updatedEvent.DateTime);
                        command.Parameters.AddWithValue("@maximumParticipants", updatedEvent.MaximumParticipants);
                        command.Parameters.AddWithValue("@currentParticipants", updatedEvent.CurrentParticipants);
                        command.Parameters.AddWithValue("@venue", updatedEvent.Venue);
                        command.Parameters.AddWithValue("@location", updatedEvent.Location);
                        command.Parameters.AddWithValue("@description", updatedEvent.Description);
                        command.Parameters.AddWithValue("@startTime", updatedEvent.StartTime);
                        command.Parameters.AddWithValue("@endTime", updatedEvent.EndTime);

                        command.ExecuteNonQuery();
                    }
                }

                return "Event updated successfully!";
            }
            catch (MySqlException ex)
            {
                /*If there is any MySQL-related error, catch the exception and return an error message with details.*/
                return "Error updating event: " + ex.Message;
            }
            catch (Exception ex)
            {
                /*Catch any unexpected exceptions and return a general error message.*/
                return "An unexpected error occurred: " + ex.Message;
            }
        }
        public static string DeleteEvent(int eventID)
        {
            /*Check if the provided eventID is valid (greater than 0), otherwise return an error message.*/
            if (eventID <= 0)
            {
                return "Invalid Event ID.";
            }
            /*Retrieve the current user's ID and role from the user session.*/
            int currentUserID = UserSession.CurrentUser.User_ID;  
            string currentUserRole = UserSession.CurrentUser.Role; 

            try
            {
                /*connection to the MySQL database using the connection string.*/
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    /*Query to check if the event with the specified eventID exists and retrieve the organizer's ID.*/
                    string checkQuery = "SELECT id FROM events WHERE eventID = @eventID";
                    int eventOrganizerID;
                    using (MySqlCommand checkCommand = new MySqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@eventID", eventID);

                        /*Execute the query and store the result (organizer's ID).*/
                        object result = checkCommand.ExecuteScalar();
                        if (result == null)
                        {
                            return "Event with the specified ID does not exist.";
                        }

                        /*Convert the result to an integer, which represents the organizer's ID.*/
                        eventOrganizerID = Convert.ToInt32(result);
                    }

                    /*Check if the current user is either an admin or the organizer of the event.*/
                    if (currentUserRole == "admin" || eventOrganizerID == currentUserID)
                    {

                        /* SQL query to delete the event with the specified eventID from the database.*/
                        string deleteQuery = "DELETE FROM events WHERE eventID = @eventID";
                        using (MySqlCommand deleteCommand = new MySqlCommand(deleteQuery, connection))
                        {
                            /*Add the eventID parameter to the delete query.*/
                            deleteCommand.Parameters.AddWithValue("@eventID", eventID);

                            /*Execute the delete command to remove the event from the database.*/
                            deleteCommand.ExecuteNonQuery();
                        }

                        return "Event deleted successfully!";
                    }
                    else
                    {
                        /*If the user is not an admin or the event's organizer, deny the deletion.*/
                        return "You do not have permission to delete this event.";
                    }
                }
            }
            catch (MySqlException ex)
            {
                /*Catch any MySQL-specific exceptions and return an error message with the details.*/
                return "Error deleting event: " + ex.Message;
            }
            catch (Exception ex)
            {
                /*Catch any unexpected exceptions and return a general error message.*/
                return "An unexpected error occurred: " + ex.Message;
            }
        }

        public static string CreateUser(string fullname, string email, int phone, string username, string password, string role)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    /*SQL query to insert the new user's information into the usertable.*/
                    string query = "INSERT INTO usertable (fullname, email, phone, username, password, role) " +
                                   "VALUES (@fullname, @email, @phone, @username, @password, @role)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@fullname", fullname);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@phone", phone);
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);
                        command.Parameters.AddWithValue("@role", role);

                        command.ExecuteNonQuery();
                    }
                }
                return "User created successfully.";
            }
            catch (MySqlException ex)
            {
                return "Error creating user: " + ex.Message;
            }
        }

        public static string UpdateUser(int id, string fullname, string email, int phone, string username, string password, string role)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    /* SQL query to update the user's details in the database for the specified user ID.*/
                    string query = "UPDATE usertable SET fullname = @fullname, email = @email, phone = @phone, username = @username, password = @password, role = @role WHERE id = @user_id";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@user_id", id);
                        command.Parameters.AddWithValue("@fullname", fullname);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@phone", phone);
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);
                        command.Parameters.AddWithValue("@role", role);

                        /*Execute the query to update the user record in the database.*/
                        command.ExecuteNonQuery();
                    }
                }
                return "User updated successfully.";
            }
            catch (MySqlException ex)
            {
                return "Error updating user: " + ex.Message;
            }
        }

        public static string DeleteUser(int id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    /*SQL query to delete the user with the specified user ID from the usertable.*/
                    string query = "DELETE FROM usertable WHERE id = @user_id";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@user_id", id);

                        /*Execute the query and get the number of rows affected (whether the deletion succeeded)*/
                        int rowsAffected = command.ExecuteNonQuery();

                        /*Check if any rows were affected, indicating the user was deleted.*/
                        if (rowsAffected > 0)
                        {
                            return "User deleted successfully.";
                        }
                        else
                        {
                            /*Return a message indicating no user was found with the specified ID.*/
                            return "No user found with the specified ID.";
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                return "Error deleting user: " + ex.Message;
            }
        }

        public static DataTable SearchUserByID(int id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM usertable WHERE id = @user_id";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@user_id", id);
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable result = new DataTable();
                            adapter.Fill(result);
                            return result;
                        }
                    }
                }
            }
            catch (MySqlException)
            {
                return null;
            }
        }
        public static string RegisterBooking(int eventID, string eventName, string fullname, string email, string phone, DateTime booking_date)
        {
            if (UserSession.CurrentUser == null)
            {
                return "User is not logged in.";
            }

            int participantID = UserSession.CurrentUser.User_ID;  

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            /*Query to check if the event exists and retrieve participant limits*/
                            string checkEventQuery = "SELECT maximumParticipants, currentParticipants FROM events WHERE eventID = @eventID";
                            using (MySqlCommand checkCommand = new MySqlCommand(checkEventQuery, connection, transaction))
                            {
                                checkCommand.Parameters.AddWithValue("@eventID", eventID);

                                /*Execute the query and read the event details*/
                                using (MySqlDataReader reader = checkCommand.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        int maximumParticipants = reader.GetInt32("maximumParticipants");
                                        int currentParticipants = reader.GetInt32("currentParticipants");

                                        /*Check if the event is fully booked*/
                                        if (currentParticipants >= maximumParticipants)
                                        {
                                            return "Event is fully booked. Cannot register more participants.";
                                        }
                                    }
                                    else
                                    {
                                        return "Event not found.";
                                    }
                                }
                            }

                            /*Query to insert the booking into the bookings table*/
                            string insertBookingQuery = "INSERT INTO bookings (eventID, eventName, Participant_ID, fullname, email, phone, booking_date) " +
                                                        "VALUES (@eventID, @eventName, @participantID, @fullname, @email, @phone, @bookingDate)";

                            using (MySqlCommand insertCommand = new MySqlCommand(insertBookingQuery, connection, transaction))
                            {
                                insertCommand.Parameters.AddWithValue("@eventID", eventID);
                                insertCommand.Parameters.AddWithValue("@eventName", eventName);
                                insertCommand.Parameters.AddWithValue("@participantID", participantID);
                                insertCommand.Parameters.AddWithValue("@fullname", fullname);
                                insertCommand.Parameters.AddWithValue("@email", email);
                                insertCommand.Parameters.AddWithValue("@phone", phone);
                                insertCommand.Parameters.AddWithValue("@bookingDate", booking_date);

                                insertCommand.ExecuteNonQuery();
                            }

                            /*Query to update the current participant count for the event*/
                            string updateParticipantsQuery = "UPDATE events SET currentParticipants = currentParticipants + 1 WHERE eventID = @eventID";
                            using (MySqlCommand updateCommand = new MySqlCommand(updateParticipantsQuery, connection, transaction))
                            {
                                updateCommand.Parameters.AddWithValue("@eventID", eventID);
                                updateCommand.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            return "Booking registered successfully!";
                        }
                        catch (Exception)
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                return "Error registering booking: " + ex.Message;
            }
            catch (Exception ex)
            {
                return "An error occurred: " + ex.Message;
            }
        }

        public static string UpdateBooking(int bookingID, int eventID, string eventName, string fullname, string email, string phone, DateTime booking_date)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    /*Query to update the booking details for the specified booking ID*/
                    string query = "UPDATE bookings SET eventID = @eventID, eventName = @eventName, fullname = @fullname, " +
                                   "email = @email, phone = @phone, booking_date = @bookingDate " +
                                   "WHERE booking_ID = @bookingID";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@bookingID", bookingID);
                        command.Parameters.AddWithValue("@eventID", eventID);
                        command.Parameters.AddWithValue("@eventName", eventName);
                        command.Parameters.AddWithValue("@fullname", fullname);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@phone", phone);
                        command.Parameters.AddWithValue("@bookingDate", booking_date);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            return "Booking updated successfully!";
                        }
                        else
                        {
                            return "No booking found with the specified ID.";
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                return "Error updating booking: " + ex.Message;
            }
        }
        public static string CancelBooking(int bookingID)
        {
            /*Check if the booking ID is valid*/
            if (bookingID <= 0)
            {
                return "Invalid Booking ID.";
            }

            /*Get current user's ID and role from the session*/
            int currentUserID = UserSession.CurrentUser.User_ID;  
            string currentUserRole = UserSession.CurrentUser.Role; 

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    /*Query to retrieve the participant ID and event ID for the specified booking*/
                    string checkQuery = "SELECT Participant_ID, eventID FROM bookings WHERE booking_id = @bookingID";
                    int bookingParticipantID;
                    using (MySqlCommand checkCommand = new MySqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@bookingID", bookingID);

                        using (MySqlDataReader reader = checkCommand.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                return "Booking with the specified ID does not exist.";
                            }
                            /*Get the participant ID for the booking*/
                            bookingParticipantID = reader.GetInt32("Participant_ID"); 
                        }
                    }

                    /*Check permissions based on user roles (admin, organizer, participant)*/
                    if (currentUserRole == "admin")
                    {
                    }
                    else if (currentUserRole == "organizer")
                    {
                        /*Organizers can cancel bookings for their own events*/
                        string organizerCheckQuery = "SELECT COUNT(*) FROM events WHERE eventID = (SELECT eventID FROM bookings WHERE booking_id = @bookingID) AND id = @organizerID";
                        using (MySqlCommand organizerCheckCommand = new MySqlCommand(organizerCheckQuery, connection))
                        {
                            organizerCheckCommand.Parameters.AddWithValue("@bookingID", bookingID);
                            organizerCheckCommand.Parameters.AddWithValue("@organizerID", currentUserID);

                            int count = Convert.ToInt32(organizerCheckCommand.ExecuteScalar());
                            if (count == 0)
                            {
                                return "Booking with the specified ID does not exist.";
                            }
                        }
                    }
                    else if (currentUserRole == "participant")
                    {
                        /*Participants can only cancel their own bookings*/
                        if (bookingParticipantID != currentUserID)
                        {
                            return "Booking with the specified ID does not exist.";
                        }
                    }

                    /*Query to delete the booking*/
                    string deleteQuery = "DELETE FROM bookings WHERE booking_id = @bookingID";
                    using (MySqlCommand command = new MySqlCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@bookingID", bookingID);
                        command.ExecuteNonQuery();
                    }
                }

                return "Booking cancelled successfully!";
            }
            catch (MySqlException ex)
            {
                return "Error cancelling booking: " + ex.Message;
            }
            catch (Exception ex)
            {
                return "An unexpected error occurred: " + ex.Message;
            }
        }



    }
}
