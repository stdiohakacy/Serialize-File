using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testtest
{
    [Serializable]
    public class Student
    {
        public int code { get; set; }
        public string name { get; set; }
        public DateTime DOB { get; set; }
        public override string ToString()
        {
            return code + "-" + name + "-" + DOB.ToString("dd/MM/yyyy");
        }
    }
}
