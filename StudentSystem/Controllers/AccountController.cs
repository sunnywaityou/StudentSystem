using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Model;
using Dal;

namespace StudentSystem.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 用户登录的控制器
        /// </summary>
        /// <returns></returns>
        public ActionResult AdminLogin()
        {
            //【1】获取数据
            SysAdmin objAdmin = new SysAdmin()
            {
                LoginId = Request.Params["loginId"],
                LoginPwd = Request.Params["loginPwd"]
            };
            //【2】业务处理
            objAdmin = new SysAdminServices().AdminLogin(objAdmin);
            if (objAdmin != null)
            {
                Session.Add("xuehao", objAdmin.LoginId);
                ViewData["info"] = "";
                return View("../Home/Index");
            }
            else
            {
                ViewData["info"] = "用户名或密码错误！";
                return View();
            }
            //【3】返回数据

        }
    }
}