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
    public partial class AddStudentForm : Form, IDisposable
    {
        public delegate void StudentDelegate(Student student = null, string req = null);
        private event StudentDelegate _addStudentHandler;

        public AddStudentForm(StudentDelegate requestrDelegate)
        {
            InitializeComponent();
            MainForm.DataBase.SetComboBox(StudentClassComboBox, "CLASS", "NAME");

            ReloadDelField();

            _addStudentHandler += requestrDelegate;
        }

        public new void Dispose()
        {
            _addStudentHandler = null;
        }

        private void ReloadDelField()
        {
            MainForm.DataBase.SetComboBox(DelFirstNameComboBox, "STUDENT", "(STUDENT.LAST_NAME || ' ' || STUDENT.FIRST_NAME)");
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
        
        private void DelStud(object sender, EventArgs e)
        {
            var count = MainForm.DataBase.SelectRequest($"SELECT ID FROM STUDENT " +
                $"WHERE STUDENT.ID = '{((KeyValuePair<object, object>)DelFirstNameComboBox.SelectedItem).Key.ToString()}'" +
                //$"AND FIRST_NAME = '{((KeyValuePair<object, object>)DelLastNameComboBox.SelectedItem).Value.ToString()}'" +
                $";");

            if (count.Count == 0)
            {
                MessageBox.Show("Студента нет");
            }
            else
            {
                string request = ($"DELETE FROM PERSONAL WHERE ID in (" +
                    $"SELECT USER_ID FROM STUDENT " +
                    $"WHERE STUDENT.ID = '{((KeyValuePair<object, object>)DelFirstNameComboBox.SelectedItem).Key.ToString()}'" +
                    //$"AND FIRST_NAME = '{((KeyValuePair<object, object>)DelLastNameComboBox.SelectedItem).Value.ToString()}'" +
                    $");");

                MainForm.DataBase.DUIRequest(request, true);
                request = ($"DELETE FROM STUDENT " +
                    $"WHERE STUDENT.ID = '{((KeyValuePair<object, object>)DelFirstNameComboBox.SelectedItem).Key.ToString()}'" +
                    //$"AND FIRST_NAME = '{((KeyValuePair<object, object>)DelLastNameComboBox.SelectedItem).Value.ToString()}'" +
                    $";");
                _addStudentHandler(null, request);
                ReloadDelField();
            }
        }
    }
}
