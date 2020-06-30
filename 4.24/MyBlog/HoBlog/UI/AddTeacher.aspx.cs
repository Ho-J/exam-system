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
    public partial class AddTeacher : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
      //  static string strUal;
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
                    // file.SaveAs(context.Request.MapPath(fullDir));
                    //file.SaveAs(context.Request.MapPath("/img/" + fileName));
                    //using (Image imge = Image.FromStream(file.InputStream))//根据上传的文件流创建 Image

                    //Stream objFile = file.InputStream;
                    //BinaryReader objReader = new BinaryReader(objFile);
                    ////读取文件内容
                    //byteFile = objReader.ReadBytes((int)objFile.Length);
                    ////文件扩展名
                    //string strExtent = file.FileName.Substring(file.FileName.LastIndexOf("."));
                    //  fileExt

                    // Response.Write(byteFile);
                    Image2.ImageUrl = fullDir;
                    //students.imgUal = fullDir;
                
                }

            }
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Teachers teachers = new Teachers();
            teachers.account = TextBox1.Text;
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
    }
}