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
        private List<Dictionary<object, object>> _answer;

        public MainForm()
        {
            InitializeComponent();

            _dataBase = new DataBaseAdapter();

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
            _dataBase.DUIRequest("INSERT INTO TEACHER VALUES(1, 'AAA');", true);
            _answer = _dataBase.SelectRequest("SELECT * FROM TEACHER");
            _dataBase.DUIRequest("DELETE FROM TEACHER WHERE ID = 1", true);
            _answer = _dataBase.SelectRequest("SELECT * FROM TEACHER");
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

            Show();
            _loginForm.Dispose();
            _loginForm.Close();
        }

        private void AddShoolGrade(string request)
        {
            //INSERTN VALUE IN DB
            _addShoolGradeForm.Dispose();
            _addShoolGradeForm.Close();
        }

        private void AddTeacher(Teacher teacher)
        {
            // Add to BD teacher

            _addTeacherForm.Dispose();
            _addTeacherForm.Close();
        }
    }
}
