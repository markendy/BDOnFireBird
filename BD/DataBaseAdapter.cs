using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD
{
    public class DataBaseAdapter
    {
        private FbConnection _fbCon;

        public DataBaseAdapter()
        {
            FbConnectionStringBuilder fb_cons = new FbConnectionStringBuilder();
            fb_cons.Charset = "WIN1251"; //кодировка
            fb_cons.UserID = "SYSDBA";
            fb_cons.Password = "123123";
            fb_cons.Database = @"E:\Comp 5.0\Life on vuz\VUZ\Semestr 5\BD\FireBirdEmbedx64\SHOOLK";
            fb_cons.ServerType = FbServerType.Embedded;
            _fbCon = new FbConnection(fb_cons.ToString());
            _fbCon.Open();
            _fbCon.Close();
        }

        public void DUIRequest(string request, bool isCommit)
        {
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
