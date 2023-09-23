using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class StudentCourseAssignment
    {
        [Key] // Primary Key
        public int StudentCourseAssignmentID { get; set; }

        public int Score { get; set; }
        public DateTime DueDate { get; set; }

        [ForeignKey("Student")] // Foreign Key
        public int? StudentID { get; set; }
        public virtual User Student { get; set; }

        [ForeignKey("CourseAssignment")] // Foreign Key
        public int AssignmentID { get; set; }
        public virtual CourseAssignment CourseAssignment { get; set; }
    }
}
