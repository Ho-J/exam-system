using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using P.Model;
using P.BLL;

namespace UI
{
    public partial class UpdateDB : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {

            }
            else
            {
                BASE_USER bASE = (BASE_USER)Session["account"];
                Label1.Text = bASE.name;
                TextBox1.Text = bASE.pwd;
            }
            

        }
        BASE_USERDalServer bASE_USERDalServer = new BASE_USERDalServer();
        protected void Button1_Click(object sender, EventArgs e)
        {
            BASE_USER bASE = new BASE_USER();
            bASE.name = Label1.Text;
            bASE.pwd = TextBox1.Text;
            if (bASE_USERDalServer.UPpwd(bASE))
            {
                Session["account"] = null;
                Response.Write("<script>alert('请重新登录');</script>");
                
                Server.Transfer("index.aspx");
            }
            else
            {
                Response.Write("<script>alert('修改失败');</script>");
            }
           
        }
    }
}