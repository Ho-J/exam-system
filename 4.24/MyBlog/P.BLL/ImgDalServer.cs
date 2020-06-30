using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P.Model;
using P.DAL;

namespace P.BLL
{
    public class ImgDalServer
    {
       static ImgtypeDal imgtypedal = new ImgtypeDal();
      public  int AddImg(Imgtype imgtype)
        {
            return imgtypedal.AddImg(imgtype);
        }
    }
}
