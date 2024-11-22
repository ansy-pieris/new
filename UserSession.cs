using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EventMGTNew
{
    internal class UserSession
    {
        public static UserSession CurrentUser { get; set; }

        public int User_ID
        {
            get { return user_ID; }
            private set { user_ID = value; }
        }
        public string User_Name
        {
            get { return user_name; }
            private set { user_name = value; }
        }
        public string Role
        {
            get { return role; }
            private set { role = value; }
        }

        private int user_ID;
        private string user_name;
        private string role;

        public UserSession(int user_ID, string user_name, string role)
        {
            this.user_ID = user_ID;
            this.user_name = user_name;
            this.role = role;
        }

        public static void StartSession(int userId, string userName, string role)
        {
            CurrentUser = new UserSession(userId, userName, role);
        }

        public static void EndSession()
        {
            CurrentUser = null;
        }

        public static bool IsLoggedIn()
        {
            return CurrentUser != null;
        }

        public static int CurrentUserID
        {
            get
            {
                if (IsLoggedIn())
                    return CurrentUser.User_ID;
                throw new InvalidOperationException("No user is logged in.");
            }
        }

        public static string CurrentUserName
        {
            get
            {
                if (IsLoggedIn())
                    return CurrentUser.User_Name;
                throw new InvalidOperationException("No user is logged in.");
            }
        }

        public static string CurrentUserRole
        {
            get
            {
                if (IsLoggedIn())
                    return CurrentUser.Role;
                throw new InvalidOperationException("No user is logged in.");
            }
        }
    }

}
