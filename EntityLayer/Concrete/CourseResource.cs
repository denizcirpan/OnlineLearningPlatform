using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class CourseResource
    {
        [Key] // Primary Key
        public int CourseResourceID { get; set; }

        [ForeignKey("Course")] // Foreign Key
        public int CourseID { get; set; }

        [ForeignKey("Resource")] // Foreign Key
        public int ResourceID { get; set; }

        [MaxLength(50)] // Max Length 50 karakter
        public string ResourceType { get; set; }

        [MaxLength(1000)] // Max Length 1000 karakter
        public string Content { get; set; }

        public Course Course { get; set; }
        public Resource Resource { get; set; }
    }
}
