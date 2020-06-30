using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using P.Model;
using P.BLL;
using System.IO;

namespace UI
{
    /// <summary>
    /// Addbaokao 的摘要说明
    /// </summary>
    public class Addbaokao : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            ExamSubjectDalServer examSubjectDalServer = new ExamSubjectDalServer();
            context.Response.ContentType = "html/plain";
            //context.Response.Write("Hello World");
            BaoKao baoKao = new BaoKao();
            baoKao.Sid= context.Request.QueryString["sid"];
        

            baoKao.Eid = Convert.ToInt32( context.Request.QueryString["eid"]);
            baoKao.ApplyTime = DateTime.Now;
            baoKao.Estate = 2;
            examSubjectDalServer.InsertBK(baoKao);
            string str = "baokao.aspx?id=" + baoKao.Sid;
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