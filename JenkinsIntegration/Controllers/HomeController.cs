﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JenkinsIntegration.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Descrição da página.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page." + "teste lala";

            return View();
        }
    }
}
