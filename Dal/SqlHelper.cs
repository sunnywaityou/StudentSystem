using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Dal
{
    public class SqlHelper
    {
        private static SqlCommand sqlcmd = new SqlCommand();
        private static SqlConnection sqlconn = new SqlConnection();
        //定义连接字符串
        private static string connString = ConfigurationManager.ConnectionStrings["connString"].ToString();
        #region 1.打开数据库openData
        public static void openData()
        {
            if (sqlconn.State == ConnectionState.Closed)
            {
                sqlconn.ConnectionString = connString;
                sqlcmd.Connection = sqlconn;
                try
                {
                    sqlconn.Open();

                }
                catch (Exception err)
                {
                    throw new Exception(err.Message);
                }
            }
        }
        #endregion

        #region 2.关闭数据库closeData
        public static void closeData()
        {
            if (sqlconn.State == ConnectionState.Open)
            {
                try
                {
                    sqlconn.Close();
                    sqlconn.Dispose();
                    sqlcmd.Dispose();
                }
                catch (Exception err)
                {
                    throw new Exception(err.Message);
                }
            }
        }
        #endregion
        public static SqlDataReader GetReader(string sql)
        {
            SqlConnection sqlConn = new SqlConnection(connString);
            SqlCommand sqlCmd = new SqlCommand(sql, sqlConn);
            try
            {
                sqlConn.Open();
                return sqlCmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception e)
            {
                sqlConn.Close();
                throw e;
            }
        }
        #region 3.执行sql语句excuteSql
        public static void excuteSql(string sql)
        {
            try
            {
                openData();//打开数据库连接
                sqlcmd.CommandText = sql;
                sqlcmd.CommandType = CommandType.Text;//sql语句
                sqlcmd.ExecuteNonQuery();//执行sql语句并返回受影响行数
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
            finally
            {
                closeData();//关闭数据库连接
            }
        }

        #endregion         

        #region 5.获取数据表DataTable
        /// <summary>
        /// 获取数据表
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <returns>DataTable数据表dt</returns>
        public static DataTable getDataTabel(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                //打开数据库
                openData();
                SqlDataAdapter sda = new SqlDataAdapter(sql, connString);
                sda.Fill(dt);
            }
            catch (Exception)
            {
                try
                {
                    closeData();//关闭数据库连接
                }
                catch { }
            }

            return dt;
        }
        #endregion

        #region 6.保存到数据库的数据集DataSet
        /// <summary>
        /// 获取数据集
        /// 创建人：sunny
        /// 创建时间：2017年12月21日09:28:29
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="table">查询的目标表名</param>
        /// <returns>数据集</returns>
        public static DataSet getDataSet(string sql, string table)
        {
            DataSet ds = new DataSet();
            try
            {
                openData();
                sqlcmd.CommandText = sql;
                sqlcmd.CommandType = CommandType.Text;
                SqlDataAdapter dpt = new SqlDataAdapter(sql, connString);//在connString下创建数据适配器
                dpt.Fill(ds, table);//返回添加的行数
            }
            catch (Exception e)
            {
                try
                {
                    closeData();
                }
                catch
                {
                    throw e;
                }
            }
            return ds;
        }
        #endregion
    }
}