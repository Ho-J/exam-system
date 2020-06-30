using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P.Model
{
    public class ExamSubject
    {
        public int id { set; get; }
        public string name { set; get; }
        public DateTime ApplyStar { set; get; }
        public DateTime ApplyEnd { set; get; }
        public DateTime ExamEnd { set; get; }
        public DateTime ExamStar { set; get; }
        public string examPlace { set; get; }
        public string detail { set; get; }
        public string classifyName { set; get; }
     


    }
}
