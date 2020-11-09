using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//引用需要的命名空间
using System.Data.SqlClient;
using System.Data;
//using System.Data;
namespace ADO.Learn
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExecuteInsert();
            //ExecuteUpdate();
            //ExecuteDelete();
            // ExecuteSingleResult();
            ExecuteReader();
        }

        //插入数据

        static void ExecuteInsert()
        {
            string connString = "server=.;DataBase=CourseManageDB;Uid=sa;Pwd=newu";
            //【1】 创建连接对象
            SqlConnection conn = new SqlConnection(connString);
            //【2】创建Command对象

            string sql = "insert into Course(CourseName,CourseContent,ClassHour,Credit,CategoryId,TeacherId)";
                sql += "values('。Net上位机开发', '上位机开发课程的王牌', '10', '3', '10002', '10002')";
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

        }
        static void ExecuteUpdate()
        {
            string connString = "server=.;DataBase=CourseManageDB;Uid=sa;Pwd=newu";
            //【1】 创建连接对象
            SqlConnection conn = new SqlConnection(connString);
            //【2】创建Command对象

            string sql = "update Course set CourseName = 'ADO学习',CourseContent = 'ADO.NET基础学习'where CourseId = 10003";
            SqlCommand sqlCmd = new SqlCommand(sql, conn);
            //【3】 打开链接
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                Console.WriteLine("更新连接成功");
            }

            //【4】执行操作（下面这个方法只能用于执行insert update delete 操作，不能执行select）

            int result = sqlCmd.ExecuteNonQuery();

            Console.WriteLine("受影响的行数=" + result);

            //【5】关闭连接
            conn.Close();
            if (conn.State == ConnectionState.Closed)
            {
                Console.WriteLine("更新关闭成功");
            }

        }
        static void ExecuteDelete()
        {
            string connString = "server=.;DataBase=CourseManageDB;Uid=sa;Pwd=newu";
            //【1】 创建连接对象
            SqlConnection conn = new SqlConnection(connString);
            //【2】创建Command对象

            string sql = "delete from Course where CourseId = 10002";
            SqlCommand sqlCmd = new SqlCommand(sql, conn);
            //【3】 打开链接
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                Console.WriteLine("更新连接成功");
            }

            //【4】执行操作（下面这个方法只能用于执行insert update delete 操作，不能执行select）

            int result = sqlCmd.ExecuteNonQuery();

            Console.WriteLine("受影响的行数=" + result);

            //【5】关闭连接
            conn.Close();
            if (conn.State == ConnectionState.Closed)
            {
                Console.WriteLine("更新关闭成功");
            }

        }
        static void ExecuteSingleResult()
        {
            string connString = "server=.;DataBase=CourseManageDB;Uid=sa;Pwd=newu";
            //【1】 创建连接对象
            SqlConnection conn = new SqlConnection(connString);
            //【2】创建Command对象

            string sql = "select count(*) as 课程总数 from Course";
            SqlCommand sqlCmd = new SqlCommand(sql, conn);
            //【3】 打开链接
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                Console.WriteLine("更新连接成功");
            }

            //【4】执行操作（下面这个方法 一般执行的都是查询，但是有时候也用于执行insert update delete 操作，不能执行select）

            object result = sqlCmd.ExecuteScalar();

            Console.WriteLine("查询结果=" + result);

            //【5】关闭连接
            conn.Close();
            if (conn.State == ConnectionState.Closed)
            {
                Console.WriteLine("更新关闭成功");
            }

        }
        static void ExecuteReader()
        {
            string connString = "server=.;DataBase=CourseManageDB;Uid=sa;Pwd=newu";
            //【1】 创建连接对象
            SqlConnection conn = new SqlConnection(connString);
            //【2】创建Command对象

            string sql = "select CourseName,CourseContent,CourseHour from Course where CourseId<10050 ";
            SqlCommand sqlCmd = new SqlCommand(sql, conn);
            //【3】 打开链接
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                Console.WriteLine("更新连接成功");
            }

            //【4】执行操作（下面这个方法 一般执行的都是查询，但是有时候也用于执行insert update delete 操作，不能执行select）

            SqlDataReader result = sqlCmd.ExecuteReader();

            //判断是否有查询结果，来决定输出数据

            while (result.Read())
            {
                Console.WriteLine($"{result["CourseName"]}\t{result["CourseContent"]}\t{result["CourseHour"]}");
            }

            result.Close();

            //【5】关闭连接
            conn.Close();
            if (conn.State == ConnectionState.Closed)
            {
                Console.WriteLine("更新关闭成功");
            }

        }
    }
}
