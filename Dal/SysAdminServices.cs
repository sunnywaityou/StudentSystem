using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using Model;

namespace Dal
{
    public class SysAdminServices
    {
        /// <summary>
        /// 根据账号密码登录
        /// </summary>
        /// <param name="objAdmin"></param>
        /// <returns></returns>
        public SysAdmin AdminLogin(SysAdmin objAdmin)
        {
            string sql = "select AdminName from t_Admin where LoginId = '{0}' and LoginPwd='{1}'";
            sql = string.Format(sql, objAdmin.LoginId, objAdmin.LoginPwd);
            SqlDataReader dr = SqlHelper.GetReader(sql);
            if(dr.Read())
            {
                objAdmin.AdminName = dr["AdminName"].ToString();
            }
            else
            {
                objAdmin = null;
            }
            dr.Close();
            return objAdmin;
        }
        
    }
}