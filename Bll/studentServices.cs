using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;

namespace Bll
{
    public class studentServices
    {
        private readonly Dal.studentServices dal = new Dal.studentServices();
        private Model.SysAdmin model1 = new SysAdmin();
        private Dal.studentServices dal2 = new Dal.studentServices();
        private Model.student model2 = new student();
        /// <summary>
        /// 是否存在记录
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Model.SysAdmin Exits(SysAdmin model)
        {
            model1 = dal.isExits(model);
            return model1;
        }
        /// <summary>
        /// 更新学生个人信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Update(Model.student model)
        {
            return dal2.Update(model);
        }
        /// <summary>
        /// 删除一条记录
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(int id)
        {
            return dal2.Delete(id);
        }
        /// <summary>
        /// 添加一条记录
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Add(Model.student model)
        {
            return dal2.Add(model);
        }
    }
}
