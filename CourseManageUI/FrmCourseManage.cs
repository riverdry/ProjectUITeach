using CourseManageBLL;
using CourseManageModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

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

            list.Insert(0, new CourseCategory() { CategoryId = -1, CategoryName = "--请选择--" });

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

            //修改面板动态填充课程分类
            // this.cbbCategory_Modify.DataSource = list;
            this.cbbCategory_Modify.DataSource = new List<CourseCategory>(list);//将前面的集合先复制在做数据源
            this.cbbCategory_Modify.DisplayMember = "CategoryName";
            this.cbbCategory_Modify.ValueMember = "CategoryId";

        }
        //提交查询
        private void btnQuery_Click(object sender, EventArgs e)
        {
            //【1】数据、条件验证,检查复选框的索引
            if ((this.cbbCategory.SelectedIndex == -1 || this.cbbCategory.SelectedIndex == 0) && this.txtCourseName.Text.Trim().Length == 0)

            {
                MessageBox.Show("请至少选择一个查询条件！", "查询提示");
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
            //隐藏修改面板
            this.panelModify.Visible = false;



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

            // 初学者使用方法，循环找到对应结果
            //foreach (var item in this.queryList)
            //{
            //    if (item.CourseId.Equals(courseId))
            //    {
            //        currentCourse = item;
            //        break;
            //    }
            //}


            // LINQ 查询
            currentCourse = (from c in this.queryList where c.CourseId.Equals(courseId) select c).First();
            // 扩展 
            //currentCourse = this.queryList.Where(c => c.CourseId.Equals(courseId)).First();


            // 显示修改面板

            this.txtCourseContent_Modify.Text = currentCourse.CourseContent;
            this.txtCourseName_Modify.Text = currentCourse.CourseName;
            this.txtCourseHour_Modify.Text = currentCourse.ClassHour.ToString();
            this.txtCourseCredit_Modify.Text = currentCourse.Credit.ToString();
            this.lblCourseId.Text = currentCourse.CourseId.ToString();
            this.cbbCategory_Modify.SelectedValue = currentCourse.CategoryId;
            this.panelModify.Visible = true;





        }
        // 保存修改信息
        private void btnSaveToDB_Click(object sender, EventArgs e)
        {
            // 数据验证：对修改的信息检查（待完成）


            //封装对象
            Course modifyCourse = new Course()
            {
                CourseName = this.txtCourseName_Modify.Text.Trim(),
                CourseContent = this.txtCourseContent_Modify.Text.Trim(),
                ClassHour = Convert.ToInt32(this.txtCourseHour_Modify.Text.Trim()),
                Credit = Convert.ToInt32(this.txtCourseCredit_Modify.Text.Trim()),
                CategoryId = Convert.ToInt32(this.cbbCategory_Modify.SelectedValue),
                TeacherId = Program.currentTeacher.TeacherId,//默认用登录用户
                CategoryName = this.cbbCategory_Modify.Text,
                CourseId = Convert.ToInt32(this.lblCourseId.Text)
            };
            // 调用后台  应该添加异常
            courseManage.ModifyCourse(modifyCourse);
            this.panelModify.Visible = false;
            // 同步显示修改后的信息
            Course currentCourse = (from c in this.queryList where c.CourseId.Equals(modifyCourse.CourseId) select c).First();
            currentCourse.CourseName = modifyCourse.CourseName;
            currentCourse.CategoryName = modifyCourse.CategoryName;
            currentCourse.CategoryId = modifyCourse.CategoryId;
            currentCourse.CourseContent = modifyCourse.CourseContent;
            currentCourse.Credit = modifyCourse.Credit;
            currentCourse.ClassHour = modifyCourse.ClassHour;

            this.dgvCourseList.Refresh();
        }
        // 删除课程
        private void btnDeleteCourse_Click(object sender, EventArgs e)
        {
            if (this.dgvCourseList.CurrentRow == null)
            {
                MessageBox.Show("请选择需要修改的课程", "修改提示");
                return;
            }
            //获取当前选中行

            int courseId = (int)this.dgvCourseList.CurrentRow.Cells["CourseId"].Value;

            // 删除前确认
           DialogResult dialogResult = MessageBox.Show($"您确认要删除编号为：{courseId}的课程吗","删除确认",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (dialogResult ==DialogResult.Cancel)
            {
                return;
            }
            // 从后台删除
            int deleteCount = courseManage.DeleteCourse(new Course() { CourseId = courseId });

            //使用LINQ查询或者扩展方法

            this.queryList.Remove(this.queryList.Where(c => c.CourseId == courseId).First());

            this.dgvCourseList.DataSource = null;
            this.dgvCourseList.DataSource = this.queryList;
            this.lblCount.Text = this.queryList.Count.ToString();



        }
        //关闭当前窗口
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
