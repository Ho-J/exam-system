using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P.Model;
using P.DAL;
using System.Data;

namespace P.BLL
{
    public class ExamSubjectDalServer
    {
        ExamSubjuectDal examSubjuectDal = new ExamSubjuectDal();
        BaoKaoDal baokao = new BaoKaoDal();
        public List<ExamSubject> IdToSubject(Teachers t)
        {
            return examSubjuectDal.IdToSubject(t);
        }
        public DataTable DetailsSubjectDataTable(BaoKao baoKao)
        {
            return examSubjuectDal.DetailsSubjectDataTable(baoKao);
        }
        public void updateCheck(List<Major> list, List<CheckGrade> LC, ExamSubject examSubject, Boolean r1, Boolean r2)
        {
            examSubjuectDal.updateCheck(list, LC, examSubject,r1,r2);
        }
        public List<Major> examSubjectNoToGetCheckMajor(ExamSubject examSubject)
        {
            return examSubjuectDal.examSubjectNoToGetCheckMajor(examSubject);
        }
        public Boolean ExistMajor(Major major)
        {
            return examSubjuectDal.ExistMajor(major);
        }
        public int AddMajor(Major major)
        {
            return examSubjuectDal.AddMajor(major);
        }

        //筛选此科目的grade约束 

        public List<CheckGrade> examSubjectNoToGetCheckGrade(ExamSubject examSubject)
        {
            return examSubjuectDal.examSubjectNoToGetCheckGrade(examSubject);
        }

        //添加考试科目报名约束，需要先插入考试科目
        public void AddMajors(List<Major> list, List<CheckGrade> LC, ExamSubject examSubject)
        {
            examSubjuectDal.AddMajors(list, LC, examSubject);
        }
        public List<CheckGrade> getCheckGrade(ExamSubject e)
        {
            return examSubjuectDal.getCheckGrade(e);
        }
        public List<Major> getCheckMajor(ExamSubject e)
        {
            return examSubjuectDal.getCheckMajor(e);
        }
         public List<DetailsSubject> DetailsSubject(BaoKao baoKao)
        {
            return examSubjuectDal.DetailsSubject(baoKao);
        }
        //添加考试科目
        public int AddSubject(ExamSubject examSubject)
        {
            return examSubjuectDal.AddSubject(examSubject);
        }
        //删除考试科目
        public int DeletSubject(ExamSubject examSubject)
        {
            return examSubjuectDal.DeletSubject(examSubject);
        }
        //查询可报名的考试，排除已报考
        public List<ExamSubject> NotBKtable(BaoKao baoKao)
        {
            return examSubjuectDal.NotBKtable(baoKao);
        }
        //查找学生已报考的考试科目
        public List<ExamSubject> BKtable(BaoKao baoKao)
        {
           
            
            return examSubjuectDal.BKtable(baoKao);
        }
        //编号查找考试科目
        public ExamSubject GetSubject(ExamSubject examSubject)
        {


            return examSubjuectDal.GetSubject(examSubject);
        }
        public int InsertBK(BaoKao baoKao)
        {
            return baokao.InsertBK(baoKao);
        }
        public int DeletBK(BaoKao baoKao)
        {
            return baokao.DeletBK(baoKao);
        }
        public List<ExamSubject> GetTable()
        {
            return examSubjuectDal.GetTable();
        }

        public int UpdateExamSubject(ExamSubject examSubject)
        {
            return examSubjuectDal.UpdateExamSubject(examSubject);
        }
        public BaoKao SelectIdAndEid(BaoKao baoKao)
        {
            return baokao.SelectIdAndEid(baoKao);
        }
        public int UpdateBaoKao(BaoKao baoKao)
        {
            return examSubjuectDal.UpdateBaoKao(baoKao);
        }
    }
}
