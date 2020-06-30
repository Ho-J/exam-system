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
    public partial class ExamInfoList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BASE_USERDalServer bASE_USERDalServer = new BASE_USERDalServer();
            //SqlDataSource1.SelectCommand = "SELECT [title], [creatTime], [source], [id], [creatId] FROM [ExamInform] where title=";
        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }
    }
}