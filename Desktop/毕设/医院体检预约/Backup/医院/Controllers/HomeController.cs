using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace 医院.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        DBA.BLL.Users bll = new DBA.BLL.Users();
        DBA.BLL.JobNews jbll = new DBA.BLL.JobNews();
        DBA.BLL.Apply abll = new DBA.BLL.Apply();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Detail(string ID)
        {
            return View(jbll.GetModel(Convert.ToInt32(ID)));
        }

        public ActionResult QZDetail(string ID)
        {
            return View(abll.GetModel(Convert.ToInt32(ID)));
        }

        public ActionResult List(Conris.DBA.ViewModel.JobNewsSearch model)
        {
            return View(jbll.SearchProject(model));
        }

        public ActionResult QZList(Conris.DBA.ViewModel.ApplySearch model)
        {
            return View(abll.SearchProject(model));
        }

        public ActionResult CXList(Conris.DBA.ViewModel.JobNewsSearch model)
        {
            return View(jbll.SearchProject(model));
        }
        public ActionResult Regist()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Regist(string LoginName, string LoginPwd)
        {
            string IsLogin = bll.Regist(LoginName, LoginPwd);
            return Json(IsLogin);
        }

        [HttpPost]
        public JsonResult Login(string LoginName, string LoginPwd)
        {
            string IsLogin = bll.Login(LoginName, LoginPwd, false);
            return Json(IsLogin);
        }

        [HttpPost]
        public JsonResult GetIndexNews(string flag, string Category)
        {
            List<DBA.Model.JobNews> List = jbll.GetModelList(Convert.ToInt32(flag), " Category='" + Category + "'", " ID desc");
            return Json(List);
        }


        public ActionResult LogOff()
        {
            bll.LogOut();
            return Redirect("/Home/Login");
        }
    }
}
