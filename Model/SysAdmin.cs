using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Model
{
    public class SysAdmin
    {
        public string LoginId { get; set; }
        public string LoginPwd { get; set; }
        public string AdminName { get; set; }
        public int roleID { get; set; }
    }
}