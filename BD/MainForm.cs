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

        public void Logined()
        {
            Show();
            loginForm.Close();
        }
    }
}
