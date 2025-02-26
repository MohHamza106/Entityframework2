using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAssignment.Entities
{
    internal class Instructor
    {
        [Key]
        // [DatabaseGenerated(DatabaseGeneratedOption.None)]
         [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        [Column(TypeName ="varchar")]
        public string Name { get; set; }

        [EmailAddress]
        public string? Email { get; set; }
        public double? Bouns { get; set; }        // by convension --> float , nullable

        [Column(TypeName = "Money")]

        public double Salary { get; set; }        // by convension --> float , not nullable
        public double? HourRate { get; set; }     // by convension --> float , nullable
        public int DeptId { get; set; }
        public Department ContainDepartment { get; set; }
        public Department ManageDepartment { get; set; }
        public ICollection< Course_Instructor> Course_Instructors { get; set; } = new HashSet< Course_Instructor>();


    }
}
