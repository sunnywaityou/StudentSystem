using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using Model;
using System.Text;
using Maticsoft.DBUtility;

namespace Dal
{
    public class studentServices
    {
        DataSet ds = null;
        /// <summary>
        /// 查询学生个人信息
        /// </summary>
        /// <param name="objstu"></param>
        /// <returns></returns>
        public student studentQuery(student objstu)
        {
            string sql = "select xuehao,name,age,hobby,zhuanye,xueli from t_student where xuehao='{0}'";
            sql = string.Format(sql, objstu.xuehao);
            ds = SqlHelper.getDataSet(sql, "t_student");
            return objstu;
        }
        /// <summary>
        /// 是否存在用户
        /// </summary>
        /// <returns></returns>
        public Model.SysAdmin isExits(SysAdmin model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select AdminName from t_Admin");
            strSql.Append(" where LoginId=@user");
            strSql.Append(" and LoginPwd=@pwd");
            SqlParameter[] parameter =
            {
                new SqlParameter("@user",SqlDbType.VarChar,50),
                new SqlParameter("@pwd",SqlDbType.NVarChar,50)
            };
            parameter[0].Value = model.LoginId;
            parameter[1].Value = model.LoginPwd;

            Model.SysAdmin model1 = new SysAdmin();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameter);

            if (ds.Tables[0].Rows.Count > 0)
            {
                model.LoginId = parameter[0].Value.ToString();
                model.LoginPwd = parameter[1].Value.ToString();
                model.AdminName = ds.Tables[0].Rows[0][0].ToString();
            }
            else
            {
                model = null;
            }
            return model;
        }
        /// <summary>
        /// 更新学生个人信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Update(Model.student model)
        {
            StringBuilder sqlstr = new StringBuilder();
            sqlstr.Append("update t_student set");
            sqlstr.Append(" xuehao=@xuehao,");
            sqlstr.Append(" name=@name,");
            sqlstr.Append(" age=@age,");
            sqlstr.Append(" hobby=@hobby,");
            sqlstr.Append(" zhuanye=@zhuanye,");
            sqlstr.Append(" xueli=@xueli");
            sqlstr.Append(" where xuehao=@xuehao");
            SqlParameter[] parameters =
            {
                new SqlParameter("@xuehao", SqlDbType.VarChar,50),
                new SqlParameter("@name", SqlDbType.VarChar,50),
                new SqlParameter("@age", SqlDbType.VarChar,50),
                new SqlParameter("@hobby", SqlDbType.VarChar,50),
                new SqlParameter("@zhuanye", SqlDbType.VarChar,50),
                new SqlParameter("@xueli", SqlDbType.VarChar,50),
            };
            parameters[0].Value = model.xuehao;
            parameters[1].Value = model.name;
            parameters[2].Value = model.age;
            parameters[3].Value = model.hobby;
            parameters[4].Value = model.zhuanye;
            parameters[5].Value = model.xueli;

            int rows = DbHelperSQL.ExecuteSql(sqlstr.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}