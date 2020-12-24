using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD
{
    public class Teacher
    {
        public Teacher(string lastName, string middleName, string firstName, ListBox thingListBox, string login, string pass, string cabinet = "0")
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            ListThing = thingListBox;
            Cabinet = cabinet;
            Login = login;
            Password = pass;
        }

        public string Login { get; set; }
        public string Password { get; set; }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public string Cabinet { get; set; }

        public ListBox ListThing{ get; set; }
    }
}
