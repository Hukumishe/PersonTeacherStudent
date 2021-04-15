using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonTeacherStudent
{
    class StudentWithAdviser : Student
    {
        public Teacher teacher { get; set; }

        public override string ToString()
        {
            return "Это учитель";
        }
    }
}
