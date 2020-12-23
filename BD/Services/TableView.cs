using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD
{
    public class TableView
    {
        private DataGridView _dataGridView;
        private List<Dictionary<object, object>> _answer;

        public TableView(DataGridView dataGridView)
        {
            _dataGridView = dataGridView;
            _dataGridView.AllowUserToAddRows = false;
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
            if (_answer != null && _answer.Count != 0)
            {
                _dataGridView.Columns.Clear();
                var str = _answer[0];
                foreach (var title in str.Keys)
                    AddColumn(title.ToString(), true);

                _dataGridView.Rows.Clear();

                ShowMainTable();
            }
            else 
            {
                MessageBox.Show("Таблица пуста");
            }
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