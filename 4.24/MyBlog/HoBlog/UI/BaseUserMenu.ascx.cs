using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using P.Model;

namespace UI
{
    public partial class BaseUserMenu : System.Web.UI.UserControl
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
           // BASE_USER  bASE_USER = (BASE_USER)Session["account"];
            Server.Transfer("UpdateDB.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Server.Transfer(" StudentList.aspx");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Server.Transfer(" SubjectManage.aspx");
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Server.Transfer(" AddExamInfo.aspx");
        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            Server.Transfer("TeacherManage.aspx");

        }

        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            Server.Transfer("MajorManage.aspx");
        }

        protected void LinkButton7_Click(object sender, EventArgs e)
        {
            Server.Transfer("BaseUser.aspx");
        }
    }
}