using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace CourseManageDAL
{
    class SQLHelper
    {
        private static string connString = ConfigurationManager.ConnectionStrings["connString"].ToString();
        /// <summary>
        /// 执行Insert、update、delete的类型语句
        /// </summary>
        /// <param name="sql">普通sql语句或带参数的sql语句</param>
        /// <param name="sqlParameter">参数数组</param>
        /// <returns></returns>
        public static int Update(string sql,SqlParameter[] sqlParameter = null)
        {
            // using System.Data.SqlClient  建立与数据库的连接
            SqlConnection conn = new SqlConnection(connString);

            // using System.Data  对连接的数据库 执行T-SQL语句或存储过程
            SqlCommand cmd = new SqlCommand(sql, conn);
            // 判断是否存在sql参数数组，如果有 添加到SqlCommand中
            if(sqlParameter != null)
            {
                cmd.Parameters.AddRange(sqlParameter);
            }
            try
            {
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("执行public  int Update(string sql)方法时异常："+ ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        /// <summary>
        /// 执行单一结果查询
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static object GetSingleResult(string sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                return cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {

                throw new Exception("执行public object GetSingleResult(string sql)方法时异常：" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        /// <summary>
        /// 执行一个结果集的查询
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static SqlDataReader GetReader(string sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {

                throw new Exception("执行 public static SqlDataReader GetReader(string sql)方法时异常：" + ex.Message);
            }          
        }
    }
}
