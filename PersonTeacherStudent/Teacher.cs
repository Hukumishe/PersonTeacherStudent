using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonTeacherStudent
{
    class Teacher : Person
    {
        public List<Student> students { get; set; }
    }
}
