using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD
{
    public class DataBaseAdapter
    {
        private FbConnection _fbCon;
        private TextBox reqShow;        

        public DataBaseAdapter(TextBox label)
        {
            reqShow = label;
        }

        public string CheckUser(User user)
        {
            Connect("SYSDBA");
            var type = RequestWithReturnId($"SELECT TYPE FROM PERSONAL WHERE LOGIN = '{user.UserName}' AND PASSWORD = '{user.Password}';", true);
            if (type == null)
                return "";
            return type.ToString();
        }

        public string Connect(string user, string role = "OBS")
        {
            if (user == "TEACHER")
                role = "EDITOR";
            if (user == "SYSDBA")
                role = "ADMIN";
            FbConnectionStringBuilder fb_cons = new FbConnectionStringBuilder();
            fb_cons.Charset = "UTF8";
            fb_cons.Dialect = 3;
            fb_cons.UserID = user;
            fb_cons.Role = role;
            fb_cons.WireCrypt = FbWireCrypt.Enabled;
            fb_cons.DataSource = "localhost";
            fb_cons.Password = "123123";
            fb_cons.Pooling = true;
            fb_cons.Database = String.Format(@"{0}/SHOOLK2", Environment.CurrentDirectory);
            fb_cons.ServerType = FbServerType.Default;
            _fbCon = new FbConnection(fb_cons.ToString());
            return role;
        }

        public object RequestWithReturnId(string request, bool isCommit, bool notification = true)
        {
            if (notification)
            try
            {
                Console.WriteLine(request);
                _fbCon.Open();
                FbTransaction transaction = _fbCon.BeginTransaction();
                FbCommand command = new FbCommand(request, _fbCon, transaction);
                var lastId = command.ExecuteScalar();
                if (isCommit)
                    transaction.Commit();
                else
                    transaction.Rollback();
                _fbCon.Close();
                return lastId;
            }
            catch (FbException e)
            {
                MessageBox.Show("Ошибка "+e.Message);
                MainForm.IsResultOk = false;
                _fbCon.Close();
                return 0;
            }
            else
            {
                try
                {
                    Console.WriteLine(request);
                    _fbCon.Open();
                    FbTransaction transaction = _fbCon.BeginTransaction();
                    FbCommand command = new FbCommand(request, _fbCon, transaction);
                    var ans = command.ExecuteScalar();
                    transaction.Commit();
                    _fbCon.Close();
                    return ans;
                }
                catch(Exception e)
                {
                    Console.WriteLine("[ERROR] "+e.Message);
                    _fbCon.Close();
                    return null;
                }
            }
        }

        public void SetComboBox(ListControl comboBox, string table, string column2, string column1 = null, string whereR = null)
        {
            string where = whereR != null ? $"WHERE {whereR} " : "";
            string col1 = column1 != null ? $"{column1}" : "ID";
            var items = SelectRequest($"SELECT {col1}, {column2} FROM {table} {where}ORDER BY {column2};");
            
            SetComboBox(items, comboBox);            
        }

        public void SetComboBox(Dictionary<object, object> items, ListControl comboBox)
        {           
            if (items != null && items.Count != 0)
            {                               
                comboBox.DataSource = new BindingSource(items, null);
            }
            else
            {
                MessageBox.Show("Одна из выборок пуста");
                MainForm.IsResultOk = false;
                comboBox.DataSource = new BindingSource(null, null);
            }
            comboBox.DisplayMember = "Value";
            comboBox.ValueMember = "Value";
            comboBox.Refresh();
        }

        public void SetComboBox(List<Dictionary<object, object>> items, ListControl comboBox)
        {
            var listDic = new Dictionary<object, object>();
            if (items != null && items.Count != 0)
            {
                foreach (var item in items)
                {
                    List<object> vl = new List<object>();
                    foreach (var dic in item)
                    {
                        vl.Add(dic.Value);
                    }
                    listDic[vl[0]] = vl[1];
                }
                comboBox.DataSource = new BindingSource(listDic, null);
            }
            else
            {
                MessageBox.Show("Одна из выборок пуста");
                MainForm.IsResultOk = false;
                comboBox.DataSource = new BindingSource(null, null);
            }
            comboBox.DisplayMember = "Value";
            comboBox.ValueMember = "Value";
            comboBox.Refresh();
        }

        public void DUIRequest(string request, bool isCommit)
        {
                try
                {
                    Console.WriteLine(request);
                    _fbCon.Open();
                    FbTransaction transaction = _fbCon.BeginTransaction();
                    FbCommand command = new FbCommand(request, _fbCon, transaction);
                    command.ExecuteNonQuery();
                    if (isCommit)
                        transaction.Commit();
                    else
                        transaction.Rollback();
                    _fbCon.Close();
                    reqShow.Text = request;
                }
                catch (FbException e)
                {
                        MessageBox.Show("Ошибка " + e.Message);             
                        MainForm.IsResultOk = false;                
                    _fbCon.Close();
                }            
        }

        public List<Dictionary<object, object>> ShowOnMainTable(string table)
        {
            try
            {
                string request = $"SELECT * FROM {table}";
                Console.WriteLine(request);
                _fbCon.Open();
                FbCommand command = new FbCommand(request, _fbCon);
                FbDataReader dataReader = command.ExecuteReader();
                List<Dictionary<object, object>> answer = new List<Dictionary<object, object>>();
                while (dataReader.Read())
                {
                    Dictionary<object, object> str = new Dictionary<object, object>();
                    for (int i = 0; i < dataReader.FieldCount; ++i)
                    {
                        str.Add(dataReader.GetName(i), dataReader.GetValue(i));
                    }
                    answer.Add(str);
                }
                dataReader.Close();
                _fbCon.Close();
                reqShow.Text = request;
                return answer;
            }
            catch (FbException e)
            {
                MessageBox.Show("Ошибка " + e.Message);
                MainForm.IsResultOk = false;
                _fbCon.Close();
                return new List<Dictionary< object, object>>();;
            }
        }

        public List<Dictionary<object, object>> SelectRequest(string request)
        {
            try
            {
                Console.WriteLine(request);
                _fbCon.Open();
                FbCommand command = new FbCommand(request, _fbCon);
                FbDataReader dataReader = command.ExecuteReader();
                List<Dictionary<object, object>> answer = new List<Dictionary<object, object>>();
                while (dataReader.Read())
                {
                    Dictionary<object, object> str = new Dictionary<object, object>();
                    for (int i = 0; i < dataReader.FieldCount; ++i)
                    {
                        str.Add(dataReader.GetName(i), dataReader.GetValue(i));
                    }
                    answer.Add(str);
                }
                dataReader.Close();
                _fbCon.Close();
                reqShow.Text = request;
                if (answer != null)
                    return answer;
                return new List<Dictionary<object, object>>();
            }
            catch (FbException e)
            {
                MessageBox.Show("Ошибка " + e.Message);
                MainForm.IsResultOk = false;
                _fbCon.Close();
                return new List<Dictionary<object, object>>();
            }
        }
    }
}
