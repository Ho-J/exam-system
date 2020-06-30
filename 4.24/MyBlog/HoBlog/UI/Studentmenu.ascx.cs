using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using P.Model;

namespace UI
{
    public partial class Studentmenu : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        //修改个人资料
        protected void LinkButton5_Click1(object sender, EventArgs e)
        {
            Students stu = (Students)Session["account"];
            
            Server.Transfer("Update.aspx?id=" + stu.id + "&s=1");
            LinkButton5.CssClass = "background-color:red;";

        }

       
        //已报考科目
        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            
            Server.Transfer("detailStudent.aspx");
            LinkButton2.CssClass = "background-color:red;";
        }
        //添加报考
        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            LinkButton4.CssClass = "background-color:red;";
            Students st = (Students)Session["account"];
            string str = "baokao?id=" + st.id;
            Server.Transfer("baokao.aspx");
        }
        //查询成绩
        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            // Response.Write("<script>alert('正在开发ing ');</script>");
            LinkButton3.CssClass = "background-color:red;";
            Response.Redirect("ScoreStudent.aspx");
        }
    }
}