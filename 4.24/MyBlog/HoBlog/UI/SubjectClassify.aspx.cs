using P.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI
{
    public partial class SubjectClassify : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadData();
            }
        }

        private void LoadData()
        {
            string sql = "select * from SubjectClassify ";
            // Response.Write(sql);
            GridView1.DataSource = SqlHelper.GetTable(sql, System.Data.CommandType.Text);
            GridView1.DataKeyNames = new string[] { "id" };
            GridView1.DataBind();
        }

        protected void GridView1_DataBound(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sql = "select * from SubjectClassify where name='" + TextBox1.Text.Trim()+"'";
            if(SqlHelper.GetTable(sql, System.Data.CommandType.Text).Rows.Count > 0)
            {
                Response.Write("<script>alert('已有此报考分类');</script>");
                return;
            }
               sql = "insert into SubjectClassify (name) values('" + TextBox1.Text.Trim()+"')";
            SqlHelper.GetExecuteNonQuery(sql, System.Data.CommandType.Text);
            LoadData();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowDeleted(object sender, GridViewDeletedEventArgs e)
        {
            
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            var d = GridView1.DataKeys[e.RowIndex];
            string sql = "delete SubjectClassify where id=" + d[0];
            SqlHelper.GetExecuteNonQuery(sql, System.Data.CommandType.Text);
            LoadData();
        }
    }
}