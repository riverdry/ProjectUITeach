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
    }
}
