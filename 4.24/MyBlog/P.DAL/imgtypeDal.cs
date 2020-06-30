using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P.Model;
using System.Data;
using System.Data.SqlClient;

namespace P.DAL
{
    public class ImgtypeDal
    {
        public List<Imgtype> GetImgtypeList()
        {
            string str = "select * from imgSave";
            DataTable da = SqlHelper.GetTable(str, CommandType.Text);
            List<Imgtype> list = null;
            if (da.Rows.Count > 0)
            {
                list = new List<Imgtype>();
                Imgtype imgtype = null;
                foreach (DataRow datarow in da.Rows)
                {
                    imgtype = new Imgtype();
                    LoadImgtype(datarow, imgtype);
                    list.Add(imgtype);
                }
            }
            return list;
        }
        public int AddImg(Imgtype imgtype)
        {
            string str = "insert into imgSave(id,name,time,img) values(@id,@name,@time,@img)";

            //sql 语句中的替换
            SqlParameter[] pars ={
                                //new SqlParameter("@name", userInfo.UserName),
                                  new SqlParameter("@id",SqlDbType.VarChar,500),
                                  new SqlParameter("@name",SqlDbType.VarChar,100),
                                  new SqlParameter("@time",SqlDbType.DateTime),
                                  new SqlParameter("@img",SqlDbType.VarBinary),
                                };
            pars[0].Value = imgtype.idImg;
            pars[1].Value = imgtype.nameImg;
            pars[2].Value = imgtype.timeImg;
            pars[3].Value = imgtype.imgImg;

            return SqlHelper.GetExecuteNonQuery(str, CommandType.Text, pars);

        }


        public static void LoadImgtype(DataRow datarow, Imgtype imgtype)
        {
            imgtype.idImg = datarow["id"].ToString();
            //imgtype.UserName = datarow["用户名"].ToString();
            imgtype.nameImg = datarow["name"] != null ? datarow["name"].ToString() : string.Empty;
            imgtype.imgImg = datarow["img"] != null ? Convert.FromBase64String(datarow["img"].ToString()): Convert.FromBase64String(string.Empty);
            //转换未字符类型后再转换为 []byte 类型   tc

            imgtype.timeImg = Convert.ToDateTime(datarow["时间"]);
        }
    }
}
