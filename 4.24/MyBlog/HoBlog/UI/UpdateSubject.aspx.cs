using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using P.Model;
using P.BLL;
using System.Data.SqlClient;
using System.Data;
using P.DAL;

namespace UI
{
    public partial class UpdateSubject : System.Web.UI.Page
    {
        public ExamSubject Sub= new ExamSubject();
        ExamSubjectDalServer examSubjectDalServer = new ExamSubjectDalServer();
        ExamSubject examSubject = new ExamSubject();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
              //  Response.Write(" 1   IsPostBack:" + IsPostBack + "</br>");


                examSubject.id = Convert.ToInt32(Request.QueryString["id"]);

                Sub = examSubjectDalServer.GetSubject(examSubject);
               // Response.Write("</br>+Sub.detail" + Sub.detail + "==" + Sub.examPlace);
                TextBox3.Text = Sub.examPlace;
                TextBox1.Text = Sub.detail;
                //CheckBoxList1.Items[0].Selected = true;
                //取得grade约束
                List<CheckGrade> clist = examSubjectDalServer.examSubjectNoToGetCheckGrade(examSubject);
                Boolean f1 = false;
                for (int i = 0; i < CheckBoxList1.Items.Count; i++)
                {
                    foreach (var cl in clist)
                    {
                        if (CheckBoxList1.Items[i].Text == cl.grade)
                        {
                            CheckBoxList1.Items[i].Selected = true;
                            f1 = true;
                        }
                    }
                }
                //分类 下拉框待选中



                if (f1)
                {
                    RadioButton2.Checked = true;
                }
                else
                {
                    RadioButton1.Checked = true;
                    // CheckBoxList1.Visible = false;
                    Response.Write("<script>visableF();</script>");
                }
                
            }
            else
            {
               // Response.Write("2     IsPostBack-true:" + IsPostBack + "</br>");
                examSubject.id = Convert.ToInt32(Request.QueryString["id"]);
                examSubject.name = Request.Form["name"];
                examSubject.ApplyStar = Convert.ToDateTime(Request.Form["ApplyStar"]);
                examSubject.ApplyEnd = Convert.ToDateTime(Request.Form["ApplyEnd"]);
                examSubject.ExamStar = Convert.ToDateTime(Request.Form["ExamStar"]);
                examSubject.ExamEnd = Convert.ToDateTime(Request.Form["ExamEnd"]);
                examSubject.examPlace = TextBox3.Text;
                examSubject.detail = TextBox1.Text;
                examSubject.classifyName = DropDownList1.SelectedValue;
                Major major = null;

                List<Major> cm = new List<Major>();

                for (int i = 0; i < CheckBoxList2.Items.Count; i++)
                {
                    if (CheckBoxList2.Items[i].Selected)
                    {
                        major = new Major();
                        major.name = CheckBoxList2.Items[i].Text;

                        cm.Add(major);
                    }
                }

                List<CheckGrade> cl = new List<CheckGrade>();
                CheckGrade cg = null;
                for (int i = 0; i < CheckBoxList1.Items.Count; i++)
                {
                    if (CheckBoxList1.Items[i].Selected)
                    {
                        cg = new CheckGrade();

                        cg.grade = CheckBoxList1.Items[i].Text;

                        cl.Add(cg);
                    }
                }

                examSubjectDalServer.updateCheck(cm, cl, examSubject, RadioButton1.Checked, RadioButton3.Checked);

                if (examSubjectDalServer.UpdateExamSubject(examSubject) > 0)
                {
                    Response.Redirect("SubjectManage.aspx");
                }
                else
                {
                    Response.Write("修改失败");
                }
            }


           


        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < CheckBoxList1.Items.Count; i++)
            {
               
                CheckBoxList1.Items[i].Selected = false;
            }
           // Response.Write("asd");
        }
        protected void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < CheckBoxList2.Items.Count; i++)
            {
                CheckBoxList2.Items[i].Selected = false;
            }

        }

        protected void CheckBoxList2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        protected void CheckBoxList2_DataBound(object sender, EventArgs e)
        {
            //  ExamSubjectDalServer examSubjectDalServer = new ExamSubjectDalServer();
            List<Major> mlist = examSubjectDalServer.examSubjectNoToGetCheckMajor(examSubject);

            Boolean f2 = false;
            for (int i = 0; i < CheckBoxList2.Items.Count; i++)
            {
                foreach (var cl in mlist)
                {
                    if (CheckBoxList2.Items[i].Text == cl.name)
                    {
                        CheckBoxList2.Items[i].Selected = true;
                        f2 = true;
                    }
                }
            }

            if (f2)
            {
                RadioButton4.Checked = true;
                
            }
            else
            {
                RadioButton3.Checked = true;
                Response.Write("<script>visableF();</script>");
            }
            
        }

        protected void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}