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
        Bll.studentServices bll2 = new Bll.studentServices();
       
        private DataSet ds = null;
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
            dgv_studentList.DataSource = null;
            getStudents();
            string num = tbx_Num.Text.Trim();
            string name = tbx_Name.Text.Trim();
            if (tbx_Num.Text != "" || tbx_Name.Text != "")
            {
                DataTable dt = ds.Tables[0];
                var item = ds.Tables[0].AsEnumerable();
                var query = from a in item where (a.Field<string>("xuehao") == num || a.Field<string>("name") == name) select a; //linq查询
                if(query.ToList().Count == 0)
                {
                    MessageBox.Show("无该记录");
                }
                else
                {
                    dgv_studentList.DataSource = query.AsDataView();
                }
            }
            else
            {
                dgv_studentList.DataSource = ds.Tables[0];
            }
        }
        //修改
        private void btn_edit_Click(object sender, EventArgs e)
        {
            if(dgv_studentList.SelectedRows.Count > 0)
            {
                int a = dgv_studentList.CurrentRow.Index;
                string xuehao = dgv_studentList.Rows[a].Cells[0].Value.ToString();
                stu_query se = new stu_query(xuehao, 2);
                se.Show();
            }
            else
            {
                MessageBox.Show("请选择记录");
            }
        }
        //删除
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if(dgv_studentList.SelectedRows.Count>0)
            {
                DialogResult result = MessageBox.Show("确认删除？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Cancel) return;
                else
                {
                    int a = dgv_studentList.CurrentRow.Index;
                    int id = Convert.ToInt32(dgv_studentList.Rows[a].Cells[0].Value);
                    if (bll2.Delete(id) == true)
                    {
                        MessageBox.Show("删除成功！", "提示");
                        getStudents();
                    }
                    else
                    {
                        MessageBox.Show("删除失败！", "提示");
                    }
                }
            }
        }
    }
}
