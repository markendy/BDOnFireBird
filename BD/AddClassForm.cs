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
    public partial class AddClassForm : Form
    {
        private event MainForm.RequestrDelegate _addClassHandler;

        public AddClassForm(MainForm.RequestrDelegate requestrDelegate)
        {
            InitializeComponent();

            _addClassHandler += requestrDelegate;
        }

        private void AddClassButton_Click(object sender, EventArgs e)
        {
            if(ClassNameTextBox.Text != "")
                _addClassHandler($"INSERT INTO CLASS VALUES(null, '{ClassNameTextBox.Text}')");
        }
    }
}
