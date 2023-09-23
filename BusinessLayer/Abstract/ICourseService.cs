using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICourseService
    {
        List<Course> GetList();
        void CourseAdd(Course course);
        Course GetByID(int id);
        void CourseChangeStatus(Course course);
        void CourseUpdate(Course course);
        void CourseDelete(Course course);
    }
}
