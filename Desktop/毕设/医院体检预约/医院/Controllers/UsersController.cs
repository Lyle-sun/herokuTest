﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace 医院.Controllers
{
    public class UsersController : Controller
    {
        //
        // GET: /Users/
        DBA.BLL.Users bll = new DBA.BLL.Users();
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
            ViewData["DepName"] = new SelectList(select1, "Value", "Text", "");
            if (string.IsNullOrEmpty(ID))
            {
                DBA.Model.Users model = new DBA.Model.Users();
                return View(model);
            }
            else
            {
                return View(bll.GetModel(Convert.ToInt32(ID)));
            }

        }

        [HttpPost]
        public ActionResult Edit(DBA.Model.Users model)
        {
            bll.Edit(model);
            return RedirectToAction("UsersManage");

        }

        [HttpPost]
        public JsonResult Del(string ID)
        {
            return Json(bll.Delete(Convert.ToInt32(ID)));

        }

        public ActionResult UsersManage(Conris.DBA.ViewModel.UsersSearch model)
        {
            return View(model);
        }

        public PartialViewResult UsersSearch(Conris.DBA.ViewModel.UsersSearch model)
        {
            return PartialView(model);
        }

        public PartialViewResult UsersList(Conris.DBA.ViewModel.UsersSearch model)
        {
            return PartialView(bll.SearchProject(model));
        }

    }
}
