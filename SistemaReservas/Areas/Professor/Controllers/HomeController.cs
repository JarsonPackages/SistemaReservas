﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaReservas.Areas.Professor.Controllers
{
    public class HomeController : Controller
    {
        // GET: Professor/Default
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult SelecionaDia()
        {
            return PartialView();
        }
        

    }
}