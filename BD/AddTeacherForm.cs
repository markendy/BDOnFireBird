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
        private event TeacherDelegate _addTeacherHandler;

        public AddTeacherForm(TeacherDelegate addTeacher)
        {
            InitializeComponent();

            _addTeacherHandler += addTeacher;
        }

        public new void Dispose()
        {
            _addTeacherHandler = null;
        }

        private void AddButtonClick(object sender, EventArgs e)
        {
            if (TeacherFullNameLabelTextBox.Text.Split().Length != 3)
            {
                MessageBox.Show("Неккоректно заполнено ФИО");
            }
            else if (ThingTextBox.Text == "")
            {
                MessageBox.Show("Неккоректно заполнен предмет");
            }
            else if (CabinetLabelTextBox.Text == "")
            {
                MessageBox.Show("Неккоректно заполнен предмет");
            }
            else
                _addTeacherHandler(new Teacher(
                    TeacherFullNameLabelTextBox.Text.Split()[0],
                    TeacherFullNameLabelTextBox.Text.Split()[1],
                    TeacherFullNameLabelTextBox.Text.Split()[2],                    
                    CabinetLabelTextBox.Text,
                    ThingTextBox.Text));
        }
    }
}
