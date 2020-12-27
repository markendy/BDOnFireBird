using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.IO;
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
        private StreamReader _streamReader;
        private string _password = "123123";

        public DataBaseAdapter(TextBox label)
        {
            reqShow = label;
            _streamReader = new StreamReader("pass.txt");
            Password = _streamReader.ReadLine();
        }

        public string Password { get => _password; set { _password = value; } }

        public void CreateObsStudent()
        {
            Connect("SYSDBA");

            RequestWithReturnId("DROP ROLE OBS", true, false);

            RequestWithReturnId("CREATE ROLE OBS", true, false);
            RequestWithReturnId("GRANT SELECT ON BIND_TEACHER_THING TO OBS", true, false);
            RequestWithReturnId("GRANT SELECT ON CABINET TO OBS", true, false);
            RequestWithReturnId("GRANT SELECT ON CLASS TO OBS", true, false);
            RequestWithReturnId("GRANT SELECT ON LESSON TO OBS", true, false);
            RequestWithReturnId("GRANT SELECT ON PERFORMANCE TO OBS", true, false);
            RequestWithReturnId("GRANT SELECT ON STUDENT TO OBS", true, false);
            RequestWithReturnId("GRANT SELECT ON TEACHER TO OBS", true, false);
            RequestWithReturnId("GRANT SELECT ON THING TO OBS", true, false);

            RequestWithReturnId("DROP USER STUDENT;", true, false);

            RequestWithReturnId($"CREATE USER STUDENT PASSWORD '{Password}' using plugin Srp", true, false);
            RequestWithReturnId("GRANT OBS TO STUDENT", true, false);
        }

        public void CreateEditorTeacher()
        {
            Connect("SYSDBA");

            RequestWithReturnId("DROP ROLE EDITOR", true, false);

            RequestWithReturnId("CREATE ROLE EDITOR", true, false);
            RequestWithReturnId("GRANT SELECT, REFERENCES ON BIND_TEACHER_THING TO EDITOR", true, false);
            RequestWithReturnId("GRANT SELECT, REFERENCES ON CABINET TO EDITOR", true, false);
            RequestWithReturnId("GRANT SELECT, REFERENCES ON CLASS TO EDITOR", true, false);
            RequestWithReturnId("GRANT SELECT, REFERENCES ON LESSON TO EDITOR", true, false);
            RequestWithReturnId("GRANT SELECT, UPDATE, INSERT, REFERENCES ON PERFORMANCE TO EDITOR", true, false);
            RequestWithReturnId("GRANT SELECT, REFERENCES ON STUDENT TO EDITOR", true, false);
            RequestWithReturnId("GRANT SELECT, REFERENCES   ON TEACHER TO EDITOR", true, false);
            RequestWithReturnId("GRANT SELECT, REFERENCES ON THING TO EDITOR", true, false);
            RequestWithReturnId("GRANT USAGE ON SEQUENCE GEN_PERFORMANCE_ID TO EDITOR", true, false);

            RequestWithReturnId("DROP USER TEACHER;", true, false);

            RequestWithReturnId($"CREATE USER TEACHER PASSWORD '{Password}' using plugin Srp", true, false);
            RequestWithReturnId("GRANT EDITOR TO TEACHER", true, false);

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
            fb_cons.Password = Password;
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

        public void SetComboBox(bool notyfication, ListControl comboBox, string table, string column2, string column1 = null, string whereR = null)
        {
            string where = whereR != null ? $"WHERE {whereR} " : "";
            string col1 = column1 != null ? $"{column1}" : "ID";
            var items = SelectRequest($"SELECT {col1}, {column2} as column_name FROM {table} {where}ORDER BY column_name;");
            
            SetComboBox(notyfication, items, comboBox);            
        }

        public void SetComboBox(bool notyfication, Dictionary<object, object> items, ListControl comboBox)
        {           
            if (items != null && items.Count != 0)
            {                               
                comboBox.DataSource = new BindingSource(items, null);
            }
            else
            {
                if (notyfication)
                    MessageBox.Show("Одна из выборок пуста");
                //MainForm.IsResultOk = false;
                comboBox.DataSource = new BindingSource(null, null);
            }
            comboBox.DisplayMember = "Value";
            comboBox.ValueMember = "Value";
            comboBox.Refresh();
        }

        public void SetComboBox(bool notyfication, List<Dictionary<object, object>> items, ListControl comboBox)
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
                comboBox.DisplayMember = "Value";
                comboBox.ValueMember = "Value";
            }
            else
            {
                if(notyfication)
                    MessageBox.Show("Одна из выборок пуста");
                //MainForm.IsResultOk = false;
                listDic = new Dictionary<object, object>();
            }            
            
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
