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
    public partial class Quest1Form : Form
    {
        private event MainForm.RequestrDelegate _quest1Handler;

        private string _request;

        public Quest1Form(MainForm.RequestrDelegate quest1)
        {
            InitializeComponent();

            _quest1Handler = quest1;
        }

        private void ThingButton_Click(object sender, EventArgs e)
        {
            _request = $"SELECT NAME FROM THING, LESSON WHERE LESSON.THING_ID = ID AND DATE = {DayOfWeekTextBox.Text} AND CLASS_ID = (SELECT ID FROM CLASS WHERE NAME = '{ClassTextBox.Text}') AND LESSON.NUMBER = {NumLessonTextBox.Text};";

            _quest1Handler(_request);
        }
    }
}
