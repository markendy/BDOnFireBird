using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Printing;

namespace BD
{
    public partial class Print : Form
    {
        private TableView _tableView;

        private Point _lastPos;

        private bool _visibleTitle;

        private PrintDocument printDocument1 = new PrintDocument();
        private Bitmap memoryImage;

        public Print(string[] titles, bool visibleTitle, params List<Dictionary<object, object>> [] allItems)
        {
            InitializeComponent();

            _visibleTitle = visibleTitle;

            if (!_visibleTitle)
                label1.Visible = false;

            if (allItems[0].Count != 0)
            {

                printButton.Click += new EventHandler(printButton_Click);
                printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

                _lastPos = new Point(0, label1.Location.Y + label1.Height + 15);
                AutoScroll = true;
                int i = 0;
                SuspendLayout();
                if (allItems != null)
                    foreach (var item in allItems)
                    {
                        AddTable(titles[i], item);
                        i++;
                    }
                ResumeLayout();
            }
            else
            {
                label1.Text = "Выборка пуста";
                label1.Visible = true;
                MainForm.IsResultOk = false;
            }
        }

        public void AddTable(string _title, List<Dictionary<object, object>> items)
        {
            if (items.Count == 0)
                return;
            if (_visibleTitle)
            {
                Label title = new Label();
                title.Text = _title;
                title.Location = _lastPos;
                _lastPos = new Point(_lastPos.X, _lastPos.Y + title.Height);
                title.AutoSize = true;
                Controls.Add(title);
            }
            DataGridView dataGridView = new DataGridView();
            _tableView = new TableView(dataGridView);
            _tableView.CreateMainTableView(items);
            dataGridView.CurrentCell = null;
            dataGridView.AutoResizeColumns();
            dataGridView.BackgroundColor = Color.White;
            dataGridView.Width = this.Width - 30;
            dataGridView.Height = dataGridView.Rows.GetRowsHeight(DataGridViewElementStates.None) + dataGridView.Rows.GetRowsHeight(DataGridViewElementStates.None)/dataGridView.Rows.Count;
            dataGridView.Location = _lastPos;
            dataGridView.ColumnHeadersVisible = false;
            if (_visibleTitle)
                dataGridView.ColumnHeadersVisible = false;
            _lastPos = new Point(_lastPos.X, _lastPos.Y + dataGridView.Height + 15);

            Controls.Add(dataGridView);            
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            CaptureScreen();
            printDocument1.Print();
        }

        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }

        private void printDocument1_PrintPage(System.Object sender,
               System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }
    }
}
