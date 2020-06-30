using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using P.Model;
using P.BLL;
using P.DAL;
using System.IO;
using System.Data;

namespace UI
{
    public partial class detailStudent : System.Web.UI.Page
    {

        public Students Sstudents = new Students();
        public List<ExamSubject> examSubjectsList = new List<ExamSubject>();
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["account"] == null)
            {
                Response.Write("<script>alert(\"请先登录！\");</script>");
                Server.Transfer("index.aspx");
                return;
            }
            Students students = new Students();
            students = (Students)Session["account"];

            //更新科目状态
            string sql1 = "update baokao set Estate=2  where eid in ( select eid from baokao,examsubject where ExamEnd<'"+DateTime.Now+ "' and Estate=1 and eid=id) and sid='" + students.id+"'";
           // Response.Write(sql1);
            SqlHelper.GetExecuteNonQuery(sql1, CommandType.Text);


            MessageDalServer messageDalServer = new MessageDalServer();
       
            Students st = new Students();

            // st.id= Context.Request.QueryString["id"];
            st = (Students)Session["account"];
           
            
            //Response.Write(st.id);
            StudentsDalServer studentsDalServer = new StudentsDalServer();
            ExamSubjectDalServer examSubjectDalServer = new ExamSubjectDalServer();

            BaoKao bk = new BaoKao();
            bk.Sid = st.id;
            examSubjectsList = examSubjectDalServer.BKtable(bk);
            Sstudents = studentsDalServer.SelectId(st);
            GetData();
            if (!IsPostBack)
            {
                
            }
        }


        private void GetData()
        {
            Students students = new Students();
            students = (Students)Session["account"];
            //选择正在报考状态中的考试科目
            string sql = "select * from examSubject where id in( select eid from baokao where sid='"+students.id+"' and estate=1)";
           // Response.Write(sql);
            GridView1.DataSource=SqlHelper.GetTable(sql, CommandType.Text);
            //  GridView1.DataSource = SqlHelper.GetTable("select * from baokao", CommandType.Text);
            GridView1.DataKeyNames = new string[] { "id" };
            GridView1.DataBind();
        }


        protected void GridView1_Unload(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowDeleted(object sender, GridViewDeletedEventArgs e)
        {
            
        }

        //修改个人资料
        protected void LinkButton5_Click1(object sender, EventArgs e)
        {
            Students stu = (Students)Session["account"];
            Server.Transfer("Update.aspx?id=" + stu.id + "&s=1");
        }


        //已报考科目
        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Server.Transfer("detailStudent.aspx");
        }
        //添加报考
        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            
          Server.Transfer("baokao.aspx");
        }
        //查询成绩
        protected void LinkButton3_Click(object sender, EventArgs e)
        {

            //Response.Write("<script>alert('正在开发ing ');</script>");
            Response.Redirect("ScoreStudent.aspx");

        }
    }
}