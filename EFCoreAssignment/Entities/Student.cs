using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAssignment.Entities
{
    // poco class dont have any behavours,methods,dont inmplement interfaces,inheritance 
    // just props

    
    internal class Student
    {
        // 2 approaches of mapping
        // code first (from code (classes , generate tables)
        // database first (from database ( tables , generate classes)

        //Ef support 4 ways of mapping:
        //1.By convension
        //2.Data annontation
        //3.Fluent Apis
        //4.Configuration class <summary>

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }  // by convension --> PK , identity column start with 1 and increment with 1 
        public string FName { get; set; } // by convension --> nvarchar(max) , not nullable
        public string? LName { get; set; }  // by convension --> nvarchar , allow null --> nullable
        public string? Address { get; set; } 
        public int Age { get; set; } 
        public int? DepartmentId { get; set; } // by convention --> FK
         public Department Department { get; set; }
        public ICollection< Student_Course> Student_Courses { get; set; } = new HashSet<Student_Course>();

        public override string ToString()
        {
            return $"id : {Id}  ,fname : {FName}  ,age : {Age}  , address : {Address}";
        }

    }
}
