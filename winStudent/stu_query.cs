using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winStudent
{    
    public partial class stu_query : Form
    {
        Bll.v_students bll = new Bll.v_students();
        Model.v_students model = new Model.v_students();
        Bll.studentServices bll2 = new Bll.studentServices();
        Model.student model2 = new Model.student();
        public string Xuehao;
        public int ID;
        public stu_query()
        {
            InitializeComponent();
            this.Text = "学生添加";
            this.btn_close.Text = "添加";
        }
        public stu_query(string xuehao)
        {
            Xuehao = xuehao;
            InitializeComponent();
            getStudents();// 获取学生信息
        }
        public stu_query(string xuehao, int id)
        {
            ID = id;
            InitializeComponent();
            Xuehao = xuehao;
            getStudents();// 获取学生信息
            this.Text = "信息修改";
            this.btn_close.Text = "确认修改";
            this.tbx_name.Enabled = true;
            this.tbx_age.Enabled = true;
            this.tbx_zhuanye.Enabled = true;
            this.tbx_xueli.Enabled = true;
            this.tbx_hobby.Enabled = true;
        }
        /// <summary>
        /// 获取学生信息
        /// </summary>
        public void getStudents()
        {
            if(Xuehao != null)
            {
                model = bll.getModel(Xuehao);
                this.tbx_xuehao.Text = model.Xuehao;
                this.tbx_name.Text = model.Name;
                this.tbx_age.Text = model.Age;
                this.tbx_zhuanye.Text = model.Zhuanye;
                this.tbx_xueli.Text = model.Xueli;
                this.tbx_hobby.Text = model.Hobby;
            }
        }
        
        /// <summary>
        /// 关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_close_Click(object sender, EventArgs e)
        {
            model2.name = tbx_name.Text.Trim();
            model2.xuehao = tbx_xuehao.Text.Trim();
            model2.zhuanye = tbx_zhuanye.Text.Trim();
            model2.xueli = tbx_xueli.Text.Trim();
            model2.age = tbx_age.Text.Trim();
            model2.hobby = tbx_hobby.Text.Trim();

            if (ID>0)
            {               
                if (bll2.Update(model2) == true)
                {
                    MessageBox.Show("修改成功！", "提示");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("修改失败！", "提示");
                }
            }
            else
            {
                if(bll2.Add(model2) > 0)
                {
                    MessageBox.Show("添加成功！", "提示");

                }
                else
                {
                    MessageBox.Show("添加失败！", "提示");
                }
                //this.Close();
            }
        }
    }
}
