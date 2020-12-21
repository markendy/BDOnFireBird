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
    public partial class AddLessonForm : Form
    {
        private event MainForm.RequestrDelegate _addLessonHandler;

        public AddLessonForm(MainForm.RequestrDelegate _addLessonDelegate)
        {
            InitializeComponent();

            MainForm.DataBase.SetComboBox(ThingComboBox, "THING", "NAME");
            MainForm.DataBase.SetComboBox(ClassComboBox, "CLASS", "NAME");
            DataTextBox.Text = Calendar.SelectionRange.Start.ToString("dd.MM.yyyy");

            _addLessonHandler += _addLessonDelegate;
        }

        private void CalendarDateSelected(object sender, DateRangeEventArgs e)
        {
            DataTextBox.Text = Calendar.SelectionRange.Start.ToString("dd.MM.yyyy");
            Calendar.Visible = false;
        }

        private void DataTextBoxClick(object sender, EventArgs e)
        {
            Calendar.Location = new Point(DataTextBox.Location.X, DataTextBox.Location.Y + DataTextBox.Size.Height - Calendar.Size.Height);
            Calendar.Visible = true;
        }

        private void ThingComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            //ClassComboBox.Visible = true;
        }

        private void ShoolGradeLabelComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            //DataTextBox.Visible = true;
        }

        private void StudentComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            //ShoolGradeLabelComboBox.Visible = true;
        }

        private void AddLessonButton_Click(object sender, EventArgs e)
        {
            _addLessonHandler($"INSERT INTO LESSON VALUES(null, " +
                $"{NumberComboBox.SelectedItem}, " +
                $"{((KeyValuePair<object, object>)CabinetComboBox.SelectedItem).Key}, " +
                $"{((KeyValuePair<object, object>)TeacherComboBox.SelectedItem).Key}, " +
                $"{((KeyValuePair<object, object>)ClassComboBox.SelectedItem).Key}, " +
                $"{((KeyValuePair<object, object>)ThingComboBox.SelectedItem).Key}, " +
                $"'{Calendar.SelectionRange.Start:yyyy-MM-dd}');");
        }

        private void ThingComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var items = MainForm.DataBase.SelectRequest($"SELECT TEACHER.ID, TEACHER.LAST_NAME FROM TEACHER " +
                $"JOIN BIND_TEACHER_THING ON (BIND_TEACHER_THING.TEACHER_ID = TEACHER.ID) " +
                $"WHERE BIND_TEACHER_THING.THING_ID = {((KeyValuePair<object, object>)ThingComboBox.SelectedItem).Key};");
            MainForm.DataBase.SetComboBox(items, TeacherComboBox);
        }

        private void TeacherComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var items = MainForm.DataBase.SelectRequest($"SELECT CABINET.ID, CABINET.NUMBER FROM CABINET JOIN TEACHER " +
                $"ON (TEACHER.CABINET_ID = CABINET.ID) " +
                $"WHERE TEACHER.ID = {((KeyValuePair<object, object>)TeacherComboBox.SelectedItem).Key};");
            MainForm.DataBase.SetComboBox(items, CabinetComboBox);
        }
    }
}
