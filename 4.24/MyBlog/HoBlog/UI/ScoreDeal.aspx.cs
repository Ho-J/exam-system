using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using P.DAL;
using System.Data;
using P.Model;

namespace UI
{
    public partial class ScoreDeal : System.Web.UI.Page
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
            int eid = Convert.ToInt32(Request.QueryString["subjectid"]);
            
            string sql = "select * from baokao where Eid =" + eid;
            GridView1.DataSource = SqlHelper.GetTable(sql, System.Data.CommandType.Text);
            GridView1.DataKeyNames = new string[] { "sid", "eid" };
            GridView1.DataBind();
        }
        protected void GridView1_Unload(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)//&&e.Row.RowState==DataControlRowState.Normal
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
               // Response.Write(e.Row.Cells[0].Text);
                string sid = e.Row.Cells[0].Text;
                string str1 = "select name from students where id ='" + sid + "'";
                DataTable da = SqlHelper.GetTable(str1, System.Data.CommandType.Text);

                string name = da.Rows[0][0].ToString();

                e.Row.Cells[0].Text = name;//替代学生名字

                string eid = e.Row.Cells[1].Text;
                str1 = "select name from examsubject where id=" + eid;
                da = SqlHelper.GetTable(str1, System.Data.CommandType.Text);
                string subjectName = da.Rows[0][0].ToString();
                e.Row.Cells[1].Text = subjectName;//替代科目名字

                if (e.Row.Cells[2].Text != "3")
                {
                    e.Row.Cells[2].Text = "待录入成绩";
                }
                else
                {
                    e.Row.Cells[2].Text = "已录入成绩";
                }
            }



        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {

            //某行进入编辑状态，绑定VG
            
            GridView1.EditIndex = e.NewEditIndex;
            
            
            BindGV();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            BindGV();
        }

        protected void GridView1_RowUpdated(object sender, GridViewUpdatedEventArgs e)
        {
           
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            var d = GridView1.DataKeys[e.RowIndex];
            BaoKao baokao = new BaoKao();
            baokao.Sid = d[0].ToString();
            
            baokao.Eid = Convert.ToInt32(d[1].ToString());
            //Response.Write((GridView1.Rows[e.RowIndex].Cells[3].Controls[0] as TextBox).Text + "," );
            string score = (GridView1.Rows[e.RowIndex].Cells[3].Controls[0] as TextBox).Text;
            try
            {
                baokao.Score = Convert.ToInt32(score);

            }
            catch
            {
                Response.Write("<script>alert('未正确填写分数');</script>");
                return;
            }
            string sql = "update baokao set score=" + baokao.Score + ",estate=3 where sid='" + baokao.Sid + "' and eid=" + baokao.Eid;
            SqlHelper.GetExecuteNonQuery(sql, CommandType.Text);
            GridView1.EditIndex = -1;
            BindGV();
        }

       
        //查找全部
        protected void Button2_Click(object sender, EventArgs e)
        {
            BindGV();
        }

        //已录入成绩
        private void BindGV3()
        {
            int eid = Convert.ToInt32(Request.QueryString["subjectid"]);

            string sql = "select * from baokao where Eid =" + eid + " and estate=3";
            GridView1.DataSource = SqlHelper.GetTable(sql, System.Data.CommandType.Text);
            GridView1.DataKeyNames = new string[] { "sid", "eid" };
            GridView1.DataBind();
        }
        //已录入
        protected void Button3_Click(object sender, EventArgs e)
        {
            BindGV3();
        }

        //未录入成绩
        private void BindGV2()
        {
            int eid = Convert.ToInt32(Request.QueryString["subjectid"]);

            string sql = "select * from baokao where Eid =" + eid + " and estate!=3";
            GridView1.DataSource = SqlHelper.GetTable(sql, System.Data.CommandType.Text);
            GridView1.DataKeyNames = new string[] { "sid", "eid" };
            GridView1.DataBind();
        }
        //未录入成绩
        protected void Button4_Click(object sender, EventArgs e)
        {
            BindGV2();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = xm.Text;
            string sql = "select * from baokao where sid =( select id from Students where name like '%"+name+"%') and eid="+ Request.QueryString["subjectid"];
            GridView1.DataSource = SqlHelper.GetTable(sql, System.Data.CommandType.Text);
            GridView1.DataKeyNames = new string[] { "sid", "eid" };
            GridView1.DataBind();
        }
        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateTeacher2.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Teacher.aspx");
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}