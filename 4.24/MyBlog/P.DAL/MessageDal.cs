using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P.Model;
using System.Data;
using System.Data.SqlClient;

namespace P.DAL
{
    public class MessageDal
    {
        public int UpdateMessage(MessageDb messageDb)
        {
            string str = "update MessageDb set titleMess =@titleMess,textMess=@textMess where no=1 ";

            SqlParameter[] pars ={
                                  new SqlParameter("@titleMess",SqlDbType.VarChar,50),
                                  new SqlParameter("@textMess",SqlDbType.Text),
                                  

                                };
            pars[0].Value = messageDb.TitleMes;
            pars[1].Value = messageDb.TextMes;

            return SqlHelper.GetExecuteNonQuery(str, CommandType.Text, pars);
        }
        public MessageDb getMessage()
        {
            string str = "select * from MessageDB";
            DataTable da = SqlHelper.GetTable(str, CommandType.Text);
            MessageDb message = new MessageDb();
            if (da.Rows.Count > 0)
            {
                
                foreach (DataRow datarow in da.Rows)
                {
                    LoadMessageDb(datarow, message);
                }
            }
            return message;
        }
        public void LoadMessageDb(DataRow rows, MessageDb messageDb)
        {
            messageDb.TitleMes = rows["titleMess"].ToString();
            messageDb.TextMes = rows["textMess"].ToString();
        }
    }
}
