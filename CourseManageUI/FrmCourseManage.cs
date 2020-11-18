using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseManageBLL;
using CourseManageModels;

namespace CourseManageUI
{
    public partial class FrmCourseManage : Form

    {
        private CourseCategoryManage categoryManage = new CourseCategoryManage();
        private CourseManage courseManage = new CourseManage();
        private List<Course> queryList = null;// 创建一个集合用来缓存查询结果，便于修改
        public FrmCourseManage()
        {
            InitializeComponent();
            // 在集合元素中插入一个空白

            List<CourseCategory> list = categoryManage.GetCourseCategories();

            list.Insert(0, new CourseCategory() { CategoryId = -1,CategoryName = "--请选择--" });

            //动态填充课程分类
            this.cbbCategory.DataSource = list;
            this.cbbCategory.DisplayMember = "CategoryName";
            this.cbbCategory.ValueMember = "CategoryId";
            this.cbbCategory.SelectedIndex = -1;
            // 禁止自动生成列
            this.dgvCourseList.AutoGenerateColumns = false;
            
            //修改面板隐藏
            this.panelModify.Visible = false;
            this.btnModifyCourse.Enabled = false;//禁用修改按钮
            this.btnDeleteCourse.Enabled = false;//禁用删除按钮
        }
        //提交查询
        private void btnQuery_Click(object sender, EventArgs e)
        {
            //【1】数据、条件验证,检查复选框的索引
            if ((this.cbbCategory.SelectedIndex == -1 || this.cbbCategory.SelectedIndex ==0)&&this.txtCourseName.Text.Trim().Length == 0)

            {
                MessageBox.Show("请至少选择一个查询条件！","查询提示");
                return;
            }
            //[2]提交查询,使用三元运算符简化

            int categoryId = this.cbbCategory.SelectedIndex == -1 ? -1 : Convert.ToInt32(this.cbbCategory.SelectedValue);

            queryList = courseManage.QueryCourse(categoryId, this.txtCourseName.Text.Trim().ToString());//查询

            if (queryList.Count == 0)//如果没有结果 清空上一次的查询结果
            {
                this.lblCount.Text = "0";
                this.dgvCourseList = null;
                MessageBox.Show("未找到相关课程", "查询结果");
            }
            else// 重新绑定查询结果
            {
                this.dgvCourseList.DataSource = queryList;
                this.lblCount.Text = this.dgvCourseList.RowCount.ToString();
                this.btnModifyCourse.Enabled = true;//启用修改按钮
                this.btnDeleteCourse.Enabled = true;//启用删除按钮
            }




        }
        //显示修改信息
        private void btnModifyCourse_Click(object sender, EventArgs e)
        {
            if (this.dgvCourseList.CurrentRow == null)
            {
                MessageBox.Show("请选择需要修改的课程", "修改提示");
                return;
            }
            //获取当前选中行对用的课程ID
            int courseId = (int)this.dgvCourseList.CurrentRow.Cells["CourseId"].Value;
            // 根据课程ID从集合中查询课程对象
            Course currentCourse = null;
            foreach (var item in this.queryList)
            {
                if (item.CourseId.Equals(courseId))
                {
                    currentCourse = item;
                    break;
                }
            }
       
        }
    }
}
