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
    public partial class LoginForm : Form
    {
        private TextBox _loginTextBox;
        private TextBox _passwordTextBox;

        private Action _loginHandler;

        public LoginForm(MainForm mainForm)
        {
            InitializeComponent();

            _loginTextBox = this.LoginTextBox;
            _passwordTextBox = this.PasswordTextBox;

            Login = _loginTextBox.Text;
            Password = _passwordTextBox.Text;

            _loginHandler += mainForm.Logined;
        }

        public string Login { get; set; }
        public string Password { get; set; }

        private void LoginButtonClick(object sender, EventArgs e)
        {
            if (Check())
            {
                _loginHandler();
            }
        }

        private bool Check()
        {
            //check user on bd
            return true;
        }
    }
}
