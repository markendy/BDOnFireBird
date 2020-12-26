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

        private TableView _tableSQuest;

        private string _request;

        private Dictionary<object, object> dayOfWeek;

        public QuestForm(MainForm.RequestrDelegate quest1)
        {
            InitializeComponent();
            _tableSQuest = new TableView(null);
            InitWeekDay();
            MainForm.DataBase.SetComboBox(false, Q1ClassComboBox, "CLASS", "NAME");
            MainForm.DataBase.SetComboBox(false, Q2ClassComboBox, "CLASS", "NAME");
            MainForm.DataBase.SetComboBox(false, Q3ClassComboBox, "CLASS", "NAME");
            MainForm.DataBase.SetComboBox(false, Q4TeacherComboBox, "TEACHER", "LAST_NAME");
            MainForm.DataBase.SetComboBox(false, SQ1ClassComboBox, "CLASS", "NAME");
            Q4SetThing();
            MainForm.DataBase.SetComboBox(false, dayOfWeek, Q1WeekComboBox);
            MainForm.DataBase.SetComboBox(false, dayOfWeek, Q3WeekComboBox);
            MainForm.DataBase.SetComboBox(false, dayOfWeek, Q5WeekComboBox);
            MainForm.DataBase.SetComboBox(false, Q5ClassComboBox, "CLASS", "NAME");

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

        private void Q4SetThing()
        {
            if (Q4TeacherComboBox.SelectedItem != null)
                MainForm.DataBase.SetComboBox(true, MainForm.DataBase.SelectRequest($"SELECT THING.ID, THING.NAME FROM THING JOIN BIND_TEACHER_THING ON (BIND_TEACHER_THING.THING_ID = THING.ID) " +
                    $"WHERE BIND_TEACHER_THING.TEACHER_ID = {((KeyValuePair<object, object>)Q4TeacherComboBox.SelectedItem).Key.ToString()};"), Q4ThingComboBox);
            else
            {
                Console.WriteLine("[NOTY] Q4 - NULL TEACHER");
            }
        }

        private void CustomPrint(List<Dictionary<object, object>> items)
        {
            if (items.Count != 0)
            {
                Print print = new Print(new string[] { "" }, false, items);
                print.Show();
            }
            else
            {
                MessageBox.Show("Выборка пуста");
            }
        }

        private void Q1Button_Click(object sender, EventArgs e)
        {
            if (Q1NumberComboBox.SelectedItem != null)
            {
                //_request = $"SELECT NAME FROM THING, LESSON WHERE LESSON.THING_ID = ID AND DATE = {DayOfWeekTextBox.Text} AND CLASS_ID = (SELECT ID FROM CLASS WHERE NAME = '{ClassTextBox.Text}') AND LESSON.NUMBER = {NumLessonTextBox.Text};";
                _request = $"SELECT THING.NAME as \"Предмет\" FROM THING JOIN LESSON ON (LESSON.THING_ID = THING.ID) " +
                    $"WHERE LESSON.CLASS_ID = {((KeyValuePair<object, object>)Q1ClassComboBox.SelectedItem).Key.ToString()} " +
                    $"AND EXTRACT(WEEKDAY FROM LESSON.\"DATE\") = {((KeyValuePair<object, object>)Q1WeekComboBox.SelectedItem).Key.ToString()} " +
                    $"AND LESSON.NUMBER = {Q1NumberComboBox.Text.ToString()}";
                var items = MainForm.DataBase.SelectRequest(_request);
                CustomPrint(items);
                _quest1Handler(_request);
            }
            else
            {
                MessageBox.Show("Пустой номер урока");
            }
        }

        private void Q2Button_Click(object sender, EventArgs e)
        {
            if (Q2ClassComboBox.SelectedItem != null)
            {
                _request = $"SELECT (TEACHER.LAST_NAME || ' ' || TEACHER.MIDDLE_NAME || ' ' || TEACHER.FIRST_NAME) as \"Преподаватель\" FROM TEACHER JOIN LESSON ON (LESSON.TEACHER_ID = TEACHER.ID) " +
                    $"JOIN CLASS ON (LESSON.CLASS_ID = CLASS.ID) " +
                    $"WHERE CLASS.ID = {((KeyValuePair<object, object>)Q2ClassComboBox.SelectedItem).Key.ToString()}";
                var items = MainForm.DataBase.SelectRequest(_request);
                CustomPrint(items);
                _quest1Handler(_request);
            }
        }

        private void Q4Button_Click(object sender, EventArgs e)
        {
            if (Q4ThingComboBox.SelectedItem != null && Q4TeacherComboBox.SelectedItem != null)
            {
                _request = $"SELECT DISTINCT CLASS.NAME as \"Класс\" FROM CLASS JOIN LESSON ON (LESSON.CLASS_ID = CLASS.ID) " +
                    $"JOIN TEACHER ON (LESSON.TEACHER_ID = TEACHER.ID) " +
                    $"WHERE LESSON.THING_ID = {((KeyValuePair<object, object>)Q4ThingComboBox.SelectedItem).Key.ToString()} " +
                    $"AND LESSON.TEACHER_ID = {((KeyValuePair<object, object>)Q4TeacherComboBox.SelectedItem).Key.ToString()};";
                var items = MainForm.DataBase.SelectRequest(_request);
                CustomPrint(items);
                _quest1Handler(_request);
            }
        }

        private void Q4TeacherComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Q4SetThing();
        }

        private void Q5Button_Click(object sender, EventArgs e)
        {
            if (Q5ClassComboBox.SelectedItem != null)
            {
                _request = $"SELECT LESSON.\"DATE\", LESSON.NUMBER, THING.NAME, CABINET.NUMBER as CABINET FROM LESSON " +
                    $"JOIN CLASS ON (CLASS.ID = LESSON.CLASS_ID) " +
                    $"JOIN THING ON (THING.ID = LESSON.THING_ID) " +
                    $"JOIN CABINET ON (CABINET.ID = LESSON.CABINET_ID) " +
                    $"WHERE CLASS.ID = {((KeyValuePair<object, object>)Q5ClassComboBox.SelectedItem).Key.ToString()} " +
                    $"AND EXTRACT(WEEKDAY FROM LESSON.\"DATE\") = {((KeyValuePair<object, object>)Q5WeekComboBox.SelectedItem).Key.ToString()}";
                var items = MainForm.DataBase.SelectRequest(_request);
                CustomPrint(items);
                _quest1Handler(_request);
            }
        }

        private void Q3Button_Click(object sender, EventArgs e)
        {
            if (Q3NumberComboBox.SelectedItem != null)
            {
                _request = $"SELECT CABINET.NUMBER as \"Кабинет\"FROM CABINET " +
                $"JOIN LESSON ON (LESSON.CABINET_ID = CABINET.ID) " +
                $"JOIN CLASS ON (CLASS.ID = LESSON.CLASS_ID) " +
                $"WHERE CLASS.ID = {((KeyValuePair<object, object>)Q3ClassComboBox.SelectedItem).Key.ToString()} " +
                $"AND LESSON.NUMBER = {Q3NumberComboBox.Text.ToString()} " +
                $"AND EXTRACT(WEEKDAY FROM LESSON.\"DATE\") = {((KeyValuePair<object, object>)Q3WeekComboBox.SelectedItem).Key.ToString()}";
                var items = MainForm.DataBase.SelectRequest(_request);
                CustomPrint(items);
                _quest1Handler(_request);
            }
            else
            {
                MessageBox.Show("Пустой номер урока");
            }
        }

        private void SQ1Bbutton_Click(object sender, EventArgs e)
        {
            if(SQ1ClassComboBox.SelectedItem != null) 
            { 
            _request = $"SELECT 'Количество учеников, в {((KeyValuePair<object, object>)SQ1ClassComboBox.SelectedItem).Value} классе', COUNT(STUDENT.ID) FROM STUDENT " +
                $"JOIN CLASS ON (STUDENT.CLASS_ID = CLASS.ID) " +
                $"WHERE STUDENT.CLASS_ID = {((KeyValuePair<object, object>)SQ1ClassComboBox.SelectedItem).Key.ToString()}";
            var items = MainForm.DataBase.SelectRequest(_request);
            Print print = new Print(new string[] { "Количестве учеников, в заданом классе" }, true, items);
            print.Show();
            //_tableSQuest.WriteInFile(MainForm.DataBase.SelectRequest(_request), "SQ4.txt");
            }
        }

        private void SQ2Bbutton_Click(object sender, EventArgs e)
        {
            _request = $"SELECT 'Колличество учителей по', THING.NAME, COUNT(TEACHER.ID) FROM TEACHER " +
                $"JOIN BIND_TEACHER_THING ON(TEACHER.ID = BIND_TEACHER_THING.TEACHER_ID) " +
                $"JOIN THING ON (BIND_TEACHER_THING.THING_ID = THING.ID) GROUP BY THING.NAME;";
            var items1 = MainForm.DataBase.SelectRequest(_request);
            _request = $"SELECT 'Кол-во кабинетов в школе', COUNT(ID) FROM CABINET;";
            var items2 = MainForm.DataBase.SelectRequest(_request);
            _request = $"SELECT  'Кол-во учеников в классе', CLASS.NAME, COUNT(STUDENT.ID) FROM STUDENT " +
                $"JOIN CLASS ON(STUDENT.CLASS_ID = CLASS.ID) " +
                $"GROUP BY CLASS.NAME;";
            var items3 = MainForm.DataBase.SelectRequest(_request);
            _request = $"SELECT  'Кол-во учеников в школе', COUNT(STUDENT.ID) FROM STUDENT;";
            var items4 = MainForm.DataBase.SelectRequest(_request);
            Print print = new Print(new string[] { "Количество учителей по предметам", "Количество кабинетов", "Число учеников в каждом классе", "Число учеников в школе" }, true, items1, items2, items3, items4);
            print.Show();
            //_tableSQuest.WriteInFile(MainForm.DataBase.SelectRequest(_request), "SQ5.txt");
        }
    }
}
