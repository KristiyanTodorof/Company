using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    public abstract class User
    {
        private string username;
        private string password;
        public string Username { get { return username; } protected set { username = value; } }
        public string Password { get { return password; } protected set { username = value; } }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
        public abstract void GetInfo();
    }
}
