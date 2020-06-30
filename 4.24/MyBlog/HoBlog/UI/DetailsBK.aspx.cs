using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using P.Model;
using P.BLL;

using System.Data;
using System.IO;

using System.Text;

namespace UI
{
    public partial class DetailsBK : System.Web.UI.Page
    {
        public string EstateName;//EstateName显示名字
        public List<DetailsSubject> ListDetailsSubject { get; set; }
        ExamSubjectDalServer examSubjectDalServer = new ExamSubjectDalServer();
        BaoKao baoKao = new BaoKao();
        protected void Page_Load(object sender, EventArgs e)
        {
            //ListDetailsSubject = new List<DetailsSubject>();
            
            baoKao.Eid = Convert.ToInt32(Request.QueryString["eid"]);
            

            ListDetailsSubject = examSubjectDalServer.DetailsSubject(baoKao);

          
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
          DataTable dt=   examSubjectDalServer.DetailsSubjectDataTable(baoKao);
            CreateExcel(dt);
        }

        public void CreateExcel(DataTable db)
        {
            //Excel.Application excel = new Excel.Application();
            //Excel.Workbook wb = excel.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);    // 创建工作簿
            //Excel.Worksheet ws = (Excel.Worksheet)wb.Worksheets[1];                          // 创建工作页
            
            // int iMaxRow = db.Rows.Count;
            //int iMaxCol = db.Columns.Count;

            //// 设置格式
            ////ws.get_Range(ws.Cells[1, 1], ws.Cells[1, iMaxCol]).Font.Name = "黑体";
            ////ws.get_Range(ws.Cells[1, 1], ws.Cells[1, iMaxCol]).Font.Bold = true;
            ////ws.get_Range(ws.Cells[1, 1], ws.Cells[iMaxRow + 1, iMaxCol]).Borders.LineStyle = 1;
            //// 设置标题
            //excel.Cells[1, 1] = "姓名";
            //excel.Cells[1, 2] = "年级";
            //excel.Cells[1, 3] = "报名时间";
            //excel.Cells[1, 4] = "考试状态";
            //excel.Cells[1, 6] = "分数";
            ////for (int i = 1; i <= db.Columns.Count; i++)
            ////{
            ////    excel.Cells[1, i] = db.Columns[i].Caption.ToString()+"/"+ excel.Cells[1, i];
                
            ////}
            //// 填充数据
            //for (int iRow = 0; iRow < iMaxRow; iRow++)
            //{
            //    for (int iCol = 0; iCol < iMaxCol; iCol++)
            //    {
            //        excel.Cells[iRow + 2, iCol + 1] = db.Rows[iRow][iCol].ToString();
            //    }
            //}
            //string dir = "/ExcelData/" + DateTime.Now.Year + "/" + DateTime.Now.Month + "/" + DateTime.Now.Day + "/";
            ////创建文件夹保存文件
            //Directory.CreateDirectory(Path.GetDirectoryName(Request.MapPath(dir)));
            //// 保存Excel
            
            //excel.Save("11.xlsx");
            //// 打开Excel
            //excel.Visible = true;
        }
        public void creat2()
        {
            
            string dir = "/ExcelData/" + DateTime.Now.Year + "/" + DateTime.Now.Month + "/" + DateTime.Now.Day + "/";
            //创建文件夹保存文件
            Directory.CreateDirectory(Path.GetDirectoryName(Request.MapPath(dir)));
            FileStream file = new FileStream(dir+"test.x", FileMode.Create);
            StreamWriter sw = new StreamWriter(file, Encoding.Default);//设置编码为当面页面编码


        }
         

        
    }
}