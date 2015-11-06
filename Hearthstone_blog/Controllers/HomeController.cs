﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hearthstone_blog.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // get Name from personal account and assign to ViewBag.Name
            ViewBag.Name = "test";
            return View();
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