using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using System.Configuration;
namespace ADO.Learn
{
    /// <summary>
    /// 通用数据库访问类
    /// 
    /// 封装变化的 抽取不变的。变化的作为参数，不变的作为方法体
    /// </summary>
    class SQLHelper
    {
        // private static string connString = "server=.;DataBase=CourseManageDB;Uid=sa;Pwd=newu";
        //从配置文件读取数据库连接字符串
        private static string connString = ConfigurationManager.ConnectionStrings["connString"].ToString();
        public static int Update(string sql)
        {
            
            //【1】 创建连接对象
            SqlConnection conn = new SqlConnection(connString);
            //【2】创建Command对象
            SqlCommand sqlCmd = new SqlCommand(sql, conn);
            //【3】 打开链接
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                Console.WriteLine("连接成功");
            }

            //【4】执行操作（下面这个方法只能用于执行insert update delete 操作，不能执行select）

            int result = sqlCmd.ExecuteNonQuery();

            Console.WriteLine("受影响的行数=" + result);

            //【5】关闭连接
            conn.Close();
            if (conn.State == ConnectionState.Closed)
            {
                Console.WriteLine("关闭成功");
            }
            return result;

        }
    }
}
