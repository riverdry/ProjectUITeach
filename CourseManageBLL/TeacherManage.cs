using CourseManageDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseManageModels;

namespace CourseManageBLL
{
    public class TeacherManage
    {
        private TeacherService teacherService = new TeacherService();

        public Teacher TeacherLogin(Teacher teacher)
        {
            // 后台登录实现
            teacher = teacherService.TeacherLogin(teacher);

            // 其他业务逻辑


            return teacher;
        }
        /// <summary>
        /// 修改登录密码
        /// </summary>
        /// <param name="teacher"></param>
        /// <returns></returns>
        public int ModifyPwd(Teacher teacher)
        {
            return teacherService.ModifyPwd(teacher);
        }
    }
}
