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
    }
}
