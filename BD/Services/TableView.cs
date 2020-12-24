using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace BD
{
    public class TableView
    {
        private DataGridView _dataGridView;
        private List<Dictionary<object, object>> _answer;
        private StreamWriter _writer;
        private string _path = "output.txt";

        public TableView(DataGridView dataGridView = null)
        {
            if (dataGridView != null)
            {
                _dataGridView = dataGridView;
                _dataGridView.AllowUserToAddRows = false;
            }
        }

        public void WriteInFile(List<Dictionary<object, object>> col, string path = null)
        {
            string filePath = _path;
            if(path != null)
                filePath = path;
            _writer = new StreamWriter(filePath);
            _answer = col;
            int del = 0;
            int maxL = 0;
            if (_answer != null && _answer.Count != 0)
            {
                var str = _answer[0];
                int cras = str.Count - 1;
                foreach (var title in str.Keys)
                {
                    if (maxL < title.ToString().Length)
                    {
                        maxL = title.ToString().Length;
                    }
                }
                foreach (var val in str.Values)
                {
                    if (maxL < val.ToString().Length)
                    {
                        maxL = val.ToString().Length;
                    }
                }
                foreach (var title in str.Keys)
                {
                    string t = setProb(title.ToString().Length, maxL) + title.ToString() + setProb(title.ToString().Length, maxL);
                    _writer.Write(t);
                    del += t.Length;
                    if (0 != cras)
                    {
                        _writer.Write("|");
                        ++del;
                        --cras;
                    }
                }
                _writer.WriteLine();
                while (cras != del)
                {
                    _writer.Write("-");
                    ++cras;
                }
                _writer.WriteLine();
            }
            else
            {
                MessageBox.Show("Данные отсутствуют");
                return;
            }

            foreach (var str in _answer)
            {
                int cras = str.Count - 1;
                foreach (var val in str.Values)
                {
                    string t = setProb(val.ToString().Length, maxL) + val.ToString() + setProb(val.ToString().Length, maxL);
                    _writer.Write(t);
                    if (0 != cras)
                    {
                        _writer.Write("|");
                        --cras;
                    }
                }
                _writer.WriteLine();
            }
            _writer.Close();

            Process.Start(filePath);
        }

        private string setProb(int t1, int t2)
        {
            string res = "";
            for (int i = 0; i < Math.Abs((t1 - t2) / 2); ++i)
            {
                res += " ";
            }
            return res;
        }

        private void ShowMainTable()
        {
            foreach (var str in _answer)
            {
                _dataGridView.Rows.Add();
                foreach (var dic in str)
                {
                    _dataGridView[dic.Key.ToString(), _dataGridView.Rows.Count - 1].Value = dic.Value;
                }
            }
        }

        public void CreateMainTableView(List<Dictionary<object, object>> list)
        {
            _answer = list;
            _dataGridView.Rows.Clear();
            if (_answer != null && _answer.Count != 0)
            {
                _dataGridView.Columns.Clear();
                var str = _answer[0];
                foreach (var title in str.Keys)
                    AddColumn(title.ToString(), true);
            }
            else
            {
                MessageBox.Show("Данные отсутствуют");
                return;
            }
            ShowMainTable();
        }

        private void AddColumn(string columnNameView, bool isSorting)
        {
            var column = new DataGridViewColumn();
            column.HeaderText = columnNameView;
            column.Name = columnNameView;
            column.ReadOnly = true;
            column.SortMode = DataGridViewColumnSortMode.NotSortable;
            if (isSorting)
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            column.CellTemplate = new DataGridViewTextBoxCell();

            _dataGridView.Columns.Add(column);
        }
    }
}