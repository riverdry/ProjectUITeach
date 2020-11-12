using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
// 读取配置文件的信息
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
        /// <summary>
        /// 执行增删改的方法
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static int Update(string sql)
        {
            
            //【1】 创建连接对象
            SqlConnection conn = new SqlConnection(connString);
            //【2】创建Command对象
            SqlCommand sqlCmd = new SqlCommand(sql, conn);

            try
            {
                //【3】 打开链接
                conn.Open();
                //【4】执行操作（下面这个方法只能用于执行insert update delete 操作，不能执行select）
                return sqlCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("执行方法public static int Update(string sql)发生异常："+ ex.Message);
            }
            finally
            {
                //【5】关闭连接
                conn.Close();
            }
        }


        /// <summary>
        /// 执行单一查询返回的结果
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static object GetSingleResult(string sql)
        {

            //【1】 创建连接对象
            SqlConnection conn = new SqlConnection(connString);
            //【2】创建Command对象
            SqlCommand sqlCmd = new SqlCommand(sql, conn);

            try
            {
                //【3】 打开链接
                conn.Open();
                //【4】执行操作（下面这个方法只能用于执行insert update delete 操作，不能执行select）
                return sqlCmd.ExecuteScalar();
            }
            catch (Exception ex)
            {

                throw new Exception("执行方法public static int Update(string sql)发生异常：" + ex.Message);
            }
            finally
            {
                //【5】关闭连接
                conn.Close();
            }
        }
         
        /// <summary>
        /// 执行返回结果集reader结果
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static SqlDataReader GetReader(string sql)
        {

            //【1】 创建连接对象
            SqlConnection conn = new SqlConnection(connString);
            //【2】创建Command对象
            SqlCommand sqlCmd = new SqlCommand(sql, conn);

            try
            {
                //【3】 打开链接
                conn.Open();
                //【4】执行操作（下面这个方法只能用于执行insert update delete 操作，不能执行select）

                //添加枚举 CommandBehavior.CloseConnection之后，将来reader对象关闭链接会跟随对象的关闭自动关闭
                return sqlCmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {

                throw new Exception("执行方法public static int Update(string sql)发生异常：" + ex.Message);
            }
           // finally //在这个方法里面，绝对不能直接把链接关掉，否则出错
            //{
                //【5】关闭连接
             //   conn.Close();
            //}
        }
    }
}
