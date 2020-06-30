using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using P.Model;
using P.BLL;

namespace UI
{
    public partial class UpdateTeacher2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Teachers teachers = (Teachers)Session["account"];
                Label1.Text= teachers.account ;
                 TextBox2.Text= teachers.pwd ;
                 TextBox7.Text= teachers.name ;
                 TextBox3.Text= teachers.position ;
                 TextBox4.Text= teachers.tel ;
                 TextBox5.Text= teachers.emil ;
                 TextBox6.Text= teachers.academy ;
                 Image2.ImageUrl= teachers.imgUrl ;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpPostedFile file = fileUp.PostedFile;
            if (file == null)
            {
                Response.Write("请上传文件");
            }
            else
            {
                //Response.Write("上传成功");
                string fileName = Path.GetFileName(file.FileName);///获取文件完全限定的名字 
                string fileExt = Path.GetExtension(fileName);
                fileExt = fileExt.ToLower();
                //if (this.fileUp.PostedFile.ContentLength > 5100000)
                //{
                //    ClientScript.RegisterStartupScript(GetType(), null, "alert('文件大小不能超过1M')", true);
                //}
                if (fileExt == ".gif" || fileExt == ".png" || fileExt == ".jpg")
                {
                    string dir = "/Img/" + DateTime.Now.Year + "/" + DateTime.Now.Month + "/" + DateTime.Now.Day + "/";
                    //创建文件夹保存文件
                    Directory.CreateDirectory(Path.GetDirectoryName(Request.MapPath(dir)));
                    //需要对上传的文件进行重命名.
                    string newfileName = Guid.NewGuid().ToString();  //创建唯一名字
                    string fullDir = dir + newfileName + fileExt;//构建了完整文件路径.
                    file.SaveAs(Request.MapPath(fullDir));
                   
                    Image2.ImageUrl = fullDir;
                    //students.imgUal = fullDir;

                }

            }
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Teachers teachers = new Teachers();
            teachers.account = Label1.Text;
            teachers.pwd = TextBox2.Text;
            teachers.name = TextBox7.Text;
            teachers.position = TextBox3.Text;
            teachers.tel = TextBox4.Text;
            teachers.emil = TextBox5.Text;
            teachers.academy = TextBox6.Text;
            teachers.imgUrl = Image2.ImageUrl;
            TeacherDalServer teacherDalServer = new TeacherDalServer();



            if (teacherDalServer.IsExist(teachers))
            {
                Response.Write("<script>alert('此账号已被注册！')</script>");
                // Alert.AlertAndRedirect("对不起您没有登录不能报名", "Default.aspx");

            }
            else
            {
                Response.Write("<script>alert('注册成功！')</script>");
                teacherDalServer.AddTeacher(teachers);
                Response.Redirect("index.aspx");

            }
        }
        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateTeacher2.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Teacher.aspx");
        }
    }
}