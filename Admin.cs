using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMGTNew
{
    internal class Admin : Users
    {
        public Admin(int user_ID, string name, string email, int phone, string user_name, string password, string role) : base(user_ID, name, email, phone, user_name, password, role)
        {
        }


        private static string connectionString = "server=localhost;database=eventmgtdb;user=root;password=;";
        public static string addEvents(Events events, int userId)
        {
            return DataBase.AddEvent(events, userId);
        }

        public static string updateEvent(Events updatedEvent)
        {
            return DataBase.UpdateEvent(updatedEvent);
        }

        public static string deleteEvent(int eventID)
        {
            return DataBase.DeleteEvent(eventID);
        }


        public static string CreateUser(string fullname, string email, int phone, string username, string password, string role)
        {
            return DataBase.CreateUser(fullname, email, phone, username, password, role);
        }

        public static string UpdateUser(int id, string fullname, string email, int phone, string username, string password, string role)
        {
            return DataBase.UpdateUser(id, fullname, email, phone, username, password, role);
        }
        public static string DeleteUser(int id)
        {
            return DataBase.DeleteUser(id);
        }
        public static DataTable SearchUserByID(int id)
        {
            return DataBase.SearchUserByID(id);
        }
        public static string CancelBooking(int bookingID)
        {
            return DataBase.CancelBooking(bookingID);
        }
    }

}
