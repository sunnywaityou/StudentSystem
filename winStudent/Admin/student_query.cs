using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace winStudent.Admin
{
    public partial class student_query : Form
    {
        Bll.v_students bll = new Bll.v_students();
        Dal.v_students dal = new Dal.v_students();
        Model.v_students model = new Model.v_students();
        private DataSet ds = null;
        DataSet ds2 = new DataSet();
        public student_query()
        {
            InitializeComponent();
            getStudents();
        }
        /// <summary>
        /// 获取所有学生信息
        /// </summary>
        private void getStudents()
        {
            ds = bll.getModels();
            dgv_studentList.DataSource = null;
            if (ds.Tables[0].Rows.Count > 0)
            {
                dgv_studentList.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("没有学生信息记录");
            }
        }
        //查询
        private void btn_query_Click(object sender, EventArgs e)
        {
            string num = tbx_Num.Text.Trim();
            string name = tbx_Name.Text.Trim();
            if (tbx_Num.Text != "" || tbx_Name.Text != "")
            {
                DataTable dt = ds.Tables[0];
                string expression = "xuehao = " + num;
                string sortOrder = "xuehao DESC";
                DataRow[] dr = dt.Select(expression, sortOrder);
                DataTable dt2 = dt.Clone();
                dt2.Rows.Add(dr);
                BindingSource bs = new BindingSource();
                bs.DataSource = dt2;
                dgv_studentList.DataSource = dt2;
            }
        }
        //修改
        private void btn_edit_Click(object sender, EventArgs e)
        {

        }
        //删除
        private void btn_delete_Click(object sender, EventArgs e)
        {

        }
    }
}
