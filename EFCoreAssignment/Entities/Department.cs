using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAssignment.Entities
{
    internal class Department
    {
     
        public int Id { get; set; } // by convension PK , 1 ... 1
        public string Name { get; set; } // nvarchar
        public int? InstructorId { get; set; } // FK
        public Instructor Manager { get; set; }
        public DateTime HiringDate { get; set; } 

        public ICollection<Student> Students { get; set; } = new HashSet<Student>();

       public ICollection<Instructor> ContainInstructors { get; set; } = new HashSet<Instructor>();

    }
}
