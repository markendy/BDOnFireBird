using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD
{
    public class Student
    {
        public Student(string firstName, string lastName, object _class, string login, string pass)
        {
            FirstName = firstName;
            LastName = lastName;
            Class = _class;
            Login = login;
            Password = pass;
        }

        public string Login { get; set; }
        public string Password { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public object Class { get; set; }
    }
}
