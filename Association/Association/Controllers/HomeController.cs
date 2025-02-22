﻿using Association.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Association.Controllers
{
    public class HomeController : Controller
    {
        UMSEntities db = new UMSEntities();
        public ActionResult Index()
        {
            var data = db.Departments.ToList();
            return View(data);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}