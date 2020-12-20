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
            MainForm.DataBase.SetComboBox(StudentComboBox, "STUDENT", "LAST_NAME");

            _addSchoolGradeHandler += _addSchoolGradeDelegate;
        }      

        private void AddButtonClick(object sender, EventArgs e)
        {
            //INSERT VALUE
            _addSchoolGradeHandler("REQUEST");
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

        private void NumberOfLessonTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ThingComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            // do something
            //ClassComboBox.Visible = true;
        }

        private void ShoolGradeLabelComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            //DataTextBox.Visible = true;
        }

        private void ClassComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            //StudentComboBox.Visible = true;
        }

        private void StudentComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            //ShoolGradeLabelComboBox.Visible = true;
        }

        private void DataTextBoxTextChanged(object sender, EventArgs e)
        {

        }
    }
}
