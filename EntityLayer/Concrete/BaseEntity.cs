using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class BaseEntity
    {
        public bool isDeleted { get; set; } 
        public bool isActive { get; set; } 
        public DateTime creationTime { get; set; } 
        public DateTime updatedTime { get; set; } 
    }
}
