using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI
{
    public partial class HeadTT : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            if (Session["type"] == null|| Session["account"]==null)
            {
                Response.Write("<script>alert('请先登录！');</script>");
                //Response.Redirect("index.aspx");
                return;
            }
            else
            {
                if (Session["type"].ToString() == "student")
                {
                    string str = "baokao.aspx";
                    Server.Transfer(str);
                }
                else if(Session["type"].ToString() == "baseUser")
                {
                    string str = "BaseUser.aspx";
                    Server.Transfer(str);
                }
                else if(Session["type"].ToString() == "teacher")
                {
                    string str = "Teacher.aspx";
                    Server.Transfer(str);
                }
            }
        }
    }
}