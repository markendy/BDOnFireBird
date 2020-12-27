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
        public delegate void TeacherDelegate(Teacher teacher = null, string req = null);
        private event TeacherDelegate _addTeacherHandler;

        public AddTeacherForm(TeacherDelegate addTeacher)
        {
            InitializeComponent();

            MainForm.DataBase.SetComboBox(false, ThingListBox, "THING", "NAME");
            MainForm.DataBase.SetComboBox(false, CabinetComboBox, "CABINET", "NUMBER");

            ReloadDelField();

            _addTeacherHandler += addTeacher;
        }

        public new void Dispose()
        {
            _addTeacherHandler = null;
        }

        private void AddButtonClick(object sender, EventArgs e)
        {
            if (TeacherFullNameLabelTextBox.Text.Split().Length != 3 || ThingListBox.SelectedItems.Count == 0 || LoginTextBox.Text == "" || PasswordTextBox.Text == "")
            {
                MessageBox.Show("Неккоректно заполненые поля");
            }
            else if (CabinetComboBox.SelectedItem == null)
            {
                _addTeacherHandler(new Teacher(
                    TeacherFullNameLabelTextBox.Text.Split()[0],
                    TeacherFullNameLabelTextBox.Text.Split()[1],
                    TeacherFullNameLabelTextBox.Text.Split()[2],
                    ThingListBox,
                    LoginTextBox.Text,
                    PasswordTextBox.Text));
                ReloadDelField();
            }
            else
            {
                _addTeacherHandler(new Teacher(
                    TeacherFullNameLabelTextBox.Text.Split()[0],
                    TeacherFullNameLabelTextBox.Text.Split()[1],
                    TeacherFullNameLabelTextBox.Text.Split()[2],
                    ThingListBox,
                    LoginTextBox.Text,
                    PasswordTextBox.Text,
                    ((KeyValuePair<object, object>)CabinetComboBox.SelectedItem).Key.ToString()));
                ReloadDelField();
            }
        }

        private void ThingComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ThingListBox.Items.Count != 0)
                ThingTextBox.Text = ((KeyValuePair<object, object>)ThingListBox.SelectedItem).Value.ToString();
        }

        private void AddNewButton_Click(object sender, EventArgs e)
        {
            ThingTextBox.Text = ThingTextBox.Text.ToUpper();
            object r = 1;
            if (ThingTextBox.Text != "")
                r = MainForm.DataBase.RequestWithReturnId($"SELECT COUNT(ID) FROM THING WHERE NAME = '{ThingTextBox.Text}';", true);
            if (Convert.ToInt32(r) == 0)
            {
                MainForm.DataBase.DUIRequest($"INSERT INTO THING VALUES(null, '{ThingTextBox.Text}');", true);
                MainForm.DataBase.SetComboBox(true, ThingListBox, "THING", "NAME");
                ThingListBox.Text = ThingTextBox.Text;
            }
            else
            {
                MessageBox.Show("Предмет уже есть или строка пуста");
            }
        }

        private void AddCabinetButton_Click(object sender, EventArgs e)
        {
            object r = 1;
            if (CabinetTextBox.Text != "")
                r = MainForm.DataBase.RequestWithReturnId($"SELECT COUNT(ID) FROM CABINET WHERE NUMBER = {CabinetTextBox.Text};", true);
            if (Convert.ToInt32(r) == 0)
            {
                MainForm.DataBase.DUIRequest($"INSERT INTO CABINET VALUES(null, {CabinetTextBox.Text}) RETURNING ID;", true); 
                MainForm.DataBase.SetComboBox(true, CabinetComboBox, "CABINET", "NUMBER");                
                CabinetComboBox.Text = CabinetTextBox.Text;    
            }
            else
            {
                MessageBox.Show("Кабинет уже есть или строка пуста");
            }
        }

        private void CabinetComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //CabinetTextBox.Text = ((KeyValuePair<object, object>)CabinetComboBox.SelectedItem).Value.ToString();
        }

        private void ReloadDelField()
        {
            MainForm.DataBase.SetComboBox(true, LastNameСomboBox, "TEACHER", "(TEACHER.LAST_NAME || ' ' || TEACHER.MIDDLE_NAME || ' ' || TEACHER.FIRST_NAME)");
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (LastNameСomboBox.SelectedItem != null)
            {
                var count = MainForm.DataBase.SelectRequest($"SELECT ID FROM TEACHER " +
                    $"WHERE TEACHER.ID = {((KeyValuePair<object, object>)LastNameСomboBox.SelectedItem).Key.ToString()}" +
                    //$"AND MIDDLE_NAME = '{((KeyValuePair<object, object>)MiddleNameСomboBox.SelectedItem).Value.ToString()}'" +
                    //$"AND FIRST_NAME = '{((KeyValuePair<object, object>)FirstNameСomboBox.SelectedItem).Value.ToString()}'" +
                    $";");

                if (count.Count == 0)
                {
                    MessageBox.Show("Преподавателя нет");
                }
                else
                {
                    string request = ($"DELETE FROM PERSONAL WHERE PERSONAL.ID IN (" +
                        $"SELECT TEACHER.USER_ID FROM TEACHER " +
                        $"WHERE TEACHER.ID = {((KeyValuePair<object, object>)LastNameСomboBox.SelectedItem).Key.ToString()}" +
                        //$"AND MIDDLE_NAME = '{((KeyValuePair<object, object>)MiddleNameСomboBox.SelectedItem).Value.ToString()}'" +
                        //$"AND FIRST_NAME = '{((KeyValuePair<object, object>)FirstNameСomboBox.SelectedItem).Value.ToString()}'" +
                        $");");

                    MainForm.DataBase.DUIRequest(request, true);
                    request = ($"DELETE FROM TEACHER " +
                        $"WHERE TEACHER.ID = {((KeyValuePair<object, object>)LastNameСomboBox.SelectedItem).Key.ToString()}" +
                        //$"AND MIDDLE_NAME = '{((KeyValuePair<object, object>)MiddleNameСomboBox.SelectedItem).Value.ToString()}'" +
                        //$"AND FIRST_NAME = '{((KeyValuePair<object, object>)FirstNameСomboBox.SelectedItem).Value.ToString()}'" +
                        $";");
                    _addTeacherHandler(null, request);
                    ReloadDelField();
                }
            }
        }
    }
}
