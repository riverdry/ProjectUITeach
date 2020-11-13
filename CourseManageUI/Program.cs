﻿using CourseManageModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace CourseManageUI
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //显示登录窗体
            FrmAdminLogin frmLogin = new FrmAdminLogin();
            DialogResult loginResult =  frmLogin.ShowDialog();

            //根据登录窗体的返回值 确定是否显示主窗体
            if (loginResult == DialogResult.OK)
            {
                Application.Run(new FrmMain());
            }
            else
            {
                Application.Exit();
            }
            
            

        }
        // 全局变量

        public static Teacher currentTeacher = null;
    }
}
