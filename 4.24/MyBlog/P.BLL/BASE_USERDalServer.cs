using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P.Model;
using System.Data;
using System.Data.SqlClient;

namespace P.BLL
{
    
    public class BASE_USERDalServer
    {
        BASE_USERDal bASE_USERDal = new BASE_USERDal();


        public int AddExamInform(ExamInform examInform)
        {
            return bASE_USERDal.AddExamInform(examInform);
        }
        public Boolean login(BASE_USER bASE_USER)
        {
            return bASE_USERDal.login(bASE_USER);
        }
        public BASE_USER selectBase(BASE_USER bASE_USER)
        {
            return bASE_USERDal.selectBase(bASE_USER);
        }
        public Boolean UPpwd(BASE_USER bASE_USER)
        {
            return bASE_USERDal.UPpwd(bASE_USER);
        }
        public Teachers loginTeacher(Teachers teachers)
        {
            return bASE_USERDal.loginTeacher(teachers);
        }
    }
}
