using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<CourseResource> CourseResources { get; set; }
        public DbSet<CourseAssignment> CourseAssignments { get; set; }
        public DbSet<StudentCourseAssignment> StudentCourseAssignments { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<CourseEnrollment> CourseEnrollments { get; set; }
    }
}
