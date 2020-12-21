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

        public AddShoolGradeForm(MainForm.RequestrDelegate _addSchoolGradeDelegate)
        {
            InitializeComponent();

            MainForm.DataBase.SetComboBox(ThingComboBox, "THING", "NAME");
            MainForm.DataBase.SetComboBox(ClassComboBox, "CLASS", "NAME");
            DataTextBox.Text = Calendar.SelectionRange.Start.ToString("dd.MM.yyyy");

            _addSchoolGradeHandler += _addSchoolGradeDelegate;
        }      

        private void AddButtonClick(object sender, EventArgs e)
        {
            _addSchoolGradeHandler($"INSERT INTO PERFORMANCE VALUES(null, {((KeyValuePair<object, object>)StudentComboBox.SelectedItem).Key}, {((KeyValuePair<object, object>)ThingComboBox.SelectedItem).Key}, {ShoolGradeLabelComboBox.Text}, '{Calendar.SelectionRange.Start.ToString("yyyy-MM-dd")}');");
        }

        private void CalendarDateSelected(object sender, DateRangeEventArgs e)
        {
            DataTextBox.Text = Calendar.SelectionRange.Start.ToString("dd.MM.yyyy");
            Calendar.Visible = false;
        }

        private void DataTextBoxClick(object sender, EventArgs e)
        {
            Calendar.Location = new Point(DataTextBox.Location.X, DataTextBox.Location.Y+DataTextBox.Size.Height-Calendar.Size.Height);
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
        } 
    }
}
