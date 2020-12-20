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

        public string CheckUser(User user)
        {
            Connect("SYSDBA");
            var type = InsertWithReturnId($"SELECT TYPE FROM PERSONAL WHERE LOGIN = '{user.UserName}' AND PASSWORD = '{user.Password}';", true);
            if (type == null)
                return "";
            return type.ToString();
        }

        public void Connect(string user, string role = "OBS")
        {
            if (user == "teacher")
                role = "EDITOR";
            FbConnectionStringBuilder fb_cons = new FbConnectionStringBuilder();
            fb_cons.Charset = "UTF8";
            fb_cons.UserID = user;
            fb_cons.Role = role;
            fb_cons.WireCrypt = FbWireCrypt.Enabled;
            fb_cons.DataSource = "localhost";
            fb_cons.Password = "123123";
            fb_cons.Database = @"E:\Comp 5.0\Life on vuz\VUZ\Semestr 5\BD\FireBirdEmbedx64\SHOOLK2";
            fb_cons.ServerType = FbServerType.Default;
            _fbCon = new FbConnection(fb_cons.ToString());            
        }

        public object InsertWithReturnId(string request, bool isCommit)
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

        public void SetComboBox(ComboBox comboBox, string table, string column)
        {
            var items = SelectRequest($"SELECT ID, {column} FROM {table}");
            var listDic = new Dictionary<object, object>();
            if (items != null)
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
                MessageBox.Show("Одна из выборок пуста");
            }
        }

        public void DUIRequest(string request, bool isCommit)
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
        }

        public List<Dictionary<object, object>> SelectRequest(string request)
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
            return answer;
        }
    }
}
