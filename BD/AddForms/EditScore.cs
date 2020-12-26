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
    public partial class EditScore : Form
    {
        private event MainForm.RequestrDelegate _editRequestHandler;
        public string RequestEdit { get; set; }
        private object _row;

        public EditScore(object row, MainForm.RequestrDelegate method)
        {
            InitializeComponent();
            _row = row;
            _editRequestHandler += method;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                string request = $"UPDATE PERFORMANCE SET SCORE = {comboBox1.Text} WHERE ID = {_row};";
                _editRequestHandler(request);
            }
            else
                MessageBox.Show("Пустая оценка");
        }
    }
}
