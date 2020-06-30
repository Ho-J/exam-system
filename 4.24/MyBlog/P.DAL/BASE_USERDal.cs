using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P.Model;
using System.Data;
using System.Data.SqlClient;
using P.DAL;

namespace P.Model
{
    public class BASE_USERDal
    {
        public void  GetExamInformList(ExamInform examInform)
        {

        }
        public int AddExamInform(ExamInform examInform)
        {
            string sql = "insert into ExamInform(title,informText,creatTime,creatId,source) values(@title,@informText,@creatTime,@creatId,@source)";
         
            SqlParameter[] pars ={
                                //new SqlParameter("@name", userInfo.UserName),
                                  
                                  new SqlParameter("@title",SqlDbType.VarChar,200),
                                  new SqlParameter("@informText",SqlDbType.Text),
                                  new SqlParameter("@creatTime",SqlDbType.DateTime),
                                  new SqlParameter("@creatId",SqlDbType.VarChar,20),
                                  new SqlParameter("@source",SqlDbType.VarChar,200),
                                };
            pars[0].Value = examInform.title;
            pars[1].Value = examInform.informText;
            pars[2].Value = examInform.creatTime;
            pars[3].Value = examInform.creatId;
            pars[4].Value = examInform.source;

            return SqlHelper.GetExecuteNonQuery(sql, CommandType.Text, pars);

        }
        public Boolean UPpwd(BASE_USER bASE_USER)
        {
            string str = "update BASE_USER set password =@password where name=@name ";
            SqlParameter[] pars ={
                                //new SqlParameter("@name", userInfo.UserName),
                                  
                                  new SqlParameter("@password",SqlDbType.VarChar,20),
                                  new SqlParameter("@name",SqlDbType.VarChar,20),
                                };
            pars[0].Value = bASE_USER.pwd;
            pars[1].Value = bASE_USER.name;
            if(SqlHelper.GetExecuteNonQuery(str, CommandType.Text, pars)>0)
            {
                return true;
            }
            else
            {
                return false;
            }
             
            
        }
        public Teachers loginTeacher(Teachers teachers)
        {
            string str = "select * from teachers where account=@account and password=@password";

            //sql 语句中的替换
            SqlParameter[] pars ={
                                //new SqlParameter("@name", userInfo.UserName),
                                  new SqlParameter("@account",SqlDbType.VarChar,50),
                                  new SqlParameter("@password",SqlDbType.VarChar,50),

                                };
            pars[0].Value = teachers.account;
            pars[1].Value = teachers.pwd;
            DataTable da = SqlHelper.GetTable(str, CommandType.Text, pars);
            Teachers teachers1 = new Teachers();
            if (da.Rows.Count > 0)
            {
                foreach (DataRow datarow in da.Rows)
                {
                    LoadTeacher(datarow, teachers1);
                }
            }
            return teachers1;
        }

        

        public Boolean login(BASE_USER bASE_USER)
        {
            string str = "select * from BASE_USER where name=@name and password=@password";

            //sql 语句中的替换
            SqlParameter[] pars ={
                                //new SqlParameter("@name", userInfo.UserName),
                                  new SqlParameter("@name",SqlDbType.VarChar,20),
                                  new SqlParameter("@password",SqlDbType.VarChar,20),

                                };
            pars[0].Value = bASE_USER.name;
            pars[1].Value = bASE_USER.pwd;
            DataTable da = SqlHelper.GetTable(str, CommandType.Text, pars);
            if (da.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public BASE_USER selectBase(BASE_USER bASE_USER)
        {
            string str = "select * from BASE_USER where name=@name";
            SqlParameter[] pars ={
                                  new SqlParameter("@name",SqlDbType.VarChar,20),

                                };
            pars[0].Value = bASE_USER.name;
            DataTable da = SqlHelper.GetTable(str, CommandType.Text, pars);
            BASE_USER bASE_USER1 = new BASE_USER();
            if (da.Rows.Count > 0)
            {
                foreach (DataRow datarow in da.Rows)
                {

                    LoadBase(datarow, bASE_USER1);
                }
            }
            return bASE_USER1;
        }
        public void LoadBase(DataRow rows, BASE_USER bASE_USER1)
        {

            bASE_USER1.id = Convert.ToInt32(rows["id"]);
            bASE_USER1.name = rows["name"] != null ? rows["name"].ToString() : string.Empty;
            bASE_USER1.pwd = rows["password"] != null ? rows["password"].ToString() : string.Empty;
            bASE_USER1.jurisdiction = Convert.ToInt32(rows["jurisdiction"]);
            
        }
        public void LoadTeacher(DataRow rows, Teachers teachers)
        {

            teachers.id = rows["id"].ToString();
            teachers.name = rows["name"] != null ? rows["name"].ToString() : string.Empty;
            teachers.pwd = rows["password"] != null ? rows["password"].ToString() : string.Empty;

        }

    }
}
