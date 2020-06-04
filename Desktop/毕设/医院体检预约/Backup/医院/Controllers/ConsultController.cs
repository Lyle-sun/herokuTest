using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace 医院.Controllers
{
    public class ConsultController : Controller
    {
        //
        // GET: /Consult/
        DBA.BLL.Consult bll = new DBA.BLL.Consult();
        DBA.BLL.Department dbll = new DBA.BLL.Department();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create(string ID)
        {
            //laoshi
            List<SelectListItem> select1 = new List<SelectListItem>();
            select1.Add(new SelectListItem
            {
                Text = "请选择",
                Value = ""
            });
            List<DBA.Model.Department> list = dbll.GetModelList("");
            for (int i = 0; i < list.Count; i++)
            {
                select1.Add(new SelectListItem
                {
                    Text = list[i].DepartmentName,
                    Value = list[i].DepartmentName
                });
            };
            ViewData["ReName"] = new SelectList(select1, "Value", "Text", "");
            if (string.IsNullOrEmpty(ID))
            {
                DBA.Model.Consult model = new DBA.Model.Consult();
                return View(model);
            }
            else
            {
                return View(bll.GetModel(Convert.ToInt32(ID)));
            }

        }

        public ActionResult ZCreate(string ID)
        {
            //laoshi
            List<SelectListItem> select1 = new List<SelectListItem>();
            select1.Add(new SelectListItem
            {
                Text = "请选择",
                Value = ""
            });
            List<DBA.Model.Department> list = dbll.GetModelList("");
            for (int i = 0; i < list.Count; i++)
            {
                select1.Add(new SelectListItem
                {
                    Text = list[i].DepartmentName,
                    Value = list[i].DepartmentName
                });
            };
            ViewData["ReName"] = new SelectList(select1, "Value", "Text", "");
            if (string.IsNullOrEmpty(ID))
            {
                DBA.Model.Consult model = new DBA.Model.Consult();
                return View(model);
            }
            else
            {
                return View(bll.GetModel(Convert.ToInt32(ID)));
            }

        }

        public ActionResult RCreate(string ID)
        {
            if (string.IsNullOrEmpty(ID))
            {
                DBA.Model.Consult model = new DBA.Model.Consult();
                return View(model);
            }
            else
            {
                return View(bll.GetModel(Convert.ToInt32(ID)));
            }

        }

        [HttpPost]
        public ActionResult ZEdit(DBA.Model.Consult model)
        {
            bll.ZEdit(model);
            return RedirectToAction("ConsultManage");

        }

        [HttpPost]
        public ActionResult Edit(DBA.Model.Consult model)
        {
            bll.Edit(model);
            return RedirectToAction("ConsultManage");

        }

        [HttpPost]
        public JsonResult Del(string ID)
        {
            return Json(bll.Delete(Convert.ToInt32(ID)));

        }

        public ActionResult ConsultManage(Conris.DBA.ViewModel.ConsultSearch model)
        {
            return View(model);
        }

        public PartialViewResult ConsultSearch(Conris.DBA.ViewModel.ConsultSearch model)
        {
            return PartialView(model);
        }

        public PartialViewResult ConsultList(Conris.DBA.ViewModel.ConsultSearch model)
        {
            return PartialView(bll.SearchProject(model));
        }
    }
}
