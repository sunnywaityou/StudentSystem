using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Maticsoft.DBUtility;

namespace Dal
{
    public class v_students
    {
        /// <summary>
        /// 根据学号获取学生个人信息
        /// </summary>
        /// <param name="xuehao"></param>
        /// <returns></returns>
        public Model.v_students getModel(string xuehao)
        {
            StringBuilder sqlstr = new StringBuilder();
            sqlstr.Append("select xuehao, name, age, hobby, zhuanye, xueli");
            sqlstr.Append(" from v_students");
            sqlstr.Append(" where xuehao = @xuehao");
            SqlParameter[] parameters =
            {
                new SqlParameter("@xuehao",SqlDbType.VarChar,50)
            };
            parameters[0].Value = xuehao;
            Model.v_students model = new Model.v_students();
            DataSet ds = DbHelperSQL.Query(sqlstr.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return model = null;
            }
        }
        /// <summary>
        /// 获取学生个人信息
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        public Model.v_students DataRowToModel(DataRow row)
        {
            Model.v_students model = new Model.v_students();
            if(row != null)
            {
                if(row["Xuehao"] != null)
                {
                    model.Xuehao = row["Xuehao"].ToString();
                }
                if(row["Name"] != null)
                {
                    model.Name = row["Name"].ToString();
                }
                if(row["Age"] != null)
                {
                    model.Age = row["Age"].ToString();
                }
                if(row["Hobby"] != null)
                {
                    model.Hobby = row["Hobby"].ToString();
                }
                if(row["Zhuanye"] != null)
                {
                    model.Zhuanye = row["Zhuanye"].ToString();
                }
                if(row["Xueli"] != null)
                {
                    model.Xueli = row["Xueli"].ToString();
                }
                //if (row["roleName"] != null)
                //{
                //    model.Xueli = row["roleName"].ToString();
                //}
            }
            return model;
        }
        /// <summary>
        /// 获取学生表信息
        /// </summary>
        /// <returns></returns>
        public DataSet getModels()
        {
            StringBuilder sqlstr = new StringBuilder();
            sqlstr.Append("select xuehao, name, age, hobby, zhuanye, xueli, roleName");
            sqlstr.Append(" from v_students");
            DataSet ds = DbHelperSQL.Query(sqlstr.ToString());
            if(ds.Tables[0].Rows.Count > 0)
            {
                return ds;
            }
            else
            {
               return ds = null;
            }
        }
    }
}
