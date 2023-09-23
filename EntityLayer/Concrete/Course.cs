using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Course : BaseEntity
    {
        public Course()
        {
            isDeleted = false;
            isActive = true;
            creationTime = DateTime.Now;
        }

        [Key] // Primary Key
        public int CourseID { get; set; }

        [MaxLength(100)] // Max Length 100 karakter
        public string Title { get; set; }

        [MaxLength(500)] // Max Length 500 karakter
        public string Description { get; set; }

        [MaxLength(50)] // Max Length 50 karakter
        public string Category { get; set; }

        [MaxLength(200)] // Max Length 200 karakter
        public string ImageURL { get; set; }

        public int OverallScore { get; set; }

        [ForeignKey("InstructorID")] // Foreign Key
        public virtual User Instructor { get; set; }
        public int InstructorID { get; set; }

        public ICollection<CourseResource> CourseResources { get; set; }
        public ICollection<CourseAssignment> CourseAssignments { get; set; }
        public ICollection<CourseEnrollment> CourseEnrollments { get; set; }
    }
}
