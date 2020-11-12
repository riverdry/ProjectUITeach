using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using BLL;

namespace MyProjectUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Course> coursesList = new CourseManager().QueryCourseById(10020);

            foreach (var item in coursesList)
            {
                Console.WriteLine(item.CourseId + "\t" + item.CourseName + "\t" + item.ClassHour + "\t");
            }
        }
    }
}
