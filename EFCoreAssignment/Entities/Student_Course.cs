using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAssignment.Entities
{
    [PrimaryKey(nameof(Std_Id),nameof(Crs_Id))]
    internal class Student_Course
    {
        public int Std_Id { get; set; } 
        public int Crs_Id { get; set; }
        public int Grade { get; set; }
        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}
