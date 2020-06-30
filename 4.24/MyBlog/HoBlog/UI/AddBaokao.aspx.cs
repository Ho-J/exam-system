using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using P.Model;
using P.BLL;
using P.DAL;
namespace UI
{
    public partial class AddBaokao : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ExamSubjectDalServer examSubjectDalServer = new ExamSubjectDalServer();
  
            
            //context.Response.Write("Hello World");
            BaoKao baoKao = new BaoKao();
            // baoKao.Sid= context.Request.QueryString["sid"];
            Students students = (Students)Session["account"];
            baoKao.Sid = students.id;

            baoKao.Eid = Convert.ToInt32(Request.QueryString["eid"]);


            string sql = "select * from baokao where sid='" + baoKao.Sid + "' and Eid=" + baoKao.Eid;
            string str = "baokao.aspx?id=" + baoKao.Sid;
            //已报考
            if (SqlHelper.GetTable(sql, System.Data.CommandType.Text).Rows.Count > 0)
            {
                
                Server.Transfer(str);
            }
            else
            {
                baoKao.ApplyTime = DateTime.Now;
                baoKao.Estate = 1;//待考试
                
                examSubjectDalServer.InsertBK(baoKao);

                Server.Transfer(str);
            }

           
        }
    }
}