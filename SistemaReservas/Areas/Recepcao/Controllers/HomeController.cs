using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaReservas.Areas.Recepcao.Controllers
{
    public class HomeController : Controller
    {
        // GET: Recepcao/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}