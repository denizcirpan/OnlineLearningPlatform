using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Assignment : BaseEntity
    {
        public Assignment()
        {
            isActive = true;
            isDeleted = false;
            creationTime = DateTime.Now;
        }

        [Key]
        public int assignmentId { get; set; }
        public int CourseID { get; set; }
        public int title { get; set; }
        public int description { get; set; }
        public int dueDate { get; set; }
    }
}
