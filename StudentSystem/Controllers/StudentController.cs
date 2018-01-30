using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using Model;
using Dal;

namespace StudentSystem.Controllers
{
    public class StudentController : Controller
    {
        
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 回到首页的方法
        /// </summary>
        /// <returns></returns>
        public ActionResult GetStudent()
        {
            return View();
        }
        /// <summary>
        /// 个人信息
        /// </summary>
        /// <returns></returns>
        public ActionResult GetGerenxinxi()
        {
            //【1】获取学生信息
            student objstudent = new student()
            {
                xuehao = Session["xuehao"].ToString(),
                name = Request.Params["name"],
                age = Request.Params["age"],
                hobby = Request.Params["hobby"],
                zhuanye = Request.Params["zhuanye"],
                xueli = Request.Params["xueli"]
            };
            //【2】业务处理
            string sql = "select xuehao,name,age,hobby,zhuanye,xueli from t_student where xuehao='{0}'";
            sql = string.Format(sql, objstudent.xuehao);
            DataSet ds = SqlHelper.getDataSet(sql, "t_student");
            if (ds.Tables[0].Rows.Count != 0)
            {
                ViewData["xuehao"] = objstudent.xuehao =Convert.ToString(ds.Tables[0].Rows[0][0]);
                ViewData["name"] = Convert.ToString(ds.Tables[0].Rows[0][1]);
                ViewData["age"] = Convert.ToString(ds.Tables[0].Rows[0][2]);
                ViewData["hobby"] = Convert.ToString(ds.Tables[0].Rows[0][3]);
                ViewData["zhuanye"] = Convert.ToString(ds.Tables[0].Rows[0][4]);
                ViewData["xueli"] = Convert.ToString(ds.Tables[0].Rows[0][5]);                
                return View("GetGerenxinxi");
            }
            else
            {
                ViewBag.Tishi = "不存在该学生信息";
                return View("GetGerenxinxi");
            }
            //【3】返回数据
        }
        /// <summary>
        /// 质量评价
        /// </summary>
        /// <returns></returns>
        public ActionResult GetZhiliangpingjia()
        {
            return View();
        }
        /// <summary>
        /// 活动报名
        /// </summary>
        /// <returns></returns>
        public ActionResult GetHuodongbaoming()
        {
            Response.Write("<script>alert('暂无活动!');</script>");
            return View("../Home/Index");
        }
        /// <summary>
        /// 信息查询
        /// </summary>
        /// <returns></returns>
        public ActionResult GetXinxichaxun()
        {
            return View();
        }
        /// <summary>
        /// 信息维护
        /// </summary>
        /// <returns></returns>
        public ActionResult GetXinxiweihu()
        {
            return View();
        }
        /// <summary>
        /// 公用信息
        /// </summary>
        /// <returns></returns>
        public ActionResult GetGongyongxinxi()
        {
            return View();
        }
    }
}