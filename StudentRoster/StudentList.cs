using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace StudentRoster
{
    internal class StudentList
    {
        public List<Student> StudentLists { get; set; } = new List<Student>();
        public object ID { get; internal set; }
    }
}
