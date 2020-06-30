using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using P.Model;
using P.BLL;
using P.DAL;
using System.Data;

namespace UI
{
    public partial class baokao : System.Web.UI.Page
    {
        public List<ExamSubject> ExamSubjectsList { get; set; }
        public List<String> classifyName { get; set; }
        public string Iid { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["account"] == null)
                {
                    // Response.Write("<script>alert('未登录！');</script>");
                    Response.Redirect("index.aspx");
                    return;
                }
                string sql = "select * from SubjectClassify";
               DataTable dataTable= SqlHelper.GetTable(sql, System.Data.CommandType.Text);

                classifyName = new List<string>();
                for(int i = 0; i < dataTable.Rows.Count; i++)
                {
                    classifyName.Add(dataTable.Rows[i][1].ToString());
                }
                string classify = Request.QueryString["classify"];
                
                if (classify == null)
                {
                    //  Response.Write("<script>alert('');</script>");
                    LoadData();
                }
                else
                {

                    LoadData(classify);
                }
                
           

            }

        }
        private void LoadData()
        {
            Students st = (Students)Session["account"];
            //string sid =Request.QueryString["id"];
            string sid = st.id;
            // sid = "1";
            //string sql = "  select * from ExamSubject where id not in( select eid from Baokao where sid='" + sid + "') and ApplyStar<'" + DateTime.Now + "' and ApplyEnd>'" + DateTime.Now + "'" ;
            string sql = "select * from ExamSubject e,Students s where e.id not in( select eid from Baokao where sid='12') " +
                         "and ApplyStar<'" + DateTime.Now + "' and ApplyEnd>'" + DateTime.Now + "'" +
                         "and e.id not in (select examSubjectNo from Check_grade where checkGrade=s.grade) " +
                         "and s.id='" + sid + "' " +
                         "and e.id not in (select examSubjectNo from Check_major,major where  Checkmajor=专业编号 and s.major=专业名)";
            // Response.Write(sql);
            GridView1.DataSource = SqlHelper.GetTable(sql, System.Data.CommandType.Text);
            GridView1.DataKeyNames = new string[] { "id" };
            GridView1.DataBind();
        }
        private void  LoadData(string classify)
        {
            Students st = (Students)Session["account"];
            //string sid =Request.QueryString["id"];
            string sid = st.id;
            // sid = "1";
           // string sql= "  select * from ExamSubject where id not in( select eid from Baokao where sid='"+sid+ "') and ApplyStar<'"+DateTime.Now+ "' and ApplyEnd>'"+DateTime.Now+ "' and classifyName='"+ classify+"' ";
            string sql = "select * from ExamSubject e,Students s where e.id not in( select eid from Baokao where sid='12') " +
                        "and ApplyStar<'" + DateTime.Now + "' and ApplyEnd>'" + DateTime.Now + "' and classifyName='" + classify + "'" +
                        "and e.id not in (select examSubjectNo from Check_grade where checkGrade=s.grade) " +
                        "and s.id='" + sid + "' " +
                        "and e.id not in (select examSubjectNo from Check_major,major where  Checkmajor=专业编号 and s.major=专业名)";
          //  Response.Write(sql);

            GridView1.DataSource = SqlHelper.GetTable(sql, System.Data.CommandType.Text);
            GridView1.DataKeyNames = new string[] { "id" };
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //string sid = Request.QueryString["id"];
            Students st = (Students)Session["account"];
            //string sid =Request.QueryString["id"];
            string sid = st.id;
            // sid = "1";
            string sql = "  select * from ExamSubject where id not in( select eid from Baokao where sid='" + sid + "') and ApplyStar<'" + DateTime.Now + "' and ApplyEnd>'" + DateTime.Now + "' and name like '%"+TextBox1.Text+"%'";
            // Response.Write(sql);
            GridView1.DataSource = SqlHelper.GetTable(sql, System.Data.CommandType.Text);
            GridView1.DataKeyNames = new string[] { "id" };
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }
    }
}