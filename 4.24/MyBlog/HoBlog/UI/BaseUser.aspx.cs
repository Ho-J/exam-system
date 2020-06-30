using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using P.Model;
using P.BLL;

namespace UI
{
    public partial class BaseUser : System.Web.UI.Page
    {
        BASE_USERDalServer bASE_USERDalServe = new BASE_USERDalServer();
        public  BASE_USER Base_user = new BASE_USER();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if ((BASE_USER)Session["account"] == null)
            {
                
                Response.Write("< script > alert('请先登录！') </ script >");
                Response.Redirect("index.aspx");
            }
            //Base_user.name= Context.Request.QueryString["name"];
            //Base_user = bASE_USERDalServe.selectBase(Base_user);
            
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Base_user = (BASE_USER)Session["account"];
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
            Server.Transfer("SubjectClassify.aspx");
        }
    }
}