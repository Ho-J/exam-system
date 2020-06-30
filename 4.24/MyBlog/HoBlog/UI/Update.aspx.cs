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
    public partial class WebForm1 : System.Web.UI.Page
    {
         


    public Boolean Flag = false;
       
        StudentsDalServer studentsDalServer = new StudentsDalServer();
       
        //int i = 0,j=0;
        
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {

            }
            else
            {
                
                Students outStudent = (Students)Session["account"];
                outStudent = studentsDalServer.SelectId(outStudent);
             //   if (f1)
                {
                    Label1.Text = outStudent.id;
                    TextBox3.Text = outStudent.name;
                    TextBox2.Text = outStudent.pwd;
                   // TextBox1.Text = outStudent.pwd;
                    tel.Text = outStudent.tel;
                    emil.Text = outStudent.emil;
                    academy.Text = outStudent.academy;
                    for (int i = 0; i < DropDownList1.Items.Count; i++)
                    {
                        if (DropDownList1.Items[i].Value == outStudent.grade)
                        {
                            DropDownList1.Items[i].Selected = true;
                        }
                    }
                  //  DropDownList1.Items[3].Selected = true;
                    Image2.ImageUrl = outStudent.imgUal;
                    urlStr= outStudent.imgUal;
                   // Response.Write("in" + i++);
                }
//
               // Response.Write("out" + j++);
            }

               
            
        }
       static  string urlStr;
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
                    students.imgUal = fullDir;
                    urlStr = fullDir;
                   // Response.Write( "----ual:" + students.imgUal+"</br>---------id:"+students.id);
                }

            }
        }
        Students students = new Students();
        protected void Button2_Click(object sender, EventArgs e)
        {
            string strUal = students.imgUal;
          //  Response.Write("----ual:" + students.imgUal + "</br>---------id:" + students.id);
            Students st = (Students)Session["account"];
            students = studentsDalServer.SelectId(st);
            students.id = Label1.Text;
            students.name = TextBox3.Text;
            students.tel = tel.Text;
            students.emil = emil.Text;
            students.academy = academy.Text;
            students.grade = DropDownList1.SelectedValue;
            students.pwd = TextBox2.Text;
            students.imgUal = urlStr;
         //    Response.Write(students.name+"--"+students.pwd+"----ual"+students.imgUal);

            if (studentsDalServer.Update(students) > 0)
            {
               
                Response.Redirect("detailStudent.aspx");
            }
            else
            {
                Response.Write("<script>alert('修改失败');</script>");
            }
        }

        //修改个人资料
        protected void LinkButton5_Click1(object sender, EventArgs e)
        {
            Students stu = (Students)Session["account"];
            Server.Transfer("Update.aspx?id=" + stu.id + "&s=1");
        }

        protected void GridView1_Load(object sender, EventArgs e)
        {
            //string sql="select *"
        }
        //已报考科目
        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Server.Transfer("detailStudent.aspx");
        }
        //添加报考
        protected void LinkButton4_Click(object sender, EventArgs e)
        {

            Server.Transfer("baokao.aspx");
        }
        //查询成绩
        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Response.Write("<script>alert('正在开发ing ');</script>");
        }
    }
}