using Bll;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using winStudent.Admin;

namespace winStudent
{
    public partial class Index_Admin : Form
    {
        Model.v_students model = new Model.v_students();
        public string Xuehao;
        public string AdminName;
        public Index_Admin()
        {
            InitializeComponent();
        }
        public Index_Admin(string loginId, string adminName)
        {
            AdminName = adminName.ToString();
            InitializeComponent();
            toolStripStatusLabel2.Text = AdminName;
            Xuehao = loginId;
        }

        private void 学生查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            student_query sq = new student_query();
            sq.MdiParent = this;
            sq.Dock = DockStyle.Fill;
            sq.Show();
        }

        private void 学生添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            student_add sa = new student_add();
            sa.Show();
        }

        private void 信息修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            student_edit se = new student_edit();
            se.Show();
        }
    }
}
