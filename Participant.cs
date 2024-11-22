using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMGTNew
{
    internal class Participant : Users
    {
        public Participant(int user_ID, string name, string email, int phone, string user_name, string password, string role) : base(user_ID, name, email, phone, user_name, password, role)
        {
        }
        private static string connectionString = "server=localhost;database=eventmgtdb;user=root;password=;";

        public static string RegisterBooking(int eventID, string eventName, string fullname, string email, string phone, DateTime booking_date)
        {
            return DataBase.RegisterBooking(eventID, eventName,fullname, email, phone, booking_date);


        }

        public static string UpdateBooking(int bookingID, int eventID, string eventName, string fullname, string email, string phone, DateTime booking_date)
        {
            return DataBase.UpdateBooking(bookingID, eventID, eventName, fullname, email, phone, booking_date);
        }

        public static string CancelBooking(int bookingID)
        {
            return DataBase.CancelBooking(bookingID);
        }


    }
}
