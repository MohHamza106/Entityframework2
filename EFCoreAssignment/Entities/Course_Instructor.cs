using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAssignment.Entities
{
    internal class Course_Instructor
    {
        public int Ins_Id { get; set; }
        public int Crs_Id { get; set; }
        public string? Evalute { get; set; }
        public Course Course { get; set; }
        public Instructor Instructor { get; set; }

    }
}
