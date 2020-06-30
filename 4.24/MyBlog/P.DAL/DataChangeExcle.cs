//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Microsoft.Office.Core;
//using Microsoft.Office.Interop.Excel;
//using Excel = Microsoft.Office.Interop.Excel;

//namespace P.DAL
//{
//    public class DataChangeExcle
//    {
//        /// <summary>  
//        /// 数据库转为excel表格  
//        /// </summary>  
//        /// <param name="dataTable">数据库数据</param>  
//        /// <param name="SaveFile">导出的excel文件</param>  
//        public static void DataSetToExcel(System.Data.DataTable dataTable, string SaveFile)
//        {
//            Excel.Application excel;

//            Excel._Workbook workBook;

//            Excel._Worksheet workSheet;

//            object misValue = System.Reflection.Missing.Value;

//            // excel = new Excel.ApplicationClass();
//            excel = new Excel.Application();

//            workBook = excel.Workbooks.Add(misValue);

//            workSheet = (Excel._Worksheet)workBook.ActiveSheet;

//            int rowIndex = 1;

//            int colIndex = 0;

//            //取得标题  
//            foreach (DataColumn col in dataTable.Columns)
//            {
//                colIndex++;

//                excel.Cells[1, colIndex] = col.ColumnName;
//            }

//            //取得表格中的数据  
//            foreach (DataRow row in dataTable.Rows)
//            {
//                rowIndex++;

//                colIndex = 0;

//                foreach (DataColumn col in dataTable.Columns)
//                {
//                    colIndex++;

//                    excel.Cells[rowIndex, colIndex] =

//                         row[col.ColumnName].ToString().Trim();

//                    //设置表格内容居中对齐  
//                    workSheet.get_Range(excel.Cells[rowIndex, colIndex],

//                      excel.Cells[rowIndex, colIndex]).HorizontalAlignment =

//                      Excel.XlVAlign.xlVAlignCenter;
//                }
//            }

//            excel.Visible = false;

//            workBook.SaveAs(SaveFile, Excel.XlFileFormat.xlWorkbookNormal, misValue,

//                misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive,

//                misValue, misValue, misValue, misValue, misValue);

//            dataTable = null;

//            workBook.Close(true, misValue, misValue);

//            excel.Quit();

//            PublicMethod.Kill(excel);//调用kill当前excel进程  

//            releaseObject(workSheet);

//            releaseObject(workBook);

//            releaseObject(excel);

//        }

//        private static void releaseObject(object obj)
//        {
//            try
//            {
//                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
//                obj = null;
//            }
//            catch
//            {
//                obj = null;
//            }
//            finally
//            {
//                GC.Collect();
//            }
//        }

//         public static void SuperToExcel(System.Data.DataTable excelTable, string filePath)
//        {
//            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.ApplicationClass();
//            try
//            {
//                app.Visible = false;
//                Workbook wBook = app.Workbooks.Add(true);              //Workbook对象。Workbook对象直接地处于Application对象的下层，表示一个Excel工作薄文件。
//                Worksheet wSheet = wBook.Worksheets[1] as Worksheet;   // Worksheet对象。Worksheet对象包含于Workbook对象，表示一个Excel工作表。
//                Microsoft.Office.Interop.Excel.Range range;           //范围
//                app.ScreenUpdating = false;  //屏幕不跟新，加快速度             
//                int colCount = excelTable.Columns.Count;//列总数
//                int rowCount = excelTable.Rows.Count;//行总数
//                //创建缓存数据
//                object[,] objData = new object[rowCount + 1, colCount];
//                //写标题，第一行各列
//                int size = excelTable.Columns.Count;
//                for (int i = 0; i < size; i++)
//                {
//                    wSheet.Cells[1, 1 + i] = excelTable.Columns[i].ToString();
//                }
//                range = (Range)wSheet.get_Range(app.Cells[1, 1], app.Cells[1, colCount]);//设置工作表第一行的范围
//                range.Interior.ColorIndex = 15;//背景色 灰色
//                range.Font.Bold = true;//粗字体
//                //获取实际数据
//                for (int rowIndex = 0; rowIndex < rowCount; rowIndex++)
//                {
//                    for (int colIndex = 0; colIndex < colCount; colIndex++)
//                    {
//                        objData[rowIndex, colIndex] = excelTable.Rows[rowIndex][colIndex].ToString();
//                    }
//                }
//                //写入Excel 
//                range = (Range)wSheet.get_Range(app.Cells[2, 1], app.Cells[rowCount + 1, colCount]);
//                // range.NumberFormatLocal = "@";//设置数字文本格式
//                range.Value2 = objData;
//                //Application.DoEvents();

//               // wSheet.Columns.AutoFit();//列的宽度自适应

//               //设置禁止弹出保存和覆盖的询问提示框 
//                app.DisplayAlerts = false;
//                app.AlertBeforeOverwriting = false;

//                wBook.Saved = true;
//                wBook.SaveCopyAs(filePath);

//                app.Quit();
//                app = null;
//                GC.Collect();
//            }
//            catch (Exception err)
//            {
//                //MessageBox.Show("导出Excel出错！错误原因：" + err.Message, "提示信息");
//                string errorStr = "导出Excel出错！错误原因：" + err.Message;
//            }


//        }
//        #region 单个单元格写入
//        Char[] tempArray1 = new Char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'h', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'a', 'b', 'c', 'd' };
//        int[] tempArray2 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
//        string fullPath2;
//        private void Button_Click_1(object sender, RoutedEventArgs e)
//        {
//            fullPath2 = "";
//            System.Windows.Forms.SaveFileDialog dialog = new System.Windows.Forms.SaveFileDialog();
//            dialog.Filter = "Excel文件(*.xls)|*.xls";//设置对话框保存的文件类型
//            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)//将ok返回默认用户公共对话框
//            {
//                fullPath2 = dialog.FileName;//获取文件路径和文件名
//            }
//            if (fullPath2 != "")
//            {
//                FileInfo fi = new FileInfo(fullPath2);//创建名xls文件
//                fi.Directory.Create();

//                SaveWaveToFile();
//            }
//        }
//        object[] tempArray3 = new object[30];
//        System.Data.DataTable DT = new System.Data.DataTable("Datas");
//        private void SaveWaveToFile()
//        {
//            foreach (Char tempChar in tempArray1)
//            {
//                DT.Columns.Add(tempChar.ToString(), Type.GetType("System.String"));
//            }
//            DT.Columns[0].AutoIncrement = true;//是否将列的值自动递增
//            // DT.Columns[0].AutoIncrementSeed = 1;//AutoIncrement属性为true的列的起始值
//            DT.Columns[0].AutoIncrementStep = 1;//AutoIncrement属性为true的列使用的增量
//            for (int j = 0; j < 6; j++)
//            {
//                tempArray3[0] = 23;
//                for (int i = 1; i < 30; i++)
//                {
//                    tempArray3[i] = tempArray2[i - 1];
//                }
//                DT.Rows.Add(tempArray3);//将指定的值添加到行中/每行加完之后自动往后加
//            }
//            SuperToExcel(DT, fullPath2);
//            this.Close();
//        }
//        #endregion


//    }
//}
