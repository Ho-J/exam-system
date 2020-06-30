using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using P.Model;
using P.BLL;

namespace UI
{
    public partial class index : System.Web.UI.Page
    {
        public static Teachers teachers;
        protected void Page_Load(object sender, EventArgs e)
        {
            

            if (IsPostBack)//html 提交处理
            {
               
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Request.Form["id"] == "" || Request.Form["pwd"] == "")
            {
                return;
            }

            if (Request.Form["fx"] == "1")//学生登录
            {

                StudentsDalServer studentsDalServer = new StudentsDalServer();
                Students students = new Students();
                students.id = Request.Form["id"];
                students.pwd = Request.Form["pwd"];
                if (studentsDalServer.login(students))//是否允许登录
                {
                    //   students.GetType()
                    Session["account"] = students;
                    Session["type"] = "student";

                    // string str= "detailStudent.aspx?id="+students.id;//传去学生学号
                    // Server.Transfer(str);
                    Server.Transfer("detailStudent.aspx");

                }
                else
                {
                    Response.Write("<script>alert('用户名或密码错误！')</script>");
                }
            }
            else if (Request.Form["fx"] == "2")//管理员登录
            {
                BASE_USERDalServer bASE_USERDalServer = new BASE_USERDalServer();
                BASE_USER bASE_USER = new BASE_USER();
                bASE_USER.pwd = Request.Form["pwd"];
                bASE_USER.name = Request.Form["id"];
                if (bASE_USERDalServer.login(bASE_USER))
                {
                    Session["account"] = bASE_USER;
                    Session["type"] = "baseUser";

                    string str = "BaseUser.aspx";
                    Server.Transfer(str);
                }
                else
                {
                    Response.Write("<script>alert('用户名或密码错误！')</script>");
                }



            }
            else
            {
                BASE_USERDalServer bASE_USERDalServer = new BASE_USERDalServer();
                teachers = new Teachers();
                teachers.pwd = Request.Form["pwd"];
                teachers.account = Request.Form["id"];
                teachers = bASE_USERDalServer.loginTeacher(teachers);
                if (teachers.id == null)
                {
                    Response.Write("<script>alert('用户名或密码错误！')</script>");
                }
                else
                {
                    Session["account"] = teachers;
                    Session["type"] = "teacher";
                    string str = "Teacher.aspx";
                    //Response.Redirect(str);
                    Server.Transfer(str);
                }
            }
        }
    }
}