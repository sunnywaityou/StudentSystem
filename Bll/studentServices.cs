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
    }
}
