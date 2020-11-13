using CourseManageDAL;
using CourseManageModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManageBLL
{
    /// <summary>
    /// 课程分类 的业务逻辑类
    /// </summary>
    public class CourseCategoryManage
    {
        private CourseCategoryService categoryService = new CourseCategoryService();

        public List<CourseCategory> GetCourseCategories()
        {
            return categoryService.GetCourseCategories();
        }
    }
}
