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
    public class StudentsDal
    {
        
        public List<Students> GetTable()
        {
            List<Students> list = new List<Students>();
            string str = "select * from Students";
            DataTable da = SqlHelper.GetTable(str, CommandType.Text);
            Students st;
            if (da.Rows.Count > 0)
            {
                foreach (DataRow datarow in da.Rows)
                {
                    st = new Students();
                    LoadStuents(datarow, st);
                    list.Add(st);
                }
            }
            return list;
        }
        //是否查到此账号密码
        public Boolean login(Students student)
        {
            string str = "select * from Students where id=@id and password=@pwd";

            //sql 语句中的替换
            SqlParameter[] pars ={
                                //new SqlParameter("@name", userInfo.UserName),
                                  new SqlParameter("@id",SqlDbType.VarChar,50),
                                  new SqlParameter("@pwd",SqlDbType.VarChar,50),
                                  
                                };
            pars[0].Value = student.id;
            pars[1].Value = student.pwd;
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
        public int UpdateM(Students students)
        {
            string str = "update  Students set name=@name,password=@pwd,state=@state  where id=@id";
            byte[] a = new byte[1];
            SqlParameter[] pars ={
                                  new SqlParameter("@name",SqlDbType.VarChar,50),
                                  new SqlParameter("@pwd",SqlDbType.VarChar,50),
                                  new SqlParameter("@state",SqlDbType.Int),
                                  new SqlParameter("@id",SqlDbType.VarChar,50),
                                };

            pars[0].Value = students.name;
            pars[1].Value = students.pwd;
            pars[2].Value = students.state;
            pars[3].Value = students.id;
            return SqlHelper.GetExecuteNonQuery(str, CommandType.Text, pars);
        }

        public int Update(Students students)
        {



            string str = "update Students set name=@name,password=@password,img=@img,grade=@grade," +
                "major=@major,academy=@academy,emil=@emil,tel=@tel,imgUal=@imgUal,state=@state where id=@id";

            byte[] a = new byte[1];
            SqlParameter[] pars ={
                                  
                                  new SqlParameter("@name",SqlDbType.VarChar,50),
                                  new SqlParameter("@password",SqlDbType.VarChar,50),
                                  new SqlParameter("@img",SqlDbType.Image),
                                  new SqlParameter("@grade",SqlDbType.NChar,10),
                                  new SqlParameter("@major",SqlDbType.VarChar,50),
                                  new SqlParameter("@academy",SqlDbType.VarChar,50),
                                  new SqlParameter("@emil",SqlDbType.VarChar,50),
                                  new SqlParameter("@tel",SqlDbType.VarChar,20),
                                  //
                                  new SqlParameter("@imgUal",SqlDbType.VarChar,200),
                                  new SqlParameter("@state",SqlDbType.Int),
                                  new SqlParameter("@id",SqlDbType.VarChar,50),
                                };
           
            pars[0].Value = students.name;
            pars[1].Value = students.pwd;
            pars[2].Value = students.img != null ? students.img : a;//此处上传若为空文件，则数据库中img不会为null 而是会保存一个值为 0byte数组
            pars[3].Value = students.grade;
            pars[4].Value = students.major;
            pars[5].Value = students.academy;
            pars[6].Value = students.emil;
            pars[7].Value = students.tel;
            //
            pars[9].Value = students.state;
            pars[8].Value = students.imgUal != null ? students.imgUal : "";
            pars[10].Value = students.id;

            return SqlHelper.GetExecuteNonQuery(str, CommandType.Text, pars);
        }
        public Students SelectId(Students students)
        {
            string str = "select * from Students where id=@id";
            SqlParameter[] pars ={
                                //new SqlParameter("@name", userInfo.UserName),
                                  new SqlParameter("@id",SqlDbType.VarChar,50),

                                };
            pars[0].Value = students.id;
            DataTable da = SqlHelper.GetTable(str, CommandType.Text, pars);
            Students st = new Students();
            if (da.Rows.Count > 0)
            {
                foreach (DataRow datarow in da.Rows)
                {
                   
                    LoadStuents(datarow, st);
                }
            }
            return st;
        }

        //添加学生账号
        public int Add(Students students)
        {
            string str = "insert into Students(id,name,password,img,grade,major,academy,emil,tel,state,imgUal) " +
                "values(@id,@name,@pwd,@img,@grade,@major,@academy,@emil,@tel,@state,@imgUal)";//,@state  ,state

            byte[] a = new byte[1];
            SqlParameter[] pars ={
                                  new SqlParameter("@id",SqlDbType.VarChar,50),
                                  new SqlParameter("@name",SqlDbType.VarChar,50),
                                  new SqlParameter("@pwd",SqlDbType.VarChar,50),
                                  new SqlParameter("@img",SqlDbType.Image),
                                  new SqlParameter("@grade",SqlDbType.NChar,10),
                                  new SqlParameter("@major",SqlDbType.VarChar,50),
                                  new SqlParameter("@academy",SqlDbType.VarChar,50),
                                  new SqlParameter("@emil",SqlDbType.VarChar,50),
                                  new SqlParameter("@tel",SqlDbType.VarChar,20),
                                  //
                                  new SqlParameter("@state",SqlDbType.Int),
                                  new SqlParameter("@imgUal",SqlDbType.VarChar,200),
                                };
            pars[0].Value = students.id;
            pars[1].Value = students.name;
            pars[2].Value = students.pwd;
            pars[3].Value = students.img!=null ? students.img : a;//此处上传若为空文件，则数据库中img不会为null 而是会保存一个值为 0byte数组
            pars[4].Value = students.grade;
            pars[5].Value = students.major;
            pars[6].Value = students.academy;
            pars[7].Value = students.emil;
            pars[8].Value = students.tel;
            //
            pars[9].Value = students.state;
            pars[10].Value = students.imgUal!=null?students.imgUal:"";

            return SqlHelper.GetExecuteNonQuery(str, CommandType.Text, pars);
        }

        public void LoadStuents(DataRow rows, Students students)
        {
           
            students.id= rows["id"] != null ? rows["id"].ToString() : string.Empty;
            students.name = rows["name"] != null ? rows["name"].ToString() : string.Empty;
            students.pwd = rows["password"] != null ? rows["password"].ToString() : string.Empty;
            students.state =rows["state"] is DBNull?0:Convert.ToInt32(rows["state"]); //Convert.ToInt32(rows["state"])
            students.grade = rows["grade"] != null ? rows["grade"].ToString() : string.Empty;
            //students.img= rows["img"] != null ? Convert.FromBase64String(rows["img"].ToString()) : Convert.FromBase64String(string.Empty);
            students.img = System.Text.Encoding.Default.GetBytes(rows["img"].ToString());
            //转换未字符类型后再转换为 []byte 类型   tc
            students.major = rows["major"] != null ? rows["major"].ToString() : string.Empty;
            students.academy = rows["academy"] != null ? rows["academy"].ToString() : string.Empty;

            students.emil = rows["emil"] != null ? rows["emil"].ToString() : string.Empty;

            students.tel = rows["tel"] != null ? rows["tel"].ToString() : string.Empty;

            students.imgUal = rows["imgUal"] != null ? rows["imgUal"].ToString() : string.Empty;
        }
    }
}
