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
        private LoginForm loginForm;
       
        public MainForm()
        {
            InitializeComponent();

            loginForm = new LoginForm(this);
            loginForm.Show();
        }

        public static User User { get; private set; }

        public void Logined()
        {
            User = new User(loginForm._LoginTextBox.Text, loginForm._PasswordTextBox.Text);

            Show();
            loginForm.Close();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            Visible = false;
        }
    }
}
