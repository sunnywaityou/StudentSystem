using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class v_students
    {
        private Dal.v_students dal = new Dal.v_students();
        private Model.v_students model = new Model.v_students();
        /// <summary>
        /// 根据学号获取学生个人信息
        /// </summary>
        /// <param name="xuehao"></param>
        /// <returns></returns>
        public Model.v_students getModel(string xuehao)
        {
            model = dal.getModel(xuehao);
            return model;
        }     
        /// <summary>
        /// 获取学生表信息
        /// </summary>
        /// <returns></returns>
        public DataSet getModels()
        {
            DataSet ds = dal.getModels();
            return ds;
        }   
    }
}
