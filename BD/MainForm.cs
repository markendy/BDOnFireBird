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


        public MainForm()
        {
            InitializeComponent();

            _loginForm = new LoginForm(this);
            _loginForm.Show();
        }

        public static User User { get; private set; }

        public void Logined()
        {
            User = new User(_loginForm.GetLoginPassword()[0], _loginForm.GetLoginPassword()[1]);

            Show();
            _loginForm.Close();
        }

        public void AddShoolGrade(string request)
        {
            //INSERTN VALUE IN DB
            AddShoolGradeButton.Text = request;
            _addShoolGradeForm.Close();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            Visible = false;
        }

        private void AddShoolGradeClick(object sender, EventArgs e)
        {
            _addShoolGradeForm = new AddShoolGradeForm(AddShoolGrade);
            _addShoolGradeForm.Show();
        }
    }
}
