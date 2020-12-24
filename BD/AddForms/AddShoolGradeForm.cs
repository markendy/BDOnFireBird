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
    public partial class AddShoolGradeForm : Form
    {
        private event MainForm.RequestrDelegate _addSchoolGradeHandler;

        private TableView _table;

        public AddShoolGradeForm(MainForm.RequestrDelegate _addSchoolGradeDelegate)
        {
            InitializeComponent();

            _table = new TableView(dataGridViewEdit);            

            MainForm.DataBase.SetComboBox(ThingComboBox, "THING", "NAME");
            MainForm.DataBase.SetComboBox(ClassComboBox, "CLASS", "NAME");
            DataTextBox.Text = Calendar.SelectionRange.Start.ToString("dd.MM.yyyy");

            CreateScoreTable();

            _addSchoolGradeHandler += _addSchoolGradeDelegate;
        }

        private void CreateScoreTable()
        {
            if (StudentComboBox != null && StudentComboBox.SelectedItem != null && StudentComboBox.Items.Count != 0)
            {
                var res = MainForm.DataBase.SelectRequest($"SELECT " +
                $"PERFORMANCE.ID, PERFORMANCE.\"DATA\", PERFORMANCE.SCORE, STUDENT.LAST_NAME, THING.NAME FROM PERFORMANCE " +
                $"JOIN STUDENT ON (PERFORMANCE.STUDENT_ID = STUDENT.ID) " +
                $"JOIN THING ON (PERFORMANCE.THING_ID = THING.ID)" +
                $"WHERE STUDENT.ID = {((KeyValuePair<object, object>)StudentComboBox.SelectedItem).Key};");
                if (res.Count != 0)
                {
                    _table.CreateMainTableView(res);
                }
                else
                {
                    _table.CreateMainTableView(res);
                }
               
            }
        }

        private void AddButtonClick(object sender, EventArgs e)
        {
            if (ThingComboBox.Text != "" && ClassComboBox.Text != "" && StudentComboBox.Text != "" && ShoolGradeomboBox.SelectedItem != null && DataTextBox.Text != "")
            {
                _addSchoolGradeHandler($"INSERT INTO PERFORMANCE VALUES(null, {((KeyValuePair<object, object>)StudentComboBox.SelectedItem).Key}, {((KeyValuePair<object, object>)ThingComboBox.SelectedItem).Key}, {ShoolGradeomboBox.Text}, '{Calendar.SelectionRange.Start.ToString("yyyy-MM-dd")}');");
                CreateScoreTable();
            }
            else
                MessageBox.Show("Неправильно заполнены поля");
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

        private void ClassComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            MainForm.DataBase.SetComboBox(StudentComboBox, "STUDENT", "LAST_NAME", null, $"CLASS_ID = {((KeyValuePair<object, object>)ClassComboBox.SelectedItem).Key}");
        }

        private void StudentComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            //ShoolGradeLabelComboBox.Visible = true;
            CreateScoreTable();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (ShoolGradeomboBox.SelectedItem != null)
            {
                var selected = dataGridViewEdit.CurrentCell.RowIndex;
                _addSchoolGradeHandler($"UPDATE PERFORMANCE SET SCORE = {ShoolGradeomboBox.Text} WHERE ID = {dataGridViewEdit[0, selected].Value};");
                CreateScoreTable();
            }
            else
                MessageBox.Show("Пустая оценка");            
        }
    }
}
