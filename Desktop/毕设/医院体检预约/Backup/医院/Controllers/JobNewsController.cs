using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace 医院.Controllers
{
    public class JobNewsController : Controller
    {
        //
        // GET: /Job/
        DBA.BLL.JobNews bll = new DBA.BLL.JobNews();
        
        DBA.BLL.Department cbll = new DBA.BLL.Department();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create(string ID)
        {
          
            List<SelectListItem> select2 = new List<SelectListItem>();
            select2.Add(new SelectListItem
            {
                Text = "请选择",
                Value = ""
            });
            List<DBA.Model.Department> list2 = cbll.GetModelList("");
            for (int i = 0; i < list2.Count; i++)
            {
                select2.Add(new SelectListItem
                {
                    Text = list2[i].DepartmentName,
                    Value = list2[i].DepartmentName
                });
            };
            ViewData["Department"] = new SelectList(select2, "Value", "Text", "");
            if (string.IsNullOrEmpty(ID))
            {
                DBA.Model.JobNews model = new DBA.Model.JobNews();
                model.CreateName = DateTime.Now.ToShortDateString();
                return View(model);
            }
            else
            {
                return View(bll.GetModel(Convert.ToInt32(ID)));
            }

        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(DBA.Model.JobNews model)
        {
            bll.Edit(model);
            return RedirectToAction("JobNewsManage");

        }

        [HttpPost]
        public JsonResult Del(string ID)
        {
            return Json(bll.Delete(Convert.ToInt32(ID)));

        }

        public ActionResult JobNewsManage(Conris.DBA.ViewModel.JobNewsSearch model)
        {
            return View(model);
        }

        public PartialViewResult JobNewsSearch(Conris.DBA.ViewModel.JobNewsSearch model)
        {
          
            //kecheng
            List<SelectListItem> select2 = new List<SelectListItem>();
            select2.Add(new SelectListItem
            {
                Text = "请选择",
                Value = ""
            });
            List<DBA.Model.Department> list2 = cbll.GetModelList("");
            for (int i = 0; i < list2.Count; i++)
            {
                select2.Add(new SelectListItem
                {
                    Text = list2[i].DepartmentName,
                    Value = list2[i].DepartmentName
                });
            };
            ViewData["Department"] = new SelectList(select2, "Value", "Text", "");
            return PartialView(model);
        }

        public PartialViewResult JobNewsList(Conris.DBA.ViewModel.JobNewsSearch model)
        {
            return PartialView(bll.SearchProject(model));
        }

        public ActionResult NewsDetail(string ID)
        {
            return View(bll.GetModel(Convert.ToInt32(ID)));
        }

    }
}
