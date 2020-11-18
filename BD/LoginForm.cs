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
        private Action _loginHandler;

        MainForm mainForm;

        public LoginForm(MainForm _mainForm)
        {
            InitializeComponent();

            mainForm = _mainForm;
            _loginHandler += mainForm.Logined;
        }

        ~LoginForm()
        {
            _loginHandler -= mainForm.Logined;
        }

        private void LoginButtonClick(object sender, EventArgs e)
        {
            if (Check())
            {
                _loginHandler();
            }
            else
            {
                WinHelp.ShowMessage("Логин/пароль не распознан");
            }
        }

        private bool Check()
        {
            if (LoginTextBox.Text != "")
            {
                return true;
            }
            //CHECK USER ON BD
            return false;
        }

        public string[] GetLoginPassword()
        {
            return new string[] { LoginTextBox.Text, PasswordTextBox.Text };
        }
    }
}
