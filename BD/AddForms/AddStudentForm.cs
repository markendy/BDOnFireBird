using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD
{
    public partial class AddStudentForm : Form
    {
        public delegate void StudentDelegate(Student student);
        private event StudentDelegate _addStudentHandler;

        public AddStudentForm(StudentDelegate requestrDelegate)
        {
            InitializeComponent();
            MainForm.DataBase.SetComboBox(StudentClassComboBox, "CLASS", "NAME");
            _addStudentHandler += requestrDelegate;
        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            if (StudentFirstNameTextBox.Text != "" || StudentLastNameTextBox.Text != "" || StudentClassComboBox.Text != "")
            {
                _addStudentHandler(new Student(StudentFirstNameTextBox.Text, StudentLastNameTextBox.Text, ((KeyValuePair<object, object>)StudentClassComboBox.SelectedItem).Key, LoginTextBox.Text, PasswordTextBox.Text));
            }
            else
                MessageBox.Show("Некоторые поля пусты");
        }
        /*
        private void DelStud()
        {
            var count = MainForm.DataBase.SelectRequest($"SELECT ID FROM TEACHER " +
                $"WHERE LAST_NAME = '{((KeyValuePair<object, object>)LastNameСomboBox.SelectedItem).Value.ToString()}'" +
                $"AND MIDDLE_NAME = '{((KeyValuePair<object, object>)MiddleNameСomboBox.SelectedItem).Value.ToString()}'" +
                $"AND FIRST_NAME = '{((KeyValuePair<object, object>)FirstNameСomboBox.SelectedItem).Value.ToString()}'" +
                $";");

            if (count.Count == 0)
            {
                MessageBox.Show("Преподавателя нет");
            }
            else
            {
                string request = ($"DELETE FROM PERSONAL WHERE ID in (" +
                    $"SELECT USER_ID FROM TEACHER " +
                    $"WHERE LAST_NAME = '{((KeyValuePair<object, object>)LastNameСomboBox.SelectedItem).Value.ToString()}'" +
                    $"AND MIDDLE_NAME = '{((KeyValuePair<object, object>)MiddleNameСomboBox.SelectedItem).Value.ToString()}'" +
                    $"AND FIRST_NAME = '{((KeyValuePair<object, object>)FirstNameСomboBox.SelectedItem).Value.ToString()}'" +
                    $");");

                MainForm.DataBase.DUIRequest(request, true);
                request = ($"DELETE FROM TEACHER " +
                    $"WHERE LAST_NAME = '{((KeyValuePair<object, object>)LastNameСomboBox.SelectedItem).Value.ToString()}'" +
                    $"AND MIDDLE_NAME = '{((KeyValuePair<object, object>)MiddleNameСomboBox.SelectedItem).Value.ToString()}'" +
                    $"AND FIRST_NAME = '{((KeyValuePair<object, object>)FirstNameСomboBox.SelectedItem).Value.ToString()}'" +
                    $";");
                _addTeacherHandler(null, request);
                ReloadDelField();
            }
        }*/
    }
}
