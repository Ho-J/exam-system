using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P.Model;

namespace P.DAL
{
    public class TeacherDal
    {
        public int  UpdateTeacherForDB(Teachers teachers)
        {
            string str = "select * from Subject_Teacher where TeacherId=@TeacherId";
            SqlParameter[] pars = {

                 new SqlParameter("@teacherId",SqlDbType.Int),
                 };
            pars[0].Value = teachers.id;
            string state = "未分配";
            if (SqlHelper.GetTable(str, CommandType.Text,pars).Rows.Count > 0)
            {
                state = "已分配";
            }


            string sql = "update teachers set password=@password,state=@state where id=@id";
            SqlParameter[] pars1 = {
                new SqlParameter("@password",SqlDbType.VarChar,50),
                new SqlParameter("@state",SqlDbType.VarChar,50),
                 new SqlParameter("@id",SqlDbType.Int),
            };
            pars1[0].Value = teachers.pwd;
            pars1[1].Value = state;
            pars1[2].Value = teachers.id;
           return   SqlHelper.GetExecuteNonQuery(sql, CommandType.Text, pars1);
        }
        public void AddSubject_Teacher(List<Subject_Teacher> list)
        {
            //先删除全部关系
            string str = "delete  from Subject_Teacher where TeacherId=@TeacherId";
            SqlParameter[] pars1 = {
             
                 new SqlParameter("@teacherId",SqlDbType.Int),
                 };
            pars1[0].Value = list[0].TeacherId;
            SqlHelper.GetExecuteNonQuery(str, CommandType.Text, pars1);

            if (list[0].subjectName == null)
            {
                list.Clear();

            }

            foreach (Subject_Teacher subject_Teacher in list)
            {
                string sql = "insert into subject_teacher (subjectName,teacherId) values(@subjectName,@teacherId)";
                SqlParameter[] pars = {
                 new SqlParameter("@subjectName",SqlDbType.VarChar,20),
                 new SqlParameter("@teacherId",SqlDbType.Int),
                 };
                pars[0].Value = subject_Teacher.subjectName;
                pars[1].Value = subject_Teacher.TeacherId;
                SqlHelper.GetExecuteNonQuery(sql, CommandType.Text, pars);
            }

        }

            //通过Id搜索
        public Teachers IdToTeacher(Teachers t)
        {
            string sql = "select * from teachers where id=@id";
            SqlParameter[] pars1 = {
                 new SqlParameter("@id",SqlDbType.Int),
            };
            pars1[0].Value = t.id;

            DataTable da = SqlHelper.GetTable(sql, CommandType.Text,pars1);

            Teachers teachers = new Teachers();
            LoadTeacher(da.Rows[0], teachers);
            return teachers;
        }
        public List<Teachers> GetTeacherList()
        {
            string sql = "select * from teachers";

            DataTable da = SqlHelper.GetTable(sql, CommandType.Text);
            List<Teachers> list = new List<Teachers>();
            Teachers teachers;
            if (da.Rows.Count > 0)
            {
                foreach (DataRow datarow in da.Rows)
                {
                    teachers = new Teachers();
                    LoadTeacher(datarow, teachers);
                    list.Add(teachers);
                }
            }
            return list;
        }

        public int AddTeacher(Teachers teachers)
        {
            string sql = "insert into teachers (account,password,name,academy,tel,emil,position,imgUrl,state)" +
                " values(@account,@password,@name,@academy,@tel,@emil,@position,@imgUrl,@state)";
            SqlParameter[] pars1 ={
                                  new SqlParameter("@account",SqlDbType.VarChar,50),
                                  new SqlParameter("@password",SqlDbType.VarChar,50),
                                  new SqlParameter("@name",SqlDbType.VarChar,50),
                                  new SqlParameter("@academy",SqlDbType.VarChar,50),
                                  new SqlParameter("@tel",SqlDbType.VarChar,50),
                                  new SqlParameter("@emil",SqlDbType.VarChar,50),
                                  new SqlParameter("@position",SqlDbType.VarChar,50),
                                  new SqlParameter("@imgUrl",SqlDbType.VarChar,200),
                                  new SqlParameter("@state",SqlDbType.VarChar,50),
                                };
            pars1[0].Value = teachers.account;
            pars1[1].Value = teachers.pwd;
            pars1[2].Value = teachers.name;
            pars1[3].Value = teachers.academy;
            pars1[4].Value = teachers.tel;
            pars1[5].Value = teachers.emil;
            pars1[6].Value = teachers.position;
            pars1[7].Value = teachers.imgUrl;
            pars1[8].Value = "未分配"; //teachers.state;
          return    SqlHelper.GetExecuteNonQuery(sql, CommandType.Text, pars1);
        }

        //是否存在此账号
        public Boolean IsExist(Teachers teachers)
        {
            string sql = "select * from teachers where account=@account";
                SqlParameter[] pars1 ={
                                  new SqlParameter("@account",SqlDbType.VarChar,50),
                                };
            pars1[0].Value = teachers.account;
            DataTable da=   SqlHelper.GetTable(sql, CommandType.Text,pars1);
            if (da.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void LoadTeacher(DataRow rows, Teachers teachers)
        {

            teachers.id = rows["id"] != null ? rows["id"].ToString() : string.Empty;
            teachers.pwd = rows["password"] != null ? rows["password"].ToString() : string.Empty;
            teachers.name = rows["name"] != null ? rows["name"].ToString() : string.Empty;
            teachers.account = rows["account"] != null ? rows["account"].ToString() : string.Empty;
            teachers.academy = rows["academy"] != null ? rows["academy"].ToString() : string.Empty;
            teachers.tel = rows["tel"] != null ? rows["tel"].ToString() : string.Empty;
            teachers.emil = rows["emil"] != null ? rows["emil"].ToString() : string.Empty;
            teachers.imgUrl = rows["imgUrl"] != null ? rows["imgUrl"].ToString() : string.Empty;
            teachers.state = rows["state"] != null ? rows["state"].ToString() : string.Empty;
            teachers.position = rows["position"] != null ? rows["position"].ToString() : string.Empty;

        }

    }
}
