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
    public partial class MessageManage : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            BASE_USER bs = (BASE_USER)Session["account"];
            ExamInform examInform = new ExamInform();
            examInform.title = TextBox2.Text;
            examInform.informText = TextBox1.Text;
            examInform.source = TextBox3.Text;
            examInform.creatTime = DateTime.Now;
            examInform.creatId = bs.name;

            BASE_USERDalServer bASE_USERDalServer = new BASE_USERDalServer();
            if (bASE_USERDalServer.AddExamInform(examInform)>0)
            {
                Response.Write("<script>alert('发布成功');</script>");
             
                //string str = "BaseUser.aspx";
                //Server.Transfer(str);
            }
            else
            {
                Response.Write("<script>alert('发布失败');</script>");
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Server.Transfer("InfoManage.aspx");
        }
    }
}