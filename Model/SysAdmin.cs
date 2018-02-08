using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Model
{
    public class SysAdmin
    {
        [Required]
        [Display(Name = "用户名")]
        public string LoginId { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "密码")]
        public string LoginPwd { get; set; }
        public string AdminName { get; set; }
        public int roleID { get; set; }
        [Display(Name = "记住我？")]
        public bool RemenberMe { get; set; }
    }
}