using System;
using System.Data;
//引用需要的命名空间
using System.Data.SqlClient;

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
            // ExecuteReader();
            //ExecuteInsertByHelper();
            //ExecuteSingleResultByHelper();
            // ExecuteReaderByHelper();
            //AddCourse();
            //DeleteCourse();
            //UpdateCourse();
            GetCourseCount();
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

        #region 通过通用SQLHelper类简化CRUD操作
        static void ExecuteInsertByHelper()
        {
            string sql = "insert into Course(CourseName,CourseContent,ClassHour,Credit,CategoryId,TeacherId)";
            sql += "values('。Net上位机开发', '上位机开发课程的王牌', '10', '3', '10002', '10002')";
            int result = SQLHelper.Update(sql);
            Console.WriteLine(result);

        }
        static void ExecuteSingleResultByHelper()
        {
            string sql = "select count(*) as 课程总数 from Course";
            Object result = SQLHelper.GetSingleResult(sql);
            Console.WriteLine(result);
        }
        static void ExecuteReaderByHelper()
        {


            string sql = "select CourseName,CourseContent,ClassHour from Course where CourseId<10050 ";

            SqlDataReader result = SQLHelper.GetReader(sql);

            //判断是否有查询结果，来决定输出数据

            while (result.Read())
            {
                Console.WriteLine($"{result["CourseName"]}\t{result["CourseContent"]}\t{result["ClassHour"]}");
            }

            result.Close();

        }

        #endregion

        #region 通过实体类传递数据
        // 添加课程
        static void AddCourse()
        {
            Console.WriteLine("请输入课程名称");
            Course course = new Course()
            {
                CourseName = Console.ReadLine(),
                CourseContent = "通过实体类传递数据",
                ClassHour = 500,
                CategoryId = 10001,
                TeacherId = 10001,
                Credit = 5
            };
            int result = new CourseService().AddCourse(course);

            Console.WriteLine("受影响的行数=" + result);
        }

        // 修改课程
        static void UpdateCourse()
        {
            Console.WriteLine("请输入要更新的课程ID");
            Course course = new Course()
            {
                CourseId = Convert.ToInt32(Console.ReadLine()),
                CourseName = "UpdateCourse",
                CourseContent = "更新功能测试",
                ClassHour = 500,
                CategoryId = 10001,
                TeacherId = 10001,
                Credit = 5
            };
            int result = new CourseService().UpdateCourse(course);
            Console.WriteLine("受影响的行数=" + result);
        }
        // 通过课程ID删除课程
        static void DeleteCourse()
        {
            Console.WriteLine("请输入要删除课程的课程ID");
            Course course = new Course()
            {
                CourseId = Convert.ToInt32(Console.ReadLine())
            };
            int result = new CourseService().DeleteCourse(course);

            Console.WriteLine("受影响的行数=" + result);
        }

        // 返回课程总数
        static void GetCourseCount()
        {
            Console.WriteLine(new CourseService().GetCourseCount());
        }
        #endregion
    }
}
