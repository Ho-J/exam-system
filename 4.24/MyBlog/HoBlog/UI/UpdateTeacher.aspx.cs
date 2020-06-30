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
    public partial class UpdateTeacher : System.Web.UI.Page
    {
        ExamSubjectDalServer examSubjectDalServer = new ExamSubjectDalServer();
        TeacherDalServer teacherDalServer = new TeacherDalServer();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Teachers teachers = new Teachers();
                teachers.id = Request.QueryString["id"];
               // Response.Write(teachers.id);return;
                TeacherDalServer teacherDalServer = new TeacherDalServer();
                teachers= teacherDalServer.IdToTeacher(teachers);
                Label1.Text = teachers.account;
                Label2.Text = teachers.name;
                TextBox2.Text = teachers.pwd;
                
            }
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Teachers teachers = new Teachers();
            teachers.id = Request.QueryString["id"];
           
            teachers.account= Label1.Text ;
             teachers.name= Label2.Text ;
             teachers.pwd= TextBox2.Text ;
            List<Subject_Teacher> list = new List<Subject_Teacher>();


            Subject_Teacher subject_Teacher;
            for (int i = 0; i < CheckBoxList1.Items.Count; i++)
            {
                if (CheckBoxList1.Items[i].Selected)
                {
                    subject_Teacher = new Subject_Teacher();
                    subject_Teacher.subjectName = CheckBoxList1.Items[i].Value;
                    subject_Teacher.TeacherId = teachers.id;
                    list.Add(subject_Teacher);
                }
            }
            // Response.Write(teachers.id);
            if (list.Count > 0)
            {
                
            }
            else
            {
                subject_Teacher = new Subject_Teacher();
                subject_Teacher.TeacherId = teachers.id;
                list.Add(subject_Teacher);
            }

            teacherDalServer.AddSubject_Teacher(list);
            teacherDalServer.UpdateTeacherForDB(teachers);

            Server.Transfer("TeacherManage.aspx");

        }

        protected void CheckBoxList1_Load(object sender, EventArgs e)
        {
            
        }

        protected void CheckBoxList1_DataBound(object sender, EventArgs e)
        {
            Teachers teachers = new Teachers();
            teachers.id = Request.QueryString["id"];
            List<ExamSubject> subjects = examSubjectDalServer.IdToSubject(teachers);
   
            for (int i = 0; i < CheckBoxList1.Items.Count; i++)
            {
                foreach (ExamSubject sub in subjects)
                {
                   // Response.Write(sub.name + " ====" + CheckBoxList1.Items[i].Text);
                    if (CheckBoxList1.Items[i].Text == sub.name)
                    {

                        CheckBoxList1.Items[i].Selected = true;
                    }
                }
            }
        }
    }
}