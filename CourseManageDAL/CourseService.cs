using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

using CourseManageModels;
namespace CourseManageDAL
{
    /// <summary>
    /// 课程访问类
    /// </summary>
    public class CourseService
    {
       
        public int AddCourse(Course course)
        {
            //定义sql语句,使用带参数的SQL语句
            string sql = "insert into Course(CourseName,CourseContent,ClassHour,Credit,CategoryId,TeacherId)";
            sql += "values(@CourseName,@CourseContent,@ClassHour,@Credit,@CategoryId,@TeacherId)";

            //封装sql语句参数
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@CourseName",course.CourseName),
                new SqlParameter("@CourseContent",course.CourseContent),
                new SqlParameter("@ClassHour",course.ClassHour),
                new SqlParameter("@Credit",course.Credit),
                new SqlParameter("@CategoryId",course.CategoryId),
                new SqlParameter("@TeacherId",course.TeacherId),
            };


            //执行SQL语句
            return SQLHelper.Update(sql,sqlParameters);
        }
         
    }
}
