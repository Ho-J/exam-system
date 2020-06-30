using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using P.Model;
using P.DAL;
using System.Data;

namespace UI
{
    public partial class ExamInfoDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               string id= Request.QueryString["id"];
                string sql = "select * from examInform where id='" + id + "'";
               DataTable da=  SqlHelper.GetTable(sql, System.Data.CommandType.Text);
                Label1.Text = da.Rows[0]["title"].ToString();
                Label2.Text ="发布日期：" +da.Rows[0]["creatTime"].ToString();
                Label3.Text = "来源：" + da.Rows[0]["source"].ToString();
                Label4.Text ="  "+ da.Rows[0]["informText"].ToString();
            }
        }
    }
}