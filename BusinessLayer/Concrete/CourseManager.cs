using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CourseManager : ICourseService
    {
        ICourseDAL _courseDAL;
        public CourseManager(ICourseDAL courseDAL)
        {
            _courseDAL = courseDAL;
        }

        public void CourseAdd(Course course)
        {
            _courseDAL.Insert(course);
        }

        public void CourseChangeStatus(Course course)
        {
            if (course.isActive == true)
            {
                course.isActive = false;
            }
            else if (course.isActive == false)
            {
                course.isActive = true;
            }
        }

        public void CourseDelete(Course course)
        {
            _courseDAL.Delete(course);
        }

        public void CourseUpdate(Course course)
        {
            _courseDAL.Update(course);
        }

        public Course GetByID(int id)
        {
            return _courseDAL.Get(x => x.CourseID == id);
        }

        public List<Course> GetList()
        {
            return _courseDAL.List();
        }
    }
}
