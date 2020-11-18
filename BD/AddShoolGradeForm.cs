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
    public partial class AddShoolGradeForm : Form
    {
        public delegate void MyDelegate(string request);
        public event MyDelegate _addShoolGradeHandler;

        public AddShoolGradeForm(MyDelegate addSchoolGrade)
        {
            InitializeComponent();

            _addShoolGradeHandler += addSchoolGrade;
        }      

        private void AddButtonClick(object sender, EventArgs e)
        {
            //INSERT VALUE
            _addShoolGradeHandler("REQUEST");
        }

        private void CanelButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
