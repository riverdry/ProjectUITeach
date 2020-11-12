using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Models;
namespace BLL
{
    public class CourseManager
    {
        private CourseService courseService = new CourseService();

        public int AddCourse(Course course)
        {
            return courseService.AddCourse(course);
        }
        public int UpdateCourse(Course course)
        {
            return courseService.UpdateCourse(course);
        }
        public int DeleteCourse(Course course)
        {
            return courseService.DeleteCourse(course);
        }
        public object GetCourseCount( )
        {
            return courseService.GetCourseCount();
        }
        public List<Course> QueryCourseById(int courseId )
        {
            return courseService.QueryCourseById(courseId);
        }
    }
}
