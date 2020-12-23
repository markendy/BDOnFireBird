using FirebirdSql.Data.FirebirdClient;
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
    public partial class MainForm : Form
    {
        private LoginForm _loginForm;
        private AddShoolGradeForm _addShoolGradeForm;
        private AddTeacherForm _addTeacherForm;
        private QuestForm _quest1Form;
        private AddClassForm _addClassForm;
        private AddStudentForm _addStudentForm;
        private AddLessonForm _addLessonForm;

        public static DataBaseAdapter DataBase;
        private TableView _tableView;

        public delegate void RequestrDelegate(string request);

        public MainForm()
        {
            InitializeComponent();

            DataBase = new DataBaseAdapter();
            _tableView = new TableView(DataGridView);

            // SYSTEM :: _tableView.CreateMainTableView(_dataBase.SelectRequest("select * from sec$users;"));

            _loginForm = new LoginForm(Logined);
            _loginForm.Show();
        }

        public static User User { get; private set; }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            Visible = false;
        }

        //========================================================
        // Buttons Click
        //========================================================

        private void AddShoolGradeClick(object sender, EventArgs e)
        {
            _addShoolGradeForm = new AddShoolGradeForm(AddShoolGrade);
            _addShoolGradeForm.Show();
        }

        private void AddTeacherButtonClick(object sender, EventArgs e)
        {
            _addTeacherForm = new AddTeacherForm(AddTeacher);
            _addTeacherForm.Show();
        }

        private void Quest1Button_Click(object sender, EventArgs e)
        {
            _quest1Form = new QuestForm(Quest);
            _quest1Form.Show();
            //_tableView.CreateMainTableView(DataBase.SelectRequest($"SELECT ID, \"DATE\", EXTRACT(WEEKDAY FROM \"DATE\") as wd FROM LESSON WHERE EXTRACT(WEEKDAY FROM \"DATE\") = 3 ;"));
        }

        private void ClassAddButton_Click(object sender, EventArgs e)
        {
            _addClassForm = new AddClassForm(AddClass);
            _addClassForm.Show();
        }

        private void StudentAddButton_Click(object sender, EventArgs e)
        {
            _addStudentForm = new AddStudentForm(AddStudent);
            _addStudentForm.Show();
        }

        private void AddLessonButton_Click(object sender, EventArgs e)
        {
            _addLessonForm = new AddLessonForm(AddLesson);
            _addLessonForm.Show();
        }


        //========================================================
        // Outside method
        //========================================================

        private void Quest(string request)
        {
            _tableView.CreateMainTableView(DataBase.SelectRequest(request));

            CloseWindow(_quest1Form);
        }

        private void Logined()
        {
            User = _loginForm.GetUser();
            var login = DataBase.CheckUser(User);
            if (login != "")
            {
                DataBase.Connect(login);
                Show();

                CloseWindow(_loginForm);

                _tableView.CreateMainTableView(DataBase.ShowOnMainTable("PERSONAL"));
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }

        private void AddShoolGrade(string request)
        {
            DataBase.DUIRequest(request, true);

            CloseWindow(_addShoolGradeForm);

            _tableView.CreateMainTableView(DataBase.ShowOnMainTable("PERFORMANCE"));
        }

        private void AddTeacher(Teacher teacher = null, string request = null)
        {
            if (request == null)
            {
                var lastIdUser = DataBase.RequestWithReturnId($"INSERT INTO PERSONAL VALUES(null, '{teacher.Login}','{teacher.Password}', 'TEACHER') RETURNING ID;", true);
                var lastId = DataBase.RequestWithReturnId(
                    $"INSERT INTO TEACHER VALUES(null, '{teacher.FirstName}', '{teacher.MiddleName}', '{teacher.LastName}', '{teacher.Cabinet}', {lastIdUser}) RETURNING ID;"
                    , true);
                foreach (var t in teacher.ListThing.SelectedItems)
                {
                    DataBase.DUIRequest(
                    $"INSERT INTO BIND_TEACHER_THING VALUES(null, {lastId}, {((KeyValuePair<object, object>)t).Key.ToString()});",
                    true);
                }
            }
            else
            {
                DataBase.DUIRequest(request, true);

                CloseWindow(_addTeacherForm);

                _tableView.CreateMainTableView(DataBase.ShowOnMainTable("TEACHER"));
            }
            CloseWindow(_addTeacherForm);

            _tableView.CreateMainTableView(DataBase.ShowOnMainTable("TEACHER"));
        }

        private void AddClass(string request)
        {
            DataBase.RequestWithReturnId(request, true);

            CloseWindow(_addClassForm);

            _tableView.CreateMainTableView(DataBase.ShowOnMainTable("CLASS"));
        }

        private void AddStudent(Student student)
        {
            var lastIdUser = DataBase.RequestWithReturnId($"INSERT INTO PERSONAL VALUES(null, '{student.Login}','{student.Password}','STUDENT') RETURNING ID;", true);
            DataBase.DUIRequest($"INSERT INTO STUDENT VALUES(null, '{student.FirstName}', '{student.LastName}', {student.Class}, {lastIdUser});", true);


            CloseWindow(_addStudentForm);

            _tableView.CreateMainTableView(DataBase.ShowOnMainTable("STUDENT"));
        }

        private void AddLesson(string request)
        {
            DataBase.DUIRequest(request, true);

            CloseWindow(_addLessonForm);

            _tableView.CreateMainTableView(DataBase.ShowOnMainTable("LESSON"));
        }

        private void CloseWindow(Form form)
        {
            form.Dispose();
            form.Close();
        }
    }
}
