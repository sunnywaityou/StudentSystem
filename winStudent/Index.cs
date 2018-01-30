using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace winStudent
{
    public partial class Index : Form
    {
        Bll.v_students bll = new Bll.v_students();
        Model.v_students model = new v_students();
        public string Xuehao;
        public string AdminName;
        public Index()
        {
            InitializeComponent();
        }
        public Index(string loginId,string adminName)
        {
            AdminName = adminName.ToString();
            InitializeComponent();
            toolStripStatusLabel2.Text = AdminName + "同学";
            Xuehao = loginId;
        }

        private void 信息查询ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            stu_query sq = new stu_query(Xuehao);
            sq.MdiParent = this;
            sq.Dock = DockStyle.Fill;
            sq.Show();
        }

        private void 信息修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stu_query sq = new stu_query(Xuehao, 2);
            sq.MdiParent = this;
            sq.Dock = DockStyle.Fill;
            sq.Show();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login lo = new Login();
            lo.Show();
            this.Close();
        }
    }
}
