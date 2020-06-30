using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P.Model;
using P.DAL;


namespace P.BLL
{
    
   public class TeacherDalServer
    {
        TeacherDal teacherDal = new TeacherDal();
        public int UpdateTeacherForDB(Teachers teachers)
        {
            return teacherDal.UpdateTeacherForDB(teachers);
        }
        public void AddSubject_Teacher(List<Subject_Teacher> list)
        {
            teacherDal.AddSubject_Teacher(list);
        }
        public Teachers IdToTeacher(Teachers t)
        {
            return teacherDal.IdToTeacher(t);
        }
        public List<Teachers> GetTeacherList()
        {
            return teacherDal.GetTeacherList();
        }
        public int AddTeacher(Teachers teachers)
        {
            return teacherDal.AddTeacher(teachers);
        
        }
        public Boolean IsExist(Teachers teachers)
        {
            return teacherDal.IsExist(teachers);
        }
    }
}
