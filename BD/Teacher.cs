using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD
{
    public class Teacher
    {
        public Teacher(string firstName, string middleName, string lastName, string cabinet, string thing)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            Cabinet = cabinet;
            Thing = thing;
        }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public string Thing { get; set; }
        public string Cabinet { get; set; }
    }
}
