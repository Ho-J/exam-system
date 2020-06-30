using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P.Model
{
    public class BASE_USER
    {
        public int id { get; set; }
        public string name { get; set; }
        public string pwd { get; set; }
        public int jurisdiction { get; set; }//权限等级
    }
}
