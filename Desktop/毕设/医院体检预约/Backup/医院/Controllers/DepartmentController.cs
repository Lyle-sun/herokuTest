using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace 医院.Controllers
{
    public class DepartmentController : Controller
    {
        //
        // GET: /Department/
        DBA.BLL.Department bll = new DBA.BLL.Department();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create(string ID)
        {
            if (string.IsNullOrEmpty(ID))
            {
                DBA.Model.Department model = new DBA.Model.Department();
                return View(model);
            }
            else
            {
                return View(bll.GetModel(Convert.ToInt32(ID)));
            }

        }

        [HttpPost]
        public ActionResult Edit(DBA.Model.Department model)
        {
            bll.Edit(model);
            return RedirectToAction("DepartmentManage");

        }

        [HttpPost]
        public JsonResult Del(string ID)
        {
            return Json(bll.Delete(Convert.ToInt32(ID)));

        }

        public ActionResult DepartmentManage(Conris.DBA.ViewModel.DepartmentSearch model)
        {
            return View(model);
        }

        public PartialViewResult DepartmentSearch(Conris.DBA.ViewModel.DepartmentSearch model)
        {
            return PartialView(model);
        }

        public PartialViewResult DepartmentList(Conris.DBA.ViewModel.DepartmentSearch model)
        {
            return PartialView(bll.SearchProject(model));
        }
    }
}
