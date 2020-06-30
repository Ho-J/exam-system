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
    public partial class AddSubject : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                ExamSubject examSubject = new ExamSubject();
                examSubject.name = Request.Form["mz"].Trim();
                examSubject.ApplyStar = Convert.ToDateTime(Request.Form["as"]);
                examSubject.ApplyEnd = Convert.ToDateTime(Request.Form["ae"]);
                examSubject.ExamEnd = Convert.ToDateTime(Request.Form["ee"]);
                examSubject.ExamStar = Convert.ToDateTime(Request.Form["es"]);
                examSubject.examPlace= TextBox3.Text;
                examSubject.detail = TextBox1.Text;
                examSubject.classifyName = DropDownList1.SelectedValue;
                Major major = null;

                List<Major> mlist = new List<Major>();
                
                for(int i = 0; i < CheckBoxList2.Items.Count; i++)
                {
                    if (CheckBoxList2.Items[i].Selected)
                    {
                        major = new Major();
                        major.name = CheckBoxList2.Items[i].Text;

                        mlist.Add(major);
                    }
                }

                List<CheckGrade> clist = new List<CheckGrade>();
                CheckGrade cg = null;
                for (int i = 0; i < CheckBoxList1.Items.Count; i++)
                {
                    if (CheckBoxList1.Items[i].Selected)
                    {
                        cg = new CheckGrade();

                        cg.grade = CheckBoxList1.Items[i].Text;

                        clist.Add(cg);
                    }
                }
                 



                ExamSubjectDalServer examSubjectDalServer = new ExamSubjectDalServer();
                if (Request.Form["r1"] == "无限制")
                {
                    clist.Clear();
                }
                if (Request.Form["r2"] == "无限制")
                {
                    mlist.Clear();
                }
                //string 
                // DropDownList1.SelectedValue
                //classifyName


                examSubjectDalServer.AddSubject(examSubject);
                examSubjectDalServer.AddMajors(mlist, clist, examSubject);

                Response.Redirect("SubjectManage.aspx");
            }

        }


        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}