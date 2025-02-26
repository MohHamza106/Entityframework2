using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAssignment.Entities
{
    internal class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }
        public int? Topic_Id { get; set; }
        public Topic Topic { get; set; }
        public ICollection< Student_Course> Student_Courses { get; set; } = new HashSet< Student_Course>();
        public ICollection< Course_Instructor> Course_Instructors { get; set; } = new HashSet<Course_Instructor>(); 

    }
}
