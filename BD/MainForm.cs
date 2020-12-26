using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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

        private List<Button> forStudent;
        private List<Button> forTeacher;
        private List<Button> forAdmin;

        public static bool IsResultOk = true;

        public delegate void RequestrDelegate(string request);

        public MainForm()
        {
            InitializeComponent();

            DataBase = new DataBaseAdapter(ReqView);
            _tableView = new TableView(DataGridView);

            DataBase.Connect("SYSDBA");
            CreateObsStudent();
            CreateEditorTeacher();

            // SYSTEM :: _tableView.CreateMainTableView(_dataBase.SelectRequest("select * from sec$users;"));

            forStudent = new List<Button>();
            forStudent.Add(OBSClass);
            forStudent.Add(OBSLesson);
            forStudent.Add(OBSScore);
            forStudent.Add(OBSStudent);
            forStudent.Add(OBSTeacher);

            forTeacher = new List<Button>();
            forTeacher.Add(AddShoolGradeButton);

            forAdmin = new List<Button>();
            forAdmin.Add(AddTeacherButton);
            forAdmin.Add(ClassAddButton);
            forAdmin.Add(AddStudentButton);
            forAdmin.Add(AddLessonButton);
            forAdmin.Add(AddShoolGradeButton);
            forAdmin.Add(QuestButton);
            forAdmin.Add(AddLessonButton);
            forAdmin.Add(OBSTeacher);

            _loginForm = new LoginForm(Logined);
            _loginForm.Show();
        }

        public static User User { get; private set; }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            Visible = false;
        }

        private void VisualSet(string role)
        {
            if (role == "OBS")
                ShowForStudent();
            else if (role == "EDITOR")
            {
                ShowForTeacher();
            }
            else
            {
                ShowForAdmin();
            }
        }

        private void ShowForStudent()
        {
            foreach (var butt in forStudent)
            {
                butt.Visible = true;
            }
        }

        private void ShowForTeacher()
        {
            ShowForStudent();
            foreach (var butt in forTeacher)
            {
                butt.Visible = true;
            }
        }

        private void ShowForAdmin()
        {
            ShowForTeacher();
            foreach (var butt in forAdmin)
            {
                butt.Visible = true;
            }
        }


        private void CreateObsStudent()
        {
            DataBase.Connect("SYSDBA");

            DataBase.RequestWithReturnId("DROP ROLE OBS", true, false);

            DataBase.RequestWithReturnId("CREATE ROLE OBS", true, false);
            DataBase.RequestWithReturnId("GRANT SELECT ON BIND_TEACHER_THING TO OBS", true, false);
            DataBase.RequestWithReturnId("GRANT SELECT ON CABINET TO OBS", true, false);
            DataBase.RequestWithReturnId("GRANT SELECT ON CLASS TO OBS", true, false);
            DataBase.RequestWithReturnId("GRANT SELECT ON LESSON TO OBS", true, false);
            DataBase.RequestWithReturnId("GRANT SELECT ON PERFORMANCE TO OBS", true, false);
            DataBase.RequestWithReturnId("GRANT SELECT ON STUDENT TO OBS", true, false);
            DataBase.RequestWithReturnId("GRANT SELECT ON TEACHER TO OBS", true, false);
            DataBase.RequestWithReturnId("GRANT SELECT ON THING TO OBS", true, false);

            DataBase.RequestWithReturnId("DROP USER STUDENT;", true, false);

            DataBase.RequestWithReturnId("CREATE USER STUDENT PASSWORD '123123' using plugin Srp", true, false);
            DataBase.RequestWithReturnId("GRANT OBS TO STUDENT", true, false);
        }

        private void CreateEditorTeacher()
        {
            DataBase.Connect("SYSDBA");

            DataBase.RequestWithReturnId("DROP ROLE EDITOR", true, false);

            DataBase.RequestWithReturnId("CREATE ROLE EDITOR", true, false);
            DataBase.RequestWithReturnId("GRANT SELECT, REFERENCES ON BIND_TEACHER_THING TO EDITOR", true, false);
            DataBase.RequestWithReturnId("GRANT SELECT, REFERENCES ON CABINET TO EDITOR", true, false);
            DataBase.RequestWithReturnId("GRANT SELECT, REFERENCES ON CLASS TO EDITOR", true, false);
            DataBase.RequestWithReturnId("GRANT SELECT, REFERENCES ON LESSON TO EDITOR", true, false);
            DataBase.RequestWithReturnId("GRANT SELECT, UPDATE, INSERT, REFERENCES ON PERFORMANCE TO EDITOR", true, false);
            DataBase.RequestWithReturnId("GRANT SELECT, REFERENCES ON STUDENT TO EDITOR", true, false);
            DataBase.RequestWithReturnId("GRANT SELECT, REFERENCES   ON TEACHER TO EDITOR", true, false);
            DataBase.RequestWithReturnId("GRANT SELECT, REFERENCES ON THING TO EDITOR", true, false);
            DataBase.RequestWithReturnId("GRANT USAGE ON SEQUENCE GEN_PERFORMANCE_ID TO EDITOR", true, false);

            DataBase.RequestWithReturnId("DROP USER TEACHER;", true, false);

            DataBase.RequestWithReturnId("CREATE USER TEACHER PASSWORD '123123' using plugin Srp", true, false);
            DataBase.RequestWithReturnId("GRANT EDITOR TO TEACHER", true, false);

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

        private void QuestButton_Click(object sender, EventArgs e)
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

        private void OBSTeacher_Click(object sender, EventArgs e)
        {
            _tableView.CreateMainTableView(DataBase.SelectRequest($"SELECT (TEACHER.LAST_NAME || ' ' || TEACHER.MIDDLE_NAME || ' ' || TEACHER.FIRST_NAME) as \"Преподаватель\", CABINET.NUMBER as \"Кабинет\" FROM TEACHER " +
                $"LEFT JOIN CABINET ON(TEACHER.CABINET_ID = CABINET.ID) ORDER BY \"Преподаватель\"")); ;
        }

        private void OBSClass_Click(object sender, EventArgs e)
        {
            _tableView.CreateMainTableView(DataBase.SelectRequest($"SELECT CLASS.NAME as \"Класс\" FROM CLASS ORDER BY \"Класс\";"));
        }

        private void OBSStudent_Click(object sender, EventArgs e)
        {
            _tableView.CreateMainTableView(DataBase.SelectRequest($"SELECT (STUDENT.LAST_NAME || ' ' || STUDENT.FIRST_NAME) as \"Ученик\", CLASS.NAME as \"Класс\" FROM STUDENT " +
                $"JOIN CLASS ON(STUDENT.CLASS_ID = CLASS.ID) ORDER BY \"Ученик\";"));
        }

        private void OBSLesson_Click(object sender, EventArgs e)
        {
            _tableView.CreateMainTableView(DataBase.SelectRequest($"SELECT  LESSON.\"DATE\" as \"Дата\", LESSON.NUMBER AS \"Номер урока\", CABINET.NUMBER AS \"Кабинет\", CLASS.NAME as \"Класс\", THING.NAME as \"Предмет\" ,(TEACHER.LAST_NAME || ' ' || TEACHER.MIDDLE_NAME || ' ' || TEACHER.FIRST_NAME) as \"Преподаватель\" FROM LESSON " +
                $"JOIN CABINET ON (LESSON.CABINET_ID = CABINET.ID) " +
                $"JOIN TEACHER ON (LESSON.TEACHER_ID = TEACHER.ID) " +
                $"JOIN CLASS ON (LESSON.CLASS_ID = CLASS.ID) " +
                $"JOIN THING ON (LESSON.THING_ID = THING.ID) " +
                $"ORDER BY \"Дата\" DESC;"));
        }

        private void OBSScore_Click(object sender, EventArgs e)
        {
            _tableView.CreateMainTableView(DataBase.SelectRequest($"SELECT " +
                $"PERFORMANCE.\"DATA\" as \"Дата\", PERFORMANCE.SCORE as \"Оценка\", (STUDENT.LAST_NAME || STUDENT.FIRST_NAME) as \"Ученик\", THING.NAME as \"Предмет\" FROM PERFORMANCE " +
                $"JOIN STUDENT ON (PERFORMANCE.STUDENT_ID = STUDENT.ID) " +
                $"JOIN THING ON (PERFORMANCE.THING_ID = THING.ID)" +
                $"ORDER BY \"Дата\" DESC;"));
        }

        //========================================================
        // Outside method
        //========================================================

        private void Quest(string request)
        {
            _tableView.CreateMainTableView(DataBase.SelectRequest(request));

            ShowSucsess();
        }

        private void Logined()
        {
            User = _loginForm.GetUser();
            var login = DataBase.CheckUser(User);
            if (login != "")
            {
                string role = DataBase.Connect(login);

                Show();
                CloseWindow(_loginForm);

                VisualSet(role);
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
                MainForm.IsResultOk = false;
            }
        }

        private void AddShoolGrade(string request)
        {
            DataBase.DUIRequest(request, true);

            ShowSucsess();

            //_tableView.CreateMainTableView(DataBase.ShowOnMainTable("PERFORMANCE"));
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
            }

            ShowSucsess();

            //_tableView.CreateMainTableView(DataBase.ShowOnMainTable("TEACHER"));
        }

        private void AddClass(string request)
        {
            DataBase.RequestWithReturnId(request, true);

            ShowSucsess();

            _tableView.CreateMainTableView(DataBase.ShowOnMainTable("CLASS"));
        }

        private void AddStudent(Student student, string request)
        {
            if (request == null)
            {
                var lastIdUser = DataBase.RequestWithReturnId($"INSERT INTO PERSONAL VALUES(null, '{student.Login}','{student.Password}','STUDENT') RETURNING ID;", true);
                DataBase.DUIRequest($"INSERT INTO STUDENT VALUES(null, '{student.FirstName}', '{student.LastName}', {student.Class}, {lastIdUser});", true);

            }
            else
            {
                DataBase.DUIRequest(request, true);
            }
            ShowSucsess();

            //_tableView.CreateMainTableView(DataBase.ShowOnMainTable("STUDENT"));
        }

        private void AddLesson(string request)
        {
            DataBase.DUIRequest(request, true);

            ShowSucsess();

            //_tableView.CreateMainTableView(DataBase.ShowOnMainTable("LESSON"));
        }

        private void CloseWindow(Form form)
        {
            form.Dispose();
            form.Close();
        }

        private void ShowSucsess()
        {
            if (IsResultOk)
                MessageBox.Show("Действие завершено успешно");
            IsResultOk = true;
        }
    }
}
