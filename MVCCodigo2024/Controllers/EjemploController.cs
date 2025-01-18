using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCodigo2024.Controllers
{
    public class EjemploController : Controller
    {
        // GET: Ejemplo
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Mensaje()
        {
            return View();
        }
        public ActionResult Nombres()
        {
            return View();
        }
    }
}