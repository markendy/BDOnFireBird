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
    public partial class QuestForm : Form
    {
        private event MainForm.RequestrDelegate _quest1Handler;

        private string _request;

        private Dictionary<object, object>dayOfWeek;

        public QuestForm(MainForm.RequestrDelegate quest1)
        {
            InitializeComponent();
            InitWeekDay();         
            MainForm.DataBase.SetComboBox(Q1ClassComboBox, "CLASS", "NAME");
            MainForm.DataBase.SetComboBox(Q2ClassComboBox, "CLASS", "NAME");           
            MainForm.DataBase.SetComboBox(Q3TeacherComboBox, "TEACHER", "LAST_NAME");
            Q3SetThing();
            MainForm.DataBase.SetComboBox(dayOfWeek, Q1WeekComboBox);
            MainForm.DataBase.SetComboBox(dayOfWeek, Q4WeekComboBox);
            MainForm.DataBase.SetComboBox(Q4ClassComboBox, "CLASS", "NAME");

            _quest1Handler = quest1;
        }

        private void InitWeekDay()
        {
            dayOfWeek = new Dictionary<object, object>();
            dayOfWeek.Add(0, "Воскресенье");
            dayOfWeek.Add(1, "Понедельник");
            dayOfWeek.Add(2, "Вторник");
            dayOfWeek.Add(3, "Среда");
            dayOfWeek.Add(4, "Четверг");
            dayOfWeek.Add(5, "Пятница");
            dayOfWeek.Add(6, "Суббота");
        }

        private void Q3SetThing()
        {
            MainForm.DataBase.SetComboBox(MainForm.DataBase.SelectRequest($"SELECT THING.ID, THING.NAME FROM THING JOIN BIND_TEACHER_THING ON (BIND_TEACHER_THING.THING_ID = THING.ID) " +
                $"WHERE BIND_TEACHER_THING.TEACHER_ID = {((KeyValuePair<object, object>)Q3TeacherComboBox.SelectedItem).Key.ToString()};"), Q3ThingComboBox);
        }

        private void Q1Button_Click(object sender, EventArgs e)
        {                                  
            //_request = $"SELECT NAME FROM THING, LESSON WHERE LESSON.THING_ID = ID AND DATE = {DayOfWeekTextBox.Text} AND CLASS_ID = (SELECT ID FROM CLASS WHERE NAME = '{ClassTextBox.Text}') AND LESSON.NUMBER = {NumLessonTextBox.Text};";
            _request = $"SELECT THING.NAME FROM THING JOIN LESSON ON (LESSON.THING_ID = THING.ID) " +
                $"WHERE LESSON.CLASS_ID = {((KeyValuePair<object, object>)Q1ClassComboBox.SelectedItem).Key.ToString()} " +
                $"AND EXTRACT(WEEKDAY FROM LESSON.\"DATE\") = {((KeyValuePair<object, object>)Q1WeekComboBox.SelectedItem).Key.ToString()} " +
                $"AND LESSON.NUMBER = {Q1NumberComboBox.Text.ToString()}";
            _quest1Handler(_request);
        }

        private void Q2Button_Click(object sender, EventArgs e)
        {
            _request = $"SELECT TEACHER.LAST_NAME FROM TEACHER JOIN LESSON ON (LESSON.TEACHER_ID = TEACHER.ID) " +
                $"JOIN CLASS ON (LESSON.CLASS_ID = CLASS.ID) " +
                $"WHERE CLASS.ID = {((KeyValuePair<object, object>)Q2ClassComboBox.SelectedItem).Key.ToString()}";
            _quest1Handler(_request);
        }

        private void Q3Button_Click(object sender, EventArgs e)
        {
            _request = $"SELECT CLASS.NAME FROM CLASS JOIN LESSON ON (LESSON.CLASS_ID = CLASS.ID) " +
                $"JOIN TEACHER ON (LESSON.TEACHER_ID = TEACHER.ID) " +
                $"WHERE LESSON.THING_ID = {((KeyValuePair<object, object>)Q3ThingComboBox.SelectedItem).Key.ToString()} " +
                $"AND LESSON.TEACHER_ID = {((KeyValuePair<object, object>)Q3TeacherComboBox.SelectedItem).Key.ToString()};";

            _quest1Handler(_request);
        }

        private void Q3TeacherComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Q3SetThing();
        }

        private void Q4Button_Click(object sender, EventArgs e)
        {
            _request = $"SELECT LESSON.\"DATE\", LESSON.NUMBER, THING.NAME FROM LESSON " +
                $"JOIN CLASS ON (CLASS.ID = LESSON.CLASS_ID) " +
                $"JOIN THING ON (THING.ID = LESSON.THING_ID) " +
                $"WHERE CLASS.ID = {((KeyValuePair<object, object>)Q4ClassComboBox.SelectedItem).Key.ToString()} " +
                $"AND EXTRACT(WEEKDAY FROM LESSON.\"DATE\") = {((KeyValuePair<object, object>)Q4WeekComboBox.SelectedItem).Key.ToString()}";
            _quest1Handler(_request);
        }
    }
}
