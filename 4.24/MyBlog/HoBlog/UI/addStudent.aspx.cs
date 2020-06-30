using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using P.Model;
using P.BLL;
using System.IO;

namespace UI
{
    public partial class addStudent : System.Web.UI.Page
    {
        static int num = 1;
        protected void Page_Load(object sender, EventArgs e)
        {
          //  Response.Write(Request.Form["kuang"]+"====="+ num);
            num++;
           //第一次页面
            if (!IsPostBack)
            {




            }
            else
            {

            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpPostedFile file = fileUp.PostedFile;
            if (file==null)
            {
                Response.Write("请上传文件");
            }
            else
            {
                //Response.Write("上传成功");
                string fileName = Path.GetFileName(file.FileName);///获取文件完全限定的名字 
                string fileExt = Path.GetExtension(fileName);
                fileExt = fileExt.ToLower();

                if (fileExt == ".gif" || fileExt == ".png" || fileExt == ".jpg")
                {
                    string dir = "/Img/" + DateTime.Now.Year + "/" +DateTime.Now.Month + "/" + DateTime.Now.Day + "/";
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

        
        protected void Button2_Click(object sender, EventArgs e)
        {
            //这里是我保存文件转为二进制流存入数据库的方法

            if (this.fileUp.PostedFile.FileName != "")
            {
                //得到提交的文件 
                Stream fileDataStream = this.fileUp.PostedFile.InputStream;

                //得到文件大小 
                int fileLength = this.fileUp.PostedFile.ContentLength;

                //创建数组 
                byte[] fileData = new byte[fileLength];

                //把文件流填充到数组 
                fileDataStream.Read(fileData, 0, fileLength);

                //获取上传文件的完整路径以及文件名
                string FullName = this.fileUp.PostedFile.FileName.ToString();

                //得到文件名字 
                string fileTitle = FullName.Substring(FullName.LastIndexOf("\\") + 1);

                //得到文件类型 
                string fileType = FullName.Substring(FullName.LastIndexOf(".") + 1);
              
            }
        }
       
        protected void Button3_Click(object sender, EventArgs e)
        {
            // check()
            Students students = new Students();
            var AderssUser = Request.UserHostAddress;
            StudentsDalServer studentsDalServer = new StudentsDalServer();

            students.id = TextBox1.Text;
            //students.id = "asdsadadssadfsg";
            //Response.Write(Request.Form["name"]+ students.id);
            students.name = TextBox3.Text;
            students.pwd = TextBox2.Text;
            students.grade = Request.Form["grade"];
            students.major = DropDownList1.Text;
            students.imgUal = Image2.ImageUrl;
            students.state = 1;//学生状态默认为1
            students.tel = tel.Text;
            students.emil = emil.Text;
            students.academy = academy.Text;
            students.state = 3;
            // Response.Write(students.ToString());
            Students st = new Students();
            st = studentsDalServer.SelectId(students);
            if (st.id == null)
            {
                students.img = new byte[1];
                studentsDalServer.Add(students);

                Response.Redirect("addSuccess.html");
            }
            else
            {
                Response.Write("<script>alert('此账号已被注册！')</script>");
            }
        }
    }
}