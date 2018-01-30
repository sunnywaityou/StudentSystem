using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class v_students
    {
        /// <summary>
        /// 学号
        /// </summary>
        private string _xuehao;
        public string Xuehao
        {
            set { _xuehao = value; }
            get { return _xuehao; }
        }
        /// <summary>
        /// 姓名
        /// </summary>
        private string _name;
        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }
        /// <summary>
        /// 年龄
        /// </summary>
        private string _age;
        public string Age
        {
            set { _age = value; }
            get { return _age; }
        }
        /// <summary>
        /// 爱好
        /// </summary>
        private string _hobby;
        public string Hobby
        {
            set { _hobby = value; }
            get { return _hobby; }
        }
        /// <summary>
        /// 专业
        /// </summary>
        private string _zhuanye;
        public string Zhuanye
        {
            set { _zhuanye = value; }
            get { return _zhuanye; }
        }
        /// <summary>
        /// 学历
        /// </summary>
        private string _xueli;
        public string Xueli
        {
            set { _xueli = value; }
            get { return _xueli; }
        }
    }
}
