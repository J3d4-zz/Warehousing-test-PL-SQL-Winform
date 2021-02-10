using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehousing
{
    class Users
    {
        private string username;
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        private string password;
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public Users(string username, string password)
        {
            Username = username;
            Password = password;
        }
        public Users()
        { 

        }
        public override string ToString()
        {
            return string.Format("User Name: {0}, Password: {1}", Username, Password);
        }
    }
}
