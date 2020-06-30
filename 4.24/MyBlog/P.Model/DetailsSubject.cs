using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P.Model
{

    //select s.name, s.grade, ApplyTime, Score, Estate from baokao b, Students s where b.Sid= s.id and b.eid= 2
    public class DetailsSubject
    {
        public string name { get; set; }
        public string grade { get; set; }
        public DateTime ApplyTime { get; set; }
        public int Score { get; set; }
        public int Estate { get; set; }
        public string sid { get; set; }


    }
}
