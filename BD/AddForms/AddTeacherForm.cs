using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirebirdSql.Data.Client;

namespace BD
{
    public partial class AddTeacherForm : Form, IDisposable
    {
        public delegate void TeacherDelegate(Teacher teacher);
        private event TeacherDelegate _addTeacherHandler;

        public AddTeacherForm(TeacherDelegate addTeacher)
        {
            InitializeComponent();

            MainForm.DataBase.SetComboBox(ThingListBox, "THING", "NAME");
            MainForm.DataBase.SetComboBox(CabinetComboBox, "CABINET", "NUMBER");

            _addTeacherHandler += addTeacher;
        }

        public new void Dispose()
        {
            _addTeacherHandler = null;
        }

        private void AddButtonClick(object sender, EventArgs e)
        {
            if (TeacherFullNameLabelTextBox.Text.Split().Length != 3)
            {
                MessageBox.Show("Неккоректно заполнено ФИО");
            }
            else if (CabinetLabelTextBox.Text == "")
            {
                MessageBox.Show("Неккоректно заполнен предмет");
            }
            else
                _addTeacherHandler(new Teacher(
                    TeacherFullNameLabelTextBox.Text.Split()[0],
                    TeacherFullNameLabelTextBox.Text.Split()[1],
                    TeacherFullNameLabelTextBox.Text.Split()[2],
                    ((KeyValuePair<object, object>)CabinetComboBox.SelectedItem).Key.ToString(),
                    ThingListBox,
                    LoginTextBox.Text,
                    PasswordTextBox.Text));
        }

        private void ThingComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ThingListBox.Items.Count != 0)
                ThingTextBox.Text = ((KeyValuePair<object, object>)ThingListBox.SelectedItem).Value.ToString();
        }

        private void CabinetLabelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CabinetComboBox.Items.Count != 0)
                CabinetLabelTextBox.Text = ((KeyValuePair<object, object>)CabinetComboBox.SelectedItem).Value.ToString();
        }

        private void AddNewButton_Click(object sender, EventArgs e)
        {
            object r = 1;
            if (ThingTextBox.Text != "")
                r = MainForm.DataBase.InsertWithReturnId($"SELECT COUNT(ID) FROM THING WHERE NAME = '{ThingTextBox.Text}';", true);
            if (Convert.ToInt32(r) == 0)
            {
                MainForm.DataBase.DUIRequest($"INSERT INTO THING VALUES(null, '{ThingTextBox.Text.ToUpper()}');", true);
                MainForm.DataBase.SetComboBox(ThingListBox, "THING", "NAME");
            }
            else
            {
                MessageBox.Show("Предмет уже есть или строка пуста");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            object r = 1;
            if (CabinetLabelTextBox.Text != "")
                r = MainForm.DataBase.InsertWithReturnId($"SELECT COUNT(ID) FROM CABINET WHERE NUMBER = {CabinetLabelTextBox.Text};", true);
            if (Convert.ToInt32(r) == 0)
            {
                MainForm.DataBase.DUIRequest($"INSERT INTO CABINET VALUES(null, {CabinetLabelTextBox.Text});", true);
                MainForm.DataBase.SetComboBox(CabinetComboBox, "CABINET", "NUMBER");
            }
            else
            {
                MessageBox.Show("Кабинет уже есть или строка пуста");
            }
        }
    }
}
