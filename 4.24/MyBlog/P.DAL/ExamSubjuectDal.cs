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
    public class ExamSubjuectDal
    {

        //搜索这个老师负责的考试科目
        public List<ExamSubject> IdToSubject(Teachers t)
        {
            string sql = "select * from ExamSubject where name in( select subjectName from Subject_Teacher where TeacherId=@id)";
            SqlParameter[] pars1 = {
                 new SqlParameter("@id",SqlDbType.Int),
            };
            pars1[0].Value = t.id;

            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, pars1);
            List<ExamSubject> list = new List<ExamSubject>();
            ExamSubject examSubject;
            foreach(DataRow row in da.Rows)
            {
                examSubject = new ExamSubject();
                LoadExamSubject(row, examSubject);
                list.Add(examSubject);
            }
            return list;
            

        }
        //更新约束
        public void  updateCheck(List<Major> list, List<CheckGrade> LC, ExamSubject examSubject,Boolean r1,Boolean r2)
        {
            //删除所有约束，再添加新约束
            string sql1 = "delete from  check_major where examSubjectNo=@examSubjectNo  ";
            string sql2 = "delete from  check_grade where examSubjectNo=@examSubjectNo  ";
            SqlParameter[] pars1 ={
                                  new SqlParameter("@examSubjectNo",SqlDbType.Int)
                                };
            pars1[0].Value = examSubject.id;
            //无限制
            SqlParameter[] pars2 ={
                                  new SqlParameter("@examSubjectNo",SqlDbType.Int)
                                };
            pars2[0].Value = examSubject.id;

            SqlHelper.GetExecuteNonQuery(sql2, CommandType.Text, pars1);
            
           
            
                SqlHelper.GetExecuteNonQuery(sql1, CommandType.Text, pars2);



            AddMajorsBoolean(list, LC, examSubject,r1,r2);

        }

        public List<Major> examSubjectNoToGetCheckMajor(ExamSubject examSubject)
        {
            string sql1 = " select * from major where 专业编号 in(  select checkMajor from check_major where examSubjectNo=@examSubjectNo)";
            SqlParameter[] pars ={
                                  new SqlParameter("@examSubjectNo",SqlDbType.Int)
                                };
            pars[0].Value = examSubject.id;
            DataTable da = SqlHelper.GetTable(sql1, CommandType.Text, pars);
            List<Major> list = new List<Major>();
            if (da.Rows.Count > 0)
            {
                Major check = null;
                foreach (DataRow datarow in da.Rows)
                {
                    check = new Major();
                    LoadMajor(datarow, check);
                    list.Add(check);
                }

            }
            return list;

        }
        //取得grade约束
        public List<CheckGrade> examSubjectNoToGetCheckGrade(  ExamSubject examSubject)
        {
            //取要限制的科目编号
           
            string sql = "select * from check_grade where examSubjectNo=@examSubjectNo";
            SqlParameter[] pars ={
                                  new SqlParameter("@examSubjectNo",SqlDbType.Int)
                                };
            pars[0].Value = examSubject.id;
            DataTable da= SqlHelper.GetTable (sql, CommandType.Text, pars);
            List<CheckGrade> list = new List<CheckGrade>();
            if (da.Rows.Count > 0)
            {
                CheckGrade check = null;
                list = new List<CheckGrade>();
                foreach (DataRow datarow in da.Rows)
                {
                    check = new CheckGrade();
                    LoadGrade(datarow, check);
                    list.Add(check);
                }

            }
            return list;
        }
        public void AddMajorsBoolean(List<Major> list, List<CheckGrade> LC, ExamSubject examSubject,Boolean r1,Boolean r2)
        {
            //取要限制的科目编号
            ExamSubject e = NameToGetSubject(examSubject);

            //  try
            {
                if (!r1)
                {
                    foreach (var m in list)
                    {
                        string sql1 = "select 专业编号 from major where 专业名=@mn";
                        SqlParameter[] pars ={
                                  new SqlParameter("@mn",SqlDbType.VarChar,50)
                                };
                        pars[0].Value = m.name;
                        //取要限制专业编号
                        DataTable d1 = SqlHelper.GetTable(sql1, CommandType.Text, pars);
                        //插入
                        string sql3 = "insert into check_major(examsubjectNo,checkmajor) values(@examsubjectNo,@checkmajor)";
                        SqlParameter[] pars3 ={
                                  new SqlParameter("@examsubjectNo",SqlDbType.VarChar,50),
                                  new SqlParameter("@checkmajor",SqlDbType.VarChar,50)
                                };
                        pars3[0].Value = e.id;
                        if (d1.Rows.Count > 0)
                        {
                            pars3[1].Value = d1.Rows[0][0].ToString();
                            SqlHelper.GetExecuteNonQuery(sql3, CommandType.Text, pars3);
                        }

                    }
                }

                if (!r2)
                {
                    foreach (var m in LC)
                    {
                        string sql3 = "insert into check_grade(examsubjectNo,checkgrade) values(@examsubjectNo,@checkgrade)";
                        SqlParameter[] pars3 ={
                                  new SqlParameter("@examsubjectNo",SqlDbType.VarChar,50),
                                  new SqlParameter("@checkgrade",SqlDbType.VarChar,50)
                                };
                        pars3[0].Value = e.id;
                        pars3[1].Value = m.grade;
                        SqlHelper.GetExecuteNonQuery(sql3, CommandType.Text, pars3);
                    }
                }
                
            }
            // catch
            {
                // Console.WriteLine("数据库连接失败");
            }

        }
        public void AddMajors(List<Major> list, List<CheckGrade> LC, ExamSubject examSubject)
        {
            //取要限制的科目编号
            ExamSubject e= NameToGetSubject(examSubject);

          //  try
            {
                foreach (var m in list)
                {
                    string sql1 = "select 专业编号 from major where 专业名=@mn";
                    SqlParameter[] pars ={
                                  new SqlParameter("@mn",SqlDbType.VarChar,50)
                                };
                    pars[0].Value = m.name;
                    //取要限制专业编号
                    DataTable d1 = SqlHelper.GetTable(sql1, CommandType.Text, pars);
                    //插入
                    string sql3 = "insert into check_major(examsubjectNo,checkmajor) values(@examsubjectNo,@checkmajor)";
                    SqlParameter[] pars3 ={
                                  new SqlParameter("@examsubjectNo",SqlDbType.VarChar,50),
                                  new SqlParameter("@checkmajor",SqlDbType.VarChar,50)
                                };
                    pars3[0].Value = e.id;
                    if (d1.Rows.Count>0)
                    {
                        pars3[1].Value = d1.Rows[0][0].ToString();
                        SqlHelper.GetExecuteNonQuery(sql3, CommandType.Text, pars3);
                    }
                    
                }
                foreach (var m in LC)
                {
                    string sql3 = "insert into check_grade(examsubjectNo,checkgrade) values(@examsubjectNo,@checkgrade)";
                    SqlParameter[] pars3 ={
                                  new SqlParameter("@examsubjectNo",SqlDbType.VarChar,50),
                                  new SqlParameter("@checkgrade",SqlDbType.VarChar,50)
                                };
                    pars3[0].Value = e.id;
                    pars3[1].Value = m.grade;
                    SqlHelper.GetExecuteNonQuery(sql3, CommandType.Text, pars3);
                }
            }
           // catch
            {
               // Console.WriteLine("数据库连接失败");
            }
            
        }
        public Boolean ExistMajor(Major major)
        {
            string sql = "select * from major where 专业名=@专业名";
            SqlParameter[] pars ={
                                  new SqlParameter("@专业名",SqlDbType.VarChar,50)

                                };
            pars[0].Value = major.name;

           if(SqlHelper.GetTable(sql,CommandType.Text,pars).Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public int AddMajor(Major major)
        {
            string sql = "insert into major (专业名) values(@专业名)";
            SqlParameter[] pars ={
                                  new SqlParameter("@专业名",SqlDbType.VarChar,50)

                                };
            pars[0].Value = major.name;

            return SqlHelper.GetExecuteNonQuery(sql, CommandType.Text, pars);

        }
        public List<CheckGrade> getCheckGrade(ExamSubject e)
        {
            string str = "select * from check_grade where examSubjectNo=@examSubjectNo";
            SqlParameter[] pars ={
                                  new SqlParameter("@examSubjectNo",SqlDbType.Int)

                                };
            pars[0].Value = e.id;

            DataTable da = SqlHelper.GetTable(str, CommandType.Text, pars);
            List<CheckGrade> list = new List<CheckGrade>();
            if (da.Rows.Count > 0)
            {
                CheckGrade check = null;
                list = new List<CheckGrade>();
                foreach (DataRow datarow in da.Rows)
                {
                    check = new CheckGrade();
                    LoadGrade(datarow, check);
                    list.Add(check);
                }

            }
            return list;
        }
        public List<Major> getCheckMajor(ExamSubject e)
        {
            string str = "select * from major where 专业编号 in ( select checkMajor from check_major where examSubjectNo=@examSubjectNo)";
            SqlParameter[] pars ={
                                  new SqlParameter("@examSubjectNo",SqlDbType.Int)

                                };
            pars[0].Value = e.id;

            DataTable da = SqlHelper.GetTable(str, CommandType.Text, pars);
            List<Major> list = null;
            if (da.Rows.Count > 0)
            {
                Major major = null;
                list = new List<Major>();
                foreach (DataRow datarow in da.Rows)
                {
                    major = new Major();
                    LoadMajor(datarow, major);
                    list.Add(major);
                }

            }
            return list;
        }
        public int UpdateBaoKao(BaoKao baoKao)
        {
            string str = "update BaoKao set score =@score where sid=@sid and eid=@eid";

            SqlParameter[] pars ={
                                  new SqlParameter("@score",SqlDbType.Int),
                                  new SqlParameter("@sid",SqlDbType.VarChar,50),
                                  new SqlParameter("@eid",SqlDbType.Int),
                                  

                                };
            pars[0].Value = baoKao.Score;
            pars[1].Value = baoKao.Sid;
            pars[2].Value = baoKao.Eid;

            return SqlHelper.GetExecuteNonQuery(str, CommandType.Text, pars);
        }
        public DataTable DetailsSubjectDataTable(BaoKao baoKao)
        {
            string str = "select name,grade,ApplyTime,Score,Estate,sid from baokao b,Students s where b.Sid=s.id and b.eid=@eid";
            SqlParameter[] pars ={
                                  new SqlParameter("@eid",SqlDbType.Int)

                                };
            pars[0].Value = baoKao.Eid;

            DataTable da = SqlHelper.GetTable(str, CommandType.Text, pars);
            return da;
        }
        public List<DetailsSubject> DetailsSubject(BaoKao baoKao)
        {
            string str = "select name,grade,ApplyTime,Score,Estate,sid from baokao b,Students s where b.Sid=s.id and b.eid=@eid";
            SqlParameter[] pars ={
                                  new SqlParameter("@eid",SqlDbType.Int)

                                };
            pars[0].Value = baoKao.Eid;

            DataTable da = SqlHelper.GetTable(str, CommandType.Text, pars);
            
            List<DetailsSubject> list= new List<DetailsSubject>();//
            if (da.Rows.Count > 0)
            {
                DetailsSubject detailsSubject = null;
                foreach (DataRow datarow in da.Rows)
                {
                    detailsSubject = new DetailsSubject();
                    LoadExamSubject1(datarow, detailsSubject);
                    list.Add(detailsSubject);
                }
               
            }
            
            return list;
        }

        public void LoadMajor(DataRow rows, Major major)
        {
            major.id = Convert.ToInt32( rows["专业编号"]);
            major.name = rows["专业名"] != null ? rows["专业名"].ToString().Trim() : string.Empty;
        }
        public void LoadGrade(DataRow rows, CheckGrade check)
        {
            check.examsubjecSubject = Convert.ToInt32(rows["examSubjectNo"]);
            check.grade = rows["checkGrade"] != null ? rows["checkGrade"].ToString().Trim() : string.Empty;
        }
        public void LoadExamSubject1(DataRow rows, DetailsSubject detailsSubject)
        {

            detailsSubject.name = rows["name"] != null ? rows["name"].ToString().Trim() : string.Empty;
            //detailsSubject.name = rows["Score"].ToString();
            detailsSubject.ApplyTime = Convert.ToDateTime(rows["ApplyTime"]);
            detailsSubject.grade = rows["grade"] != null ? rows["grade"].ToString() : string.Empty;
            // detailsSubject.Score = int.Parse(rows["Score"].ToString()) is DBNull ? -1 : Convert.ToInt32(rows["Score"]);// Convert.ToInt32(rows["Score"])
            //string date = rows["Score"] is DBNull ? "-1" : rows["Score"].ToString;//rows["Score"].ToString()
            detailsSubject.Score =Convert.ToInt32( rows["Score"] is DBNull ? "-1" : rows["Score"].ToString()); 
            detailsSubject.Estate = Convert.ToInt32(rows["Estate"] is DBNull ? "-1" : rows["Estate"].ToString()); ;//Convert.ToInt32(rows["Estate"])
            detailsSubject.sid = rows["sid"] != null ? rows["sid"].ToString() : string.Empty;

        }

        public int AddSubject(ExamSubject examSubject)
        {
            string str = "insert into ExamSubject (name,ApplyStar,ApplyEnd,ExamEnd,ExamStar,detail,examPlace,classifyName) values(@name,@ApplyStar,@ApplyEnd,@ExamStar,@ExamEnd,@detail,@examPlace,@classifyName)";
            SqlParameter[] pars ={
                                  new SqlParameter("@name",SqlDbType.VarChar,50),
                                  new SqlParameter("@ApplyStar",SqlDbType.DateTime),
                                  new SqlParameter("@ApplyEnd",SqlDbType.DateTime),
                                  new SqlParameter("@ExamEnd",SqlDbType.DateTime),
                                  new SqlParameter("@ExamStar",SqlDbType.DateTime),
                                  new SqlParameter("@detail",SqlDbType.VarChar,200),
                                  new SqlParameter("@examPlace",SqlDbType.VarChar,200),
                                  new SqlParameter("@classifyName",SqlDbType.VarChar,200),

                                };
            pars[0].Value = examSubject.name;
            pars[1].Value = examSubject.ApplyStar;
            pars[2].Value = examSubject.ApplyEnd;
            pars[4].Value = examSubject.ExamEnd;
            pars[3].Value = examSubject.ExamStar;
            pars[5].Value = examSubject.detail;
            pars[6].Value = examSubject.examPlace;
            pars[7].Value = examSubject.classifyName;
            return SqlHelper.GetExecuteNonQuery(str, CommandType.Text, pars);

        }
        public int DeletSubject(ExamSubject examSubject)
        {
            string str = "delete ExamSubject where id=@id ";

            SqlParameter[] pars ={
                                  new SqlParameter("@id",SqlDbType.Int)

                                };
            pars[0].Value = examSubject.id;
            return SqlHelper.GetExecuteNonQuery(str, CommandType.Text, pars);
        }

        public ExamSubject NameToGetSubject(ExamSubject examSubject)
        {
            string str = "select * from ExamSubject where name=@name";
            SqlParameter[] pars = {
                new SqlParameter("@name",SqlDbType.VarChar,50)
            };
            pars[0].Value = examSubject.name;
            ExamSubject ex = new ExamSubject();
            DataTable da = SqlHelper.GetTable(str, CommandType.Text, pars);
            if (da.Rows.Count > 0)
            {

                foreach (DataRow datarow in da.Rows)
                {
                    LoadExamSubject(datarow, ex);
                }
            }
            return ex;
        }

        public ExamSubject GetSubject(ExamSubject examSubject)
        {
            string str = "select * from ExamSubject where id=@id";
            SqlParameter[] pars = {
                new SqlParameter("@id",SqlDbType.Int)
            };
            pars[0].Value = examSubject.id;
            ExamSubject ex = new ExamSubject();
            DataTable da = SqlHelper.GetTable(str, CommandType.Text, pars);
            if (da.Rows.Count > 0)
            {
                
                foreach (DataRow datarow in da.Rows)
                {
                    LoadExamSubject(datarow, ex);
                }
            }
            return ex;
        }
        public int UpdateExamSubject(ExamSubject examSubject)
        {
            string str = "update ExamSubject set name =@name,ApplyStar=@ApplyStar,ApplyEnd=@ApplyEnd," +
                "ExamEnd=@ExamEnd,ExamStar=@ExamStar,examPlace=@examPlace,detail=@detail,classifyName=@classifyName where id=@id ";

            SqlParameter[] pars ={
                                  new SqlParameter("@name",SqlDbType.VarChar,50),
                                  new SqlParameter("@ApplyStar",SqlDbType.DateTime),
                                  new SqlParameter("@ApplyEnd",SqlDbType.DateTime),
                                  new SqlParameter("@ExamEnd",SqlDbType.DateTime),
                                  new SqlParameter("@ExamStar",SqlDbType.DateTime),
                                  new SqlParameter("@examPlace",SqlDbType.VarChar,200),
                                  new SqlParameter("@detail",SqlDbType.VarChar,200),
                                  new SqlParameter("@classifyName",SqlDbType.VarChar,200),
                                  new SqlParameter("@id",SqlDbType.Int),
                                  

                                };
            pars[0].Value = examSubject.name;
            pars[1].Value = examSubject.ApplyStar;
            pars[2].Value = examSubject.ApplyEnd;
            pars[3].Value = examSubject.ExamEnd;
            pars[4].Value = examSubject.ExamStar;
            pars[5].Value = examSubject.examPlace;
            pars[6].Value = examSubject.detail;
            pars[7].Value = examSubject.classifyName;
            pars[8].Value = examSubject.id;
            return SqlHelper.GetExecuteNonQuery(str, CommandType.Text, pars);
        }

        //  查看可报考的 科目   去掉约束科目 去掉已选科目
        public List<ExamSubject> NotBKtable(BaoKao baoKao)
        {
            //string str = "select * from ExamSubject where id not in( select Eid from baokao where sid=@id)";
            string str = "select * from ExamSubject where (id not in (select * from ( sele" +
                "ct examSubjectNo from check_grade where checkGrade not in" +
                " (select grade from Students where id=@id) ) a where" +
                " a.examSubjectNo in (select examSubjectNo from Check_major wh" +
                "ere '专业名' not in (select major from Students where id=@id))) ) and (id not in( select Eid from baokao where sid=@id  ))";//andEstate!=3
            SqlParameter[] pars ={
                                  new SqlParameter("@id",SqlDbType.VarChar,50),
                                };
            pars[0].Value = baoKao.Sid;
            DataTable da = SqlHelper.GetTable(str, CommandType.Text,pars);
            List<ExamSubject> list = new List<ExamSubject>();
            if (da.Rows.Count > 0)
            {
                
                ExamSubject bk = null;
                foreach (DataRow datarow in da.Rows)
                {
                    bk = new ExamSubject();
                    LoadExamSubject(datarow, bk);
                    list.Add(bk);
                }
            }
            return list;

        }
        public List<ExamSubject> BKtable(BaoKao baoKao)
        {
            string str = "select * from ExamSubject where id in( select Eid from baokao where sid=@id)";

            SqlParameter[] pars ={
                                  new SqlParameter("@id",SqlDbType.VarChar,50),

                                };
            pars[0].Value = baoKao.Sid;
            DataTable da = SqlHelper.GetTable(str, CommandType.Text, pars);
            List<ExamSubject> list = new List<ExamSubject>();
            if (da.Rows.Count > 0)
            {
                
                ExamSubject bk = null;
                foreach (DataRow datarow in da.Rows)
                {
                    bk = new ExamSubject();
                    LoadExamSubject(datarow, bk);
                    list.Add(bk);
                }
            }
            return list;
        }
        public List<ExamSubject> GetTable()
        {
            string str = "select * from ExamSubject";
            
            DataTable da = SqlHelper.GetTable(str, CommandType.Text);
            List<ExamSubject> list = new List<ExamSubject>();
            if (da.Rows.Count > 0)
            {
                list = new List<ExamSubject>();
                ExamSubject bk = null;
                foreach (DataRow datarow in da.Rows)
                {
                    bk = new ExamSubject();
                    LoadExamSubject(datarow, bk);
                    list.Add(bk);
                }
            }
            return list;
        }
        public void LoadExamSubject(DataRow rows, ExamSubject examSubject)
        {

            examSubject.id = Convert.ToInt32(rows["id"]); 
            examSubject.name = rows["name"] != null ?rows["name"].ToString().Trim()  : string.Empty;
            examSubject.ApplyStar = Convert.ToDateTime(rows["ApplyStar"]);
            examSubject.ApplyEnd = Convert.ToDateTime(rows["ApplyEnd"]);
            examSubject.ExamStar = Convert.ToDateTime(rows["ExamStar"]);
            //students.img= rows["img"] != null ? Convert.FromBase64String(rows["img"].ToString()) : Convert.FromBase64String(string.Empty);
            examSubject.ExamEnd = Convert.ToDateTime(rows["ExamEnd"]);
            examSubject.detail = rows["detail"] != null ? rows["detail"].ToString().Trim() : string.Empty;
            examSubject.examPlace = rows["examPlace"] != null ? rows["examPlace"].ToString().Trim() : string.Empty;
            examSubject.classifyName = rows["classifyName"] != null ? rows["classifyName"].ToString().Trim() : string.Empty;
            //转换未字符类型后再转换为 []byte 类型   tc
        }
    }
}
