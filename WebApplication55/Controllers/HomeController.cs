﻿using DXC.Ecommerce.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication55.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            EcomRepo obj = new EcomRepo();
            obj.GetProducts();
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