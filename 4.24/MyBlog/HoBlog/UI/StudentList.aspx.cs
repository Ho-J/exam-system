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
    public partial class StudentList : System.Web.UI.Page
    {
        public List<Students> StudentsList = new List<Students>();
        protected void Page_Load(object sender, EventArgs e)
        {
            StudentsDalServer studentsDalServer = new StudentsDalServer();
            StudentsList=studentsDalServer.GetTable();
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {

        }
    }
}