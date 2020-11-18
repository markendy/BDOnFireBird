using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD
{
    public class User
    {
        public User()
        {

        }

        public User(string username, string pass)
        {
            UserName = username;
            Password = pass;
        }

        public string UserName{ get; private set; }
        public string Password { get; private set; }
    }
}
