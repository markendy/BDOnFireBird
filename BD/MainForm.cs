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
        private DataBaseAdapter _dataBase;
        private TableView _tableView;

        public MainForm()
        {
            InitializeComponent();

            _dataBase = new DataBaseAdapter();
            _tableView = new TableView(DataGridView);

            //_tableView.CreateMainTableView(_dataBase.SelectRequest("SELECT * FROM TEACHER;"));

            // SYSTEM :: _tableView.CreateMainTableView(_dataBase.SelectRequest("select * from sec$users;"));
            
            _loginForm = new LoginForm(Logined);
            _loginForm.Show();
        }

        public static User User { get; private set; }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            Visible = false;
        }      

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

        //========================================================
        // Outside method
        //========================================================

        private void Logined()
        {
            User = _loginForm.GetUser();
            var login = _dataBase.CheckUser(User);
            if (login != "")
            {
                _dataBase.Connect(login);
                Show();
                _loginForm.Dispose();
                _loginForm.Close();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }

        private void AddShoolGrade(string request)
        {
            //INSERTN VALUE IN DB
            _addShoolGradeForm.Dispose();
            _addShoolGradeForm.Close();
        }

        private void AddTeacher(Teacher teacher)
        {
            var lastId = _dataBase.InsertWithReturnId(
                $"INSERT INTO TEACHER VALUES(null, '{teacher.FirstName}', '{teacher.MiddleName}', '{teacher.LastName}') RETURNING ID;"
                , true);
            _dataBase.DUIRequest(
                $"INSERT INTO THING VALUES(null, '{teacher.Thing}', {lastId});", 
                true);
            _dataBase.DUIRequest(
                $"INSERT INTO CABINET VALUES(null, {teacher.Cabinet}, {lastId});",
                true);
            CloseWindow(_addTeacherForm);
        }

        private void CloseWindow(Form form)
        {
            form.Dispose();
            form.Close();
        }
    }
}
