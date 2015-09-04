﻿using Globalization.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Globalization.Controllers
{
    public class HomeController : Controller
    {
        private static List<Demo> list = new List<Demo>();

        public ActionResult Index()
        {
            return View(list);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Demo model)
        {
            if (ModelState.IsValid)
            {
                list.Add(model);
                return RedirectToAction("Index");
            }
            return View();
        }

    }
}
