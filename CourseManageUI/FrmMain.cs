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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            //显示登录的用户名
            this.lblCurrentUser.Text = Program.currentTeacher.TeacherName;
            //用户的权限处理  也将在这里处理
        }
        #region 窗体移动

        private Point mouseOff;//鼠标移动位置变量
        private bool leftFlag;//标签是否为左键
        private void Frm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y); //得到变量的值
                leftFlag = true;                  //点击左键按下时标注为true;
            }
        }
        private void Frm_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);  //设置移动后的位置
                Location = mouseSet;
            }
        }
        private void Frm_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;//释放鼠标后标注为false;
            }
        }


        #endregion


        // 窗体嵌入 通用方法

        public void OpenForm(Form childForm)
        {
            foreach (Control item in this.panelRight.Controls)
            {
                if (item is Form)
                {
                    ((Form)item).Close();
                }

            }

            childForm.TopLevel = false;// 将子窗体设置成非顶级控件
            childForm.FormBorderStyle = FormBorderStyle.None;//边框设为无
            childForm.Parent = this.panelRight;//设置窗体容器
            childForm.Dock = DockStyle.Fill;//随着容器的大小自动调整窗体大小
            childForm.Show();

        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //添加课程
        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmAddCourse());// 创建子窗体

        }

        private void btnCourseManage_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmCourseManage());// 创建子窗体
        }

        private void btnModifyPwd_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmModifyPwd());// 创建子窗体
        }
    }
}
