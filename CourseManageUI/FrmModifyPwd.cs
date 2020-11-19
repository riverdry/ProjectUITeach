using CourseManageBLL;
using CourseManageModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseManageUI
{
    public partial class FrmModifyPwd : Form
       
    {
        private TeacherManage teacherManage = new TeacherManage();
        public FrmModifyPwd()
        {
            InitializeComponent();
        }
        //退出修改
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //保存密码修改
        private void btnSaveToDB_Click(object sender, EventArgs e)
        {
            // 基础数据验证 非空以及长度验证

            //判断原密码是否正确
            if (!txtCurrentPwd.Text.Trim().Equals(Program.currentTeacher.LoginPwd))
            {
                MessageBox.Show("原密码不正确", "修改提示");
                this.txtCurrentPwd.SelectAll();
                this.txtCurrentPwd.Focus();
                return;
            }
            if (!txtNewPwd.Text.Trim().Equals(txtNewPwdConfirm.Text.Trim()))
            {
                MessageBox.Show("两次输入的新密码不一致", "修改提示");
                return;
            }

            //封装对象

            Teacher teacher = new Teacher()
            {
              TeacherId = Program.currentTeacher.TeacherId,
              LoginPwd = this.txtNewPwd.Text.Trim()
            };

            //调用修改（可以添加异常处理）

            int result = teacherManage.ModifyPwd(teacher);
            
            // 修改成功  就保存到当前用户
            if (result == 1)
            {
                Program.currentTeacher.LoginPwd = this.txtNewPwd.Text.Trim();
                MessageBox.Show("密码修改成功", "成功提示");

            }
            this.Close();
        }
    }
}
