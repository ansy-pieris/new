using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMGTNew
{
    internal class Users
    {
        private int user_ID;
        private string name;
        private string email;
        private int phone;
        private string user_name;
        private string password;
        private string role;

        public int User_ID
        {
            get { return user_ID; }
            set { user_ID = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public int Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public string User_Name
        {
            get { return user_name; }
            set { user_name = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Role
        {
            get { return role; }
            set { role = value; }
        }
        public Users(int user_ID, string name, string email, int phone, string user_name, string password, string role)
        {
            this.user_ID = user_ID;
            this.name = name;
            this.email = email;
            this.phone = phone;
            this.user_name = user_name;
            this.password = password;
            this.role = role;
        }

        public virtual void Login(string email, string password)
        {
        }

        public virtual void Logout()
        {
        }
    }
}
