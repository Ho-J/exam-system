using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using P.Model;
using P.DAL;

namespace UI
{
    public partial class Teacher : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["account"] == null )
            {
                Response.Redirect("index.aspx");
                return;
            }

            if (!IsPostBack)
            {
                
            }
        }

        private void BindGV()
        {
            Teachers teachers = (Teachers)Session["account"];
             int tid = Convert.ToInt32(teachers.id);
           // int tid = 4;
            string sql = " select * from ExamSubject where name in (select subjectName from Subject_Teacher where teacherId=" + tid + ")" +
                " and ExamEnd<'"+DateTime.Now+"'";
            //string sql1 = " select * from ExamSubject where name in (select subjectName from Subject_Teacher where teacherId=" + 2 + ")";
            GridView1.DataSource = SqlHelper.GetTable(sql, System.Data.CommandType.Text);
            GridView1.DataKeyNames = new string[] { "id" };
            GridView1.DataBind();
        }
        protected void GridView1_Load(object sender, EventArgs e)
        {
            BindGV();

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {

        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateTeacher2.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Teacher.aspx");
        }
    }
}