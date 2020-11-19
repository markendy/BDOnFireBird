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
    public partial class LoginForm : Form, IDisposable
    {
        private Action _loginHandler;

        public LoginForm(Action logined)
        {
            InitializeComponent();

            _loginHandler += logined;
        }
        
        public new void Dispose()
        {
            _loginHandler = null;
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

        public User GetUser()
        {
            return new User(LoginTextBox.Text, PasswordTextBox.Text);
        }   
    }
}
