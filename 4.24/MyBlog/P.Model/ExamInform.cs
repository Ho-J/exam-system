using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P.Model
{
    public class ExamInform
    {
        public int id { get; set; }
        public string title { get; set; }
        public string source { get; set; }
        public string informText { get; set; }
        public DateTime creatTime { get; set; }
        public string  creatId { get; set; }
    }
}
