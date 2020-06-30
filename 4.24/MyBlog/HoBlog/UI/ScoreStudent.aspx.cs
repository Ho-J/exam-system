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
    public partial class ScorStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGV();
            }
        }
        private void BindGV()
        {
            Students stu = (Students)Session["account"];
            string sid = stu.id;

            string sql = "select * from baokao where sid ='" + sid + "' and estate!=1";
            GridView1.DataSource = SqlHelper.GetTable(sql, System.Data.CommandType.Text);
            GridView1.DataKeyNames = new string[] { "sid", "eid" };
            GridView1.DataBind();
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

        protected void Button2_Click(object sender, EventArgs e)
        {
            BindGV();
        }


        //已录入
        private void BindGV2()
        {
            Students stu = (Students)Session["account"];
            string sid = stu.id;

            string sql = "select * from baokao where sid ='" + sid + "' and estate=3";
            GridView1.DataSource = SqlHelper.GetTable(sql, System.Data.CommandType.Text);
            GridView1.DataKeyNames = new string[] { "sid", "eid" };
            GridView1.DataBind();
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            BindGV2();
        }

        //未录入
        private void BindGV3()
        {
            Students stu = (Students)Session["account"];
            string sid = stu.id;

            string sql = "select * from baokao where sid ='" + sid + "' and estate=2";
            GridView1.DataSource = SqlHelper.GetTable(sql, System.Data.CommandType.Text);
            GridView1.DataKeyNames = new string[] { "sid", "eid" };
            GridView1.DataBind();
        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            BindGV3();
        }

        //科目查找
        private void BindGV4()
        {
            Students stu = (Students)Session["account"];
            string sid = stu.id;

            string sql = "select * from baokao where sid='"+sid+"' and Eid in (select id from ExamSubject where name like '%"+km.Text+ "%') and estate!=1";
            GridView1.DataSource = SqlHelper.GetTable(sql, System.Data.CommandType.Text);
            GridView1.DataKeyNames = new string[] { "sid", "eid" };
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            BindGV4();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                //Response.Write(e.Row.Cells[0].Text + "," + e.Row.Cells[1].Text + "," + e.Row.Cells[2].Text+"</br>");
                string eid = e.Row.Cells[0].Text;
                string str1 = "select name from examsubject where id=" + eid;
                DataTable da = SqlHelper.GetTable(str1, System.Data.CommandType.Text);
                string subjectName = da.Rows[0][0].ToString();
                e.Row.Cells[0].Text = subjectName;//替代科目名字

                if (e.Row.Cells[2].Text != "3")
                {
                    e.Row.Cells[2].Text = "未录入成绩";
                }
                else
                {
                    e.Row.Cells[2].Text = "已录入成绩";
                }
            }
        }
    }
}