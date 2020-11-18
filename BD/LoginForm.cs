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
        public TextBox _LoginTextBox;
        public TextBox _PasswordTextBox;

        private Action _loginHandler;

        public LoginForm(MainForm mainForm)
        {
            InitializeComponent();

            _LoginTextBox = this.LoginTextBox;
            _PasswordTextBox = this.PasswordTextBox;
            
            _loginHandler += mainForm.Logined;
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
            //check user on bd
            return false;
        }
    }
}
