using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseManageModels;
using CourseManageBLL;

namespace CourseManageUI
{
    public partial class FrmAddCourse : Form
    {
        // 添加业务逻辑的对象
        private CourseCategoryManage categoryManage = new CourseCategoryManage();
        public FrmAddCourse()
        {
            InitializeComponent();
            // 动态填充课程分类下拉框

            this.cbbCategory.DataSource = categoryManage.GetCourseCategories();
            this.cbbCategory.DisplayMember = "CategoryName";//显示值
            this.cbbCategory.ValueMember = "CategoryId"; // 保存到数据库中外键值


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
