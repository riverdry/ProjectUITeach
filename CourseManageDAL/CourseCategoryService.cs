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
    /// 课程分类访问类
    /// </summary>
    public class CourseCategoryService
    {
        public List<CourseCategory> GetCourseCategories()
        {
            string sql = "select CategoryName,CategoryId from CourseCategory";
            SqlDataReader sqlDataReader = SQLHelper.GetReader(sql);

            List<CourseCategory> courseCategories = new List<CourseCategory>();
            while (sqlDataReader.Read())
            {
                courseCategories.Add(new CourseCategory() { 
                    CategoryId = (int)sqlDataReader["CategoryId"],
                    CategoryName = sqlDataReader["CategoryName"].ToString(),              
                });
            }
            sqlDataReader.Close();
            return courseCategories;
        }
    }
}
