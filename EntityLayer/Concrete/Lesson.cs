using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Lesson : BaseEntity
    {
        public Lesson()
        {
            isDeleted = false;
            isActive = true;
            creationTime = DateTime.Now;
        }

        [Key] // Primary Key
        public int LessonID { get; set; }

        public ICollection<Resource> Resources { get; set; }
        public ICollection<Question> Questions { get; set; }
    }
}
