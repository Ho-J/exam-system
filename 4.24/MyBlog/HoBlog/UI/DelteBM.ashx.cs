using P.BLL;
using P.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UI
{
    /// <summary>
    /// DelteBM 的摘要说明
    /// </summary>
    public class DelteBM : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            // context.Response.Write("Hello World");
            ExamSubjectDalServer examSubjectDalServer = new ExamSubjectDalServer();
            context.Response.ContentType = "html/plain";
            //context.Response.Write("Hello World");
            BaoKao baoKao = new BaoKao();
            baoKao.Sid = context.Request.QueryString["sid"];
            baoKao.Eid = Convert.ToInt32(context.Request.QueryString["eid"]);

            examSubjectDalServer.DeletBK(baoKao);
            string str = "detailStudent.aspx?id=" + baoKao.Sid;
            context.Response.Redirect(str);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}