using Dal;
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
using Bll;

namespace winStudent
{
    public partial class Login : Form
    {
        public Bll.studentServices bll = new Bll.studentServices();
        public Model.SysAdmin mSysAdmin = new SysAdmin();
        public Login()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_login_Click(object sender, EventArgs e)
        {
            string user = tbxUser.Text.Trim();
            string pwd = tbxPwd.Text.Trim();
            if (user != "" && pwd != "")
            {
                SysAdmin objAdmin = new SysAdmin()
                {
                    LoginId = user,
                    LoginPwd = pwd
                };
                mSysAdmin = bll.Exits(objAdmin);
                if (mSysAdmin != null)
                {
                    Index ind = new Index(mSysAdmin.LoginId, mSysAdmin.AdminName);
                    this.Hide();
                    ind.Show();
                }
                else
                {
                    MessageBox.Show("登录失败！");
                }
            }
            else
            {
                MessageBox.Show("用户名或密码不能为空！");
            }
        }
        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
