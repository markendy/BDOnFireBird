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
            if(CheckNullField())
                _loginHandler();
        }

        private bool CheckNullField()
        {
            if (LoginTextBox.Text == "" || PasswordTextBox.Text == "")
            {
                MessageBox.Show("Неправильно введены поля");
                return false;
            }            
            return true;
        }

        public User GetUser()
        {
            return new User(LoginTextBox.Text, PasswordTextBox.Text);
        }   
    }
}
