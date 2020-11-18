using CourseManageModels;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace CourseManageDAL
{
    /// <summary>
    /// 课程访问类
    /// </summary>
    public class CourseService
    {

        #region 添加课程
        /// <summary>
        /// 添加课程
        /// </summary>
        /// <param name="course"></param>
        /// <returns></returns>
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
            return SQLHelper.Update(sql, sqlParameters);
        }
        #endregion

        #region 查询课程
        /// <summary>
        /// 根据多个查询条件动态组合查询
        /// </summary>
        /// <param name="categoryId">课程分类编号</param>
        /// <param name="courseName">课程名称</param>
        /// <returns></returns>
        public List<Course> QueryCourse(int categoryId, string courseName)
        {
            //[1]定义基本的SQL语句
            string sql = "select CourseId,CourseName,CourseContent,ClassHour,Credit,CategoryId,TeacherName,Course.TeacherId from Course";
            sql += " inner join Teacher on Teacher.TeacherId = Course.TeacherId where";
            //[2]定义组合条件
            string whereSql = string.Empty;
            if (categoryId != -1)
            {
                whereSql += " and CategoryId=" + categoryId;
            }
            if (courseName != "")//这个地方没必要检查null，因为我们通过文本框传递的数据永不可能为null
            {
                whereSql += $" and CourseName like'{courseName}%'";
            }

            sql += whereSql.Substring(4);// 把第一个and去掉后组合

            //【3】执行查询
            SqlDataReader sqlDataReader = SQLHelper.GetReader(sql);
            // [4] 封装结果

            List<Course> list = new List<Course>();
            while (sqlDataReader.Read())
            {
                list.Add(new Course()
                {
                    CourseId = (int)sqlDataReader["CourseId"],
                    CourseName = sqlDataReader["CourseName"].ToString(),
                    CourseContent = sqlDataReader["CourseContent"].ToString(),
                    ClassHour = (int)sqlDataReader["ClassHour"],
                    Credit = (int)sqlDataReader["Credit"],
                    CategoryId = (int)sqlDataReader["CategoryId"],
                    TeacherId = (int)sqlDataReader["TeacherId"],
                    TeacherName = sqlDataReader["TeacherName"].ToString(),

                });
            }
            sqlDataReader.Close();
            return list;
            
        }
        #endregion

        #region 修改课程
        /// <summary>
        /// 修改课程对象
        /// </summary>
        /// <param name="course"></param>
        /// <returns></returns>
        public int ModifyCourse(Course course)
        {
            string sql = $"update Course set CourseName=@CourseName,CourseContent=@CourseContent,ClassHour=@ClassHour,Credit=@Credit";
            sql += " where CourseId=@CourseId";
            // 封装sql语句参数
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@CourseContetnt",course.CourseContent),
                new SqlParameter("@CourseName",course.CourseName),
                new SqlParameter("@ClassHour",course.ClassHour),
                new SqlParameter("@Credit",course.Credit),
                new SqlParameter("@CategoryId",course.CategoryId),
                new SqlParameter("@CourseId",course.CourseId)
            
            };
            return SQLHelper.Update(sql, sqlParameters);
        }
        #endregion

    }
}
