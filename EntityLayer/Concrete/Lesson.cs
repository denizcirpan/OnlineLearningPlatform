using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Lesson
    {
        [Key] // Primary Key
        public int LessonID { get; set; }

        [ForeignKey("Resource")] // Foreign Key
        public int ResourceID { get; set; }

        public Resource Resource { get; set; }
        public ICollection<Question> Questions { get; set; }
    }
}
