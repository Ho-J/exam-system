using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using P.Model;
using P.DAL;
using P.BLL;

namespace UI
{
    public partial class DeleteBm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Students students = new Students();
            students = (Students)Session["account"];
            BaoKao baoKao = new BaoKao();
            baoKao.Sid = students.id;
            baoKao.Eid = Convert.ToInt32(Request.QueryString["id"]);
            ExamSubjectDalServer examSubjectDalServer = new ExamSubjectDalServer();
            examSubjectDalServer.DeletBK(baoKao);
            string str = "detailStudent.aspx?id=" + baoKao.Sid;
            Response.Redirect(str);
        }
    }
}