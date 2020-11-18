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
        private CourseManage courseManage = new CourseManage();
        private List<Course> addedCourse = new List<Course>();//用来缓存添加的课程
        public FrmAddCourse()
        {
            InitializeComponent();
            // 动态填充课程分类下拉框
            this.cbbCategory.DataSource = categoryManage.GetCourseCategories();
            this.cbbCategory.DisplayMember = "CategoryName";//显示值
            this.cbbCategory.ValueMember = "CategoryId"; // 保存到数据库中外键值，用于程序获取对应值

            // 设置dgv表中是否自动生成的列
            this.dgvCourseList.AutoGenerateColumns = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // 保存到数据库
        private void btnSaveToDB_Click(object sender, EventArgs e)
        {
            //1.数据校验  按照项目实际需求填写
            //TODO

            //数据封装
            Course newCourse = new Course()
            {
                CourseName = this.txtCourseName.Text.Trim(),
                CourseContent = this.txtCourseContent.Text.Trim(),
                ClassHour = Convert.ToInt32(this.txtClassHour.Text.Trim()),
                Credit = Convert.ToInt32(this.txtCredit.Text.Trim()),
                CategoryId =Convert.ToInt32( this.cbbCategory.SelectedValue),
                TeacherId = Program.currentTeacher.TeacherId,
                CategoryName = this.cbbCategory.Text.Trim()

            };
            // 调用后台提交保存
            courseManage.AddCourse(newCourse);

            // 保存到列表，并设置DGV的数据源
            addedCourse.Add(newCourse);
            this.dgvCourseList.DataSource = null;//如果不清空，多次添加后不显示
            this.dgvCourseList.DataSource = this.addedCourse;
            this.lblCount.Text = Convert.ToString(this.addedCourse.Count);
            if (this.ckbAutoClear.Checked == true)
            {
                this.txtClassHour.Text = null;
                this.txtCourseContent.Text = null;
                this.txtCourseName.Text = null;
                this.txtCredit.Text = null;
            }
            


            // 自动清除文本框


        }
    }
}
