using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace 医院.Controllers
{
    public class ApplyController : Controller
    {
        //
        // GET: /Job/
        DBA.BLL.Apply bll = new DBA.BLL.Apply();
        DBA.BLL.Users ubll = new DBA.BLL.Users();
        DBA.BLL.ExaminationItme xbll = new DBA.BLL.ExaminationItme();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create(string ID)
        {
            if (string.IsNullOrEmpty(ID))
            {
                DBA.Model.Apply model = new DBA.Model.Apply();

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
                DBA.Model.Apply model = new DBA.Model.Apply();

                return View(model);
            }
            else
            {
                return View(bll.GetModel(Convert.ToInt32(ID)));
            }

        }

        public ActionResult DCreate(string ID)
        {
            if (string.IsNullOrEmpty(ID))
            {
                DBA.Model.Apply model = new DBA.Model.Apply();

                return View(model);
            }
            else
            {
                return View(bll.GetModel(Convert.ToInt32(ID)));
            }

        }

        public ActionResult Detail(string ID)
        {
            if (string.IsNullOrEmpty(ID))
            {
                DBA.Model.Apply model = new DBA.Model.Apply();

                return View(model);
            }
            else
            {
                return View(bll.GetModel(Convert.ToInt32(ID)));
            }

        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(DBA.Model.Apply model)
        {
            bll.Edit(model);
            return RedirectToAction("ApplyManage");

        }

        [HttpPost]
        public JsonResult Del(string ID)
        {
            return Json(bll.Delete(Convert.ToInt32(ID)));

        }

        [HttpPost]
        public JsonResult SX(string ID)
        {
            DBA.Model.Apply model = bll.GetModel(Convert.ToInt32(ID));
            model.Major = "失约";
            bll.Update(model);
            DBA.Model.Users user = ubll.GetModel(Convert.ToInt32(model.Str1));
            user.Str2 = (Convert.ToInt32(user.Str2)+1).ToString();
            ubll.Update(user);
            return Json(true);

        }

        [HttpPost]
        public JsonResult GetJson()
        {
            return Json(xbll.GetExaminationItmeJsonList());

        }

        [HttpPost]
        public JsonResult GetNum(string Time)
        {
            List<DBA.Model.Apply> list = bll.GetModelList(" Str2='"+Time+"'");

            return Json(list.Count);

        }

        public ActionResult ApplyManage(Conris.DBA.ViewModel.ApplySearch model)
        {
            return View(model);
        }

        public PartialViewResult ApplySearch(Conris.DBA.ViewModel.ApplySearch model)
        {
            TempData["Num"] = bll.GetModelList(" Str2 like '"+model.Str2+"%'").Count;
            TempData["Tol"] = bll.GetModelList(" Str2 like '" + model.Str2 + "%' and Major='审核通过'").Count;
            return PartialView(model);
        }

        public PartialViewResult ApplyList(Conris.DBA.ViewModel.ApplySearch model)
        {
            return PartialView(bll.SearchProject(model));
        }
    }
}
