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
    }
}
