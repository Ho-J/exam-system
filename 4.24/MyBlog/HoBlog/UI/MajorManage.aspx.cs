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
    public partial class MajorManage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Major major = new Major();
            major.name = TextBox1.Text;
            if (major.name == "")
            {
                Response.Write("<script>alert('输入为空！');</script>");
                return;
            }
            ExamSubjectDalServer examSubjectDalServer = new ExamSubjectDalServer();
            if (examSubjectDalServer.ExistMajor(major))
            {
                Response.Write("<script>alert('请勿重复添加');</script>");
            }
            else
            {
                examSubjectDalServer.AddMajor(major);
                Response.Redirect("MajorManage.aspx");
            }
            

        }
    }
}