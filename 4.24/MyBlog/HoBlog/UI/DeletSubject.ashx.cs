using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using P.BLL;
using P.Model;

namespace UI
{
    /// <summary>
    /// DeletSubject 的摘要说明
    /// </summary>
    public class DeletSubject : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            // context.Response.Write("Hello World");
            ExamSubjectDalServer examSubjectDalServer = new ExamSubjectDalServer();
            ExamSubject examSubject = new ExamSubject();
            examSubject.id= Convert.ToInt32( context.Request.QueryString["id"]);

            examSubjectDalServer.DeletSubject(examSubject);
            context.Response.Redirect("SubjectManage.aspx");
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