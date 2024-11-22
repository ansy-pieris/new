using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMGTNew
{
    internal class Organizer : Users
    {
        public Organizer(int user_ID, string name, string email, int phone, string user_name, string password, string role) : base(user_ID, name, email, phone, user_name, password, role)
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
        public static string CancelBooking(int bookingID)
        {
            return DataBase.CancelBooking(bookingID);
        }

    }
}

