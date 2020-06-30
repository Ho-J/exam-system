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
    public class BaoKaoDal
    {

        public int UpdateEstate()
        {
            string sql = "update baokao set estate=2 where estate=1 and examEnd<'"+DateTime.Now+"'";
             return   SqlHelper.GetExecuteNonQuery(sql, CommandType.Text);
            
        }


        //查找可此学号学生报考信息
        public List<BaoKao> SelectId(BaoKao baoKao)
        {
            string str = "select * from baokao where Sid=@id";
            SqlParameter[] pars ={
                                //new SqlParameter("@name", userInfo.UserName),
                                  new SqlParameter("@id",SqlDbType.VarChar,50),

                                };
            pars[0].Value = baoKao.Sid;
            DataTable da = SqlHelper.GetTable(str, CommandType.Text, pars);
            List<BaoKao> list = null;
            if (da.Rows.Count > 0)
            {
                list = new List<BaoKao>();
                BaoKao bk = null;
                foreach (DataRow datarow in da.Rows)
                {
                    bk = new BaoKao();
                    LoadBaoKao(datarow, bk);
                    list.Add(bk);
                }
            }
            return list;
        }
        public BaoKao SelectIdAndEid(BaoKao baoKao)
        {
            string str = "select * from baokao where Sid=@id and Eid=@eid";
            SqlParameter[] pars ={
                                //new SqlParameter("@name", userInfo.UserName),
                                  new SqlParameter("@id",SqlDbType.VarChar,50),
                                   new SqlParameter("@eid",SqlDbType.Int),
                                };
            pars[0].Value = baoKao.Sid;
            pars[1].Value = baoKao.Eid;
            DataTable da = SqlHelper.GetTable(str, CommandType.Text, pars);
            BaoKao list = new BaoKao ();
            if (da.Rows.Count > 0)
            {
                
                foreach (DataRow datarow in da.Rows)
                {
                   
                    LoadBaoKao(datarow, list);
                }
            }
            return list;
        }
        public int DeletBK(BaoKao baoKao)
        {
            string str = "delete baokao where sid=@sid and eid=@eid";
            SqlParameter[] pars ={
                                  new SqlParameter("@sid",SqlDbType.VarChar,50),
                                  new SqlParameter("@eid",SqlDbType.Int),
                       
                                };
            pars[0].Value = baoKao.Sid;
            pars[1].Value = baoKao.Eid;
   
            return SqlHelper.GetExecuteNonQuery(str, CommandType.Text, pars);
        }
        public int InsertBK(BaoKao baoKao)
        {
            string str = "insert into baokao(sid,eid,applytime,Estate) values(@sid,@eid,@applytime,@Estate)";
            SqlParameter[] pars ={
                                  new SqlParameter("@sid",SqlDbType.VarChar,50),
                                  new SqlParameter("@eid",SqlDbType.Int),
                                  new SqlParameter("@applytime",SqlDbType.DateTime),
                                  new SqlParameter("@Estate",SqlDbType.Int),
                                };
            pars[0].Value = baoKao.Sid;
            pars[1].Value = baoKao.Eid;
            pars[2].Value = baoKao.ApplyTime;
            pars[3].Value = baoKao.Estate;// 报考默认为1 1为待考试  2已完成考试
            return SqlHelper.GetExecuteNonQuery(str, CommandType.Text, pars);
        }
        public void LoadBaoKao(DataRow rows, BaoKao baoKao)
        {

            baoKao.Sid = rows["Sid"] != null ? rows["Sid"].ToString() : string.Empty;
            baoKao.Eid = Convert.ToInt32(rows["Eid"]);
            baoKao.ERid = Convert.ToInt32(rows["ERid"]);
            baoKao.Estate = Convert.ToInt32(rows["Estate"]);
            baoKao.Score = Convert.ToInt32(rows["Score"]);
            //students.img= rows["img"] != null ? Convert.FromBase64String(rows["img"].ToString()) : Convert.FromBase64String(string.Empty);
            baoKao.ApplyTime = Convert.ToDateTime(rows["applytime"]);
            //转换未字符类型后再转换为 []byte 类型   tc
        }
    }
}
