using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class User
    {
        [Key] // Primary Key
        public int UserID { get; set; }

        [MaxLength(50)] // Max Length 50 karakter
        public string FirstName { get; set; }

        [MaxLength(50)] // Max Length 50 karakter
        public string LastName { get; set; }

        [MaxLength(100)] // Max Length 100 karakter
        public string Email { get; set; }

        [MaxLength(50)] // Max Length 50 karakter
        public string Password { get; set; }

        [MaxLength(20)] // Max Length 20 karakter
        public string Role { get; set; }

        public ICollection<CourseEnrollment> CourseEnrollments { get; set; }
    }
}
