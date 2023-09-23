using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class CourseAssignment
    {
        [Key] // Primary Key
        public int CourseAssignmentID { get; set; }

        [ForeignKey("Assignment")] // Foreign Key
        public int AssignmentID { get; set; }

        [ForeignKey("Course")] // Foreign Key
        public int CourseID { get; set; }

        [MaxLength(100)] // Max Length 100 karakter
        public string Title { get; set; }

        [MaxLength(500)] // Max Length 500 karakter
        public string Description { get; set; }

        public int OverallScore { get; set; }

        public Assignment Assignment { get; set; }
        public Course Course { get; set; }
    }
}
