using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P.Model;
using P.DAL;

namespace P.BLL
{
    public class StudentsDalServer
    {
        public Boolean login(Students students)
        {
            StudentsDal studentsHelp = new StudentsDal();
            return studentsHelp.login(students);
        }
        public int Add(Students students)
        {
            StudentsDal studentsHelp = new StudentsDal();
            return studentsHelp.Add(students);
        }
        //按照学号查早值
        public Students SelectId(Students students)
        {
            StudentsDal studentsDal = new StudentsDal();
            return studentsDal.SelectId(students);
        }

        public int Update(Students students)
        {
            StudentsDal studentsDal = new StudentsDal();
            return studentsDal.Update(students);
        }
        public int UpdateM(Students students)
        {
            StudentsDal studentsDal = new StudentsDal();
            return studentsDal.UpdateM(students);
        }
        public List<Students> GetTable()
        {
            StudentsDal studentsDal = new StudentsDal();
            return studentsDal.GetTable();
        }
    }
   
}
