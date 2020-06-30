using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P.Model
{
    public class Students
    {
       public string id { get; set; }
       public string name { get; set; }
       public string pwd { get; set; }
        public Nullable<Int32> state { get; set; }
        public string grade { get; set; }
        public string major { get; set; }
        public  byte[] img{ get; set; }
        public string academy { get; set; }
        public string emil { get; set; }
        public string tel { get; set; }
        public string imgUal { get; set; }
    }
}
