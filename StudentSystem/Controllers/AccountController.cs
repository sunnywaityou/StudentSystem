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
        private Bll.studentServices bll = new Bll.studentServices();
        private Model.SysAdmin objmodel = new SysAdmin();
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }
        //GET: /Account/AdminLogin
        public ActionResult AdminLogin()
        {
            return View();
        }

        //POST: /Account/AdminLogin
        [HttpPost]
        public ActionResult AdminLogin(Model.SysAdmin model, string returnUrl)
        {
            //【1】获取数据
            SysAdmin objAdmin = new SysAdmin()
            {
                LoginId = Request.Params["loginId"],
                LoginPwd = Request.Params["loginPwd"],
                RemenberMe = Convert.ToBoolean(Request.Params["RemenberMe"])
            };
            //【2】业务处理
            objmodel = bll.Exits(objAdmin);
            if (objmodel != null)
            {
                FormsAuthentication.SetAuthCookie(model.LoginId, model.RemenberMe);
                int roleId = objmodel.roleID;
                switch (roleId)
                {
                    case 1://管理员
                        return RedirectToAction("Index", "Administrator");
                    case 2://教师
                        break;
                    case 3://学生
                        return RedirectToAction("Index", "Home");
                }
            }
            else
            {
                ModelState.AddModelError("", "用户名或密码错误");
            }
            return View(model);
        }
    }
}