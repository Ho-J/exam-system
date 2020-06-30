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
    public partial class SubJectManage : System.Web.UI.Page
    {
        public List<ExamSubject> ExamSubjectsList { get; set; }
       static  ExamSubjectDalServer examSubjectDalServer = new ExamSubjectDalServer();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            
            ExamSubjectsList = new List<ExamSubject>();
            ExamSubjectsList =examSubjectDalServer.GetTable();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void getCheckMajor(ExamSubject e)
        {
          List<Major> list=  examSubjectDalServer.getCheckMajor(e);
            string str="";
           // 
            if (list == null)
            {

            }
            else
            {
                foreach (var l in list)
                {

                    str = l.name + "</br>" + str;
                }
            }
            if (str.Equals(""))
            {
                str = "无专业限制";
            }
            Response.Write(str);
        }

        public void getCheckGrade(ExamSubject e)
        {
            List<CheckGrade> list = examSubjectDalServer.getCheckGrade(e);
            string str = "";
            // 
            if (list == null)
            {

            }
            else
            {
                foreach (var l in list)
                {

                    str = l.grade + "</br>" + str;
                }
            }
            if (str.Equals(""))
            {
                str = "无年级限制";
            }
            Response.Write(str);
        }
      
    }
}