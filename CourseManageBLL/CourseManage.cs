using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseManageDAL;
using CourseManageModels;

namespace CourseManageBLL //命名空间
{
    public class CourseManage // 类名称
    {
        // 创建相应数据访问类
        private CourseService courseService = new CourseService();

        // 创建与数据访问类相似的方法 并返回数据访问类对应的方法的调用
        public int AddCourse(Course course)
        {
            return courseService.AddCourse(course);
        }
        /// <summary>
        /// 根据多个查询条件动态组合查询
        /// </summary>
        /// <param name="categoryId">课程分类编号</param>
        /// <param name="courseName">课程名称</param>
        /// <returns></returns>
        public List<Course> QueryCourse(int categoryId, string courseName)
        {
            return courseService.QueryCourse(categoryId, courseName);
        }
        /// <summary>
        /// 修改课程对象
        /// </summary>
        /// <param name="course"></param>
        /// <returns></returns>
        public int ModifyCourse(Course course)
        {
            return courseService.ModifyCourse(course);
        }
    }
}
