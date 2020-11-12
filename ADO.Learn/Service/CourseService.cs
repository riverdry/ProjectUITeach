using System.Data.SqlClient;

namespace ADO.Learn
{
    /// <summary>
    /// 课程数据访问类
    /// </summary>
    public class CourseService
    {
        /// <summary>
        /// 添加课程（通过实体类作为参数）
        /// </summary>
        /// <param name="course"></param>
        /// <returns></returns>
        public int AddCourse(Course course)
        {
            // 定义SQL语句，解析实体类数据
            string sql = "insert into Course(CourseName,CourseContent,ClassHour,Credit,CategoryId,TeacherId)";
            sql += $"values('{course.CourseName}', '{course.CourseContent}', '{course.ClassHour}', '{course.Credit}', '{course.CategoryId}', '{course.TeacherId}')";
            return SQLHelper.Update(sql);

        }
        /// <summary>
        /// 修改课程（通过实体类作为参数）
        /// </summary>
        /// <param name="course"></param>
        /// <returns></returns>
        public int UpdateCourse(Course course)
        {
            string sql = $"update Course set CourseName = '{course.CourseName}',CourseContent = '{course.CourseContent}'where CourseId = {course.CourseId}";
            return SQLHelper.Update(sql);
        }

        /// <summary>
        ///删除课程 （通过实体类参数）
        /// </summary>
        /// <param name="course"></param>
        /// <returns></returns>
        public int DeleteCourse(Course course)
        {
            string sql = $"delete from Course where CourseId = {course.CourseId}";
            return SQLHelper.Update(sql);
        }


        /// <summary>
        /// 返回课程总数
        /// </summary>
        /// <returns></returns>
        public object GetCourseCount()
        {
            string sql = "select count(*) as 课程总数 from Course";
            return SQLHelper.GetSingleResult(sql);
        }

        
        public SqlDataReader QueryCourseById()
        {

        }
    }
}
