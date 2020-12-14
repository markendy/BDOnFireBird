using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirebirdSql.Data.Client;

namespace BD
{
    public partial class AddTeacherForm : Form, IDisposable
    {
        public delegate void TeacherDelegate(Teacher teacher);
        private event TeacherDelegate _addTeacher;
        private Teacher _teacher;

        public AddTeacherForm(TeacherDelegate addTeacher)
        {
            InitializeComponent();

            _addTeacher += addTeacher;
        }

        public new void Dispose()
        {
            _addTeacher = null;
        }

        private void AddButtonClick(object sender, EventArgs e)
        {
            //creare teacher
            _addTeacher(_teacher);
        }
    }
}
